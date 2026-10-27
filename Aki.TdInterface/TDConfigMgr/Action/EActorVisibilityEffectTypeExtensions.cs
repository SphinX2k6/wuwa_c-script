using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002293 RID: 8851
	public static class EActorVisibilityEffectTypeExtensions
	{
		// Token: 0x0600C214 RID: 49684 RVA: 0x001C5A88 File Offset: 0x001C3C88
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

		// Token: 0x0600C215 RID: 49685 RVA: 0x001C5AB0 File Offset: 0x001C3CB0
		public static EActorVisibilityEffectType FromString(string name)
		{
			EActorVisibilityEffectType result;
			if (!EActorVisibilityEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorVisibilityEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x001C5AD9 File Offset: 0x001C3CD9
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

		// Token: 0x0600C217 RID: 49687 RVA: 0x001C5AFE File Offset: 0x001C3CFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x001C5B0E File Offset: 0x001C3D0E
		public static EActorVisibilityEffectType[] GetValues()
		{
			return new EActorVisibilityEffectType[1];
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x001C5B16 File Offset: 0x001C3D16
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}
