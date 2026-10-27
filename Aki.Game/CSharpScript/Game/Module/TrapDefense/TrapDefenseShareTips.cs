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
	// Token: 0x02004AA6 RID: 19110
	public class TrapDefenseShareTips : UiPanelBase
	{
		// Token: 0x06031855 RID: 202837 RVA: 0x00B7B234 File Offset: 0x00B79434
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

		// Token: 0x06031856 RID: 202838 RVA: 0x00B7B2C0 File Offset: 0x00B794C0
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

		// Token: 0x0200ABFB RID: 44027
		private class EShare
		{
			// Token: 0x04034425 RID: 214053
			public const int TxtTips = 0;

			// Token: 0x04034426 RID: 214054
			public const int TxtCost = 1;

			// Token: 0x04034427 RID: 214055
			public const int TexCost = 2;
		}
	}
}
