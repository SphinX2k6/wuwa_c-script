using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C6 RID: 9670
	public static class EHandBookProgressTypeExtensions
	{
		// Token: 0x0600D155 RID: 53589 RVA: 0x001E52F8 File Offset: 0x001E34F8
		public static string ToEnumString(this EHandBookProgressType value)
		{
			string result;
			if (value != EHandBookProgressType.GrantEmoji)
			{
				if (value != EHandBookProgressType.RollbackEmoji)
				{
					result = value.ToString();
				}
				else
				{
					result = "RollbackEmoji";
				}
			}
			else
			{
				result = "GrantEmoji";
			}
			return result;
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x001E5330 File Offset: 0x001E3530
		public static EHandBookProgressType FromString(string name)
		{
			EHandBookProgressType result;
			if (!EHandBookProgressTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHandBookProgressType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x001E5359 File Offset: 0x001E3559
		public static bool TryFromString(string name, out EHandBookProgressType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHandBookProgressType.GrantEmoji;
				return false;
			}
			if (name == "GrantEmoji")
			{
				value = EHandBookProgressType.GrantEmoji;
				return true;
			}
			if (!(name == "RollbackEmoji"))
			{
				value = EHandBookProgressType.GrantEmoji;
				return false;
			}
			value = EHandBookProgressType.RollbackEmoji;
			return true;
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x001E5392 File Offset: 0x001E3592
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GrantEmoji",
				"RollbackEmoji"
			};
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x001E53AA File Offset: 0x001E35AA
		public static EHandBookProgressType[] GetValues()
		{
			return new EHandBookProgressType[]
			{
				EHandBookProgressType.GrantEmoji,
				EHandBookProgressType.RollbackEmoji
			};
		}

		// Token: 0x0600D15A RID: 53594 RVA: 0x001E53B6 File Offset: 0x001E35B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"GrantEmoji",
				"RollbackEmoji"
			};
		}
	}
}
