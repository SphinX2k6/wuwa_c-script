using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CD RID: 8909
	public static class ECameraShakeTypeExtensions
	{
		// Token: 0x0600C319 RID: 49945 RVA: 0x001C82F0 File Offset: 0x001C64F0
		public static string ToEnumString(this ECameraShakeType value)
		{
			string result;
			if (value != ECameraShakeType.Constant)
			{
				if (value != ECameraShakeType.LinearOverRange)
				{
					result = value.ToString();
				}
				else
				{
					result = "LinearOverRange";
				}
			}
			else
			{
				result = "Constant";
			}
			return result;
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x001C8328 File Offset: 0x001C6528
		public static ECameraShakeType FromString(string name)
		{
			ECameraShakeType result;
			if (!ECameraShakeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECameraShakeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x001C8351 File Offset: 0x001C6551
		public static bool TryFromString(string name, out ECameraShakeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECameraShakeType.Constant;
				return false;
			}
			if (name == "Constant")
			{
				value = ECameraShakeType.Constant;
				return true;
			}
			if (!(name == "LinearOverRange"))
			{
				value = ECameraShakeType.Constant;
				return false;
			}
			value = ECameraShakeType.LinearOverRange;
			return true;
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x001C838A File Offset: 0x001C658A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Constant",
				"LinearOverRange"
			};
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x001C83A2 File Offset: 0x001C65A2
		public static ECameraShakeType[] GetValues()
		{
			return new ECameraShakeType[]
			{
				ECameraShakeType.Constant,
				ECameraShakeType.LinearOverRange
			};
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x001C83AE File Offset: 0x001C65AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Constant",
				"LinearOverRange"
			};
		}
	}
}
