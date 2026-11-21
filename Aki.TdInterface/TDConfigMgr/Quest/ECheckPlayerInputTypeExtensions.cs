using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200136A RID: 4970
	public static class ECheckPlayerInputTypeExtensions
	{
		// Token: 0x06006FB7 RID: 28599 RVA: 0x00108F8C File Offset: 0x0010718C
		public static string ToEnumString(this ECheckPlayerInputType value)
		{
			string result;
			if (value == ECheckPlayerInputType.PressButton)
			{
				result = "PressButton";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00108FB4 File Offset: 0x001071B4
		public static ECheckPlayerInputType FromString(string name)
		{
			ECheckPlayerInputType result;
			if (!ECheckPlayerInputTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECheckPlayerInputType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00108FDD File Offset: 0x001071DD
		public static bool TryFromString(string name, out ECheckPlayerInputType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECheckPlayerInputType.PressButton;
				return false;
			}
			if (name == "PressButton")
			{
				value = ECheckPlayerInputType.PressButton;
				return true;
			}
			value = ECheckPlayerInputType.PressButton;
			return false;
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00109002 File Offset: 0x00107202
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PressButton"
			};
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00109012 File Offset: 0x00107212
		public static ECheckPlayerInputType[] GetValues()
		{
			return new ECheckPlayerInputType[1];
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x0010901A File Offset: 0x0010721A
		public static string[] GetNames()
		{
			return new string[]
			{
				"PressButton"
			};
		}
	}
}
