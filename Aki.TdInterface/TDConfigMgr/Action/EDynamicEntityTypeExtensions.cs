using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230D RID: 8973
	public static class EDynamicEntityTypeExtensions
	{
		// Token: 0x0600C439 RID: 50233 RVA: 0x001CA590 File Offset: 0x001C8790
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

		// Token: 0x0600C43A RID: 50234 RVA: 0x001CA5B8 File Offset: 0x001C87B8
		public static EDynamicEntityType FromString(string name)
		{
			EDynamicEntityType result;
			if (!EDynamicEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x001CA5E1 File Offset: 0x001C87E1
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

		// Token: 0x0600C43C RID: 50236 RVA: 0x001CA606 File Offset: 0x001C8806
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VisionDisplay"
			};
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x001CA616 File Offset: 0x001C8816
		public static EDynamicEntityType[] GetValues()
		{
			return new EDynamicEntityType[1];
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x001CA61E File Offset: 0x001C881E
		public static string[] GetNames()
		{
			return new string[]
			{
				"VisionDisplay"
			};
		}
	}
}
