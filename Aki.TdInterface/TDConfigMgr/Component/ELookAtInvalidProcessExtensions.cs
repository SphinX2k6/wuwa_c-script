using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000992 RID: 2450
	public static class ELookAtInvalidProcessExtensions
	{
		// Token: 0x060036C2 RID: 14018 RVA: 0x0008E91C File Offset: 0x0008CB1C
		public static string ToEnumString(this ELookAtInvalidProcess value)
		{
			string result;
			if (value != ELookAtInvalidProcess.Reset)
			{
				if (value != ELookAtInvalidProcess.DoNothing)
				{
					result = value.ToString();
				}
				else
				{
					result = "DoNothing";
				}
			}
			else
			{
				result = "Reset";
			}
			return result;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0008E954 File Offset: 0x0008CB54
		public static ELookAtInvalidProcess FromString(string name)
		{
			ELookAtInvalidProcess result;
			if (!ELookAtInvalidProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtInvalidProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0008E97D File Offset: 0x0008CB7D
		public static bool TryFromString(string name, out ELookAtInvalidProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELookAtInvalidProcess.Reset;
				return false;
			}
			if (name == "Reset")
			{
				value = ELookAtInvalidProcess.Reset;
				return true;
			}
			if (!(name == "DoNothing"))
			{
				value = ELookAtInvalidProcess.Reset;
				return false;
			}
			value = ELookAtInvalidProcess.DoNothing;
			return true;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0008E9B6 File Offset: 0x0008CBB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Reset",
				"DoNothing"
			};
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x0008E9CE File Offset: 0x0008CBCE
		public static ELookAtInvalidProcess[] GetValues()
		{
			return new ELookAtInvalidProcess[]
			{
				ELookAtInvalidProcess.Reset,
				ELookAtInvalidProcess.DoNothing
			};
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0008E9DA File Offset: 0x0008CBDA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Reset",
				"DoNothing"
			};
		}
	}
}
