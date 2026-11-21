using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257C RID: 9596
	public static class EDynamicEntityTypeExtensions
	{
		// Token: 0x0600D008 RID: 53256 RVA: 0x001E2458 File Offset: 0x001E0658
		public static string ToEnumString(this EDynamicEntityType value)
		{
			string result;
			if (value == EDynamicEntityType.VisionDisplay)
			{
				result = "VisionDisplay";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x001E2480 File Offset: 0x001E0680
		public static EDynamicEntityType FromString(string name)
		{
			EDynamicEntityType result;
			if (!EDynamicEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D00A RID: 53258 RVA: 0x001E24A9 File Offset: 0x001E06A9
		public static bool TryFromString(string name, out EDynamicEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDynamicEntityType.VisionDisplay;
				return false;
			}
			if (name == "VisionDisplay")
			{
				value = EDynamicEntityType.VisionDisplay;
				return true;
			}
			value = EDynamicEntityType.VisionDisplay;
			return false;
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x001E24CE File Offset: 0x001E06CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VisionDisplay"
			};
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x001E24DE File Offset: 0x001E06DE
		public static EDynamicEntityType[] GetValues()
		{
			return new EDynamicEntityType[1];
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x001E24E6 File Offset: 0x001E06E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"VisionDisplay"
			};
		}
	}
}
