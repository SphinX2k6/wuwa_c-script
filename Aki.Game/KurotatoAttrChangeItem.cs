using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CB5 RID: 7349
[Nullable(new byte[]
{
	0,
	1
})]
internal class KurotatoAttrChangeItem : GridProxyAbstract<IKurotatoAttrChangeData>
{
	// Token: 0x0600DE0D RID: 56845 RVA: 0x0033E7D7 File Offset: 0x0033C9D7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600DE0E RID: 56846 RVA: 0x0033E810 File Offset: 0x0033CA10
	[NullableContext(1)]
	public override void Refresh(IKurotatoAttrChangeData data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data.Text, true);
		base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x0200829D RID: 33437
	private static class EAttrItemComp
	{
		// Token: 0x0402A9B8 RID: 174520
		public const int TextAttr = 0;

		// Token: 0x0402A9B9 RID: 174521
		public const int TextureIcon = 1;
	}
}
