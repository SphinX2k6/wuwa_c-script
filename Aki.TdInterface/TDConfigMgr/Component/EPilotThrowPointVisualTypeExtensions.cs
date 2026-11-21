using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A99 RID: 2713
	public static class EPilotThrowPointVisualTypeExtensions
	{
		// Token: 0x06003BC3 RID: 15299 RVA: 0x00099B6C File Offset: 0x00097D6C
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

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00099BB4 File Offset: 0x00097DB4
		public static EPilotThrowPointVisualType FromString(string name)
		{
			EPilotThrowPointVisualType result;
			if (!EPilotThrowPointVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPilotThrowPointVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00099BE0 File Offset: 0x00097DE0
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

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00099C36 File Offset: 0x00097E36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"MainStory",
				"PlantFlag"
			};
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00099C56 File Offset: 0x00097E56
		public static EPilotThrowPointVisualType[] GetValues()
		{
			return new EPilotThrowPointVisualType[]
			{
				EPilotThrowPointVisualType.Normal,
				EPilotThrowPointVisualType.MainStory,
				EPilotThrowPointVisualType.PlantFlag
			};
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00099C66 File Offset: 0x00097E66
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
