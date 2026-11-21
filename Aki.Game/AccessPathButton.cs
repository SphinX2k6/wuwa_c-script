using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001495 RID: 5269
public class AccessPathButton : UiPanelBase
{
	// Token: 0x0600D2B7 RID: 53943 RVA: 0x003E7DC6 File Offset: 0x003E5FC6
	[NullableContext(1)]
	public AccessPathButton(AActor rootActor, int getWayId)
	{
		this.GetWayId = getWayId;
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600D2B8 RID: 53944 RVA: 0x003E7DE0 File Offset: 0x003E5FE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIToggleComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnGetWayButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D2B9 RID: 53945 RVA: 0x003E7F2C File Offset: 0x003E612C
	protected override void OnStart()
	{
		AccessPath? accessPathConfig = InventoryConfig.Instance.GetAccessPathConfig(this.GetWayId);
		if (accessPathConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		UUIText text3 = base.GetText(2);
		UUIText text4 = base.GetText(3);
		UUIText text5 = base.GetText(4);
		UUIText text6 = base.GetText(5);
		if (text == null || text2 == null || text3 == null || text4 == null || text5 == null || text6 == null)
		{
			return;
		}
		string description = accessPathConfig.Value.Description;
		text.ShowTextNew(description);
		text2.ShowTextNew(description);
		text3.ShowTextNew(description);
		text4.ShowTextNew(description);
		text5.ShowTextNew(description);
		text6.ShowTextNew(description);
	}

	// Token: 0x0600D2BA RID: 53946 RVA: 0x003E7FE2 File Offset: 0x003E61E2
	protected override void OnBeforeDestroy()
	{
		this.OnAccessPathButtonClickedCallback = null;
	}

	// Token: 0x0600D2BB RID: 53947 RVA: 0x003E7FEB File Offset: 0x003E61EB
	[NullableContext(1)]
	public void BindOnGetWayButtonClickedCallback(Action<int> onAccessPathButtonClickedCallback)
	{
		this.OnAccessPathButtonClickedCallback = onAccessPathButtonClickedCallback;
	}

	// Token: 0x0600D2BC RID: 53948 RVA: 0x003E7FF4 File Offset: 0x003E61F4
	private void OnGetWayButtonClicked()
	{
		if (this.OnAccessPathButtonClickedCallback != null)
		{
			this.OnAccessPathButtonClickedCallback(this.GetWayId);
		}
	}

	// Token: 0x04007695 RID: 30357
	[Nullable(2)]
	private Action<int> OnAccessPathButtonClickedCallback;

	// Token: 0x04007696 RID: 30358
	private readonly int GetWayId;

	// Token: 0x0200775A RID: 30554
	private enum EChildComponentType
	{
		// Token: 0x04026BFC RID: 158716
		Text1,
		// Token: 0x04026BFD RID: 158717
		Text2,
		// Token: 0x04026BFE RID: 158718
		Text3,
		// Token: 0x04026BFF RID: 158719
		Text4,
		// Token: 0x04026C00 RID: 158720
		Text5,
		// Token: 0x04026C01 RID: 158721
		Text6,
		// Token: 0x04026C02 RID: 158722
		Button
	}
}
