using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060C8 RID: 24776
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AbyssDangoDescItem : GridProxyAbstract<IAbyssDescData>
	{
		// Token: 0x0603EA47 RID: 256583 RVA: 0x00F20D04 File Offset: 0x00F1EF04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EA48 RID: 256584 RVA: 0x00F20D90 File Offset: 0x00F1EF90
		[NullableContext(1)]
		public override void Refresh(IAbyssDescData data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(base.GridIndex % 2 == 0);
			}
			AbyssSettle? abyssSettleById = DangoAbyssConfig.Instance.GetAbyssSettleById(data.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), abyssSettleById.Value.BaseTitle, Array.Empty<object>());
			if (abyssSettleById.Value.IsTotalRatio)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(data.Count.ToString() + "%", true);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(data.Count.ToString(), true);
				return;
			}
		}

		// Token: 0x0200C313 RID: 49939
		private enum EDescItem
		{
			// Token: 0x0403AE7B RID: 241275
			Bg,
			// Token: 0x0403AE7C RID: 241276
			Name,
			// Token: 0x0403AE7D RID: 241277
			NumText
		}
	}
}
