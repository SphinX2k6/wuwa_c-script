using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A5 RID: 8869
	public static class EAudioEnableTypeExtensions
	{
		// Token: 0x0600C265 RID: 49765 RVA: 0x001C6700 File Offset: 0x001C4900
		public static string ToEnumString(this EAudioEnableType value)
		{
			string result;
			if (value != EAudioEnableType.Enable)
			{
				if (value != EAudioEnableType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600C266 RID: 49766 RVA: 0x001C6738 File Offset: 0x001C4938
		public static EAudioEnableType FromString(string name)
		{
			EAudioEnableType result;
			if (!EAudioEnableTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioEnableType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C267 RID: 49767 RVA: 0x001C6761 File Offset: 0x001C4961
		public static bool TryFromString(string name, out EAudioEnableType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAudioEnableType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EAudioEnableType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EAudioEnableType.Enable;
				return false;
			}
			value = EAudioEnableType.Disable;
			return true;
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x001C679A File Offset: 0x001C499A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x001C67B2 File Offset: 0x001C49B2
		public static EAudioEnableType[] GetValues()
		{
			return new EAudioEnableType[]
			{
				EAudioEnableType.Enable,
				EAudioEnableType.Disable
			};
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x001C67BE File Offset: 0x001C49BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
