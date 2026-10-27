using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A04 RID: 2564
	public static class ESceneTextGuideUiScaleTypeExtensions
	{
		// Token: 0x060038C3 RID: 14531 RVA: 0x00092C94 File Offset: 0x00090E94
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

		// Token: 0x060038C4 RID: 14532 RVA: 0x00092CCC File Offset: 0x00090ECC
		public static ESceneTextGuideUiScaleType FromString(string name)
		{
			ESceneTextGuideUiScaleType result;
			if (!ESceneTextGuideUiScaleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneTextGuideUiScaleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00092CF5 File Offset: 0x00090EF5
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

		// Token: 0x060038C6 RID: 14534 RVA: 0x00092D2E File Offset: 0x00090F2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FarBigNearSmall",
				"FarSmallNearBig"
			};
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00092D46 File Offset: 0x00090F46
		public static ESceneTextGuideUiScaleType[] GetValues()
		{
			return new ESceneTextGuideUiScaleType[]
			{
				ESceneTextGuideUiScaleType.FarBigNearSmall,
				ESceneTextGuideUiScaleType.FarSmallNearBig
			};
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00092D52 File Offset: 0x00090F52
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
