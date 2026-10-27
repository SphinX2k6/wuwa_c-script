using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D0 RID: 26320
	public static class EDropCatchCommandNameExtensions
	{
		// Token: 0x06041CFB RID: 269563 RVA: 0x00FF60A4 File Offset: 0x00FF42A4
		public static string ToEnumString(this EDropCatchCommandName value)
		{
			string result;
			switch (value)
			{
			case EDropCatchCommandName.SpawnDropItem:
				result = "SpawnDropItem";
				break;
			case EDropCatchCommandName.AddEnergy:
				result = "AddEnergy";
				break;
			case EDropCatchCommandName.FullEnergy:
				result = "FullEnergy";
				break;
			case EDropCatchCommandName.AddScore:
				result = "AddScore";
				break;
			case EDropCatchCommandName.AddTime:
				result = "AddTime";
				break;
			case EDropCatchCommandName.MoveRole:
				result = "MoveRole";
				break;
			case EDropCatchCommandName.CrazyMode:
				result = "CrazyMode";
				break;
			case EDropCatchCommandName.AddShield:
				result = "AddShield";
				break;
			case EDropCatchCommandName.ConvertDropItem:
				result = "ConvertDropItem";
				break;
			case EDropCatchCommandName.ModifyRoleSpeed:
				result = "ModifyRoleSpeed";
				break;
			case EDropCatchCommandName.ModifyDropPoolTimeInterval:
				result = "ModifyDropPoolTimeInterval";
				break;
			case EDropCatchCommandName.ModifyAddScoreRate:
				result = "ModifyAddScoreRate";
				break;
			case EDropCatchCommandName.ModifyEnergyGetRate:
				result = "ModifyEnergyGetRate";
				break;
			case EDropCatchCommandName.ShowLeftMsg:
				result = "ShowLeftMsg";
				break;
			case EDropCatchCommandName.ShowFloatEff:
				result = "ShowFloatEff";
				break;
			case EDropCatchCommandName.ChangeRoleColor:
				result = "ChangeRoleColor";
				break;
			case EDropCatchCommandName.PostAudioEvent:
				result = "PostAudioEvent";
				break;
			case EDropCatchCommandName.PlayFlow:
				result = "PlayFlow";
				break;
			case EDropCatchCommandName.SetInputEnabled:
				result = "SetInputEnabled";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06041CFC RID: 269564 RVA: 0x00FF61BC File Offset: 0x00FF43BC
		public static EDropCatchCommandName FromString(string name)
		{
			EDropCatchCommandName result;
			if (!EDropCatchCommandNameExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchCommandName 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CFD RID: 269565 RVA: 0x00FF61E8 File Offset: 0x00FF43E8
		public static bool TryFromString(string name, out EDropCatchCommandName value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchCommandName.SpawnDropItem;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 7:
					if (name == "AddTime")
					{
						value = EDropCatchCommandName.AddTime;
						return true;
					}
					break;
				case 8:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c != 'M')
						{
							if (c == 'P')
							{
								if (name == "PlayFlow")
								{
									value = EDropCatchCommandName.PlayFlow;
									return true;
								}
							}
						}
						else if (name == "MoveRole")
						{
							value = EDropCatchCommandName.MoveRole;
							return true;
						}
					}
					else if (name == "AddScore")
					{
						value = EDropCatchCommandName.AddScore;
						return true;
					}
					break;
				}
				case 9:
				{
					char c = name[3];
					if (c != 'E')
					{
						if (c != 'S')
						{
							if (c == 'z')
							{
								if (name == "CrazyMode")
								{
									value = EDropCatchCommandName.CrazyMode;
									return true;
								}
							}
						}
						else if (name == "AddShield")
						{
							value = EDropCatchCommandName.AddShield;
							return true;
						}
					}
					else if (name == "AddEnergy")
					{
						value = EDropCatchCommandName.AddEnergy;
						return true;
					}
					break;
				}
				case 10:
					if (name == "FullEnergy")
					{
						value = EDropCatchCommandName.FullEnergy;
						return true;
					}
					break;
				case 11:
					if (name == "ShowLeftMsg")
					{
						value = EDropCatchCommandName.ShowLeftMsg;
						return true;
					}
					break;
				case 12:
					if (name == "ShowFloatEff")
					{
						value = EDropCatchCommandName.ShowFloatEff;
						return true;
					}
					break;
				case 13:
					if (name == "SpawnDropItem")
					{
						value = EDropCatchCommandName.SpawnDropItem;
						return true;
					}
					break;
				case 14:
					if (name == "PostAudioEvent")
					{
						value = EDropCatchCommandName.PostAudioEvent;
						return true;
					}
					break;
				case 15:
				{
					char c = name[2];
					if (c <= 'd')
					{
						if (c != 'a')
						{
							if (c == 'd')
							{
								if (name == "ModifyRoleSpeed")
								{
									value = EDropCatchCommandName.ModifyRoleSpeed;
									return true;
								}
							}
						}
						else if (name == "ChangeRoleColor")
						{
							value = EDropCatchCommandName.ChangeRoleColor;
							return true;
						}
					}
					else if (c != 'n')
					{
						if (c == 't')
						{
							if (name == "SetInputEnabled")
							{
								value = EDropCatchCommandName.SetInputEnabled;
								return true;
							}
						}
					}
					else if (name == "ConvertDropItem")
					{
						value = EDropCatchCommandName.ConvertDropItem;
						return true;
					}
					break;
				}
				case 18:
					if (name == "ModifyAddScoreRate")
					{
						value = EDropCatchCommandName.ModifyAddScoreRate;
						return true;
					}
					break;
				case 19:
					if (name == "ModifyEnergyGetRate")
					{
						value = EDropCatchCommandName.ModifyEnergyGetRate;
						return true;
					}
					break;
				case 26:
					if (name == "ModifyDropPoolTimeInterval")
					{
						value = EDropCatchCommandName.ModifyDropPoolTimeInterval;
						return true;
					}
					break;
				}
			}
			value = EDropCatchCommandName.SpawnDropItem;
			return false;
		}

		// Token: 0x06041CFE RID: 269566 RVA: 0x00FF64D8 File Offset: 0x00FF46D8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpawnDropItem",
				"AddEnergy",
				"FullEnergy",
				"AddScore",
				"AddTime",
				"MoveRole",
				"CrazyMode",
				"AddShield",
				"ConvertDropItem",
				"ModifyRoleSpeed",
				"ModifyDropPoolTimeInterval",
				"ModifyAddScoreRate",
				"ModifyEnergyGetRate",
				"ShowLeftMsg",
				"ShowFloatEff",
				"ChangeRoleColor",
				"PostAudioEvent",
				"PlayFlow",
				"SetInputEnabled"
			};
		}

		// Token: 0x06041CFF RID: 269567 RVA: 0x00FF658E File Offset: 0x00FF478E
		public static EDropCatchCommandName[] GetValues()
		{
			return new EDropCatchCommandName[]
			{
				EDropCatchCommandName.SpawnDropItem,
				EDropCatchCommandName.AddEnergy,
				EDropCatchCommandName.FullEnergy,
				EDropCatchCommandName.AddScore,
				EDropCatchCommandName.AddTime,
				EDropCatchCommandName.MoveRole,
				EDropCatchCommandName.CrazyMode,
				EDropCatchCommandName.AddShield,
				EDropCatchCommandName.ConvertDropItem,
				EDropCatchCommandName.ModifyRoleSpeed,
				EDropCatchCommandName.ModifyDropPoolTimeInterval,
				EDropCatchCommandName.ModifyAddScoreRate,
				EDropCatchCommandName.ModifyEnergyGetRate,
				EDropCatchCommandName.ShowLeftMsg,
				EDropCatchCommandName.ShowFloatEff,
				EDropCatchCommandName.ChangeRoleColor,
				EDropCatchCommandName.PostAudioEvent,
				EDropCatchCommandName.PlayFlow,
				EDropCatchCommandName.SetInputEnabled
			};
		}

		// Token: 0x06041D00 RID: 269568 RVA: 0x00FF65A4 File Offset: 0x00FF47A4
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpawnDropItem",
				"AddEnergy",
				"FullEnergy",
				"AddScore",
				"AddTime",
				"MoveRole",
				"CrazyMode",
				"AddShield",
				"ConvertDropItem",
				"ModifyRoleSpeed",
				"ModifyDropPoolTimeInterval",
				"ModifyAddScoreRate",
				"ModifyEnergyGetRate",
				"ShowLeftMsg",
				"ShowFloatEff",
				"ChangeRoleColor",
				"PostAudioEvent",
				"PlayFlow",
				"SetInputEnabled"
			};
		}
	}
}
