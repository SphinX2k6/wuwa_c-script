using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002600 RID: 9728
	public static class ELongPressInteractStyleExtensions
	{
		// Token: 0x0600D25A RID: 53850 RVA: 0x001E94A8 File Offset: 0x001E76A8
		public static string ToEnumString(this ELongPressInteractStyle value)
		{
			string result;
			switch (value)
			{
			case ELongPressInteractStyle.Default:
				result = "Default";
				break;
			case ELongPressInteractStyle.TimeBackInteract:
				result = "TimeBackInteract";
				break;
			case ELongPressInteractStyle.SwordRiderInteract:
				result = "SwordRiderInteract";
				break;
			case ELongPressInteractStyle.CoreFixInteract:
				result = "CoreFixInteract";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D25B RID: 53851 RVA: 0x001E94FC File Offset: 0x001E76FC
		public static ELongPressInteractStyle FromString(string name)
		{
			ELongPressInteractStyle result;
			if (!ELongPressInteractStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELongPressInteractStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D25C RID: 53852 RVA: 0x001E9528 File Offset: 0x001E7728
		public static bool TryFromString(string name, out ELongPressInteractStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELongPressInteractStyle.Default;
				return false;
			}
			if (name == "Default")
			{
				value = ELongPressInteractStyle.Default;
				return true;
			}
			if (name == "TimeBackInteract")
			{
				value = ELongPressInteractStyle.TimeBackInteract;
				return true;
			}
			if (name == "SwordRiderInteract")
			{
				value = ELongPressInteractStyle.SwordRiderInteract;
				return true;
			}
			if (!(name == "CoreFixInteract"))
			{
				value = ELongPressInteractStyle.Default;
				return false;
			}
			value = ELongPressInteractStyle.CoreFixInteract;
			return true;
		}

		// Token: 0x0600D25D RID: 53853 RVA: 0x001E9590 File Offset: 0x001E7790
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"TimeBackInteract",
				"SwordRiderInteract",
				"CoreFixInteract"
			};
		}

		// Token: 0x0600D25E RID: 53854 RVA: 0x001E95B8 File Offset: 0x001E77B8
		public static ELongPressInteractStyle[] GetValues()
		{
			return new ELongPressInteractStyle[]
			{
				ELongPressInteractStyle.Default,
				ELongPressInteractStyle.TimeBackInteract,
				ELongPressInteractStyle.SwordRiderInteract,
				ELongPressInteractStyle.CoreFixInteract
			};
		}

		// Token: 0x0600D25F RID: 53855 RVA: 0x001E95CB File Offset: 0x001E77CB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"TimeBackInteract",
				"SwordRiderInteract",
				"CoreFixInteract"
			};
		}
	}
}
