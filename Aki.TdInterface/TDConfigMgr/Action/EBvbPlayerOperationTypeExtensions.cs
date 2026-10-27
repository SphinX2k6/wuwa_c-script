using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C7 RID: 8903
	public static class EBvbPlayerOperationTypeExtensions
	{
		// Token: 0x0600C2FE RID: 49918 RVA: 0x001C7D60 File Offset: 0x001C5F60
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

		// Token: 0x0600C2FF RID: 49919 RVA: 0x001C7DFC File Offset: 0x001C5FFC
		public static EBvbPlayerOperationType FromString(string name)
		{
			EBvbPlayerOperationType result;
			if (!EBvbPlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBvbPlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x001C7E28 File Offset: 0x001C6028
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

		// Token: 0x0600C301 RID: 49921 RVA: 0x001C7F9C File Offset: 0x001C619C
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

		// Token: 0x0600C302 RID: 49922 RVA: 0x001C8001 File Offset: 0x001C6201
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

		// Token: 0x0600C303 RID: 49923 RVA: 0x001C8018 File Offset: 0x001C6218
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
