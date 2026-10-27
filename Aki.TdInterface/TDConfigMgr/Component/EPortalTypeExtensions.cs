using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DC RID: 2524
	public static class EPortalTypeExtensions
	{
		// Token: 0x0600380F RID: 14351 RVA: 0x000916D0 File Offset: 0x0008F8D0
		public static string ToEnumString(this EPortalType value)
		{
			string result;
			if (value != EPortalType.Static)
			{
				if (value != EPortalType.Dynamic)
				{
					result = value.ToString();
				}
				else
				{
					result = "Dynamic";
				}
			}
			else
			{
				result = "Static";
			}
			return result;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00091708 File Offset: 0x0008F908
		public static EPortalType FromString(string name)
		{
			EPortalType result;
			if (!EPortalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPortalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00091731 File Offset: 0x0008F931
		public static bool TryFromString(string name, out EPortalType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPortalType.Static;
				return false;
			}
			if (name == "Static")
			{
				value = EPortalType.Static;
				return true;
			}
			if (!(name == "Dynamic"))
			{
				value = EPortalType.Static;
				return false;
			}
			value = EPortalType.Dynamic;
			return true;
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x0009176A File Offset: 0x0008F96A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Static",
				"Dynamic"
			};
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00091782 File Offset: 0x0008F982
		public static EPortalType[] GetValues()
		{
			return new EPortalType[]
			{
				EPortalType.Static,
				EPortalType.Dynamic
			};
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0009178E File Offset: 0x0008F98E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Static",
				"Dynamic"
			};
		}
	}
}
