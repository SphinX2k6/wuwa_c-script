using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002087 RID: 8327
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponAttributeView : UiViewBase
{
	// Token: 0x060148B2 RID: 84146 RVA: 0x005FCB8C File Offset: 0x005FAD8C
	public SurvivorsWeaponAttributeView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060148B3 RID: 84147 RVA: 0x005FCB98 File Offset: 0x005FAD98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060148B4 RID: 84148 RVA: 0x005FCBF4 File Offset: 0x005FADF4
	protected override void OnStart()
	{
		SurvivorsWeaponGainData survivorsWeaponGainData = this.OpenParam as SurvivorsWeaponGainData;
		if (survivorsWeaponGainData == null)
		{
			return;
		}
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
		this.CaptionItem.SetHelpBtnActive(false);
		this.WeaponAttributeItemLayout = new GenericLayout<SurvivorsWeaponAttributeItem, ISurvivorsWeaponAttributeData>(base.GetVerticalLayout(2), new Func<SurvivorsWeaponAttributeItem>(this.CreateAttributeItem), null, false, true);
		this.WeaponAttributeItemLayout.RefreshByData(survivorsWeaponGainData.GetWeaponSpecialAttributeList(), null, false);
	}

	// Token: 0x060148B5 RID: 84149 RVA: 0x005FCC7A File Offset: 0x005FAE7A
	private SurvivorsWeaponAttributeItem CreateAttributeItem()
	{
		return new SurvivorsWeaponAttributeItem();
	}

	// Token: 0x0400AE3A RID: 44602
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AE3B RID: 44603
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsWeaponAttributeItem, ISurvivorsWeaponAttributeData> WeaponAttributeItemLayout;
}
