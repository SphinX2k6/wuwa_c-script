using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002754 RID: 10068
	public static class EVisualNovelPerformanceTypeExtensions
	{
		// Token: 0x0600D854 RID: 55380 RVA: 0x001F9940 File Offset: 0x001F7B40
		public static string ToEnumString(this EVisualNovelPerformanceType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelPerformanceType.Enter:
				result = "Enter";
				break;
			case EVisualNovelPerformanceType.Exit:
				result = "Exit";
				break;
			case EVisualNovelPerformanceType.Move:
				result = "Move";
				break;
			case EVisualNovelPerformanceType.ModifyRole:
				result = "ModifyRole";
				break;
			case EVisualNovelPerformanceType.PortraitEffect:
				result = "PortraitEffect";
				break;
			case EVisualNovelPerformanceType.BackgroundMove:
				result = "BackgroundMove";
				break;
			case EVisualNovelPerformanceType.CgMove:
				result = "CgMove";
				break;
			case EVisualNovelPerformanceType.EnterBlackScreen:
				result = "EnterBlackScreen";
				break;
			case EVisualNovelPerformanceType.LeaveBlackScreen:
				result = "LeaveBlackScreen";
				break;
			case EVisualNovelPerformanceType.PlayScreenEffect:
				result = "PlayScreenEffect";
				break;
			case EVisualNovelPerformanceType.StopScreenEffect:
				result = "StopScreenEffect";
				break;
			case EVisualNovelPerformanceType.SendAudioEvent:
				result = "SendAudioEvent";
				break;
			case EVisualNovelPerformanceType.SwitchAudioState:
				result = "SwitchAudioState";
				break;
			case EVisualNovelPerformanceType.Transition:
				result = "Transition";
				break;
			case EVisualNovelPerformanceType.RoleIntroduction:
				result = "RoleIntroduction";
				break;
			case EVisualNovelPerformanceType.ActivityAction:
				result = "ActivityAction";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x001F9A2C File Offset: 0x001F7C2C
		public static EVisualNovelPerformanceType FromString(string name)
		{
			EVisualNovelPerformanceType result;
			if (!EVisualNovelPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D856 RID: 55382 RVA: 0x001F9A58 File Offset: 0x001F7C58
		public static bool TryFromString(string name, out EVisualNovelPerformanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelPerformanceType.Enter;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 4:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c == 'M')
						{
							if (name == "Move")
							{
								value = EVisualNovelPerformanceType.Move;
								return true;
							}
						}
					}
					else if (name == "Exit")
					{
						value = EVisualNovelPerformanceType.Exit;
						return true;
					}
					break;
				}
				case 5:
					if (name == "Enter")
					{
						value = EVisualNovelPerformanceType.Enter;
						return true;
					}
					break;
				case 6:
					if (name == "CgMove")
					{
						value = EVisualNovelPerformanceType.CgMove;
						return true;
					}
					break;
				case 7:
				case 8:
				case 9:
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'M')
					{
						if (c == 'T')
						{
							if (name == "Transition")
							{
								value = EVisualNovelPerformanceType.Transition;
								return true;
							}
						}
					}
					else if (name == "ModifyRole")
					{
						value = EVisualNovelPerformanceType.ModifyRole;
						return true;
					}
					break;
				}
				default:
					if (length != 14)
					{
						if (length == 16)
						{
							char c = name[1];
							if (c <= 'o')
							{
								if (c != 'e')
								{
									switch (c)
									{
									case 'l':
										if (name == "PlayScreenEffect")
										{
											value = EVisualNovelPerformanceType.PlayScreenEffect;
											return true;
										}
										break;
									case 'n':
										if (name == "EnterBlackScreen")
										{
											value = EVisualNovelPerformanceType.EnterBlackScreen;
											return true;
										}
										break;
									case 'o':
										if (name == "RoleIntroduction")
										{
											value = EVisualNovelPerformanceType.RoleIntroduction;
											return true;
										}
										break;
									}
								}
								else if (name == "LeaveBlackScreen")
								{
									value = EVisualNovelPerformanceType.LeaveBlackScreen;
									return true;
								}
							}
							else if (c != 't')
							{
								if (c == 'w')
								{
									if (name == "SwitchAudioState")
									{
										value = EVisualNovelPerformanceType.SwitchAudioState;
										return true;
									}
								}
							}
							else if (name == "StopScreenEffect")
							{
								value = EVisualNovelPerformanceType.StopScreenEffect;
								return true;
							}
						}
					}
					else
					{
						char c = name[0];
						if (c <= 'B')
						{
							if (c != 'A')
							{
								if (c == 'B')
								{
									if (name == "BackgroundMove")
									{
										value = EVisualNovelPerformanceType.BackgroundMove;
										return true;
									}
								}
							}
							else if (name == "ActivityAction")
							{
								value = EVisualNovelPerformanceType.ActivityAction;
								return true;
							}
						}
						else if (c != 'P')
						{
							if (c == 'S')
							{
								if (name == "SendAudioEvent")
								{
									value = EVisualNovelPerformanceType.SendAudioEvent;
									return true;
								}
							}
						}
						else if (name == "PortraitEffect")
						{
							value = EVisualNovelPerformanceType.PortraitEffect;
							return true;
						}
					}
					break;
				}
			}
			value = EVisualNovelPerformanceType.Enter;
			return false;
		}

		// Token: 0x0600D857 RID: 55383 RVA: 0x001F9CFC File Offset: 0x001F7EFC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enter",
				"Exit",
				"Move",
				"ModifyRole",
				"PortraitEffect",
				"BackgroundMove",
				"CgMove",
				"EnterBlackScreen",
				"LeaveBlackScreen",
				"PlayScreenEffect",
				"StopScreenEffect",
				"SendAudioEvent",
				"SwitchAudioState",
				"Transition",
				"RoleIntroduction",
				"ActivityAction"
			};
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x001F9D97 File Offset: 0x001F7F97
		public static EVisualNovelPerformanceType[] GetValues()
		{
			return new EVisualNovelPerformanceType[]
			{
				EVisualNovelPerformanceType.Enter,
				EVisualNovelPerformanceType.Exit,
				EVisualNovelPerformanceType.Move,
				EVisualNovelPerformanceType.ModifyRole,
				EVisualNovelPerformanceType.PortraitEffect,
				EVisualNovelPerformanceType.BackgroundMove,
				EVisualNovelPerformanceType.CgMove,
				EVisualNovelPerformanceType.EnterBlackScreen,
				EVisualNovelPerformanceType.LeaveBlackScreen,
				EVisualNovelPerformanceType.PlayScreenEffect,
				EVisualNovelPerformanceType.StopScreenEffect,
				EVisualNovelPerformanceType.SendAudioEvent,
				EVisualNovelPerformanceType.SwitchAudioState,
				EVisualNovelPerformanceType.Transition,
				EVisualNovelPerformanceType.RoleIntroduction,
				EVisualNovelPerformanceType.ActivityAction
			};
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x001F9DAC File Offset: 0x001F7FAC
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enter",
				"Exit",
				"Move",
				"ModifyRole",
				"PortraitEffect",
				"BackgroundMove",
				"CgMove",
				"EnterBlackScreen",
				"LeaveBlackScreen",
				"PlayScreenEffect",
				"StopScreenEffect",
				"SendAudioEvent",
				"SwitchAudioState",
				"Transition",
				"RoleIntroduction",
				"ActivityAction"
			};
		}
	}
}
