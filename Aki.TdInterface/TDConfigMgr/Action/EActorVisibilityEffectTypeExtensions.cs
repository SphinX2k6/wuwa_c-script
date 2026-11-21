using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002500 RID: 9472
	public static class EActorVisibilityEffectTypeExtensions
	{
		// Token: 0x0600CDDA RID: 52698 RVA: 0x001DD77C File Offset: 0x001DB97C
		public static string ToEnumString(this EActorVisibilityEffectType value)
		{
			string result;
			if (value == EActorVisibilityEffectType.Default)
			{
				result = "Default";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CDDB RID: 52699 RVA: 0x001DD7A4 File Offset: 0x001DB9A4
		public static EActorVisibilityEffectType FromString(string name)
		{
			EActorVisibilityEffectType result;
			if (!EActorVisibilityEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorVisibilityEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDDC RID: 52700 RVA: 0x001DD7CD File Offset: 0x001DB9CD
		public static bool TryFromString(string name, out EActorVisibilityEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorVisibilityEffectType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EActorVisibilityEffectType.Default;
				return true;
			}
			value = EActorVisibilityEffectType.Default;
			return false;
		}

		// Token: 0x0600CDDD RID: 52701 RVA: 0x001DD7F2 File Offset: 0x001DB9F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x001DD802 File Offset: 0x001DBA02
		public static EActorVisibilityEffectType[] GetValues()
		{
			return new EActorVisibilityEffectType[1];
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x001DD80A File Offset: 0x001DBA0A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}
