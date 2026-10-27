using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017F8 RID: 6136
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonLevelUpAttributeItem : GridProxyAbstract<IAttributeInfo>
{
	// Token: 0x0600B3B8 RID: 46008 RVA: 0x00289CBC File Offset: 0x00287EBC
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

	// Token: 0x0600B3B9 RID: 46009 RVA: 0x00289D44 File Offset: 0x00287F44
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

	// Token: 0x02007DF4 RID: 32244
	private enum EComponent
	{
		// Token: 0x0402938B RID: 168843
		AttributeText,
		// Token: 0x0402938C RID: 168844
		BeforeText,
		// Token: 0x0402938D RID: 168845
		ArrowItem,
		// Token: 0x0402938E RID: 168846
		AfterText,
		// Token: 0x0402938F RID: 168847
		AttributeTexture
	}
}
