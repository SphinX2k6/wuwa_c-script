using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000950 RID: 2384
	public static class EGearHitAffectTypeExtensions
	{
		// Token: 0x06003599 RID: 13721 RVA: 0x0008BD3C File Offset: 0x00089F3C
		public static string ToEnumString(this EGearHitAffectType value)
		{
			string result;
			if (value == EGearHitAffectType.ChangeNextState)
			{
				result = "ChangeNextState";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0008BD64 File Offset: 0x00089F64
		public static EGearHitAffectType FromString(string name)
		{
			EGearHitAffectType result;
			if (!EGearHitAffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGearHitAffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0008BD8D File Offset: 0x00089F8D
		public static bool TryFromString(string name, out EGearHitAffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGearHitAffectType.ChangeNextState;
				return false;
			}
			if (name == "ChangeNextState")
			{
				value = EGearHitAffectType.ChangeNextState;
				return true;
			}
			value = EGearHitAffectType.ChangeNextState;
			return false;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x0008BDB2 File Offset: 0x00089FB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeNextState"
			};
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x0008BDC2 File Offset: 0x00089FC2
		public static EGearHitAffectType[] GetValues()
		{
			return new EGearHitAffectType[1];
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x0008BDCA File Offset: 0x00089FCA
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeNextState"
			};
		}
	}
}
