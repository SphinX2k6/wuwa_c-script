using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DD RID: 8925
	public static class EClientEventPianoEventTypeExtensions
	{
		// Token: 0x0600C361 RID: 50017 RVA: 0x001C8C24 File Offset: 0x001C6E24
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

		// Token: 0x0600C362 RID: 50018 RVA: 0x001C8C5C File Offset: 0x001C6E5C
		public static EClientEventPianoEventType FromString(string name)
		{
			EClientEventPianoEventType result;
			if (!EClientEventPianoEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventPianoEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x001C8C85 File Offset: 0x001C6E85
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

		// Token: 0x0600C364 RID: 50020 RVA: 0x001C8CBE File Offset: 0x001C6EBE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UpdateSubtitle",
				"SwitchPhase"
			};
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x001C8CD6 File Offset: 0x001C6ED6
		public static EClientEventPianoEventType[] GetValues()
		{
			return new EClientEventPianoEventType[]
			{
				EClientEventPianoEventType.UpdateSubtitle,
				EClientEventPianoEventType.SwitchPhase
			};
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x001C8CE2 File Offset: 0x001C6EE2
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
