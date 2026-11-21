using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC9 RID: 2761
	public static class ESceneTextGuideUiScaleTypeExtensions
	{
		// Token: 0x06003C9B RID: 15515 RVA: 0x0009B584 File Offset: 0x00099784
		public static string ToEnumString(this ESceneTextGuideUiScaleType value)
		{
			string result;
			if (value != ESceneTextGuideUiScaleType.FarBigNearSmall)
			{
				if (value != ESceneTextGuideUiScaleType.FarSmallNearBig)
				{
					result = value.ToString();
				}
				else
				{
					result = "FarSmallNearBig";
				}
			}
			else
			{
				result = "FarBigNearSmall";
			}
			return result;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0009B5BC File Offset: 0x000997BC
		public static ESceneTextGuideUiScaleType FromString(string name)
		{
			ESceneTextGuideUiScaleType result;
			if (!ESceneTextGuideUiScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneTextGuideUiScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0009B5E5 File Offset: 0x000997E5
		public static bool TryFromString(string name, out ESceneTextGuideUiScaleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneTextGuideUiScaleType.FarBigNearSmall;
				return false;
			}
			if (name == "FarBigNearSmall")
			{
				value = ESceneTextGuideUiScaleType.FarBigNearSmall;
				return true;
			}
			if (!(name == "FarSmallNearBig"))
			{
				value = ESceneTextGuideUiScaleType.FarBigNearSmall;
				return false;
			}
			value = ESceneTextGuideUiScaleType.FarSmallNearBig;
			return true;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x0009B61E File Offset: 0x0009981E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FarBigNearSmall",
				"FarSmallNearBig"
			};
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x0009B636 File Offset: 0x00099836
		public static ESceneTextGuideUiScaleType[] GetValues()
		{
			return new ESceneTextGuideUiScaleType[]
			{
				ESceneTextGuideUiScaleType.FarBigNearSmall,
				ESceneTextGuideUiScaleType.FarSmallNearBig
			};
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x0009B642 File Offset: 0x00099842
		public static string[] GetNames()
		{
			return new string[]
			{
				"FarBigNearSmall",
				"FarSmallNearBig"
			};
		}
	}
}
