using System;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003017 RID: 12311
	public static class ESpineAnimationExtensions
	{
		// Token: 0x0601D371 RID: 119665 RVA: 0x008EADC8 File Offset: 0x008E8FC8
		public static string ToEnumString(this ESpineAnimation value)
		{
			string result;
			switch (value)
			{
			case ESpineAnimation.Die:
				result = "die";
				break;
			case ESpineAnimation.Idle:
				result = "idle";
				break;
			case ESpineAnimation.Sleep:
				result = "sleep";
				break;
			case ESpineAnimation.Sleep2:
				result = "sleep2";
				break;
			case ESpineAnimation.Trap:
				result = "trap";
				break;
			case ESpineAnimation.TrapOpen:
				result = "trap_open";
				break;
			case ESpineAnimation.WakeUp:
				result = "wake up";
				break;
			case ESpineAnimation.WakeUp2:
				result = "wake up2";
				break;
			case ESpineAnimation.Walk:
				result = "walk";
				break;
			case ESpineAnimation.WalkLoop:
				result = "walk_loop";
				break;
			case ESpineAnimation.SleepStart:
				result = "sleep_start";
				break;
			case ESpineAnimation.SleepStart2:
				result = "sleep_start2";
				break;
			case ESpineAnimation.WalkAway:
				result = "walk_away";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0601D372 RID: 119666 RVA: 0x008EAE88 File Offset: 0x008E9088
		public static ESpineAnimation FromString(string name)
		{
			ESpineAnimation result;
			if (!ESpineAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpineAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0601D373 RID: 119667 RVA: 0x008EAEB4 File Offset: 0x008E90B4
		public static bool TryFromString(string name, out ESpineAnimation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpineAnimation.Die;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "die")
					{
						value = ESpineAnimation.Die;
						return true;
					}
					break;
				case 4:
				{
					char c = name[0];
					if (c != 'i')
					{
						if (c != 't')
						{
							if (c == 'w')
							{
								if (name == "walk")
								{
									value = ESpineAnimation.Walk;
									return true;
								}
							}
						}
						else if (name == "trap")
						{
							value = ESpineAnimation.Trap;
							return true;
						}
					}
					else if (name == "idle")
					{
						value = ESpineAnimation.Idle;
						return true;
					}
					break;
				}
				case 5:
					if (name == "sleep")
					{
						value = ESpineAnimation.Sleep;
						return true;
					}
					break;
				case 6:
					if (name == "sleep2")
					{
						value = ESpineAnimation.Sleep2;
						return true;
					}
					break;
				case 7:
					if (name == "wake up")
					{
						value = ESpineAnimation.WakeUp;
						return true;
					}
					break;
				case 8:
					if (name == "wake up2")
					{
						value = ESpineAnimation.WakeUp2;
						return true;
					}
					break;
				case 9:
				{
					char c = name[5];
					if (c != 'a')
					{
						if (c != 'l')
						{
							if (c == 'o')
							{
								if (name == "trap_open")
								{
									value = ESpineAnimation.TrapOpen;
									return true;
								}
							}
						}
						else if (name == "walk_loop")
						{
							value = ESpineAnimation.WalkLoop;
							return true;
						}
					}
					else if (name == "walk_away")
					{
						value = ESpineAnimation.WalkAway;
						return true;
					}
					break;
				}
				case 11:
					if (name == "sleep_start")
					{
						value = ESpineAnimation.SleepStart;
						return true;
					}
					break;
				case 12:
					if (name == "sleep_start2")
					{
						value = ESpineAnimation.SleepStart2;
						return true;
					}
					break;
				}
			}
			value = ESpineAnimation.Die;
			return false;
		}

		// Token: 0x0601D374 RID: 119668 RVA: 0x008EB094 File Offset: 0x008E9294
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"die",
				"idle",
				"sleep",
				"sleep2",
				"trap",
				"trap_open",
				"wake up",
				"wake up2",
				"walk",
				"walk_loop",
				"sleep_start",
				"sleep_start2",
				"walk_away"
			};
		}

		// Token: 0x0601D375 RID: 119669 RVA: 0x008EB114 File Offset: 0x008E9314
		public static ESpineAnimation[] GetValues()
		{
			return new ESpineAnimation[]
			{
				ESpineAnimation.Die,
				ESpineAnimation.Idle,
				ESpineAnimation.Sleep,
				ESpineAnimation.Sleep2,
				ESpineAnimation.Trap,
				ESpineAnimation.TrapOpen,
				ESpineAnimation.WakeUp,
				ESpineAnimation.WakeUp2,
				ESpineAnimation.Walk,
				ESpineAnimation.WalkLoop,
				ESpineAnimation.SleepStart,
				ESpineAnimation.SleepStart2,
				ESpineAnimation.WalkAway
			};
		}

		// Token: 0x0601D376 RID: 119670 RVA: 0x008EB128 File Offset: 0x008E9328
		public static string[] GetNames()
		{
			return new string[]
			{
				"Die",
				"Idle",
				"Sleep",
				"Sleep2",
				"Trap",
				"TrapOpen",
				"WakeUp",
				"WakeUp2",
				"Walk",
				"WalkLoop",
				"SleepStart",
				"SleepStart2",
				"WalkAway"
			};
		}
	}
}
