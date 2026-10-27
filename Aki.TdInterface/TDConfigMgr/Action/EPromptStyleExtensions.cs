using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E1 RID: 9185
	public static class EPromptStyleExtensions
	{
		// Token: 0x0600C7F3 RID: 51187 RVA: 0x001D44E8 File Offset: 0x001D26E8
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

		// Token: 0x0600C7F4 RID: 51188 RVA: 0x001D453C File Offset: 0x001D273C
		public static EPromptStyle FromString(string name)
		{
			EPromptStyle result;
			if (!EPromptStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPromptStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7F5 RID: 51189 RVA: 0x001D4568 File Offset: 0x001D2768
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

		// Token: 0x0600C7F6 RID: 51190 RVA: 0x001D45D0 File Offset: 0x001D27D0
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

		// Token: 0x0600C7F7 RID: 51191 RVA: 0x001D45F8 File Offset: 0x001D27F8
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

		// Token: 0x0600C7F8 RID: 51192 RVA: 0x001D460B File Offset: 0x001D280B
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
