using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A18 RID: 23064
	public sealed class SolarSchoolEndingSummaryItem : GridProxyAbstract<SolarSchoolEndingSummaryItemData>
	{
		// Token: 0x06038CC4 RID: 232644 RVA: 0x00FE5F04 File Offset: 0x00FE4104
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038CC5 RID: 232645 RVA: 0x00FE5F6D File Offset: 0x00FE416D
		public override void Refresh(SolarSchoolEndingSummaryItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TitleTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.ContentTextId, data.ContentParams);
		}

		// Token: 0x06038CC6 RID: 232646 RVA: 0x00FE5FA8 File Offset: 0x00FE41A8
		[NullableContext(1)]
		public override object GetKey(SolarSchoolEndingSummaryItemData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x0200B5D8 RID: 46552
		private class EComponents
		{
			// Token: 0x040383C3 RID: 230339
			public const int TitleText = 0;

			// Token: 0x040383C4 RID: 230340
			public const int ContentText = 1;
		}
	}
}
