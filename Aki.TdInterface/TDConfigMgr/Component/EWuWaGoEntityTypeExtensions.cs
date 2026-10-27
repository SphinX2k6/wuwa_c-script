using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A46 RID: 2630
	public static class EWuWaGoEntityTypeExtensions
	{
		// Token: 0x060039EC RID: 14828 RVA: 0x00095578 File Offset: 0x00093778
		public static string ToEnumString(this EWuWaGoEntityType value)
		{
			string result;
			switch (value)
			{
			case EWuWaGoEntityType.LevelCenter:
				result = "LevelCenter";
				break;
			case EWuWaGoEntityType.MovableFloor:
				result = "MovableFloor";
				break;
			case EWuWaGoEntityType.PullRod:
				result = "PullRod";
				break;
			case EWuWaGoEntityType.PressureTrigger:
				result = "PressureTrigger";
				break;
			case EWuWaGoEntityType.Gear:
				result = "Gear";
				break;
			case EWuWaGoEntityType.SpikeTrap:
				result = "SpikeTrap";
				break;
			case EWuWaGoEntityType.BowTrap:
				result = "BowTrap";
				break;
			case EWuWaGoEntityType.SaveGrid:
				result = "SaveGrid";
				break;
			case EWuWaGoEntityType.EndGrid:
				result = "EndGrid";
				break;
			case EWuWaGoEntityType.StartGrid:
				result = "StartGrid";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00095614 File Offset: 0x00093814
		public static EWuWaGoEntityType FromString(string name)
		{
			EWuWaGoEntityType result;
			if (!EWuWaGoEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00095640 File Offset: 0x00093840
		public static bool TryFromString(string name, out EWuWaGoEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWuWaGoEntityType.LevelCenter;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Gear")
					{
						value = EWuWaGoEntityType.Gear;
						return true;
					}
					break;
				case 7:
				{
					char c = name[0];
					if (c != 'B')
					{
						if (c != 'E')
						{
							if (c == 'P')
							{
								if (name == "PullRod")
								{
									value = EWuWaGoEntityType.PullRod;
									return true;
								}
							}
						}
						else if (name == "EndGrid")
						{
							value = EWuWaGoEntityType.EndGrid;
							return true;
						}
					}
					else if (name == "BowTrap")
					{
						value = EWuWaGoEntityType.BowTrap;
						return true;
					}
					break;
				}
				case 8:
					if (name == "SaveGrid")
					{
						value = EWuWaGoEntityType.SaveGrid;
						return true;
					}
					break;
				case 9:
				{
					char c = name[1];
					if (c != 'p')
					{
						if (c == 't')
						{
							if (name == "StartGrid")
							{
								value = EWuWaGoEntityType.StartGrid;
								return true;
							}
						}
					}
					else if (name == "SpikeTrap")
					{
						value = EWuWaGoEntityType.SpikeTrap;
						return true;
					}
					break;
				}
				case 11:
					if (name == "LevelCenter")
					{
						value = EWuWaGoEntityType.LevelCenter;
						return true;
					}
					break;
				case 12:
					if (name == "MovableFloor")
					{
						value = EWuWaGoEntityType.MovableFloor;
						return true;
					}
					break;
				case 15:
					if (name == "PressureTrigger")
					{
						value = EWuWaGoEntityType.PressureTrigger;
						return true;
					}
					break;
				}
			}
			value = EWuWaGoEntityType.LevelCenter;
			return false;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x000957BC File Offset: 0x000939BC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelCenter",
				"MovableFloor",
				"PullRod",
				"PressureTrigger",
				"Gear",
				"SpikeTrap",
				"BowTrap",
				"SaveGrid",
				"EndGrid",
				"StartGrid"
			};
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00095821 File Offset: 0x00093A21
		public static EWuWaGoEntityType[] GetValues()
		{
			return new EWuWaGoEntityType[]
			{
				EWuWaGoEntityType.LevelCenter,
				EWuWaGoEntityType.MovableFloor,
				EWuWaGoEntityType.PullRod,
				EWuWaGoEntityType.PressureTrigger,
				EWuWaGoEntityType.Gear,
				EWuWaGoEntityType.SpikeTrap,
				EWuWaGoEntityType.BowTrap,
				EWuWaGoEntityType.SaveGrid,
				EWuWaGoEntityType.EndGrid,
				EWuWaGoEntityType.StartGrid
			};
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00095838 File Offset: 0x00093A38
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelCenter",
				"MovableFloor",
				"PullRod",
				"PressureTrigger",
				"Gear",
				"SpikeTrap",
				"BowTrap",
				"SaveGrid",
				"EndGrid",
				"StartGrid"
			};
		}
	}
}
