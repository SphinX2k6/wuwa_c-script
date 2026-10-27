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
	// Token: 0x020069E6 RID: 27110
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeTrackController : UiControllerBase
	{
		// Token: 0x060436E9 RID: 276201 RVA: 0x0107AA81 File Offset: 0x01078C81
		protected override void OnAddEvents()
		{
			if (!EventSystem.Instance.Has(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
			{
				EventSystem.Instance.Add<float, string>(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
			}
		}

		// Token: 0x060436EA RID: 276202 RVA: 0x0107AABC File Offset: 0x01078CBC
		protected override void OnRemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged)))
			{
				EventSystem.Instance.Remove(EEventName.CameraViewTargetChanged, new Action<float, string>(this.OnViewTargetChanged));
			}
		}

		// Token: 0x060436EB RID: 276203 RVA: 0x0107AAF8 File Offset: 0x01078CF8
		protected void SafeRegisterEvents(EntityHandle inEntity)
		{
			if (EventSystem.Instance.HasWithTarget(inEntity.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				return;
			}
			EventSystem.Instance.AddWithTarget(inEntity.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x060436EC RID: 276204 RVA: 0x0107AB4C File Offset: 0x01078D4C
		protected void SafeUnRegisterEvents(EntityHandle inEntityHandle)
		{
			if (EventSystem.Instance.HasWithTarget(inEntityHandle.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.RemoveWithTarget(inEntityHandle.Entity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
		}

		// Token: 0x060436ED RID: 276205 RVA: 0x0107AB9E File Offset: 0x01078D9E
		private void CameraViewTargetEnd(float _)
		{
			this.FinishCallback(true);
		}

		// Token: 0x060436EE RID: 276206 RVA: 0x0107ABA8 File Offset: 0x01078DA8
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

		// Token: 0x060436EF RID: 276207 RVA: 0x0107AC34 File Offset: 0x01078E34
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

		// Token: 0x060436F0 RID: 276208 RVA: 0x0107AC94 File Offset: 0x01078E94
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

		// Token: 0x060436F1 RID: 276209 RVA: 0x0107ACF4 File Offset: 0x01078EF4
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

		// Token: 0x060436F2 RID: 276210 RVA: 0x0107AD70 File Offset: 0x01078F70
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

		// Token: 0x060436F3 RID: 276211 RVA: 0x0107ADE4 File Offset: 0x01078FE4
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

		// Token: 0x060436F4 RID: 276212 RVA: 0x0107AE39 File Offset: 0x01079039
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			TimeTrackController.Instance.SafeUnRegisterEvents(handle);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.TimeTrackControlView))
			{
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.TimeTrackControlView, null);
		}

		// Token: 0x060436F5 RID: 276213 RVA: 0x0107AE68 File Offset: 0x01079068
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

		// Token: 0x060436F6 RID: 276214 RVA: 0x0107AF60 File Offset: 0x01079160
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

		// Token: 0x060436F7 RID: 276215 RVA: 0x0107AFD8 File Offset: 0x010791D8
		public void FinishCallback(bool value)
		{
			if (this.Callback != null)
			{
				Log.Instance.Info(ELogModule.SceneGameplay, ELogAuthor.JYS, "时间控制装置启动请求:FinishCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Callback(value);
				this.Callback = null;
			}
		}

		// Token: 0x1700987B RID: 39035
		// (get) Token: 0x060436F8 RID: 276216 RVA: 0x0107B01C File Offset: 0x0107921C
		public static TimeTrackController Instance
		{
			get
			{
				return TimeTrackController._Instance;
			}
		}

		// Token: 0x060436F9 RID: 276217 RVA: 0x0107B023 File Offset: 0x01079223
		public static TimeTrackController GetOrCreateInstance()
		{
			if (TimeTrackController._Instance == null)
			{
				TimeTrackController.CreateInstance();
			}
			return TimeTrackController._Instance;
		}

		// Token: 0x060436FA RID: 276218 RVA: 0x0107B037 File Offset: 0x01079237
		public static bool CreateInstance()
		{
			if (TimeTrackController._Instance != null)
			{
				return true;
			}
			TimeTrackController._Instance = new TimeTrackController();
			return true;
		}

		// Token: 0x060436FB RID: 276219 RVA: 0x0107B04D File Offset: 0x0107924D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060436FC RID: 276220 RVA: 0x0107B04F File Offset: 0x0107924F
		public static void ResetStaticDefaultValue()
		{
			TimeTrackController._Instance = null;
		}

		// Token: 0x060436FD RID: 276221 RVA: 0x0107B057 File Offset: 0x01079257
		static TimeTrackController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TimeTrackController.CreateStaticDefaultValue), new Action(TimeTrackController.ResetStaticDefaultValue));
		}

		// Token: 0x04023309 RID: 144137
		[Nullable(2)]
		private Action<bool> Callback;

		// Token: 0x0402330A RID: 144138
		[Nullable(2)]
		private static TimeTrackController _Instance;
	}
}
