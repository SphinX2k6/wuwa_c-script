using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000964 RID: 2404
	public static class EHookFetchMoveModeExtensions
	{
		// Token: 0x060035F3 RID: 13811 RVA: 0x0008C9A0 File Offset: 0x0008ABA0
		public static string ToEnumString(this EHookFetchMoveMode value)
		{
			string result;
			if (value == EHookFetchMoveMode.Uniform)
			{
				result = "Uniform";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x0008C9C8 File Offset: 0x0008ABC8
		public static EHookFetchMoveMode FromString(string name)
		{
			EHookFetchMoveMode result;
			if (!EHookFetchMoveModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookFetchMoveMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0008C9F1 File Offset: 0x0008ABF1
		public static bool TryFromString(string name, out EHookFetchMoveMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHookFetchMoveMode.Uniform;
				return false;
			}
			if (name == "Uniform")
			{
				value = EHookFetchMoveMode.Uniform;
				return true;
			}
			value = EHookFetchMoveMode.Uniform;
			return false;
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0008CA16 File Offset: 0x0008AC16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Uniform"
			};
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0008CA26 File Offset: 0x0008AC26
		public static EHookFetchMoveMode[] GetValues()
		{
			return new EHookFetchMoveMode[1];
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0008CA2E File Offset: 0x0008AC2E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Uniform"
			};
		}
	}
}
