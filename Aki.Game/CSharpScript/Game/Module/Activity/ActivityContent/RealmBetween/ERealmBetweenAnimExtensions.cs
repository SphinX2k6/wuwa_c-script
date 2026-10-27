using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200629C RID: 25244
	public static class ERealmBetweenAnimExtensions
	{
		// Token: 0x0603F81E RID: 260126 RVA: 0x00F5AE50 File Offset: 0x00F59050
		public static string ToEnumString(this ERealmBetweenAnim value)
		{
			string result;
			if (value != ERealmBetweenAnim.AniOpen)
			{
				if (value != ERealmBetweenAnim.AniClose)
				{
					result = value.ToString();
				}
				else
				{
					result = "AniClose";
				}
			}
			else
			{
				result = "AniOpen";
			}
			return result;
		}

		// Token: 0x0603F81F RID: 260127 RVA: 0x00F5AE88 File Offset: 0x00F59088
		public static ERealmBetweenAnim FromString(string name)
		{
			ERealmBetweenAnim result;
			if (!ERealmBetweenAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERealmBetweenAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603F820 RID: 260128 RVA: 0x00F5AEB1 File Offset: 0x00F590B1
		public static bool TryFromString(string name, out ERealmBetweenAnim value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERealmBetweenAnim.AniOpen;
				return false;
			}
			if (name == "AniOpen")
			{
				value = ERealmBetweenAnim.AniOpen;
				return true;
			}
			if (!(name == "AniClose"))
			{
				value = ERealmBetweenAnim.AniOpen;
				return false;
			}
			value = ERealmBetweenAnim.AniClose;
			return true;
		}

		// Token: 0x0603F821 RID: 260129 RVA: 0x00F5AEEA File Offset: 0x00F590EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}

		// Token: 0x0603F822 RID: 260130 RVA: 0x00F5AF02 File Offset: 0x00F59102
		public static ERealmBetweenAnim[] GetValues()
		{
			return new ERealmBetweenAnim[]
			{
				ERealmBetweenAnim.AniOpen,
				ERealmBetweenAnim.AniClose
			};
		}

		// Token: 0x0603F823 RID: 260131 RVA: 0x00F5AF0E File Offset: 0x00F5910E
		public static string[] GetNames()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}
	}
}
