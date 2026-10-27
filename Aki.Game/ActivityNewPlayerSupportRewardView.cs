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

// Token: 0x020013C1 RID: 5057
public class ActivityNewPlayerSupportRewardView : UiViewBase
{
	// Token: 0x06008E9B RID: 36507 RVA: 0x001EC4CE File Offset: 0x001EA6CE
	[NullableContext(1)]
	public ActivityNewPlayerSupportRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008E9C RID: 36508 RVA: 0x001EC4D7 File Offset: 0x001EA6D7
	public ActivityNewPlayerSupportRewardView() : base(null)
	{
	}

	// Token: 0x06008E9D RID: 36509 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
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

	// Token: 0x06008E9E RID: 36510 RVA: 0x001EC5A4 File Offset: 0x001EA7A4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityNewPlayerSupportRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityNewPlayerSupportRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008E9F RID: 36511 RVA: 0x001EC5E7 File Offset: 0x001EA7E7
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<ActivityNewPlayerSupportRewardRoleItem, int>(base.GetHorizontalLayout(1), new Func<ActivityNewPlayerSupportRewardRoleItem>(this.CreateLayoutItem), null, false, true);
		this.RefreshRewardView();
	}

	// Token: 0x06008EA0 RID: 36512 RVA: 0x001EC610 File Offset: 0x001EA810
	protected override void OnBeforeDestroy()
	{
		ItemRewardModel.Instance.ClearCurrentRewardData();
	}

	// Token: 0x06008EA1 RID: 36513 RVA: 0x001EC61C File Offset: 0x001EA81C
	protected override void OnBeforePlayCloseSequence()
	{
		this.UiViewSequence.StopSequenceByKey("Switch", true, true);
	}

	// Token: 0x06008EA2 RID: 36514 RVA: 0x001EC630 File Offset: 0x001EA830
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

	// Token: 0x06008EA3 RID: 36515 RVA: 0x001EC68D File Offset: 0x001EA88D
	[NullableContext(1)]
	private ActivityNewPlayerSupportRewardRoleItem CreateLayoutItem()
	{
		return new ActivityNewPlayerSupportRewardRoleItem();
	}

	// Token: 0x06008EA4 RID: 36516 RVA: 0x001EC694 File Offset: 0x001EA894
	private void OnConfirmBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008EA5 RID: 36517 RVA: 0x001EC6A0 File Offset: 0x001EA8A0
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

	// Token: 0x04003F19 RID: 16153
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityNewPlayerSupportRewardRoleItem, int> RoleLayout;

	// Token: 0x04003F1A RID: 16154
	[Nullable(2)]
	private RewardItemList RewardItemList;

	// Token: 0x02007A34 RID: 31284
	private static class EComponentType
	{
		// Token: 0x0402839D RID: 164765
		public const int RewardItemListItem = 0;

		// Token: 0x0402839E RID: 164766
		public const int RoleLayout = 1;

		// Token: 0x0402839F RID: 164767
		public const int RoleItem = 2;

		// Token: 0x040283A0 RID: 164768
		public const int ConfirmBtn = 3;

		// Token: 0x040283A1 RID: 164769
		public const int GotoBtn = 4;
	}
}
