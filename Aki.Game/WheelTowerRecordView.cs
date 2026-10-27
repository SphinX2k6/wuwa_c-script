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

// Token: 0x0200162E RID: 5678
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerRecordView : UiViewBase
{
	// Token: 0x06009FB8 RID: 40888 RVA: 0x002317AB File Offset: 0x0022F9AB
	[NullableContext(1)]
	public WheelTowerRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FB9 RID: 40889 RVA: 0x002317B4 File Offset: 0x0022F9B4
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

	// Token: 0x06009FBA RID: 40890 RVA: 0x00231968 File Offset: 0x0022FB68
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecordView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecordView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FBB RID: 40891 RVA: 0x002319AB File Offset: 0x0022FBAB
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

	// Token: 0x06009FBC RID: 40892 RVA: 0x002319D8 File Offset: 0x0022FBD8
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

	// Token: 0x06009FBD RID: 40893 RVA: 0x00231A7C File Offset: 0x0022FC7C
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

	// Token: 0x06009FBE RID: 40894 RVA: 0x00231AC3 File Offset: 0x0022FCC3
	[NullableContext(1)]
	private WheelTowerRecordTeamItem CreateTeamItem()
	{
		return new WheelTowerRecordTeamItem
		{
			OnToggleClickCallback = new Action<int>(this.OnTeamItemClick)
		};
	}

	// Token: 0x06009FBF RID: 40895 RVA: 0x00231ADC File Offset: 0x0022FCDC
	private void OnCloseBtnClick()
	{
		WheelTowerModel.Instance.UpdateSelectRound(this.FirstSelectedIndex, false);
		base.CloseMe(null);
	}

	// Token: 0x06009FC0 RID: 40896 RVA: 0x00231AF8 File Offset: 0x0022FCF8
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

	// Token: 0x04004869 RID: 18537
	private int FirstSelectedIndex;

	// Token: 0x0400486A RID: 18538
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400486B RID: 18539
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerRecordTeamItem, int> TeamScrollView;

	// Token: 0x0400486C RID: 18540
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecordBossItem, IBossItemData> BossLayout;

	// Token: 0x0400486D RID: 18541
	private WheelTowerRecordScoreInfoPanel ScoreInfoPanel;

	// Token: 0x0400486E RID: 18542
	private WheelTowerRecordTeamInfoPanel TeamInfoPanel;
}
