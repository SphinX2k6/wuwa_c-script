using System;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD4 RID: 16340
	public static class EPlotLevelExtensions
	{
		// Token: 0x060295A0 RID: 169376 RVA: 0x00BA4928 File Offset: 0x00BA2B28
		public static string ToEnumString(this EPlotLevel value)
		{
			string result;
			switch (value)
			{
			case EPlotLevel.LevelA:
				result = "LevelA";
				break;
			case EPlotLevel.LevelB:
				result = "LevelB";
				break;
			case EPlotLevel.LevelC:
				result = "LevelC";
				break;
			case EPlotLevel.LevelD:
				result = "LevelD";
				break;
			case EPlotLevel.LevelE:
				result = "LevelE";
				break;
			case EPlotLevel.Prompt:
				result = "Prompt";
				break;
			case EPlotLevel.ControlEntity:
				result = "ControlEntity";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060295A1 RID: 169377 RVA: 0x00BA49A0 File Offset: 0x00BA2BA0
		public static EPlotLevel FromString(string name)
		{
			EPlotLevel result;
			if (!EPlotLevelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlotLevel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060295A2 RID: 169378 RVA: 0x00BA49CC File Offset: 0x00BA2BCC
		public static bool TryFromString(string name, out EPlotLevel value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlotLevel.LevelA;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 6)
				{
					if (length == 13)
					{
						if (name == "ControlEntity")
						{
							value = EPlotLevel.ControlEntity;
							return true;
						}
					}
				}
				else
				{
					char c = name[5];
					switch (c)
					{
					case 'A':
						if (name == "LevelA")
						{
							value = EPlotLevel.LevelA;
							return true;
						}
						break;
					case 'B':
						if (name == "LevelB")
						{
							value = EPlotLevel.LevelB;
							return true;
						}
						break;
					case 'C':
						if (name == "LevelC")
						{
							value = EPlotLevel.LevelC;
							return true;
						}
						break;
					case 'D':
						if (name == "LevelD")
						{
							value = EPlotLevel.LevelD;
							return true;
						}
						break;
					case 'E':
						if (name == "LevelE")
						{
							value = EPlotLevel.LevelE;
							return true;
						}
						break;
					default:
						if (c == 't')
						{
							if (name == "Prompt")
							{
								value = EPlotLevel.Prompt;
								return true;
							}
						}
						break;
					}
				}
			}
			value = EPlotLevel.LevelA;
			return false;
		}

		// Token: 0x060295A3 RID: 169379 RVA: 0x00BA4AC3 File Offset: 0x00BA2CC3
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD",
				"LevelE",
				"Prompt",
				"ControlEntity"
			};
		}

		// Token: 0x060295A4 RID: 169380 RVA: 0x00BA4B03 File Offset: 0x00BA2D03
		public static EPlotLevel[] GetValues()
		{
			return new EPlotLevel[]
			{
				EPlotLevel.LevelA,
				EPlotLevel.LevelB,
				EPlotLevel.LevelC,
				EPlotLevel.LevelD,
				EPlotLevel.LevelE,
				EPlotLevel.Prompt,
				EPlotLevel.ControlEntity
			};
		}

		// Token: 0x060295A5 RID: 169381 RVA: 0x00BA4B16 File Offset: 0x00BA2D16
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD",
				"LevelE",
				"Prompt",
				"ControlEntity"
			};
		}
	}
}
