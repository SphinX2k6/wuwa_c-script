using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000590 RID: 1424
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeSuitItem : GridProxyAbstract<string>
{
	// Token: 0x060043F7 RID: 17399 RVA: 0x00177723 File Offset: 0x00175923
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x0017775C File Offset: 0x0017595C
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(data, base.GetTexture(1), null, null);
	}

	// Token: 0x0200683A RID: 26682
	private class ECom
	{
		// Token: 0x040225D3 RID: 140755
		public const int ElementBgSprite = 0;

		// Token: 0x040225D4 RID: 140756
		public const int ElementIconTexture = 1;
	}
}
