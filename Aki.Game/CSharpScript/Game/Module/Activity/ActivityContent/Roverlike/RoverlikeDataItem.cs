using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006136 RID: 24886
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeDataItem : GridProxyAbstract<IRoverlikeSettleDataItemData>
	{
		// Token: 0x0603EEA3 RID: 257699 RVA: 0x00F325B4 File Offset: 0x00F307B4
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

		// Token: 0x0603EEA4 RID: 257700 RVA: 0x00F3261D File Offset: 0x00F3081D
		public override void Refresh(IRoverlikeSettleDataItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.NameTextId, Array.Empty<object>());
			base.GetText(1).SetText(data.ValueText, true);
		}

		// Token: 0x0603EEA5 RID: 257701 RVA: 0x00F3264E File Offset: 0x00F3084E
		public override object GetKey(IRoverlikeSettleDataItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200C393 RID: 50067
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B050 RID: 241744
			public const int TxtDataName = 0;

			// Token: 0x0403B051 RID: 241745
			public const int TxtDataNum = 1;
		}
	}
}
