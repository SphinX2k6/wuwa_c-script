using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200254C RID: 9548
	public static class EClientEventPianoEventTypeExtensions
	{
		// Token: 0x0600CF30 RID: 53040 RVA: 0x001E0A2C File Offset: 0x001DEC2C
		public static string ToEnumString(this EClientEventPianoEventType value)
		{
			string result;
			if (value != EClientEventPianoEventType.UpdateSubtitle)
			{
				if (value != EClientEventPianoEventType.SwitchPhase)
				{
					result = value.ToString();
				}
				else
				{
					result = "SwitchPhase";
				}
			}
			else
			{
				result = "UpdateSubtitle";
			}
			return result;
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x001E0A64 File Offset: 0x001DEC64
		public static EClientEventPianoEventType FromString(string name)
		{
			EClientEventPianoEventType result;
			if (!EClientEventPianoEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventPianoEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x001E0A8D File Offset: 0x001DEC8D
		public static bool TryFromString(string name, out EClientEventPianoEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientEventPianoEventType.UpdateSubtitle;
				return false;
			}
			if (name == "UpdateSubtitle")
			{
				value = EClientEventPianoEventType.UpdateSubtitle;
				return true;
			}
			if (!(name == "SwitchPhase"))
			{
				value = EClientEventPianoEventType.UpdateSubtitle;
				return false;
			}
			value = EClientEventPianoEventType.SwitchPhase;
			return true;
		}

		// Token: 0x0600CF33 RID: 53043 RVA: 0x001E0AC6 File Offset: 0x001DECC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpdateSubtitle",
				"SwitchPhase"
			};
		}

		// Token: 0x0600CF34 RID: 53044 RVA: 0x001E0ADE File Offset: 0x001DECDE
		public static EClientEventPianoEventType[] GetValues()
		{
			return new EClientEventPianoEventType[]
			{
				EClientEventPianoEventType.UpdateSubtitle,
				EClientEventPianoEventType.SwitchPhase
			};
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x001E0AEA File Offset: 0x001DECEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"UpdateSubtitle",
				"SwitchPhase"
			};
		}
	}
}
