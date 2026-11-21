using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020D8 RID: 8408
public class SurvivorsWeaponUnlockView : UiViewBase
{
	// Token: 0x06014A6F RID: 84591 RVA: 0x00604BC7 File Offset: 0x00602DC7
	[NullableContext(1)]
	public SurvivorsWeaponUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A70 RID: 84592 RVA: 0x00604BD0 File Offset: 0x00602DD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose))
		};
	}

	// Token: 0x06014A71 RID: 84593 RVA: 0x00604C90 File Offset: 0x00602E90
	protected override void OnStart()
	{
		if (SurvivorsRogueModel.Instance.ActivityData == null)
		{
			base.CloseMe(null);
			return;
		}
		int[] array = this.OpenParam as int[];
		this.ScrollView = new GenericScrollViewNew<CardScrollItem, int>(base.GetScrollViewWithScrollbar(5), () => new CardScrollItem(), null, true, null);
		if (array != null)
		{
			this.ScrollView.RefreshByData(array, null, false);
		}
	}

	// Token: 0x06014A72 RID: 84594 RVA: 0x00604D02 File Offset: 0x00602F02
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400B002 RID: 45058
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CardScrollItem, int> ScrollView;
}
