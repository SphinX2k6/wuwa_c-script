using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8F RID: 2703
	public static class EPetalGrabEventTypeExtensions
	{
		// Token: 0x06003B96 RID: 15254 RVA: 0x000995B8 File Offset: 0x000977B8
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

		// Token: 0x06003B97 RID: 15255 RVA: 0x000995F0 File Offset: 0x000977F0
		public static EPetalGrabEventType FromString(string name)
		{
			EPetalGrabEventType result;
			if (!EPetalGrabEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPetalGrabEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00099619 File Offset: 0x00097819
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

		// Token: 0x06003B99 RID: 15257 RVA: 0x00099652 File Offset: 0x00097852
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Grabbed",
				"Leave"
			};
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x0009966A File Offset: 0x0009786A
		public static EPetalGrabEventType[] GetValues()
		{
			return new EPetalGrabEventType[]
			{
				EPetalGrabEventType.Grabbed,
				EPetalGrabEventType.Leave
			};
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00099676 File Offset: 0x00097876
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
