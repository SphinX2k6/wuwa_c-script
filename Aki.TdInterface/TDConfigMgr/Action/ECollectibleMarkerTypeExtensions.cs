using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E9 RID: 8937
	public static class ECollectibleMarkerTypeExtensions
	{
		// Token: 0x0600C397 RID: 50071 RVA: 0x001C929C File Offset: 0x001C749C
		public static string ToEnumString(this ECollectibleMarkerType value)
		{
			string result;
			if (value == ECollectibleMarkerType.Placeholder)
			{
				result = "Placeholder";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x001C92C4 File Offset: 0x001C74C4
		public static ECollectibleMarkerType FromString(string name)
		{
			ECollectibleMarkerType result;
			if (!ECollectibleMarkerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECollectibleMarkerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x001C92ED File Offset: 0x001C74ED
		public static bool TryFromString(string name, out ECollectibleMarkerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECollectibleMarkerType.Placeholder;
				return false;
			}
			if (name == "Placeholder")
			{
				value = ECollectibleMarkerType.Placeholder;
				return true;
			}
			value = ECollectibleMarkerType.Placeholder;
			return false;
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x001C9312 File Offset: 0x001C7512
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Placeholder"
			};
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x001C9322 File Offset: 0x001C7522
		public static ECollectibleMarkerType[] GetValues()
		{
			return new ECollectibleMarkerType[1];
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x001C932A File Offset: 0x001C752A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Placeholder"
			};
		}
	}
}
