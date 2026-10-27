using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FDF RID: 8159
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageViewModel : PhantomManageViewModelBase<EPhantomManageViewData>
{
	// Token: 0x0600FFBB RID: 65467 RVA: 0x003E4928 File Offset: 0x003E2B28
	public PhantomManageViewModel()
	{
		HashSet<int> value = new HashSet<int>();
		this.DataMap.Add(EPhantomManageViewData.SelectSet, value);
		List<ItemViewData> value2 = new List<ItemViewData>();
		this.DataMap.Add(EPhantomManageViewData.ItemDataList, value2);
	}

	// Token: 0x0600FFBC RID: 65468 RVA: 0x003E4964 File Offset: 0x003E2B64
	public void SetSelectState(int uniqueId, bool add, bool notNotify = false)
	{
		HashSet<int> selectSet = this.GetSelectSet();
		if (add && !selectSet.Contains(uniqueId))
		{
			selectSet.Add(uniqueId);
		}
		else if (!add && selectSet.Contains(uniqueId))
		{
			selectSet.Remove(uniqueId);
		}
		this.SetSelectSet(selectSet, notNotify);
	}

	// Token: 0x0600FFBD RID: 65469 RVA: 0x003E49AC File Offset: 0x003E2BAC
	public void SwitchSelectState(int uniqueId, bool notNotify = false)
	{
		HashSet<int> selectSet = this.GetSelectSet();
		if (selectSet.Contains(uniqueId))
		{
			selectSet.Remove(uniqueId);
		}
		else
		{
			selectSet.Add(uniqueId);
		}
		this.SetSelectSet(selectSet, notNotify);
	}

	// Token: 0x0600FFBE RID: 65470 RVA: 0x003E49E4 File Offset: 0x003E2BE4
	public HashSet<int> GetSelectSet()
	{
		object data = base.GetData(EPhantomManageViewData.SelectSet);
		if (data == null)
		{
			return new HashSet<int>();
		}
		return data as HashSet<int>;
	}

	// Token: 0x0600FFBF RID: 65471 RVA: 0x003E4A08 File Offset: 0x003E2C08
	[NullableContext(2)]
	private void SetSelectSet(HashSet<int> selectSet, bool notNotify = false)
	{
		base.SetData(EPhantomManageViewData.SelectSet, selectSet, notNotify);
		InventoryModel.Instance.SetPhantomManageSelectSet(selectSet);
	}

	// Token: 0x0600FFC0 RID: 65472 RVA: 0x003E4A1E File Offset: 0x003E2C1E
	public void ClearSelectSet()
	{
		this.SetSelectSet(null, false);
	}

	// Token: 0x0600FFC1 RID: 65473 RVA: 0x003E4A28 File Offset: 0x003E2C28
	public void SetItemDataList(ItemViewData[] itemDataList, bool notNotify = false)
	{
		base.SetData(EPhantomManageViewData.ItemDataList, itemDataList, notNotify);
	}

	// Token: 0x0600FFC2 RID: 65474 RVA: 0x003E4A33 File Offset: 0x003E2C33
	public ItemViewData[] GetItemDataList()
	{
		return base.GetData(EPhantomManageViewData.ItemDataList) as ItemViewData[];
	}
}
