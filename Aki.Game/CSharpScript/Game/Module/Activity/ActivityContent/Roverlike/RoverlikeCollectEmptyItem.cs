using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200509C RID: 20636
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeCollectEmptyItem : SyncGridProxyAbstract<IRoverlikeCollectEmptyData>
	{
		// Token: 0x06033A99 RID: 211609 RVA: 0x00E75E00 File Offset: 0x00E74000
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A9A RID: 211610 RVA: 0x00E75E6C File Offset: 0x00E7406C
		[NullableContext(1)]
		public override void Refresh(IRoverlikeCollectEmptyData data)
		{
			UUIText text = base.GetText(1);
			if (text != null && !StringUtils.IsEmpty(data.Txt))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.Txt, Array.Empty<object>());
			}
		}

		// Token: 0x0200AD65 RID: 44389
		private class EComponents
		{
			// Token: 0x0403594E RID: 219470
			public const int PanelSelf = 0;

			// Token: 0x0403594F RID: 219471
			public const int TxtInfo = 1;
		}
	}
}
