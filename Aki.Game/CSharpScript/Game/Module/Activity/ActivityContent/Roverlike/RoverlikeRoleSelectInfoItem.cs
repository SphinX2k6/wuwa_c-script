using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006179 RID: 24953
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeRoleSelectInfoItem : GridProxyAbstract<RoverlikeRoleSelectInfoItemData>
	{
		// Token: 0x0603F12D RID: 258349 RVA: 0x00F3DD60 File Offset: 0x00F3BF60
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

		// Token: 0x0603F12E RID: 258350 RVA: 0x00F3DDCC File Offset: 0x00F3BFCC
		public override void Refresh(RoverlikeRoleSelectInfoItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.TitleTextId, Array.Empty<object>());
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, data.DescTextId, Array.Empty<object>());
			}
		}

		// Token: 0x0603F12F RID: 258351 RVA: 0x00F3DE1B File Offset: 0x00F3C01B
		public override object GetKey(RoverlikeRoleSelectInfoItemData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0200C3E3 RID: 50147
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B1C0 RID: 242112
			public const int TxtInfoTitle = 0;

			// Token: 0x0403B1C1 RID: 242113
			public const int TxtInfoDescription = 1;
		}
	}
}
