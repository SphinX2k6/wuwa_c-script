using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200164D RID: 5709
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerSettlementView : UiViewBase
{
	// Token: 0x0600A042 RID: 41026 RVA: 0x002347C4 File Offset: 0x002329C4
	[NullableContext(1)]
	public WheelTowerSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A043 RID: 41027 RVA: 0x002347D4 File Offset: 0x002329D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A044 RID: 41028 RVA: 0x002349AD File Offset: 0x00232BAD
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x0600A045 RID: 41029 RVA: 0x002349C8 File Offset: 0x00232BC8
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSettlementView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSettlementView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A046 RID: 41030 RVA: 0x00234A0C File Offset: 0x00232C0C
	private void UpdateShareBtnItem()
	{
		if (this.DataInternal == null || this.ShareBtnItem == null)
		{
			return;
		}
		ShareBtnItem shareBtnItem = this.ShareBtnItem;
		if (shareBtnItem != null)
		{
			shareBtnItem.SetUiActive(this.DataInternal.EndlessMode);
		}
		if (this.DataInternal.EndlessMode)
		{
			this.ShareBtnItem.SetShareActionId(EShareActionId.WheelTowerRoundScore);
			this.ShareBtnItem.SetClickCallBack(delegate
			{
				PhotoSaveViewParam param = new PhotoSaveViewParam
				{
					ScreenShot = false,
					IsHiddenBattleView = false,
					ShareId = 12,
					WheelTowerSettlementViewData = this.DataInternal
				};
				UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
			});
		}
	}

	// Token: 0x0600A047 RID: 41031 RVA: 0x00234A77 File Offset: 0x00232C77
	protected override void OnHandleLoadScene()
	{
		this.BindGachaSequenceSceneActors();
	}

	// Token: 0x0600A048 RID: 41032 RVA: 0x00234A80 File Offset: 0x00232C80
	protected override void OnBeforeShow()
	{
		this.TryPlayRoleSequence();
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Start01", false, null);
	}

	// Token: 0x0600A049 RID: 41033 RVA: 0x00234AB2 File Offset: 0x00232CB2
	protected override void OnBeforeDestroy()
	{
		LguiIntTween totalScoreTween = this.TotalScoreTween;
		if (totalScoreTween == null)
		{
			return;
		}
		totalScoreTween.Destroy();
	}

	// Token: 0x0600A04A RID: 41034 RVA: 0x00234AC4 File Offset: 0x00232CC4
	private void TryPlayRoleSequence()
	{
		if (this.IsPlayingRoleSequence)
		{
			return;
		}
		if (this.SceneSequenceCamera == null)
		{
			this.BindGachaSequenceSceneActors();
		}
		if (this.SceneSequenceCamera == null)
		{
			return;
		}
		this.IsPlayingRoleSequence = true;
		this.GachaSequence.PlayRoleSequence(this.SequenceRoleId, 0);
	}

	// Token: 0x0600A04B RID: 41035 RVA: 0x00234B00 File Offset: 0x00232D00
	private void BindGachaSequenceSceneActors()
	{
		if (this.SceneSequenceCamera == null)
		{
			this.SceneSequenceCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SceneCamera1").Value, ECollectActorType.Default);
			if (this.SceneSequenceCamera != null)
			{
				this.GachaSequence.BindSceneSequenceCamera(this.SceneSequenceCamera);
			}
		}
		if (this.UpdateInteractBp == null)
		{
			this.UpdateInteractBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C);
			if (this.UpdateInteractBp != null)
			{
				this.UpdateInteractBp.SetTickableWhenPaused(true);
				this.GachaSequence.BindUpdateInteractBp(this.UpdateInteractBp);
			}
		}
	}

	// Token: 0x0600A04C RID: 41036 RVA: 0x00234B9C File Offset: 0x00232D9C
	private void BindTween()
	{
		this.TotalScoreTween = new LguiIntTween();
		this.TotalScoreTween.UpdateTween = delegate(int value)
		{
			int totalScoreLevel = (int)WheelTowerModel.Instance.GetTotalScoreLevel(value, null, null);
			if (totalScoreLevel != this.LastScoreLevel)
			{
				this.LastScoreLevel = totalScoreLevel;
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.PlaySequence("LevelUp", false, null);
				}
				WheelTowerSettlementScorePanel scorePanel = this.ScorePanel;
				if (scorePanel != null)
				{
					scorePanel.RefreshScoreLevel(totalScoreLevel);
				}
			}
			WheelTowerSettlementScorePanel scorePanel2 = this.ScorePanel;
			if (scorePanel2 == null)
			{
				return;
			}
			scorePanel2.RefreshTotalScore(value);
		};
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Start01", new Action<string>(this.OnSequenceStartFinish), false);
	}

	// Token: 0x0600A04D RID: 41037 RVA: 0x00234BF0 File Offset: 0x00232DF0
	[NullableContext(0)]
	private ValueTuple<int, int> GetBossRoundAndWave([Nullable(1)] List<IBossItemData> bossInfoList)
	{
		int num = 1;
		int item = 0;
		foreach (IBossItemData bossItemData in bossInfoList)
		{
			if (bossItemData.BossInfo.Round > num)
			{
				num = bossItemData.BossInfo.Round;
			}
			NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossItemData.BossInfo.WaveConfigId);
			if (waveConfigById != null)
			{
				item = waveConfigById.Value.Wave;
			}
		}
		return new ValueTuple<int, int>(num, item);
	}

	// Token: 0x0600A04E RID: 41038 RVA: 0x00234C90 File Offset: 0x00232E90
	private void UpdateSettlementInfo()
	{
		if (this.DataInternal == null)
		{
			return;
		}
		ValueTuple<int, int> bossRoundAndWave = this.GetBossRoundAndWave(this.DataInternal.BossInfoList);
		int item = bossRoundAndWave.Item1;
		int num = bossRoundAndWave.Item2 % this.DataInternal.MaxBossWaveNum;
		int curBossWave = (num != 0) ? num : this.DataInternal.MaxBossWaveNum;
		EScoreLevel totalScoreLevel = WheelTowerModel.Instance.GetTotalScoreLevel(0, null, null);
		WheelTowerModeSettlementTitleItem modeTitleItem = this.ModeTitleItem;
		if (modeTitleItem != null)
		{
			modeTitleItem.Refresh(this.DataInternal.EndlessMode);
		}
		WheelTowerSettlementRoundPanel roundPanel = this.RoundPanel;
		if (roundPanel != null)
		{
			roundPanel.RefreshRoundScore(this.DataInternal.CurrentScore);
		}
		WheelTowerSettlementScorePanel scorePanel = this.ScorePanel;
		if (scorePanel != null)
		{
			scorePanel.RefreshTotalScore(0);
		}
		WheelTowerSettlementScorePanel scorePanel2 = this.ScorePanel;
		if (scorePanel2 != null)
		{
			scorePanel2.RefreshScoreLevel((int)totalScoreLevel);
		}
		WheelTowerSettlementScorePanel scorePanel3 = this.ScorePanel;
		if (scorePanel3 != null)
		{
			scorePanel3.RefreshRoundWave(this.DataInternal.EndlessMode, item, curBossWave, this.DataInternal.MaxBossWaveNum);
		}
		WheelTowerSettlementBossResultPanel bossResultPanel = this.BossResultPanel;
		if (bossResultPanel != null)
		{
			bossResultPanel.Refresh(this.DataInternal.BossInfoList);
		}
		GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(this.DataInternal.RoleList, null, false);
		}
		ButtonItem reBattleBtnItem = this.ReBattleBtnItem;
		if (reBattleBtnItem != null)
		{
			reBattleBtnItem.SetUiActive(this.DataInternal.CenterButtonData != null);
		}
		ButtonItem backBtnItem = this.BackBtnItem;
		if (backBtnItem != null)
		{
			backBtnItem.SetUiActive(this.DataInternal.LeftButtonData != null);
		}
		ButtonItem continueBtnItem = this.ContinueBtnItem;
		if (continueBtnItem != null)
		{
			continueBtnItem.SetUiActive(this.DataInternal.RightButtonData != null);
		}
		if (this.DataInternal.CenterButtonData != null)
		{
			ButtonItem reBattleBtnItem2 = this.ReBattleBtnItem;
			if (reBattleBtnItem2 != null)
			{
				reBattleBtnItem2.SetLocalTextNew(this.DataInternal.CenterButtonData.Name, Array.Empty<object>());
			}
		}
		if (this.DataInternal.LeftButtonData != null)
		{
			ButtonItem backBtnItem2 = this.BackBtnItem;
			if (backBtnItem2 != null)
			{
				backBtnItem2.SetLocalTextNew(this.DataInternal.LeftButtonData.Name, Array.Empty<object>());
			}
		}
		if (this.DataInternal.RightButtonData != null)
		{
			ButtonItem continueBtnItem2 = this.ContinueBtnItem;
			if (continueBtnItem2 != null)
			{
				continueBtnItem2.SetLocalTextNew(this.DataInternal.RightButtonData.Name, Array.Empty<object>());
			}
		}
		List<int> finishedSeasonTaskIds = this.DataInternal.FinishedSeasonTaskIds;
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(finishedSeasonTaskIds.Count > 0);
		}
		if (finishedSeasonTaskIds.Count <= 0)
		{
			return;
		}
		NewTowerSeasonAward? seasonTaskRewardConfig = WheelTowerConfig.Instance.GetSeasonTaskRewardConfig(finishedSeasonTaskIds[0]);
		if (seasonTaskRewardConfig == null)
		{
			return;
		}
		if (finishedSeasonTaskIds.Count > 1)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "WheelTower_Settlement_SeasonTask", new <>z__ReadOnlyArray<object>(new object[]
			{
				ConfigMultiTextLang.GetLocalTextNew(seasonTaskRewardConfig.Value.Desc, null),
				finishedSeasonTaskIds.Count
			}));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), seasonTaskRewardConfig.Value.Desc, Array.Empty<object>());
	}

	// Token: 0x0600A04F RID: 41039 RVA: 0x00234F84 File Offset: 0x00233184
	[NullableContext(1)]
	private void OnSequenceStartFinish(string name)
	{
		if (this.DataInternal == null)
		{
			return;
		}
		this.TotalScoreTween.PlayTween(0, this.DataInternal.TotalScore, 0.4f, null);
	}

	// Token: 0x0600A050 RID: 41040 RVA: 0x00234FAC File Offset: 0x002331AC
	private void OnBtnReBattleClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.CenterButtonData : null);
	}

	// Token: 0x0600A051 RID: 41041 RVA: 0x00234FC6 File Offset: 0x002331C6
	private void OnBtnBackClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.LeftButtonData : null);
	}

	// Token: 0x0600A052 RID: 41042 RVA: 0x00234FE0 File Offset: 0x002331E0
	private void OnBtnContinueClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.RightButtonData : null);
	}

	// Token: 0x0600A053 RID: 41043 RVA: 0x00234FFC File Offset: 0x002331FC
	private void HandleButtonClick(IWheelTowerSettlementViewButtonData buttonData)
	{
		if (buttonData == null)
		{
			return;
		}
		if (buttonData.ConfirmBoxId != null)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(buttonData.ConfirmBoxId.Value);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				buttonData.OnClick();
				this.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		buttonData.OnClick();
		base.CloseMe(null);
	}

	// Token: 0x04004912 RID: 18706
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004913 RID: 18707
	private WheelTowerModeSettlementTitleItem ModeTitleItem;

	// Token: 0x04004914 RID: 18708
	private WheelTowerSettlementRoundPanel RoundPanel;

	// Token: 0x04004915 RID: 18709
	private WheelTowerSettlementScorePanel ScorePanel;

	// Token: 0x04004916 RID: 18710
	private WheelTowerSettlementBossResultPanel BossResultPanel;

	// Token: 0x04004917 RID: 18711
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x04004918 RID: 18712
	private ButtonItem ReBattleBtnItem;

	// Token: 0x04004919 RID: 18713
	private ButtonItem BackBtnItem;

	// Token: 0x0400491A RID: 18714
	private ButtonItem ContinueBtnItem;

	// Token: 0x0400491B RID: 18715
	private IWheelTowerSettlementViewData DataInternal;

	// Token: 0x0400491C RID: 18716
	[Nullable(1)]
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x0400491D RID: 18717
	private AActor SceneSequenceCamera;

	// Token: 0x0400491E RID: 18718
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x0400491F RID: 18719
	private bool IsPlayingRoleSequence;

	// Token: 0x04004920 RID: 18720
	private int SequenceRoleId;

	// Token: 0x04004921 RID: 18721
	[Nullable(1)]
	private LguiIntTween TotalScoreTween;

	// Token: 0x04004922 RID: 18722
	private int LastScoreLevel = -1;

	// Token: 0x04004923 RID: 18723
	[Nullable(1)]
	private ShareBtnItem ShareBtnItem;
}
