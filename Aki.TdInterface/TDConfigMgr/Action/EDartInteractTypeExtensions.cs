using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002568 RID: 9576
	public static class EDartInteractTypeExtensions
	{
		// Token: 0x0600CFAE RID: 53166 RVA: 0x001E19E4 File Offset: 0x001DFBE4
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

		// Token: 0x0600CFAF RID: 53167 RVA: 0x001E1A2C File Offset: 0x001DFC2C
		public static EDartInteractType FromString(string name)
		{
			EDartInteractType result;
			if (!EDartInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDartInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x001E1A58 File Offset: 0x001DFC58
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

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x001E1AAE File Offset: 0x001DFCAE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Machine",
				"ChampionOwner",
				"PlayableRole"
			};
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x001E1ACE File Offset: 0x001DFCCE
		public static EDartInteractType[] GetValues()
		{
			return new EDartInteractType[]
			{
				EDartInteractType.Machine,
				EDartInteractType.ChampionOwner,
				EDartInteractType.PlayableRole
			};
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x001E1ADE File Offset: 0x001DFCDE
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
