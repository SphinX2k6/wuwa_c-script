using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268E RID: 9870
	public static class ERogueSelectRoomTypeExtensions
	{
		// Token: 0x0600D4D9 RID: 54489 RVA: 0x001EE9E4 File Offset: 0x001ECBE4
		public static string ToEnumString(this ERogueSelectRoomType value)
		{
			string result;
			if (value == ERogueSelectRoomType.Role)
			{
				result = "Role";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x001EEA0C File Offset: 0x001ECC0C
		public static ERogueSelectRoomType FromString(string name)
		{
			ERogueSelectRoomType result;
			if (!ERogueSelectRoomTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueSelectRoomType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x001EEA35 File Offset: 0x001ECC35
		public static bool TryFromString(string name, out ERogueSelectRoomType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERogueSelectRoomType.Role;
				return false;
			}
			if (name == "Role")
			{
				value = ERogueSelectRoomType.Role;
				return true;
			}
			value = ERogueSelectRoomType.Role;
			return false;
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x001EEA5A File Offset: 0x001ECC5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role"
			};
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x001EEA6A File Offset: 0x001ECC6A
		public static ERogueSelectRoomType[] GetValues()
		{
			return new ERogueSelectRoomType[1];
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x001EEA72 File Offset: 0x001ECC72
		public static string[] GetNames()
		{
			return new string[]
			{
				"Role"
			};
		}
	}
}
