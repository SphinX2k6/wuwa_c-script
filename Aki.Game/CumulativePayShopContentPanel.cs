using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001861 RID: 6241
public class CumulativePayShopContentPanel : UiPanelBase
{
	// Token: 0x0600F713 RID: 63251 RVA: 0x00483108 File Offset: 0x00481308
	private void OnPreviewCheckClick()
	{
		PayShopUtil.OpenItemPreview(InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.PreviewItemConfigId)), this.PreviewItemConfigId);
	}

	// Token: 0x0600F714 RID: 63252 RVA: 0x0048312C File Offset: 0x0048132C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F715 RID: 63253 RVA: 0x00483174 File Offset: 0x00481374
	protected override void OnStart()
	{
		this.ApplyCheckButtonState();
	}

	// Token: 0x0600F716 RID: 63254 RVA: 0x0048317C File Offset: 0x0048137C
	public void SetCheckButtonVisible(bool active)
	{
		this.CheckBtnVisible = active;
		this.ApplyCheckButtonState();
	}

	// Token: 0x0600F717 RID: 63255 RVA: 0x0048318C File Offset: 0x0048138C
	public void RefreshCheckButtonVisibility(int itemConfigId)
	{
		this.PreviewItemConfigId = itemConfigId;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemConfigId));
		this.SetCheckButtonVisible(PayShopDefine.PayShopNeedCheckBtnItemTypeSet.Contains(itemDataTypeByConfigId));
	}

	// Token: 0x0600F718 RID: 63256 RVA: 0x004831C4 File Offset: 0x004813C4
	private void ApplyCheckButtonState()
	{
		if (!this.CheckBtnVisible)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(0);
			AActor aactor = (item2 != null) ? item2.GetOwner() : null;
			if (aactor == null || !aactor.IsValid())
			{
				return;
			}
			if (this.CheckBtnItem == null)
			{
				this.CheckBtnItem = new PayShopCheckBtnItem();
				this.CheckBtnItem.CreateByActorAsync(aactor, null, false).ContinueWith(delegate()
				{
					this.CheckBtnItem.SetCallback(new Action(this.OnPreviewCheckClick));
					UUIItem item4 = base.GetItem(0);
					if (item4 == null)
					{
						return;
					}
					item4.SetUIActive(this.CheckBtnVisible);
				});
				return;
			}
			UUIItem item3 = base.GetItem(0);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(true);
			return;
		}
	}

	// Token: 0x04008A6E RID: 35438
	[Nullable(2)]
	private PayShopCheckBtnItem CheckBtnItem;

	// Token: 0x04008A6F RID: 35439
	private bool CheckBtnVisible;

	// Token: 0x04008A70 RID: 35440
	private int PreviewItemConfigId;

	// Token: 0x02007AA2 RID: 31394
	private enum EComponents
	{
		// Token: 0x04027C14 RID: 162836
		BtnItem
	}
}
