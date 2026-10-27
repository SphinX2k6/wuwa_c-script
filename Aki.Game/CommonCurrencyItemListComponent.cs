using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017F2 RID: 6130
[NullableContext(1)]
[Nullable(0)]
public class CommonCurrencyItemListComponent
{
	// Token: 0x0600B37B RID: 45947 RVA: 0x0028917E File Offset: 0x0028737E
	public CommonCurrencyItemListComponent(UUIItem rootItem)
	{
		this.RootItem = rootItem;
	}

	// Token: 0x0600B37C RID: 45948 RVA: 0x00289198 File Offset: 0x00287398
	public void SetResourceId(string resourceId)
	{
		this.ResourceId = resourceId;
	}

	// Token: 0x0600B37D RID: 45949 RVA: 0x002891A1 File Offset: 0x002873A1
	private CommonCurrencyItem GetCurrentItemByItemId(int itemId)
	{
		if (PowerModel.Instance.CheckItemIfPowerItem(itemId))
		{
			return new PowerCurrencyItem();
		}
		return new CommonCurrencyItem();
	}

	// Token: 0x0600B37E RID: 45950 RVA: 0x002891BC File Offset: 0x002873BC
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

	// Token: 0x0600B37F RID: 45951 RVA: 0x00289208 File Offset: 0x00287408
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

	// Token: 0x0600B380 RID: 45952 RVA: 0x00289253 File Offset: 0x00287453
	public List<CommonCurrencyItem> GetCurrencyItemList()
	{
		return this.CurrencyItemList;
	}

	// Token: 0x04005145 RID: 20805
	private List<CommonCurrencyItem> CurrencyItemList;

	// Token: 0x04005146 RID: 20806
	private readonly UUIItem RootItem;

	// Token: 0x04005147 RID: 20807
	private string ResourceId = "UIItem_CommonCurrencyItem";

	// Token: 0x04005148 RID: 20808
	private bool IsExecuting;

	// Token: 0x04005149 RID: 20809
	[Nullable(2)]
	private int[] PendingItemIdList;
}
