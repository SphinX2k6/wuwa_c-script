using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FB RID: 2555
	public static class EFollowDecorationTypeExtensions
	{
		// Token: 0x060038FC RID: 14588 RVA: 0x00093804 File Offset: 0x00091A04
		public static string ToEnumString(this EFollowDecorationType value)
		{
			string result;
			if (value == EFollowDecorationType.Chair)
			{
				result = "Chair";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0009382C File Offset: 0x00091A2C
		public static EFollowDecorationType FromString(string name)
		{
			EFollowDecorationType result;
			if (!EFollowDecorationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFollowDecorationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00093855 File Offset: 0x00091A55
		public static bool TryFromString(string name, out EFollowDecorationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFollowDecorationType.Chair;
				return false;
			}
			if (name == "Chair")
			{
				value = EFollowDecorationType.Chair;
				return true;
			}
			value = EFollowDecorationType.Chair;
			return false;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0009387A File Offset: 0x00091A7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Chair"
			};
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x0009388A File Offset: 0x00091A8A
		public static EFollowDecorationType[] GetValues()
		{
			return new EFollowDecorationType[1];
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00093892 File Offset: 0x00091A92
		public static string[] GetNames()
		{
			return new string[]
			{
				"Chair"
			};
		}
	}
}
