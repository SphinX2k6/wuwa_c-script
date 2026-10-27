using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236D RID: 9069
	public static class ELeisureInteractExtensions
	{
		// Token: 0x0600C5E9 RID: 50665 RVA: 0x001CEF2C File Offset: 0x001CD12C
		public static string ToEnumString(this ELeisureInteract value)
		{
			string result;
			switch (value)
			{
			case ELeisureInteract.CustomSkill:
				result = "CustomSkill";
				break;
			case ELeisureInteract.SitDown:
				result = "SitDown";
				break;
			case ELeisureInteract.SitOnGround:
				result = "SitOnGround";
				break;
			case ELeisureInteract.Bounce:
				result = "Bounce";
				break;
			case ELeisureInteract.Catapult:
				result = "Catapult";
				break;
			case ELeisureInteract.SuperCatapult:
				result = "SuperCatapult";
				break;
			case ELeisureInteract.MotorBounce:
				result = "MotorBounce";
				break;
			case ELeisureInteract.MotorCatapult:
				result = "MotorCatapult";
				break;
			case ELeisureInteract.Manipulate:
				result = "Manipulate";
				break;
			case ELeisureInteract.StandControl:
				result = "StandControl";
				break;
			case ELeisureInteract.StandControl2:
				result = "StandControl2";
				break;
			case ELeisureInteract.Soar:
				result = "Soar";
				break;
			case ELeisureInteract.Soar2:
				result = "Soar2";
				break;
			case ELeisureInteract.Glide:
				result = "Glide";
				break;
			case ELeisureInteract.HookLock:
				result = "HookLock";
				break;
			case ELeisureInteract.KiteHook:
				result = "KiteHook";
				break;
			case ELeisureInteract.GetUp:
				result = "GetUp";
				break;
			case ELeisureInteract.FailurePose:
				result = "FailurePose";
				break;
			case ELeisureInteract.GameplayPose1:
				result = "GameplayPose1";
				break;
			case ELeisureInteract.GameplayPose2:
				result = "GameplayPose2";
				break;
			case ELeisureInteract.GameplayPose3:
				result = "GameplayPose3";
				break;
			case ELeisureInteract.FaithJump:
				result = "FaithJump";
				break;
			case ELeisureInteract.WindProtagonistParkour1:
				result = "WindProtagonistParkour1";
				break;
			case ELeisureInteract.WindProtagonistParkour2:
				result = "WindProtagonistParkour2";
				break;
			case ELeisureInteract.WindProtagonistParkour3:
				result = "WindProtagonistParkour3";
				break;
			case ELeisureInteract.WindProtagonistParkour4:
				result = "WindProtagonistParkour4";
				break;
			case ELeisureInteract.WindProtagonistParkour5:
				result = "WindProtagonistParkour5";
				break;
			case ELeisureInteract.PainCoveringHead:
				result = "PainCoveringHead";
				break;
			case ELeisureInteract.Swing:
				result = "Swing";
				break;
			case ELeisureInteract.SwingGetUp:
				result = "SwingGetUp";
				break;
			case ELeisureInteract.MotorEnterSlide:
				result = "MotorEnterSlide";
				break;
			case ELeisureInteract.QiuyuanLongPressQinggong:
				result = "QiuyuanLongPressQinggong";
				break;
			case ELeisureInteract.QiuyuanQinggongEnd:
				result = "QiuyuanQinggongEnd";
				break;
			case ELeisureInteract.QiuyuanQinggongExploration1:
				result = "QiuyuanQinggongExploration1";
				break;
			case ELeisureInteract.QiuyuanQinggongExploration2:
				result = "QiuyuanQinggongExploration2";
				break;
			case ELeisureInteract.QiuyuanQinggongExploration3:
				result = "QiuyuanQinggongExploration3";
				break;
			case ELeisureInteract.QiuyuanQinggongExploration4:
				result = "QiuyuanQinggongExploration4";
				break;
			case ELeisureInteract.QiuyuanQinggongStraight:
				result = "QiuyuanQinggongStraight";
				break;
			case ELeisureInteract.QiuyuanQinggongHovering:
				result = "QiuyuanQinggongHovering";
				break;
			case ELeisureInteract.SunPalaceInteract:
				result = "SunPalaceInteract";
				break;
			case ELeisureInteract.LandSlide:
				result = "Slide";
				break;
			case ELeisureInteract.LandSlideEnd:
				result = "LandSlideEnd";
				break;
			case ELeisureInteract.RideMotorcycle:
				result = "RideMotorcycle";
				break;
			case ELeisureInteract.GetOffMotorcycle:
				result = "GetOffMotorcycle";
				break;
			case ELeisureInteract.MoneHackingDoor:
				result = "MoneHackingDoor";
				break;
			case ELeisureInteract.MotorSoar:
				result = "MotorSoar";
				break;
			case ELeisureInteract.ParticipateGroupPatrol:
				result = "ParticipateGroupPatrol";
				break;
			case ELeisureInteract.FoxPickUp:
				result = "FoxPickUp";
				break;
			case ELeisureInteract.FoxPutDown:
				result = "FoxPutDown";
				break;
			case ELeisureInteract.FoxPushBox:
				result = "FoxPushBox";
				break;
			case ELeisureInteract.FoxReversePush:
				result = "FoxReversePush";
				break;
			case ELeisureInteract.FoxAutoJump:
				result = "FoxAutoJump";
				break;
			case ELeisureInteract.MechStunt:
				result = "MechStunt";
				break;
			case ELeisureInteract.MechEscortFly:
				result = "MechEscortFly";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x001CF250 File Offset: 0x001CD450
		public static ELeisureInteract FromString(string name)
		{
			ELeisureInteract result;
			if (!ELeisureInteractExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELeisureInteract 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x001CF27C File Offset: 0x001CD47C
		public static bool TryFromString(string name, out ELeisureInteract value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELeisureInteract.CustomSkill;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Soar")
					{
						value = ELeisureInteract.Soar;
						return true;
					}
					break;
				case 5:
				{
					char c = name[1];
					if (c <= 'l')
					{
						if (c != 'e')
						{
							if (c == 'l')
							{
								if (name == "Glide")
								{
									value = ELeisureInteract.Glide;
									return true;
								}
								if (name == "Slide")
								{
									value = ELeisureInteract.LandSlide;
									return true;
								}
							}
						}
						else if (name == "GetUp")
						{
							value = ELeisureInteract.GetUp;
							return true;
						}
					}
					else if (c != 'o')
					{
						if (c == 'w')
						{
							if (name == "Swing")
							{
								value = ELeisureInteract.Swing;
								return true;
							}
						}
					}
					else if (name == "Soar2")
					{
						value = ELeisureInteract.Soar2;
						return true;
					}
					break;
				}
				case 6:
					if (name == "Bounce")
					{
						value = ELeisureInteract.Bounce;
						return true;
					}
					break;
				case 7:
					if (name == "SitDown")
					{
						value = ELeisureInteract.SitDown;
						return true;
					}
					break;
				case 8:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'H')
						{
							if (c == 'K')
							{
								if (name == "KiteHook")
								{
									value = ELeisureInteract.KiteHook;
									return true;
								}
							}
						}
						else if (name == "HookLock")
						{
							value = ELeisureInteract.HookLock;
							return true;
						}
					}
					else if (name == "Catapult")
					{
						value = ELeisureInteract.Catapult;
						return true;
					}
					break;
				}
				case 9:
				{
					char c = name[2];
					if (c <= 'i')
					{
						if (c != 'c')
						{
							if (c == 'i')
							{
								if (name == "FaithJump")
								{
									value = ELeisureInteract.FaithJump;
									return true;
								}
							}
						}
						else if (name == "MechStunt")
						{
							value = ELeisureInteract.MechStunt;
							return true;
						}
					}
					else if (c != 't')
					{
						if (c == 'x')
						{
							if (name == "FoxPickUp")
							{
								value = ELeisureInteract.FoxPickUp;
								return true;
							}
						}
					}
					else if (name == "MotorSoar")
					{
						value = ELeisureInteract.MotorSoar;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[5];
					if (c != 'G')
					{
						switch (c)
						{
						case 's':
							if (name == "FoxPushBox")
							{
								value = ELeisureInteract.FoxPushBox;
								return true;
							}
							break;
						case 't':
							if (name == "FoxPutDown")
							{
								value = ELeisureInteract.FoxPutDown;
								return true;
							}
							break;
						case 'u':
							if (name == "Manipulate")
							{
								value = ELeisureInteract.Manipulate;
								return true;
							}
							break;
						}
					}
					else if (name == "SwingGetUp")
					{
						value = ELeisureInteract.SwingGetUp;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[3];
					if (c <= 'O')
					{
						if (c != 'A')
						{
							if (c == 'O')
							{
								if (name == "SitOnGround")
								{
									value = ELeisureInteract.SitOnGround;
									return true;
								}
							}
						}
						else if (name == "FoxAutoJump")
						{
							value = ELeisureInteract.FoxAutoJump;
							return true;
						}
					}
					else if (c != 'l')
					{
						if (c != 'o')
						{
							if (c == 't')
							{
								if (name == "CustomSkill")
								{
									value = ELeisureInteract.CustomSkill;
									return true;
								}
							}
						}
						else if (name == "MotorBounce")
						{
							value = ELeisureInteract.MotorBounce;
							return true;
						}
					}
					else if (name == "FailurePose")
					{
						value = ELeisureInteract.FailurePose;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c != 'L')
					{
						if (c == 'S')
						{
							if (name == "StandControl")
							{
								value = ELeisureInteract.StandControl;
								return true;
							}
						}
					}
					else if (name == "LandSlideEnd")
					{
						value = ELeisureInteract.LandSlideEnd;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[1];
					if (c <= 'e')
					{
						if (c != 'a')
						{
							if (c == 'e')
							{
								if (name == "MechEscortFly")
								{
									value = ELeisureInteract.MechEscortFly;
									return true;
								}
							}
						}
						else
						{
							if (name == "GameplayPose1")
							{
								value = ELeisureInteract.GameplayPose1;
								return true;
							}
							if (name == "GameplayPose2")
							{
								value = ELeisureInteract.GameplayPose2;
								return true;
							}
							if (name == "GameplayPose3")
							{
								value = ELeisureInteract.GameplayPose3;
								return true;
							}
						}
					}
					else if (c != 'o')
					{
						if (c != 't')
						{
							if (c == 'u')
							{
								if (name == "SuperCatapult")
								{
									value = ELeisureInteract.SuperCatapult;
									return true;
								}
							}
						}
						else if (name == "StandControl2")
						{
							value = ELeisureInteract.StandControl2;
							return true;
						}
					}
					else if (name == "MotorCatapult")
					{
						value = ELeisureInteract.MotorCatapult;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c != 'F')
					{
						if (c == 'R')
						{
							if (name == "RideMotorcycle")
							{
								value = ELeisureInteract.RideMotorcycle;
								return true;
							}
						}
					}
					else if (name == "FoxReversePush")
					{
						value = ELeisureInteract.FoxReversePush;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[2];
					if (c != 'n')
					{
						if (c == 't')
						{
							if (name == "MotorEnterSlide")
							{
								value = ELeisureInteract.MotorEnterSlide;
								return true;
							}
						}
					}
					else if (name == "MoneHackingDoor")
					{
						value = ELeisureInteract.MoneHackingDoor;
						return true;
					}
					break;
				}
				case 16:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'P')
						{
							if (name == "PainCoveringHead")
							{
								value = ELeisureInteract.PainCoveringHead;
								return true;
							}
						}
					}
					else if (name == "GetOffMotorcycle")
					{
						value = ELeisureInteract.GetOffMotorcycle;
						return true;
					}
					break;
				}
				case 17:
					if (name == "SunPalaceInteract")
					{
						value = ELeisureInteract.SunPalaceInteract;
						return true;
					}
					break;
				case 18:
					if (name == "QiuyuanQinggongEnd")
					{
						value = ELeisureInteract.QiuyuanQinggongEnd;
						return true;
					}
					break;
				case 22:
					if (name == "ParticipateGroupPatrol")
					{
						value = ELeisureInteract.ParticipateGroupPatrol;
						return true;
					}
					break;
				case 23:
				{
					char c = name[22];
					switch (c)
					{
					case '1':
						if (name == "WindProtagonistParkour1")
						{
							value = ELeisureInteract.WindProtagonistParkour1;
							return true;
						}
						break;
					case '2':
						if (name == "WindProtagonistParkour2")
						{
							value = ELeisureInteract.WindProtagonistParkour2;
							return true;
						}
						break;
					case '3':
						if (name == "WindProtagonistParkour3")
						{
							value = ELeisureInteract.WindProtagonistParkour3;
							return true;
						}
						break;
					case '4':
						if (name == "WindProtagonistParkour4")
						{
							value = ELeisureInteract.WindProtagonistParkour4;
							return true;
						}
						break;
					case '5':
						if (name == "WindProtagonistParkour5")
						{
							value = ELeisureInteract.WindProtagonistParkour5;
							return true;
						}
						break;
					default:
						if (c != 'g')
						{
							if (c == 't')
							{
								if (name == "QiuyuanQinggongStraight")
								{
									value = ELeisureInteract.QiuyuanQinggongStraight;
									return true;
								}
							}
						}
						else if (name == "QiuyuanQinggongHovering")
						{
							value = ELeisureInteract.QiuyuanQinggongHovering;
							return true;
						}
						break;
					}
					break;
				}
				case 24:
					if (name == "QiuyuanLongPressQinggong")
					{
						value = ELeisureInteract.QiuyuanLongPressQinggong;
						return true;
					}
					break;
				case 27:
					switch (name[26])
					{
					case '1':
						if (name == "QiuyuanQinggongExploration1")
						{
							value = ELeisureInteract.QiuyuanQinggongExploration1;
							return true;
						}
						break;
					case '2':
						if (name == "QiuyuanQinggongExploration2")
						{
							value = ELeisureInteract.QiuyuanQinggongExploration2;
							return true;
						}
						break;
					case '3':
						if (name == "QiuyuanQinggongExploration3")
						{
							value = ELeisureInteract.QiuyuanQinggongExploration3;
							return true;
						}
						break;
					case '4':
						if (name == "QiuyuanQinggongExploration4")
						{
							value = ELeisureInteract.QiuyuanQinggongExploration4;
							return true;
						}
						break;
					}
					break;
				}
			}
			value = ELeisureInteract.CustomSkill;
			return false;
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x001CFAC0 File Offset: 0x001CDCC0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CustomSkill",
				"SitDown",
				"SitOnGround",
				"Bounce",
				"Catapult",
				"SuperCatapult",
				"MotorBounce",
				"MotorCatapult",
				"Manipulate",
				"StandControl",
				"StandControl2",
				"Soar",
				"Soar2",
				"Glide",
				"HookLock",
				"KiteHook",
				"GetUp",
				"FailurePose",
				"GameplayPose1",
				"GameplayPose2",
				"GameplayPose3",
				"FaithJump",
				"WindProtagonistParkour1",
				"WindProtagonistParkour2",
				"WindProtagonistParkour3",
				"WindProtagonistParkour4",
				"WindProtagonistParkour5",
				"PainCoveringHead",
				"Swing",
				"SwingGetUp",
				"MotorEnterSlide",
				"QiuyuanLongPressQinggong",
				"QiuyuanQinggongEnd",
				"QiuyuanQinggongExploration1",
				"QiuyuanQinggongExploration2",
				"QiuyuanQinggongExploration3",
				"QiuyuanQinggongExploration4",
				"QiuyuanQinggongStraight",
				"QiuyuanQinggongHovering",
				"SunPalaceInteract",
				"Slide",
				"LandSlideEnd",
				"RideMotorcycle",
				"GetOffMotorcycle",
				"MoneHackingDoor",
				"MotorSoar",
				"ParticipateGroupPatrol",
				"FoxPickUp",
				"FoxPutDown",
				"FoxPushBox",
				"FoxReversePush",
				"FoxAutoJump",
				"MechStunt",
				"MechEscortFly"
			};
		}

		// Token: 0x0600C5ED RID: 50669 RVA: 0x001CFCB1 File Offset: 0x001CDEB1
		public static ELeisureInteract[] GetValues()
		{
			return new ELeisureInteract[]
			{
				ELeisureInteract.CustomSkill,
				ELeisureInteract.SitDown,
				ELeisureInteract.SitOnGround,
				ELeisureInteract.Bounce,
				ELeisureInteract.Catapult,
				ELeisureInteract.SuperCatapult,
				ELeisureInteract.MotorBounce,
				ELeisureInteract.MotorCatapult,
				ELeisureInteract.Manipulate,
				ELeisureInteract.StandControl,
				ELeisureInteract.StandControl2,
				ELeisureInteract.Soar,
				ELeisureInteract.Soar2,
				ELeisureInteract.Glide,
				ELeisureInteract.HookLock,
				ELeisureInteract.KiteHook,
				ELeisureInteract.GetUp,
				ELeisureInteract.FailurePose,
				ELeisureInteract.GameplayPose1,
				ELeisureInteract.GameplayPose2,
				ELeisureInteract.GameplayPose3,
				ELeisureInteract.FaithJump,
				ELeisureInteract.WindProtagonistParkour1,
				ELeisureInteract.WindProtagonistParkour2,
				ELeisureInteract.WindProtagonistParkour3,
				ELeisureInteract.WindProtagonistParkour4,
				ELeisureInteract.WindProtagonistParkour5,
				ELeisureInteract.PainCoveringHead,
				ELeisureInteract.Swing,
				ELeisureInteract.SwingGetUp,
				ELeisureInteract.MotorEnterSlide,
				ELeisureInteract.QiuyuanLongPressQinggong,
				ELeisureInteract.QiuyuanQinggongEnd,
				ELeisureInteract.QiuyuanQinggongExploration1,
				ELeisureInteract.QiuyuanQinggongExploration2,
				ELeisureInteract.QiuyuanQinggongExploration3,
				ELeisureInteract.QiuyuanQinggongExploration4,
				ELeisureInteract.QiuyuanQinggongStraight,
				ELeisureInteract.QiuyuanQinggongHovering,
				ELeisureInteract.SunPalaceInteract,
				ELeisureInteract.LandSlide,
				ELeisureInteract.LandSlideEnd,
				ELeisureInteract.RideMotorcycle,
				ELeisureInteract.GetOffMotorcycle,
				ELeisureInteract.MoneHackingDoor,
				ELeisureInteract.MotorSoar,
				ELeisureInteract.ParticipateGroupPatrol,
				ELeisureInteract.FoxPickUp,
				ELeisureInteract.FoxPutDown,
				ELeisureInteract.FoxPushBox,
				ELeisureInteract.FoxReversePush,
				ELeisureInteract.FoxAutoJump,
				ELeisureInteract.MechStunt,
				ELeisureInteract.MechEscortFly
			};
		}

		// Token: 0x0600C5EE RID: 50670 RVA: 0x001CFCC8 File Offset: 0x001CDEC8
		public static string[] GetNames()
		{
			return new string[]
			{
				"CustomSkill",
				"SitDown",
				"SitOnGround",
				"Bounce",
				"Catapult",
				"SuperCatapult",
				"MotorBounce",
				"MotorCatapult",
				"Manipulate",
				"StandControl",
				"StandControl2",
				"Soar",
				"Soar2",
				"Glide",
				"HookLock",
				"KiteHook",
				"GetUp",
				"FailurePose",
				"GameplayPose1",
				"GameplayPose2",
				"GameplayPose3",
				"FaithJump",
				"WindProtagonistParkour1",
				"WindProtagonistParkour2",
				"WindProtagonistParkour3",
				"WindProtagonistParkour4",
				"WindProtagonistParkour5",
				"PainCoveringHead",
				"Swing",
				"SwingGetUp",
				"MotorEnterSlide",
				"QiuyuanLongPressQinggong",
				"QiuyuanQinggongEnd",
				"QiuyuanQinggongExploration1",
				"QiuyuanQinggongExploration2",
				"QiuyuanQinggongExploration3",
				"QiuyuanQinggongExploration4",
				"QiuyuanQinggongStraight",
				"QiuyuanQinggongHovering",
				"SunPalaceInteract",
				"LandSlide",
				"LandSlideEnd",
				"RideMotorcycle",
				"GetOffMotorcycle",
				"MoneHackingDoor",
				"MotorSoar",
				"ParticipateGroupPatrol",
				"FoxPickUp",
				"FoxPutDown",
				"FoxPushBox",
				"FoxReversePush",
				"FoxAutoJump",
				"MechStunt",
				"MechEscortFly"
			};
		}
	}
}
