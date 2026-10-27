using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3A RID: 2618
	public static class ETimeScheduleNpcSourceTypeExtensions
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x00094EF0 File Offset: 0x000930F0
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

		// Token: 0x060039B7 RID: 14775 RVA: 0x00094F18 File Offset: 0x00093118
		public static ETimeScheduleNpcSourceType FromString(string name)
		{
			ETimeScheduleNpcSourceType result;
			if (!ETimeScheduleNpcSourceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeScheduleNpcSourceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00094F41 File Offset: 0x00093141
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

		// Token: 0x060039B9 RID: 14777 RVA: 0x00094F66 File Offset: 0x00093166
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityTemplate"
			};
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00094F76 File Offset: 0x00093176
		public static ETimeScheduleNpcSourceType[] GetValues()
		{
			return new ETimeScheduleNpcSourceType[1];
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00094F7E File Offset: 0x0009317E
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityTemplate"
			};
		}
	}
}
