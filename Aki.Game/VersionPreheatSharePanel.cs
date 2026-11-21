using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A2F RID: 2607
public class VersionPreheatSharePanel : UiPanelBase
{
	// Token: 0x06007101 RID: 28929 RVA: 0x0022A580 File Offset: 0x00228780
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007102 RID: 28930 RVA: 0x0022A62C File Offset: 0x0022882C
	protected override void OnStart()
	{
		VersionPreheatShareData versionPreheatShareData = (VersionPreheatShareData)this.OpenParam;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), versionPreheatShareData.NameTextId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), versionPreheatShareData.ThemeTextId, Array.Empty<object>());
		base.SetTextureByPath(versionPreheatShareData.PhotoPath, base.GetTexture(0), null, null);
	}

	// Token: 0x02006D33 RID: 27955
	private class EComponents
	{
		// Token: 0x04023DB2 RID: 146866
		public const int Texture = 0;

		// Token: 0x04023DB3 RID: 146867
		public const int Name = 1;

		// Token: 0x04023DB4 RID: 146868
		public const int Time = 2;

		// Token: 0x04023DB5 RID: 146869
		public const int Desc = 3;
	}
}
