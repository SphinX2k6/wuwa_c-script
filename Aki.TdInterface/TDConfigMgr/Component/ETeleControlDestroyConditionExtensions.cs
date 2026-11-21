using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF3 RID: 2803
	public static class ETeleControlDestroyConditionExtensions
	{
		// Token: 0x06003D58 RID: 15704 RVA: 0x0009D0FC File Offset: 0x0009B2FC
		public static string ToEnumString(this ETeleControlDestroyCondition value)
		{
			string result;
			switch (value)
			{
			case ETeleControlDestroyCondition.LetGo:
				result = "LetGo";
				break;
			case ETeleControlDestroyCondition.CreateBullet:
				result = "CreateBullet";
				break;
			case ETeleControlDestroyCondition.Throw:
				result = "Throw";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x0009D144 File Offset: 0x0009B344
		public static ETeleControlDestroyCondition FromString(string name)
		{
			ETeleControlDestroyCondition result;
			if (!ETeleControlDestroyConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleControlDestroyCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x0009D170 File Offset: 0x0009B370
		public static bool TryFromString(string name, out ETeleControlDestroyCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleControlDestroyCondition.LetGo;
				return false;
			}
			if (name == "LetGo")
			{
				value = ETeleControlDestroyCondition.LetGo;
				return true;
			}
			if (name == "CreateBullet")
			{
				value = ETeleControlDestroyCondition.CreateBullet;
				return true;
			}
			if (!(name == "Throw"))
			{
				value = ETeleControlDestroyCondition.LetGo;
				return false;
			}
			value = ETeleControlDestroyCondition.Throw;
			return true;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x0009D1C6 File Offset: 0x0009B3C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LetGo",
				"CreateBullet",
				"Throw"
			};
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x0009D1E6 File Offset: 0x0009B3E6
		public static ETeleControlDestroyCondition[] GetValues()
		{
			return new ETeleControlDestroyCondition[]
			{
				ETeleControlDestroyCondition.LetGo,
				ETeleControlDestroyCondition.CreateBullet,
				ETeleControlDestroyCondition.Throw
			};
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x0009D1F6 File Offset: 0x0009B3F6
		public static string[] GetNames()
		{
			return new string[]
			{
				"LetGo",
				"CreateBullet",
				"Throw"
			};
		}
	}
}
