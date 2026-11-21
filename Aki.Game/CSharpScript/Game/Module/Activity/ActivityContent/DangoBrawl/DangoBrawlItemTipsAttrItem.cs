using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005767 RID: 22375
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlItemTipsAttrItem : GridProxyAbstract<DangoBrawlItemTipsAttrData>
	{
		// Token: 0x06037300 RID: 226048 RVA: 0x00F67C88 File Offset: 0x00F65E88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037301 RID: 226049 RVA: 0x00F67D14 File Offset: 0x00F65F14
		[NullableContext(1)]
		public override void Refresh(DangoBrawlItemTipsAttrData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.AttrIcon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.AttrName, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(data.AttrValue, true);
		}

		// Token: 0x0200B373 RID: 45939
		private enum EAttrComponent
		{
			// Token: 0x04037768 RID: 227176
			AttrIcon,
			// Token: 0x04037769 RID: 227177
			AttrName,
			// Token: 0x0403776A RID: 227178
			AttrValue
		}
	}
}
