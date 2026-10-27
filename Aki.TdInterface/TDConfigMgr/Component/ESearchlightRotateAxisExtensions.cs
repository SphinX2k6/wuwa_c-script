using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A08 RID: 2568
	public static class ESearchlightRotateAxisExtensions
	{
		// Token: 0x060038D5 RID: 14549 RVA: 0x00092EBC File Offset: 0x000910BC
		public static string ToEnumString(this ESearchlightRotateAxis value)
		{
			string result;
			if (value != ESearchlightRotateAxis.Yaw)
			{
				if (value != ESearchlightRotateAxis.Pitch)
				{
					result = value.ToString();
				}
				else
				{
					result = "Pitch";
				}
			}
			else
			{
				result = "Yaw";
			}
			return result;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x00092EF4 File Offset: 0x000910F4
		public static ESearchlightRotateAxis FromString(string name)
		{
			ESearchlightRotateAxis result;
			if (!ESearchlightRotateAxisExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESearchlightRotateAxis 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00092F1D File Offset: 0x0009111D
		public static bool TryFromString(string name, out ESearchlightRotateAxis value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESearchlightRotateAxis.Yaw;
				return false;
			}
			if (name == "Yaw")
			{
				value = ESearchlightRotateAxis.Yaw;
				return true;
			}
			if (!(name == "Pitch"))
			{
				value = ESearchlightRotateAxis.Yaw;
				return false;
			}
			value = ESearchlightRotateAxis.Pitch;
			return true;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x00092F56 File Offset: 0x00091156
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Yaw",
				"Pitch"
			};
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00092F6E File Offset: 0x0009116E
		public static ESearchlightRotateAxis[] GetValues()
		{
			return new ESearchlightRotateAxis[]
			{
				ESearchlightRotateAxis.Yaw,
				ESearchlightRotateAxis.Pitch
			};
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x00092F7A File Offset: 0x0009117A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Yaw",
				"Pitch"
			};
		}
	}
}
