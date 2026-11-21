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

// Token: 0x02000B05 RID: 2821
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerSettlementView : UiViewBase
{
	// Token: 0x06007420 RID: 29728 RVA: 0x0023E600 File Offset: 0x0023C800
	[NullableContext(1)]
	public WheelTowerSettlementView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007421 RID: 29729 RVA: 0x0023E610 File Offset: 0x0023C810
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

	// Token: 0x06007422 RID: 29730 RVA: 0x0023E7E9 File Offset: 0x0023C9E9
	protected override void OnBeforeCreate()
	{
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x06007423 RID: 29731 RVA: 0x0023E804 File Offset: 0x0023CA04
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSettlementView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSettlementView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007424 RID: 29732 RVA: 0x0023E848 File Offset: 0x0023CA48
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

	// Token: 0x06007425 RID: 29733 RVA: 0x0023E8B3 File Offset: 0x0023CAB3
	protected override void OnHandleLoadScene()
	{
		this.BindGachaSequenceSceneActors();
	}

	// Token: 0x06007426 RID: 29734 RVA: 0x0023E8BC File Offset: 0x0023CABC
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

	// Token: 0x06007427 RID: 29735 RVA: 0x0023E8EE File Offset: 0x0023CAEE
	protected override void OnBeforeDestroy()
	{
		LguiIntTween totalScoreTween = this.TotalScoreTween;
		if (totalScoreTween == null)
		{
			return;
		}
		totalScoreTween.Destroy();
	}

	// Token: 0x06007428 RID: 29736 RVA: 0x0023E900 File Offset: 0x0023CB00
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

	// Token: 0x06007429 RID: 29737 RVA: 0x0023E93C File Offset: 0x0023CB3C
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

	// Token: 0x0600742A RID: 29738 RVA: 0x0023E9D8 File Offset: 0x0023CBD8
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

	// Token: 0x0600742B RID: 29739 RVA: 0x0023EA2C File Offset: 0x0023CC2C
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

	// Token: 0x0600742C RID: 29740 RVA: 0x0023EACC File Offset: 0x0023CCCC
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

	// Token: 0x0600742D RID: 29741 RVA: 0x0023EDC0 File Offset: 0x0023CFC0
	[NullableContext(1)]
	private void OnSequenceStartFinish(string name)
	{
		if (this.DataInternal == null)
		{
			return;
		}
		this.TotalScoreTween.PlayTween(0, this.DataInternal.TotalScore, 0.4f, null);
	}

	// Token: 0x0600742E RID: 29742 RVA: 0x0023EDE8 File Offset: 0x0023CFE8
	private void OnBtnReBattleClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.CenterButtonData : null);
	}

	// Token: 0x0600742F RID: 29743 RVA: 0x0023EE02 File Offset: 0x0023D002
	private void OnBtnBackClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.LeftButtonData : null);
	}

	// Token: 0x06007430 RID: 29744 RVA: 0x0023EE1C File Offset: 0x0023D01C
	private void OnBtnContinueClick()
	{
		IWheelTowerSettlementViewData dataInternal = this.DataInternal;
		this.HandleButtonClick((dataInternal != null) ? dataInternal.RightButtonData : null);
	}

	// Token: 0x06007431 RID: 29745 RVA: 0x0023EE38 File Offset: 0x0023D038
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

	// Token: 0x040049B8 RID: 18872
	private PopupCaptionItem CaptionItem;

	// Token: 0x040049B9 RID: 18873
	private WheelTowerModeSettlementTitleItem ModeTitleItem;

	// Token: 0x040049BA RID: 18874
	private WheelTowerSettlementRoundPanel RoundPanel;

	// Token: 0x040049BB RID: 18875
	private WheelTowerSettlementScorePanel ScorePanel;

	// Token: 0x040049BC RID: 18876
	private WheelTowerSettlementBossResultPanel BossResultPanel;

	// Token: 0x040049BD RID: 18877
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x040049BE RID: 18878
	private ButtonItem ReBattleBtnItem;

	// Token: 0x040049BF RID: 18879
	private ButtonItem BackBtnItem;

	// Token: 0x040049C0 RID: 18880
	private ButtonItem ContinueBtnItem;

	// Token: 0x040049C1 RID: 18881
	private IWheelTowerSettlementViewData DataInternal;

	// Token: 0x040049C2 RID: 18882
	[Nullable(1)]
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x040049C3 RID: 18883
	private AActor SceneSequenceCamera;

	// Token: 0x040049C4 RID: 18884
	private BP_UpdateInteract_C UpdateInteractBp;

	// Token: 0x040049C5 RID: 18885
	private bool IsPlayingRoleSequence;

	// Token: 0x040049C6 RID: 18886
	private int SequenceRoleId;

	// Token: 0x040049C7 RID: 18887
	[Nullable(1)]
	private LguiIntTween TotalScoreTween;

	// Token: 0x040049C8 RID: 18888
	private int LastScoreLevel = -1;

	// Token: 0x040049C9 RID: 18889
	[Nullable(1)]
	private ShareBtnItem ShareBtnItem;
}
