using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002461 RID: 9313
	public static class ETargetVehicleExtensions
	{
		// Token: 0x0600CA33 RID: 51763 RVA: 0x001DC020 File Offset: 0x001DA220
		public static string ToEnumString(this ETargetVehicle value)
		{
			string result;
			switch (value)
			{
			case ETargetVehicle.Current:
				result = "Current";
				break;
			case ETargetVehicle.Self:
				result = "Self";
				break;
			case ETargetVehicle.Appointed:
				result = "Appointed";
				break;
			case ETargetVehicle.Triggered:
				result = "Triggered";
				break;
			case ETargetVehicle.FishingBoat:
				result = "FishingBoat";
				break;
			case ETargetVehicle.VehicleTeam:
				result = "VehicleTeam";
				break;
			case ETargetVehicle.PlayerMotor:
				result = "PlayerMotor";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x001DC098 File Offset: 0x001DA298
		public static ETargetVehicle FromString(string name)
		{
			ETargetVehicle result;
			if (!ETargetVehicleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetVehicle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA35 RID: 51765 RVA: 0x001DC0C4 File Offset: 0x001DA2C4
		public static bool TryFromString(string name, out ETargetVehicle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETargetVehicle.Current;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 4)
				{
					switch (length)
					{
					case 7:
						if (name == "Current")
						{
							value = ETargetVehicle.Current;
							return true;
						}
						break;
					case 9:
					{
						char c = name[0];
						if (c != 'A')
						{
							if (c == 'T')
							{
								if (name == "Triggered")
								{
									value = ETargetVehicle.Triggered;
									return true;
								}
							}
						}
						else if (name == "Appointed")
						{
							value = ETargetVehicle.Appointed;
							return true;
						}
						break;
					}
					case 11:
					{
						char c = name[0];
						if (c != 'F')
						{
							if (c != 'P')
							{
								if (c == 'V')
								{
									if (name == "VehicleTeam")
									{
										value = ETargetVehicle.VehicleTeam;
										return true;
									}
								}
							}
							else if (name == "PlayerMotor")
							{
								value = ETargetVehicle.PlayerMotor;
								return true;
							}
						}
						else if (name == "FishingBoat")
						{
							value = ETargetVehicle.FishingBoat;
							return true;
						}
						break;
					}
					}
				}
				else if (name == "Self")
				{
					value = ETargetVehicle.Self;
					return true;
				}
			}
			value = ETargetVehicle.Current;
			return false;
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x001DC1D3 File Offset: 0x001DA3D3
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Current",
				"Self",
				"Appointed",
				"Triggered",
				"FishingBoat",
				"VehicleTeam",
				"PlayerMotor"
			};
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x001DC213 File Offset: 0x001DA413
		public static ETargetVehicle[] GetValues()
		{
			return new ETargetVehicle[]
			{
				ETargetVehicle.Current,
				ETargetVehicle.Self,
				ETargetVehicle.Appointed,
				ETargetVehicle.Triggered,
				ETargetVehicle.FishingBoat,
				ETargetVehicle.VehicleTeam,
				ETargetVehicle.PlayerMotor
			};
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x001DC226 File Offset: 0x001DA426
		public static string[] GetNames()
		{
			return new string[]
			{
				"Current",
				"Self",
				"Appointed",
				"Triggered",
				"FishingBoat",
				"VehicleTeam",
				"PlayerMotor"
			};
		}
	}
}
