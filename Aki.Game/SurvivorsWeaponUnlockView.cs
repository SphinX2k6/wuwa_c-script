using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B5C RID: 11100
public class SurvivorsWeaponUnlockView : UiViewBase
{
	// Token: 0x0601703E RID: 94270 RVA: 0x005D805B File Offset: 0x005D625B
	[NullableContext(1)]
	public SurvivorsWeaponUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601703F RID: 94271 RVA: 0x005D8064 File Offset: 0x005D6264
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

	// Token: 0x06017040 RID: 94272 RVA: 0x005D8124 File Offset: 0x005D6324
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
			this.ScrollView.RefreshByData(array.ToList<int>(), null, false);
		}
	}

	// Token: 0x06017041 RID: 94273 RVA: 0x005D819B File Offset: 0x005D639B
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400ABFC RID: 44028
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CardScrollItem, int> ScrollView;
}
