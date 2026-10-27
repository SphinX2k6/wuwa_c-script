using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2E RID: 2606
	public static class ETeleControlDestroyConditionExtensions
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x000947C8 File Offset: 0x000929C8
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

		// Token: 0x06003981 RID: 14721 RVA: 0x00094810 File Offset: 0x00092A10
		public static ETeleControlDestroyCondition FromString(string name)
		{
			ETeleControlDestroyCondition result;
			if (!ETeleControlDestroyConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleControlDestroyCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0009483C File Offset: 0x00092A3C
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

		// Token: 0x06003983 RID: 14723 RVA: 0x00094892 File Offset: 0x00092A92
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LetGo",
				"CreateBullet",
				"Throw"
			};
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x000948B2 File Offset: 0x00092AB2
		public static ETeleControlDestroyCondition[] GetValues()
		{
			return new ETeleControlDestroyCondition[]
			{
				ETeleControlDestroyCondition.LetGo,
				ETeleControlDestroyCondition.CreateBullet,
				ETeleControlDestroyCondition.Throw
			};
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x000948C2 File Offset: 0x00092AC2
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
