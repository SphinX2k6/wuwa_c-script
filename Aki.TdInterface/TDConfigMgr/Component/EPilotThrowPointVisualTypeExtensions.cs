using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D4 RID: 2516
	public static class EPilotThrowPointVisualTypeExtensions
	{
		// Token: 0x060037EB RID: 14315 RVA: 0x000912AC File Offset: 0x0008F4AC
		public static string ToEnumString(this EPilotThrowPointVisualType value)
		{
			string result;
			switch (value)
			{
			case EPilotThrowPointVisualType.Normal:
				result = "Normal";
				break;
			case EPilotThrowPointVisualType.MainStory:
				result = "MainStory";
				break;
			case EPilotThrowPointVisualType.PlantFlag:
				result = "PlantFlag";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x000912F4 File Offset: 0x0008F4F4
		public static EPilotThrowPointVisualType FromString(string name)
		{
			EPilotThrowPointVisualType result;
			if (!EPilotThrowPointVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPilotThrowPointVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00091320 File Offset: 0x0008F520
		public static bool TryFromString(string name, out EPilotThrowPointVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPilotThrowPointVisualType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = EPilotThrowPointVisualType.Normal;
				return true;
			}
			if (name == "MainStory")
			{
				value = EPilotThrowPointVisualType.MainStory;
				return true;
			}
			if (!(name == "PlantFlag"))
			{
				value = EPilotThrowPointVisualType.Normal;
				return false;
			}
			value = EPilotThrowPointVisualType.PlantFlag;
			return true;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00091376 File Offset: 0x0008F576
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"MainStory",
				"PlantFlag"
			};
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00091396 File Offset: 0x0008F596
		public static EPilotThrowPointVisualType[] GetValues()
		{
			return new EPilotThrowPointVisualType[]
			{
				EPilotThrowPointVisualType.Normal,
				EPilotThrowPointVisualType.MainStory,
				EPilotThrowPointVisualType.PlantFlag
			};
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000913A6 File Offset: 0x0008F5A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"MainStory",
				"PlantFlag"
			};
		}
	}
}
