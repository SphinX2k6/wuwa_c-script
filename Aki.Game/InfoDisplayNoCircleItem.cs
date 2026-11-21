using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200145F RID: 5215
public class InfoDisplayNoCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x0600CF6E RID: 53102 RVA: 0x003D9E58 File Offset: 0x003D8058
	[NullableContext(1)]
	public InfoDisplayNoCircleItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x0600CF6F RID: 53103 RVA: 0x003D9E88 File Offset: 0x003D8088
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

	// Token: 0x0600CF70 RID: 53104 RVA: 0x003D9F30 File Offset: 0x003D8130
	public void RefreshItem()
	{
		if (this.Data == null)
		{
			return;
		}
		int showItemIndex = base.GetShowItemIndex();
		if (showItemIndex < 0 || showItemIndex >= this.Data.Length)
		{
			return;
		}
		this.CurrentItemData = this.Data[showItemIndex];
		if (string.IsNullOrEmpty(this.CurrentItemData))
		{
			return;
		}
		this.RefreshTexture();
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetHierarchyIndex(0);
		}
	}

	// Token: 0x0600CF71 RID: 53105 RVA: 0x003D9F90 File Offset: 0x003D8190
	[NullableContext(2)]
	public override void SetData(object param)
	{
		this.Data = (param as string[]);
	}

	// Token: 0x0600CF72 RID: 53106 RVA: 0x003D9FA0 File Offset: 0x003D81A0
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

	// Token: 0x0600CF73 RID: 53107 RVA: 0x003D9FE4 File Offset: 0x003D81E4
	public override void OnMoveItem(float vectorX)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		AutoAttachExhibitionItem attachItem = base.GetAttachItem();
		if (((attachItem != null) ? attachItem.ExhibitionView : null) == null)
		{
			return;
		}
		Number width = attachItem.ExhibitionView.GetWidth();
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
				rootItem2.SetHierarchyIndex(1);
				return;
			}
		}
		else if (relativeScale3D.X != this.DefaultScale.X)
		{
			rootItem.SetUIItemScale(this.DefaultScale);
		}
	}

	// Token: 0x0600CF74 RID: 53108 RVA: 0x003DA16C File Offset: 0x003D836C
	private void OnClickItem()
	{
		AutoAttachExhibitionItem attachItem = base.GetAttachItem();
		bool flag;
		if (attachItem == null)
		{
			flag = (null != null);
		}
		else
		{
			AutoAttachExhibitionView exhibitionView = attachItem.ExhibitionView;
			flag = (((exhibitionView != null) ? exhibitionView.ItemActor : null) != null);
		}
		if (!flag)
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

	// Token: 0x040075D8 RID: 30168
	private const int FRONT_HIERACHY = 1;

	// Token: 0x040075D9 RID: 30169
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040075DA RID: 30170
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040075DB RID: 30171
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040075DC RID: 30172
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040075DD RID: 30173
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] Data;

	// Token: 0x040075DE RID: 30174
	[Nullable(1)]
	private string CurrentItemData = "";

	// Token: 0x040075DF RID: 30175
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0200770F RID: 30479
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x04026ABB RID: 158395
		public const int Btn = 0;

		// Token: 0x04026ABC RID: 158396
		public const int Texture = 1;
	}
}
