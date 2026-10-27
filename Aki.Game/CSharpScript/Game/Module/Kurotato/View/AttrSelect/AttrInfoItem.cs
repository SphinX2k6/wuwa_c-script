using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200577B RID: 22395
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttrInfoItem : SyncGridProxyAbstract<IKurotatoAttrDisplay>
	{
		// Token: 0x06038E51 RID: 233041 RVA: 0x00D85BA8 File Offset: 0x00D83DA8
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

		// Token: 0x06038E52 RID: 233042 RVA: 0x00D85C14 File Offset: 0x00D83E14
		[NullableContext(1)]
		public override void Refresh(IKurotatoAttrDisplay data)
		{
			base.GetText(0).SetText(data.Text, true);
			base.SetTextureByPath(data.Icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0200B997 RID: 47511
		private class EAttrItemComp
		{
			// Token: 0x040381EB RID: 229867
			public const int TextInfo = 0;

			// Token: 0x040381EC RID: 229868
			public const int TextureIcon = 1;
		}
	}
}
