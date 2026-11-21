using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002612 RID: 9746
	public static class EMontageConfigTypeExtensions
	{
		// Token: 0x0600D2AB RID: 53931 RVA: 0x001E9F3C File Offset: 0x001E813C
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

		// Token: 0x0600D2AC RID: 53932 RVA: 0x001E9F74 File Offset: 0x001E8174
		public static EMontageConfigType FromString(string name)
		{
			EMontageConfigType result;
			if (!EMontageConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMontageConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2AD RID: 53933 RVA: 0x001E9F9D File Offset: 0x001E819D
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

		// Token: 0x0600D2AE RID: 53934 RVA: 0x001E9FD6 File Offset: 0x001E81D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Asset",
				"Registered"
			};
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x001E9FEE File Offset: 0x001E81EE
		public static EMontageConfigType[] GetValues()
		{
			return new EMontageConfigType[]
			{
				EMontageConfigType.Asset,
				EMontageConfigType.Registered
			};
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x001E9FFA File Offset: 0x001E81FA
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
