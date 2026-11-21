using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200521A RID: 21018
	public static class ERealmBetweenAnimExtensions
	{
		// Token: 0x060344DF RID: 214239 RVA: 0x00EA1DAC File Offset: 0x00E9FFAC
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

		// Token: 0x060344E0 RID: 214240 RVA: 0x00EA1DE4 File Offset: 0x00E9FFE4
		public static ERealmBetweenAnim FromString(string name)
		{
			ERealmBetweenAnim result;
			if (!ERealmBetweenAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERealmBetweenAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060344E1 RID: 214241 RVA: 0x00EA1E0D File Offset: 0x00EA000D
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

		// Token: 0x060344E2 RID: 214242 RVA: 0x00EA1E46 File Offset: 0x00EA0046
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AniOpen",
				"AniClose"
			};
		}

		// Token: 0x060344E3 RID: 214243 RVA: 0x00EA1E5E File Offset: 0x00EA005E
		public static ERealmBetweenAnim[] GetValues()
		{
			return new ERealmBetweenAnim[]
			{
				ERealmBetweenAnim.AniOpen,
				ERealmBetweenAnim.AniClose
			};
		}

		// Token: 0x060344E4 RID: 214244 RVA: 0x00EA1E6A File Offset: 0x00EA006A
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
