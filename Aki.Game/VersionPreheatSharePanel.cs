using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001577 RID: 5495
public class VersionPreheatSharePanel : UiPanelBase
{
	// Token: 0x06009D23 RID: 40227 RVA: 0x002207D0 File Offset: 0x0021E9D0
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

	// Token: 0x06009D24 RID: 40228 RVA: 0x0022087C File Offset: 0x0021EA7C
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

	// Token: 0x02007BA8 RID: 31656
	private class EComponents
	{
		// Token: 0x04028A77 RID: 166519
		public const int Texture = 0;

		// Token: 0x04028A78 RID: 166520
		public const int Name = 1;

		// Token: 0x04028A79 RID: 166521
		public const int Time = 2;

		// Token: 0x04028A7A RID: 166522
		public const int Desc = 3;
	}
}
