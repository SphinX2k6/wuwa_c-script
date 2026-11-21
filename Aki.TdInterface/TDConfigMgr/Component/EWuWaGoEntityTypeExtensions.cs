using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0F RID: 2831
	public static class EWuWaGoEntityTypeExtensions
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x0009E148 File Offset: 0x0009C348
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

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0009E1E4 File Offset: 0x0009C3E4
		public static EWuWaGoEntityType FromString(string name)
		{
			EWuWaGoEntityType result;
			if (!EWuWaGoEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x0009E210 File Offset: 0x0009C410
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

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0009E38C File Offset: 0x0009C58C
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

		// Token: 0x06003DDA RID: 15834 RVA: 0x0009E3F1 File Offset: 0x0009C5F1
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

		// Token: 0x06003DDB RID: 15835 RVA: 0x0009E408 File Offset: 0x0009C608
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
