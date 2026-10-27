using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093E RID: 2366
	public static class EExploreSkillInteractTypeExtensions
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x0008B0BC File Offset: 0x000892BC
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
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0008B188 File Offset: 0x00089388
		public static EExploreSkillInteractType FromString(string name)
		{
			EExploreSkillInteractType result;
			if (!EExploreSkillInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExploreSkillInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0008B1B4 File Offset: 0x000893B4
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
					if (name == "MechascoutDrag")
					{
						value = EExploreSkillInteractType.MechascoutDrag;
						return true;
					}
					break;
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

		// Token: 0x0600354B RID: 13643 RVA: 0x0008B3DC File Offset: 0x000895DC
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
				"Eavesdrop"
			};
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0008B465 File Offset: 0x00089665
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
				EExploreSkillInteractType.Eavesdrop
			};
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0008B47C File Offset: 0x0008967C
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
				"Eavesdrop"
			};
		}
	}
}
