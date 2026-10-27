using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024E3 RID: 9443
[Nullable(new byte[]
{
	0,
	1
})]
public class FetterIconItem : GridProxyAbstract<IVisionNewRecommendFetterItemData>
{
	// Token: 0x06012FD0 RID: 77776 RVA: 0x004B39CC File Offset: 0x004B1BCC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012FD1 RID: 77777 RVA: 0x004B3A28 File Offset: 0x004B1C28
	[NullableContext(1)]
	public override void Refresh(IVisionNewRecommendFetterItemData data, bool isSelected, int gridIndex)
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetFetterGroupById(data.GroupId).FetterElementPath, base.GetTexture(0), null, null);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetUIActive(data.Count > 0);
		}
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(gridIndex != 0);
	}

	// Token: 0x02008A72 RID: 35442
	private enum EFetterIcon
	{
		// Token: 0x0402CF4D RID: 184141
		Icon,
		// Token: 0x0402CF4E RID: 184142
		Num,
		// Token: 0x0402CF4F RID: 184143
		Add
	}
}
