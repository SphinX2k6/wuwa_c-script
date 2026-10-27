using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C6 RID: 26310
	public static class EDropCatchTextIdExtensions
	{
		// Token: 0x06041CCE RID: 269518 RVA: 0x00FF585C File Offset: 0x00FF3A5C
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

		// Token: 0x06041CCF RID: 269519 RVA: 0x00FF5884 File Offset: 0x00FF3A84
		public static EDropCatchTextId FromString(string name)
		{
			EDropCatchTextId result;
			if (!EDropCatchTextIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchTextId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CD0 RID: 269520 RVA: 0x00FF58AD File Offset: 0x00FF3AAD
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

		// Token: 0x06041CD1 RID: 269521 RVA: 0x00FF58D2 File Offset: 0x00FF3AD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DropCatch_ScoreLevel"
			};
		}

		// Token: 0x06041CD2 RID: 269522 RVA: 0x00FF58E2 File Offset: 0x00FF3AE2
		public static EDropCatchTextId[] GetValues()
		{
			return new EDropCatchTextId[1];
		}

		// Token: 0x06041CD3 RID: 269523 RVA: 0x00FF58EA File Offset: 0x00FF3AEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"TextScoreLevel"
			};
		}
	}
}
