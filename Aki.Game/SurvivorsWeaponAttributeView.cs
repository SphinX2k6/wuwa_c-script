using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B0B RID: 11019
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponAttributeView : UiViewBase
{
	// Token: 0x06016E81 RID: 93825 RVA: 0x005D000C File Offset: 0x005CE20C
	public SurvivorsWeaponAttributeView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06016E82 RID: 93826 RVA: 0x005D0018 File Offset: 0x005CE218
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06016E83 RID: 93827 RVA: 0x005D0074 File Offset: 0x005CE274
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

	// Token: 0x06016E84 RID: 93828 RVA: 0x005D00FA File Offset: 0x005CE2FA
	private SurvivorsWeaponAttributeItem CreateAttributeItem()
	{
		return new SurvivorsWeaponAttributeItem();
	}

	// Token: 0x0400AA34 RID: 43572
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400AA35 RID: 43573
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsWeaponAttributeItem, ISurvivorsWeaponAttributeData> WeaponAttributeItemLayout;
}
