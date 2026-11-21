using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005616 RID: 22038
	public static class EDropCatchTextIdExtensions
	{
		// Token: 0x0603681A RID: 223258 RVA: 0x00F36C60 File Offset: 0x00F34E60
		public static string ToEnumString(this EDropCatchTextId value)
		{
			string result;
			if (value == EDropCatchTextId.TextScoreLevel)
			{
				result = "DropCatch_ScoreLevel";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0603681B RID: 223259 RVA: 0x00F36C88 File Offset: 0x00F34E88
		public static EDropCatchTextId FromString(string name)
		{
			EDropCatchTextId result;
			if (!EDropCatchTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603681C RID: 223260 RVA: 0x00F36CB1 File Offset: 0x00F34EB1
		public static bool TryFromString(string name, out EDropCatchTextId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchTextId.TextScoreLevel;
				return false;
			}
			if (name == "DropCatch_ScoreLevel")
			{
				value = EDropCatchTextId.TextScoreLevel;
				return true;
			}
			value = EDropCatchTextId.TextScoreLevel;
			return false;
		}

		// Token: 0x0603681D RID: 223261 RVA: 0x00F36CD6 File Offset: 0x00F34ED6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DropCatch_ScoreLevel"
			};
		}

		// Token: 0x0603681E RID: 223262 RVA: 0x00F36CE6 File Offset: 0x00F34EE6
		public static EDropCatchTextId[] GetValues()
		{
			return new EDropCatchTextId[1];
		}

		// Token: 0x0603681F RID: 223263 RVA: 0x00F36CEE File Offset: 0x00F34EEE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TextScoreLevel"
			};
		}
	}
}
