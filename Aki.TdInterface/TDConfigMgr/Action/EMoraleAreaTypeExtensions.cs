using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002614 RID: 9748
	public static class EMoraleAreaTypeExtensions
	{
		// Token: 0x0600D2B4 RID: 53940 RVA: 0x001EA050 File Offset: 0x001E8250
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

		// Token: 0x0600D2B5 RID: 53941 RVA: 0x001EA0B0 File Offset: 0x001E82B0
		public static EMoraleAreaType FromString(string name)
		{
			EMoraleAreaType result;
			if (!EMoraleAreaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoraleAreaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x001EA0DC File Offset: 0x001E82DC
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

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x001EA156 File Offset: 0x001E8356
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

		// Token: 0x0600D2B8 RID: 53944 RVA: 0x001EA186 File Offset: 0x001E8386
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

		// Token: 0x0600D2B9 RID: 53945 RVA: 0x001EA199 File Offset: 0x001E8399
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
