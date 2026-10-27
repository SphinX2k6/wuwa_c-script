using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002383 RID: 9091
	public static class EModifyActorMaterialTypeExtensions
	{
		// Token: 0x0600C64C RID: 50764 RVA: 0x001D0C9C File Offset: 0x001CEE9C
		public static string ToEnumString(this EModifyActorMaterialType value)
		{
			string result;
			if (value != EModifyActorMaterialType.ChangeMaterialData)
			{
				if (value != EModifyActorMaterialType.ChangeMPC)
				{
					result = value.ToString();
				}
				else
				{
					result = "ChangeMPC";
				}
			}
			else
			{
				result = "ChangeMaterialData";
			}
			return result;
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x001D0CD4 File Offset: 0x001CEED4
		public static EModifyActorMaterialType FromString(string name)
		{
			EModifyActorMaterialType result;
			if (!EModifyActorMaterialTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModifyActorMaterialType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x001D0CFD File Offset: 0x001CEEFD
		public static bool TryFromString(string name, out EModifyActorMaterialType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EModifyActorMaterialType.ChangeMaterialData;
				return false;
			}
			if (name == "ChangeMaterialData")
			{
				value = EModifyActorMaterialType.ChangeMaterialData;
				return true;
			}
			if (!(name == "ChangeMPC"))
			{
				value = EModifyActorMaterialType.ChangeMaterialData;
				return false;
			}
			value = EModifyActorMaterialType.ChangeMPC;
			return true;
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x001D0D36 File Offset: 0x001CEF36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeMaterialData",
				"ChangeMPC"
			};
		}

		// Token: 0x0600C650 RID: 50768 RVA: 0x001D0D4E File Offset: 0x001CEF4E
		public static EModifyActorMaterialType[] GetValues()
		{
			return new EModifyActorMaterialType[]
			{
				EModifyActorMaterialType.ChangeMaterialData,
				EModifyActorMaterialType.ChangeMPC
			};
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x001D0D5A File Offset: 0x001CEF5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeMaterialData",
				"ChangeMPC"
			};
		}
	}
}
