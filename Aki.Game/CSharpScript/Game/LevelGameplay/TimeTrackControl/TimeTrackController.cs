using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x02005B42 RID: 23362
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeTrackController : UiControllerBase
	{
		// Token: 0x06039725 RID: 235301 RVA: 0x0101EF35 File Offset: 0x0101D135
		protected override void OnAddEvents()
		{
			if (!EventSystem.Instance.Has(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
			{
				EventSystem.Instance.Add<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
			}
		}

		// Token: 0x06039726 RID: 235302 RVA: 0x0101EF70 File Offset: 0x0101D170
		protected override void OnRemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
			{
				EventSystem.Instance.Remove(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
			}
		}

		// Token: 0x06039727 RID: 235303 RVA: 0x0101EFAC File Offset: 0x0101D1AC
		protected void SafeRegisterEvents(EntityHandle inEntity)
		{
			if (EventSystem.Instance.HasWithTarget(inEntity.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				return;
			}
			EventSystem.Instance.AddWithTarget(inEntity.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x06039728 RID: 235304 RVA: 0x0101F000 File Offset: 0x0101D200
		protected void SafeUnRegisterEvents(EntityHandle inEntityHandle)
		{
			if (EventSystem.Instance.HasWithTarget(inEntityHandle.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.RemoveWithTarget(inEntityHandle.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
		}

		// Token: 0x06039729 RID: 235305 RVA: 0x0101F052 File Offset: 0x0101D252
		private void CameraViewTargetEnd(float _)
		{
			this.FinishCallback(true);
		}

		// Token: 0x0603972A RID: 235306 RVA: 0x0101F05C File Offset: 0x0101D25C
		protected void OnViewTargetChanged(float blendTime, string cameraName)
		{
			if (cameraName != "MainCamera")
			{
				return;
			}
			if (CameraController.Instance.MainModel.IsToLockOnCameraMode() && this.Callback != null)
			{
				if (blendTime <= 1f)
				{
					TimerSystem.Instance.Delay(new TTimerAction(this.CameraViewTargetEnd), 1000f, null, null, true, 1f);
					return;
				}
				TimerSystem.Instance.Delay(new TTimerAction(this.CameraViewTargetEnd), (float)((long)(blendTime * 1000f)), null, null, true, 1f);
			}
		}

		// Token: 0x0603972B RID: 235307 RVA: 0x0101F0E8 File Offset: 0x0101D2E8
		[NullableContext(2)]
		public void OpenTimeTrackControlView(long entityId, int index, Action<bool> callback = null)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TimeTrackControlView))
			{
				if (callback != null)
				{
					callback(false);
					this.Callback = null;
				}
				return;
			}
			TimeTrackControlModel.Instance.SetCurrentTimeTrackControl(entityId, index);
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			this.SafeRegisterEvents(entity);
			this.Callback = callback;
			this.TimelineTraceStartRequest(entityId, index);
		}

		// Token: 0x0603972C RID: 235308 RVA: 0x0101F148 File Offset: 0x0101D348
		public void HandleTimeTrackControlViewClose()
		{
			this.TimelineTraceExitRequest();
			EntityHandle entity = CreatureModel.Instance.GetEntity(TimeTrackControlModel.Instance.RefEntityId);
			SceneItemReferenceComponent sceneItemReferenceComponent;
			if (entity == null)
			{
				sceneItemReferenceComponent = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				sceneItemReferenceComponent = ((entity2 != null) ? entity2.GetComponent<SceneItemReferenceComponent>() : null);
			}
			SceneItemReferenceComponent sceneItemReferenceComponent2 = sceneItemReferenceComponent;
			if (sceneItemReferenceComponent2 != null)
			{
				sceneItemReferenceComponent2.ForceExitSeqCamera();
			}
			StaticSceneModel.Instance.IsNotAutoExitSceneCamera = false;
			StaticSceneModel.Instance.IsForceKeepUi = false;
		}

		// Token: 0x0603972D RID: 235309 RVA: 0x0101F1A8 File Offset: 0x0101D3A8
		public void TimelineTraceStartRequest(long entityId, int index)
		{
			long creatureDataId = TimeTrackControlModel.Instance.CreatureDataId;
			if (creatureDataId == 0L)
			{
				Log.Instance.Warn(ELogModule.SceneGameplay, ELogAuthor.YZH, "时间控制装置启动请求:当前没有有效的控制实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			Action<IMessage, Net.CallbackStatus> handle = delegate(IMessage msg, Net.CallbackStatus _)
			{
				TimelineTraceStartResponse timelineTraceStartResponse = (TimelineTraceStartResponse)msg;
				if (timelineTraceStartResponse == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneGameplay;
					ELogAuthor author = ELogAuthor.JYS;
					string message = "时间控制装置启动请求:response请求失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityid", entityId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.FinishCallback(false);
					return;
				}
				TimeTrackControlModel.Instance.InitControlInfo(timelineTraceStartResponse);
				StaticSceneModel.Instance.IsNotAutoExitSceneCamera = true;
				StaticSceneModel.Instance.IsForceKeepUi = true;
				if (this.HandleStaticSceneSeq(timelineTraceStartResponse.EntityIds, entityId))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneGameplay;
					ELogAuthor author2 = ELogAuthor.JYS;
					string message2 = "时间控制装置启动请求:HandleStaticSceneSeq成功";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityid", entityId);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				TsInteractionUtils.ClearCurrentOpenViewName();
				this.HandleTimeTrackControlViewClose();
				this.FinishCallback(false);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SceneGameplay;
				ELogAuthor author3 = ELogAuthor.JYS;
				string message3 = "时间控制装置启动请求:HandleStaticSceneSeq失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("entityid", entityId);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			};
			TimelineTraceStartRequest timelineTraceStartRequest = Aki.Protocol.TimelineTraceStartRequest.Create();
			timelineTraceStartRequest.EntityId = creatureDataId;
			timelineTraceStartRequest.Index = index;
			Net.Instance.Call(ERequestMessageId.TimelineTraceStartRequest, timelineTraceStartRequest, handle, 0);
		}

		// Token: 0x0603972E RID: 235310 RVA: 0x0101F224 File Offset: 0x0101D424
		public void TimelineTraceControlRequest(bool inForward)
		{
			long creatureDataId = TimeTrackControlModel.Instance.CreatureDataId;
			if (creatureDataId == 0L)
			{
				Log.Instance.Warn(ELogModule.SceneGameplay, ELogAuthor.YZH, "时间控制装置变更请求:当前没有有效的控制实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			TimeTrackControlModel.Instance.CanUpdated = false;
			Action<IMessage, Net.CallbackStatus> handle = delegate(IMessage msg, Net.CallbackStatus _)
			{
				TimelineTraceControlResponse timelineTraceControlResponse = (TimelineTraceControlResponse)msg;
				TimeTrackControlModel.Instance.CanUpdated = true;
				if (timelineTraceControlResponse == null)
				{
					return;
				}
				if (timelineTraceControlResponse.Code == ErrorCode.ErrTimelineMove)
				{
					EventSystem.Instance.Emit<int, ErrorCode>(EEventName.OnTimeTrackControlUpdate, timelineTraceControlResponse.ControlPoint, timelineTraceControlResponse.Code);
					return;
				}
				if (timelineTraceControlResponse.Code != ErrorCode.Success)
				{
					return;
				}
				int controlPoint = TimeTrackControlModel.Instance.ControlPoint;
				TimeTrackControlModel.Instance.UpdateControlInfo(timelineTraceControlResponse.ControlPoint);
				this.HandleControlEntitySeq(controlPoint, timelineTraceControlResponse.ControlPoint);
				EventSystem.Instance.Emit<int, ErrorCode>(EEventName.OnTimeTrackControlUpdate, timelineTraceControlResponse.ControlPoint, timelineTraceControlResponse.Code);
			};
			TimelineTraceControlRequest timelineTraceControlRequest = Aki.Protocol.TimelineTraceControlRequest.Create();
			timelineTraceControlRequest.Forward = inForward;
			timelineTraceControlRequest.EntityId = creatureDataId;
			Net.Instance.Call(ERequestMessageId.TimelineTraceControlRequest, timelineTraceControlRequest, handle, 0);
		}

		// Token: 0x0603972F RID: 235311 RVA: 0x0101F298 File Offset: 0x0101D498
		public void TimelineTraceExitRequest()
		{
			long creatureDataId = TimeTrackControlModel.Instance.CreatureDataId;
			if (creatureDataId == 0L)
			{
				Log.Instance.Warn(ELogModule.SceneGameplay, ELogAuthor.YZH, "时间控制装置退出请求:当前没有有效的控制实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			TimelineTraceExitRequest timelineTraceExitRequest = Aki.Protocol.TimelineTraceExitRequest.Create();
			timelineTraceExitRequest.EntityId = creatureDataId;
			Net.Instance.Call(ERequestMessageId.TimelineTraceExitRequest, timelineTraceExitRequest, null, 0);
		}

		// Token: 0x06039730 RID: 235312 RVA: 0x0101F2ED File Offset: 0x0101D4ED
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			TimeTrackController.Instance.SafeUnRegisterEvents(handle);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.TimeTrackControlView))
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.TimeTrackControlView, null);
		}

		// Token: 0x06039731 RID: 235313 RVA: 0x0101F31C File Offset: 0x0101D51C
		private bool HandleStaticSceneSeq(IList<long> inIds, long entityId)
		{
			if (inIds == null || inIds.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "时间控制装置启动请求:失败，inId数组长度异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityid", entityId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.FinishCallback(false);
				return false;
			}
			for (int i = inIds.Count - 1; i >= 0; i--)
			{
				long num = inIds[i];
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity != null && entity.Valid)
				{
					WorldEntity entity2 = entity.Entity;
					SceneItemReferenceComponent sceneItemReferenceComponent = (entity2 != null) ? entity2.GetComponent<SceneItemReferenceComponent>() : null;
					if (sceneItemReferenceComponent != null && sceneItemReferenceComponent.ForceEnterSeqCamera())
					{
						TimeTrackControlModel.Instance.RefEntityId = num;
						TimeTrackControlModel.Instance.RefTrueEntityId = entityId;
						return true;
					}
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneGameplay;
			ELogAuthor author2 = ELogAuthor.JYS;
			string message2 = "时间控制装置启动请求:失败，没找到合适的entityId";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityid", entityId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.FinishCallback(false);
			return false;
		}

		// Token: 0x06039732 RID: 235314 RVA: 0x0101F414 File Offset: 0x0101D614
		private void HandleControlEntitySeq(int oldPoint, int newPoint)
		{
			EntityHandle controllerEntity = TimeTrackControlModel.Instance.ControllerEntity;
			if (controllerEntity == null || !controllerEntity.Valid)
			{
				Log.Instance.Warn(ELogModule.SceneGameplay, ELogAuthor.ZYL, "时间控制装置自身表现变化:当前没有有效的控制实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SceneItemTimeTrackControlComponent component = controllerEntity.Entity.GetComponent<SceneItemTimeTrackControlComponent>();
			if (TimeTrackControlModel.Instance.GetConfigStatesCounts() < 2)
			{
				return;
			}
			if (newPoint == oldPoint)
			{
				return;
			}
			if (component != null)
			{
				component.PlayActiveSeqForDuration(newPoint < oldPoint, -1f);
			}
		}

		// Token: 0x06039733 RID: 235315 RVA: 0x0101F48C File Offset: 0x0101D68C
		public void FinishCallback(bool value)
		{
			if (this.Callback != null)
			{
				Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:FinishCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Callback(value);
				this.Callback = null;
			}
		}

		// Token: 0x17006D5B RID: 27995
		// (get) Token: 0x06039734 RID: 235316 RVA: 0x0101F4D0 File Offset: 0x0101D6D0
		public static TimeTrackController Instance
		{
			get
			{
				return TimeTrackController._Instance;
			}
		}

		// Token: 0x06039735 RID: 235317 RVA: 0x0101F4D7 File Offset: 0x0101D6D7
		public static TimeTrackController GetOrCreateInstance()
		{
			if (TimeTrackController._Instance == null)
			{
				TimeTrackController.CreateInstance();
			}
			return TimeTrackController._Instance;
		}

		// Token: 0x06039736 RID: 235318 RVA: 0x0101F4EB File Offset: 0x0101D6EB
		public static bool CreateInstance()
		{
			if (TimeTrackController._Instance != null)
			{
				return true;
			}
			TimeTrackController._Instance = new TimeTrackController();
			return true;
		}

		// Token: 0x06039737 RID: 235319 RVA: 0x0101F501 File Offset: 0x0101D701
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039738 RID: 235320 RVA: 0x0101F503 File Offset: 0x0101D703
		public static void ResetStaticDefaultValue()
		{
			TimeTrackController._Instance = null;
		}

		// Token: 0x06039739 RID: 235321 RVA: 0x0101F50B File Offset: 0x0101D70B
		static TimeTrackController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TimeTrackController.CreateStaticDefaultValue), new Action(TimeTrackController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E4F9 RID: 124153
		[Nullable(2)]
		private Action<bool> Callback;

		// Token: 0x0401E4FA RID: 124154
		[Nullable(2)]
		private static TimeTrackController _Instance;
	}
}
