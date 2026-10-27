using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F7 RID: 9207
	public static class ERogueSelectRoomTypeExtensions
	{
		// Token: 0x0600C856 RID: 51286 RVA: 0x001D5238 File Offset: 0x001D3438
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

		// Token: 0x0600C857 RID: 51287 RVA: 0x001D5260 File Offset: 0x001D3460
		public static ERogueSelectRoomType FromString(string name)
		{
			ERogueSelectRoomType result;
			if (!ERogueSelectRoomTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueSelectRoomType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x001D5289 File Offset: 0x001D3489
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

		// Token: 0x0600C859 RID: 51289 RVA: 0x001D52AE File Offset: 0x001D34AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role"
			};
		}

		// Token: 0x0600C85A RID: 51290 RVA: 0x001D52BE File Offset: 0x001D34BE
		public static ERogueSelectRoomType[] GetValues()
		{
			return new ERogueSelectRoomType[1];
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x001D52C6 File Offset: 0x001D34C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Role"
			};
		}
	}
}
