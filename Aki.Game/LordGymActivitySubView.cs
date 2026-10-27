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

// Token: 0x020012BB RID: 4795
[NullableContext(2)]
[Nullable(0)]
public class LordGymActivitySubView : ActivitySubViewBase
{
	// Token: 0x17000B34 RID: 2868
	// (get) Token: 0x060083C2 RID: 33730 RVA: 0x001C0DED File Offset: 0x001BEFED
	protected new LordGymActivityData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as LordGymActivityData;
		}
	}

	// Token: 0x060083C3 RID: 33731 RVA: 0x001C0DFC File Offset: 0x001BEFFC
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

	// Token: 0x060083C4 RID: 33732 RVA: 0x001C0E68 File Offset: 0x001BF068
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymActivitySubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymActivitySubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060083C5 RID: 33733 RVA: 0x001C0EAC File Offset: 0x001BF0AC
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

	// Token: 0x060083C6 RID: 33734 RVA: 0x001C0F2D File Offset: 0x001BF12D
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

	// Token: 0x04003B42 RID: 15170
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003B43 RID: 15171
	protected LordGymBossCard BossCard;

	// Token: 0x020078D7 RID: 30935
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027D04 RID: 163076
		public const int CommonActionInfo = 0;

		// Token: 0x04027D05 RID: 163077
		public const int BossCard = 1;
	}
}
