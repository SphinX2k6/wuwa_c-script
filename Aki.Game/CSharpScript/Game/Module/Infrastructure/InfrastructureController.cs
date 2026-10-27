using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005901 RID: 22785
	[Controller(0)]
	public class InfrastructureController : ActivityControllerBase
	{
		// Token: 0x06039D7C RID: 236924 RVA: 0x00DBCEDE File Offset: 0x00DBB0DE
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06039D7D RID: 236925 RVA: 0x00DBCEE0 File Offset: 0x00DBB0E0
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_InfrastructureActivityMain";
		}

		// Token: 0x06039D7E RID: 236926 RVA: 0x00DBCEE7 File Offset: 0x00DBB0E7
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new InfrActivityMainView();
		}

		// Token: 0x06039D7F RID: 236927 RVA: 0x00DBCEF0 File Offset: 0x00DBB0F0
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			foreach (EUiViewName viewName in new EUiViewName[]
			{
				EUiViewName.InfrLimitTaskMainView
			})
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06039D80 RID: 236928 RVA: 0x00DBCF38 File Offset: 0x00DBB138
		[NullableContext(1)]
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			InfrastructureActivityData infrastructureActivityData = new InfrastructureActivityData();
			InfrastructureModel.Instance.SetActivityData(infrastructureActivityData);
			return infrastructureActivityData;
		}

		// Token: 0x06039D81 RID: 236929 RVA: 0x00DBCF58 File Offset: 0x00DBB158
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InfrFireAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrFireAddNotify));
			Net.Instance.Register(ENotifyMessageId.InfrFireUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrFireUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrRoadUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrRoadUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrLibraryTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrLibraryTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FireShopCoinNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFireShopCoinNotify));
			Net.Instance.Register(ENotifyMessageId.InfrThemeActivityTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrThemeActivityTaskDataUpdateNotify));
		}

		// Token: 0x06039D82 RID: 236930 RVA: 0x00DBD010 File Offset: 0x00DBB210
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InfrFireAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrFireUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrRoadUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrLibraryTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FireShopCoinNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrThemeActivityTaskDataUpdateNotify);
		}

		// Token: 0x06039D83 RID: 236931 RVA: 0x00DBD080 File Offset: 0x00DBB280
		public UniTask<bool> RequestInfrastructureInfoRequest()
		{
			InfrastructureController.<RequestInfrastructureInfoRequest>d__7 <RequestInfrastructureInfoRequest>d__;
			<RequestInfrastructureInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureInfoRequest>d__.<>1__state = -1;
			<RequestInfrastructureInfoRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureInfoRequest>d__7>(ref <RequestInfrastructureInfoRequest>d__);
			return <RequestInfrastructureInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039D84 RID: 236932 RVA: 0x00DBD0BC File Offset: 0x00DBB2BC
		public UniTask<bool> RequestInfrastructureArchiveTaskReward()
		{
			InfrastructureController.<RequestInfrastructureArchiveTaskReward>d__8 <RequestInfrastructureArchiveTaskReward>d__;
			<RequestInfrastructureArchiveTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureArchiveTaskReward>d__.<>1__state = -1;
			<RequestInfrastructureArchiveTaskReward>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureArchiveTaskReward>d__8>(ref <RequestInfrastructureArchiveTaskReward>d__);
			return <RequestInfrastructureArchiveTaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x06039D85 RID: 236933 RVA: 0x00DBD0F8 File Offset: 0x00DBB2F8
		public UniTask<bool> RequestInfrastructurePhoneTaskReward()
		{
			InfrastructureController.<RequestInfrastructurePhoneTaskReward>d__9 <RequestInfrastructurePhoneTaskReward>d__;
			<RequestInfrastructurePhoneTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructurePhoneTaskReward>d__.<>1__state = -1;
			<RequestInfrastructurePhoneTaskReward>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructurePhoneTaskReward>d__9>(ref <RequestInfrastructurePhoneTaskReward>d__);
			return <RequestInfrastructurePhoneTaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x06039D86 RID: 236934 RVA: 0x00DBD134 File Offset: 0x00DBB334
		public UniTask<bool> RequestInfrastructureLevelUp()
		{
			InfrastructureController.<RequestInfrastructureLevelUp>d__10 <RequestInfrastructureLevelUp>d__;
			<RequestInfrastructureLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureLevelUp>d__.<>1__state = -1;
			<RequestInfrastructureLevelUp>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureLevelUp>d__10>(ref <RequestInfrastructureLevelUp>d__);
			return <RequestInfrastructureLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x06039D87 RID: 236935 RVA: 0x00DBD170 File Offset: 0x00DBB370
		public UniTask<bool> RequestInfrastructureRoadBuild(int roadId)
		{
			InfrastructureController.<RequestInfrastructureRoadBuild>d__11 <RequestInfrastructureRoadBuild>d__;
			<RequestInfrastructureRoadBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureRoadBuild>d__.roadId = roadId;
			<RequestInfrastructureRoadBuild>d__.<>1__state = -1;
			<RequestInfrastructureRoadBuild>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureRoadBuild>d__11>(ref <RequestInfrastructureRoadBuild>d__);
			return <RequestInfrastructureRoadBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06039D88 RID: 236936 RVA: 0x00DBD1B4 File Offset: 0x00DBB3B4
		public UniTask<bool> RequestInfrastructureManualSwitchTraceRoad(int roadId)
		{
			InfrastructureController.<RequestInfrastructureManualSwitchTraceRoad>d__12 <RequestInfrastructureManualSwitchTraceRoad>d__;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureManualSwitchTraceRoad>d__.roadId = roadId;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>1__state = -1;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureManualSwitchTraceRoad>d__12>(ref <RequestInfrastructureManualSwitchTraceRoad>d__);
			return <RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder.Task;
		}

		// Token: 0x06039D89 RID: 236937 RVA: 0x00DBD1F8 File Offset: 0x00DBB3F8
		public UniTask<bool> RequestInfrManualCancelTraceRoadRequest()
		{
			InfrastructureController.<RequestInfrManualCancelTraceRoadRequest>d__13 <RequestInfrManualCancelTraceRoadRequest>d__;
			<RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrManualCancelTraceRoadRequest>d__.<>1__state = -1;
			<RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrManualCancelTraceRoadRequest>d__13>(ref <RequestInfrManualCancelTraceRoadRequest>d__);
			return <RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039D8A RID: 236938 RVA: 0x00DBD234 File Offset: 0x00DBB434
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<InfrFireNoticeResponse> RequestInfrastructureFireNotice()
		{
			InfrastructureController.<RequestInfrastructureFireNotice>d__14 <RequestInfrastructureFireNotice>d__;
			<RequestInfrastructureFireNotice>d__.<>t__builder = AsyncUniTaskMethodBuilder<InfrFireNoticeResponse>.Create();
			<RequestInfrastructureFireNotice>d__.<>1__state = -1;
			<RequestInfrastructureFireNotice>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureFireNotice>d__14>(ref <RequestInfrastructureFireNotice>d__);
			return <RequestInfrastructureFireNotice>d__.<>t__builder.Task;
		}

		// Token: 0x06039D8B RID: 236939 RVA: 0x00DBD270 File Offset: 0x00DBB470
		public UniTask<bool> RequestInfrArchiveReadRequest([Nullable(1)] int[] archiveIds)
		{
			InfrastructureController.<RequestInfrArchiveReadRequest>d__15 <RequestInfrArchiveReadRequest>d__;
			<RequestInfrArchiveReadRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrArchiveReadRequest>d__.archiveIds = archiveIds;
			<RequestInfrArchiveReadRequest>d__.<>1__state = -1;
			<RequestInfrArchiveReadRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrArchiveReadRequest>d__15>(ref <RequestInfrArchiveReadRequest>d__);
			return <RequestInfrArchiveReadRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039D8C RID: 236940 RVA: 0x00DBD2B4 File Offset: 0x00DBB4B4
		[NullableContext(2)]
		private void OnFireShopCoinNotify(IMessage msg, Net.CallbackStatus _)
		{
			FireShopCoinNotify fireShopCoinData = (FireShopCoinNotify)msg;
			InfrastructureModel.Instance.SetFireShopCoinData(fireShopCoinData);
		}

		// Token: 0x06039D8D RID: 236941 RVA: 0x00DBD2D4 File Offset: 0x00DBB4D4
		[NullableContext(2)]
		private void OnInfrThemeActivityTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrThemeActivityTaskDataUpdateNotify data = (InfrThemeActivityTaskDataUpdateNotify)msg;
			InfrastructureModel.Instance.UpdateActivityTaskData(data);
		}

		// Token: 0x06039D8E RID: 236942 RVA: 0x00DBD2F4 File Offset: 0x00DBB4F4
		public UniTask<bool> RequestInfrLimitTaskRewardRequest(int activityId, [Nullable(1)] int[] taskIds)
		{
			InfrastructureController.<RequestInfrLimitTaskRewardRequest>d__18 <RequestInfrLimitTaskRewardRequest>d__;
			<RequestInfrLimitTaskRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrLimitTaskRewardRequest>d__.taskIds = taskIds;
			<RequestInfrLimitTaskRewardRequest>d__.<>1__state = -1;
			<RequestInfrLimitTaskRewardRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrLimitTaskRewardRequest>d__18>(ref <RequestInfrLimitTaskRewardRequest>d__);
			return <RequestInfrLimitTaskRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06039D8F RID: 236943 RVA: 0x00DBD338 File Offset: 0x00DBB538
		[NullableContext(2)]
		private void OnInfrFireAddNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrFireAddNotify infrFireAddNotify = (InfrFireAddNotify)msg;
			InfrastructureModel.Instance.AddFireLevel(infrFireAddNotify);
			EventSystem.Instance.Emit<float>(EEventName.InfrastructureFireExpAdd, (float)infrFireAddNotify.Add);
		}

		// Token: 0x06039D90 RID: 236944 RVA: 0x00DBD370 File Offset: 0x00DBB570
		[NullableContext(2)]
		private void OnInfrFireUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrFireUpdateNotify infrFireUpdateNotify = (InfrFireUpdateNotify)msg;
			InfrastructureModel.Instance.SetFireData(infrFireUpdateNotify.FireInfo);
		}

		// Token: 0x06039D91 RID: 236945 RVA: 0x00DBD394 File Offset: 0x00DBB594
		[NullableContext(2)]
		private void OnInfrRoadUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrRoadUpdateNotify infrRoadUpdateNotify = (InfrRoadUpdateNotify)msg;
			InfrastructureModel.Instance.SetRoadData(infrRoadUpdateNotify.RoadInfo);
		}

		// Token: 0x06039D92 RID: 236946 RVA: 0x00DBD3B8 File Offset: 0x00DBB5B8
		[NullableContext(2)]
		private void OnInfrLibraryTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrLibraryTaskUpdateNotify infrLibraryTaskUpdateNotify = (InfrLibraryTaskUpdateNotify)msg;
			InfrastructureModel.Instance.SetArchiveTaskData(infrLibraryTaskUpdateNotify.ArchiveTasks.ToArray<InfrTaskPb>());
			InfrastructureModel.Instance.SetPhoneTaskData(infrLibraryTaskUpdateNotify.PhoneTasks.ToArray<InfrTaskPb>());
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
		}

		// Token: 0x06039D93 RID: 236947 RVA: 0x00DBD41C File Offset: 0x00DBB61C
		public void OpenMaterialDelivery(ActionInfrastructureItemDeliveryType deliveryType, int roadId, int actionId, InfrastructureDefine.EMaterialDeliveryOpenSource openSource)
		{
			InfrastructureDefine.InfrMaterialsDeliveryOpenParam param = new InfrastructureDefine.InfrMaterialsDeliveryOpenParam
			{
				DeliveryType = deliveryType,
				RoadId = roadId,
				ActionId = new int?(actionId),
				OpenSource = openSource
			};
			InfrastructureModel.Instance.SetInteractingRoadId(roadId);
			UiManager.Instance.OpenView(EUiViewName.InfrMaterialsDeliveryView, param, null);
		}

		// Token: 0x06039D94 RID: 236948 RVA: 0x00DBD470 File Offset: 0x00DBB670
		public UniTask<int?> OpenInfrastructureMainView([Nullable(2)] InfrastructureDefine.IInfrMainViewOpenParam param = null)
		{
			InfrastructureController.<OpenInfrastructureMainView>d__24 <OpenInfrastructureMainView>d__;
			<OpenInfrastructureMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenInfrastructureMainView>d__.param = param;
			<OpenInfrastructureMainView>d__.<>1__state = -1;
			<OpenInfrastructureMainView>d__.<>t__builder.Start<InfrastructureController.<OpenInfrastructureMainView>d__24>(ref <OpenInfrastructureMainView>d__);
			return <OpenInfrastructureMainView>d__.<>t__builder.Task;
		}

		// Token: 0x06039D95 RID: 236949 RVA: 0x00DBD4B3 File Offset: 0x00DBB6B3
		[NullableContext(1)]
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.InfrOpeningTipsView, null, null);
		}

		// Token: 0x17008ACA RID: 35530
		// (get) Token: 0x06039D96 RID: 236950 RVA: 0x00DBD4C6 File Offset: 0x00DBB6C6
		[Nullable(1)]
		public static InfrastructureController Instance
		{
			[NullableContext(1)]
			get
			{
				return InfrastructureController._Instance;
			}
		}

		// Token: 0x06039D97 RID: 236951 RVA: 0x00DBD4CD File Offset: 0x00DBB6CD
		[NullableContext(1)]
		public static InfrastructureController GetOrCreateInstance()
		{
			if (InfrastructureController._Instance == null)
			{
				InfrastructureController.CreateInstance();
			}
			return InfrastructureController._Instance;
		}

		// Token: 0x06039D98 RID: 236952 RVA: 0x00DBD4E1 File Offset: 0x00DBB6E1
		public static bool CreateInstance()
		{
			if (InfrastructureController._Instance != null)
			{
				return true;
			}
			InfrastructureController._Instance = new InfrastructureController();
			return true;
		}

		// Token: 0x06039D99 RID: 236953 RVA: 0x00DBD4F7 File Offset: 0x00DBB6F7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039D9A RID: 236954 RVA: 0x00DBD4F9 File Offset: 0x00DBB6F9
		public static void ResetStaticDefaultValue()
		{
			InfrastructureController._Instance = null;
		}

		// Token: 0x06039D9B RID: 236955 RVA: 0x00DBD501 File Offset: 0x00DBB701
		static InfrastructureController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureController.CreateStaticDefaultValue), new Action(InfrastructureController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E2E1 RID: 123617
		[Nullable(2)]
		private static InfrastructureController _Instance;
	}
}
