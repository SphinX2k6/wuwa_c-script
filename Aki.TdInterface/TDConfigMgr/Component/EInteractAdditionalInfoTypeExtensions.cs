using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000970 RID: 2416
	public static class EInteractAdditionalInfoTypeExtensions
	{
		// Token: 0x06003629 RID: 13865 RVA: 0x0008D520 File Offset: 0x0008B720
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

		// Token: 0x0600362A RID: 13866 RVA: 0x0008D548 File Offset: 0x0008B748
		public static EInteractAdditionalInfoType FromString(string name)
		{
			EInteractAdditionalInfoType result;
			if (!EInteractAdditionalInfoTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractAdditionalInfoType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0008D571 File Offset: 0x0008B771
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

		// Token: 0x0600362C RID: 13868 RVA: 0x0008D596 File Offset: 0x0008B796
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FishingPoint"
			};
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0008D5A6 File Offset: 0x0008B7A6
		public static EInteractAdditionalInfoType[] GetValues()
		{
			return new EInteractAdditionalInfoType[1];
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0008D5AE File Offset: 0x0008B7AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"FishingPoint"
			};
		}
	}
}
