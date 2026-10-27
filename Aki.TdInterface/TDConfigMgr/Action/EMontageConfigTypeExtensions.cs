using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002389 RID: 9097
	public static class EMontageConfigTypeExtensions
	{
		// Token: 0x0600C667 RID: 50791 RVA: 0x001D0F68 File Offset: 0x001CF168
		public static string ToEnumString(this EMontageConfigType value)
		{
			string result;
			if (value != EMontageConfigType.Asset)
			{
				if (value != EMontageConfigType.Registered)
				{
					result = value.ToString();
				}
				else
				{
					result = "Registered";
				}
			}
			else
			{
				result = "Asset";
			}
			return result;
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x001D0FA0 File Offset: 0x001CF1A0
		public static EMontageConfigType FromString(string name)
		{
			EMontageConfigType result;
			if (!EMontageConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMontageConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x001D0FC9 File Offset: 0x001CF1C9
		public static bool TryFromString(string name, out EMontageConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMontageConfigType.Asset;
				return false;
			}
			if (name == "Asset")
			{
				value = EMontageConfigType.Asset;
				return true;
			}
			if (!(name == "Registered"))
			{
				value = EMontageConfigType.Asset;
				return false;
			}
			value = EMontageConfigType.Registered;
			return true;
		}

		// Token: 0x0600C66A RID: 50794 RVA: 0x001D1002 File Offset: 0x001CF202
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Asset",
				"Registered"
			};
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x001D101A File Offset: 0x001CF21A
		public static EMontageConfigType[] GetValues()
		{
			return new EMontageConfigType[]
			{
				EMontageConfigType.Asset,
				EMontageConfigType.Registered
			};
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x001D1026 File Offset: 0x001CF226
		public static string[] GetNames()
		{
			return new string[]
			{
				"Asset",
				"Registered"
			};
		}
	}
}
