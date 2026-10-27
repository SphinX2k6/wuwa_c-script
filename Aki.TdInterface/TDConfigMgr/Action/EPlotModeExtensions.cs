using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002283 RID: 8835
	public static class EPlotModeExtensions
	{
		// Token: 0x0600C1CC RID: 49612 RVA: 0x001BC900 File Offset: 0x001BAB00
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

		// Token: 0x0600C1CD RID: 49613 RVA: 0x001BC990 File Offset: 0x001BAB90
		public static EPlotMode FromString(string name)
		{
			EPlotMode result;
			if (!EPlotModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlotMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x001BC9BC File Offset: 0x001BABBC
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

		// Token: 0x0600C1CF RID: 49615 RVA: 0x001BCB00 File Offset: 0x001BAD00
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

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x001BCB5C File Offset: 0x001BAD5C
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

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x001BCB70 File Offset: 0x001BAD70
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
