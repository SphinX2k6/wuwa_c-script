using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002712 RID: 10002
	public static class ETimerTypeExtensions
	{
		// Token: 0x0600D72B RID: 55083 RVA: 0x001F6E38 File Offset: 0x001F5038
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

		// Token: 0x0600D72C RID: 55084 RVA: 0x001F6EC8 File Offset: 0x001F50C8
		public static ETimerType FromString(string name)
		{
			ETimerType result;
			if (!ETimerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x001F6EF4 File Offset: 0x001F50F4
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

		// Token: 0x0600D72E RID: 55086 RVA: 0x001F702C File Offset: 0x001F522C
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

		// Token: 0x0600D72F RID: 55087 RVA: 0x001F7088 File Offset: 0x001F5288
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

		// Token: 0x0600D730 RID: 55088 RVA: 0x001F709C File Offset: 0x001F529C
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
