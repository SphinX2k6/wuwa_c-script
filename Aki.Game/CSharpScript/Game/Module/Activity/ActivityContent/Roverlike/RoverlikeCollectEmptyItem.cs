using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200611E RID: 24862
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeCollectEmptyItem : SyncGridProxyAbstract<IRoverlikeCollectEmptyData>
	{
		// Token: 0x0603EDD7 RID: 257495 RVA: 0x00F2EFEC File Offset: 0x00F2D1EC
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

		// Token: 0x0603EDD8 RID: 257496 RVA: 0x00F2F058 File Offset: 0x00F2D258
		[NullableContext(1)]
		public override void Refresh(IRoverlikeCollectEmptyData data)
		{
			UUIText text = base.GetText(1);
			if (text != null && !StringUtils.IsEmpty(data.Txt))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.Txt, Array.Empty<object>());
			}
		}

		// Token: 0x0200C37D RID: 50045
		private class EComponents
		{
			// Token: 0x0403AFE9 RID: 241641
			public const int PanelSelf = 0;

			// Token: 0x0403AFEA RID: 241642
			public const int TxtInfo = 1;
		}
	}
}
