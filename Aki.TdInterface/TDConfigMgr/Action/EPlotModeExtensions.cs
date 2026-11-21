using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F0 RID: 9456
	public static class EPlotModeExtensions
	{
		// Token: 0x0600CD92 RID: 52626 RVA: 0x001D4084 File Offset: 0x001D2284
		public static string ToEnumString(this EPlotMode value)
		{
			string result;
			switch (value)
			{
			case EPlotMode.LevelA:
				result = "LevelA";
				break;
			case EPlotMode.LevelB:
				result = "LevelB";
				break;
			case EPlotMode.LevelC:
				result = "LevelC";
				break;
			case EPlotMode.LevelD:
				result = "LevelD";
				break;
			case EPlotMode.Prompt:
				result = "Prompt";
				break;
			case EPlotMode.Reigns:
				result = "Reigns";
				break;
			case EPlotMode.PhoneMessage:
				result = "PhoneMessage";
				break;
			case EPlotMode.Avg:
				result = "Avg";
				break;
			case EPlotMode.ControlEntity:
				result = "ControlEntity";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x001D4114 File Offset: 0x001D2314
		public static EPlotMode FromString(string name)
		{
			EPlotMode result;
			if (!EPlotModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlotMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x001D4140 File Offset: 0x001D2340
		public static bool TryFromString(string name, out EPlotMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlotMode.LevelA;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 6)
				{
					if (length != 3)
					{
						if (length == 6)
						{
							char c = name[5];
							switch (c)
							{
							case 'A':
								if (name == "LevelA")
								{
									value = EPlotMode.LevelA;
									return true;
								}
								break;
							case 'B':
								if (name == "LevelB")
								{
									value = EPlotMode.LevelB;
									return true;
								}
								break;
							case 'C':
								if (name == "LevelC")
								{
									value = EPlotMode.LevelC;
									return true;
								}
								break;
							case 'D':
								if (name == "LevelD")
								{
									value = EPlotMode.LevelD;
									return true;
								}
								break;
							default:
								if (c != 's')
								{
									if (c == 't')
									{
										if (name == "Prompt")
										{
											value = EPlotMode.Prompt;
											return true;
										}
									}
								}
								else if (name == "Reigns")
								{
									value = EPlotMode.Reigns;
									return true;
								}
								break;
							}
						}
					}
					else if (name == "Avg")
					{
						value = EPlotMode.Avg;
						return true;
					}
				}
				else if (length != 12)
				{
					if (length == 13)
					{
						if (name == "ControlEntity")
						{
							value = EPlotMode.ControlEntity;
							return true;
						}
					}
				}
				else if (name == "PhoneMessage")
				{
					value = EPlotMode.PhoneMessage;
					return true;
				}
			}
			value = EPlotMode.LevelA;
			return false;
		}

		// Token: 0x0600CD95 RID: 52629 RVA: 0x001D4284 File Offset: 0x001D2484
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD",
				"Prompt",
				"Reigns",
				"PhoneMessage",
				"Avg",
				"ControlEntity"
			};
		}

		// Token: 0x0600CD96 RID: 52630 RVA: 0x001D42E0 File Offset: 0x001D24E0
		public static EPlotMode[] GetValues()
		{
			return new EPlotMode[]
			{
				EPlotMode.LevelA,
				EPlotMode.LevelB,
				EPlotMode.LevelC,
				EPlotMode.LevelD,
				EPlotMode.Prompt,
				EPlotMode.Reigns,
				EPlotMode.PhoneMessage,
				EPlotMode.Avg,
				EPlotMode.ControlEntity
			};
		}

		// Token: 0x0600CD97 RID: 52631 RVA: 0x001D42F4 File Offset: 0x001D24F4
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD",
				"Prompt",
				"Reigns",
				"PhoneMessage",
				"Avg",
				"ControlEntity"
			};
		}
	}
}
