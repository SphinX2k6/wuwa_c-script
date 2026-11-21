using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003804 RID: 14340
	[Controller(0)]
	public class VillageInfrController : ActivityControllerBase
	{
		// Token: 0x0602547B RID: 152699 RVA: 0x00A837C8 File Offset: 0x00A819C8
		[NullableContext(1)]
		protected override void OnOpenView(ActivityBaseData data)
		{
			List<int> list = ((data != null) ? data.GetPreGuideQuestIds() : null) ?? new List<int>();
			if (list.Count <= 0)
			{
				this.OpenVillageInfrMainView(null).Forget<int?>();
				return;
			}
			int num = list[0];
			if (QuestNewModel.Instance.CheckQuestFinished(num))
			{
				this.OpenVillageInfrMainView(null).Forget<int?>();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, num, null);
		}

		// Token: 0x0602547C RID: 152700 RVA: 0x00A83839 File Offset: 0x00A81A39
		[NullableContext(1)]
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_VillageInfrActivityMain";
		}

		// Token: 0x0602547D RID: 152701 RVA: 0x00A83840 File Offset: 0x00A81A40
		[NullableContext(1)]
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new VillageInfrActivityMainView();
		}

		// Token: 0x0602547E RID: 152702 RVA: 0x00A83847 File Offset: 0x00A81A47
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0602547F RID: 152703 RVA: 0x00A8384C File Offset: 0x00A81A4C
		[NullableContext(1)]
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			VillageInfrActivityData villageInfrActivityData = new VillageInfrActivityData();
			VillageInfrModel.Instance.SetActivityData(villageInfrActivityData);
			return villageInfrActivityData;
		}

		// Token: 0x06025480 RID: 152704 RVA: 0x00A8386C File Offset: 0x00A81A6C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.InfrV2TaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2TreeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTreeUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2FireUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnVillageUpdate));
			Net.Instance.Register(ENotifyMessageId.InfrV2TreeFinishCondUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFinishConditionUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.InfrV2InfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInfrV2InfoNotify));
		}

		// Token: 0x06025481 RID: 152705 RVA: 0x00A83908 File Offset: 0x00A81B08
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TaskDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TreeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2FireUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2TreeFinishCondUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.InfrV2InfoNotify);
		}

		// Token: 0x06025482 RID: 152706 RVA: 0x00A83965 File Offset: 0x00A81B65
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IProto_NormalItem, bool>(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06025483 RID: 152707 RVA: 0x00A8399F File Offset: 0x00A81B9F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06025484 RID: 152708 RVA: 0x00A839DC File Offset: 0x00A81BDC
		public UniTask<bool> RequestInfrV2Info()
		{
			VillageInfrController.<RequestInfrV2Info>d__9 <RequestInfrV2Info>d__;
			<RequestInfrV2Info>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2Info>d__.<>1__state = -1;
			<RequestInfrV2Info>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2Info>d__9>(ref <RequestInfrV2Info>d__);
			return <RequestInfrV2Info>d__.<>t__builder.Task;
		}

		// Token: 0x06025485 RID: 152709 RVA: 0x00A83A18 File Offset: 0x00A81C18
		public UniTask<bool> RequestInfrV2LevelUp()
		{
			VillageInfrController.<RequestInfrV2LevelUp>d__10 <RequestInfrV2LevelUp>d__;
			<RequestInfrV2LevelUp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2LevelUp>d__.<>1__state = -1;
			<RequestInfrV2LevelUp>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2LevelUp>d__10>(ref <RequestInfrV2LevelUp>d__);
			return <RequestInfrV2LevelUp>d__.<>t__builder.Task;
		}

		// Token: 0x06025486 RID: 152710 RVA: 0x00A83A54 File Offset: 0x00A81C54
		public UniTask<bool> RequestInfrV2TreeBuild(int treeId)
		{
			VillageInfrController.<RequestInfrV2TreeBuild>d__11 <RequestInfrV2TreeBuild>d__;
			<RequestInfrV2TreeBuild>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2TreeBuild>d__.treeId = treeId;
			<RequestInfrV2TreeBuild>d__.<>1__state = -1;
			<RequestInfrV2TreeBuild>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2TreeBuild>d__11>(ref <RequestInfrV2TreeBuild>d__);
			return <RequestInfrV2TreeBuild>d__.<>t__builder.Task;
		}

		// Token: 0x06025487 RID: 152711 RVA: 0x00A83A98 File Offset: 0x00A81C98
		public UniTask<bool> RequestInfrV2ManualSwitchTraceTree(int treeId)
		{
			VillageInfrController.<RequestInfrV2ManualSwitchTraceTree>d__12 <RequestInfrV2ManualSwitchTraceTree>d__;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ManualSwitchTraceTree>d__.treeId = treeId;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>1__state = -1;
			<RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ManualSwitchTraceTree>d__12>(ref <RequestInfrV2ManualSwitchTraceTree>d__);
			return <RequestInfrV2ManualSwitchTraceTree>d__.<>t__builder.Task;
		}

		// Token: 0x06025488 RID: 152712 RVA: 0x00A83ADC File Offset: 0x00A81CDC
		public UniTask<bool> RequestInfrV2ManualCancelTraceTree()
		{
			VillageInfrController.<RequestInfrV2ManualCancelTraceTree>d__13 <RequestInfrV2ManualCancelTraceTree>d__;
			<RequestInfrV2ManualCancelTraceTree>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ManualCancelTraceTree>d__.<>1__state = -1;
			<RequestInfrV2ManualCancelTraceTree>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ManualCancelTraceTree>d__13>(ref <RequestInfrV2ManualCancelTraceTree>d__);
			return <RequestInfrV2ManualCancelTraceTree>d__.<>t__builder.Task;
		}

		// Token: 0x06025489 RID: 152713 RVA: 0x00A83B18 File Offset: 0x00A81D18
		public UniTask<bool> RequestInfrV2ScoreReward()
		{
			VillageInfrController.<RequestInfrV2ScoreReward>d__14 <RequestInfrV2ScoreReward>d__;
			<RequestInfrV2ScoreReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2ScoreReward>d__.<>1__state = -1;
			<RequestInfrV2ScoreReward>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2ScoreReward>d__14>(ref <RequestInfrV2ScoreReward>d__);
			return <RequestInfrV2ScoreReward>d__.<>t__builder.Task;
		}

		// Token: 0x0602548A RID: 152714 RVA: 0x00A83B54 File Offset: 0x00A81D54
		public UniTask<bool> RequestInfrV2TaskReward([Nullable(1)] List<int> taskIds)
		{
			VillageInfrController.<RequestInfrV2TaskReward>d__15 <RequestInfrV2TaskReward>d__;
			<RequestInfrV2TaskReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2TaskReward>d__.taskIds = taskIds;
			<RequestInfrV2TaskReward>d__.<>1__state = -1;
			<RequestInfrV2TaskReward>d__.<>t__builder.Start<VillageInfrController.<RequestInfrV2TaskReward>d__15>(ref <RequestInfrV2TaskReward>d__);
			return <RequestInfrV2TaskReward>d__.<>t__builder.Task;
		}

		// Token: 0x0602548B RID: 152715 RVA: 0x00A83B98 File Offset: 0x00A81D98
		[NullableContext(2)]
		private void OnInfrV2InfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2InfoNotify infrV2InfoNotify = (InfrV2InfoNotify)msg;
			VillageInfrModel.Instance.SetData(infrV2InfoNotify.InfrInfo);
		}

		// Token: 0x0602548C RID: 152716 RVA: 0x00A83BBC File Offset: 0x00A81DBC
		[NullableContext(2)]
		private void OnTaskUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TaskDataUpdateNotify infrV2TaskDataUpdateNotify = (InfrV2TaskDataUpdateNotify)msg;
			VillageInfrModel.Instance.UpdateActivityTask(infrV2TaskDataUpdateNotify.Task);
		}

		// Token: 0x0602548D RID: 152717 RVA: 0x00A83BE0 File Offset: 0x00A81DE0
		[NullableContext(2)]
		private void OnTreeUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TreeUpdateNotify infrV2TreeUpdateNotify = (InfrV2TreeUpdateNotify)msg;
			VillageInfrModel.Instance.SetAllTreeData(infrV2TreeUpdateNotify.TreeInfo);
		}

		// Token: 0x0602548E RID: 152718 RVA: 0x00A83C04 File Offset: 0x00A81E04
		[NullableContext(2)]
		private void OnVillageUpdate(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2FireUpdateNotify infrV2FireUpdateNotify = (InfrV2FireUpdateNotify)msg;
			VillageInfrModel.Instance.SetVillageData(infrV2FireUpdateNotify.FireInfo);
		}

		// Token: 0x0602548F RID: 152719 RVA: 0x00A83C28 File Offset: 0x00A81E28
		[NullableContext(2)]
		private void OnFinishConditionUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			InfrV2TreeFinishCondUpdateNotify infrV2TreeFinishCondUpdateNotify = (InfrV2TreeFinishCondUpdateNotify)msg;
			VillageInfrModel.Instance.SetAllTreeFinishConditionData(infrV2TreeFinishCondUpdateNotify.Cond);
		}

		// Token: 0x06025490 RID: 152720 RVA: 0x00A83C4C File Offset: 0x00A81E4C
		[NullableContext(1)]
		private void OnAddCommonItem(IProto_NormalItem normalItem, bool isShowNewTips)
		{
			if (VillageInfrModel.Instance.CanShowNewTip(normalItem.Id, normalItem.Count))
			{
				int value = VillageInfrConfig.Instance.GetTreeIdByItemId(normalItem.Id).Value;
				ItemModel.Instance.PushWaitVillageInfrTree(value);
			}
		}

		// Token: 0x06025491 RID: 152721 RVA: 0x00A83C98 File Offset: 0x00A81E98
		[NullableContext(1)]
		private void OnCommonItemCountAnyChange(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (VillageInfrModel.Instance.CanShowNewTip(normalItem.Id, count - lastCount))
			{
				int value = VillageInfrConfig.Instance.GetTreeIdByItemId(normalItem.Id).Value;
				ItemModel.Instance.PushWaitVillageInfrTree(value);
			}
		}

		// Token: 0x06025492 RID: 152722 RVA: 0x00A83CE0 File Offset: 0x00A81EE0
		public UniTask<int?> OpenVillageInfrMainView([Nullable(2)] IVillageInfrMainParam param = null)
		{
			VillageInfrController.<OpenVillageInfrMainView>d__23 <OpenVillageInfrMainView>d__;
			<OpenVillageInfrMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenVillageInfrMainView>d__.param = param;
			<OpenVillageInfrMainView>d__.<>1__state = -1;
			<OpenVillageInfrMainView>d__.<>t__builder.Start<VillageInfrController.<OpenVillageInfrMainView>d__23>(ref <OpenVillageInfrMainView>d__);
			return <OpenVillageInfrMainView>d__.<>t__builder.Task;
		}

		// Token: 0x06025493 RID: 152723 RVA: 0x00A83D24 File Offset: 0x00A81F24
		public UniTask<int?> OpenVillageInfrWorldBuildViewAsync(EVillageInfrSelectType selectType, int selectId, [Nullable(1)] string uiCameraName)
		{
			VillageInfrController.<OpenVillageInfrWorldBuildViewAsync>d__24 <OpenVillageInfrWorldBuildViewAsync>d__;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<OpenVillageInfrWorldBuildViewAsync>d__.selectType = selectType;
			<OpenVillageInfrWorldBuildViewAsync>d__.selectId = selectId;
			<OpenVillageInfrWorldBuildViewAsync>d__.uiCameraName = uiCameraName;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>1__state = -1;
			<OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder.Start<VillageInfrController.<OpenVillageInfrWorldBuildViewAsync>d__24>(ref <OpenVillageInfrWorldBuildViewAsync>d__);
			return <OpenVillageInfrWorldBuildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x06025494 RID: 152724 RVA: 0x00A83D77 File Offset: 0x00A81F77
		[Nullable(1)]
		public static VillageInfrController Instance
		{
			[NullableContext(1)]
			get
			{
				return VillageInfrController._Instance;
			}
		}

		// Token: 0x06025495 RID: 152725 RVA: 0x00A83D7E File Offset: 0x00A81F7E
		[NullableContext(1)]
		public static VillageInfrController GetOrCreateInstance()
		{
			if (VillageInfrController._Instance == null)
			{
				VillageInfrController.CreateInstance();
			}
			return VillageInfrController._Instance;
		}

		// Token: 0x06025496 RID: 152726 RVA: 0x00A83D92 File Offset: 0x00A81F92
		public static bool CreateInstance()
		{
			if (VillageInfrController._Instance != null)
			{
				return true;
			}
			VillageInfrController._Instance = new VillageInfrController();
			return true;
		}

		// Token: 0x06025497 RID: 152727 RVA: 0x00A83DA8 File Offset: 0x00A81FA8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025498 RID: 152728 RVA: 0x00A83DAA File Offset: 0x00A81FAA
		public static void ResetStaticDefaultValue()
		{
			VillageInfrController._Instance = null;
		}

		// Token: 0x06025499 RID: 152729 RVA: 0x00A83DB2 File Offset: 0x00A81FB2
		static VillageInfrController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VillageInfrController.CreateStaticDefaultValue), new Action(VillageInfrController.ResetStaticDefaultValue));
		}

		// Token: 0x04014A25 RID: 84517
		[Nullable(2)]
		private static VillageInfrController _Instance;
	}
}
