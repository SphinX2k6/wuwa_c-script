using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F98 RID: 8088
public class InfoDisplayCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x0600FB35 RID: 64309 RVA: 0x003CDB1C File Offset: 0x003CBD1C
	[NullableContext(1)]
	public InfoDisplayCircleItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x0600FB36 RID: 64310 RVA: 0x003CDB4C File Offset: 0x003CBD4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB37 RID: 64311 RVA: 0x003CDBF4 File Offset: 0x003CBDF4
	public override void RefreshItem(int showItemIndex)
	{
		if (this.Data == null)
		{
			return;
		}
		if (showItemIndex >= 0 && showItemIndex < this.Data.Length)
		{
			this.CurrentItemData = this.Data[showItemIndex];
		}
		this.RefreshTexture();
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetHierarchyIndex(0);
		}
	}

	// Token: 0x0600FB38 RID: 64312 RVA: 0x003CDC40 File Offset: 0x003CBE40
	public override void OnMoveItem(float vectorX)
	{
		AutoAttachExhibitionItem attachItem = base.GetAttachItem();
		if (attachItem == null || attachItem.ExhibitionView == null)
		{
			return;
		}
		Number width = attachItem.ExhibitionView.GetWidth();
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		Number a = (rootItem.GetAnchorOffsetX() + width / 2) / width;
		FVector relativeScale3D = rootItem.RelativeScale3D;
		if (a >= 0.4f && a <= 0.6f)
		{
			if (a >= 0.4f && a <= 0.5f)
			{
				float num = a - 0.4f;
				float num2 = MathUtils.Instance.Lerp(0.8f, 1f, num * 10f);
				FVector uiitemScale = new FVector(num2, num2, num2);
				rootItem.SetUIItemScale(uiitemScale);
			}
			else
			{
				float num = a - 0.5f;
				float num3 = MathUtils.Instance.Lerp(1f, 0.8f, num * 10f);
				FVector uiitemScale2 = new FVector(num3, num3, num3);
				rootItem.SetUIItemScale(uiitemScale2);
			}
			UUIItem rootItem2 = base.GetRootItem();
			if (rootItem2 != null)
			{
				rootItem2.SetHierarchyIndex(3);
				return;
			}
		}
		else if (relativeScale3D.X != this.DefaultScale.X)
		{
			rootItem.SetUIItemScale(this.DefaultScale);
		}
	}

	// Token: 0x0600FB39 RID: 64313 RVA: 0x003CDDC2 File Offset: 0x003CBFC2
	[NullableContext(2)]
	public override void SetData(object param)
	{
		this.Data = (param as string[]);
	}

	// Token: 0x0600FB3A RID: 64314 RVA: 0x003CDDD0 File Offset: 0x003CBFD0
	private void RefreshTexture()
	{
		if (this.CurrentItemData != "")
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				base.SetTextureByPath(this.CurrentItemData, texture, null, null);
			}
		}
	}

	// Token: 0x0600FB3B RID: 64315 RVA: 0x003CDE14 File Offset: 0x003CC014
	private void OnClickItem()
	{
		AutoAttachExhibitionItem attachItem = base.GetAttachItem();
		if (attachItem == null || attachItem.ExhibitionView == null || attachItem.ExhibitionView.ItemActor == null)
		{
			return;
		}
		float width = attachItem.ExhibitionView.ItemActor.GetWidth();
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		float num = (rootItem.GetAnchorOffsetX() + width / 2f) / width;
		if (num >= 0.4f && num <= 0.6f)
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.CurrentItemData);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x040074E4 RID: 29924
	private const int FRONT_HIERACHY = 3;

	// Token: 0x040074E5 RID: 29925
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040074E6 RID: 29926
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040074E7 RID: 29927
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040074E8 RID: 29928
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040074E9 RID: 29929
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] Data;

	// Token: 0x040074EA RID: 29930
	[Nullable(1)]
	private string CurrentItemData = "";

	// Token: 0x040074EB RID: 29931
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x02008586 RID: 34182
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x0402B790 RID: 178064
		public const int Btn = 0;

		// Token: 0x0402B791 RID: 178065
		public const int Texture = 1;
	}
}
