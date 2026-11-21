using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002536 RID: 9526
	public static class EBvbPlayerOperationTypeExtensions
	{
		// Token: 0x0600CECD RID: 52941 RVA: 0x001DFB68 File Offset: 0x001DDD68
		public static string ToEnumString(this EBvbPlayerOperationType value)
		{
			string result;
			switch (value)
			{
			case EBvbPlayerOperationType.BvbDeploy:
				result = "BvbDeploy";
				break;
			case EBvbPlayerOperationType.BvbEvolution:
				result = "BvbEvolution";
				break;
			case EBvbPlayerOperationType.BvbChangeHandCard:
				result = "BvbChangeHandCard";
				break;
			case EBvbPlayerOperationType.BvbChangeBoardCard:
				result = "BvbChangeBoardCard";
				break;
			case EBvbPlayerOperationType.BvbRecycleHandCard:
				result = "BvbRecycleHandCard";
				break;
			case EBvbPlayerOperationType.BvbRecycleBoardCard:
				result = "BvbRecycleBoardCard";
				break;
			case EBvbPlayerOperationType.BvbEndTurn:
				result = "BvbEndTurn";
				break;
			case EBvbPlayerOperationType.BvbUseItemCardSkill:
				result = "BvbUseItemCardSkill";
				break;
			case EBvbPlayerOperationType.BvbUseFieldCardSkill:
				result = "BvbUseFieldCardSkill";
				break;
			case EBvbPlayerOperationType.BvbSelectCard:
				result = "BvbSelectCard";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x001DFC04 File Offset: 0x001DDE04
		public static EBvbPlayerOperationType FromString(string name)
		{
			EBvbPlayerOperationType result;
			if (!EBvbPlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBvbPlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x001DFC30 File Offset: 0x001DDE30
		public static bool TryFromString(string name, out EBvbPlayerOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBvbPlayerOperationType.BvbDeploy;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 9:
					if (name == "BvbDeploy")
					{
						value = EBvbPlayerOperationType.BvbDeploy;
						return true;
					}
					break;
				case 10:
					if (name == "BvbEndTurn")
					{
						value = EBvbPlayerOperationType.BvbEndTurn;
						return true;
					}
					break;
				case 12:
					if (name == "BvbEvolution")
					{
						value = EBvbPlayerOperationType.BvbEvolution;
						return true;
					}
					break;
				case 13:
					if (name == "BvbSelectCard")
					{
						value = EBvbPlayerOperationType.BvbSelectCard;
						return true;
					}
					break;
				case 17:
					if (name == "BvbChangeHandCard")
					{
						value = EBvbPlayerOperationType.BvbChangeHandCard;
						return true;
					}
					break;
				case 18:
				{
					char c = name[3];
					if (c != 'C')
					{
						if (c == 'R')
						{
							if (name == "BvbRecycleHandCard")
							{
								value = EBvbPlayerOperationType.BvbRecycleHandCard;
								return true;
							}
						}
					}
					else if (name == "BvbChangeBoardCard")
					{
						value = EBvbPlayerOperationType.BvbChangeBoardCard;
						return true;
					}
					break;
				}
				case 19:
				{
					char c = name[3];
					if (c != 'R')
					{
						if (c == 'U')
						{
							if (name == "BvbUseItemCardSkill")
							{
								value = EBvbPlayerOperationType.BvbUseItemCardSkill;
								return true;
							}
						}
					}
					else if (name == "BvbRecycleBoardCard")
					{
						value = EBvbPlayerOperationType.BvbRecycleBoardCard;
						return true;
					}
					break;
				}
				case 20:
					if (name == "BvbUseFieldCardSkill")
					{
						value = EBvbPlayerOperationType.BvbUseFieldCardSkill;
						return true;
					}
					break;
				}
			}
			value = EBvbPlayerOperationType.BvbDeploy;
			return false;
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x001DFDA4 File Offset: 0x001DDFA4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BvbDeploy",
				"BvbEvolution",
				"BvbChangeHandCard",
				"BvbChangeBoardCard",
				"BvbRecycleHandCard",
				"BvbRecycleBoardCard",
				"BvbEndTurn",
				"BvbUseItemCardSkill",
				"BvbUseFieldCardSkill",
				"BvbSelectCard"
			};
		}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x001DFE09 File Offset: 0x001DE009
		public static EBvbPlayerOperationType[] GetValues()
		{
			return new EBvbPlayerOperationType[]
			{
				EBvbPlayerOperationType.BvbDeploy,
				EBvbPlayerOperationType.BvbEvolution,
				EBvbPlayerOperationType.BvbChangeHandCard,
				EBvbPlayerOperationType.BvbChangeBoardCard,
				EBvbPlayerOperationType.BvbRecycleHandCard,
				EBvbPlayerOperationType.BvbRecycleBoardCard,
				EBvbPlayerOperationType.BvbEndTurn,
				EBvbPlayerOperationType.BvbUseItemCardSkill,
				EBvbPlayerOperationType.BvbUseFieldCardSkill,
				EBvbPlayerOperationType.BvbSelectCard
			};
		}

		// Token: 0x0600CED2 RID: 52946 RVA: 0x001DFE20 File Offset: 0x001DE020
		public static string[] GetNames()
		{
			return new string[]
			{
				"BvbDeploy",
				"BvbEvolution",
				"BvbChangeHandCard",
				"BvbChangeBoardCard",
				"BvbRecycleHandCard",
				"BvbRecycleBoardCard",
				"BvbEndTurn",
				"BvbUseItemCardSkill",
				"BvbUseFieldCardSkill",
				"BvbSelectCard"
			};
		}
	}
}
