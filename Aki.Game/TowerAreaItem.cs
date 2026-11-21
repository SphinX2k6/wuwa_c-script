using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200215A RID: 8538
public class TowerAreaItem : GridProxyAbstract<int>
{
	// Token: 0x06014F6E RID: 85870 RVA: 0x0061B104 File Offset: 0x00619304
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

	// Token: 0x06014F6F RID: 85871 RVA: 0x0061B2B4 File Offset: 0x006194B4
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		EventSystem.Instance.Add(EEventName.OnTowerRefresh, new Action(this.OnTowerRefresh));
		base.GetText(1).SetUIActive(false);
	}

	// Token: 0x06014F70 RID: 85872 RVA: 0x0061B314 File Offset: 0x00619514
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(data).Value;
		this.TowerData = data;
		this.AreaNumber = value.AreaNum;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.AreaName, Array.Empty<object>());
		this.RefreshTowerStar(value);
	}

	// Token: 0x06014F71 RID: 85873 RVA: 0x0061B370 File Offset: 0x00619570
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

	// Token: 0x06014F72 RID: 85874 RVA: 0x0061B4D4 File Offset: 0x006196D4
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

	// Token: 0x06014F73 RID: 85875 RVA: 0x0061B528 File Offset: 0x00619728
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

	// Token: 0x06014F74 RID: 85876 RVA: 0x0061B565 File Offset: 0x00619765
	[NullableContext(1)]
	private void FinishSequenceEvent(string name)
	{
		if (name == "Click")
		{
			UiManager.Instance.OpenView(EUiViewName.TowerFloorView, this.AreaNumber, null);
		}
	}

	// Token: 0x06014F75 RID: 85877 RVA: 0x0061B590 File Offset: 0x00619790
	private void OnTowerRefresh()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.TowerData).Value;
		this.RefreshTowerStar(value);
	}

	// Token: 0x0400B2B1 RID: 45745
	private bool IsLock = true;

	// Token: 0x0400B2B2 RID: 45746
	private int AreaNumber = -1;

	// Token: 0x0400B2B3 RID: 45747
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B2B4 RID: 45748
	private int TowerData = -1;

	// Token: 0x020083DB RID: 33755
	private enum EChildType
	{
		// Token: 0x0402A8C7 RID: 174279
		LockItem,
		// Token: 0x0402A8C8 RID: 174280
		AreaNumberText,
		// Token: 0x0402A8C9 RID: 174281
		AreaNameText,
		// Token: 0x0402A8CA RID: 174282
		StarText,
		// Token: 0x0402A8CB RID: 174283
		TowerBtn,
		// Token: 0x0402A8CC RID: 174284
		UnLockItem,
		// Token: 0x0402A8CD RID: 174285
		FinishItem,
		// Token: 0x0402A8CE RID: 174286
		StarItem,
		// Token: 0x0402A8CF RID: 174287
		NormalEffectItem,
		// Token: 0x0402A8D0 RID: 174288
		DarkEffectItem
	}
}
