using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A18 RID: 2584
	public static class ESpecialNpcMarkTypeExtensions
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x000937C0 File Offset: 0x000919C0
		public static string ToEnumString(this ESpecialNpcMarkType value)
		{
			string result;
			if (value != ESpecialNpcMarkType.TrafficLight)
			{
				if (value != ESpecialNpcMarkType.IgnoreCameraHideNpc)
				{
					result = value.ToString();
				}
				else
				{
					result = "IgnoreCameraHideNpc";
				}
			}
			else
			{
				result = "TrafficLight";
			}
			return result;
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x000937F8 File Offset: 0x000919F8
		public static ESpecialNpcMarkType FromString(string name)
		{
			ESpecialNpcMarkType result;
			if (!ESpecialNpcMarkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialNpcMarkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00093821 File Offset: 0x00091A21
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
			if (!(name == "IgnoreCameraHideNpc"))
			{
				value = ESpecialNpcMarkType.TrafficLight;
				return false;
			}
			value = ESpecialNpcMarkType.IgnoreCameraHideNpc;
			return true;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0009385A File Offset: 0x00091A5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrafficLight",
				"IgnoreCameraHideNpc"
			};
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00093872 File Offset: 0x00091A72
		public static ESpecialNpcMarkType[] GetValues()
		{
			return new ESpecialNpcMarkType[]
			{
				ESpecialNpcMarkType.TrafficLight,
				ESpecialNpcMarkType.IgnoreCameraHideNpc
			};
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0009387E File Offset: 0x00091A7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"TrafficLight",
				"IgnoreCameraHideNpc"
			};
		}
	}
}
