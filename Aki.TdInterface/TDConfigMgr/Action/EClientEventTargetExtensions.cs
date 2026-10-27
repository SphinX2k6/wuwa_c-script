using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DF RID: 8927
	public static class EClientEventTargetExtensions
	{
		// Token: 0x0600C36A RID: 50026 RVA: 0x001C8D38 File Offset: 0x001C6F38
		public static string ToEnumString(this EClientEventTarget value)
		{
			string result;
			if (value != EClientEventTarget.Self)
			{
				if (value != EClientEventTarget.Ui)
				{
					result = value.ToString();
				}
				else
				{
					result = "Ui";
				}
			}
			else
			{
				result = "Self";
			}
			return result;
		}

		// Token: 0x0600C36B RID: 50027 RVA: 0x001C8D70 File Offset: 0x001C6F70
		public static EClientEventTarget FromString(string name)
		{
			EClientEventTarget result;
			if (!EClientEventTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x001C8D99 File Offset: 0x001C6F99
		public static bool TryFromString(string name, out EClientEventTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientEventTarget.Self;
				return false;
			}
			if (name == "Self")
			{
				value = EClientEventTarget.Self;
				return true;
			}
			if (!(name == "Ui"))
			{
				value = EClientEventTarget.Self;
				return false;
			}
			value = EClientEventTarget.Ui;
			return true;
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x001C8DD2 File Offset: 0x001C6FD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Ui"
			};
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x001C8DEA File Offset: 0x001C6FEA
		public static EClientEventTarget[] GetValues()
		{
			return new EClientEventTarget[]
			{
				EClientEventTarget.Self,
				EClientEventTarget.Ui
			};
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x001C8DF6 File Offset: 0x001C6FF6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Self",
				"Ui"
			};
		}
	}
}
