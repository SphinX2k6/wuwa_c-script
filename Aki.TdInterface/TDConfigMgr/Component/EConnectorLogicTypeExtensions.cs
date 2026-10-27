using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000910 RID: 2320
	public static class EConnectorLogicTypeExtensions
	{
		// Token: 0x06003479 RID: 13433 RVA: 0x00089804 File Offset: 0x00087A04
		public static string ToEnumString(this EConnectorLogicType value)
		{
			string result;
			if (value != EConnectorLogicType.Range)
			{
				if (value != EConnectorLogicType.PointToPointPathAdvance)
				{
					result = value.ToString();
				}
				else
				{
					result = "PointToPointPathAdvance";
				}
			}
			else
			{
				result = "Range";
			}
			return result;
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x0008983C File Offset: 0x00087A3C
		public static EConnectorLogicType FromString(string name)
		{
			EConnectorLogicType result;
			if (!EConnectorLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConnectorLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00089865 File Offset: 0x00087A65
		public static bool TryFromString(string name, out EConnectorLogicType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConnectorLogicType.Range;
				return false;
			}
			if (name == "Range")
			{
				value = EConnectorLogicType.Range;
				return true;
			}
			if (!(name == "PointToPointPathAdvance"))
			{
				value = EConnectorLogicType.Range;
				return false;
			}
			value = EConnectorLogicType.PointToPointPathAdvance;
			return true;
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x0008989E File Offset: 0x00087A9E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Range",
				"PointToPointPathAdvance"
			};
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000898B6 File Offset: 0x00087AB6
		public static EConnectorLogicType[] GetValues()
		{
			return new EConnectorLogicType[]
			{
				EConnectorLogicType.Range,
				EConnectorLogicType.PointToPointPathAdvance
			};
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000898C2 File Offset: 0x00087AC2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Range",
				"PointToPointPathAdvance"
			};
		}
	}
}
