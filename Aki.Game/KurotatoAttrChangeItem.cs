using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001177 RID: 4471
[Nullable(new byte[]
{
	0,
	1
})]
internal class KurotatoAttrChangeItem : GridProxyAbstract<IKurotatoAttrChangeData>
{
	// Token: 0x0600B22A RID: 45610 RVA: 0x0034A213 File Offset: 0x00348413
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600B22B RID: 45611 RVA: 0x0034A24C File Offset: 0x0034844C
	[NullableContext(1)]
	public override void Refresh(IKurotatoAttrChangeData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.Text, true);
		base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x02007427 RID: 29735
	private static class EAttrItemComp
	{
		// Token: 0x04025CE3 RID: 154851
		public const int TextAttr = 0;

		// Token: 0x04025CE4 RID: 154852
		public const int TextureIcon = 1;
	}
}
