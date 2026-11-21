using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A47 RID: 2631
	public static class ELookAtRotateModeExtensions
	{
		// Token: 0x06003A52 RID: 14930 RVA: 0x0009699C File Offset: 0x00094B9C
		public static string ToEnumString(this ELookAtRotateMode value)
		{
			string result;
			if (value != ELookAtRotateMode.KeepInitialPitchRoll)
			{
				if (value != ELookAtRotateMode.AllAxisLookAt)
				{
					result = value.ToString();
				}
				else
				{
					result = "AllAxisLookAt";
				}
			}
			else
			{
				result = "KeepInitialPitchRoll";
			}
			return result;
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x000969D4 File Offset: 0x00094BD4
		public static ELookAtRotateMode FromString(string name)
		{
			ELookAtRotateMode result;
			if (!ELookAtRotateModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtRotateMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x000969FD File Offset: 0x00094BFD
		public static bool TryFromString(string name, out ELookAtRotateMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return false;
			}
			if (name == "KeepInitialPitchRoll")
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return true;
			}
			if (!(name == "AllAxisLookAt"))
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return false;
			}
			value = ELookAtRotateMode.AllAxisLookAt;
			return true;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00096A36 File Offset: 0x00094C36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KeepInitialPitchRoll",
				"AllAxisLookAt"
			};
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x00096A4E File Offset: 0x00094C4E
		public static ELookAtRotateMode[] GetValues()
		{
			return new ELookAtRotateMode[]
			{
				ELookAtRotateMode.KeepInitialPitchRoll,
				ELookAtRotateMode.AllAxisLookAt
			};
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x00096A5A File Offset: 0x00094C5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"KeepInitialPitchRoll",
				"AllAxisLookAt"
			};
		}
	}
}
