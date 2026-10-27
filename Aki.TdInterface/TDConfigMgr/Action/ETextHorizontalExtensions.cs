using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246D RID: 9325
	public static class ETextHorizontalExtensions
	{
		// Token: 0x0600CA69 RID: 51817 RVA: 0x001DCB50 File Offset: 0x001DAD50
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

		// Token: 0x0600CA6A RID: 51818 RVA: 0x001DCB98 File Offset: 0x001DAD98
		public static ETextHorizontal FromString(string name)
		{
			ETextHorizontal result;
			if (!ETextHorizontalExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETextHorizontal 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x001DCBC4 File Offset: 0x001DADC4
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

		// Token: 0x0600CA6C RID: 51820 RVA: 0x001DCC1A File Offset: 0x001DAE1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Left",
				"Center",
				"Right"
			};
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x001DCC3A File Offset: 0x001DAE3A
		public static ETextHorizontal[] GetValues()
		{
			return new ETextHorizontal[]
			{
				ETextHorizontal.Left,
				ETextHorizontal.Center,
				ETextHorizontal.Right
			};
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x001DCC4A File Offset: 0x001DAE4A
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
