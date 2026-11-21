using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002514 RID: 9492
	public static class EAudioEnableTypeExtensions
	{
		// Token: 0x0600CE34 RID: 52788 RVA: 0x001DE508 File Offset: 0x001DC708
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

		// Token: 0x0600CE35 RID: 52789 RVA: 0x001DE540 File Offset: 0x001DC740
		public static EAudioEnableType FromString(string name)
		{
			EAudioEnableType result;
			if (!EAudioEnableTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioEnableType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE36 RID: 52790 RVA: 0x001DE569 File Offset: 0x001DC769
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

		// Token: 0x0600CE37 RID: 52791 RVA: 0x001DE5A2 File Offset: 0x001DC7A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x001DE5BA File Offset: 0x001DC7BA
		public static EAudioEnableType[] GetValues()
		{
			return new EAudioEnableType[]
			{
				EAudioEnableType.Enable,
				EAudioEnableType.Disable
			};
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x001DE5C6 File Offset: 0x001DC7C6
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
