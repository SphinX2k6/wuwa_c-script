using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200680C RID: 26636
	public class DangoBrawlHandBookTitleItem : SyncGridProxyAbstract<DangBrawlHandBookTitleData>
	{
		// Token: 0x060426F6 RID: 272118 RVA: 0x01022DD0 File Offset: 0x01020FD0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060426F7 RID: 272119 RVA: 0x01022E3C File Offset: 0x0102103C
		public override void Refresh(DangBrawlHandBookTitleData data)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
		}

		// Token: 0x0200C986 RID: 51590
		private enum ETitleComponent
		{
			// Token: 0x0403CDC8 RID: 249288
			TexIcon,
			// Token: 0x0403CDC9 RID: 249289
			TxtName
		}
	}
}
