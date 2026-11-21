using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014B2 RID: 5298
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageViewModel : PhantomManageViewModelBase<EPhantomManageViewData>
{
	// Token: 0x0600D423 RID: 54307 RVA: 0x003F0F28 File Offset: 0x003EF128
	public PhantomManageViewModel()
	{
		HashSet<int> value = new HashSet<int>();
		this.DataMap.Add(EPhantomManageViewData.SelectSet, value);
		List<ItemViewData> value2 = new List<ItemViewData>();
		this.DataMap.Add(EPhantomManageViewData.ItemDataList, value2);
	}

	// Token: 0x0600D424 RID: 54308 RVA: 0x003F0F64 File Offset: 0x003EF164
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

	// Token: 0x0600D425 RID: 54309 RVA: 0x003F0FAC File Offset: 0x003EF1AC
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

	// Token: 0x0600D426 RID: 54310 RVA: 0x003F0FE4 File Offset: 0x003EF1E4
	public HashSet<int> GetSelectSet()
	{
		object data = base.GetData(EPhantomManageViewData.SelectSet);
		if (data == null)
		{
			return new HashSet<int>();
		}
		return data as HashSet<int>;
	}

	// Token: 0x0600D427 RID: 54311 RVA: 0x003F1008 File Offset: 0x003EF208
	[NullableContext(2)]
	private void SetSelectSet(HashSet<int> selectSet, bool notNotify = false)
	{
		base.SetData(EPhantomManageViewData.SelectSet, selectSet, notNotify);
		InventoryModel.Instance.SetPhantomManageSelectSet(selectSet);
	}

	// Token: 0x0600D428 RID: 54312 RVA: 0x003F101E File Offset: 0x003EF21E
	public void ClearSelectSet()
	{
		this.SetSelectSet(null, false);
	}

	// Token: 0x0600D429 RID: 54313 RVA: 0x003F1028 File Offset: 0x003EF228
	public void SetItemDataList(ItemViewData[] itemDataList, bool notNotify = false)
	{
		base.SetData(EPhantomManageViewData.ItemDataList, itemDataList, notNotify);
	}

	// Token: 0x0600D42A RID: 54314 RVA: 0x003F1033 File Offset: 0x003EF233
	public ItemViewData[] GetItemDataList()
	{
		return base.GetData(EPhantomManageViewData.ItemDataList) as ItemViewData[];
	}
}
