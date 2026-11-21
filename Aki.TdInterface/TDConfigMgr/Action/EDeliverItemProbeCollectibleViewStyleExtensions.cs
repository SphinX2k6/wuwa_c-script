using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256C RID: 9580
	public static class EDeliverItemProbeCollectibleViewStyleExtensions
	{
		// Token: 0x0600CFC0 RID: 53184 RVA: 0x001E1C18 File Offset: 0x001DFE18
		public static string ToEnumString(this EDeliverItemProbeCollectibleViewStyle value)
		{
			string result;
			if (value == EDeliverItemProbeCollectibleViewStyle.HandInItemStyle)
			{
				result = "HandInItemStyle";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x001E1C40 File Offset: 0x001DFE40
		public static EDeliverItemProbeCollectibleViewStyle FromString(string name)
		{
			EDeliverItemProbeCollectibleViewStyle result;
			if (!EDeliverItemProbeCollectibleViewStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDeliverItemProbeCollectibleViewStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x001E1C69 File Offset: 0x001DFE69
		public static bool TryFromString(string name, out EDeliverItemProbeCollectibleViewStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				return false;
			}
			if (name == "HandInItemStyle")
			{
				value = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				return true;
			}
			value = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
			return false;
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x001E1C8E File Offset: 0x001DFE8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HandInItemStyle"
			};
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x001E1C9E File Offset: 0x001DFE9E
		public static EDeliverItemProbeCollectibleViewStyle[] GetValues()
		{
			return new EDeliverItemProbeCollectibleViewStyle[1];
		}

		// Token: 0x0600CFC5 RID: 53189 RVA: 0x001E1CA6 File Offset: 0x001DFEA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"HandInItemStyle"
			};
		}
	}
}
