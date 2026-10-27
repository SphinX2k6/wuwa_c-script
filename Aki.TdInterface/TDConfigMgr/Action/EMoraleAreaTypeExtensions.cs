using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238B RID: 9099
	public static class EMoraleAreaTypeExtensions
	{
		// Token: 0x0600C670 RID: 50800 RVA: 0x001D107C File Offset: 0x001CF27C
		public static string ToEnumString(this EMoraleAreaType value)
		{
			string result;
			switch (value)
			{
			case EMoraleAreaType.MoraleArea1:
				result = "MoraleArea1";
				break;
			case EMoraleAreaType.MoraleArea2:
				result = "MoraleArea2";
				break;
			case EMoraleAreaType.MoraleArea3:
				result = "MoraleArea3";
				break;
			case EMoraleAreaType.MoraleArea4:
				result = "MoraleArea4";
				break;
			case EMoraleAreaType.MoraleArea5:
				result = "MoraleArea5";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x001D10DC File Offset: 0x001CF2DC
		public static EMoraleAreaType FromString(string name)
		{
			EMoraleAreaType result;
			if (!EMoraleAreaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoraleAreaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x001D1108 File Offset: 0x001CF308
		public static bool TryFromString(string name, out EMoraleAreaType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoraleAreaType.MoraleArea1;
				return false;
			}
			if (name == "MoraleArea1")
			{
				value = EMoraleAreaType.MoraleArea1;
				return true;
			}
			if (name == "MoraleArea2")
			{
				value = EMoraleAreaType.MoraleArea2;
				return true;
			}
			if (name == "MoraleArea3")
			{
				value = EMoraleAreaType.MoraleArea3;
				return true;
			}
			if (name == "MoraleArea4")
			{
				value = EMoraleAreaType.MoraleArea4;
				return true;
			}
			if (!(name == "MoraleArea5"))
			{
				value = EMoraleAreaType.MoraleArea1;
				return false;
			}
			value = EMoraleAreaType.MoraleArea5;
			return true;
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x001D1182 File Offset: 0x001CF382
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoraleArea1",
				"MoraleArea2",
				"MoraleArea3",
				"MoraleArea4",
				"MoraleArea5"
			};
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x001D11B2 File Offset: 0x001CF3B2
		public static EMoraleAreaType[] GetValues()
		{
			return new EMoraleAreaType[]
			{
				EMoraleAreaType.MoraleArea1,
				EMoraleAreaType.MoraleArea2,
				EMoraleAreaType.MoraleArea3,
				EMoraleAreaType.MoraleArea4,
				EMoraleAreaType.MoraleArea5
			};
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x001D11C5 File Offset: 0x001CF3C5
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoraleArea1",
				"MoraleArea2",
				"MoraleArea3",
				"MoraleArea4",
				"MoraleArea5"
			};
		}
	}
}
