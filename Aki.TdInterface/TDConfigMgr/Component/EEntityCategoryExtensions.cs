using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E3 RID: 2531
	public static class EEntityCategoryExtensions
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x00092704 File Offset: 0x00090904
		public static string ToEnumString(this EEntityCategory value)
		{
			string result;
			switch (value)
			{
			case EEntityCategory.MonsterMatchType:
				result = "MonsterMatchType";
				break;
			case EEntityCategory.ControlMatchType:
				result = "ControlMatchType";
				break;
			case EEntityCategory.ItemFoundation:
				result = "ItemFoundation";
				break;
			case EEntityCategory.DestructibleType:
				result = "DestructibleType";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00092758 File Offset: 0x00090958
		public static EEntityCategory FromString(string name)
		{
			EEntityCategory result;
			if (!EEntityCategoryExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityCategory 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00092784 File Offset: 0x00090984
		public static bool TryFromString(string name, out EEntityCategory value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityCategory.MonsterMatchType;
				return false;
			}
			if (name == "MonsterMatchType")
			{
				value = EEntityCategory.MonsterMatchType;
				return true;
			}
			if (name == "ControlMatchType")
			{
				value = EEntityCategory.ControlMatchType;
				return true;
			}
			if (name == "ItemFoundation")
			{
				value = EEntityCategory.ItemFoundation;
				return true;
			}
			if (!(name == "DestructibleType"))
			{
				value = EEntityCategory.MonsterMatchType;
				return false;
			}
			value = EEntityCategory.DestructibleType;
			return true;
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x000927EC File Offset: 0x000909EC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MonsterMatchType",
				"ControlMatchType",
				"ItemFoundation",
				"DestructibleType"
			};
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00092814 File Offset: 0x00090A14
		public static EEntityCategory[] GetValues()
		{
			return new EEntityCategory[]
			{
				EEntityCategory.MonsterMatchType,
				EEntityCategory.ControlMatchType,
				EEntityCategory.ItemFoundation,
				EEntityCategory.DestructibleType
			};
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00092827 File Offset: 0x00090A27
		public static string[] GetNames()
		{
			return new string[]
			{
				"MonsterMatchType",
				"ControlMatchType",
				"ItemFoundation",
				"DestructibleType"
			};
		}
	}
}
