using System;

// Token: 0x02002AC2 RID: 10946
public static class EMapExploreToolCheckTipIdExtensions
{
	// Token: 0x0601BCA9 RID: 113833 RVA: 0x0088DBF4 File Offset: 0x0088BDF4
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

	// Token: 0x0601BCAA RID: 113834 RVA: 0x0088DCB4 File Offset: 0x0088BEB4
	public static EMapExploreToolCheckTipId FromString(string name)
	{
		EMapExploreToolCheckTipId result;
		if (!EMapExploreToolCheckTipIdExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EMapExploreToolCheckTipId 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCAB RID: 113835 RVA: 0x0088DCE0 File Offset: 0x0088BEE0
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

	// Token: 0x0601BCAC RID: 113836 RVA: 0x0088DEE0 File Offset: 0x0088C0E0
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

	// Token: 0x0601BCAD RID: 113837 RVA: 0x0088DF60 File Offset: 0x0088C160
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

	// Token: 0x0601BCAE RID: 113838 RVA: 0x0088DF74 File Offset: 0x0088C174
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
