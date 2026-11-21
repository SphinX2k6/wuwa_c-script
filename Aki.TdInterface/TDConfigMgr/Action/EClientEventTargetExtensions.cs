using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200254E RID: 9550
	public static class EClientEventTargetExtensions
	{
		// Token: 0x0600CF39 RID: 53049 RVA: 0x001E0B40 File Offset: 0x001DED40
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

		// Token: 0x0600CF3A RID: 53050 RVA: 0x001E0B78 File Offset: 0x001DED78
		public static EClientEventTarget FromString(string name)
		{
			EClientEventTarget result;
			if (!EClientEventTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x001E0BA1 File Offset: 0x001DEDA1
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

		// Token: 0x0600CF3C RID: 53052 RVA: 0x001E0BDA File Offset: 0x001DEDDA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Ui"
			};
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x001E0BF2 File Offset: 0x001DEDF2
		public static EClientEventTarget[] GetValues()
		{
			return new EClientEventTarget[]
			{
				EClientEventTarget.Self,
				EClientEventTarget.Ui
			};
		}

		// Token: 0x0600CF3E RID: 53054 RVA: 0x001E0BFE File Offset: 0x001DEDFE
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
