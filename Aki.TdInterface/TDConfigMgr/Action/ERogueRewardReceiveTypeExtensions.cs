using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F5 RID: 9205
	public static class ERogueRewardReceiveTypeExtensions
	{
		// Token: 0x0600C84D RID: 51277 RVA: 0x001D5124 File Offset: 0x001D3324
		public static string ToEnumString(this ERogueRewardReceiveType value)
		{
			string result;
			if (value != ERogueRewardReceiveType.ReceiveByCount)
			{
				if (value != ERogueRewardReceiveType.ReceiveByEnergy)
				{
					result = value.ToString();
				}
				else
				{
					result = "ReceiveByEnergy";
				}
			}
			else
			{
				result = "ReceiveByCount";
			}
			return result;
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x001D515C File Offset: 0x001D335C
		public static ERogueRewardReceiveType FromString(string name)
		{
			ERogueRewardReceiveType result;
			if (!ERogueRewardReceiveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueRewardReceiveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x001D5185 File Offset: 0x001D3385
		public static bool TryFromString(string name, out ERogueRewardReceiveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERogueRewardReceiveType.ReceiveByCount;
				return false;
			}
			if (name == "ReceiveByCount")
			{
				value = ERogueRewardReceiveType.ReceiveByCount;
				return true;
			}
			if (!(name == "ReceiveByEnergy"))
			{
				value = ERogueRewardReceiveType.ReceiveByCount;
				return false;
			}
			value = ERogueRewardReceiveType.ReceiveByEnergy;
			return true;
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x001D51BE File Offset: 0x001D33BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ReceiveByCount",
				"ReceiveByEnergy"
			};
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x001D51D6 File Offset: 0x001D33D6
		public static ERogueRewardReceiveType[] GetValues()
		{
			return new ERogueRewardReceiveType[]
			{
				ERogueRewardReceiveType.ReceiveByCount,
				ERogueRewardReceiveType.ReceiveByEnergy
			};
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x001D51E2 File Offset: 0x001D33E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ReceiveByCount",
				"ReceiveByEnergy"
			};
		}
	}
}
