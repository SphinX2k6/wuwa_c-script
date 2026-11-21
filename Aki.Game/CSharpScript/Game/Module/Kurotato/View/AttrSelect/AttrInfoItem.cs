using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004752 RID: 18258
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttrInfoItem : SyncGridProxyAbstract<IKurotatoAttrDisplay>
	{
		// Token: 0x0602DD61 RID: 187745 RVA: 0x00CD4868 File Offset: 0x00CD2A68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DD62 RID: 187746 RVA: 0x00CD48D4 File Offset: 0x00CD2AD4
		[NullableContext(1)]
		public override void Refresh(IKurotatoAttrDisplay data)
		{
			base.GetText(0).SetText(data.Text, true);
			base.SetTextureByPath(data.Icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0200A3AF RID: 41903
		private class EAttrItemComp
		{
			// Token: 0x04032BE0 RID: 207840
			public const int TextInfo = 0;

			// Token: 0x04032BE1 RID: 207841
			public const int TextureIcon = 1;
		}
	}
}
