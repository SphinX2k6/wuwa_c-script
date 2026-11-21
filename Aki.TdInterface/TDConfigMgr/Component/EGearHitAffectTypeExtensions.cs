using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A03 RID: 2563
	public static class EGearHitAffectTypeExtensions
	{
		// Token: 0x06003920 RID: 14624 RVA: 0x00093C90 File Offset: 0x00091E90
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

		// Token: 0x06003921 RID: 14625 RVA: 0x00093CB8 File Offset: 0x00091EB8
		public static EGearHitAffectType FromString(string name)
		{
			EGearHitAffectType result;
			if (!EGearHitAffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGearHitAffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x00093CE1 File Offset: 0x00091EE1
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

		// Token: 0x06003923 RID: 14627 RVA: 0x00093D06 File Offset: 0x00091F06
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeNextState"
			};
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00093D16 File Offset: 0x00091F16
		public static EGearHitAffectType[] GetValues()
		{
			return new EGearHitAffectType[1];
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00093D1E File Offset: 0x00091F1E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeNextState"
			};
		}
	}
}
