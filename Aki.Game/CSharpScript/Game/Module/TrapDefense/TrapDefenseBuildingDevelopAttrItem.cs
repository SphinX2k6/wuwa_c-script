using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A3F RID: 14911
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopAttrItem : GridProxyAbstract<ITrapDefenseBuildingDevelopAttrInfo>
	{
		// Token: 0x06026583 RID: 157059 RVA: 0x00ABD0EC File Offset: 0x00ABB2EC
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

		// Token: 0x06026584 RID: 157060 RVA: 0x00ABD178 File Offset: 0x00ABB378
		public override void Refresh(ITrapDefenseBuildingDevelopAttrInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			if (data.MultiTxt.GetValueOrDefault())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Value, Array.Empty<object>());
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(data.Value.ToString(), true);
		}

		// Token: 0x040150B4 RID: 86196
		protected ITrapDefenseBuildingDevelopAttrInfo Data;

		// Token: 0x02009610 RID: 38416
		[NullableContext(0)]
		private class EAttr
		{
			// Token: 0x0402EDA9 RID: 191913
			public const int Icon = 0;

			// Token: 0x0402EDAA RID: 191914
			public const int Title = 1;

			// Token: 0x0402EDAB RID: 191915
			public const int Value = 2;
		}
	}
}
