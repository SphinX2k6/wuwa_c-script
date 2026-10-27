using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200667A RID: 26234
	public static class ESpineAnimationExtensions
	{
		// Token: 0x06041BD6 RID: 269270 RVA: 0x00FF2360 File Offset: 0x00FF0560
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

		// Token: 0x06041BD7 RID: 269271 RVA: 0x00FF2420 File Offset: 0x00FF0620
		public static ESpineAnimation FromString(string name)
		{
			ESpineAnimation result;
			if (!ESpineAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpineAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041BD8 RID: 269272 RVA: 0x00FF244C File Offset: 0x00FF064C
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

		// Token: 0x06041BD9 RID: 269273 RVA: 0x00FF262C File Offset: 0x00FF082C
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

		// Token: 0x06041BDA RID: 269274 RVA: 0x00FF26AC File Offset: 0x00FF08AC
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

		// Token: 0x06041BDB RID: 269275 RVA: 0x00FF26C0 File Offset: 0x00FF08C0
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
