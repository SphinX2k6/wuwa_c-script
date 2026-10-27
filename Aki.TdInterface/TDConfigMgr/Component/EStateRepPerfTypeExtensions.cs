using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A20 RID: 2592
	public static class EStateRepPerfTypeExtensions
	{
		// Token: 0x06003941 RID: 14657 RVA: 0x00093F78 File Offset: 0x00092178
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

		// Token: 0x06003942 RID: 14658 RVA: 0x00093FC0 File Offset: 0x000921C0
		public static EStateRepPerfType FromString(string name)
		{
			EStateRepPerfType result;
			if (!EStateRepPerfTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStateRepPerfType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x00093FEC File Offset: 0x000921EC
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

		// Token: 0x06003944 RID: 14660 RVA: 0x00094042 File Offset: 0x00092242
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SkillId",
				"MontagePath",
				"Effects"
			};
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00094062 File Offset: 0x00092262
		public static EStateRepPerfType[] GetValues()
		{
			return new EStateRepPerfType[]
			{
				EStateRepPerfType.SkillId,
				EStateRepPerfType.MontagePath,
				EStateRepPerfType.Effects
			};
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00094072 File Offset: 0x00092272
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
