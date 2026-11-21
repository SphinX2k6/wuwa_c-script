using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x0200145E RID: 5214
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InfoDisplayNoCircleAttachItem : AutoAttachItem<string>
{
	// Token: 0x0600CF66 RID: 53094 RVA: 0x003D9BAF File Offset: 0x003D7DAF
	public InfoDisplayNoCircleAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600CF67 RID: 53095 RVA: 0x003D9BE0 File Offset: 0x003D7DE0
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

	// Token: 0x0600CF68 RID: 53096 RVA: 0x003D9C88 File Offset: 0x003D7E88
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

	// Token: 0x0600CF69 RID: 53097 RVA: 0x003D9CB4 File Offset: 0x003D7EB4
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

	// Token: 0x0600CF6A RID: 53098 RVA: 0x003D9CF8 File Offset: 0x003D7EF8
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
				rootItem.SetHierarchyIndex(1);
				return;
			}
		}
		else if (relativeScale3D.X != this.DefaultScale.X)
		{
			this.RootItem.SetUIItemScale(this.DefaultScale);
		}
	}

	// Token: 0x0600CF6B RID: 53099 RVA: 0x003D9E03 File Offset: 0x003D8003
	public override void OnSelect()
	{
	}

	// Token: 0x0600CF6C RID: 53100 RVA: 0x003D9E05 File Offset: 0x003D8005
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600CF6D RID: 53101 RVA: 0x003D9E08 File Offset: 0x003D8008
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

	// Token: 0x040075D1 RID: 30161
	private const int FRONT_HIERACHY = 1;

	// Token: 0x040075D2 RID: 30162
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040075D3 RID: 30163
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040075D4 RID: 30164
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040075D5 RID: 30165
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040075D6 RID: 30166
	private string CurrentItemData = "";

	// Token: 0x040075D7 RID: 30167
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x0200770E RID: 30478
	[NullableContext(0)]
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x04026AB9 RID: 158393
		public const int Btn = 0;

		// Token: 0x04026ABA RID: 158394
		public const int Texture = 1;
	}
}
