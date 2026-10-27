using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FA RID: 2554
	public static class ERoleMotionInteractTypeExtensions
	{
		// Token: 0x06003896 RID: 14486 RVA: 0x000927D8 File Offset: 0x000909D8
		public static string ToEnumString(this ERoleMotionInteractType value)
		{
			string result;
			if (value == ERoleMotionInteractType.PetalGrab)
			{
				result = "PetalGrab";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00092800 File Offset: 0x00090A00
		public static ERoleMotionInteractType FromString(string name)
		{
			ERoleMotionInteractType result;
			if (!ERoleMotionInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleMotionInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00092829 File Offset: 0x00090A29
		public static bool TryFromString(string name, out ERoleMotionInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoleMotionInteractType.PetalGrab;
				return false;
			}
			if (name == "PetalGrab")
			{
				value = ERoleMotionInteractType.PetalGrab;
				return true;
			}
			value = ERoleMotionInteractType.PetalGrab;
			return false;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0009284E File Offset: 0x00090A4E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PetalGrab"
			};
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x0009285E File Offset: 0x00090A5E
		public static ERoleMotionInteractType[] GetValues()
		{
			return new ERoleMotionInteractType[1];
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00092866 File Offset: 0x00090A66
		public static string[] GetNames()
		{
			return new string[]
			{
				"PetalGrab"
			};
		}
	}
}
