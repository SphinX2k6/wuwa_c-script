using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000875 RID: 2165
public class ActivityNewPlayerSupportRewardView : UiViewBase
{
	// Token: 0x06006230 RID: 25136 RVA: 0x001F4FEE File Offset: 0x001F31EE
	[NullableContext(1)]
	public ActivityNewPlayerSupportRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x001F4FF7 File Offset: 0x001F31F7
	public ActivityNewPlayerSupportRewardView() : base(null)
	{
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x001F5000 File Offset: 0x001F3200
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmBtnClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnGotoBtnClick))
		};
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x001F50C4 File Offset: 0x001F32C4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006234 RID: 25140 RVA: 0x001F5107 File Offset: 0x001F3307
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<ActivityNewPlayerSupportRewardRoleItem, int>(base.GetHorizontalLayout(1), new Func<ActivityNewPlayerSupportRewardRoleItem>(this.CreateLayoutItem), null, false, true);
		this.RefreshRewardView();
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x001F5130 File Offset: 0x001F3330
	protected override void OnBeforeDestroy()
	{
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x001F513C File Offset: 0x001F333C
	protected override void OnBeforePlayCloseSequence()
	{
		this.UiViewSequence.StopSequenceByKey("Switch", true, true);
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x001F5150 File Offset: 0x001F3350
	private void RefreshRewardView()
	{
		ActivityNewPlayerSupportRewardViewParam activityNewPlayerSupportRewardViewParam = this.OpenParam as ActivityNewPlayerSupportRewardViewParam;
		List<RewardItemData> itemList = activityNewPlayerSupportRewardViewParam.RewardData.GetItemList();
		if (itemList != null)
		{
			this.RewardItemList.Refresh(itemList, true);
		}
		this.RoleLayout.RefreshByData(new List<int>(activityNewPlayerSupportRewardViewParam.TrialRoleList), null, false);
		this.UiViewSequence.StartSequenceName = "Start01";
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x001F51AD File Offset: 0x001F33AD
	[NullableContext(1)]
	private ActivityNewPlayerSupportRewardRoleItem CreateLayoutItem()
	{
		return new ActivityNewPlayerSupportRewardRoleItem();
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x001F51B4 File Offset: 0x001F33B4
	private void OnConfirmBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x001F51C0 File Offset: 0x001F33C0
	private void OnGotoBtnClick()
	{
		List<int> trialRoleList = (this.OpenParam as ActivityNewPlayerSupportRewardViewParam).TrialRoleList;
		int? trialRoleGroupId = TrialRoleConfig.Instance.GetTrialRoleGroupId(trialRoleList[trialRoleList.Count - 1]);
		base.CloseMe(null);
		ActivityNewPlayerSupportController instance = ActivityNewPlayerSupportController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenTrialRoleView(trialRoleGroupId);
	}

	// Token: 0x04003FB1 RID: 16305
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityNewPlayerSupportRewardRoleItem, int> RoleLayout;

	// Token: 0x04003FB2 RID: 16306
	[Nullable(2)]
	private RewardItemList RewardItemList;

	// Token: 0x02006BBA RID: 27578
	private static class EComponentType
	{
		// Token: 0x040236BA RID: 145082
		public const int RewardItemListItem = 0;

		// Token: 0x040236BB RID: 145083
		public const int RoleLayout = 1;

		// Token: 0x040236BC RID: 145084
		public const int RoleItem = 2;

		// Token: 0x040236BD RID: 145085
		public const int ConfirmBtn = 3;

		// Token: 0x040236BE RID: 145086
		public const int GotoBtn = 4;
	}
}
