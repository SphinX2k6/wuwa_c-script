using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001459 RID: 5209
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InfoDisplayCircleAttachItem : AutoAttachItem<string>
{
	// Token: 0x0600CF4F RID: 53071 RVA: 0x003D9434 File Offset: 0x003D7634
	public InfoDisplayCircleAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600CF50 RID: 53072 RVA: 0x003D9464 File Offset: 0x003D7664
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

	// Token: 0x0600CF51 RID: 53073 RVA: 0x003D950C File Offset: 0x003D770C
	protected override void OnRefreshItem(string data)
	{
		this.CurrentItemData = data;
		this.RefreshTexture();
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetHierarchyIndex(0);
		}
	}

	// Token: 0x0600CF52 RID: 53074 RVA: 0x003D9538 File Offset: 0x003D7738
	protected override void OnMoveItem()
	{
		float currentMovePercentage = base.GetCurrentMovePercentage();
		if (this.RootItem == null)
		{
			return;
		}
		FVector relativeScale3D = this.RootItem.RelativeScale3D;
		if (currentMovePercentage >= 0.4f && currentMovePercentage <= 0.6f)
		{
			if (currentMovePercentage >= 0.4f && currentMovePercentage <= 0.5f)
			{
				float num = currentMovePercentage - 0.4f;
				float num2 = MathUtils.Instance.Lerp(0.8f, 1f, num * 10f);
				FVector uiitemScale = new FVector(num2, num2, num2);
				this.RootItem.SetUIItemScale(uiitemScale);
			}
			else
			{
				float num = currentMovePercentage - 0.5f;
				float num3 = MathUtils.Instance.Lerp(1f, 0.8f, num * 10f);
				FVector uiitemScale2 = new FVector(num3, num3, num3);
				this.RootItem.SetUIItemScale(uiitemScale2);
			}
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetHierarchyIndex(3);
				return;
			}
		}
		else if (relativeScale3D.X != this.DefaultScale.X)
		{
			this.RootItem.SetUIItemScale(this.DefaultScale);
		}
	}

	// Token: 0x0600CF53 RID: 53075 RVA: 0x003D9644 File Offset: 0x003D7844
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

	// Token: 0x0600CF54 RID: 53076 RVA: 0x003D9685 File Offset: 0x003D7885
	public override void OnSelect()
	{
	}

	// Token: 0x0600CF55 RID: 53077 RVA: 0x003D9687 File Offset: 0x003D7887
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600CF56 RID: 53078 RVA: 0x003D968C File Offset: 0x003D788C
	private void OnClickItem()
	{
		float currentMovePercentage = base.GetCurrentMovePercentage();
		if (currentMovePercentage >= 0.4f && currentMovePercentage <= 0.6f)
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.CurrentItemData);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
			return;
		}
		EventSystem.Instance.Emit<AutoAttachItem<string>>(EEventName.ClickDisplayItem, this);
	}

	// Token: 0x040075BF RID: 30143
	private const int FRONT_HIERACHY = 3;

	// Token: 0x040075C0 RID: 30144
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040075C1 RID: 30145
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040075C2 RID: 30146
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040075C3 RID: 30147
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040075C4 RID: 30148
	private string CurrentItemData = "";

	// Token: 0x040075C5 RID: 30149
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0200770A RID: 30474
	[NullableContext(0)]
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x04026AB1 RID: 158385
		public const int Btn = 0;

		// Token: 0x04026AB2 RID: 158386
		public const int Texture = 1;
	}
}
