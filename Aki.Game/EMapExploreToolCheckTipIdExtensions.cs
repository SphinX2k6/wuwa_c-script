using System;

// Token: 0x0200354D RID: 13645
public static class EMapExploreToolCheckTipIdExtensions
{
	// Token: 0x0601DF81 RID: 122753 RVA: 0x0086608C File Offset: 0x0086428C
	public static string ToEnumString(this EMapExploreToolCheckTipId value)
	{
		string result;
		switch (value)
		{
		case EMapExploreToolCheckTipId.NotHost:
			result = "OnylHostUse";
			break;
		case EMapExploreToolCheckTipId.NotOnGround:
			result = "ExploreStateError";
			break;
		case EMapExploreToolCheckTipId.IllegalExploreToolUsingPos:
			result = "ExplorePositionError";
			break;
		case EMapExploreToolCheckTipId.InFight:
			result = "ExploreFighting";
			break;
		case EMapExploreToolCheckTipId.NotHaveCountryAccess:
			result = "ExploreUnauthorized";
			break;
		case EMapExploreToolCheckTipId.ToolActivating:
			result = "ExploreActivating";
			break;
		case EMapExploreToolCheckTipId.SoundBoxAllCollected:
			result = "ExploreShengXiaCollectAll";
			break;
		case EMapExploreToolCheckTipId.Exolore_ShengXiaNoDetect:
			result = "Exolore_ShengXiaNoDetect";
			break;
		case EMapExploreToolCheckTipId.TempTeleporterCostNotEnough:
			result = "ExploreTeleporterItemLack";
			break;
		case EMapExploreToolCheckTipId.SoundBoxDetectorCostNotEnough:
			result = "ExploreShengXiaItemLack";
			break;
		case EMapExploreToolCheckTipId.SoundBoxUseReachLimit:
			result = "ShengXiaDetectTip";
			break;
		case EMapExploreToolCheckTipId.TempTeleporterPlacementBanned:
			result = "ExploreTeleporterBan";
			break;
		case EMapExploreToolCheckTipId.AbnormalGravityCannotAddTemporary:
			result = "ErrorCode_2200054_Text";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0601DF82 RID: 122754 RVA: 0x0086614C File Offset: 0x0086434C
	public static EMapExploreToolCheckTipId FromString(string name)
	{
		EMapExploreToolCheckTipId result;
		if (!EMapExploreToolCheckTipIdExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EMapExploreToolCheckTipId 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601DF83 RID: 122755 RVA: 0x00866178 File Offset: 0x00864378
	public static bool TryFromString(string name, out EMapExploreToolCheckTipId value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = EMapExploreToolCheckTipId.NotHost;
			return false;
		}
		if (name != null)
		{
			switch (name.Length)
			{
			case 11:
				if (name == "OnylHostUse")
				{
					value = EMapExploreToolCheckTipId.NotHost;
					return true;
				}
				break;
			case 15:
				if (name == "ExploreFighting")
				{
					value = EMapExploreToolCheckTipId.InFight;
					return true;
				}
				break;
			case 17:
			{
				char c = name[7];
				if (c != 'A')
				{
					if (c != 'S')
					{
						if (c == 'a')
						{
							if (name == "ShengXiaDetectTip")
							{
								value = EMapExploreToolCheckTipId.SoundBoxUseReachLimit;
								return true;
							}
						}
					}
					else if (name == "ExploreStateError")
					{
						value = EMapExploreToolCheckTipId.NotOnGround;
						return true;
					}
				}
				else if (name == "ExploreActivating")
				{
					value = EMapExploreToolCheckTipId.ToolActivating;
					return true;
				}
				break;
			}
			case 19:
				if (name == "ExploreUnauthorized")
				{
					value = EMapExploreToolCheckTipId.NotHaveCountryAccess;
					return true;
				}
				break;
			case 20:
			{
				char c = name[7];
				if (c != 'P')
				{
					if (c == 'T')
					{
						if (name == "ExploreTeleporterBan")
						{
							value = EMapExploreToolCheckTipId.TempTeleporterPlacementBanned;
							return true;
						}
					}
				}
				else if (name == "ExplorePositionError")
				{
					value = EMapExploreToolCheckTipId.IllegalExploreToolUsingPos;
					return true;
				}
				break;
			}
			case 22:
				if (name == "ErrorCode_2200054_Text")
				{
					value = EMapExploreToolCheckTipId.AbnormalGravityCannotAddTemporary;
					return true;
				}
				break;
			case 23:
				if (name == "ExploreShengXiaItemLack")
				{
					value = EMapExploreToolCheckTipId.SoundBoxDetectorCostNotEnough;
					return true;
				}
				break;
			case 24:
				if (name == "Exolore_ShengXiaNoDetect")
				{
					value = EMapExploreToolCheckTipId.Exolore_ShengXiaNoDetect;
					return true;
				}
				break;
			case 25:
			{
				char c = name[7];
				if (c != 'S')
				{
					if (c == 'T')
					{
						if (name == "ExploreTeleporterItemLack")
						{
							value = EMapExploreToolCheckTipId.TempTeleporterCostNotEnough;
							return true;
						}
					}
				}
				else if (name == "ExploreShengXiaCollectAll")
				{
					value = EMapExploreToolCheckTipId.SoundBoxAllCollected;
					return true;
				}
				break;
			}
			}
		}
		value = EMapExploreToolCheckTipId.NotHost;
		return false;
	}

	// Token: 0x0601DF84 RID: 122756 RVA: 0x00866378 File Offset: 0x00864578
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"OnylHostUse",
			"ExploreStateError",
			"ExplorePositionError",
			"ExploreFighting",
			"ExploreUnauthorized",
			"ExploreActivating",
			"ExploreShengXiaCollectAll",
			"Exolore_ShengXiaNoDetect",
			"ExploreTeleporterItemLack",
			"ExploreShengXiaItemLack",
			"ShengXiaDetectTip",
			"ExploreTeleporterBan",
			"ErrorCode_2200054_Text"
		};
	}

	// Token: 0x0601DF85 RID: 122757 RVA: 0x008663F8 File Offset: 0x008645F8
	public static EMapExploreToolCheckTipId[] GetValues()
	{
		return new EMapExploreToolCheckTipId[]
		{
			EMapExploreToolCheckTipId.NotHost,
			EMapExploreToolCheckTipId.NotOnGround,
			EMapExploreToolCheckTipId.IllegalExploreToolUsingPos,
			EMapExploreToolCheckTipId.InFight,
			EMapExploreToolCheckTipId.NotHaveCountryAccess,
			EMapExploreToolCheckTipId.ToolActivating,
			EMapExploreToolCheckTipId.SoundBoxAllCollected,
			EMapExploreToolCheckTipId.Exolore_ShengXiaNoDetect,
			EMapExploreToolCheckTipId.TempTeleporterCostNotEnough,
			EMapExploreToolCheckTipId.SoundBoxDetectorCostNotEnough,
			EMapExploreToolCheckTipId.SoundBoxUseReachLimit,
			EMapExploreToolCheckTipId.TempTeleporterPlacementBanned,
			EMapExploreToolCheckTipId.AbnormalGravityCannotAddTemporary
		};
	}

	// Token: 0x0601DF86 RID: 122758 RVA: 0x0086640C File Offset: 0x0086460C
	public static string[] GetNames()
	{
		return new string[]
		{
			"NotHost",
			"NotOnGround",
			"IllegalExploreToolUsingPos",
			"InFight",
			"NotHaveCountryAccess",
			"ToolActivating",
			"SoundBoxAllCollected",
			"Exolore_ShengXiaNoDetect",
			"TempTeleporterCostNotEnough",
			"SoundBoxDetectorCostNotEnough",
			"SoundBoxUseReachLimit",
			"TempTeleporterPlacementBanned",
			"AbnormalGravityCannotAddTemporary"
		};
	}
}
