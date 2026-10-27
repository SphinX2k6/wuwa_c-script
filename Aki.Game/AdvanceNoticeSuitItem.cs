using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010DC RID: 4316
[Nullable(new byte[]
{
	0,
	1
})]
public class AdvanceNoticeSuitItem : GridProxyAbstract<string>
{
	// Token: 0x06007061 RID: 28769 RVA: 0x0016ED67 File Offset: 0x0016CF67
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06007062 RID: 28770 RVA: 0x0016EDA0 File Offset: 0x0016CFA0
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.SetTextureByPath(data, base.GetTexture(1), null, null);
	}

	// Token: 0x020076A6 RID: 30374
	private class ECom
	{
		// Token: 0x0402728A RID: 160394
		public const int ElementBgSprite = 0;

		// Token: 0x0402728B RID: 160395
		public const int ElementIconTexture = 1;
	}
}
