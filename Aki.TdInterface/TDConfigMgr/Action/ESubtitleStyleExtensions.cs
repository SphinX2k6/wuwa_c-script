using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DC RID: 9948
	public static class ESubtitleStyleExtensions
	{
		// Token: 0x0600D638 RID: 54840 RVA: 0x001F20FC File Offset: 0x001F02FC
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

		// Token: 0x0600D639 RID: 54841 RVA: 0x001F2134 File Offset: 0x001F0334
		public static ESubtitleStyle FromString(string name)
		{
			ESubtitleStyle result;
			if (!ESubtitleStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubtitleStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D63A RID: 54842 RVA: 0x001F215D File Offset: 0x001F035D
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

		// Token: 0x0600D63B RID: 54843 RVA: 0x001F2196 File Offset: 0x001F0396
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelA",
				"NewLevelB"
			};
		}

		// Token: 0x0600D63C RID: 54844 RVA: 0x001F21AE File Offset: 0x001F03AE
		public static ESubtitleStyle[] GetValues()
		{
			return new ESubtitleStyle[]
			{
				ESubtitleStyle.LevelA,
				ESubtitleStyle.NewLevelB
			};
		}

		// Token: 0x0600D63D RID: 54845 RVA: 0x001F21BA File Offset: 0x001F03BA
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
