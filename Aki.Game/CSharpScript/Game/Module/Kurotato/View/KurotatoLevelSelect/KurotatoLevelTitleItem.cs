using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02004736 RID: 18230
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelTitleItem : SyncGridProxyAbstract<KurotatoLevelTitleItemData>
	{
		// Token: 0x0602DC5C RID: 187484 RVA: 0x00CCED94 File Offset: 0x00CCCF94
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

		// Token: 0x0602DC5D RID: 187485 RVA: 0x00CCEE00 File Offset: 0x00CCD000
		[NullableContext(1)]
		public override void Refresh(KurotatoLevelTitleItemData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TextId, Array.Empty<object>());
			base.SetTextureByPath(data.BgPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200A376 RID: 41846
		private enum EComponents
		{
			// Token: 0x04032AD5 RID: 207573
			TextName,
			// Token: 0x04032AD6 RID: 207574
			TextureBg
		}
	}
}
