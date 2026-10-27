using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126C RID: 4716
	public static class EProgressBarLeftTypeExtensions
	{
		// Token: 0x06006A8D RID: 27277 RVA: 0x000FF6F4 File Offset: 0x000FD8F4
		public static string ToEnumString(this EProgressBarLeftType value)
		{
			string result;
			if (value != EProgressBarLeftType.UseCount)
			{
				if (value != EProgressBarLeftType.UseVar)
				{
					result = value.ToString();
				}
				else
				{
					result = "UseVar";
				}
			}
			else
			{
				result = "UseCount";
			}
			return result;
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x000FF72C File Offset: 0x000FD92C
		public static EProgressBarLeftType FromString(string name)
		{
			EProgressBarLeftType result;
			if (!EProgressBarLeftTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProgressBarLeftType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x000FF755 File Offset: 0x000FD955
		public static bool TryFromString(string name, out EProgressBarLeftType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProgressBarLeftType.UseCount;
				return false;
			}
			if (name == "UseCount")
			{
				value = EProgressBarLeftType.UseCount;
				return true;
			}
			if (!(name == "UseVar"))
			{
				value = EProgressBarLeftType.UseCount;
				return false;
			}
			value = EProgressBarLeftType.UseVar;
			return true;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x000FF78E File Offset: 0x000FD98E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UseCount",
				"UseVar"
			};
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x000FF7A6 File Offset: 0x000FD9A6
		public static EProgressBarLeftType[] GetValues()
		{
			return new EProgressBarLeftType[]
			{
				EProgressBarLeftType.UseCount,
				EProgressBarLeftType.UseVar
			};
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x000FF7B2 File Offset: 0x000FD9B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"UseCount",
				"UseVar"
			};
		}
	}
}
