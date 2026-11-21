using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A45 RID: 2629
	public static class ELookAtInvalidProcessExtensions
	{
		// Token: 0x06003A49 RID: 14921 RVA: 0x00096888 File Offset: 0x00094A88
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

		// Token: 0x06003A4A RID: 14922 RVA: 0x000968C0 File Offset: 0x00094AC0
		public static ELookAtInvalidProcess FromString(string name)
		{
			ELookAtInvalidProcess result;
			if (!ELookAtInvalidProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtInvalidProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x000968E9 File Offset: 0x00094AE9
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

		// Token: 0x06003A4C RID: 14924 RVA: 0x00096922 File Offset: 0x00094B22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Reset",
				"DoNothing"
			};
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0009693A File Offset: 0x00094B3A
		public static ELookAtInvalidProcess[] GetValues()
		{
			return new ELookAtInvalidProcess[]
			{
				ELookAtInvalidProcess.Reset,
				ELookAtInvalidProcess.DoNothing
			};
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00096946 File Offset: 0x00094B46
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
