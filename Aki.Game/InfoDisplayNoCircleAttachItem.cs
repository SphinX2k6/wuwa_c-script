using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001F9C RID: 8092
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class InfoDisplayNoCircleAttachItem : AutoAttachItem<string>
{
	// Token: 0x0600FB44 RID: 64324 RVA: 0x003CDFEF File Offset: 0x003CC1EF
	public InfoDisplayNoCircleAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600FB45 RID: 64325 RVA: 0x003CE020 File Offset: 0x003CC220
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

	// Token: 0x0600FB46 RID: 64326 RVA: 0x003CE0C8 File Offset: 0x003CC2C8
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

	// Token: 0x0600FB47 RID: 64327 RVA: 0x003CE0F4 File Offset: 0x003CC2F4
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

	// Token: 0x0600FB48 RID: 64328 RVA: 0x003CE138 File Offset: 0x003CC338
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

	// Token: 0x0600FB49 RID: 64329 RVA: 0x003CE243 File Offset: 0x003CC443
	public override void OnSelect()
	{
	}

	// Token: 0x0600FB4A RID: 64330 RVA: 0x003CE245 File Offset: 0x003CC445
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600FB4B RID: 64331 RVA: 0x003CE248 File Offset: 0x003CC448
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

	// Token: 0x040074EF RID: 29935
	private const int FRONT_HIERACHY = 1;

	// Token: 0x040074F0 RID: 29936
	private const float ANIMAL_SCALE = 0.8f;

	// Token: 0x040074F1 RID: 29937
	private const float LEFT_RANGE = 0.4f;

	// Token: 0x040074F2 RID: 29938
	private const float MIDDLE_RANGE = 0.5f;

	// Token: 0x040074F3 RID: 29939
	private const float RIGHT_RANGE = 0.6f;

	// Token: 0x040074F4 RID: 29940
	private string CurrentItemData = "";

	// Token: 0x040074F5 RID: 29941
	private readonly FVector DefaultScale = new FVector(0.8f, 0.8f, 0.8f);

	// Token: 0x02008589 RID: 34185
	[NullableContext(0)]
	private class EInfoDisplayNoCircleItemComponents
	{
		// Token: 0x0402B796 RID: 178070
		public const int Btn = 0;

		// Token: 0x0402B797 RID: 178071
		public const int Texture = 1;
	}
}
