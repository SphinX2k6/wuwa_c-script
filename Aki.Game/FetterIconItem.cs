using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019CA RID: 6602
[Nullable(new byte[]
{
	0,
	1
})]
public class FetterIconItem : GridProxyAbstract<IVisionNewRecommendFetterItemData>
{
	// Token: 0x0601048F RID: 66703 RVA: 0x004C158C File Offset: 0x004BF78C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06010490 RID: 66704 RVA: 0x004C15E8 File Offset: 0x004BF7E8
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

	// Token: 0x02007BFA RID: 31738
	private enum EFetterIcon
	{
		// Token: 0x04028266 RID: 164454
		Icon,
		// Token: 0x04028267 RID: 164455
		Num,
		// Token: 0x04028268 RID: 164456
		Add
	}
}
