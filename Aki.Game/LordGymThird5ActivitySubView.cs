using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012C1 RID: 4801
[NullableContext(2)]
[Nullable(0)]
public class LordGymThird5ActivitySubView : ActivitySubViewBase
{
	// Token: 0x17000B35 RID: 2869
	// (get) Token: 0x060083E0 RID: 33760 RVA: 0x001C1664 File Offset: 0x001BF864
	protected new LordGymActivityData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as LordGymActivityData;
		}
	}

	// Token: 0x060083E1 RID: 33761 RVA: 0x001C1674 File Offset: 0x001BF874
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060083E2 RID: 33762 RVA: 0x001C16E0 File Offset: 0x001BF8E0
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymThird5ActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymThird5ActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060083E3 RID: 33763 RVA: 0x001C1724 File Offset: 0x001BF924
	protected override void OnRefreshView()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
		this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.CheckRedDot());
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.RefreshView();
		}
		List<int> lordGymEntranceWithNewTag = LordGymModel.Instance.GetLordGymEntranceWithNewTag();
		if (lordGymEntranceWithNewTag.Count == 0)
		{
			base.GetItem(1).SetUIActive(false);
			return;
		}
		LordGymBossCard bossCard = this.BossCard;
		if (bossCard == null)
		{
			return;
		}
		bossCard.Refresh(lordGymEntranceWithNewTag);
	}

	// Token: 0x060083E4 RID: 33764 RVA: 0x001C17A5 File Offset: 0x001BF9A5
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityBaseData.ReadRedDot();
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			if (OnlineModel.Instance.GetIsTeamModel())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
				return;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_200172_Text", Array.Empty<object>());
				return;
			}
			InstanceDungeonEntranceController.Instance.EnterEntrance(3925, 0, null);
		});
	}

	// Token: 0x04003B59 RID: 15193
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003B5A RID: 15194
	protected LordGymBossCard BossCard;

	// Token: 0x020078DB RID: 30939
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027D13 RID: 163091
		CommonActionInfo,
		// Token: 0x04027D14 RID: 163092
		BossCard
	}
}
