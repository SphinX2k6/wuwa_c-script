using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AF RID: 9135
	public static class ENpcGroupPerformNpcTypeExtensions
	{
		// Token: 0x0600C712 RID: 50962 RVA: 0x001D2594 File Offset: 0x001D0794
		public static string ToEnumString(this ENpcGroupPerformNpcType value)
		{
			string result;
			switch (value)
			{
			case ENpcGroupPerformNpcType.LevelBCommonMale:
				result = "LevelBCommonMale";
				break;
			case ENpcGroupPerformNpcType.LevelBCommonFemale:
				result = "LevelBCommonFemale";
				break;
			case ENpcGroupPerformNpcType.EcologyBear:
				result = "EcologyBear";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x001D25DC File Offset: 0x001D07DC
		public static ENpcGroupPerformNpcType FromString(string name)
		{
			ENpcGroupPerformNpcType result;
			if (!ENpcGroupPerformNpcTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupPerformNpcType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x001D2608 File Offset: 0x001D0808
		public static bool TryFromString(string name, out ENpcGroupPerformNpcType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return false;
			}
			if (name == "LevelBCommonMale")
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return true;
			}
			if (name == "LevelBCommonFemale")
			{
				value = ENpcGroupPerformNpcType.LevelBCommonFemale;
				return true;
			}
			if (!(name == "EcologyBear"))
			{
				value = ENpcGroupPerformNpcType.LevelBCommonMale;
				return false;
			}
			value = ENpcGroupPerformNpcType.EcologyBear;
			return true;
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x001D265E File Offset: 0x001D085E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelBCommonMale",
				"LevelBCommonFemale",
				"EcologyBear"
			};
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x001D267E File Offset: 0x001D087E
		public static ENpcGroupPerformNpcType[] GetValues()
		{
			return new ENpcGroupPerformNpcType[]
			{
				ENpcGroupPerformNpcType.LevelBCommonMale,
				ENpcGroupPerformNpcType.LevelBCommonFemale,
				ENpcGroupPerformNpcType.EcologyBear
			};
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x001D268E File Offset: 0x001D088E
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelBCommonMale",
				"LevelBCommonFemale",
				"EcologyBear"
			};
		}
	}
}
