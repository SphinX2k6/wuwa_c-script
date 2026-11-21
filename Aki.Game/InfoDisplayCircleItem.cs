using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200145A RID: 5210
public class InfoDisplayCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x0600CF57 RID: 53079 RVA: 0x003D96DC File Offset: 0x003D78DC
	[NullableContext(1)]
	public InfoDisplayCircleItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x0600CF58 RID: 53080 RVA: 0x003D970C File Offset: 0x003D790C
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

	// Token: 0x0600CF59 RID: 53081 RVA: 0x003D97B4 File Offset: 0x003D79B4
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

	// Token: 0x0600CF5A RID: 53082 RVA: 0x003D9800 File Offset: 0x003D7A00
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

	// Token: 0x0600CF5B RID: 53083 RVA: 0x003D9982 File Offset: 0x003D7B82
	[NullableContext(2)]
	public override void SetData(object param)
	{
		this.Data = (param as string[]);
	}

	// Token: 0x0600CF5C RID: 53084 RVA: 0x003D9990 File Offset: 0x003D7B90
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

	// Token: 0x0600CF5D RID: 53085 RVA: 0x003D99D4 File Offset: 0x003D7BD4
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

	// Token: 0x040075C6 RID: 30150
	private const int FRONT_HIERACHY = 3;

	// Token: 0x040075C7 RID: 30151
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040075C8 RID: 30152
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040075C9 RID: 30153
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040075CA RID: 30154
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040075CB RID: 30155
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] Data;

	// Token: 0x040075CC RID: 30156
	[Nullable(1)]
	private string CurrentItemData = "";

	// Token: 0x040075CD RID: 30157
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0200770B RID: 30475
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x04026AB3 RID: 158387
		public const int Btn = 0;

		// Token: 0x04026AB4 RID: 158388
		public const int Texture = 1;
	}
}
