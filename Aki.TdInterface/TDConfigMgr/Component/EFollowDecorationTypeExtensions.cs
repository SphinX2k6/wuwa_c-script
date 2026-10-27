using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094C RID: 2380
	public static class EFollowDecorationTypeExtensions
	{
		// Token: 0x06003587 RID: 13703 RVA: 0x0008BB4C File Offset: 0x00089D4C
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

		// Token: 0x06003588 RID: 13704 RVA: 0x0008BB74 File Offset: 0x00089D74
		public static EFollowDecorationType FromString(string name)
		{
			EFollowDecorationType result;
			if (!EFollowDecorationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFollowDecorationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0008BB9D File Offset: 0x00089D9D
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

		// Token: 0x0600358A RID: 13706 RVA: 0x0008BBC2 File Offset: 0x00089DC2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Chair"
			};
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x0008BBD2 File Offset: 0x00089DD2
		public static EFollowDecorationType[] GetValues()
		{
			return new EFollowDecorationType[1];
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0008BBDA File Offset: 0x00089DDA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Chair"
			};
		}
	}
}
