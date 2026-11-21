using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE5 RID: 2789
	public static class EStateRepPerfTypeExtensions
	{
		// Token: 0x06003D19 RID: 15641 RVA: 0x0009C8AC File Offset: 0x0009AAAC
		public static string ToEnumString(this EStateRepPerfType value)
		{
			string result;
			switch (value)
			{
			case EStateRepPerfType.SkillId:
				result = "SkillId";
				break;
			case EStateRepPerfType.MontagePath:
				result = "MontagePath";
				break;
			case EStateRepPerfType.Effects:
				result = "Effects";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0009C8F4 File Offset: 0x0009AAF4
		public static EStateRepPerfType FromString(string name)
		{
			EStateRepPerfType result;
			if (!EStateRepPerfTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStateRepPerfType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0009C920 File Offset: 0x0009AB20
		public static bool TryFromString(string name, out EStateRepPerfType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EStateRepPerfType.SkillId;
				return false;
			}
			if (name == "SkillId")
			{
				value = EStateRepPerfType.SkillId;
				return true;
			}
			if (name == "MontagePath")
			{
				value = EStateRepPerfType.MontagePath;
				return true;
			}
			if (!(name == "Effects"))
			{
				value = EStateRepPerfType.SkillId;
				return false;
			}
			value = EStateRepPerfType.Effects;
			return true;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0009C976 File Offset: 0x0009AB76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SkillId",
				"MontagePath",
				"Effects"
			};
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x0009C996 File Offset: 0x0009AB96
		public static EStateRepPerfType[] GetValues()
		{
			return new EStateRepPerfType[]
			{
				EStateRepPerfType.SkillId,
				EStateRepPerfType.MontagePath,
				EStateRepPerfType.Effects
			};
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x0009C9A6 File Offset: 0x0009ABA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SkillId",
				"MontagePath",
				"Effects"
			};
		}
	}
}
