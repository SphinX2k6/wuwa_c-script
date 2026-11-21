using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.SceneItem;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200445E RID: 17502
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MechanismTimelineController : ControllerBase
	{
		// Token: 0x0602C22C RID: 180780 RVA: 0x00C6549B File Offset: 0x00C6369B
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			UKuroMechanismTimelineSubsystem.GetSubSystem(GlobalData.GameInstance).BindMechanismEvent(DelegateUtils.ToManualReleaseDelegate<FTriggerMechanismEventDelegate>(new Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>(this.OnTriggerMechanismEvent)));
			return result;
		}

		// Token: 0x0602C22D RID: 180781 RVA: 0x00C654C3 File Offset: 0x00C636C3
		protected override bool OnClear()
		{
			bool result = base.OnClear();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>(this.OnTriggerMechanismEvent));
			return result;
		}

		// Token: 0x0602C22E RID: 180782 RVA: 0x00C654DC File Offset: 0x00C636DC
		private unsafe void OnTriggerMechanismEvent(FName eventType, FName eventName, EMechanismEventExecuteType executeType, UMovieSceneSequencePlayer sequencePlayer, uint sectionId)
		{
			MechanismEventContext contextByPlayer = MechanismTimelineModel.Instance.GetContextByPlayer(sequencePlayer);
			if (contextByPlayer == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MechanismTimelineController.OnTriggerMechanismEvent:找不到上下文";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventName", eventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("executeType", executeType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("sectionId", sectionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			MechanismEventLevelPrefabContext mechanismEventLevelPrefabContext = contextByPlayer as MechanismEventLevelPrefabContext;
			if (mechanismEventLevelPrefabContext == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.YSQ;
				string message2 = "MechanismTimelineController.OnTriggerMechanismEvent:暂未支持的上下文类型";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("eventName", eventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("executeType", executeType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("sectionId", sectionId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(mechanismEventLevelPrefabContext.PbDataId);
			if (entityByPbDataId == null || !entityByPbDataId.IsInit)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelPlay;
				ELogAuthor author3 = ELogAuthor.YSQ;
				string message3 = "MechanismTimelineController.OnTriggerMechanismEvent:实体还未初始化";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("eventName", eventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("executeType", executeType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("sectionId", sectionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("pbDataId", mechanismEventLevelPrefabContext.PbDataId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				return;
			}
			WorldEntity entity = entityByPbDataId.Entity;
			SceneItemEventListenerComponent sceneItemEventListenerComponent = (entity != null) ? entity.GetComponent<SceneItemEventListenerComponent>() : null;
			if (sceneItemEventListenerComponent == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.LevelPlay;
				ELogAuthor author4 = ELogAuthor.YSQ;
				string message4 = "MechanismTimelineController.OnTriggerMechanismEvent:找不到SceneItemEventListenerComponent组件";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("eventName", eventName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("executeType", executeType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("sectionId", sectionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("pbDataId", mechanismEventLevelPrefabContext.PbDataId);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
				return;
			}
			sceneItemEventListenerComponent.ExecuteEvent(sequencePlayer, eventType.ToString(), eventName.ToString(), executeType, mechanismEventLevelPrefabContext);
		}

		// Token: 0x0602C22F RID: 180783 RVA: 0x00C657A4 File Offset: 0x00C639A4
		public void RequestSceneItemSequenceFrameStart(int playerId, long createDataId, string seqGuid, string eventName)
		{
			SceneItemSequenceFrameStartRequest sceneItemSequenceFrameStartRequest = SceneItemSequenceFrameStartRequest.Create();
			sceneItemSequenceFrameStartRequest.HostPlayerId = playerId;
			sceneItemSequenceFrameStartRequest.EntityId = createDataId;
			sceneItemSequenceFrameStartRequest.SeqGuid = seqGuid;
			sceneItemSequenceFrameStartRequest.EventName = eventName;
			Net.Instance.Call(ERequestMessageId.SceneItemSequenceFrameStartRequest, sceneItemSequenceFrameStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneItemSequenceFrameStartResponse sceneItemSequenceFrameStartResponse = (SceneItemSequenceFrameStartResponse)msg;
				if (sceneItemSequenceFrameStartResponse != null && sceneItemSequenceFrameStartResponse.Code != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "MechanismTimelineController.RequestSceneItemSequenceFrameStart";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", sceneItemSequenceFrameStartResponse.Code);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}, 0);
		}

		// Token: 0x0602C230 RID: 180784 RVA: 0x00C65804 File Offset: 0x00C63A04
		public void RequestSceneItemSequenceFrameEnd(int playerId, long createDataId, string seqGuid, string eventName)
		{
			SceneItemSequenceFrameEndRequest sceneItemSequenceFrameEndRequest = SceneItemSequenceFrameEndRequest.Create();
			sceneItemSequenceFrameEndRequest.HostPlayerId = playerId;
			sceneItemSequenceFrameEndRequest.EntityId = createDataId;
			sceneItemSequenceFrameEndRequest.SeqGuid = seqGuid;
			sceneItemSequenceFrameEndRequest.EventName = eventName;
			Net.Instance.Call(ERequestMessageId.SceneItemSequenceFrameEndRequest, sceneItemSequenceFrameEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneItemSequenceFrameEndResponse sceneItemSequenceFrameEndResponse = (SceneItemSequenceFrameEndResponse)msg;
				if (sceneItemSequenceFrameEndResponse != null && sceneItemSequenceFrameEndResponse.Code != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "MechanismTimelineController.RequestSceneItemSequenceFrameEnd";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", sceneItemSequenceFrameEndResponse.Code);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}, 0);
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x0602C231 RID: 180785 RVA: 0x00C65864 File Offset: 0x00C63A64
		public static MechanismTimelineController Instance
		{
			get
			{
				return MechanismTimelineController._Instance;
			}
		}

		// Token: 0x0602C232 RID: 180786 RVA: 0x00C6586B File Offset: 0x00C63A6B
		public static MechanismTimelineController GetOrCreateInstance()
		{
			if (MechanismTimelineController._Instance == null)
			{
				MechanismTimelineController.CreateInstance();
			}
			return MechanismTimelineController._Instance;
		}

		// Token: 0x0602C233 RID: 180787 RVA: 0x00C6587F File Offset: 0x00C63A7F
		public static bool CreateInstance()
		{
			if (MechanismTimelineController._Instance != null)
			{
				return true;
			}
			MechanismTimelineController._Instance = new MechanismTimelineController();
			return true;
		}

		// Token: 0x0602C234 RID: 180788 RVA: 0x00C65895 File Offset: 0x00C63A95
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C235 RID: 180789 RVA: 0x00C65897 File Offset: 0x00C63A97
		public static void ResetStaticDefaultValue()
		{
			MechanismTimelineController._Instance = null;
		}

		// Token: 0x0602C236 RID: 180790 RVA: 0x00C6589F File Offset: 0x00C63A9F
		static MechanismTimelineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MechanismTimelineController.CreateStaticDefaultValue), new Action(MechanismTimelineController.ResetStaticDefaultValue));
		}

		// Token: 0x04017C4D RID: 97357
		[Nullable(2)]
		private static MechanismTimelineController _Instance;
	}
}
