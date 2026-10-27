using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200575F RID: 22367
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelTitleItem : SyncGridProxyAbstract<KurotatoLevelTitleItemData>
	{
		// Token: 0x06038D4C RID: 232780 RVA: 0x00D802EC File Offset: 0x00D7E4EC
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

		// Token: 0x06038D4D RID: 232781 RVA: 0x00D80358 File Offset: 0x00D7E558
		[NullableContext(1)]
		public override void Refresh(KurotatoLevelTitleItemData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextId, Array.Empty<object>());
			base.SetTextureByPath(data.BgPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200B95A RID: 47450
		private enum EComponents
		{
			// Token: 0x040380D3 RID: 229587
			TextName,
			// Token: 0x040380D4 RID: 229588
			TextureBg
		}
	}
}
