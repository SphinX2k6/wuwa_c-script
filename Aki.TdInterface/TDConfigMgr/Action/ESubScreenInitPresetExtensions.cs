using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002435 RID: 9269
	public static class ESubScreenInitPresetExtensions
	{
		// Token: 0x0600C96D RID: 51565 RVA: 0x001D7E40 File Offset: 0x001D6040
		public static string ToEnumString(this ESubScreenInitPreset value)
		{
			string result;
			switch (value)
			{
			case ESubScreenInitPreset.Left:
				result = "Left";
				break;
			case ESubScreenInitPreset.Right:
				result = "Right";
				break;
			case ESubScreenInitPreset.Top:
				result = "Top";
				break;
			case ESubScreenInitPreset.Bottom:
				result = "Bottom";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x001D7E94 File Offset: 0x001D6094
		public static ESubScreenInitPreset FromString(string name)
		{
			ESubScreenInitPreset result;
			if (!ESubScreenInitPresetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenInitPreset 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x001D7EC0 File Offset: 0x001D60C0
		public static bool TryFromString(string name, out ESubScreenInitPreset value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESubScreenInitPreset.Left;
				return false;
			}
			if (name == "Left")
			{
				value = ESubScreenInitPreset.Left;
				return true;
			}
			if (name == "Right")
			{
				value = ESubScreenInitPreset.Right;
				return true;
			}
			if (name == "Top")
			{
				value = ESubScreenInitPreset.Top;
				return true;
			}
			if (!(name == "Bottom"))
			{
				value = ESubScreenInitPreset.Left;
				return false;
			}
			value = ESubScreenInitPreset.Bottom;
			return true;
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x001D7F28 File Offset: 0x001D6128
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Right",
				"Top",
				"Bottom"
			};
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x001D7F50 File Offset: 0x001D6150
		public static ESubScreenInitPreset[] GetValues()
		{
			return new ESubScreenInitPreset[]
			{
				ESubScreenInitPreset.Left,
				ESubScreenInitPreset.Right,
				ESubScreenInitPreset.Top,
				ESubScreenInitPreset.Bottom
			};
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x001D7F63 File Offset: 0x001D6163
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Right",
				"Top",
				"Bottom"
			};
		}
	}
}
