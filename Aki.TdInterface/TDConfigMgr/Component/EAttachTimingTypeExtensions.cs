using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099F RID: 2463
	public static class EAttachTimingTypeExtensions
	{
		// Token: 0x0600375E RID: 14174 RVA: 0x0008C774 File Offset: 0x0008A974
		public static string ToEnumString(this EAttachTimingType value)
		{
			string result;
			switch (value)
			{
			case EAttachTimingType.Default:
				result = "Default";
				break;
			case EAttachTimingType.OnMoveWithSplineEnd:
				result = "OnMoveWithSplineEnd";
				break;
			case EAttachTimingType.OnEntityStateChange:
				result = "OnEntityStateChange";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0008C7BC File Offset: 0x0008A9BC
		public static EAttachTimingType FromString(string name)
		{
			EAttachTimingType result;
			if (!EAttachTimingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachTimingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0008C7E8 File Offset: 0x0008A9E8
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
			if (name == "OnMoveWithSplineEnd")
			{
				value = EAttachTimingType.OnMoveWithSplineEnd;
				return true;
			}
			if (!(name == "OnEntityStateChange"))
			{
				value = EAttachTimingType.Default;
				return false;
			}
			value = EAttachTimingType.OnEntityStateChange;
			return true;
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0008C83E File Offset: 0x0008AA3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"OnMoveWithSplineEnd",
				"OnEntityStateChange"
			};
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0008C85E File Offset: 0x0008AA5E
		public static EAttachTimingType[] GetValues()
		{
			return new EAttachTimingType[]
			{
				EAttachTimingType.Default,
				EAttachTimingType.OnMoveWithSplineEnd,
				EAttachTimingType.OnEntityStateChange
			};
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0008C86E File Offset: 0x0008AA6E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"OnMoveWithSplineEnd",
				"OnEntityStateChange"
			};
		}
	}
}
