using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AE6 RID: 2790
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerRecordView : UiViewBase
{
	// Token: 0x06007396 RID: 29590 RVA: 0x0023B5F7 File Offset: 0x002397F7
	[NullableContext(1)]
	public WheelTowerRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007397 RID: 29591 RVA: 0x0023B600 File Offset: 0x00239800
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnResetBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007398 RID: 29592 RVA: 0x0023B7B4 File Offset: 0x002399B4
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecordView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecordView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007399 RID: 29593 RVA: 0x0023B7F7 File Offset: 0x002399F7
	public void RefreshView()
	{
		WheelTowerRecordScoreInfoPanel scoreInfoPanel = this.ScoreInfoPanel;
		if (scoreInfoPanel != null)
		{
			scoreInfoPanel.Refresh();
		}
		WheelTowerRecordTeamInfoPanel teamInfoPanel = this.TeamInfoPanel;
		if (teamInfoPanel != null)
		{
			teamInfoPanel.Refresh();
		}
		this.RefreshBossList();
	}

	// Token: 0x0600739A RID: 29594 RVA: 0x0023B824 File Offset: 0x00239A24
	public void RefreshBossList()
	{
		int selectedRound = WheelTowerModel.Instance.SelectedRound;
		List<IBossInfo> teamKillBossInfo = WheelTowerModel.Instance.GetTeamKillBossInfo(selectedRound, null);
		List<IBossItemData> list = new List<IBossItemData>();
		foreach (IBossInfo bossInfo in teamKillBossInfo)
		{
			list.Add(new BossItemData
			{
				BossInfo = bossInfo,
				StartPercent = new float?(0f)
			});
		}
		GenericLayout<WheelTowerRecordBossItem, IBossItemData> bossLayout = this.BossLayout;
		if (bossLayout == null)
		{
			return;
		}
		bossLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600739B RID: 29595 RVA: 0x0023B8C8 File Offset: 0x00239AC8
	private void OnTeamItemClick(int index)
	{
		GenericScrollViewNew<WheelTowerRecordTeamItem, int> teamScrollView = this.TeamScrollView;
		if (teamScrollView != null)
		{
			teamScrollView.SelectGridProxy(index, false);
		}
		WheelTowerModel.Instance.UpdateSelectRound(index, false);
		base.PlayOrReplaySequence("Switch", false, null);
		this.RefreshView();
	}

	// Token: 0x0600739C RID: 29596 RVA: 0x0023B90F File Offset: 0x00239B0F
	[NullableContext(1)]
	private WheelTowerRecordTeamItem CreateTeamItem()
	{
		return new WheelTowerRecordTeamItem
		{
			OnToggleClickCallback = new Action<int>(this.OnTeamItemClick)
		};
	}

	// Token: 0x0600739D RID: 29597 RVA: 0x0023B928 File Offset: 0x00239B28
	private void OnCloseBtnClick()
	{
		WheelTowerModel.Instance.UpdateSelectRound(this.FirstSelectedIndex, false);
		base.CloseMe(null);
	}

	// Token: 0x0600739E RID: 29598 RVA: 0x0023B944 File Offset: 0x00239B44
	private void OnResetBtnClick()
	{
		if (!WheelTowerModel.Instance.HasChallengeAnyRound(null))
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WheelTowerRoundResetAllConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			NewTowerClimbingLevelRecord currentLevelRecord = WheelTowerModel.Instance.GetCurrentLevelRecord(null);
			WheelTowerController.Instance.RequestResetLevelRecord(currentLevelRecord.LevelId).ContinueWith(new Action(this.CloseSelf));
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0400490F RID: 18703
	private int FirstSelectedIndex;

	// Token: 0x04004910 RID: 18704
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004911 RID: 18705
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerRecordTeamItem, int> TeamScrollView;

	// Token: 0x04004912 RID: 18706
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecordBossItem, IBossItemData> BossLayout;

	// Token: 0x04004913 RID: 18707
	private WheelTowerRecordScoreInfoPanel ScoreInfoPanel;

	// Token: 0x04004914 RID: 18708
	private WheelTowerRecordTeamInfoPanel TeamInfoPanel;
}
