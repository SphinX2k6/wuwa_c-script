using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260C RID: 9740
	public static class EModifyActorMaterialTypeExtensions
	{
		// Token: 0x0600D290 RID: 53904 RVA: 0x001E9C70 File Offset: 0x001E7E70
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

		// Token: 0x0600D291 RID: 53905 RVA: 0x001E9CA8 File Offset: 0x001E7EA8
		public static EModifyActorMaterialType FromString(string name)
		{
			EModifyActorMaterialType result;
			if (!EModifyActorMaterialTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModifyActorMaterialType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x001E9CD1 File Offset: 0x001E7ED1
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

		// Token: 0x0600D293 RID: 53907 RVA: 0x001E9D0A File Offset: 0x001E7F0A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeMaterialData",
				"ChangeMPC"
			};
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x001E9D22 File Offset: 0x001E7F22
		public static EModifyActorMaterialType[] GetValues()
		{
			return new EModifyActorMaterialType[]
			{
				EModifyActorMaterialType.ChangeMaterialData,
				EModifyActorMaterialType.ChangeMPC
			};
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x001E9D2E File Offset: 0x001E7F2E
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
