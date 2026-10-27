using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BF RID: 9407
	public static class TActionContextTypeExtensions
	{
		// Token: 0x0600CBDA RID: 52186 RVA: 0x001E0394 File Offset: 0x001DE594
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

		// Token: 0x0600CBDB RID: 52187 RVA: 0x001E0418 File Offset: 0x001DE618
		public static TActionContextType FromString(string name)
		{
			TActionContextType result;
			if (!TActionContextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TActionContextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x001E0444 File Offset: 0x001DE644
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

		// Token: 0x0600CBDD RID: 52189 RVA: 0x001E0548 File Offset: 0x001DE748
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

		// Token: 0x0600CBDE RID: 52190 RVA: 0x001E059B File Offset: 0x001DE79B
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

		// Token: 0x0600CBDF RID: 52191 RVA: 0x001E05B0 File Offset: 0x001DE7B0
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
