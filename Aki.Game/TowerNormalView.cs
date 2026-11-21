using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002178 RID: 8568
[NullableContext(2)]
[Nullable(0)]
public class TowerNormalView : UiViewBase
{
	// Token: 0x06015068 RID: 86120 RVA: 0x006205DD File Offset: 0x0061E7DD
	[NullableContext(1)]
	public TowerNormalView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015069 RID: 86121 RVA: 0x006205F0 File Offset: 0x0061E7F0
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

	// Token: 0x0601506A RID: 86122 RVA: 0x00620A0C File Offset: 0x0061EC0C
	private UniTask BackToBattleView()
	{
		TowerNormalView.<BackToBattleView>d__12 <BackToBattleView>d__;
		<BackToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BackToBattleView>d__.<>4__this = this;
		<BackToBattleView>d__.<>1__state = -1;
		<BackToBattleView>d__.<>t__builder.Start<TowerNormalView.<BackToBattleView>d__12>(ref <BackToBattleView>d__);
		return <BackToBattleView>d__.<>t__builder.Task;
	}

	// Token: 0x0601506B RID: 86123 RVA: 0x00620A4F File Offset: 0x0061EC4F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
	}

	// Token: 0x0601506C RID: 86124 RVA: 0x00620A6D File Offset: 0x0061EC6D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
	}

	// Token: 0x0601506D RID: 86125 RVA: 0x00620A8C File Offset: 0x0061EC8C
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

	// Token: 0x0601506E RID: 86126 RVA: 0x00620CE3 File Offset: 0x0061EEE3
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

	// Token: 0x0601506F RID: 86127 RVA: 0x00620D14 File Offset: 0x0061EF14
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

	// Token: 0x06015070 RID: 86128 RVA: 0x00620DF4 File Offset: 0x0061EFF4
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

	// Token: 0x06015071 RID: 86129 RVA: 0x00620E58 File Offset: 0x0061F058
	protected override void OnAfterHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerReward, base.GetItem(6), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(11), 1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(12), 2);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(13), 3);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(22), 4);
	}

	// Token: 0x06015072 RID: 86130 RVA: 0x00620ECD File Offset: 0x0061F0CD
	[NullableContext(1)]
	private TowerAreaItem InitItem()
	{
		return new TowerAreaItem();
	}

	// Token: 0x06015073 RID: 86131 RVA: 0x00620ED4 File Offset: 0x0061F0D4
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

	// Token: 0x06015074 RID: 86132 RVA: 0x00620F3C File Offset: 0x0061F13C
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

	// Token: 0x06015075 RID: 86133 RVA: 0x00620FA4 File Offset: 0x0061F1A4
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

	// Token: 0x06015076 RID: 86134 RVA: 0x0062100C File Offset: 0x0061F20C
	private void ChangeDifficulty(int difficulty)
	{
		TowerModel.Instance.CurrentSelectDifficulties = difficulty;
		this.CurrentDifficulty = difficulty;
		this.RefreshTowerLockState();
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(difficulty, false);
		if (this.CurrentDifficulty == 4)
		{
			this.AreaLayout.RefreshByData(Array.Empty<int>(), null, false);
			this.RedAreaLayout.RefreshByData(difficultyAllAreaFirstFloor, null, false);
			if (!TowerModel.Instance.CurrentTowerLock)
			{
				TowerModel.Instance.SetOverLockHasShow();
			}
		}
		else
		{
			this.RedAreaLayout.RefreshByData(Array.Empty<int>(), null, false);
			this.AreaLayout.RefreshByData(difficultyAllAreaFirstFloor, null, false);
		}
		this.RefreshRewardProgress();
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, this.CurrentDifficulty);
	}

	// Token: 0x06015077 RID: 86135 RVA: 0x006210CC File Offset: 0x0061F2CC
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

	// Token: 0x06015078 RID: 86136 RVA: 0x0062114C File Offset: 0x0061F34C
	private void OnClickChangeTowerBtn()
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.TowerVariationView) != null)
		{
			base.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenViewAsync(EUiViewName.TowerVariationView, null, null);
	}

	// Token: 0x06015079 RID: 86137 RVA: 0x0062118C File Offset: 0x0061F38C
	private void OnClickShopBtn()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x0601507A RID: 86138 RVA: 0x0062119C File Offset: 0x0061F39C
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

	// Token: 0x0601507B RID: 86139 RVA: 0x00621254 File Offset: 0x0061F454
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

	// Token: 0x0400B2FF RID: 45823
	private UUIExtendToggle CurrentToggle;

	// Token: 0x0400B300 RID: 45824
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerAreaItem, int> AreaLayout;

	// Token: 0x0400B301 RID: 45825
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerAreaItem, int> RedAreaLayout;

	// Token: 0x0400B302 RID: 45826
	private bool IsLowRiskClear;

	// Token: 0x0400B303 RID: 45827
	private bool IsHighRiskClear;

	// Token: 0x0400B304 RID: 45828
	private bool IsVariationRiskClear;

	// Token: 0x0400B305 RID: 45829
	private TowerTitleItem TitleItem;

	// Token: 0x0400B306 RID: 45830
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B307 RID: 45831
	private int CurrentDifficulty = 1;

	// Token: 0x02008404 RID: 33796
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A98A RID: 174474
		TitleItem,
		// Token: 0x0402A98B RID: 174475
		TowerLayout,
		// Token: 0x0402A98C RID: 174476
		RewardBtn,
		// Token: 0x0402A98D RID: 174477
		ChangeTowerBtn,
		// Token: 0x0402A98E RID: 174478
		LowRiskToggle,
		// Token: 0x0402A98F RID: 174479
		HighRiskToggle,
		// Token: 0x0402A990 RID: 174480
		RedDotItem,
		// Token: 0x0402A991 RID: 174481
		LowFinishItem,
		// Token: 0x0402A992 RID: 174482
		HighFinishItem,
		// Token: 0x0402A993 RID: 174483
		RewardProgressSprite,
		// Token: 0x0402A994 RID: 174484
		ShopBtn,
		// Token: 0x0402A995 RID: 174485
		LowRiskRedDotItem,
		// Token: 0x0402A996 RID: 174486
		HighRiskRedDotItem,
		// Token: 0x0402A997 RID: 174487
		VariationRiskRedDotItem,
		// Token: 0x0402A998 RID: 174488
		RewardShowItem,
		// Token: 0x0402A999 RID: 174489
		RewardDownItem,
		// Token: 0x0402A99A RID: 174490
		RewardDownBgItem,
		// Token: 0x0402A99B RID: 174491
		RedTowerItem,
		// Token: 0x0402A99C RID: 174492
		OverLockToggle,
		// Token: 0x0402A99D RID: 174493
		WhiteTowerItem,
		// Token: 0x0402A99E RID: 174494
		OverLockFinishItem,
		// Token: 0x0402A99F RID: 174495
		OverLockTipsItem,
		// Token: 0x0402A9A0 RID: 174496
		OverLockRedDotItem
	}
}
