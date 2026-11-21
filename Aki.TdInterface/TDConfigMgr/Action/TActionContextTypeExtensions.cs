using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002764 RID: 10084
	public static class TActionContextTypeExtensions
	{
		// Token: 0x0600D89C RID: 55452 RVA: 0x001FA628 File Offset: 0x001F8828
		public static string ToEnumString(this TActionContextType value)
		{
			string result;
			switch (value)
			{
			case TActionContextType.commonBt:
				result = "commonBt";
				break;
			case TActionContextType.csv:
				result = "csv";
				break;
			case TActionContextType.entity:
				result = "entity";
				break;
			case TActionContextType.flow:
				result = "flow";
				break;
			case TActionContextType.gm:
				result = "gm";
				break;
			case TActionContextType.levelPlay:
				result = "levelPlay";
				break;
			case TActionContextType.quest:
				result = "quest";
				break;
			case TActionContextType.toolEditor:
				result = "toolEditor";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D89D RID: 55453 RVA: 0x001FA6AC File Offset: 0x001F88AC
		public static TActionContextType FromString(string name)
		{
			TActionContextType result;
			if (!TActionContextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TActionContextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D89E RID: 55454 RVA: 0x001FA6D8 File Offset: 0x001F88D8
		public static bool TryFromString(string name, out TActionContextType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TActionContextType.commonBt;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 2:
					if (name == "gm")
					{
						value = TActionContextType.gm;
						return true;
					}
					break;
				case 3:
					if (name == "csv")
					{
						value = TActionContextType.csv;
						return true;
					}
					break;
				case 4:
					if (name == "flow")
					{
						value = TActionContextType.flow;
						return true;
					}
					break;
				case 5:
					if (name == "quest")
					{
						value = TActionContextType.quest;
						return true;
					}
					break;
				case 6:
					if (name == "entity")
					{
						value = TActionContextType.entity;
						return true;
					}
					break;
				case 8:
					if (name == "commonBt")
					{
						value = TActionContextType.commonBt;
						return true;
					}
					break;
				case 9:
					if (name == "levelPlay")
					{
						value = TActionContextType.levelPlay;
						return true;
					}
					break;
				case 10:
					if (name == "toolEditor")
					{
						value = TActionContextType.toolEditor;
						return true;
					}
					break;
				}
			}
			value = TActionContextType.commonBt;
			return false;
		}

		// Token: 0x0600D89F RID: 55455 RVA: 0x001FA7DC File Offset: 0x001F89DC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"commonBt",
				"csv",
				"entity",
				"flow",
				"gm",
				"levelPlay",
				"quest",
				"toolEditor"
			};
		}

		// Token: 0x0600D8A0 RID: 55456 RVA: 0x001FA82F File Offset: 0x001F8A2F
		public static TActionContextType[] GetValues()
		{
			return new TActionContextType[]
			{
				TActionContextType.commonBt,
				TActionContextType.csv,
				TActionContextType.entity,
				TActionContextType.flow,
				TActionContextType.gm,
				TActionContextType.levelPlay,
				TActionContextType.quest,
				TActionContextType.toolEditor
			};
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x001FA844 File Offset: 0x001F8A44
		public static string[] GetNames()
		{
			return new string[]
			{
				"commonBt",
				"csv",
				"entity",
				"flow",
				"gm",
				"levelPlay",
				"quest",
				"toolEditor"
			};
		}
	}
}
