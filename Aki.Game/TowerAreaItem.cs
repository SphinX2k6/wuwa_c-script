using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BDF RID: 11231
public class TowerAreaItem : GridProxyAbstract<int>
{
	// Token: 0x0601753D RID: 95549 RVA: 0x005EE5C4 File Offset: 0x005EC7C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickTowerBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601753E RID: 95550 RVA: 0x005EE774 File Offset: 0x005EC974
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		EventSystem.Instance.Add(EEventName.OnTowerRefresh, new Action(this.OnTowerRefresh));
		base.GetText(1).SetUIActive(false);
	}

	// Token: 0x0601753F RID: 95551 RVA: 0x005EE7D4 File Offset: 0x005EC9D4
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(data).Value;
		this.TowerData = data;
		this.AreaNumber = value.AreaNum;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.AreaName, Array.Empty<object>());
		this.RefreshTowerStar(value);
	}

	// Token: 0x06017540 RID: 95552 RVA: 0x005EE830 File Offset: 0x005ECA30
	private void RefreshTowerStar(TowerConfig towerInfo)
	{
		int areaAllStars = TowerModel.Instance.GetAreaAllStars(towerInfo.Difficulty, towerInfo.AreaNum);
		UUIText text = base.GetText(3);
		this.IsLock = TowerModel.Instance.CurrentTowerLock;
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		if (this.IsLock)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			text.SetText("0/" + areaAllStars.ToString(), true);
			FColor color = FColor.FromHex("#ADADAD");
			text.SetColor(color);
			base.GetItem(7).SetColor(color);
			return;
		}
		base.GetItem(0).SetUIActive(false);
		int areaStars = TowerModel.Instance.GetAreaStars(towerInfo.Difficulty, towerInfo.AreaNum, false);
		text.SetText(areaStars.ToString() + "/" + areaAllStars.ToString(), true);
		bool flag = areaAllStars == areaStars;
		base.GetItem(5).SetUIActive(!flag);
		base.GetItem(6).SetUIActive(flag);
		FColor color2 = FColor.FromHex(flag ? "#FFD12F" : "#ECE5D8");
		text.SetColor(color2);
		base.GetItem(7).SetColor(color2);
	}

	// Token: 0x06017541 RID: 95553 RVA: 0x005EE994 File Offset: 0x005ECB94
	private void OnClickTowerBtn()
	{
		if (this.IsLock)
		{
			ScrollingTipsController.Instance.ShowTipsById("NeedClearLastDifficulty", Array.Empty<object>());
			return;
		}
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely("Click", true, false, null, null, false);
	}

	// Token: 0x06017542 RID: 95554 RVA: 0x005EE9E8 File Offset: 0x005ECBE8
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRefresh, new Action(this.OnTowerRefresh));
		this.IsLock = true;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06017543 RID: 95555 RVA: 0x005EEA25 File Offset: 0x005ECC25
	[NullableContext(1)]
	private void FinishSequenceEvent(string name)
	{
		if (name == "Click")
		{
			UiManager.Instance.OpenView(EUiViewName.TowerFloorView, this.AreaNumber, null);
		}
	}

	// Token: 0x06017544 RID: 95556 RVA: 0x005EEA50 File Offset: 0x005ECC50
	private void OnTowerRefresh()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.TowerData).Value;
		this.RefreshTowerStar(value);
	}

	// Token: 0x0400AEAC RID: 44716
	private bool IsLock = true;

	// Token: 0x0400AEAD RID: 44717
	private int AreaNumber = -1;

	// Token: 0x0400AEAE RID: 44718
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AEAF RID: 44719
	private int TowerData = -1;

	// Token: 0x02009197 RID: 37271
	private enum EChildType
	{
		// Token: 0x0402F1C2 RID: 192962
		LockItem,
		// Token: 0x0402F1C3 RID: 192963
		AreaNumberText,
		// Token: 0x0402F1C4 RID: 192964
		AreaNameText,
		// Token: 0x0402F1C5 RID: 192965
		StarText,
		// Token: 0x0402F1C6 RID: 192966
		TowerBtn,
		// Token: 0x0402F1C7 RID: 192967
		UnLockItem,
		// Token: 0x0402F1C8 RID: 192968
		FinishItem,
		// Token: 0x0402F1C9 RID: 192969
		StarItem,
		// Token: 0x0402F1CA RID: 192970
		NormalEffectItem,
		// Token: 0x0402F1CB RID: 192971
		DarkEffectItem
	}
}
