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

// Token: 0x0200076F RID: 1903
[NullableContext(2)]
[Nullable(0)]
public class LordGymActivitySubView : ActivitySubViewBase
{
	// Token: 0x17000B54 RID: 2900
	// (get) Token: 0x0600575D RID: 22365 RVA: 0x001C9C49 File Offset: 0x001C7E49
	protected new LordGymActivityData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as LordGymActivityData;
		}
	}

	// Token: 0x0600575E RID: 22366 RVA: 0x001C9C58 File Offset: 0x001C7E58
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

	// Token: 0x0600575F RID: 22367 RVA: 0x001C9CC4 File Offset: 0x001C7EC4
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x001C9D08 File Offset: 0x001C7F08
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

	// Token: 0x06005761 RID: 22369 RVA: 0x001C9D89 File Offset: 0x001C7F89
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
			InstanceDungeonEntranceController.Instance.EnterEntrance(3924, 0, null);
		});
	}

	// Token: 0x04003BDA RID: 15322
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003BDB RID: 15323
	protected LordGymBossCard BossCard;

	// Token: 0x02006A61 RID: 27233
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023032 RID: 143410
		public const int CommonActionInfo = 0;

		// Token: 0x04023033 RID: 143411
		public const int BossCard = 1;
	}
}
