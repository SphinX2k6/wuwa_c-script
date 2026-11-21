using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251C RID: 9500
	public static class EAvgRolePositionExtensions
	{
		// Token: 0x0600CE58 RID: 52824 RVA: 0x001DEAC8 File Offset: 0x001DCCC8
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

		// Token: 0x0600CE59 RID: 52825 RVA: 0x001DEB28 File Offset: 0x001DCD28
		public static EAvgRolePosition FromString(string name)
		{
			EAvgRolePosition result;
			if (!EAvgRolePositionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgRolePosition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE5A RID: 52826 RVA: 0x001DEB54 File Offset: 0x001DCD54
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

		// Token: 0x0600CE5B RID: 52827 RVA: 0x001DEBCE File Offset: 0x001DCDCE
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

		// Token: 0x0600CE5C RID: 52828 RVA: 0x001DEBFE File Offset: 0x001DCDFE
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

		// Token: 0x0600CE5D RID: 52829 RVA: 0x001DEC11 File Offset: 0x001DCE11
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
