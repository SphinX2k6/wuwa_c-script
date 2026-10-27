using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AD RID: 8877
	public static class EAvgRolePositionExtensions
	{
		// Token: 0x0600C289 RID: 49801 RVA: 0x001C6CC0 File Offset: 0x001C4EC0
		public static string ToEnumString(this EAvgRolePosition value)
		{
			string result;
			switch (value)
			{
			case EAvgRolePosition.Center:
				result = "Center";
				break;
			case EAvgRolePosition.Left1:
				result = "Left1";
				break;
			case EAvgRolePosition.Left2:
				result = "Left2";
				break;
			case EAvgRolePosition.Right1:
				result = "Right1";
				break;
			case EAvgRolePosition.Right2:
				result = "Right2";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C28A RID: 49802 RVA: 0x001C6D20 File Offset: 0x001C4F20
		public static EAvgRolePosition FromString(string name)
		{
			EAvgRolePosition result;
			if (!EAvgRolePositionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgRolePosition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C28B RID: 49803 RVA: 0x001C6D4C File Offset: 0x001C4F4C
		public static bool TryFromString(string name, out EAvgRolePosition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgRolePosition.Center;
				return false;
			}
			if (name == "Center")
			{
				value = EAvgRolePosition.Center;
				return true;
			}
			if (name == "Left1")
			{
				value = EAvgRolePosition.Left1;
				return true;
			}
			if (name == "Left2")
			{
				value = EAvgRolePosition.Left2;
				return true;
			}
			if (name == "Right1")
			{
				value = EAvgRolePosition.Right1;
				return true;
			}
			if (!(name == "Right2"))
			{
				value = EAvgRolePosition.Center;
				return false;
			}
			value = EAvgRolePosition.Right2;
			return true;
		}

		// Token: 0x0600C28C RID: 49804 RVA: 0x001C6DC6 File Offset: 0x001C4FC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Center",
				"Left1",
				"Left2",
				"Right1",
				"Right2"
			};
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x001C6DF6 File Offset: 0x001C4FF6
		public static EAvgRolePosition[] GetValues()
		{
			return new EAvgRolePosition[]
			{
				EAvgRolePosition.Center,
				EAvgRolePosition.Left1,
				EAvgRolePosition.Left2,
				EAvgRolePosition.Right1,
				EAvgRolePosition.Right2
			};
		}

		// Token: 0x0600C28E RID: 49806 RVA: 0x001C6E09 File Offset: 0x001C5009
		public static string[] GetNames()
		{
			return new string[]
			{
				"Center",
				"Left1",
				"Left2",
				"Right1",
				"Right2"
			};
		}
	}
}
