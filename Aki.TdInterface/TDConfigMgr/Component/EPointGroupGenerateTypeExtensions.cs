using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D8 RID: 2520
	public static class EPointGroupGenerateTypeExtensions
	{
		// Token: 0x060037FD RID: 14333 RVA: 0x000914E0 File Offset: 0x0008F6E0
		public static string ToEnumString(this EPointGroupGenerateType value)
		{
			string result;
			if (value == EPointGroupGenerateType.Layer)
			{
				result = "Layer";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00091508 File Offset: 0x0008F708
		public static EPointGroupGenerateType FromString(string name)
		{
			EPointGroupGenerateType result;
			if (!EPointGroupGenerateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPointGroupGenerateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x00091531 File Offset: 0x0008F731
		public static bool TryFromString(string name, out EPointGroupGenerateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPointGroupGenerateType.Layer;
				return false;
			}
			if (name == "Layer")
			{
				value = EPointGroupGenerateType.Layer;
				return true;
			}
			value = EPointGroupGenerateType.Layer;
			return false;
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00091556 File Offset: 0x0008F756
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Layer"
			};
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00091566 File Offset: 0x0008F766
		public static EPointGroupGenerateType[] GetValues()
		{
			return new EPointGroupGenerateType[1];
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x0009156E File Offset: 0x0008F76E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Layer"
			};
		}
	}
}
