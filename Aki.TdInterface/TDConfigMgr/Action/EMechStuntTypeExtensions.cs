using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002381 RID: 9089
	public static class EMechStuntTypeExtensions
	{
		// Token: 0x0600C643 RID: 50755 RVA: 0x001D0AB8 File Offset: 0x001CECB8
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

		// Token: 0x0600C644 RID: 50756 RVA: 0x001D0B24 File Offset: 0x001CED24
		public static EMechStuntType FromString(string name)
		{
			EMechStuntType result;
			if (!EMechStuntTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechStuntType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x001D0B50 File Offset: 0x001CED50
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

		// Token: 0x0600C646 RID: 50758 RVA: 0x001D0BDC File Offset: 0x001CEDDC
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

		// Token: 0x0600C647 RID: 50759 RVA: 0x001D0C14 File Offset: 0x001CEE14
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

		// Token: 0x0600C648 RID: 50760 RVA: 0x001D0C27 File Offset: 0x001CEE27
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
