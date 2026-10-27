using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002467 RID: 9319
	public static class ETeleportTransitionTypeExtensions
	{
		// Token: 0x0600CA4E RID: 51790 RVA: 0x001DC494 File Offset: 0x001DA694
		public static string ToEnumString(this ETeleportTransitionType value)
		{
			string result;
			switch (value)
			{
			case ETeleportTransitionType.PlayMp4:
				result = "PlayMp4";
				break;
			case ETeleportTransitionType.PlayEffect:
				result = "PlayEffect";
				break;
			case ETeleportTransitionType.CenterText:
				result = "CenterText";
				break;
			case ETeleportTransitionType.Seamless:
				result = "Seamless";
				break;
			case ETeleportTransitionType.FadeInScreen:
				result = "FadeInScreen";
				break;
			case ETeleportTransitionType.DigitalScreen:
				result = "DigitalScreen";
				break;
			case ETeleportTransitionType.CharacterDisplay:
				result = "CharacterDisplay";
				break;
			case ETeleportTransitionType.CustomLoading:
				result = "CustomLoading";
				break;
			case ETeleportTransitionType.CustomScreen:
				result = "CustomScreen";
				break;
			case ETeleportTransitionType.SpecialCustomLoading:
				result = "SpecialCustomLoading";
				break;
			case ETeleportTransitionType.PlayFlow:
				result = "PlayFlow";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x001DC53C File Offset: 0x001DA73C
		public static ETeleportTransitionType FromString(string name)
		{
			ETeleportTransitionType result;
			if (!ETeleportTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleportTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x001DC568 File Offset: 0x001DA768
		public static bool TryFromString(string name, out ETeleportTransitionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleportTransitionType.PlayMp4;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 7:
					if (name == "PlayMp4")
					{
						value = ETeleportTransitionType.PlayMp4;
						return true;
					}
					break;
				case 8:
				{
					char c = name[0];
					if (c != 'P')
					{
						if (c == 'S')
						{
							if (name == "Seamless")
							{
								value = ETeleportTransitionType.Seamless;
								return true;
							}
						}
					}
					else if (name == "PlayFlow")
					{
						value = ETeleportTransitionType.PlayFlow;
						return true;
					}
					break;
				}
				case 9:
				case 11:
				case 14:
				case 15:
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'P')
						{
							if (name == "PlayEffect")
							{
								value = ETeleportTransitionType.PlayEffect;
								return true;
							}
						}
					}
					else if (name == "CenterText")
					{
						value = ETeleportTransitionType.CenterText;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'F')
						{
							if (name == "FadeInScreen")
							{
								value = ETeleportTransitionType.FadeInScreen;
								return true;
							}
						}
					}
					else if (name == "CustomScreen")
					{
						value = ETeleportTransitionType.CustomScreen;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'D')
						{
							if (name == "DigitalScreen")
							{
								value = ETeleportTransitionType.DigitalScreen;
								return true;
							}
						}
					}
					else if (name == "CustomLoading")
					{
						value = ETeleportTransitionType.CustomLoading;
						return true;
					}
					break;
				}
				case 16:
					if (name == "CharacterDisplay")
					{
						value = ETeleportTransitionType.CharacterDisplay;
						return true;
					}
					break;
				default:
					if (length == 20)
					{
						if (name == "SpecialCustomLoading")
						{
							value = ETeleportTransitionType.SpecialCustomLoading;
							return true;
						}
					}
					break;
				}
			}
			value = ETeleportTransitionType.PlayMp4;
			return false;
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x001DC740 File Offset: 0x001DA940
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayMp4",
				"PlayEffect",
				"CenterText",
				"Seamless",
				"FadeInScreen",
				"DigitalScreen",
				"CharacterDisplay",
				"CustomLoading",
				"CustomScreen",
				"SpecialCustomLoading",
				"PlayFlow"
			};
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x001DC7AE File Offset: 0x001DA9AE
		public static ETeleportTransitionType[] GetValues()
		{
			return new ETeleportTransitionType[]
			{
				ETeleportTransitionType.PlayMp4,
				ETeleportTransitionType.PlayEffect,
				ETeleportTransitionType.CenterText,
				ETeleportTransitionType.Seamless,
				ETeleportTransitionType.FadeInScreen,
				ETeleportTransitionType.DigitalScreen,
				ETeleportTransitionType.CharacterDisplay,
				ETeleportTransitionType.CustomLoading,
				ETeleportTransitionType.CustomScreen,
				ETeleportTransitionType.SpecialCustomLoading,
				ETeleportTransitionType.PlayFlow
			};
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x001DC7C4 File Offset: 0x001DA9C4
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayMp4",
				"PlayEffect",
				"CenterText",
				"Seamless",
				"FadeInScreen",
				"DigitalScreen",
				"CharacterDisplay",
				"CustomLoading",
				"CustomScreen",
				"SpecialCustomLoading",
				"PlayFlow"
			};
		}
	}
}
