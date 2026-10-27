using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FF8 RID: 8184
[NullableContext(1)]
[Nullable(0)]
public class InsideInterfaceData
{
	// Token: 0x06010085 RID: 65669 RVA: 0x003E8D35 File Offset: 0x003E6F35
	public void Clear()
	{
		this.CurIndex = 0;
		this.InterfaceDataUnitArray = new List<InterfaceDataUnit>();
	}

	// Token: 0x06010086 RID: 65670 RVA: 0x003E8D49 File Offset: 0x003E6F49
	public bool IsEmpty()
	{
		return this.CurUnit == null || this.CurUnit.WaitList.Count <= 0;
	}

	// Token: 0x06010087 RID: 65671 RVA: 0x003E8D6C File Offset: 0x003E6F6C
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

	// Token: 0x06010088 RID: 65672 RVA: 0x003E8DBC File Offset: 0x003E6FBC
	public int GetMaxCount()
	{
		if (this.CurUnit == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "里列表当前单元无效!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return this.CurUnit.GetMaxCount();
	}

	// Token: 0x06010089 RID: 65673 RVA: 0x003E8DFC File Offset: 0x003E6FFC
	public int GetAddItemTime()
	{
		if (this.CurUnit == null)
		{
			Log.Instance.Error(ELogModule.ItemHint, ELogAuthor.ZJC, "里列表当前单元无效!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return this.CurUnit.GetAddItemTime();
	}

	// Token: 0x0601008A RID: 65674 RVA: 0x003E8E39 File Offset: 0x003E7039
	public void PostBattleViewOpen()
	{
		this.UpdateIndex();
		this.UpdateAllUnitMode();
	}

	// Token: 0x0601008B RID: 65675 RVA: 0x003E8E47 File Offset: 0x003E7047
	private void UpdateIndex()
	{
		this.CurIndex++;
	}

	// Token: 0x0601008C RID: 65676 RVA: 0x003E8E58 File Offset: 0x003E7058
	private void UpdateAllUnitMode()
	{
		foreach (InterfaceDataUnit interfaceDataUnit in this.InterfaceDataUnitArray)
		{
			interfaceDataUnit.Mode = EPlayMode.Fast;
		}
	}

	// Token: 0x0601008D RID: 65677 RVA: 0x003E8EAC File Offset: 0x003E70AC
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

	// Token: 0x0601008E RID: 65678 RVA: 0x003E8F34 File Offset: 0x003E7134
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

	// Token: 0x0601008F RID: 65679 RVA: 0x003E8FC7 File Offset: 0x003E71C7
	private void UpdateCurUnit()
	{
		if (this.CurUnit == null && this.InterfaceDataUnitArray.Count > 0)
		{
			this.CurUnit = this.InterfaceDataUnitArray[0];
		}
	}

	// Token: 0x06010090 RID: 65680 RVA: 0x003E8FF4 File Offset: 0x003E71F4
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

	// Token: 0x040076AF RID: 30383
	private int CurIndex;

	// Token: 0x040076B0 RID: 30384
	[Nullable(2)]
	private InterfaceDataUnit CurUnit;

	// Token: 0x040076B1 RID: 30385
	private List<InterfaceDataUnit> InterfaceDataUnitArray = new List<InterfaceDataUnit>();
}
