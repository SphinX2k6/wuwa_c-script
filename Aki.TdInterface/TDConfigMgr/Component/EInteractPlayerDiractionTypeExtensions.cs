using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A29 RID: 2601
	public static class EInteractPlayerDiractionTypeExtensions
	{
		// Token: 0x060039CB RID: 14795 RVA: 0x00095834 File Offset: 0x00093A34
		public static string ToEnumString(this EInteractPlayerDiractionType value)
		{
			string result;
			if (value != EInteractPlayerDiractionType.Npc)
			{
				if (value != EInteractPlayerDiractionType.LeisureInteraction)
				{
					result = value.ToString();
				}
				else
				{
					result = "LeisureInteraction";
				}
			}
			else
			{
				result = "Npc";
			}
			return result;
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0009586C File Offset: 0x00093A6C
		public static EInteractPlayerDiractionType FromString(string name)
		{
			EInteractPlayerDiractionType result;
			if (!EInteractPlayerDiractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractPlayerDiractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00095895 File Offset: 0x00093A95
		public static bool TryFromString(string name, out EInteractPlayerDiractionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractPlayerDiractionType.Npc;
				return false;
			}
			if (name == "Npc")
			{
				value = EInteractPlayerDiractionType.Npc;
				return true;
			}
			if (!(name == "LeisureInteraction"))
			{
				value = EInteractPlayerDiractionType.Npc;
				return false;
			}
			value = EInteractPlayerDiractionType.LeisureInteraction;
			return true;
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x000958CE File Offset: 0x00093ACE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Npc",
				"LeisureInteraction"
			};
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x000958E6 File Offset: 0x00093AE6
		public static EInteractPlayerDiractionType[] GetValues()
		{
			return new EInteractPlayerDiractionType[]
			{
				EInteractPlayerDiractionType.Npc,
				EInteractPlayerDiractionType.LeisureInteraction
			};
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x000958F2 File Offset: 0x00093AF2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Npc",
				"LeisureInteraction"
			};
		}
	}
}
