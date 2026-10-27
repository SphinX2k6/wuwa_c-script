using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002377 RID: 9079
	public static class ELongPressInteractStyleExtensions
	{
		// Token: 0x0600C616 RID: 50710 RVA: 0x001D04D4 File Offset: 0x001CE6D4
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

		// Token: 0x0600C617 RID: 50711 RVA: 0x001D0528 File Offset: 0x001CE728
		public static ELongPressInteractStyle FromString(string name)
		{
			ELongPressInteractStyle result;
			if (!ELongPressInteractStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELongPressInteractStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C618 RID: 50712 RVA: 0x001D0554 File Offset: 0x001CE754
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

		// Token: 0x0600C619 RID: 50713 RVA: 0x001D05BC File Offset: 0x001CE7BC
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

		// Token: 0x0600C61A RID: 50714 RVA: 0x001D05E4 File Offset: 0x001CE7E4
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

		// Token: 0x0600C61B RID: 50715 RVA: 0x001D05F7 File Offset: 0x001CE7F7
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
