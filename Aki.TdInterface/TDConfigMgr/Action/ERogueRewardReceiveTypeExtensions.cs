using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268C RID: 9868
	public static class ERogueRewardReceiveTypeExtensions
	{
		// Token: 0x0600D4D0 RID: 54480 RVA: 0x001EE8D0 File Offset: 0x001ECAD0
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

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x001EE908 File Offset: 0x001ECB08
		public static ERogueRewardReceiveType FromString(string name)
		{
			ERogueRewardReceiveType result;
			if (!ERogueRewardReceiveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERogueRewardReceiveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x001EE931 File Offset: 0x001ECB31
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

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x001EE96A File Offset: 0x001ECB6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ReceiveByCount",
				"ReceiveByEnergy"
			};
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x001EE982 File Offset: 0x001ECB82
		public static ERogueRewardReceiveType[] GetValues()
		{
			return new ERogueRewardReceiveType[]
			{
				ERogueRewardReceiveType.ReceiveByCount,
				ERogueRewardReceiveType.ReceiveByEnergy
			};
		}

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x001EE98E File Offset: 0x001ECB8E
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
