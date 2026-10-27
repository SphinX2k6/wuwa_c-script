using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CD RID: 25805
	public static class EMatchThreeResourceIdExtensions
	{
		// Token: 0x06040C2E RID: 265262 RVA: 0x00FAE10C File Offset: 0x00FAC30C
		public static string ToEnumString(this EMatchThreeResourceId value)
		{
			string result;
			switch (value)
			{
			case EMatchThreeResourceId.TileNormal:
				result = "UiItem_TileNor";
				break;
			case EMatchThreeResourceId.TileUltimate:
				result = "UiItem_TileUltimate";
				break;
			case EMatchThreeResourceId.TileHourglass:
				result = "UiItem_TileSandglass";
				break;
			case EMatchThreeResourceId.TileCharger:
				result = "UiItem_TileAbsorb";
				break;
			case EMatchThreeResourceId.TileIce:
				result = "UiItem_TileIce";
				break;
			case EMatchThreeResourceId.AdditionBomb:
				result = "UiItem_ItemArrowX";
				break;
			case EMatchThreeResourceId.AdditionCrossClear:
				result = "UiItem_ItemArrowCross";
				break;
			case EMatchThreeResourceId.AdditionChain:
				result = "UiItem_ItemSkillChain";
				break;
			case EMatchThreeResourceId.UltimateTrail:
				result = "UiItem_ItemEffectUltimate";
				break;
			case EMatchThreeResourceId.EnergyTrail:
				result = "UiItem_ItemEffectRemove";
				break;
			case EMatchThreeResourceId.AllureTrail:
				result = "UiItem_ItemEffectXin";
				break;
			case EMatchThreeResourceId.ChainTrail:
				result = "UiItem_ItemEffectChain";
				break;
			case EMatchThreeResourceId.ChainDetonationTrail:
				result = "UiItem_ItemEffectChain_2";
				break;
			case EMatchThreeResourceId.MechanicTrail:
				result = "UiItem_ItemEffectProp";
				break;
			case EMatchThreeResourceId.RecycleChargerTrail:
				result = "UiItem_ItemEffectAbsorb";
				break;
			case EMatchThreeResourceId.RecycleHourglassTrail:
				result = "UiItem_ItemEffectSandglass";
				break;
			case EMatchThreeResourceId.SkillTrailCurveX:
				result = "Cure_CharacterX";
				break;
			case EMatchThreeResourceId.SkillTrailCurveY:
				result = "Cure_CharacterY";
				break;
			case EMatchThreeResourceId.SkillTrailCurveX2:
				result = "Cure_CharacterX_2";
				break;
			case EMatchThreeResourceId.SkillTrailCurveY2:
				result = "Cure_CharacterY_2";
				break;
			case EMatchThreeResourceId.ChainSkillTrailCurve:
				result = "Cure_Xian";
				break;
			case EMatchThreeResourceId.EnergyTrailCurveX:
				result = "Cure_energyX";
				break;
			case EMatchThreeResourceId.EnergyTrailCurveY:
				result = "Cure_energyY";
				break;
			case EMatchThreeResourceId.MechanicTrailCurveX:
				result = "Cure_ItemX";
				break;
			case EMatchThreeResourceId.MechanicTrailCurveY:
				result = "Cure_ItemY";
				break;
			case EMatchThreeResourceId.FallCurve:
				result = "Cure_Array";
				break;
			case EMatchThreeResourceId.EnvTips:
				result = "UiItem_GamePlayTipsEnv";
				break;
			case EMatchThreeResourceId.SkillTips:
				result = "UiItem_GamePlayTipsSkill";
				break;
			case EMatchThreeResourceId.ScorePop:
				result = "UiItem_GamePlayScore";
				break;
			case EMatchThreeResourceId.GradePop:
				result = "UiItem_GamePlayGrade";
				break;
			case EMatchThreeResourceId.IconTileUltimate:
				result = "SP_IconTileUltimate";
				break;
			case EMatchThreeResourceId.IconTileHourglass:
				result = "SP_IconTileSandglass";
				break;
			case EMatchThreeResourceId.IconTileCharger:
				result = "SP_IconTileAbsorb";
				break;
			case EMatchThreeResourceId.IconTileIce:
				result = "SP_IconIce";
				break;
			case EMatchThreeResourceId.IconTileRed:
				result = "SP_IconTile1";
				break;
			case EMatchThreeResourceId.IconTileYellow:
				result = "SP_IconTile2";
				break;
			case EMatchThreeResourceId.IconTileBlue:
				result = "SP_IconTile3";
				break;
			case EMatchThreeResourceId.IconTileGreen:
				result = "SP_IconTile4";
				break;
			case EMatchThreeResourceId.IconTilePurple:
				result = "SP_IconTile5";
				break;
			case EMatchThreeResourceId.IconScore:
				result = "SP_PointsIcon";
				break;
			case EMatchThreeResourceId.ProgressBgNormal:
				result = "SP_ProgressBarBgNor";
				break;
			case EMatchThreeResourceId.ProgressBgEndless:
				result = "SP_ProgressBarBgSP";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06040C2F RID: 265263 RVA: 0x00FAE37C File Offset: 0x00FAC57C
		public static EMatchThreeResourceId FromString(string name)
		{
			EMatchThreeResourceId result;
			if (!EMatchThreeResourceIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMatchThreeResourceId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06040C30 RID: 265264 RVA: 0x00FAE3A8 File Offset: 0x00FAC5A8
		public static bool TryFromString(string name, out EMatchThreeResourceId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMatchThreeResourceId.TileNormal;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 9:
					if (name == "Cure_Xian")
					{
						value = EMatchThreeResourceId.ChainSkillTrailCurve;
						return true;
					}
					break;
				case 10:
				{
					char c = name[9];
					if (c <= 'Y')
					{
						if (c != 'X')
						{
							if (c == 'Y')
							{
								if (name == "Cure_ItemY")
								{
									value = EMatchThreeResourceId.MechanicTrailCurveY;
									return true;
								}
							}
						}
						else if (name == "Cure_ItemX")
						{
							value = EMatchThreeResourceId.MechanicTrailCurveX;
							return true;
						}
					}
					else if (c != 'e')
					{
						if (c == 'y')
						{
							if (name == "Cure_Array")
							{
								value = EMatchThreeResourceId.FallCurve;
								return true;
							}
						}
					}
					else if (name == "SP_IconIce")
					{
						value = EMatchThreeResourceId.IconTileIce;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[11];
					switch (c)
					{
					case '1':
						if (name == "SP_IconTile1")
						{
							value = EMatchThreeResourceId.IconTileRed;
							return true;
						}
						break;
					case '2':
						if (name == "SP_IconTile2")
						{
							value = EMatchThreeResourceId.IconTileYellow;
							return true;
						}
						break;
					case '3':
						if (name == "SP_IconTile3")
						{
							value = EMatchThreeResourceId.IconTileBlue;
							return true;
						}
						break;
					case '4':
						if (name == "SP_IconTile4")
						{
							value = EMatchThreeResourceId.IconTileGreen;
							return true;
						}
						break;
					case '5':
						if (name == "SP_IconTile5")
						{
							value = EMatchThreeResourceId.IconTilePurple;
							return true;
						}
						break;
					default:
						if (c != 'X')
						{
							if (c == 'Y')
							{
								if (name == "Cure_energyY")
								{
									value = EMatchThreeResourceId.EnergyTrailCurveY;
									return true;
								}
							}
						}
						else if (name == "Cure_energyX")
						{
							value = EMatchThreeResourceId.EnergyTrailCurveX;
							return true;
						}
						break;
					}
					break;
				}
				case 13:
					if (name == "SP_PointsIcon")
					{
						value = EMatchThreeResourceId.IconScore;
						return true;
					}
					break;
				case 14:
				{
					char c = name[11];
					if (c != 'I')
					{
						if (c == 'N')
						{
							if (name == "UiItem_TileNor")
							{
								value = EMatchThreeResourceId.TileNormal;
								return true;
							}
						}
					}
					else if (name == "UiItem_TileIce")
					{
						value = EMatchThreeResourceId.TileIce;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[14];
					if (c != 'X')
					{
						if (c == 'Y')
						{
							if (name == "Cure_CharacterY")
							{
								value = EMatchThreeResourceId.SkillTrailCurveY;
								return true;
							}
						}
					}
					else if (name == "Cure_CharacterX")
					{
						value = EMatchThreeResourceId.SkillTrailCurveX;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[14];
					if (c != 'X')
					{
						if (c != 'Y')
						{
							if (c == 'o')
							{
								if (name == "UiItem_TileAbsorb")
								{
									value = EMatchThreeResourceId.TileCharger;
									return true;
								}
								if (name == "UiItem_ItemArrowX")
								{
									value = EMatchThreeResourceId.AdditionBomb;
									return true;
								}
								if (name == "SP_IconTileAbsorb")
								{
									value = EMatchThreeResourceId.IconTileCharger;
									return true;
								}
							}
						}
						else if (name == "Cure_CharacterY_2")
						{
							value = EMatchThreeResourceId.SkillTrailCurveY2;
							return true;
						}
					}
					else if (name == "Cure_CharacterX_2")
					{
						value = EMatchThreeResourceId.SkillTrailCurveX2;
						return true;
					}
					break;
				}
				case 18:
					if (name == "SP_ProgressBarBgSP")
					{
						value = EMatchThreeResourceId.ProgressBgEndless;
						return true;
					}
					break;
				case 19:
				{
					char c = name[3];
					if (c != 'I')
					{
						if (c != 'P')
						{
							if (c == 't')
							{
								if (name == "UiItem_TileUltimate")
								{
									value = EMatchThreeResourceId.TileUltimate;
									return true;
								}
							}
						}
						else if (name == "SP_ProgressBarBgNor")
						{
							value = EMatchThreeResourceId.ProgressBgNormal;
							return true;
						}
					}
					else if (name == "SP_IconTileUltimate")
					{
						value = EMatchThreeResourceId.IconTileUltimate;
						return true;
					}
					break;
				}
				case 20:
				{
					char c = name[15];
					if (c <= 'S')
					{
						if (c != 'G')
						{
							if (c == 'S')
							{
								if (name == "UiItem_GamePlayScore")
								{
									value = EMatchThreeResourceId.ScorePop;
									return true;
								}
							}
						}
						else if (name == "UiItem_GamePlayGrade")
						{
							value = EMatchThreeResourceId.GradePop;
							return true;
						}
					}
					else if (c != 'c')
					{
						if (c == 'g')
						{
							if (name == "UiItem_TileSandglass")
							{
								value = EMatchThreeResourceId.TileHourglass;
								return true;
							}
							if (name == "SP_IconTileSandglass")
							{
								value = EMatchThreeResourceId.IconTileHourglass;
								return true;
							}
						}
					}
					else if (name == "UiItem_ItemEffectXin")
					{
						value = EMatchThreeResourceId.AllureTrail;
						return true;
					}
					break;
				}
				case 21:
				{
					char c = name[11];
					if (c != 'A')
					{
						if (c != 'E')
						{
							if (c == 'S')
							{
								if (name == "UiItem_ItemSkillChain")
								{
									value = EMatchThreeResourceId.AdditionChain;
									return true;
								}
							}
						}
						else if (name == "UiItem_ItemEffectProp")
						{
							value = EMatchThreeResourceId.MechanicTrail;
							return true;
						}
					}
					else if (name == "UiItem_ItemArrowCross")
					{
						value = EMatchThreeResourceId.AdditionCrossClear;
						return true;
					}
					break;
				}
				case 22:
				{
					char c = name[7];
					if (c != 'G')
					{
						if (c == 'I')
						{
							if (name == "UiItem_ItemEffectChain")
							{
								value = EMatchThreeResourceId.ChainTrail;
								return true;
							}
						}
					}
					else if (name == "UiItem_GamePlayTipsEnv")
					{
						value = EMatchThreeResourceId.EnvTips;
						return true;
					}
					break;
				}
				case 23:
				{
					char c = name[17];
					if (c != 'A')
					{
						if (c == 'R')
						{
							if (name == "UiItem_ItemEffectRemove")
							{
								value = EMatchThreeResourceId.EnergyTrail;
								return true;
							}
						}
					}
					else if (name == "UiItem_ItemEffectAbsorb")
					{
						value = EMatchThreeResourceId.RecycleChargerTrail;
						return true;
					}
					break;
				}
				case 24:
				{
					char c = name[7];
					if (c != 'G')
					{
						if (c == 'I')
						{
							if (name == "UiItem_ItemEffectChain_2")
							{
								value = EMatchThreeResourceId.ChainDetonationTrail;
								return true;
							}
						}
					}
					else if (name == "UiItem_GamePlayTipsSkill")
					{
						value = EMatchThreeResourceId.SkillTips;
						return true;
					}
					break;
				}
				case 25:
					if (name == "UiItem_ItemEffectUltimate")
					{
						value = EMatchThreeResourceId.UltimateTrail;
						return true;
					}
					break;
				case 26:
					if (name == "UiItem_ItemEffectSandglass")
					{
						value = EMatchThreeResourceId.RecycleHourglassTrail;
						return true;
					}
					break;
				}
			}
			value = EMatchThreeResourceId.TileNormal;
			return false;
		}

		// Token: 0x06040C31 RID: 265265 RVA: 0x00FAEA30 File Offset: 0x00FACC30
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UiItem_TileNor",
				"UiItem_TileUltimate",
				"UiItem_TileSandglass",
				"UiItem_TileAbsorb",
				"UiItem_TileIce",
				"UiItem_ItemArrowX",
				"UiItem_ItemArrowCross",
				"UiItem_ItemSkillChain",
				"UiItem_ItemEffectUltimate",
				"UiItem_ItemEffectRemove",
				"UiItem_ItemEffectXin",
				"UiItem_ItemEffectChain",
				"UiItem_ItemEffectChain_2",
				"UiItem_ItemEffectProp",
				"UiItem_ItemEffectAbsorb",
				"UiItem_ItemEffectSandglass",
				"Cure_CharacterX",
				"Cure_CharacterY",
				"Cure_CharacterX_2",
				"Cure_CharacterY_2",
				"Cure_Xian",
				"Cure_energyX",
				"Cure_energyY",
				"Cure_ItemX",
				"Cure_ItemY",
				"Cure_Array",
				"UiItem_GamePlayTipsEnv",
				"UiItem_GamePlayTipsSkill",
				"UiItem_GamePlayScore",
				"UiItem_GamePlayGrade",
				"SP_IconTileUltimate",
				"SP_IconTileSandglass",
				"SP_IconTileAbsorb",
				"SP_IconIce",
				"SP_IconTile1",
				"SP_IconTile2",
				"SP_IconTile3",
				"SP_IconTile4",
				"SP_IconTile5",
				"SP_PointsIcon",
				"SP_ProgressBarBgNor",
				"SP_ProgressBarBgSP"
			};
		}

		// Token: 0x06040C32 RID: 265266 RVA: 0x00FAEBB5 File Offset: 0x00FACDB5
		public static EMatchThreeResourceId[] GetValues()
		{
			return new EMatchThreeResourceId[]
			{
				EMatchThreeResourceId.TileNormal,
				EMatchThreeResourceId.TileUltimate,
				EMatchThreeResourceId.TileHourglass,
				EMatchThreeResourceId.TileCharger,
				EMatchThreeResourceId.TileIce,
				EMatchThreeResourceId.AdditionBomb,
				EMatchThreeResourceId.AdditionCrossClear,
				EMatchThreeResourceId.AdditionChain,
				EMatchThreeResourceId.UltimateTrail,
				EMatchThreeResourceId.EnergyTrail,
				EMatchThreeResourceId.AllureTrail,
				EMatchThreeResourceId.ChainTrail,
				EMatchThreeResourceId.ChainDetonationTrail,
				EMatchThreeResourceId.MechanicTrail,
				EMatchThreeResourceId.RecycleChargerTrail,
				EMatchThreeResourceId.RecycleHourglassTrail,
				EMatchThreeResourceId.SkillTrailCurveX,
				EMatchThreeResourceId.SkillTrailCurveY,
				EMatchThreeResourceId.SkillTrailCurveX2,
				EMatchThreeResourceId.SkillTrailCurveY2,
				EMatchThreeResourceId.ChainSkillTrailCurve,
				EMatchThreeResourceId.EnergyTrailCurveX,
				EMatchThreeResourceId.EnergyTrailCurveY,
				EMatchThreeResourceId.MechanicTrailCurveX,
				EMatchThreeResourceId.MechanicTrailCurveY,
				EMatchThreeResourceId.FallCurve,
				EMatchThreeResourceId.EnvTips,
				EMatchThreeResourceId.SkillTips,
				EMatchThreeResourceId.ScorePop,
				EMatchThreeResourceId.GradePop,
				EMatchThreeResourceId.IconTileUltimate,
				EMatchThreeResourceId.IconTileHourglass,
				EMatchThreeResourceId.IconTileCharger,
				EMatchThreeResourceId.IconTileIce,
				EMatchThreeResourceId.IconTileRed,
				EMatchThreeResourceId.IconTileYellow,
				EMatchThreeResourceId.IconTileBlue,
				EMatchThreeResourceId.IconTileGreen,
				EMatchThreeResourceId.IconTilePurple,
				EMatchThreeResourceId.IconScore,
				EMatchThreeResourceId.ProgressBgNormal,
				EMatchThreeResourceId.ProgressBgEndless
			};
		}

		// Token: 0x06040C33 RID: 265267 RVA: 0x00FAEBCC File Offset: 0x00FACDCC
		public static string[] GetNames()
		{
			return new string[]
			{
				"TileNormal",
				"TileUltimate",
				"TileHourglass",
				"TileCharger",
				"TileIce",
				"AdditionBomb",
				"AdditionCrossClear",
				"AdditionChain",
				"UltimateTrail",
				"EnergyTrail",
				"AllureTrail",
				"ChainTrail",
				"ChainDetonationTrail",
				"MechanicTrail",
				"RecycleChargerTrail",
				"RecycleHourglassTrail",
				"SkillTrailCurveX",
				"SkillTrailCurveY",
				"SkillTrailCurveX2",
				"SkillTrailCurveY2",
				"ChainSkillTrailCurve",
				"EnergyTrailCurveX",
				"EnergyTrailCurveY",
				"MechanicTrailCurveX",
				"MechanicTrailCurveY",
				"FallCurve",
				"EnvTips",
				"SkillTips",
				"ScorePop",
				"GradePop",
				"IconTileUltimate",
				"IconTileHourglass",
				"IconTileCharger",
				"IconTileIce",
				"IconTileRed",
				"IconTileYellow",
				"IconTileBlue",
				"IconTileGreen",
				"IconTilePurple",
				"IconScore",
				"ProgressBgNormal",
				"ProgressBgEndless"
			};
		}
	}
}
