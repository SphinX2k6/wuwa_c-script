using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260A RID: 9738
	public static class EMechStuntTypeExtensions
	{
		// Token: 0x0600D287 RID: 53895 RVA: 0x001E9A8C File Offset: 0x001E7C8C
		public static string ToEnumString(this EMechStuntType value)
		{
			string result;
			switch (value)
			{
			case EMechStuntType.Dive:
				result = "Dive";
				break;
			case EMechStuntType.ClimbFly:
				result = "ClimbFly";
				break;
			case EMechStuntType.LevelFly:
				result = "LevelFly";
				break;
			case EMechStuntType.HighSpeed:
				result = "HighSpeed";
				break;
			case EMechStuntType.Water:
				result = "Water";
				break;
			case EMechStuntType.Burrow:
				result = "Burrow";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x001E9AF8 File Offset: 0x001E7CF8
		public static EMechStuntType FromString(string name)
		{
			EMechStuntType result;
			if (!EMechStuntTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechStuntType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x001E9B24 File Offset: 0x001E7D24
		public static bool TryFromString(string name, out EMechStuntType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMechStuntType.Dive;
				return false;
			}
			if (name == "Dive")
			{
				value = EMechStuntType.Dive;
				return true;
			}
			if (name == "ClimbFly")
			{
				value = EMechStuntType.ClimbFly;
				return true;
			}
			if (name == "LevelFly")
			{
				value = EMechStuntType.LevelFly;
				return true;
			}
			if (name == "HighSpeed")
			{
				value = EMechStuntType.HighSpeed;
				return true;
			}
			if (name == "Water")
			{
				value = EMechStuntType.Water;
				return true;
			}
			if (!(name == "Burrow"))
			{
				value = EMechStuntType.Dive;
				return false;
			}
			value = EMechStuntType.Burrow;
			return true;
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x001E9BB0 File Offset: 0x001E7DB0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Dive",
				"ClimbFly",
				"LevelFly",
				"HighSpeed",
				"Water",
				"Burrow"
			};
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x001E9BE8 File Offset: 0x001E7DE8
		public static EMechStuntType[] GetValues()
		{
			return new EMechStuntType[]
			{
				EMechStuntType.Dive,
				EMechStuntType.ClimbFly,
				EMechStuntType.LevelFly,
				EMechStuntType.HighSpeed,
				EMechStuntType.Water,
				EMechStuntType.Burrow
			};
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x001E9BFB File Offset: 0x001E7DFB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Dive",
				"ClimbFly",
				"LevelFly",
				"HighSpeed",
				"Water",
				"Burrow"
			};
		}
	}
}
