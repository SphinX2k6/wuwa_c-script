using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002399 RID: 9113
	public static class EMoveEventExtensions
	{
		// Token: 0x0600C6AF RID: 50863 RVA: 0x001D18B8 File Offset: 0x001CFAB8
		public static string ToEnumString(this EMoveEvent value)
		{
			string result;
			if (value != EMoveEvent.Walk)
			{
				if (value != EMoveEvent.Run)
				{
					result = value.ToString();
				}
				else
				{
					result = "怪物.common.关卡.朝目标点移动.跑";
				}
			}
			else
			{
				result = "怪物.common.关卡.朝目标点移动.走";
			}
			return result;
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x001D18F0 File Offset: 0x001CFAF0
		public static EMoveEvent FromString(string name)
		{
			EMoveEvent result;
			if (!EMoveEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x001D1919 File Offset: 0x001CFB19
		public static bool TryFromString(string name, out EMoveEvent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoveEvent.Walk;
				return false;
			}
			if (name == "怪物.common.关卡.朝目标点移动.走")
			{
				value = EMoveEvent.Walk;
				return true;
			}
			if (!(name == "怪物.common.关卡.朝目标点移动.跑"))
			{
				value = EMoveEvent.Walk;
				return false;
			}
			value = EMoveEvent.Run;
			return true;
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x001D1952 File Offset: 0x001CFB52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.朝目标点移动.走",
				"怪物.common.关卡.朝目标点移动.跑"
			};
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x001D196A File Offset: 0x001CFB6A
		public static EMoveEvent[] GetValues()
		{
			return new EMoveEvent[]
			{
				EMoveEvent.Walk,
				EMoveEvent.Run
			};
		}

		// Token: 0x0600C6B4 RID: 50868 RVA: 0x001D1976 File Offset: 0x001CFB76
		public static string[] GetNames()
		{
			return new string[]
			{
				"Walk",
				"Run"
			};
		}
	}
}
