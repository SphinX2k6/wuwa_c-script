using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FB RID: 8955
	public static class EDeliverItemProbeCollectibleViewStyleExtensions
	{
		// Token: 0x0600C3E8 RID: 50152 RVA: 0x001C9C74 File Offset: 0x001C7E74
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

		// Token: 0x0600C3E9 RID: 50153 RVA: 0x001C9C9C File Offset: 0x001C7E9C
		public static EDeliverItemProbeCollectibleViewStyle FromString(string name)
		{
			EDeliverItemProbeCollectibleViewStyle result;
			if (!EDeliverItemProbeCollectibleViewStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDeliverItemProbeCollectibleViewStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3EA RID: 50154 RVA: 0x001C9CC5 File Offset: 0x001C7EC5
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

		// Token: 0x0600C3EB RID: 50155 RVA: 0x001C9CEA File Offset: 0x001C7EEA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HandInItemStyle"
			};
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x001C9CFA File Offset: 0x001C7EFA
		public static EDeliverItemProbeCollectibleViewStyle[] GetValues()
		{
			return new EDeliverItemProbeCollectibleViewStyle[1];
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x001C9D02 File Offset: 0x001C7F02
		public static string[] GetNames()
		{
			return new string[]
			{
				"HandInItemStyle"
			};
		}
	}
}
