using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A19 RID: 2585
	public static class EHookInteractTypeExtensions
	{
		// Token: 0x06003983 RID: 14723 RVA: 0x000949D0 File Offset: 0x00092BD0
		public static string ToEnumString(this EHookInteractType value)
		{
			string result;
			switch (value)
			{
			case EHookInteractType.FixedPointHook:
				result = "FixedPointHook";
				break;
			case EHookInteractType.MovementPointHook:
				result = "MovementPointHook";
				break;
			case EHookInteractType.SuiGuangHook:
				result = "SuiGuangHook";
				break;
			case EHookInteractType.KiteHook:
				result = "KiteHook";
				break;
			case EHookInteractType.RagDollJumpingPoint:
				result = "RagDollJumpingPoint";
				break;
			case EHookInteractType.RagDollClimbingPoint:
				result = "RagDollClimbingPoint";
				break;
			case EHookInteractType.SlashHook:
				result = "SlashHook";
				break;
			case EHookInteractType.ChargeSlashHook:
				result = "ChargeSlashHook";
				break;
			case EHookInteractType.GravityHook:
				result = "GravityHook";
				break;
			case EHookInteractType.FlyingFeather:
				result = "FlyingFeather";
				break;
			case EHookInteractType.PilotThrow:
				result = "PilotThrow";
				break;
			case EHookInteractType.SunSpiritLauncher:
				result = "SunSpiritLauncher";
				break;
			case EHookInteractType.CableWay:
				result = "CableWay";
				break;
			case EHookInteractType.FollowerShoot:
				result = "FollowerShoot";
				break;
			case EHookInteractType.MotorPullInteract:
				result = "MotorPullInteract";
				break;
			case EHookInteractType.SpaceStationEnergyCore:
				result = "SpaceStationEnergyCore";
				break;
			case EHookInteractType.MotorEject:
				result = "MotorEject";
				break;
			case EHookInteractType.FoxJumpingPoint:
				result = "FoxJumpingPoint";
				break;
			case EHookInteractType.WaterBoxBigWeapon:
				result = "WaterBoxBigWeapon";
				break;
			case EHookInteractType.MechTransformHook:
				result = "MechTransformHook";
				break;
			case EHookInteractType.ChongLouHook:
				result = "ChongLouHook";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00094B08 File Offset: 0x00092D08
		public static EHookInteractType FromString(string name)
		{
			EHookInteractType result;
			if (!EHookInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00094B34 File Offset: 0x00092D34
		public static bool TryFromString(string name, out EHookInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHookInteractType.FixedPointHook;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 8:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'K')
						{
							if (name == "KiteHook")
							{
								value = EHookInteractType.KiteHook;
								return true;
							}
						}
					}
					else if (name == "CableWay")
					{
						value = EHookInteractType.CableWay;
						return true;
					}
					break;
				}
				case 9:
					if (name == "SlashHook")
					{
						value = EHookInteractType.SlashHook;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'M')
					{
						if (c == 'P')
						{
							if (name == "PilotThrow")
							{
								value = EHookInteractType.PilotThrow;
								return true;
							}
						}
					}
					else if (name == "MotorEject")
					{
						value = EHookInteractType.MotorEject;
						return true;
					}
					break;
				}
				case 11:
					if (name == "GravityHook")
					{
						value = EHookInteractType.GravityHook;
						return true;
					}
					break;
				case 12:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'S')
						{
							if (name == "SuiGuangHook")
							{
								value = EHookInteractType.SuiGuangHook;
								return true;
							}
						}
					}
					else if (name == "ChongLouHook")
					{
						value = EHookInteractType.ChongLouHook;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[1];
					if (c != 'l')
					{
						if (c == 'o')
						{
							if (name == "FollowerShoot")
							{
								value = EHookInteractType.FollowerShoot;
								return true;
							}
						}
					}
					else if (name == "FlyingFeather")
					{
						value = EHookInteractType.FlyingFeather;
						return true;
					}
					break;
				}
				case 14:
					if (name == "FixedPointHook")
					{
						value = EHookInteractType.FixedPointHook;
						return true;
					}
					break;
				case 15:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'F')
						{
							if (name == "FoxJumpingPoint")
							{
								value = EHookInteractType.FoxJumpingPoint;
								return true;
							}
						}
					}
					else if (name == "ChargeSlashHook")
					{
						value = EHookInteractType.ChargeSlashHook;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[5];
					if (c <= 'P')
					{
						if (c != 'B')
						{
							if (c == 'P')
							{
								if (name == "MotorPullInteract")
								{
									value = EHookInteractType.MotorPullInteract;
									return true;
								}
							}
						}
						else if (name == "WaterBoxBigWeapon")
						{
							value = EHookInteractType.WaterBoxBigWeapon;
							return true;
						}
					}
					else if (c != 'e')
					{
						if (c != 'i')
						{
							if (c == 'r')
							{
								if (name == "MechTransformHook")
								{
									value = EHookInteractType.MechTransformHook;
									return true;
								}
							}
						}
						else if (name == "SunSpiritLauncher")
						{
							value = EHookInteractType.SunSpiritLauncher;
							return true;
						}
					}
					else if (name == "MovementPointHook")
					{
						value = EHookInteractType.MovementPointHook;
						return true;
					}
					break;
				}
				case 19:
					if (name == "RagDollJumpingPoint")
					{
						value = EHookInteractType.RagDollJumpingPoint;
						return true;
					}
					break;
				case 20:
					if (name == "RagDollClimbingPoint")
					{
						value = EHookInteractType.RagDollClimbingPoint;
						return true;
					}
					break;
				case 22:
					if (name == "SpaceStationEnergyCore")
					{
						value = EHookInteractType.SpaceStationEnergyCore;
						return true;
					}
					break;
				}
			}
			value = EHookInteractType.FixedPointHook;
			return false;
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00094E94 File Offset: 0x00093094
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixedPointHook",
				"MovementPointHook",
				"SuiGuangHook",
				"KiteHook",
				"RagDollJumpingPoint",
				"RagDollClimbingPoint",
				"SlashHook",
				"ChargeSlashHook",
				"GravityHook",
				"FlyingFeather",
				"PilotThrow",
				"SunSpiritLauncher",
				"CableWay",
				"FollowerShoot",
				"MotorPullInteract",
				"SpaceStationEnergyCore",
				"MotorEject",
				"FoxJumpingPoint",
				"WaterBoxBigWeapon",
				"MechTransformHook",
				"ChongLouHook"
			};
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00094F5C File Offset: 0x0009315C
		public static EHookInteractType[] GetValues()
		{
			return new EHookInteractType[]
			{
				EHookInteractType.FixedPointHook,
				EHookInteractType.MovementPointHook,
				EHookInteractType.SuiGuangHook,
				EHookInteractType.KiteHook,
				EHookInteractType.RagDollJumpingPoint,
				EHookInteractType.RagDollClimbingPoint,
				EHookInteractType.SlashHook,
				EHookInteractType.ChargeSlashHook,
				EHookInteractType.GravityHook,
				EHookInteractType.FlyingFeather,
				EHookInteractType.PilotThrow,
				EHookInteractType.SunSpiritLauncher,
				EHookInteractType.CableWay,
				EHookInteractType.FollowerShoot,
				EHookInteractType.MotorPullInteract,
				EHookInteractType.SpaceStationEnergyCore,
				EHookInteractType.MotorEject,
				EHookInteractType.FoxJumpingPoint,
				EHookInteractType.WaterBoxBigWeapon,
				EHookInteractType.MechTransformHook,
				EHookInteractType.ChongLouHook
			};
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00094F70 File Offset: 0x00093170
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixedPointHook",
				"MovementPointHook",
				"SuiGuangHook",
				"KiteHook",
				"RagDollJumpingPoint",
				"RagDollClimbingPoint",
				"SlashHook",
				"ChargeSlashHook",
				"GravityHook",
				"FlyingFeather",
				"PilotThrow",
				"SunSpiritLauncher",
				"CableWay",
				"FollowerShoot",
				"MotorPullInteract",
				"SpaceStationEnergyCore",
				"MotorEject",
				"FoxJumpingPoint",
				"WaterBoxBigWeapon",
				"MechTransformHook",
				"ChongLouHook"
			};
		}
	}
}
