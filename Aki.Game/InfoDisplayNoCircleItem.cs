using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F9D RID: 8093
public class InfoDisplayNoCircleItem : AutoAttachExhibitionItemAbstract
{
	// Token: 0x0600FB4C RID: 64332 RVA: 0x003CE298 File Offset: 0x003CC498
	[NullableContext(1)]
	public InfoDisplayNoCircleItem(AActor uiActor) : base(uiActor)
	{
	}

	// Token: 0x0600FB4D RID: 64333 RVA: 0x003CE2C8 File Offset: 0x003CC4C8
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

	// Token: 0x0600FB4E RID: 64334 RVA: 0x003CE370 File Offset: 0x003CC570
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

	// Token: 0x0600FB4F RID: 64335 RVA: 0x003CE3D0 File Offset: 0x003CC5D0
	[NullableContext(2)]
	public override void SetData(object param)
	{
		this.Data = (param as string[]);
	}

	// Token: 0x0600FB50 RID: 64336 RVA: 0x003CE3E0 File Offset: 0x003CC5E0
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

	// Token: 0x0600FB51 RID: 64337 RVA: 0x003CE424 File Offset: 0x003CC624
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

	// Token: 0x0600FB52 RID: 64338 RVA: 0x003CE5AC File Offset: 0x003CC7AC
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

	// Token: 0x040074F6 RID: 29942
	private const int FRONT_HIERACHY = 1;

	// Token: 0x040074F7 RID: 29943
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040074F8 RID: 29944
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040074F9 RID: 29945
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040074FA RID: 29946
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040074FB RID: 29947
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] Data;

	// Token: 0x040074FC RID: 29948
	[Nullable(1)]
	private string CurrentItemData = "";

	// Token: 0x040074FD RID: 29949
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0200858A RID: 34186
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x0402B798 RID: 178072
		public const int Btn = 0;

		// Token: 0x0402B799 RID: 178073
		public const int Texture = 1;
	}
}
