using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000998 RID: 2456
	public static class EMechascoutDragTypeExtensions
	{
		// Token: 0x060036DD RID: 14045 RVA: 0x0008EC58 File Offset: 0x0008CE58
		public static string ToEnumString(this EMechascoutDragType value)
		{
			string result;
			if (value != EMechascoutDragType.Instant)
			{
				if (value != EMechascoutDragType.LongPress)
				{
					result = value.ToString();
				}
				else
				{
					result = "LongPress";
				}
			}
			else
			{
				result = "Instant";
			}
			return result;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0008EC90 File Offset: 0x0008CE90
		public static EMechascoutDragType FromString(string name)
		{
			EMechascoutDragType result;
			if (!EMechascoutDragTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechascoutDragType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0008ECB9 File Offset: 0x0008CEB9
		public static bool TryFromString(string name, out EMechascoutDragType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMechascoutDragType.Instant;
				return false;
			}
			if (name == "Instant")
			{
				value = EMechascoutDragType.Instant;
				return true;
			}
			if (!(name == "LongPress"))
			{
				value = EMechascoutDragType.Instant;
				return false;
			}
			value = EMechascoutDragType.LongPress;
			return true;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0008ECF2 File Offset: 0x0008CEF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Instant",
				"LongPress"
			};
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0008ED0A File Offset: 0x0008CF0A
		public static EMechascoutDragType[] GetValues()
		{
			return new EMechascoutDragType[]
			{
				EMechascoutDragType.Instant,
				EMechascoutDragType.LongPress
			};
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0008ED16 File Offset: 0x0008CF16
		public static string[] GetNames()
		{
			return new string[]
			{
				"Instant",
				"LongPress"
			};
		}
	}
}
