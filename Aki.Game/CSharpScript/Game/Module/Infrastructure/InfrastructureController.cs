using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048DA RID: 18650
	[Controller(0)]
	public class InfrastructureController : ActivityControllerBase
	{
		// Token: 0x0602ECA2 RID: 191650 RVA: 0x00D0BEFA File Offset: 0x00D0A0FA
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0602ECA3 RID: 191651 RVA: 0x00D0BEFC File Offset: 0x00D0A0FC
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_InfrastructureActivityMain";
		}

		// Token: 0x0602ECA4 RID: 191652 RVA: 0x00D0BF03 File Offset: 0x00D0A103
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new InfrActivityMainView();
		}

		// Token: 0x0602ECA5 RID: 191653 RVA: 0x00D0BF0C File Offset: 0x00D0A10C
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

		// Token: 0x0602ECA6 RID: 191654 RVA: 0x00D0BF54 File Offset: 0x00D0A154
		[NullableContext(1)]
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			InfrastructureActivityData infrastructureActivityData = new InfrastructureActivityData();
			InfrastructureModel.Instance.SetActivityData(infrastructureActivityData);
			return infrastructureActivityData;
		}

		// Token: 0x0602ECA7 RID: 191655 RVA: 0x00D0BF74 File Offset: 0x00D0A174
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InfrFireAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrFireAddNotify));
			Net.Instance.Register(ENotifyMessageId.InfrFireUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrFireUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrRoadUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrRoadUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrLibraryTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrLibraryTaskUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.FireShopCoinNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFireShopCoinNotify));
			Net.Instance.Register(ENotifyMessageId.InfrThemeActivityTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrThemeActivityTaskDataUpdateNotify));
		}

		// Token: 0x0602ECA8 RID: 191656 RVA: 0x00D0C02C File Offset: 0x00D0A22C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InfrFireAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrFireUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrRoadUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrLibraryTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FireShopCoinNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrThemeActivityTaskDataUpdateNotify);
		}

		// Token: 0x0602ECA9 RID: 191657 RVA: 0x00D0C09C File Offset: 0x00D0A29C
		public UniTask<bool> RequestInfrastructureInfoRequest()
		{
			InfrastructureController.<RequestInfrastructureInfoRequest>d__7 <RequestInfrastructureInfoRequest>d__;
			<RequestInfrastructureInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureInfoRequest>d__.<>1__state = -1;
			<RequestInfrastructureInfoRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureInfoRequest>d__7>(ref <RequestInfrastructureInfoRequest>d__);
			return <RequestInfrastructureInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAA RID: 191658 RVA: 0x00D0C0D8 File Offset: 0x00D0A2D8
		public UniTask<bool> RequestInfrastructureArchiveTaskReward()
		{
			InfrastructureController.<RequestInfrastructureArchiveTaskReward>d__8 <RequestInfrastructureArchiveTaskReward>d__;
			<RequestInfrastructureArchiveTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureArchiveTaskReward>d__.<>1__state = -1;
			<RequestInfrastructureArchiveTaskReward>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureArchiveTaskReward>d__8>(ref <RequestInfrastructureArchiveTaskReward>d__);
			return <RequestInfrastructureArchiveTaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAB RID: 191659 RVA: 0x00D0C114 File Offset: 0x00D0A314
		public UniTask<bool> RequestInfrastructurePhoneTaskReward()
		{
			InfrastructureController.<RequestInfrastructurePhoneTaskReward>d__9 <RequestInfrastructurePhoneTaskReward>d__;
			<RequestInfrastructurePhoneTaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructurePhoneTaskReward>d__.<>1__state = -1;
			<RequestInfrastructurePhoneTaskReward>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructurePhoneTaskReward>d__9>(ref <RequestInfrastructurePhoneTaskReward>d__);
			return <RequestInfrastructurePhoneTaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAC RID: 191660 RVA: 0x00D0C150 File Offset: 0x00D0A350
		public UniTask<bool> RequestInfrastructureLevelUp()
		{
			InfrastructureController.<RequestInfrastructureLevelUp>d__10 <RequestInfrastructureLevelUp>d__;
			<RequestInfrastructureLevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureLevelUp>d__.<>1__state = -1;
			<RequestInfrastructureLevelUp>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureLevelUp>d__10>(ref <RequestInfrastructureLevelUp>d__);
			return <RequestInfrastructureLevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAD RID: 191661 RVA: 0x00D0C18C File Offset: 0x00D0A38C
		public UniTask<bool> RequestInfrastructureRoadBuild(int roadId)
		{
			InfrastructureController.<RequestInfrastructureRoadBuild>d__11 <RequestInfrastructureRoadBuild>d__;
			<RequestInfrastructureRoadBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureRoadBuild>d__.roadId = roadId;
			<RequestInfrastructureRoadBuild>d__.<>1__state = -1;
			<RequestInfrastructureRoadBuild>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureRoadBuild>d__11>(ref <RequestInfrastructureRoadBuild>d__);
			return <RequestInfrastructureRoadBuild>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAE RID: 191662 RVA: 0x00D0C1D0 File Offset: 0x00D0A3D0
		public UniTask<bool> RequestInfrastructureManualSwitchTraceRoad(int roadId)
		{
			InfrastructureController.<RequestInfrastructureManualSwitchTraceRoad>d__12 <RequestInfrastructureManualSwitchTraceRoad>d__;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrastructureManualSwitchTraceRoad>d__.roadId = roadId;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>1__state = -1;
			<RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder.Start<InfrastructureController.<RequestInfrastructureManualSwitchTraceRoad>d__12>(ref <RequestInfrastructureManualSwitchTraceRoad>d__);
			return <RequestInfrastructureManualSwitchTraceRoad>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECAF RID: 191663 RVA: 0x00D0C214 File Offset: 0x00D0A414
		public UniTask<bool> RequestInfrManualCancelTraceRoadRequest()
		{
			InfrastructureController.<RequestInfrManualCancelTraceRoadRequest>d__13 <RequestInfrManualCancelTraceRoadRequest>d__;
			<RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrManualCancelTraceRoadRequest>d__.<>1__state = -1;
			<RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrManualCancelTraceRoadRequest>d__13>(ref <RequestInfrManualCancelTraceRoadRequest>d__);
			return <RequestInfrManualCancelTraceRoadRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECB0 RID: 191664 RVA: 0x00D0C250 File Offset: 0x00D0A450
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

		// Token: 0x0602ECB1 RID: 191665 RVA: 0x00D0C28C File Offset: 0x00D0A48C
		public UniTask<bool> RequestInfrArchiveReadRequest([Nullable(1)] int[] archiveIds)
		{
			InfrastructureController.<RequestInfrArchiveReadRequest>d__15 <RequestInfrArchiveReadRequest>d__;
			<RequestInfrArchiveReadRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrArchiveReadRequest>d__.archiveIds = archiveIds;
			<RequestInfrArchiveReadRequest>d__.<>1__state = -1;
			<RequestInfrArchiveReadRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrArchiveReadRequest>d__15>(ref <RequestInfrArchiveReadRequest>d__);
			return <RequestInfrArchiveReadRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECB2 RID: 191666 RVA: 0x00D0C2D0 File Offset: 0x00D0A4D0
		[NullableContext(2)]
		private void OnFireShopCoinNotify(IMessage msg, Net.CallbackStatus _)
		{
			FireShopCoinNotify fireShopCoinData = (FireShopCoinNotify)msg;
			InfrastructureModel.Instance.SetFireShopCoinData(fireShopCoinData);
		}

		// Token: 0x0602ECB3 RID: 191667 RVA: 0x00D0C2F0 File Offset: 0x00D0A4F0
		[NullableContext(2)]
		private void OnInfrThemeActivityTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrThemeActivityTaskDataUpdateNotify data = (InfrThemeActivityTaskDataUpdateNotify)msg;
			InfrastructureModel.Instance.UpdateActivityTaskData(data);
		}

		// Token: 0x0602ECB4 RID: 191668 RVA: 0x00D0C310 File Offset: 0x00D0A510
		public UniTask<bool> RequestInfrLimitTaskRewardRequest(int activityId, [Nullable(1)] int[] taskIds)
		{
			InfrastructureController.<RequestInfrLimitTaskRewardRequest>d__18 <RequestInfrLimitTaskRewardRequest>d__;
			<RequestInfrLimitTaskRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrLimitTaskRewardRequest>d__.taskIds = taskIds;
			<RequestInfrLimitTaskRewardRequest>d__.<>1__state = -1;
			<RequestInfrLimitTaskRewardRequest>d__.<>t__builder.Start<InfrastructureController.<RequestInfrLimitTaskRewardRequest>d__18>(ref <RequestInfrLimitTaskRewardRequest>d__);
			return <RequestInfrLimitTaskRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECB5 RID: 191669 RVA: 0x00D0C354 File Offset: 0x00D0A554
		[NullableContext(2)]
		private void OnInfrFireAddNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrFireAddNotify infrFireAddNotify = (InfrFireAddNotify)msg;
			InfrastructureModel.Instance.AddFireLevel(infrFireAddNotify);
			EventSystem.Instance.Emit<float>(EEventName.InfrastructureFireExpAdd, (float)infrFireAddNotify.Add);
		}

		// Token: 0x0602ECB6 RID: 191670 RVA: 0x00D0C38C File Offset: 0x00D0A58C
		[NullableContext(2)]
		private void OnInfrFireUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrFireUpdateNotify infrFireUpdateNotify = (InfrFireUpdateNotify)msg;
			InfrastructureModel.Instance.SetFireData(infrFireUpdateNotify.FireInfo);
		}

		// Token: 0x0602ECB7 RID: 191671 RVA: 0x00D0C3B0 File Offset: 0x00D0A5B0
		[NullableContext(2)]
		private void OnInfrRoadUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrRoadUpdateNotify infrRoadUpdateNotify = (InfrRoadUpdateNotify)msg;
			InfrastructureModel.Instance.SetRoadData(infrRoadUpdateNotify.RoadInfo);
		}

		// Token: 0x0602ECB8 RID: 191672 RVA: 0x00D0C3D4 File Offset: 0x00D0A5D4
		[NullableContext(2)]
		private void OnInfrLibraryTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			InfrLibraryTaskUpdateNotify infrLibraryTaskUpdateNotify = (InfrLibraryTaskUpdateNotify)msg;
			InfrastructureModel.Instance.SetArchiveTaskData(infrLibraryTaskUpdateNotify.ArchiveTasks);
			InfrastructureModel.Instance.SetPhoneTaskData(infrLibraryTaskUpdateNotify.PhoneTasks);
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			if (activityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
		}

		// Token: 0x0602ECB9 RID: 191673 RVA: 0x00D0C42C File Offset: 0x00D0A62C
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

		// Token: 0x0602ECBA RID: 191674 RVA: 0x00D0C480 File Offset: 0x00D0A680
		public UniTask<int?> OpenInfrastructureMainView([Nullable(2)] InfrastructureDefine.IInfrMainViewOpenParam param = null)
		{
			InfrastructureController.<OpenInfrastructureMainView>d__24 <OpenInfrastructureMainView>d__;
			<OpenInfrastructureMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenInfrastructureMainView>d__.param = param;
			<OpenInfrastructureMainView>d__.<>1__state = -1;
			<OpenInfrastructureMainView>d__.<>t__builder.Start<InfrastructureController.<OpenInfrastructureMainView>d__24>(ref <OpenInfrastructureMainView>d__);
			return <OpenInfrastructureMainView>d__.<>t__builder.Task;
		}

		// Token: 0x0602ECBB RID: 191675 RVA: 0x00D0C4C3 File Offset: 0x00D0A6C3
		[NullableContext(1)]
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.InfrOpeningTipsView, null, null);
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x0602ECBC RID: 191676 RVA: 0x00D0C4D6 File Offset: 0x00D0A6D6
		[Nullable(1)]
		public static InfrastructureController Instance
		{
			[NullableContext(1)]
			get
			{
				return InfrastructureController._Instance;
			}
		}

		// Token: 0x0602ECBD RID: 191677 RVA: 0x00D0C4DD File Offset: 0x00D0A6DD
		[NullableContext(1)]
		public static InfrastructureController GetOrCreateInstance()
		{
			if (InfrastructureController._Instance == null)
			{
				InfrastructureController.CreateInstance();
			}
			return InfrastructureController._Instance;
		}

		// Token: 0x0602ECBE RID: 191678 RVA: 0x00D0C4F1 File Offset: 0x00D0A6F1
		public static bool CreateInstance()
		{
			if (InfrastructureController._Instance != null)
			{
				return true;
			}
			InfrastructureController._Instance = new InfrastructureController();
			return true;
		}

		// Token: 0x0602ECBF RID: 191679 RVA: 0x00D0C507 File Offset: 0x00D0A707
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602ECC0 RID: 191680 RVA: 0x00D0C509 File Offset: 0x00D0A709
		public static void ResetStaticDefaultValue()
		{
			InfrastructureController._Instance = null;
		}

		// Token: 0x0602ECC1 RID: 191681 RVA: 0x00D0C511 File Offset: 0x00D0A711
		static InfrastructureController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InfrastructureController.CreateStaticDefaultValue), new Action(InfrastructureController.ResetStaticDefaultValue));
		}

		// Token: 0x04018D7E RID: 101758
		[Nullable(2)]
		private static InfrastructureController _Instance;
	}
}
