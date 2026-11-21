using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001372 RID: 4978
	public static class EDarkTideBossEventTypeExtensions
	{
		// Token: 0x06006FDB RID: 28635 RVA: 0x0010A60C File Offset: 0x0010880C
		public static string ToEnumString(this EDarkTideBossEventType value)
		{
			string result;
			switch (value)
			{
			case EDarkTideBossEventType.XinjilemuChase:
				result = "XinjilemuChase";
				break;
			case EDarkTideBossEventType.HecatePollution:
				result = "HecatePollution";
				break;
			case EDarkTideBossEventType.HaiweixiaArena:
				result = "HaiweixiaArena";
				break;
			case EDarkTideBossEventType.WyvernPosition:
				result = "WyvernPosition";
				break;
			case EDarkTideBossEventType.ChonglouTrial:
				result = "ChonglouTrial";
				break;
			case EDarkTideBossEventType.MechaAssembly:
				result = "MechaAssembly";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x0010A678 File Offset: 0x00108878
		public static EDarkTideBossEventType FromString(string name)
		{
			EDarkTideBossEventType result;
			if (!EDarkTideBossEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDarkTideBossEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x0010A6A4 File Offset: 0x001088A4
		public static bool TryFromString(string name, out EDarkTideBossEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDarkTideBossEventType.XinjilemuChase;
				return false;
			}
			if (name == "XinjilemuChase")
			{
				value = EDarkTideBossEventType.XinjilemuChase;
				return true;
			}
			if (name == "HecatePollution")
			{
				value = EDarkTideBossEventType.HecatePollution;
				return true;
			}
			if (name == "HaiweixiaArena")
			{
				value = EDarkTideBossEventType.HaiweixiaArena;
				return true;
			}
			if (name == "WyvernPosition")
			{
				value = EDarkTideBossEventType.WyvernPosition;
				return true;
			}
			if (name == "ChonglouTrial")
			{
				value = EDarkTideBossEventType.ChonglouTrial;
				return true;
			}
			if (!(name == "MechaAssembly"))
			{
				value = EDarkTideBossEventType.XinjilemuChase;
				return false;
			}
			value = EDarkTideBossEventType.MechaAssembly;
			return true;
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x0010A730 File Offset: 0x00108930
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"XinjilemuChase",
				"HecatePollution",
				"HaiweixiaArena",
				"WyvernPosition",
				"ChonglouTrial",
				"MechaAssembly"
			};
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x0010A768 File Offset: 0x00108968
		public static EDarkTideBossEventType[] GetValues()
		{
			return new EDarkTideBossEventType[]
			{
				EDarkTideBossEventType.XinjilemuChase,
				EDarkTideBossEventType.HecatePollution,
				EDarkTideBossEventType.HaiweixiaArena,
				EDarkTideBossEventType.WyvernPosition,
				EDarkTideBossEventType.ChonglouTrial,
				EDarkTideBossEventType.MechaAssembly
			};
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x0010A77B File Offset: 0x0010897B
		public static string[] GetNames()
		{
			return new string[]
			{
				"XinjilemuChase",
				"HecatePollution",
				"HaiweixiaArena",
				"WyvernPosition",
				"ChonglouTrial",
				"MechaAssembly"
			};
		}
	}
}
