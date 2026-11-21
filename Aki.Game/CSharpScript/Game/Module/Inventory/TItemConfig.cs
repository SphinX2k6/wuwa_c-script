using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x0200480D RID: 18445
	[NullableContext(1)]
	[Nullable(0)]
	public class TItemConfig
	{
		// Token: 0x0602E534 RID: 189748 RVA: 0x00CECE16 File Offset: 0x00CEB016
		private TItemConfig(object value)
		{
			this._value = value;
		}

		// Token: 0x0602E535 RID: 189749 RVA: 0x00CECE25 File Offset: 0x00CEB025
		public static implicit operator TItemConfig(AbyssItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E536 RID: 189750 RVA: 0x00CECE32 File Offset: 0x00CEB032
		public static implicit operator TItemConfig(BackgroundCard value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E537 RID: 189751 RVA: 0x00CECE3F File Offset: 0x00CEB03F
		public static implicit operator TItemConfig(CalabashSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E538 RID: 189752 RVA: 0x00CECE4C File Offset: 0x00CEB04C
		public static implicit operator TItemConfig(FlySkinConfig value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E539 RID: 189753 RVA: 0x00CECE59 File Offset: 0x00CEB059
		public static implicit operator TItemConfig(ItemInfo value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53A RID: 189754 RVA: 0x00CECE66 File Offset: 0x00CEB066
		public static implicit operator TItemConfig(PhantomBattleBadge value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53B RID: 189755 RVA: 0x00CECE73 File Offset: 0x00CEB073
		public static implicit operator TItemConfig(PhantomBattleCard value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53C RID: 189756 RVA: 0x00CECE80 File Offset: 0x00CEB080
		public static implicit operator TItemConfig(PhantomItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53D RID: 189757 RVA: 0x00CECE8D File Offset: 0x00CEB08D
		public static implicit operator TItemConfig(PlayerHeadRe value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53E RID: 189758 RVA: 0x00CECE9A File Offset: 0x00CEB09A
		public static implicit operator TItemConfig(PreviewItem value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E53F RID: 189759 RVA: 0x00CECEA7 File Offset: 0x00CEB0A7
		public static implicit operator TItemConfig(RogueCurrency value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E540 RID: 189760 RVA: 0x00CECEB4 File Offset: 0x00CEB0B4
		public static implicit operator TItemConfig(RogueResCurrency value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E541 RID: 189761 RVA: 0x00CECEC1 File Offset: 0x00CEB0C1
		public static implicit operator TItemConfig(RoleInfo value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E542 RID: 189762 RVA: 0x00CECECE File Offset: 0x00CEB0CE
		public static implicit operator TItemConfig(RoleSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E543 RID: 189763 RVA: 0x00CECEDB File Offset: 0x00CEB0DB
		public static implicit operator TItemConfig(WeaponConf value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E544 RID: 189764 RVA: 0x00CECEE8 File Offset: 0x00CEB0E8
		public static implicit operator TItemConfig(WeaponSkin value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E545 RID: 189765 RVA: 0x00CECEF5 File Offset: 0x00CEB0F5
		public static implicit operator TItemConfig(Ornament value)
		{
			return new TItemConfig(value);
		}

		// Token: 0x0602E546 RID: 189766 RVA: 0x00CECF02 File Offset: 0x00CEB102
		[NullableContext(2)]
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x0602E547 RID: 189767 RVA: 0x00CECF14 File Offset: 0x00CEB114
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

		// Token: 0x0602E548 RID: 189768 RVA: 0x00CECF49 File Offset: 0x00CEB149
		[return: Nullable(2)]
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x0602E549 RID: 189769 RVA: 0x00CECF5C File Offset: 0x00CEB15C
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

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x0602E54A RID: 189770 RVA: 0x00CECFAC File Offset: 0x00CEB1AC
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

		// Token: 0x04018AD8 RID: 101080
		private readonly object _value;
	}
}
