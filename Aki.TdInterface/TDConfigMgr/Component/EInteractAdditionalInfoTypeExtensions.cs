using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A23 RID: 2595
	public static class EInteractAdditionalInfoTypeExtensions
	{
		// Token: 0x060039B0 RID: 14768 RVA: 0x0009548C File Offset: 0x0009368C
		public static string ToEnumString(this EInteractAdditionalInfoType value)
		{
			string result;
			if (value == EInteractAdditionalInfoType.FishingPoint)
			{
				result = "FishingPoint";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x000954B4 File Offset: 0x000936B4
		public static EInteractAdditionalInfoType FromString(string name)
		{
			EInteractAdditionalInfoType result;
			if (!EInteractAdditionalInfoTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractAdditionalInfoType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x000954DD File Offset: 0x000936DD
		public static bool TryFromString(string name, out EInteractAdditionalInfoType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractAdditionalInfoType.FishingPoint;
				return false;
			}
			if (name == "FishingPoint")
			{
				value = EInteractAdditionalInfoType.FishingPoint;
				return true;
			}
			value = EInteractAdditionalInfoType.FishingPoint;
			return false;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00095502 File Offset: 0x00093702
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FishingPoint"
			};
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00095512 File Offset: 0x00093712
		public static EInteractAdditionalInfoType[] GetValues()
		{
			return new EInteractAdditionalInfoType[1];
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0009551A File Offset: 0x0009371A
		public static string[] GetNames()
		{
			return new string[]
			{
				"FishingPoint"
			};
		}
	}
}
