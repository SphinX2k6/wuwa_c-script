using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002287 RID: 8839
	public static class EActionMontageTypeExtensions
	{
		// Token: 0x0600C1DE RID: 49630 RVA: 0x001C4E5C File Offset: 0x001C305C
		public static string ToEnumString(this EActionMontageType value)
		{
			string result;
			if (value != EActionMontageType.Normal)
			{
				if (value != EActionMontageType.Sequence)
				{
					result = value.ToString();
				}
				else
				{
					result = "Sequence";
				}
			}
			else
			{
				result = "Normal";
			}
			return result;
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x001C4E94 File Offset: 0x001C3094
		public static EActionMontageType FromString(string name)
		{
			EActionMontageType result;
			if (!EActionMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActionMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x001C4EBD File Offset: 0x001C30BD
		public static bool TryFromString(string name, out EActionMontageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActionMontageType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EActionMontageType.Normal;
				return true;
			}
			if (!(name == "Sequence"))
			{
				value = EActionMontageType.Normal;
				return false;
			}
			value = EActionMontageType.Sequence;
			return true;
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x001C4EF6 File Offset: 0x001C30F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Sequence"
			};
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x001C4F0E File Offset: 0x001C310E
		public static EActionMontageType[] GetValues()
		{
			return new EActionMontageType[]
			{
				EActionMontageType.Normal,
				EActionMontageType.Sequence
			};
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x001C4F1A File Offset: 0x001C311A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"Sequence"
			};
		}
	}
}
