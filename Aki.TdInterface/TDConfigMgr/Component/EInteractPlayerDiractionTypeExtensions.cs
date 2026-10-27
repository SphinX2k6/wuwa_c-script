using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000976 RID: 2422
	public static class EInteractPlayerDiractionTypeExtensions
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x0008D8C8 File Offset: 0x0008BAC8
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

		// Token: 0x06003645 RID: 13893 RVA: 0x0008D900 File Offset: 0x0008BB00
		public static EInteractPlayerDiractionType FromString(string name)
		{
			EInteractPlayerDiractionType result;
			if (!EInteractPlayerDiractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractPlayerDiractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0008D929 File Offset: 0x0008BB29
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

		// Token: 0x06003647 RID: 13895 RVA: 0x0008D962 File Offset: 0x0008BB62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Npc",
				"LeisureInteraction"
			};
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0008D97A File Offset: 0x0008BB7A
		public static EInteractPlayerDiractionType[] GetValues()
		{
			return new EInteractPlayerDiractionType[]
			{
				EInteractPlayerDiractionType.Npc,
				EInteractPlayerDiractionType.LeisureInteraction
			};
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x0008D986 File Offset: 0x0008BB86
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
