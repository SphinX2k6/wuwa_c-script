using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AA RID: 5034
	public static class EPlayerTriggerMotionExtensions
	{
		// Token: 0x060070D7 RID: 28887 RVA: 0x0010CFD4 File Offset: 0x0010B1D4
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

		// Token: 0x060070D8 RID: 28888 RVA: 0x0010D070 File Offset: 0x0010B270
		public static EPlayerTriggerMotion FromString(string name)
		{
			EPlayerTriggerMotion result;
			if (!EPlayerTriggerMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerTriggerMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x0010D09C File Offset: 0x0010B29C
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

		// Token: 0x060070DA RID: 28890 RVA: 0x0010D200 File Offset: 0x0010B400
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

		// Token: 0x060070DB RID: 28891 RVA: 0x0010D265 File Offset: 0x0010B465
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

		// Token: 0x060070DC RID: 28892 RVA: 0x0010D27C File Offset: 0x0010B47C
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
