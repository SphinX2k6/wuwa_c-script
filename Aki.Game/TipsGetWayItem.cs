using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DA9 RID: 3497
public class TipsGetWayItem : UiPanelBase
{
	// Token: 0x06008EFD RID: 36605 RVA: 0x002B02EE File Offset: 0x002AE4EE
	[NullableContext(1)]
	public TipsGetWayItem(UUIItem uiItem, IGetWayItemData data)
	{
		this.Data = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008EFE RID: 36606 RVA: 0x002B030C File Offset: 0x002AE50C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClicked));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008EFF RID: 36607 RVA: 0x002B0418 File Offset: 0x002AE618
	protected override void OnStart()
	{
		this.ButtonFunction = this.Data.Function;
		EGetWayItemType type = this.Data.Type;
		if (type != EGetWayItemType.Locked)
		{
			if (type == EGetWayItemType.CanJump)
			{
				base.GetButton(0).RootUIComp.Get().SetUIActive(true);
				base.GetButton(1).RootUIComp.Get().SetUIActive(false);
				base.GetText(2).ShowTextNew(this.Data.Text);
				return;
			}
		}
		else
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(true);
			base.GetText(3).ShowTextNew(this.Data.Text);
		}
	}

	// Token: 0x06008F00 RID: 36608 RVA: 0x002B04E4 File Offset: 0x002AE6E4
	protected override void OnBeforeDestroy()
	{
		this.Data = null;
		this.ButtonFunction = null;
	}

	// Token: 0x06008F01 RID: 36609 RVA: 0x002B04F4 File Offset: 0x002AE6F4
	private void OnButtonClicked()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x040055A1 RID: 21921
	[Nullable(2)]
	private IGetWayItemData Data;

	// Token: 0x040055A2 RID: 21922
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02006FED RID: 28653
	private class EGetWayItemNode
	{
		// Token: 0x040248E6 RID: 149734
		public const int BtnLink = 0;

		// Token: 0x040248E7 RID: 149735
		public const int BtnLocked = 1;

		// Token: 0x040248E8 RID: 149736
		public const int TxtLink = 2;

		// Token: 0x040248E9 RID: 149737
		public const int TxtLocked = 3;
	}
}
