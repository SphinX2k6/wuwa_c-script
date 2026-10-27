using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002471 RID: 9329
	public static class ETimerTypeExtensions
	{
		// Token: 0x0600CA7B RID: 51835 RVA: 0x001DCD84 File Offset: 0x001DAF84
		public static string ToEnumString(this ETimerType value)
		{
			string result;
			switch (value)
			{
			case ETimerType.CountDownChallenge:
				result = "CountDownChallenge";
				break;
			case ETimerType.PlayStartCountDown:
				result = "GameStartCountDown";
				break;
			case ETimerType.PublicTime:
				result = "PublicTime";
				break;
			case ETimerType.WaitTime:
				result = "WaitTime";
				break;
			case ETimerType.BehaviorTreeTimer1:
				result = "BehaviorTreeTimer1";
				break;
			case ETimerType.BehaviorTreeTimer2:
				result = "BehaviorTreeTimer2";
				break;
			case ETimerType.BehaviorTreeTimer3:
				result = "BehaviorTreeTimer3";
				break;
			case ETimerType.BehaviorTreeTimer4:
				result = "BehaviorTreeTimer4";
				break;
			case ETimerType.BehaviorTreeTimer5:
				result = "BehaviorTreeTimer5";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x001DCE14 File Offset: 0x001DB014
		public static ETimerType FromString(string name)
		{
			ETimerType result;
			if (!ETimerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x001DCE40 File Offset: 0x001DB040
		public static bool TryFromString(string name, out ETimerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimerType.CountDownChallenge;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 8)
				{
					if (length != 10)
					{
						if (length == 18)
						{
							char c = name[17];
							switch (c)
							{
							case '1':
								if (name == "BehaviorTreeTimer1")
								{
									value = ETimerType.BehaviorTreeTimer1;
									return true;
								}
								break;
							case '2':
								if (name == "BehaviorTreeTimer2")
								{
									value = ETimerType.BehaviorTreeTimer2;
									return true;
								}
								break;
							case '3':
								if (name == "BehaviorTreeTimer3")
								{
									value = ETimerType.BehaviorTreeTimer3;
									return true;
								}
								break;
							case '4':
								if (name == "BehaviorTreeTimer4")
								{
									value = ETimerType.BehaviorTreeTimer4;
									return true;
								}
								break;
							case '5':
								if (name == "BehaviorTreeTimer5")
								{
									value = ETimerType.BehaviorTreeTimer5;
									return true;
								}
								break;
							default:
								if (c != 'e')
								{
									if (c == 'n')
									{
										if (name == "GameStartCountDown")
										{
											value = ETimerType.PlayStartCountDown;
											return true;
										}
									}
								}
								else if (name == "CountDownChallenge")
								{
									value = ETimerType.CountDownChallenge;
									return true;
								}
								break;
							}
						}
					}
					else if (name == "PublicTime")
					{
						value = ETimerType.PublicTime;
						return true;
					}
				}
				else if (name == "WaitTime")
				{
					value = ETimerType.WaitTime;
					return true;
				}
			}
			value = ETimerType.CountDownChallenge;
			return false;
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x001DCF78 File Offset: 0x001DB178
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CountDownChallenge",
				"GameStartCountDown",
				"PublicTime",
				"WaitTime",
				"BehaviorTreeTimer1",
				"BehaviorTreeTimer2",
				"BehaviorTreeTimer3",
				"BehaviorTreeTimer4",
				"BehaviorTreeTimer5"
			};
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x001DCFD4 File Offset: 0x001DB1D4
		public static ETimerType[] GetValues()
		{
			return new ETimerType[]
			{
				ETimerType.CountDownChallenge,
				ETimerType.PlayStartCountDown,
				ETimerType.PublicTime,
				ETimerType.WaitTime,
				ETimerType.BehaviorTreeTimer1,
				ETimerType.BehaviorTreeTimer2,
				ETimerType.BehaviorTreeTimer3,
				ETimerType.BehaviorTreeTimer4,
				ETimerType.BehaviorTreeTimer5
			};
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x001DCFE8 File Offset: 0x001DB1E8
		public static string[] GetNames()
		{
			return new string[]
			{
				"CountDownChallenge",
				"PlayStartCountDown",
				"PublicTime",
				"WaitTime",
				"BehaviorTreeTimer1",
				"BehaviorTreeTimer2",
				"BehaviorTreeTimer3",
				"BehaviorTreeTimer4",
				"BehaviorTreeTimer5"
			};
		}
	}
}
