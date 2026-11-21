using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200216D RID: 8557
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorView : UiViewBase
{
	// Token: 0x06015003 RID: 86019 RVA: 0x0061E120 File Offset: 0x0061C320
	public TowerFloorView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015004 RID: 86020 RVA: 0x0061E13C File Offset: 0x0061C33C
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

	// Token: 0x06015005 RID: 86021 RVA: 0x0061E3B9 File Offset: 0x0061C5B9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRefresh, new Action(this.RefreshTower));
	}

	// Token: 0x06015006 RID: 86022 RVA: 0x0061E3D7 File Offset: 0x0061C5D7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRefresh, new Action(this.RefreshTower));
	}

	// Token: 0x06015007 RID: 86023 RVA: 0x0061E3F8 File Offset: 0x0061C5F8
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
		this.TowerFloorLayout.RefreshByData(difficultyAreaAllFloor, null, false);
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

	// Token: 0x06015008 RID: 86024 RVA: 0x0061E626 File Offset: 0x0061C826
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

	// Token: 0x06015009 RID: 86025 RVA: 0x0061E658 File Offset: 0x0061C858
	private void RefreshTower()
	{
		this.RefreshView(this.TowerId, !TowerModel.Instance.GetFloorIsUnlock(this.TowerId));
		int[] difficultyAreaAllFloor = TowerModel.Instance.GetDifficultyAreaAllFloor(TowerModel.Instance.CurrentSelectDifficulties, (int)this.OpenParam);
		TowerModel.Instance.DefaultFloor = this.TowerId;
		this.TowerFloorLayout.RefreshByData(difficultyAreaAllFloor, null, false);
	}

	// Token: 0x0601500A RID: 86026 RVA: 0x0061E6C4 File Offset: 0x0061C8C4
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

	// Token: 0x0601500B RID: 86027 RVA: 0x0061E722 File Offset: 0x0061C922
	private TowerFloorItem InitFloorItem()
	{
		TowerFloorItem towerFloorItem = new TowerFloorItem();
		towerFloorItem.BindOnClickToggle(new Action<int, bool>(this.RefreshView));
		return towerFloorItem;
	}

	// Token: 0x0601500C RID: 86028 RVA: 0x0061E73B File Offset: 0x0061C93B
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x0601500D RID: 86029 RVA: 0x0061E742 File Offset: 0x0061C942
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x0601500E RID: 86030 RVA: 0x0061E749 File Offset: 0x0061C949
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x0601500F RID: 86031 RVA: 0x0061E750 File Offset: 0x0061C950
	private TowerElementItem InitElementItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x06015010 RID: 86032 RVA: 0x0061E758 File Offset: 0x0061C958
	private void RefreshView(int towerId, bool isLock)
	{
		this.TowerId = towerId;
		TowerModel.Instance.CurrentSelectFloor = towerId;
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(towerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs(), null, false);
		this.MonsterLayout.RefreshByData(value.ShowMonsters(), delegate
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
			this.ElementLayout.RefreshByData(value.RecommendElement(), null, false);
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

	// Token: 0x06015011 RID: 86033 RVA: 0x0061E9ED File Offset: 0x0061CBED
	private void OnClickResetBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.TowerResetView, this.TowerId, null);
	}

	// Token: 0x06015012 RID: 86034 RVA: 0x0061EA0A File Offset: 0x0061CC0A
	private void OnClickChallengeBtn()
	{
		TowerModel.Instance.OpenTowerFormationView(this.TowerId);
	}

	// Token: 0x0400B2DD RID: 45789
	private int TowerId = -1;

	// Token: 0x0400B2DE RID: 45790
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerFloorItem, int> TowerFloorLayout;

	// Token: 0x0400B2DF RID: 45791
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400B2E0 RID: 45792
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400B2E1 RID: 45793
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x0400B2E2 RID: 45794
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> ElementLayout;

	// Token: 0x0400B2E3 RID: 45795
	[Nullable(2)]
	private TowerTitleItem TitleItem;

	// Token: 0x0400B2E4 RID: 45796
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B2E5 RID: 45797
	private readonly List<int> HavePlaySwitchSequence = new List<int>();

	// Token: 0x020083F3 RID: 33779
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A92F RID: 174383
		TitleItem,
		// Token: 0x0402A930 RID: 174384
		TowerFloorLayout,
		// Token: 0x0402A931 RID: 174385
		ShowBuffLayout,
		// Token: 0x0402A932 RID: 174386
		TargetStarLayout,
		// Token: 0x0402A933 RID: 174387
		MonsterLayout,
		// Token: 0x0402A934 RID: 174388
		CostText,
		// Token: 0x0402A935 RID: 174389
		ResetBtn,
		// Token: 0x0402A936 RID: 174390
		ChallengeBtn,
		// Token: 0x0402A937 RID: 174391
		BgTexture,
		// Token: 0x0402A938 RID: 174392
		BtnPanelItem,
		// Token: 0x0402A939 RID: 174393
		LockItem,
		// Token: 0x0402A93A RID: 174394
		ElementItem = 12,
		// Token: 0x0402A93B RID: 174395
		ElementLayout,
		// Token: 0x0402A93C RID: 174396
		FloorContentItem,
		// Token: 0x0402A93D RID: 174397
		QuickPassItem
	}
}
