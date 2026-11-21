using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000CB1 RID: 3249
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonLevelUpAttributeItem : GridProxyAbstract<IAttributeInfo>
{
	// Token: 0x060087A2 RID: 34722 RVA: 0x002943B8 File Offset: 0x002925B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
	}

	// Token: 0x060087A3 RID: 34723 RVA: 0x00294440 File Offset: 0x00292640
	[NullableContext(1)]
	public override void Refresh(IAttributeInfo data, bool isSelected, int gridIndex)
	{
		if (data.IconPath != null)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(4), null, null);
		}
		base.GetTexture(4).SetUIActive(data.IconPath != null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		if (!string.IsNullOrEmpty(data.PreText))
		{
			base.GetText(1).SetText(data.PreText, true);
		}
		else
		{
			base.GetText(1).SetUIActive(false);
		}
		base.GetItem(2).SetUIActive(data.ShowArrow.GetValueOrDefault());
		if (!string.IsNullOrEmpty(data.CurText))
		{
			base.GetText(3).SetText(data.CurText, true);
			return;
		}
		base.GetText(3).SetUIActive(false);
	}

	// Token: 0x02006F7A RID: 28538
	private enum EComponent
	{
		// Token: 0x040246B6 RID: 149174
		AttributeText,
		// Token: 0x040246B7 RID: 149175
		BeforeText,
		// Token: 0x040246B8 RID: 149176
		ArrowItem,
		// Token: 0x040246B9 RID: 149177
		AfterText,
		// Token: 0x040246BA RID: 149178
		AttributeTexture
	}
}
