using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270E RID: 9998
	public static class ETextHorizontalExtensions
	{
		// Token: 0x0600D719 RID: 55065 RVA: 0x001F6C04 File Offset: 0x001F4E04
		public static string ToEnumString(this ETextHorizontal value)
		{
			string result;
			switch (value)
			{
			case ETextHorizontal.Left:
				result = "Left";
				break;
			case ETextHorizontal.Center:
				result = "Center";
				break;
			case ETextHorizontal.Right:
				result = "Right";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D71A RID: 55066 RVA: 0x001F6C4C File Offset: 0x001F4E4C
		public static ETextHorizontal FromString(string name)
		{
			ETextHorizontal result;
			if (!ETextHorizontalExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETextHorizontal 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x001F6C78 File Offset: 0x001F4E78
		public static bool TryFromString(string name, out ETextHorizontal value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETextHorizontal.Left;
				return false;
			}
			if (name == "Left")
			{
				value = ETextHorizontal.Left;
				return true;
			}
			if (name == "Center")
			{
				value = ETextHorizontal.Center;
				return true;
			}
			if (!(name == "Right"))
			{
				value = ETextHorizontal.Left;
				return false;
			}
			value = ETextHorizontal.Right;
			return true;
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x001F6CCE File Offset: 0x001F4ECE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Center",
				"Right"
			};
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x001F6CEE File Offset: 0x001F4EEE
		public static ETextHorizontal[] GetValues()
		{
			return new ETextHorizontal[]
			{
				ETextHorizontal.Left,
				ETextHorizontal.Center,
				ETextHorizontal.Right
			};
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x001F6CFE File Offset: 0x001F4EFE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Left",
				"Center",
				"Right"
			};
		}
	}
}
