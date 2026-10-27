using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006817 RID: 26647
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlItemTipsAttrItem : GridProxyAbstract<DangoBrawlItemTipsAttrData>
	{
		// Token: 0x060427AB RID: 272299 RVA: 0x01026744 File Offset: 0x01024944
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

		// Token: 0x060427AC RID: 272300 RVA: 0x010267D0 File Offset: 0x010249D0
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

		// Token: 0x0200C9A6 RID: 51622
		private enum EAttrComponent
		{
			// Token: 0x0403CE7B RID: 249467
			AttrIcon,
			// Token: 0x0403CE7C RID: 249468
			AttrName,
			// Token: 0x0403CE7D RID: 249469
			AttrValue
		}
	}
}
