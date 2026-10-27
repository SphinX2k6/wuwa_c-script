using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018F0 RID: 6384
public class TipsGetWayItem : UiPanelBase
{
	// Token: 0x0600BB13 RID: 47891 RVA: 0x002A5B8E File Offset: 0x002A3D8E
	[NullableContext(1)]
	public TipsGetWayItem(UUIItem uiItem, IGetWayItemData data)
	{
		this.Data = data;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BB14 RID: 47892 RVA: 0x002A5BAC File Offset: 0x002A3DAC
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

	// Token: 0x0600BB15 RID: 47893 RVA: 0x002A5CB8 File Offset: 0x002A3EB8
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

	// Token: 0x0600BB16 RID: 47894 RVA: 0x002A5D84 File Offset: 0x002A3F84
	protected override void OnBeforeDestroy()
	{
		this.Data = null;
		this.ButtonFunction = null;
	}

	// Token: 0x0600BB17 RID: 47895 RVA: 0x002A5D94 File Offset: 0x002A3F94
	private void OnButtonClicked()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x040054F6 RID: 21750
	[Nullable(2)]
	private IGetWayItemData Data;

	// Token: 0x040054F7 RID: 21751
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02007E66 RID: 32358
	private class EGetWayItemNode
	{
		// Token: 0x040295BA RID: 169402
		public const int BtnLink = 0;

		// Token: 0x040295BB RID: 169403
		public const int BtnLocked = 1;

		// Token: 0x040295BC RID: 169404
		public const int TxtLink = 2;

		// Token: 0x040295BD RID: 169405
		public const int TxtLocked = 3;
	}
}
