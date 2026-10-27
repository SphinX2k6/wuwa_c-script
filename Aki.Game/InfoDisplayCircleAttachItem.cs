using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001F97 RID: 8087
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InfoDisplayCircleAttachItem : AutoAttachItem<string>
{
	// Token: 0x0600FB2D RID: 64301 RVA: 0x003CD874 File Offset: 0x003CBA74
	public InfoDisplayCircleAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600FB2E RID: 64302 RVA: 0x003CD8A4 File Offset: 0x003CBAA4
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

	// Token: 0x0600FB2F RID: 64303 RVA: 0x003CD94C File Offset: 0x003CBB4C
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

	// Token: 0x0600FB30 RID: 64304 RVA: 0x003CD978 File Offset: 0x003CBB78
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

	// Token: 0x0600FB31 RID: 64305 RVA: 0x003CDA84 File Offset: 0x003CBC84
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

	// Token: 0x0600FB32 RID: 64306 RVA: 0x003CDAC5 File Offset: 0x003CBCC5
	public override void OnSelect()
	{
	}

	// Token: 0x0600FB33 RID: 64307 RVA: 0x003CDAC7 File Offset: 0x003CBCC7
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600FB34 RID: 64308 RVA: 0x003CDACC File Offset: 0x003CBCCC
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

	// Token: 0x040074DD RID: 29917
	private const int FRONT_HIERACHY = 3;

	// Token: 0x040074DE RID: 29918
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040074DF RID: 29919
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040074E0 RID: 29920
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040074E1 RID: 29921
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040074E2 RID: 29922
	private string CurrentItemData = "";

	// Token: 0x040074E3 RID: 29923
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x02008585 RID: 34181
	[NullableContext(0)]
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x0402B78E RID: 178062
		public const int Btn = 0;

		// Token: 0x0402B78F RID: 178063
		public const int Texture = 1;
	}
}
