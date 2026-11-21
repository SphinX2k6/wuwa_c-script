using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A8E RID: 19086
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkWhiteCatSettleItem : GridProxyAbstract<IDreamLinkReachedData>
	{
		// Token: 0x0602FC47 RID: 195655 RVA: 0x00D5397C File Offset: 0x00D51B7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FC48 RID: 195656 RVA: 0x00D53A06 File Offset: 0x00D51C06
		[NullableContext(1)]
		public override void Refresh(IDreamLinkReachedData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
			base.GetText(2).SetText(data.Score, true);
		}

		// Token: 0x0200A70C RID: 42764
		private class EDreamLinkSettleItemDefine
		{
			// Token: 0x040339CF RID: 211407
			public const int SpriteBg = 0;

			// Token: 0x040339D0 RID: 211408
			public const int TxtTitle = 1;

			// Token: 0x040339D1 RID: 211409
			public const int TxtScore = 2;
		}
	}
}
