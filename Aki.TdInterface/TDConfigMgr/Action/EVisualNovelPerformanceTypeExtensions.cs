using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B1 RID: 9393
	public static class EVisualNovelPerformanceTypeExtensions
	{
		// Token: 0x0600CB9B RID: 52123 RVA: 0x001DF740 File Offset: 0x001DD940
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
			case EVisualNovelPerformanceType.UiShake:
				result = "UiShake";
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

		// Token: 0x0600CB9C RID: 52124 RVA: 0x001DF83C File Offset: 0x001DDA3C
		public static EVisualNovelPerformanceType FromString(string name)
		{
			EVisualNovelPerformanceType result;
			if (!EVisualNovelPerformanceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelPerformanceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x001DF868 File Offset: 0x001DDA68
		public static bool TryFromString(string name, out EVisualNovelPerformanceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelPerformanceType.Enter;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
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
					if (name == "UiShake")
					{
						value = EVisualNovelPerformanceType.UiShake;
						return true;
					}
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
				case 14:
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
					break;
				}
				case 16:
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
					break;
				}
				}
			}
			value = EVisualNovelPerformanceType.Enter;
			return false;
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x001DFB34 File Offset: 0x001DDD34
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enter",
				"Exit",
				"Move",
				"ModifyRole",
				"PortraitEffect",
				"UiShake",
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

		// Token: 0x0600CB9F RID: 52127 RVA: 0x001DFBD8 File Offset: 0x001DDDD8
		public static EVisualNovelPerformanceType[] GetValues()
		{
			return new EVisualNovelPerformanceType[]
			{
				EVisualNovelPerformanceType.Enter,
				EVisualNovelPerformanceType.Exit,
				EVisualNovelPerformanceType.Move,
				EVisualNovelPerformanceType.ModifyRole,
				EVisualNovelPerformanceType.PortraitEffect,
				EVisualNovelPerformanceType.UiShake,
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

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x001DFBEC File Offset: 0x001DDDEC
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enter",
				"Exit",
				"Move",
				"ModifyRole",
				"PortraitEffect",
				"UiShake",
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
