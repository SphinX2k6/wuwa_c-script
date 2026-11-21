using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BF RID: 2495
	public static class EConnectorPathAdvanceVisualTypeExtensions
	{
		// Token: 0x060037EE RID: 14318 RVA: 0x00091498 File Offset: 0x0008F698
		public static string ToEnumString(this EConnectorPathAdvanceVisualType value)
		{
			string result;
			if (value == EConnectorPathAdvanceVisualType.VasePlant)
			{
				result = "VasePlant";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000914C0 File Offset: 0x0008F6C0
		public static EConnectorPathAdvanceVisualType FromString(string name)
		{
			EConnectorPathAdvanceVisualType result;
			if (!EConnectorPathAdvanceVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConnectorPathAdvanceVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000914E9 File Offset: 0x0008F6E9
		public static bool TryFromString(string name, out EConnectorPathAdvanceVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConnectorPathAdvanceVisualType.VasePlant;
				return false;
			}
			if (name == "VasePlant")
			{
				value = EConnectorPathAdvanceVisualType.VasePlant;
				return true;
			}
			value = EConnectorPathAdvanceVisualType.VasePlant;
			return false;
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x0009150E File Offset: 0x0008F70E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"VasePlant"
			};
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0009151E File Offset: 0x0008F71E
		public static EConnectorPathAdvanceVisualType[] GetValues()
		{
			return new EConnectorPathAdvanceVisualType[1];
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00091526 File Offset: 0x0008F726
		public static string[] GetNames()
		{
			return new string[]
			{
				"VasePlant"
			};
		}
	}
}
