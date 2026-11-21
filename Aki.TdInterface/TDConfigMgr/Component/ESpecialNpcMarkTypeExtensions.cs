using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADD RID: 2781
	public static class ESpecialNpcMarkTypeExtensions
	{
		// Token: 0x06003CF5 RID: 15605 RVA: 0x0009C0B0 File Offset: 0x0009A2B0
		public static string ToEnumString(this ESpecialNpcMarkType value)
		{
			string result;
			switch (value)
			{
			case ESpecialNpcMarkType.TrafficLight:
				result = "TrafficLight";
				break;
			case ESpecialNpcMarkType.IgnoreCameraHideNpc:
				result = "IgnoreCameraHideNpc";
				break;
			case ESpecialNpcMarkType.TriggerBlueprintFootprintEvent:
				result = "TriggerBlueprintFootprintEvent";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x0009C0F8 File Offset: 0x0009A2F8
		public static ESpecialNpcMarkType FromString(string name)
		{
			ESpecialNpcMarkType result;
			if (!ESpecialNpcMarkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialNpcMarkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0009C124 File Offset: 0x0009A324
		public static bool TryFromString(string name, out ESpecialNpcMarkType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialNpcMarkType.TrafficLight;
				return false;
			}
			if (name == "TrafficLight")
			{
				value = ESpecialNpcMarkType.TrafficLight;
				return true;
			}
			if (name == "IgnoreCameraHideNpc")
			{
				value = ESpecialNpcMarkType.IgnoreCameraHideNpc;
				return true;
			}
			if (!(name == "TriggerBlueprintFootprintEvent"))
			{
				value = ESpecialNpcMarkType.TrafficLight;
				return false;
			}
			value = ESpecialNpcMarkType.TriggerBlueprintFootprintEvent;
			return true;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0009C17A File Offset: 0x0009A37A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrafficLight",
				"IgnoreCameraHideNpc",
				"TriggerBlueprintFootprintEvent"
			};
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0009C19A File Offset: 0x0009A39A
		public static ESpecialNpcMarkType[] GetValues()
		{
			return new ESpecialNpcMarkType[]
			{
				ESpecialNpcMarkType.TrafficLight,
				ESpecialNpcMarkType.IgnoreCameraHideNpc,
				ESpecialNpcMarkType.TriggerBlueprintFootprintEvent
			};
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0009C1AA File Offset: 0x0009A3AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"TrafficLight",
				"IgnoreCameraHideNpc",
				"TriggerBlueprintFootprintEvent"
			};
		}
	}
}
