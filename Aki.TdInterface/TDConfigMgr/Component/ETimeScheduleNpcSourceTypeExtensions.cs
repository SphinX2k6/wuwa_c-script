using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFF RID: 2815
	public static class ETimeScheduleNpcSourceTypeExtensions
	{
		// Token: 0x06003D8E RID: 15758 RVA: 0x0009D824 File Offset: 0x0009BA24
		public static string ToEnumString(this ETimeScheduleNpcSourceType value)
		{
			string result;
			if (value == ETimeScheduleNpcSourceType.EntityTemplate)
			{
				result = "EntityTemplate";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x0009D84C File Offset: 0x0009BA4C
		public static ETimeScheduleNpcSourceType FromString(string name)
		{
			ETimeScheduleNpcSourceType result;
			if (!ETimeScheduleNpcSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleNpcSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x0009D875 File Offset: 0x0009BA75
		public static bool TryFromString(string name, out ETimeScheduleNpcSourceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeScheduleNpcSourceType.EntityTemplate;
				return false;
			}
			if (name == "EntityTemplate")
			{
				value = ETimeScheduleNpcSourceType.EntityTemplate;
				return true;
			}
			value = ETimeScheduleNpcSourceType.EntityTemplate;
			return false;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x0009D89A File Offset: 0x0009BA9A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityTemplate"
			};
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x0009D8AA File Offset: 0x0009BAAA
		public static ETimeScheduleNpcSourceType[] GetValues()
		{
			return new ETimeScheduleNpcSourceType[1];
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x0009D8B2 File Offset: 0x0009BAB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityTemplate"
			};
		}
	}
}
