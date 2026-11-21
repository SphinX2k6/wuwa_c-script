using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EB RID: 2539
	public static class EExploreSkillInteractTypeExtensions
	{
		// Token: 0x060038B4 RID: 14516 RVA: 0x00092C3C File Offset: 0x00090E3C
		public static string ToEnumString(this EExploreSkillInteractType value)
		{
			string result;
			switch (value)
			{
			case EExploreSkillInteractType.PullGiant:
				result = "PullGiant";
				break;
			case EExploreSkillInteractType.StatueInteractPoint:
				result = "StatueInteractPoint";
				break;
			case EExploreSkillInteractType.PullStatue:
				result = "PullStatue";
				break;
			case EExploreSkillInteractType.RagDollCrushingRock:
				result = "RagDollCrushingRock";
				break;
			case EExploreSkillInteractType.RagDollDestroySolidRock:
				result = "RagDollDestroySolidRock";
				break;
			case EExploreSkillInteractType.LonelyDollPollutant:
				result = "LonelyDollPollutant";
				break;
			case EExploreSkillInteractType.QuantumDiffusion:
				result = "QuantumDiffusion";
				break;
			case EExploreSkillInteractType.Custom:
				result = "Custom";
				break;
			case EExploreSkillInteractType.MechascoutDrag:
				result = "MechascoutDrag";
				break;
			case EExploreSkillInteractType.ArrowInteractPoint:
				result = "ArrowInteractPoint";
				break;
			case EExploreSkillInteractType.FollowShooterInteractPoint:
				result = "FollowShooterInteractPoint";
				break;
			case EExploreSkillInteractType.FoxJumpInteractPoint:
				result = "FoxJumpInteractPoint";
				break;
			case EExploreSkillInteractType.MonsterSummonInteractPoint:
				result = "MonsterSummonInteractPoint";
				break;
			case EExploreSkillInteractType.Eavesdrop:
				result = "Eavesdrop";
				break;
			case EExploreSkillInteractType.GraffitiPuzzle:
				result = "GraffitiPuzzle";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00092D14 File Offset: 0x00090F14
		public static EExploreSkillInteractType FromString(string name)
		{
			EExploreSkillInteractType result;
			if (!EExploreSkillInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreSkillInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00092D40 File Offset: 0x00090F40
		public static bool TryFromString(string name, out EExploreSkillInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExploreSkillInteractType.PullGiant;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 6:
					if (name == "Custom")
					{
						value = EExploreSkillInteractType.Custom;
						return true;
					}
					break;
				case 7:
				case 8:
				case 11:
				case 12:
				case 13:
				case 15:
				case 17:
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c == 'P')
						{
							if (name == "PullGiant")
							{
								value = EExploreSkillInteractType.PullGiant;
								return true;
							}
						}
					}
					else if (name == "Eavesdrop")
					{
						value = EExploreSkillInteractType.Eavesdrop;
						return true;
					}
					break;
				}
				case 10:
					if (name == "PullStatue")
					{
						value = EExploreSkillInteractType.PullStatue;
						return true;
					}
					break;
				case 14:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'M')
						{
							if (name == "MechascoutDrag")
							{
								value = EExploreSkillInteractType.MechascoutDrag;
								return true;
							}
						}
					}
					else if (name == "GraffitiPuzzle")
					{
						value = EExploreSkillInteractType.GraffitiPuzzle;
						return true;
					}
					break;
				}
				case 16:
					if (name == "QuantumDiffusion")
					{
						value = EExploreSkillInteractType.QuantumDiffusion;
						return true;
					}
					break;
				case 18:
					if (name == "ArrowInteractPoint")
					{
						value = EExploreSkillInteractType.ArrowInteractPoint;
						return true;
					}
					break;
				case 19:
				{
					char c = name[0];
					if (c != 'L')
					{
						if (c != 'R')
						{
							if (c == 'S')
							{
								if (name == "StatueInteractPoint")
								{
									value = EExploreSkillInteractType.StatueInteractPoint;
									return true;
								}
							}
						}
						else if (name == "RagDollCrushingRock")
						{
							value = EExploreSkillInteractType.RagDollCrushingRock;
							return true;
						}
					}
					else if (name == "LonelyDollPollutant")
					{
						value = EExploreSkillInteractType.LonelyDollPollutant;
						return true;
					}
					break;
				}
				case 20:
					if (name == "FoxJumpInteractPoint")
					{
						value = EExploreSkillInteractType.FoxJumpInteractPoint;
						return true;
					}
					break;
				default:
					if (length != 23)
					{
						if (length == 26)
						{
							char c = name[0];
							if (c != 'F')
							{
								if (c == 'M')
								{
									if (name == "MonsterSummonInteractPoint")
									{
										value = EExploreSkillInteractType.MonsterSummonInteractPoint;
										return true;
									}
								}
							}
							else if (name == "FollowShooterInteractPoint")
							{
								value = EExploreSkillInteractType.FollowShooterInteractPoint;
								return true;
							}
						}
					}
					else if (name == "RagDollDestroySolidRock")
					{
						value = EExploreSkillInteractType.RagDollDestroySolidRock;
						return true;
					}
					break;
				}
			}
			value = EExploreSkillInteractType.PullGiant;
			return false;
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00092FA8 File Offset: 0x000911A8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PullGiant",
				"StatueInteractPoint",
				"PullStatue",
				"RagDollCrushingRock",
				"RagDollDestroySolidRock",
				"LonelyDollPollutant",
				"QuantumDiffusion",
				"Custom",
				"MechascoutDrag",
				"ArrowInteractPoint",
				"FollowShooterInteractPoint",
				"FoxJumpInteractPoint",
				"MonsterSummonInteractPoint",
				"Eavesdrop",
				"GraffitiPuzzle"
			};
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0009303A File Offset: 0x0009123A
		public static EExploreSkillInteractType[] GetValues()
		{
			return new EExploreSkillInteractType[]
			{
				EExploreSkillInteractType.PullGiant,
				EExploreSkillInteractType.StatueInteractPoint,
				EExploreSkillInteractType.PullStatue,
				EExploreSkillInteractType.RagDollCrushingRock,
				EExploreSkillInteractType.RagDollDestroySolidRock,
				EExploreSkillInteractType.LonelyDollPollutant,
				EExploreSkillInteractType.QuantumDiffusion,
				EExploreSkillInteractType.Custom,
				EExploreSkillInteractType.MechascoutDrag,
				EExploreSkillInteractType.ArrowInteractPoint,
				EExploreSkillInteractType.FollowShooterInteractPoint,
				EExploreSkillInteractType.FoxJumpInteractPoint,
				EExploreSkillInteractType.MonsterSummonInteractPoint,
				EExploreSkillInteractType.Eavesdrop,
				EExploreSkillInteractType.GraffitiPuzzle
			};
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00093050 File Offset: 0x00091250
		public static string[] GetNames()
		{
			return new string[]
			{
				"PullGiant",
				"StatueInteractPoint",
				"PullStatue",
				"RagDollCrushingRock",
				"RagDollDestroySolidRock",
				"LonelyDollPollutant",
				"QuantumDiffusion",
				"Custom",
				"MechascoutDrag",
				"ArrowInteractPoint",
				"FollowShooterInteractPoint",
				"FoxJumpInteractPoint",
				"MonsterSummonInteractPoint",
				"Eavesdrop",
				"GraffitiPuzzle"
			};
		}
	}
}
