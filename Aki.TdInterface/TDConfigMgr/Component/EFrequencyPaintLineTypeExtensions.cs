using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A01 RID: 2561
	public static class EFrequencyPaintLineTypeExtensions
	{
		// Token: 0x06003917 RID: 14615 RVA: 0x00093B08 File Offset: 0x00091D08
		public static string ToEnumString(this EFrequencyPaintLineType value)
		{
			string result;
			switch (value)
			{
			case EFrequencyPaintLineType.Straight:
				result = "Straight";
				break;
			case EFrequencyPaintLineType.ConnectLine:
				result = "ConnectLine";
				break;
			case EFrequencyPaintLineType.Enclose:
				result = "Enclose";
				break;
			case EFrequencyPaintLineType.Stroke:
				result = "Stroke";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00093B5C File Offset: 0x00091D5C
		public static EFrequencyPaintLineType FromString(string name)
		{
			EFrequencyPaintLineType result;
			if (!EFrequencyPaintLineTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFrequencyPaintLineType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00093B88 File Offset: 0x00091D88
		public static bool TryFromString(string name, out EFrequencyPaintLineType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFrequencyPaintLineType.Straight;
				return false;
			}
			if (name == "Straight")
			{
				value = EFrequencyPaintLineType.Straight;
				return true;
			}
			if (name == "ConnectLine")
			{
				value = EFrequencyPaintLineType.ConnectLine;
				return true;
			}
			if (name == "Enclose")
			{
				value = EFrequencyPaintLineType.Enclose;
				return true;
			}
			if (!(name == "Stroke"))
			{
				value = EFrequencyPaintLineType.Straight;
				return false;
			}
			value = EFrequencyPaintLineType.Stroke;
			return true;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00093BF0 File Offset: 0x00091DF0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Straight",
				"ConnectLine",
				"Enclose",
				"Stroke"
			};
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00093C18 File Offset: 0x00091E18
		public static EFrequencyPaintLineType[] GetValues()
		{
			return new EFrequencyPaintLineType[]
			{
				EFrequencyPaintLineType.Straight,
				EFrequencyPaintLineType.ConnectLine,
				EFrequencyPaintLineType.Enclose,
				EFrequencyPaintLineType.Stroke
			};
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00093C2B File Offset: 0x00091E2B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Straight",
				"ConnectLine",
				"Enclose",
				"Stroke"
			};
		}
	}
}
