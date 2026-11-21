using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4B RID: 2635
	public static class EMechascoutDragTypeExtensions
	{
		// Token: 0x06003A64 RID: 14948 RVA: 0x00096BC4 File Offset: 0x00094DC4
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

		// Token: 0x06003A65 RID: 14949 RVA: 0x00096BFC File Offset: 0x00094DFC
		public static EMechascoutDragType FromString(string name)
		{
			EMechascoutDragType result;
			if (!EMechascoutDragTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMechascoutDragType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00096C25 File Offset: 0x00094E25
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

		// Token: 0x06003A67 RID: 14951 RVA: 0x00096C5E File Offset: 0x00094E5E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Instant",
				"LongPress"
			};
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00096C76 File Offset: 0x00094E76
		public static EMechascoutDragType[] GetValues()
		{
			return new EMechascoutDragType[]
			{
				EMechascoutDragType.Instant,
				EMechascoutDragType.LongPress
			};
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00096C82 File Offset: 0x00094E82
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
