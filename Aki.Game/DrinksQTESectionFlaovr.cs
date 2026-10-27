using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F67 RID: 3943
[Nullable(new byte[]
{
	0,
	1
})]
public class DrinksQTESectionFlaovr : GridProxyAbstract<IQTEFlavorInfo>
{
	// Token: 0x060064E5 RID: 25829 RVA: 0x001402C7 File Offset: 0x0013E4C7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060064E6 RID: 25830 RVA: 0x00140300 File Offset: 0x0013E500
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

	// Token: 0x020075B2 RID: 30130
	private static class EFlavor
	{
		// Token: 0x04026E65 RID: 159333
		public const int TexIcon = 0;

		// Token: 0x04026E66 RID: 159334
		public const int Txt = 1;
	}
}
