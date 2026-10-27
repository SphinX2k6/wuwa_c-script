using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BFD RID: 11261
[NullableContext(2)]
[Nullable(0)]
public class TowerNormalView : UiViewBase
{
	// Token: 0x06017637 RID: 95799 RVA: 0x005F3AAA File Offset: 0x005F1CAA
	[NullableContext(1)]
	public TowerNormalView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017638 RID: 95800 RVA: 0x005F3ABC File Offset: 0x005F1CBC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 23;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 6;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRewardBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickChangeTowerBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickShopBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnLowRiskChange));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnHighRiskChange));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action<EToggleState>(this.OnOverLockChange));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017639 RID: 95801 RVA: 0x005F3ED8 File Offset: 0x005F20D8
	private UniTask BackToBattleView()
	{
		TowerNormalView.<BackToBattleView>d__12 <BackToBattleView>d__;
		<BackToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BackToBattleView>d__.<>4__this = this;
		<BackToBattleView>d__.<>1__state = -1;
		<BackToBattleView>d__.<>t__builder.Start<TowerNormalView.<BackToBattleView>d__12>(ref <BackToBattleView>d__);
		return <BackToBattleView>d__.<>t__builder.Task;
	}

	// Token: 0x0601763A RID: 95802 RVA: 0x005F3F1B File Offset: 0x005F211B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
	}

	// Token: 0x0601763B RID: 95803 RVA: 0x005F3F39 File Offset: 0x005F2139
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
	}

	// Token: 0x0601763C RID: 95804 RVA: 0x005F3F58 File Offset: 0x005F2158
	protected override void OnStart()
	{
		int? num = this.OpenParam as int?;
		if (TowerModel.Instance.CheckInTower())
		{
			TowerController.Instance.ClearAllHatredInTower();
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.AreaLayout = new GenericLayout<TowerAreaItem, int>(base.GetHorizontalLayout(1), new Func<TowerAreaItem>(this.InitItem), base.GetItem(19).GetOwner() as AUIBaseActor, false, true);
		this.RedAreaLayout = new GenericLayout<TowerAreaItem, int>(base.GetHorizontalLayout(1), new Func<TowerAreaItem>(this.InitItem), base.GetItem(17).GetOwner() as AUIBaseActor, false, true);
		this.IsLowRiskClear = TowerModel.Instance.GetDifficultyIsClear(1);
		this.IsHighRiskClear = TowerModel.Instance.GetDifficultyIsClear(2);
		this.IsVariationRiskClear = TowerModel.Instance.GetDifficultyIsClear(3);
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				this.ChangeDifficulty(num.Value);
				switch (num.Value)
				{
				case 1:
					this.CurrentToggle = base.GetExtendToggle(4);
					goto IL_1B4;
				case 2:
					this.CurrentToggle = base.GetExtendToggle(5);
					goto IL_1B4;
				case 3:
					goto IL_1B4;
				case 4:
					this.CurrentToggle = base.GetExtendToggle(18);
					goto IL_1B4;
				default:
					goto IL_1B4;
				}
			}
		}
		if (this.IsLowRiskClear && !this.IsVariationRiskClear)
		{
			this.ChangeDifficulty(2);
			this.CurrentToggle = base.GetExtendToggle(5);
		}
		else if (!this.IsVariationRiskClear && !this.IsLowRiskClear)
		{
			this.ChangeDifficulty(1);
			this.CurrentToggle = base.GetExtendToggle(4);
		}
		else
		{
			this.ChangeDifficulty(4);
			this.CurrentToggle = base.GetExtendToggle(18);
		}
		IL_1B4:
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		base.GetItem(7).SetUIActive(this.IsLowRiskClear);
		base.GetItem(8).SetUIActive(TowerModel.Instance.GetDifficultyIsClear(2));
		base.GetItem(20).SetUIActive(TowerModel.Instance.GetDifficultyIsClear(4));
		this.TitleItem = new TowerTitleItem(base.GetItem(0), delegate()
		{
			if (TowerModel.Instance.CheckInTower())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LeaveTowerOnTowerView);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					TowerController.Instance.LeaveTower();
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.BackToBattleView();
		});
		this.TitleItem.RefreshText("InstanceDungeonTitle_31_CommonText", Array.Empty<string>());
		this.RefreshRewardProgress();
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x0601763D RID: 95805 RVA: 0x005F41AF File Offset: 0x005F23AF
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			TowerNormalView.<>c.<<AddHomeBtnExtraCallback>b__16_0>d <<AddHomeBtnExtraCallback>b__16_0>d;
			<<AddHomeBtnExtraCallback>b__16_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__16_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__16_0>d.<>t__builder.Start<TowerNormalView.<>c.<<AddHomeBtnExtraCallback>b__16_0>d>(ref <<AddHomeBtnExtraCallback>b__16_0>d);
			return <<AddHomeBtnExtraCallback>b__16_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0601763E RID: 95806 RVA: 0x005F41E0 File Offset: 0x005F23E0
	protected override void OnBeforeShow()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.TowerReward, base.GetItem(6), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.TowerRewardByDifficulties, base.GetItem(11), null, 1);
		RedDotController.Instance.BindRedDot(ERedDotName.TowerRewardByDifficulties, base.GetItem(12), null, 2);
		RedDotController.Instance.BindRedDot(ERedDotName.TowerRewardByDifficulties, base.GetItem(13), null, 3);
		RedDotController.Instance.BindRedDot(ERedDotName.TowerRewardByDifficulties, base.GetItem(22), null, 4);
		TowerModel.Instance.CurrentSelectDifficulties = this.CurrentDifficulty;
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 1);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 2);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 3);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 4);
	}

	// Token: 0x0601763F RID: 95807 RVA: 0x005F42C0 File Offset: 0x005F24C0
	protected override void OnBeforeDestroy()
	{
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
		if (this.AreaLayout != null)
		{
			this.AreaLayout = null;
		}
		this.CurrentToggle = null;
		TowerTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.Destroy(null);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x06017640 RID: 95808 RVA: 0x005F4324 File Offset: 0x005F2524
	protected override void OnAfterHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerReward, base.GetItem(6), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(11), 1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(12), 2);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(13), 3);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(22), 4);
	}

	// Token: 0x06017641 RID: 95809 RVA: 0x005F4399 File Offset: 0x005F2599
	[NullableContext(1)]
	private TowerAreaItem InitItem()
	{
		return new TowerAreaItem();
	}

	// Token: 0x06017642 RID: 95810 RVA: 0x005F43A0 File Offset: 0x005F25A0
	private void OnLowRiskChange(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = base.GetExtendToggle(4);
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely("Switch", false, false, null, null, false);
		this.ChangeDifficulty(1);
	}

	// Token: 0x06017643 RID: 95811 RVA: 0x005F4408 File Offset: 0x005F2608
	private void OnHighRiskChange(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = base.GetExtendToggle(5);
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely("Switch", false, false, null, null, false);
		this.ChangeDifficulty(2);
	}

	// Token: 0x06017644 RID: 95812 RVA: 0x005F4470 File Offset: 0x005F2670
	private void OnOverLockChange(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = base.GetExtendToggle(18);
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely("Switch", false, false, null, null, false);
		this.ChangeDifficulty(4);
	}

	// Token: 0x06017645 RID: 95813 RVA: 0x005F44D8 File Offset: 0x005F26D8
	private void ChangeDifficulty(int difficulty)
	{
		TowerModel.Instance.CurrentSelectDifficulties = difficulty;
		this.CurrentDifficulty = difficulty;
		this.RefreshTowerLockState();
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(difficulty, false);
		if (this.CurrentDifficulty == 4)
		{
			this.AreaLayout.RefreshByData(Array.Empty<int>(), null, false);
			this.RedAreaLayout.RefreshByData(difficultyAllAreaFirstFloor.ToList<int>(), null, false);
			if (!TowerModel.Instance.CurrentTowerLock)
			{
				TowerModel.Instance.SetOverLockHasShow();
			}
		}
		else
		{
			this.RedAreaLayout.RefreshByData(Array.Empty<int>(), null, false);
			this.AreaLayout.RefreshByData(difficultyAllAreaFirstFloor.ToList<int>(), null, false);
		}
		this.RefreshRewardProgress();
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, this.CurrentDifficulty);
	}

	// Token: 0x06017646 RID: 95814 RVA: 0x005F45A4 File Offset: 0x005F27A4
	private void OnClickRewardBtn()
	{
		TowerModel instance = TowerModel.Instance;
		float? num = (instance != null) ? new float?(instance.GetDifficultyRewardProgress(TowerModel.Instance.CurrentSelectDifficulties)) : null;
		float num2 = (float)1;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			ScrollingTipsController.Instance.ShowTipsById("HaveAllReward", Array.Empty<object>());
		}
		UiManager.Instance.OpenView(EUiViewName.TowerRewardView, null, delegate(bool success, int viewId)
		{
			base.AddChildViewById(viewId);
		});
	}

	// Token: 0x06017647 RID: 95815 RVA: 0x005F4624 File Offset: 0x005F2824
	private void OnClickChangeTowerBtn()
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.TowerVariationView) != null)
		{
			base.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenViewAsync(EUiViewName.TowerVariationView, null, null);
	}

	// Token: 0x06017648 RID: 95816 RVA: 0x005F4664 File Offset: 0x005F2864
	private void OnClickShopBtn()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x06017649 RID: 95817 RVA: 0x005F4674 File Offset: 0x005F2874
	private void RefreshRewardProgress()
	{
		TowerModel instance = TowerModel.Instance;
		float? num = (instance != null) ? new float?(instance.GetDifficultyRewardProgress(TowerModel.Instance.CurrentSelectDifficulties)) : null;
		UUISprite sprite = base.GetSprite(9);
		if (sprite != null)
		{
			sprite.SetFillAmount(num.Value);
		}
		float? num2 = num;
		float num3 = (float)1;
		if (num2.GetValueOrDefault() == num3 & num2 != null)
		{
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(15);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0601764A RID: 95818 RVA: 0x005F472C File Offset: 0x005F292C
	private void RefreshTowerLockState()
	{
		switch (this.CurrentDifficulty)
		{
		case 1:
			TowerModel.Instance.CurrentTowerLock = false;
			base.GetItem(21).SetUIActive(false);
			return;
		case 2:
			TowerModel.Instance.CurrentTowerLock = !this.IsLowRiskClear;
			base.GetItem(21).SetUIActive(false);
			return;
		case 4:
			TowerModel.Instance.CurrentTowerLock = !this.IsHighRiskClear;
			base.GetItem(21).SetUIActive(TowerModel.Instance.CurrentTowerLock);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CycleTower;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "逆境深塔选择难度时异常";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("难度", this.CurrentDifficulty);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0400AEFA RID: 44794
	private UUIExtendToggle CurrentToggle;

	// Token: 0x0400AEFB RID: 44795
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerAreaItem, int> AreaLayout;

	// Token: 0x0400AEFC RID: 44796
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerAreaItem, int> RedAreaLayout;

	// Token: 0x0400AEFD RID: 44797
	private bool IsLowRiskClear;

	// Token: 0x0400AEFE RID: 44798
	private bool IsHighRiskClear;

	// Token: 0x0400AEFF RID: 44799
	private bool IsVariationRiskClear;

	// Token: 0x0400AF00 RID: 44800
	private TowerTitleItem TitleItem;

	// Token: 0x0400AF01 RID: 44801
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AF02 RID: 44802
	private int CurrentDifficulty = 1;

	// Token: 0x020091C1 RID: 37313
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F289 RID: 193161
		TitleItem,
		// Token: 0x0402F28A RID: 193162
		TowerLayout,
		// Token: 0x0402F28B RID: 193163
		RewardBtn,
		// Token: 0x0402F28C RID: 193164
		ChangeTowerBtn,
		// Token: 0x0402F28D RID: 193165
		LowRiskToggle,
		// Token: 0x0402F28E RID: 193166
		HighRiskToggle,
		// Token: 0x0402F28F RID: 193167
		RedDotItem,
		// Token: 0x0402F290 RID: 193168
		LowFinishItem,
		// Token: 0x0402F291 RID: 193169
		HighFinishItem,
		// Token: 0x0402F292 RID: 193170
		RewardProgressSprite,
		// Token: 0x0402F293 RID: 193171
		ShopBtn,
		// Token: 0x0402F294 RID: 193172
		LowRiskRedDotItem,
		// Token: 0x0402F295 RID: 193173
		HighRiskRedDotItem,
		// Token: 0x0402F296 RID: 193174
		VariationRiskRedDotItem,
		// Token: 0x0402F297 RID: 193175
		RewardShowItem,
		// Token: 0x0402F298 RID: 193176
		RewardDownItem,
		// Token: 0x0402F299 RID: 193177
		RewardDownBgItem,
		// Token: 0x0402F29A RID: 193178
		RedTowerItem,
		// Token: 0x0402F29B RID: 193179
		OverLockToggle,
		// Token: 0x0402F29C RID: 193180
		WhiteTowerItem,
		// Token: 0x0402F29D RID: 193181
		OverLockFinishItem,
		// Token: 0x0402F29E RID: 193182
		OverLockTipsItem,
		// Token: 0x0402F29F RID: 193183
		OverLockRedDotItem
	}
}
