using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005055 RID: 20565
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TowerDefenseRoleDescItem : GridProxyAbstract<ITowerDefenseRoleDescData>
	{
		// Token: 0x06033770 RID: 210800 RVA: 0x00E69858 File Offset: 0x00E67A58
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

		// Token: 0x06033771 RID: 210801 RVA: 0x00E698E4 File Offset: 0x00E67AE4
		[NullableContext(1)]
		public override void Refresh(ITowerDefenseRoleDescData data, bool isSelected, int gridIndex)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(base.GridIndex % 2 == 0);
			}
			TowerDefenseSettle value = InstanceDungeonConfig.Instance.GetTowerDefenseSettleById(data.Title).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.BaseTitle, Array.Empty<object>());
			if (value.IsTotalRatio)
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

		// Token: 0x0200AD17 RID: 44311
		private class EDescItem
		{
			// Token: 0x04035844 RID: 219204
			public const int Bg = 0;

			// Token: 0x04035845 RID: 219205
			public const int Name = 1;

			// Token: 0x04035846 RID: 219206
			public const int NumText = 2;
		}
	}
}
