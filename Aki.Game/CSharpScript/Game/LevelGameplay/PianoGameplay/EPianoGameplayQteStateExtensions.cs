using System;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2C RID: 23596
	public static class EPianoGameplayQteStateExtensions
	{
		// Token: 0x06039F51 RID: 237393 RVA: 0x0104D418 File Offset: 0x0104B618
		public static string ToEnumString(this EPianoGameplayQteState value)
		{
			string result;
			switch (value)
			{
			case EPianoGameplayQteState.Idle:
				result = "Idle";
				break;
			case EPianoGameplayQteState.ShowKey:
				result = "ShowKey";
				break;
			case EPianoGameplayQteState.Judge:
				result = "Judge";
				break;
			case EPianoGameplayQteState.JudgeFail:
				result = "JudgeFail";
				break;
			case EPianoGameplayQteState.JudgeSuccess:
				result = "JudgeSuccess";
				break;
			case EPianoGameplayQteState.WaitRecover:
				result = "WaitRecover";
				break;
			case EPianoGameplayQteState.Recover:
				result = "Recover";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06039F52 RID: 237394 RVA: 0x0104D490 File Offset: 0x0104B690
		public static EPianoGameplayQteState FromString(string name)
		{
			EPianoGameplayQteState result;
			if (!EPianoGameplayQteStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPianoGameplayQteState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039F53 RID: 237395 RVA: 0x0104D4BC File Offset: 0x0104B6BC
		public static bool TryFromString(string name, out EPianoGameplayQteState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPianoGameplayQteState.Idle;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Idle")
					{
						value = EPianoGameplayQteState.Idle;
						return true;
					}
					break;
				case 5:
					if (name == "Judge")
					{
						value = EPianoGameplayQteState.Judge;
						return true;
					}
					break;
				case 7:
				{
					char c = name[0];
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (name == "ShowKey")
							{
								value = EPianoGameplayQteState.ShowKey;
								return true;
							}
						}
					}
					else if (name == "Recover")
					{
						value = EPianoGameplayQteState.Recover;
						return true;
					}
					break;
				}
				case 9:
					if (name == "JudgeFail")
					{
						value = EPianoGameplayQteState.JudgeFail;
						return true;
					}
					break;
				case 11:
					if (name == "WaitRecover")
					{
						value = EPianoGameplayQteState.WaitRecover;
						return true;
					}
					break;
				case 12:
					if (name == "JudgeSuccess")
					{
						value = EPianoGameplayQteState.JudgeSuccess;
						return true;
					}
					break;
				}
			}
			value = EPianoGameplayQteState.Idle;
			return false;
		}

		// Token: 0x06039F54 RID: 237396 RVA: 0x0104D5BB File Offset: 0x0104B7BB
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Idle",
				"ShowKey",
				"Judge",
				"JudgeFail",
				"JudgeSuccess",
				"WaitRecover",
				"Recover"
			};
		}

		// Token: 0x06039F55 RID: 237397 RVA: 0x0104D5FB File Offset: 0x0104B7FB
		public static EPianoGameplayQteState[] GetValues()
		{
			return new EPianoGameplayQteState[]
			{
				EPianoGameplayQteState.Idle,
				EPianoGameplayQteState.ShowKey,
				EPianoGameplayQteState.Judge,
				EPianoGameplayQteState.JudgeFail,
				EPianoGameplayQteState.JudgeSuccess,
				EPianoGameplayQteState.WaitRecover,
				EPianoGameplayQteState.Recover
			};
		}

		// Token: 0x06039F56 RID: 237398 RVA: 0x0104D60E File Offset: 0x0104B80E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Idle",
				"ShowKey",
				"Judge",
				"JudgeFail",
				"JudgeSuccess",
				"WaitRecover",
				"Recover"
			};
		}
	}
}
