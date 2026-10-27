using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001236 RID: 4662
	public static class EDetectTargetExtensions
	{
		// Token: 0x0600699A RID: 27034 RVA: 0x000FCD00 File Offset: 0x000FAF00
		public static string ToEnumString(this EDetectTarget value)
		{
			string result;
			if (value == EDetectTarget.ControlledRole)
			{
				result = "ControlledRole";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x000FCD28 File Offset: 0x000FAF28
		public static EDetectTarget FromString(string name)
		{
			EDetectTarget result;
			if (!EDetectTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x000FCD51 File Offset: 0x000FAF51
		public static bool TryFromString(string name, out EDetectTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDetectTarget.ControlledRole;
				return false;
			}
			if (name == "ControlledRole")
			{
				value = EDetectTarget.ControlledRole;
				return true;
			}
			value = EDetectTarget.ControlledRole;
			return false;
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x000FCD76 File Offset: 0x000FAF76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ControlledRole"
			};
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x000FCD86 File Offset: 0x000FAF86
		public static EDetectTarget[] GetValues()
		{
			return new EDetectTarget[1];
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x000FCD8E File Offset: 0x000FAF8E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ControlledRole"
			};
		}
	}
}
