using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002624 RID: 9764
	public static class EMoveEventExtensions
	{
		// Token: 0x0600D2FC RID: 54012 RVA: 0x001EAA58 File Offset: 0x001E8C58
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

		// Token: 0x0600D2FD RID: 54013 RVA: 0x001EAA90 File Offset: 0x001E8C90
		public static EMoveEvent FromString(string name)
		{
			EMoveEvent result;
			if (!EMoveEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2FE RID: 54014 RVA: 0x001EAAB9 File Offset: 0x001E8CB9
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

		// Token: 0x0600D2FF RID: 54015 RVA: 0x001EAAF2 File Offset: 0x001E8CF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.朝目标点移动.走",
				"怪物.common.关卡.朝目标点移动.跑"
			};
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x001EAB0A File Offset: 0x001E8D0A
		public static EMoveEvent[] GetValues()
		{
			return new EMoveEvent[]
			{
				EMoveEvent.Walk,
				EMoveEvent.Run
			};
		}

		// Token: 0x0600D301 RID: 54017 RVA: 0x001EAB16 File Offset: 0x001E8D16
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
