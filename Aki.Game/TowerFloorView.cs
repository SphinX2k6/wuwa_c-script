using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BF2 RID: 11250
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorView : UiViewBase
{
	// Token: 0x060175D2 RID: 95698 RVA: 0x005F15CC File Offset: 0x005EF7CC
	public TowerFloorView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060175D3 RID: 95699 RVA: 0x005F15E8 File Offset: 0x005EF7E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickResetBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickChallengeBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060175D4 RID: 95700 RVA: 0x005F1865 File Offset: 0x005EFA65
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRefresh, new Action(this.RefreshTower));
	}

	// Token: 0x060175D5 RID: 95701 RVA: 0x005F1883 File Offset: 0x005EFA83
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRefresh, new Action(this.RefreshTower));
	}

	// Token: 0x060175D6 RID: 95702 RVA: 0x005F18A4 File Offset: 0x005EFAA4
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		int currentSelectDifficulties = TowerModel.Instance.CurrentSelectDifficulties;
		this.TowerFloorLayout = new GenericLayout<TowerFloorItem, int>(base.GetVerticalLayout(1), new Func<TowerFloorItem>(this.InitFloorItem), null, false, true);
		TowerModel.Instance.DefaultFloor = -1;
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(currentSelectDifficulties, (int)this.OpenParam);
		if (TowerModel.Instance.NeedOpenConfirmView)
		{
			TowerModel.Instance.DefaultFloor = TowerModel.Instance.NeedOpenConfirmViewTowerId;
		}
		else
		{
			foreach (int num in difficultyAreaAllFloor)
			{
				if (!TowerModel.Instance.GetHaveChallengeFloorAndFormation(num))
				{
					TowerModel.Instance.DefaultFloor = num;
					break;
				}
			}
			if (TowerModel.Instance.DefaultFloor == -1 && difficultyAreaAllFloor.Length != 0)
			{
				TowerModel.Instance.DefaultFloor = difficultyAreaAllFloor[0];
			}
		}
		this.TowerFloorLayout.RefreshByData(difficultyAreaAllFloor.ToList<int>(), null, false);
		this.BuffShowLayout = new GenericLayout<TowerBuffShowItem, long>(base.GetVerticalLayout(2), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, true);
		this.TargetStarLayout = new GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>>(base.GetVerticalLayout(3), new Func<TowerStarsComplexItem>(this.InitTargetStarItem), null, false, true);
		this.MonsterLayout = new GenericLayout<TowerMonsterItem, int>(base.GetGridLayout(4), new Func<TowerMonsterItem>(this.InitMonsterItem), null, false, true);
		this.TitleItem = new TowerTitleItem(base.GetItem(0), delegate()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TowerNormalView);
			UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.TowerVariationView);
			if (!TowerModel.Instance.CheckInTower())
			{
				base.CloseMe(null);
				return;
			}
			if (viewByName == null && viewByName2 == null)
			{
				TowerController.Instance.BackToTowerView(delegate
				{
					base.CloseMe(null);
				});
				return;
			}
			base.CloseMe(null);
		});
		this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(13), new Func<TowerElementItem>(this.InitElementItem), null, false, true);
		string text = null;
		if (currentSelectDifficulties == 1)
		{
			text = "Text_LowRisk_Text";
		}
		else if (currentSelectDifficulties == 2)
		{
			text = "Text_HighRisk_Text";
		}
		else if (currentSelectDifficulties == 3)
		{
			text = "Text_Variation_Text";
		}
		else if (currentSelectDifficulties == 4)
		{
			text = "Text_OverLock_Text";
		}
		string towerAreaName = TowerClimbConfig.Instance.GetTowerAreaName((difficultyAreaAllFloor.Length != 0) ? difficultyAreaAllFloor[0] : 0);
		this.TitleItem.RefreshText(text ?? "", new string[]
		{
			towerAreaName
		});
		this.RefreshView(TowerModel.Instance.DefaultFloor, false);
		if (TowerModel.Instance.NeedOpenConfirmView)
		{
			UiManager.Instance.OpenView(EUiViewName.TowerApplyFloorDataView, null, null);
		}
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x060175D7 RID: 95703 RVA: 0x005F1AD7 File Offset: 0x005EFCD7
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			TowerFloorView.<>c.<<AddHomeBtnExtraCallback>b__15_0>d <<AddHomeBtnExtraCallback>b__15_0>d;
			<<AddHomeBtnExtraCallback>b__15_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__15_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__15_0>d.<>t__builder.Start<TowerFloorView.<>c.<<AddHomeBtnExtraCallback>b__15_0>d>(ref <<AddHomeBtnExtraCallback>b__15_0>d);
			return <<AddHomeBtnExtraCallback>b__15_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x060175D8 RID: 95704 RVA: 0x005F1B08 File Offset: 0x005EFD08
	private void RefreshTower()
	{
		this.RefreshView(this.TowerId, !TowerModel.Instance.GetFloorIsUnlock(this.TowerId));
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(TowerModel.Instance.CurrentSelectDifficulties, (int)this.OpenParam);
		TowerModel.Instance.DefaultFloor = this.TowerId;
		this.TowerFloorLayout.RefreshByData(difficultyAreaAllFloor.ToList<int>(), null, false);
	}

	// Token: 0x060175D9 RID: 95705 RVA: 0x005F1B78 File Offset: 0x005EFD78
	protected override void OnBeforeDestroy()
	{
		this.TowerFloorLayout = null;
		this.BuffShowLayout = null;
		this.TargetStarLayout = null;
		this.MonsterLayout = null;
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
		TowerModel.Instance.CurrentSelectFloor = -1;
	}

	// Token: 0x060175DA RID: 95706 RVA: 0x005F1BD6 File Offset: 0x005EFDD6
	private TowerFloorItem InitFloorItem()
	{
		TowerFloorItem towerFloorItem = new TowerFloorItem();
		towerFloorItem.BindOnClickToggle(new Action<int, bool>(this.RefreshView));
		return towerFloorItem;
	}

	// Token: 0x060175DB RID: 95707 RVA: 0x005F1BEF File Offset: 0x005EFDEF
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x060175DC RID: 95708 RVA: 0x005F1BF6 File Offset: 0x005EFDF6
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x060175DD RID: 95709 RVA: 0x005F1BFD File Offset: 0x005EFDFD
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x060175DE RID: 95710 RVA: 0x005F1C04 File Offset: 0x005EFE04
	private TowerElementItem InitElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x060175DF RID: 95711 RVA: 0x005F1C0C File Offset: 0x005EFE0C
	private void RefreshView(int towerId, bool isLock)
	{
		this.TowerId = towerId;
		TowerModel.Instance.CurrentSelectFloor = towerId;
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs().ToList<long>(), null, false);
		this.MonsterLayout.RefreshByData(value.ShowMonsters().ToList<int>(), delegate
		{
			base.GetItem(14).SetAnchorOffsetY(0f);
		}, false);
		if (value.RecommendElement() != null && value.RecommendElement().Length != 0)
		{
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.ElementLayout.RefreshByData(value.RecommendElement().ToList<int>(), null, false);
		}
		else
		{
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		List<ValueTuple<bool, TowerTarget>> list = new List<ValueTuple<bool, TowerTarget>>();
		List<int> floorStarsIndex = TowerModel.Instance.GetFloorStarsIndex(towerId);
		IReadOnlyList<int> readOnlyList = value.TargetConfig();
		for (int i = 0; i < 3; i++)
		{
			if (i < readOnlyList.Count)
			{
				TowerTarget? targetConfig = TowerClimbConfig.Instance.GetTargetConfig(readOnlyList[i]);
				ValueTuple<bool, TowerTarget> item3 = new ValueTuple<bool, TowerTarget>(floorStarsIndex != null && floorStarsIndex.Contains(i), targetConfig.Value);
				list.Add(item3);
			}
		}
		this.TargetStarLayout.RefreshByData(list, null, false);
		base.GetText(5).SetText(value.Cost.ToString(), true);
		base.GetItem(9).SetUIActive(!isLock);
		base.GetItem(10).SetUIActive(isLock);
		base.SetTextureByPath(value.BgPath, base.GetTexture(8), null, null);
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(this.TowerId);
		if (floorData == null || floorData.Formation.Count == 0)
		{
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}
		else
		{
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
		}
		bool haveChallengeFloor = TowerModel.Instance.GetHaveChallengeFloor(this.TowerId);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		if (!this.HavePlaySwitchSequence.Contains(this.TowerId) && !haveChallengeFloor)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("BuffShow", false, null, false);
			}
			this.HavePlaySwitchSequence.Add(this.TowerId);
		}
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 != null)
		{
			levelSequencePlayer3.PlayLevelSequenceByName("Switch", false, null, false);
		}
		base.GetItem(15).SetUIActive(floorData != null && floorData.IsQuickPass);
	}

	// Token: 0x060175E0 RID: 95712 RVA: 0x005F1EB0 File Offset: 0x005F00B0
	private void OnClickResetBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.TowerResetView, this.TowerId, null);
	}

	// Token: 0x060175E1 RID: 95713 RVA: 0x005F1ECD File Offset: 0x005F00CD
	private void OnClickChallengeBtn()
	{
		TowerModel.Instance.OpenTowerFormationView(this.TowerId);
	}

	// Token: 0x0400AED8 RID: 44760
	private int TowerId = -1;

	// Token: 0x0400AED9 RID: 44761
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerFloorItem, int> TowerFloorLayout;

	// Token: 0x0400AEDA RID: 44762
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400AEDB RID: 44763
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400AEDC RID: 44764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x0400AEDD RID: 44765
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x0400AEDE RID: 44766
	[Nullable(2)]
	private TowerTitleItem TitleItem;

	// Token: 0x0400AEDF RID: 44767
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AEE0 RID: 44768
	private readonly List<int> HavePlaySwitchSequence = new List<int>();

	// Token: 0x020091B0 RID: 37296
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F22E RID: 193070
		TitleItem,
		// Token: 0x0402F22F RID: 193071
		TowerFloorLayout,
		// Token: 0x0402F230 RID: 193072
		ShowBuffLayout,
		// Token: 0x0402F231 RID: 193073
		TargetStarLayout,
		// Token: 0x0402F232 RID: 193074
		MonsterLayout,
		// Token: 0x0402F233 RID: 193075
		CostText,
		// Token: 0x0402F234 RID: 193076
		ResetBtn,
		// Token: 0x0402F235 RID: 193077
		ChallengeBtn,
		// Token: 0x0402F236 RID: 193078
		BgTexture,
		// Token: 0x0402F237 RID: 193079
		BtnPanelItem,
		// Token: 0x0402F238 RID: 193080
		LockItem,
		// Token: 0x0402F239 RID: 193081
		ElementItem = 12,
		// Token: 0x0402F23A RID: 193082
		ElementLayout,
		// Token: 0x0402F23B RID: 193083
		FloorContentItem,
		// Token: 0x0402F23C RID: 193084
		QuickPassItem
	}
}
