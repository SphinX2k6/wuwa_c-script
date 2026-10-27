using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243B RID: 9275
	public static class ESubtitleStyleExtensions
	{
		// Token: 0x0600C988 RID: 51592 RVA: 0x001D8234 File Offset: 0x001D6434
		public static string ToEnumString(this ESubtitleStyle value)
		{
			string result;
			if (value != ESubtitleStyle.LevelA)
			{
				if (value != ESubtitleStyle.NewLevelB)
				{
					result = value.ToString();
				}
				else
				{
					result = "NewLevelB";
				}
			}
			else
			{
				result = "LevelA";
			}
			return result;
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x001D826C File Offset: 0x001D646C
		public static ESubtitleStyle FromString(string name)
		{
			ESubtitleStyle result;
			if (!ESubtitleStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubtitleStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C98A RID: 51594 RVA: 0x001D8295 File Offset: 0x001D6495
		public static bool TryFromString(string name, out ESubtitleStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESubtitleStyle.LevelA;
				return false;
			}
			if (name == "LevelA")
			{
				value = ESubtitleStyle.LevelA;
				return true;
			}
			if (!(name == "NewLevelB"))
			{
				value = ESubtitleStyle.LevelA;
				return false;
			}
			value = ESubtitleStyle.NewLevelB;
			return true;
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x001D82CE File Offset: 0x001D64CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelA",
				"NewLevelB"
			};
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x001D82E6 File Offset: 0x001D64E6
		public static ESubtitleStyle[] GetValues()
		{
			return new ESubtitleStyle[]
			{
				ESubtitleStyle.LevelA,
				ESubtitleStyle.NewLevelB
			};
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x001D82F2 File Offset: 0x001D64F2
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelA",
				"NewLevelB"
			};
		}
	}
}
