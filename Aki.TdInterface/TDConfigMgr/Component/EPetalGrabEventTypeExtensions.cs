using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CA RID: 2506
	public static class EPetalGrabEventTypeExtensions
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x00090CF8 File Offset: 0x0008EEF8
		public static string ToEnumString(this EPetalGrabEventType value)
		{
			string result;
			if (value != EPetalGrabEventType.Grabbed)
			{
				if (value != EPetalGrabEventType.Leave)
				{
					result = value.ToString();
				}
				else
				{
					result = "Leave";
				}
			}
			else
			{
				result = "Grabbed";
			}
			return result;
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00090D30 File Offset: 0x0008EF30
		public static EPetalGrabEventType FromString(string name)
		{
			EPetalGrabEventType result;
			if (!EPetalGrabEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPetalGrabEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00090D59 File Offset: 0x0008EF59
		public static bool TryFromString(string name, out EPetalGrabEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPetalGrabEventType.Grabbed;
				return false;
			}
			if (name == "Grabbed")
			{
				value = EPetalGrabEventType.Grabbed;
				return true;
			}
			if (!(name == "Leave"))
			{
				value = EPetalGrabEventType.Grabbed;
				return false;
			}
			value = EPetalGrabEventType.Leave;
			return true;
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00090D92 File Offset: 0x0008EF92
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Grabbed",
				"Leave"
			};
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00090DAA File Offset: 0x0008EFAA
		public static EPetalGrabEventType[] GetValues()
		{
			return new EPetalGrabEventType[]
			{
				EPetalGrabEventType.Grabbed,
				EPetalGrabEventType.Leave
			};
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00090DB6 File Offset: 0x0008EFB6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Grabbed",
				"Leave"
			};
		}
	}
}
