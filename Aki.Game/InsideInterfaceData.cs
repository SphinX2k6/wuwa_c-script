using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014CB RID: 5323
[NullableContext(1)]
[Nullable(0)]
public class InsideInterfaceData
{
	// Token: 0x0600D4ED RID: 54509 RVA: 0x003F532D File Offset: 0x003F352D
	public void Clear()
	{
		this.CurIndex = 0;
		this.InterfaceDataUnitArray = new List<InterfaceDataUnit>();
	}

	// Token: 0x0600D4EE RID: 54510 RVA: 0x003F5341 File Offset: 0x003F3541
	public bool IsEmpty()
	{
		return this.CurUnit == null || this.CurUnit.WaitList.Count <= 0;
	}

	// Token: 0x0600D4EF RID: 54511 RVA: 0x003F5364 File Offset: 0x003F3564
	[NullableContext(2)]
	public ItemRewardInfo ShiftFirstData()
	{
		if (this.CurUnit == null)
		{
			return null;
		}
		if (this.CurUnit.WaitList.Count > 0)
		{
			ItemRewardInfo result = this.CurUnit.WaitList[0];
			this.CurUnit.WaitList.RemoveAt(0);
			return result;
		}
		return null;
	}

	// Token: 0x0600D4F0 RID: 54512 RVA: 0x003F53B4 File Offset: 0x003F35B4
	public int GetMaxCount()
	{
		if (this.CurUnit == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "里列表当前单元无效!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return this.CurUnit.GetMaxCount();
	}

	// Token: 0x0600D4F1 RID: 54513 RVA: 0x003F53F4 File Offset: 0x003F35F4
	public int GetAddItemTime()
	{
		if (this.CurUnit == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "里列表当前单元无效!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return this.CurUnit.GetAddItemTime();
	}

	// Token: 0x0600D4F2 RID: 54514 RVA: 0x003F5431 File Offset: 0x003F3631
	public void PostBattleViewOpen()
	{
		this.UpdateIndex();
		this.UpdateAllUnitMode();
	}

	// Token: 0x0600D4F3 RID: 54515 RVA: 0x003F543F File Offset: 0x003F363F
	private void UpdateIndex()
	{
		this.CurIndex++;
	}

	// Token: 0x0600D4F4 RID: 54516 RVA: 0x003F5450 File Offset: 0x003F3650
	private void UpdateAllUnitMode()
	{
		foreach (InterfaceDataUnit interfaceDataUnit in this.InterfaceDataUnitArray)
		{
			interfaceDataUnit.Mode = EPlayMode.Fast;
		}
	}

	// Token: 0x0600D4F5 RID: 54517 RVA: 0x003F54A4 File Offset: 0x003F36A4
	public void ShiftFirstUnit()
	{
		if (this.CurUnit == null)
		{
			Log.Instance.Info(ELogModule.ItemHint, ELogAuthor.XXJ, "里列表关闭时没有数据可以拿", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurUnit.WaitList.Count > 0)
		{
			Log.Instance.Warn(ELogModule.ItemHint, ELogAuthor.ZJC, "里列表关闭时, 还有数据在队列中未开始播放!", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.InterfaceDataUnitArray.Count > 0)
		{
			this.InterfaceDataUnitArray.RemoveAt(0);
		}
		this.CurUnit = null;
		this.UpdateCurUnit();
	}

	// Token: 0x0600D4F6 RID: 54518 RVA: 0x003F552C File Offset: 0x003F372C
	public void InsertItemRewardInfo(AddCountItemInfo[] addCountItemInfo)
	{
		InterfaceDataUnit interfaceDataUnit = this.FindOrAddUnit();
		foreach (AddCountItemInfo addCountItemInfo2 in addCountItemInfo)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(addCountItemInfo2.Id);
			if (itemConfigData != null && itemConfigData.ShowInBag)
			{
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemCount = new int?(addCountItemInfo2.Count);
				itemRewardInfo.ItemId = new int?(addCountItemInfo2.Id);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				interfaceDataUnit.WaitList.Add(itemRewardInfo);
			}
		}
		this.UpdateCurUnit();
	}

	// Token: 0x0600D4F7 RID: 54519 RVA: 0x003F55BF File Offset: 0x003F37BF
	private void UpdateCurUnit()
	{
		if (this.CurUnit == null && this.InterfaceDataUnitArray.Count > 0)
		{
			this.CurUnit = this.InterfaceDataUnitArray[0];
		}
	}

	// Token: 0x0600D4F8 RID: 54520 RVA: 0x003F55EC File Offset: 0x003F37EC
	private InterfaceDataUnit FindOrAddUnit()
	{
		foreach (InterfaceDataUnit interfaceDataUnit in this.InterfaceDataUnitArray)
		{
			if (interfaceDataUnit.Index == this.CurIndex)
			{
				return interfaceDataUnit;
			}
		}
		InterfaceDataUnit interfaceDataUnit2 = new InterfaceDataUnit(this.CurIndex);
		this.InterfaceDataUnitArray.Add(interfaceDataUnit2);
		return interfaceDataUnit2;
	}

	// Token: 0x04007798 RID: 30616
	private int CurIndex;

	// Token: 0x04007799 RID: 30617
	[Nullable(2)]
	private InterfaceDataUnit CurUnit;

	// Token: 0x0400779A RID: 30618
	private List<InterfaceDataUnit> InterfaceDataUnitArray = new List<InterfaceDataUnit>();
}
