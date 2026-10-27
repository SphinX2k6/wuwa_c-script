using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057FF RID: 22527
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HonamiTowerRecordItem : GridProxyAbstract<IHonamiTowerRecordData>
	{
		// Token: 0x0603945C RID: 234588 RVA: 0x00D94F74 File Offset: 0x00D93174
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

		// Token: 0x0603945D RID: 234589 RVA: 0x00D94FDD File Offset: 0x00D931DD
		[NullableContext(1)]
		public override void Refresh(IHonamiTowerRecordData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.RecordName, Array.Empty<object>());
			base.GetText(1).SetText(data.RecordValue, true);
		}

		// Token: 0x0200B9F5 RID: 47605
		private class ERecordItemType
		{
			// Token: 0x0403837D RID: 230269
			public const int NameText = 0;

			// Token: 0x0403837E RID: 230270
			public const int ValueText = 1;
		}
	}
}
