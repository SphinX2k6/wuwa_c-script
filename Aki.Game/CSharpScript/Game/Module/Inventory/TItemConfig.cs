using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005836 RID: 22582
	[NullableContext(1)]
	[Nullable(0)]
	public class TItemConfig
	{
		// Token: 0x06039620 RID: 235040 RVA: 0x00D9DF56 File Offset: 0x00D9C156
		private TItemConfig(object value)
		{
			this._value = value;
		}

		// Token: 0x06039621 RID: 235041 RVA: 0x00D9DF65 File Offset: 0x00D9C165
		public static implicit operator TItemConfig(AbyssItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039622 RID: 235042 RVA: 0x00D9DF72 File Offset: 0x00D9C172
		public static implicit operator TItemConfig(BackgroundCard value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039623 RID: 235043 RVA: 0x00D9DF7F File Offset: 0x00D9C17F
		public static implicit operator TItemConfig(CalabashSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039624 RID: 235044 RVA: 0x00D9DF8C File Offset: 0x00D9C18C
		public static implicit operator TItemConfig(FlySkinConfig value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039625 RID: 235045 RVA: 0x00D9DF99 File Offset: 0x00D9C199
		public static implicit operator TItemConfig(ItemInfo value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039626 RID: 235046 RVA: 0x00D9DFA6 File Offset: 0x00D9C1A6
		public static implicit operator TItemConfig(PhantomBattleBadge value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039627 RID: 235047 RVA: 0x00D9DFB3 File Offset: 0x00D9C1B3
		public static implicit operator TItemConfig(PhantomBattleCard value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039628 RID: 235048 RVA: 0x00D9DFC0 File Offset: 0x00D9C1C0
		public static implicit operator TItemConfig(PhantomItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039629 RID: 235049 RVA: 0x00D9DFCD File Offset: 0x00D9C1CD
		public static implicit operator TItemConfig(PlayerHeadRe value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962A RID: 235050 RVA: 0x00D9DFDA File Offset: 0x00D9C1DA
		public static implicit operator TItemConfig(PreviewItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962B RID: 235051 RVA: 0x00D9DFE7 File Offset: 0x00D9C1E7
		public static implicit operator TItemConfig(RogueCurrency value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962C RID: 235052 RVA: 0x00D9DFF4 File Offset: 0x00D9C1F4
		public static implicit operator TItemConfig(RogueResCurrency value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962D RID: 235053 RVA: 0x00D9E001 File Offset: 0x00D9C201
		public static implicit operator TItemConfig(RoleInfo value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962E RID: 235054 RVA: 0x00D9E00E File Offset: 0x00D9C20E
		public static implicit operator TItemConfig(RoleSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0603962F RID: 235055 RVA: 0x00D9E01B File Offset: 0x00D9C21B
		public static implicit operator TItemConfig(WeaponConf value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039630 RID: 235056 RVA: 0x00D9E028 File Offset: 0x00D9C228
		public static implicit operator TItemConfig(WeaponSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039631 RID: 235057 RVA: 0x00D9E035 File Offset: 0x00D9C235
		public static implicit operator TItemConfig(Ornament value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x06039632 RID: 235058 RVA: 0x00D9E042 File Offset: 0x00D9C242
		[NullableContext(2)]
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x06039633 RID: 235059 RVA: 0x00D9E054 File Offset: 0x00D9C254
		[NullableContext(0)]
		public T? As<T>() where T : struct
		{
			object value = this._value;
			if (value is T)
			{
				T value2 = (T)((object)value);
				return new T?(value2);
			}
			return null;
		}

		// Token: 0x06039634 RID: 235060 RVA: 0x00D9E089 File Offset: 0x00D9C289
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17008A2E RID: 35374
		[Nullable(2)]
		public object this[string propertyName]
		{
			[return: Nullable(2)]
			get
			{
				PropertyInfo property = this._value.GetType().GetProperty(propertyName);
				if (property == null)
				{
					return null;
				}
				return property.GetValue(this._value);
			}
		}

		// Token: 0x17008A2F RID: 35375
		// (get) Token: 0x06039636 RID: 235062 RVA: 0x00D9E0C0 File Offset: 0x00D9C2C0
		public int[] ShowTypes
		{
			get
			{
				object value = this._value;
				if (value is ItemInfo)
				{
					return ((ItemInfo)value).GetShowTypesArray();
				}
				value = this._value;
				if (value is PreviewItem)
				{
					return ((PreviewItem)value).GetShowTypesArray();
				}
				return Array.Empty<int>();
			}
		}

		// Token: 0x17008A30 RID: 35376
		// (get) Token: 0x06039637 RID: 235063 RVA: 0x00D9E110 File Offset: 0x00D9C310
		public Dictionary<int, int> Parameters
		{
			get
			{
				object value = this._value;
				if (value is ItemInfo)
				{
					ItemInfo itemInfo = (ItemInfo)value;
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					for (int i = 0; i < itemInfo.ParametersLength; i++)
					{
						DicIntInt? dicIntInt = itemInfo.Parameters(i);
						if (dicIntInt != null)
						{
							dictionary[dicIntInt.Value.Key] = dicIntInt.Value.Value;
						}
					}
					return dictionary;
				}
				return new Dictionary<int, int>();
			}
		}

		// Token: 0x0401E03F RID: 122943
		private readonly object _value;
	}
}
