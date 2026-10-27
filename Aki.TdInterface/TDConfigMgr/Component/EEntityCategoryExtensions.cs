using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000936 RID: 2358
	public static class EEntityCategoryExtensions
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x0008AB84 File Offset: 0x00088D84
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

		// Token: 0x06003525 RID: 13605 RVA: 0x0008ABD8 File Offset: 0x00088DD8
		public static EEntityCategory FromString(string name)
		{
			EEntityCategory result;
			if (!EEntityCategoryExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityCategory 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0008AC04 File Offset: 0x00088E04
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

		// Token: 0x06003527 RID: 13607 RVA: 0x0008AC6C File Offset: 0x00088E6C
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

		// Token: 0x06003528 RID: 13608 RVA: 0x0008AC94 File Offset: 0x00088E94
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

		// Token: 0x06003529 RID: 13609 RVA: 0x0008ACA7 File Offset: 0x00088EA7
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
