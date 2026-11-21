using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002702 RID: 9986
	public static class ETargetVehicleExtensions
	{
		// Token: 0x0600D6E3 RID: 55011 RVA: 0x001F60D4 File Offset: 0x001F42D4
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

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x001F614C File Offset: 0x001F434C
		public static ETargetVehicle FromString(string name)
		{
			ETargetVehicle result;
			if (!ETargetVehicleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetVehicle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x001F6178 File Offset: 0x001F4378
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

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x001F6287 File Offset: 0x001F4487
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

		// Token: 0x0600D6E7 RID: 55015 RVA: 0x001F62C7 File Offset: 0x001F44C7
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

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x001F62DA File Offset: 0x001F44DA
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
