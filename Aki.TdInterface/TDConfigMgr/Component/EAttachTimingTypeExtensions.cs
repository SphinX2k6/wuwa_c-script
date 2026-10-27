using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F6 RID: 2294
	public static class EAttachTimingTypeExtensions
	{
		// Token: 0x06003404 RID: 13316 RVA: 0x00084F48 File Offset: 0x00083148
		public static string ToEnumString(this EAttachTimingType value)
		{
			string result;
			if (value != EAttachTimingType.Default)
			{
				if (value != EAttachTimingType.OnMoveWithSplineEnd)
				{
					result = value.ToString();
				}
				else
				{
					result = "OnMoveWithSplineEnd";
				}
			}
			else
			{
				result = "Default";
			}
			return result;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00084F80 File Offset: 0x00083180
		public static EAttachTimingType FromString(string name)
		{
			EAttachTimingType result;
			if (!EAttachTimingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachTimingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00084FA9 File Offset: 0x000831A9
		public static bool TryFromString(string name, out EAttachTimingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttachTimingType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EAttachTimingType.Default;
				return true;
			}
			if (!(name == "OnMoveWithSplineEnd"))
			{
				value = EAttachTimingType.Default;
				return false;
			}
			value = EAttachTimingType.OnMoveWithSplineEnd;
			return true;
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00084FE2 File Offset: 0x000831E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"OnMoveWithSplineEnd"
			};
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00084FFA File Offset: 0x000831FA
		public static EAttachTimingType[] GetValues()
		{
			return new EAttachTimingType[]
			{
				EAttachTimingType.Default,
				EAttachTimingType.OnMoveWithSplineEnd
			};
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00085006 File Offset: 0x00083206
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"OnMoveWithSplineEnd"
			};
		}
	}
}
