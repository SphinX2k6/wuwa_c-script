using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002678 RID: 9848
	public static class EPromptStyleExtensions
	{
		// Token: 0x0600D476 RID: 54390 RVA: 0x001EDC94 File Offset: 0x001EBE94
		public static string ToEnumString(this EPromptStyle value)
		{
			string result;
			switch (value)
			{
			case EPromptStyle.Default:
				result = "Default";
				break;
			case EPromptStyle.Photo:
				result = "Photo";
				break;
			case EPromptStyle.Battle:
				result = "Battle";
				break;
			case EPromptStyle.Battle2:
				result = "Battle2";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D477 RID: 54391 RVA: 0x001EDCE8 File Offset: 0x001EBEE8
		public static EPromptStyle FromString(string name)
		{
			EPromptStyle result;
			if (!EPromptStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPromptStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D478 RID: 54392 RVA: 0x001EDD14 File Offset: 0x001EBF14
		public static bool TryFromString(string name, out EPromptStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPromptStyle.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EPromptStyle.Default;
				return true;
			}
			if (name == "Photo")
			{
				value = EPromptStyle.Photo;
				return true;
			}
			if (name == "Battle")
			{
				value = EPromptStyle.Battle;
				return true;
			}
			if (!(name == "Battle2"))
			{
				value = EPromptStyle.Default;
				return false;
			}
			value = EPromptStyle.Battle2;
			return true;
		}

		// Token: 0x0600D479 RID: 54393 RVA: 0x001EDD7C File Offset: 0x001EBF7C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Photo",
				"Battle",
				"Battle2"
			};
		}

		// Token: 0x0600D47A RID: 54394 RVA: 0x001EDDA4 File Offset: 0x001EBFA4
		public static EPromptStyle[] GetValues()
		{
			return new EPromptStyle[]
			{
				EPromptStyle.Default,
				EPromptStyle.Photo,
				EPromptStyle.Battle,
				EPromptStyle.Battle2
			};
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x001EDDB7 File Offset: 0x001EBFB7
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Photo",
				"Battle",
				"Battle2"
			};
		}
	}
}
