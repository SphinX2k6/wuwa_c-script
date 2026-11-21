using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B4 RID: 20660
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeDataItem : GridProxyAbstract<IRoverlikeSettleDataItemData>
	{
		// Token: 0x06033B63 RID: 211811 RVA: 0x00E79494 File Offset: 0x00E77694
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

		// Token: 0x06033B64 RID: 211812 RVA: 0x00E794FD File Offset: 0x00E776FD
		public override void Refresh(IRoverlikeSettleDataItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.NameTextId, Array.Empty<object>());
			base.GetText(1).SetText(data.ValueText, true);
		}

		// Token: 0x06033B65 RID: 211813 RVA: 0x00E7952E File Offset: 0x00E7772E
		public override object GetKey(IRoverlikeSettleDataItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200AD7A RID: 44410
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359B1 RID: 219569
			public const int TxtDataName = 0;

			// Token: 0x040359B2 RID: 219570
			public const int TxtDataNum = 1;
		}
	}
}
