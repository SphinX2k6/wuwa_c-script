using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200041C RID: 1052
[Nullable(new byte[]
{
	0,
	1
})]
public class DrinksQTESectionFlaovr : GridProxyAbstract<IQTEFlavorInfo>
{
	// Token: 0x0600387D RID: 14461 RVA: 0x00148B63 File Offset: 0x00146D63
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x00148B9C File Offset: 0x00146D9C
	[NullableContext(1)]
	public override void Refresh(IQTEFlavorInfo data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(DrinksConfig.Instance.GetFlavorType(data.Type).Value.Icon, base.GetTexture(0), null, null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(data.Value.ToString(), true);
	}

	// Token: 0x02006746 RID: 26438
	private static class EFlavor
	{
		// Token: 0x040221B0 RID: 139696
		public const int TexIcon = 0;

		// Token: 0x040221B1 RID: 139697
		public const int Txt = 1;
	}
}
