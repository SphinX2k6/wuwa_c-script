using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000CAB RID: 3243
[NullableContext(1)]
[Nullable(0)]
public class CommonCurrencyItemListComponent
{
	// Token: 0x06008765 RID: 34661 RVA: 0x0029387A File Offset: 0x00291A7A
	public CommonCurrencyItemListComponent(UUIItem rootItem)
	{
		this.RootItem = rootItem;
	}

	// Token: 0x06008766 RID: 34662 RVA: 0x00293894 File Offset: 0x00291A94
	public void SetResourceId(string resourceId)
	{
		this.ResourceId = resourceId;
	}

	// Token: 0x06008767 RID: 34663 RVA: 0x0029389D File Offset: 0x00291A9D
	private CommonCurrencyItem GetCurrentItemByItemId(int itemId)
	{
		if (PowerModel.Instance.CheckItemIfPowerItem(itemId))
		{
			return new PowerCurrencyItem();
		}
		return new CommonCurrencyItem();
	}

	// Token: 0x06008768 RID: 34664 RVA: 0x002938B8 File Offset: 0x00291AB8
	private UniTask SetCurrencyItemListInternal(int[] itemIdList)
	{
		CommonCurrencyItemListComponent.<SetCurrencyItemListInternal>d__8 <SetCurrencyItemListInternal>d__;
		<SetCurrencyItemListInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCurrencyItemListInternal>d__.<>4__this = this;
		<SetCurrencyItemListInternal>d__.itemIdList = itemIdList;
		<SetCurrencyItemListInternal>d__.<>1__state = -1;
		<SetCurrencyItemListInternal>d__.<>t__builder.Start<CommonCurrencyItemListComponent.<SetCurrencyItemListInternal>d__8>(ref <SetCurrencyItemListInternal>d__);
		return <SetCurrencyItemListInternal>d__.<>t__builder.Task;
	}

	// Token: 0x06008769 RID: 34665 RVA: 0x00293904 File Offset: 0x00291B04
	public UniTask SetCurrencyItemList(int[] itemIdList)
	{
		CommonCurrencyItemListComponent.<SetCurrencyItemList>d__9 <SetCurrencyItemList>d__;
		<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCurrencyItemList>d__.<>4__this = this;
		<SetCurrencyItemList>d__.itemIdList = itemIdList;
		<SetCurrencyItemList>d__.<>1__state = -1;
		<SetCurrencyItemList>d__.<>t__builder.Start<CommonCurrencyItemListComponent.<SetCurrencyItemList>d__9>(ref <SetCurrencyItemList>d__);
		return <SetCurrencyItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600876A RID: 34666 RVA: 0x0029394F File Offset: 0x00291B4F
	public List<CommonCurrencyItem> GetCurrencyItemList()
	{
		return this.CurrencyItemList;
	}

	// Token: 0x040051F0 RID: 20976
	private List<CommonCurrencyItem> CurrencyItemList;

	// Token: 0x040051F1 RID: 20977
	private readonly UUIItem RootItem;

	// Token: 0x040051F2 RID: 20978
	private string ResourceId = "UIItem_CommonCurrencyItem";

	// Token: 0x040051F3 RID: 20979
	private bool IsExecuting;

	// Token: 0x040051F4 RID: 20980
	[Nullable(2)]
	private int[] PendingItemIdList;
}
