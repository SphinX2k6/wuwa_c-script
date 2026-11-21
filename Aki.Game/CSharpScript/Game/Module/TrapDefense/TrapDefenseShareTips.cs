using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A4E RID: 14926
	public class TrapDefenseShareTips : UiPanelBase
	{
		// Token: 0x060265E5 RID: 157157 RVA: 0x00ABF1E8 File Offset: 0x00ABD3E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060265E6 RID: 157158 RVA: 0x00ABF274 File Offset: 0x00ABD474
		protected override void OnStart()
		{
			ShareReward? config = ConfigShareRewardById.GetConfig(8, true);
			if (config == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = config.Value.Reward();
			int itemConfigId = 0;
			int value = 0;
			using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					itemConfigId = keyValuePair.Key;
					value = keyValuePair.Value;
				}
			}
			string iconSmall = InventoryConfig.Instance.GetItemConfig(itemConfigId).Value.IconSmall;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(iconSmall, base.GetTexture(2), null, null);
		}

		// Token: 0x0200961B RID: 38427
		private class EShare
		{
			// Token: 0x0402EDD6 RID: 191958
			public const int TxtTips = 0;

			// Token: 0x0402EDD7 RID: 191959
			public const int TxtCost = 1;

			// Token: 0x0402EDD8 RID: 191960
			public const int TexCost = 2;
		}
	}
}
