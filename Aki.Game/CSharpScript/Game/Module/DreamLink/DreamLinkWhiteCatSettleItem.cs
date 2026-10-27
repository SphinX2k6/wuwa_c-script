using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB2 RID: 23218
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkWhiteCatSettleItem : GridProxyAbstract<IDreamLinkReachedData>
	{
		// Token: 0x0603ACFB RID: 240891 RVA: 0x00E033B4 File Offset: 0x00E015B4
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

		// Token: 0x0603ACFC RID: 240892 RVA: 0x00E0343E File Offset: 0x00E0163E
		[NullableContext(1)]
		public override void Refresh(IDreamLinkReachedData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
			base.GetText(2).SetText(data.Score, true);
		}

		// Token: 0x0200BD04 RID: 48388
		private class EDreamLinkSettleItemDefine
		{
			// Token: 0x04039005 RID: 233477
			public const int SpriteBg = 0;

			// Token: 0x04039006 RID: 233478
			public const int TxtTitle = 1;

			// Token: 0x04039007 RID: 233479
			public const int TxtScore = 2;
		}
	}
}
