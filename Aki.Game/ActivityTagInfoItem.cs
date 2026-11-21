using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001311 RID: 4881
internal class ActivityTagInfoItem : UiPanelBase
{
	// Token: 0x0600C017 RID: 49175 RVA: 0x0038C23C File Offset: 0x0038A43C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C018 RID: 49176 RVA: 0x0038C2C8 File Offset: 0x0038A4C8
	public void SetView(ActivityTitleTags data)
	{
		base.GetSprite(0).SetUIActive(!string.IsNullOrEmpty(data.DescInTip));
		base.GetText(1).SetUIActive(!string.IsNullOrEmpty(data.DescInTip));
		base.GetText(2).SetUIActive(!string.IsNullOrEmpty(data.DescInTip));
		if (string.IsNullOrEmpty(data.DescInTip))
		{
			return;
		}
		this.SetSpriteByPath(data.TogIcon, base.GetSprite(0), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TagName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.DescInTip, Array.Empty<object>());
	}

	// Token: 0x0200758A RID: 30090
	private enum EItemComponents
	{
		// Token: 0x040262B9 RID: 156345
		SprIcon,
		// Token: 0x040262BA RID: 156346
		TxtTitle,
		// Token: 0x040262BB RID: 156347
		TxtContent
	}
}
