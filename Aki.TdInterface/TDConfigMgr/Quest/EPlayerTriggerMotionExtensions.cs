using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126A RID: 4714
	public static class EPlayerTriggerMotionExtensions
	{
		// Token: 0x06006A84 RID: 27268 RVA: 0x000FF3A8 File Offset: 0x000FD5A8
		public static string ToEnumString(this EPlayerTriggerMotion value)
		{
			string result;
			switch (value)
			{
			case EPlayerTriggerMotion.GroundSprint:
				result = "GroundSprint";
				break;
			case EPlayerTriggerMotion.GroundBackstep:
				result = "GroundBackstep";
				break;
			case EPlayerTriggerMotion.GroundLand:
				result = "GroundLand";
				break;
			case EPlayerTriggerMotion.AirJump:
				result = "AirJump";
				break;
			case EPlayerTriggerMotion.AirSprint:
				result = "AirSprint";
				break;
			case EPlayerTriggerMotion.AirBackflip:
				result = "AirBackflip";
				break;
			case EPlayerTriggerMotion.ClimbLeap:
				result = "ClimbLeap";
				break;
			case EPlayerTriggerMotion.ClimbTop:
				result = "ClimbTop";
				break;
			case EPlayerTriggerMotion.LimitDodge:
				result = "LimitDodge";
				break;
			case EPlayerTriggerMotion.CounterAttack:
				result = "CounterAttack";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x000FF444 File Offset: 0x000FD644
		public static EPlayerTriggerMotion FromString(string name)
		{
			EPlayerTriggerMotion result;
			if (!EPlayerTriggerMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerTriggerMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x000FF470 File Offset: 0x000FD670
		public static bool TryFromString(string name, out EPlayerTriggerMotion value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerTriggerMotion.GroundSprint;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 7:
					if (name == "AirJump")
					{
						value = EPlayerTriggerMotion.AirJump;
						return true;
					}
					break;
				case 8:
					if (name == "ClimbTop")
					{
						value = EPlayerTriggerMotion.ClimbTop;
						return true;
					}
					break;
				case 9:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (name == "ClimbLeap")
							{
								value = EPlayerTriggerMotion.ClimbLeap;
								return true;
							}
						}
					}
					else if (name == "AirSprint")
					{
						value = EPlayerTriggerMotion.AirSprint;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = name[0];
					if (c != 'G')
					{
						if (c == 'L')
						{
							if (name == "LimitDodge")
							{
								value = EPlayerTriggerMotion.LimitDodge;
								return true;
							}
						}
					}
					else if (name == "GroundLand")
					{
						value = EPlayerTriggerMotion.GroundLand;
						return true;
					}
					break;
				}
				case 11:
					if (name == "AirBackflip")
					{
						value = EPlayerTriggerMotion.AirBackflip;
						return true;
					}
					break;
				case 12:
					if (name == "GroundSprint")
					{
						value = EPlayerTriggerMotion.GroundSprint;
						return true;
					}
					break;
				case 13:
					if (name == "CounterAttack")
					{
						value = EPlayerTriggerMotion.CounterAttack;
						return true;
					}
					break;
				case 14:
					if (name == "GroundBackstep")
					{
						value = EPlayerTriggerMotion.GroundBackstep;
						return true;
					}
					break;
				}
			}
			value = EPlayerTriggerMotion.GroundSprint;
			return false;
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x000FF5D4 File Offset: 0x000FD7D4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"GroundSprint",
				"GroundBackstep",
				"GroundLand",
				"AirJump",
				"AirSprint",
				"AirBackflip",
				"ClimbLeap",
				"ClimbTop",
				"LimitDodge",
				"CounterAttack"
			};
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x000FF639 File Offset: 0x000FD839
		public static EPlayerTriggerMotion[] GetValues()
		{
			return new EPlayerTriggerMotion[]
			{
				EPlayerTriggerMotion.GroundSprint,
				EPlayerTriggerMotion.GroundBackstep,
				EPlayerTriggerMotion.GroundLand,
				EPlayerTriggerMotion.AirJump,
				EPlayerTriggerMotion.AirSprint,
				EPlayerTriggerMotion.AirBackflip,
				EPlayerTriggerMotion.ClimbLeap,
				EPlayerTriggerMotion.ClimbTop,
				EPlayerTriggerMotion.LimitDodge,
				EPlayerTriggerMotion.CounterAttack
			};
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x000FF650 File Offset: 0x000FD850
		public static string[] GetNames()
		{
			return new string[]
			{
				"GroundSprint",
				"GroundBackstep",
				"GroundLand",
				"AirJump",
				"AirSprint",
				"AirBackflip",
				"ClimbLeap",
				"ClimbTop",
				"LimitDodge",
				"CounterAttack"
			};
		}
	}
}
