using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047D6 RID: 18390
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HonamiTowerRecordItem : GridProxyAbstract<IHonamiTowerRecordData>
	{
		// Token: 0x0602E370 RID: 189296 RVA: 0x00CE3DC0 File Offset: 0x00CE1FC0
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

		// Token: 0x0602E371 RID: 189297 RVA: 0x00CE3E29 File Offset: 0x00CE2029
		[NullableContext(1)]
		public override void Refresh(IHonamiTowerRecordData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.RecordName, Array.Empty<object>());
			base.GetText(1).SetText(data.RecordValue, true);
		}

		// Token: 0x0200A40B RID: 41995
		private class ERecordItemType
		{
			// Token: 0x04032D6A RID: 208234
			public const int NameText = 0;

			// Token: 0x04032D6B RID: 208235
			public const int ValueText = 1;
		}
	}
}
