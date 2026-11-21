using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABB RID: 2747
	public static class ERewardDropTypeExtensions
	{
		// Token: 0x06003C5C RID: 15452 RVA: 0x0009AED8 File Offset: 0x000990D8
		public static string ToEnumString(this ERewardDropType value)
		{
			string result;
			if (value != ERewardDropType.Death)
			{
				if (value != ERewardDropType.HostInteract)
				{
					result = value.ToString();
				}
				else
				{
					result = "HostInteract";
				}
			}
			else
			{
				result = "Death";
			}
			return result;
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x0009AF10 File Offset: 0x00099110
		public static ERewardDropType FromString(string name)
		{
			ERewardDropType result;
			if (!ERewardDropTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERewardDropType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x0009AF39 File Offset: 0x00099139
		public static bool TryFromString(string name, out ERewardDropType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERewardDropType.Death;
				return false;
			}
			if (name == "Death")
			{
				value = ERewardDropType.Death;
				return true;
			}
			if (!(name == "HostInteract"))
			{
				value = ERewardDropType.Death;
				return false;
			}
			value = ERewardDropType.HostInteract;
			return true;
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x0009AF72 File Offset: 0x00099172
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Death",
				"HostInteract"
			};
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x0009AF8A File Offset: 0x0009918A
		public static ERewardDropType[] GetValues()
		{
			return new ERewardDropType[]
			{
				ERewardDropType.Death,
				ERewardDropType.HostInteract
			};
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x0009AF96 File Offset: 0x00099196
		public static string[] GetNames()
		{
			return new string[]
			{
				"Death",
				"HostInteract"
			};
		}
	}
}
