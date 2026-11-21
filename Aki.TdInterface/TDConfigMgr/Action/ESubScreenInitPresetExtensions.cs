using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D6 RID: 9942
	public static class ESubScreenInitPresetExtensions
	{
		// Token: 0x0600D61D RID: 54813 RVA: 0x001F1D08 File Offset: 0x001EFF08
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

		// Token: 0x0600D61E RID: 54814 RVA: 0x001F1D5C File Offset: 0x001EFF5C
		public static ESubScreenInitPreset FromString(string name)
		{
			ESubScreenInitPreset result;
			if (!ESubScreenInitPresetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESubScreenInitPreset 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x001F1D88 File Offset: 0x001EFF88
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

		// Token: 0x0600D620 RID: 54816 RVA: 0x001F1DF0 File Offset: 0x001EFFF0
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

		// Token: 0x0600D621 RID: 54817 RVA: 0x001F1E18 File Offset: 0x001F0018
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

		// Token: 0x0600D622 RID: 54818 RVA: 0x001F1E2B File Offset: 0x001F002B
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
