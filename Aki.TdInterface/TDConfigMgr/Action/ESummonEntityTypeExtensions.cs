using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243D RID: 9277
	public static class ESummonEntityTypeExtensions
	{
		// Token: 0x0600C991 RID: 51601 RVA: 0x001D8348 File Offset: 0x001D6548
		public static string ToEnumString(this ESummonEntityType value)
		{
			string result;
			if (value == ESummonEntityType.Vehicle)
			{
				result = "Vehicle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C992 RID: 51602 RVA: 0x001D8370 File Offset: 0x001D6570
		public static ESummonEntityType FromString(string name)
		{
			ESummonEntityType result;
			if (!ESummonEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESummonEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C993 RID: 51603 RVA: 0x001D8399 File Offset: 0x001D6599
		public static bool TryFromString(string name, out ESummonEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESummonEntityType.Vehicle;
				return false;
			}
			if (name == "Vehicle")
			{
				value = ESummonEntityType.Vehicle;
				return true;
			}
			value = ESummonEntityType.Vehicle;
			return false;
		}

		// Token: 0x0600C994 RID: 51604 RVA: 0x001D83BE File Offset: 0x001D65BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Vehicle"
			};
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x001D83CE File Offset: 0x001D65CE
		public static ESummonEntityType[] GetValues()
		{
			return new ESummonEntityType[1];
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x001D83D6 File Offset: 0x001D65D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Vehicle"
			};
		}
	}
}
