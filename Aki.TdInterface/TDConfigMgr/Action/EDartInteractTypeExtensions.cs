using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F7 RID: 8951
	public static class EDartInteractTypeExtensions
	{
		// Token: 0x0600C3D6 RID: 50134 RVA: 0x001C9A40 File Offset: 0x001C7C40
		public static string ToEnumString(this EDartInteractType value)
		{
			string result;
			switch (value)
			{
			case EDartInteractType.Machine:
				result = "Machine";
				break;
			case EDartInteractType.ChampionOwner:
				result = "ChampionOwner";
				break;
			case EDartInteractType.PlayableRole:
				result = "PlayableRole";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x001C9A88 File Offset: 0x001C7C88
		public static EDartInteractType FromString(string name)
		{
			EDartInteractType result;
			if (!EDartInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDartInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x001C9AB4 File Offset: 0x001C7CB4
		public static bool TryFromString(string name, out EDartInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDartInteractType.Machine;
				return false;
			}
			if (name == "Machine")
			{
				value = EDartInteractType.Machine;
				return true;
			}
			if (name == "ChampionOwner")
			{
				value = EDartInteractType.ChampionOwner;
				return true;
			}
			if (!(name == "PlayableRole"))
			{
				value = EDartInteractType.Machine;
				return false;
			}
			value = EDartInteractType.PlayableRole;
			return true;
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x001C9B0A File Offset: 0x001C7D0A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Machine",
				"ChampionOwner",
				"PlayableRole"
			};
		}

		// Token: 0x0600C3DA RID: 50138 RVA: 0x001C9B2A File Offset: 0x001C7D2A
		public static EDartInteractType[] GetValues()
		{
			return new EDartInteractType[]
			{
				EDartInteractType.Machine,
				EDartInteractType.ChampionOwner,
				EDartInteractType.PlayableRole
			};
		}

		// Token: 0x0600C3DB RID: 50139 RVA: 0x001C9B3A File Offset: 0x001C7D3A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Machine",
				"ChampionOwner",
				"PlayableRole"
			};
		}
	}
}
