using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200237C RID: 9084
public class CumulativePayShopContentPanel : UiPanelBase
{
	// Token: 0x06012263 RID: 74339 RVA: 0x00475F88 File Offset: 0x00474188
	private void OnPreviewCheckClick()
	{
		PayShopUtil.OpenItemPreview(InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.PreviewItemConfigId)), this.PreviewItemConfigId);
	}

	// Token: 0x06012264 RID: 74340 RVA: 0x00475FAC File Offset: 0x004741AC
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

	// Token: 0x06012265 RID: 74341 RVA: 0x00475FF4 File Offset: 0x004741F4
	protected override void OnStart()
	{
		this.ApplyCheckButtonState();
	}

	// Token: 0x06012266 RID: 74342 RVA: 0x00475FFC File Offset: 0x004741FC
	public void SetCheckButtonVisible(bool active)
	{
		this.CheckBtnVisible = active;
		this.ApplyCheckButtonState();
	}

	// Token: 0x06012267 RID: 74343 RVA: 0x0047600C File Offset: 0x0047420C
	public void RefreshCheckButtonVisibility(int itemConfigId)
	{
		this.PreviewItemConfigId = itemConfigId;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemConfigId));
		this.SetCheckButtonVisible(PayShopDefine.PayShopNeedCheckBtnItemTypeSet.Contains(itemDataTypeByConfigId));
	}

	// Token: 0x06012268 RID: 74344 RVA: 0x00476044 File Offset: 0x00474244
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

	// Token: 0x04008929 RID: 35113
	[Nullable(2)]
	private PayShopCheckBtnItem CheckBtnItem;

	// Token: 0x0400892A RID: 35114
	private bool CheckBtnVisible;

	// Token: 0x0400892B RID: 35115
	private int PreviewItemConfigId;

	// Token: 0x02008918 RID: 35096
	private enum EComponents
	{
		// Token: 0x0402C8FC RID: 182524
		BtnItem
	}
}
