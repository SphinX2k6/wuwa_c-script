using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013BA RID: 5050
	public static class ERecallOperationExtensions
	{
		// Token: 0x0600711F RID: 28959 RVA: 0x0010DE24 File Offset: 0x0010C024
		public static string ToEnumString(this ERecallOperation value)
		{
			string result;
			if (value != ERecallOperation.Include)
			{
				if (value != ERecallOperation.Exclude)
				{
					result = value.ToString();
				}
				else
				{
					result = "Exclude";
				}
			}
			else
			{
				result = "Include";
			}
			return result;
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x0010DE5C File Offset: 0x0010C05C
		public static ERecallOperation FromString(string name)
		{
			ERecallOperation result;
			if (!ERecallOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x0010DE85 File Offset: 0x0010C085
		public static bool TryFromString(string name, out ERecallOperation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERecallOperation.Include;
				return false;
			}
			if (name == "Include")
			{
				value = ERecallOperation.Include;
				return true;
			}
			if (!(name == "Exclude"))
			{
				value = ERecallOperation.Include;
				return false;
			}
			value = ERecallOperation.Exclude;
			return true;
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x0010DEBE File Offset: 0x0010C0BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Include",
				"Exclude"
			};
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x0010DED6 File Offset: 0x0010C0D6
		public static ERecallOperation[] GetValues()
		{
			return new ERecallOperation[]
			{
				ERecallOperation.Include,
				ERecallOperation.Exclude
			};
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x0010DEE2 File Offset: 0x0010C0E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Include",
				"Exclude"
			};
		}
	}
}
