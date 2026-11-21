using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002520 RID: 9504
	public static class EAvgTalkItemSubTypeExtensions
	{
		// Token: 0x0600CE6A RID: 52842 RVA: 0x001DED94 File Offset: 0x001DCF94
		public static string ToEnumString(this EAvgTalkItemSubType value)
		{
			string result;
			switch (value)
			{
			case EAvgTalkItemSubType.Dialog:
				result = "Dialog";
				break;
			case EAvgTalkItemSubType.Enter:
				result = "Enter";
				break;
			case EAvgTalkItemSubType.Exit:
				result = "Exit";
				break;
			case EAvgTalkItemSubType.Option:
				result = "Option";
				break;
			case EAvgTalkItemSubType.Narration:
				result = "Narration";
				break;
			case EAvgTalkItemSubType.CenterText:
				result = "CenterText";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CE6B RID: 52843 RVA: 0x001DEE00 File Offset: 0x001DD000
		public static EAvgTalkItemSubType FromString(string name)
		{
			EAvgTalkItemSubType result;
			if (!EAvgTalkItemSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgTalkItemSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE6C RID: 52844 RVA: 0x001DEE2C File Offset: 0x001DD02C
		public static bool TryFromString(string name, out EAvgTalkItemSubType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgTalkItemSubType.Dialog;
				return false;
			}
			if (name == "Dialog")
			{
				value = EAvgTalkItemSubType.Dialog;
				return true;
			}
			if (name == "Enter")
			{
				value = EAvgTalkItemSubType.Enter;
				return true;
			}
			if (name == "Exit")
			{
				value = EAvgTalkItemSubType.Exit;
				return true;
			}
			if (name == "Option")
			{
				value = EAvgTalkItemSubType.Option;
				return true;
			}
			if (name == "Narration")
			{
				value = EAvgTalkItemSubType.Narration;
				return true;
			}
			if (!(name == "CenterText"))
			{
				value = EAvgTalkItemSubType.Dialog;
				return false;
			}
			value = EAvgTalkItemSubType.CenterText;
			return true;
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x001DEEB8 File Offset: 0x001DD0B8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Dialog",
				"Enter",
				"Exit",
				"Option",
				"Narration",
				"CenterText"
			};
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x001DEEF0 File Offset: 0x001DD0F0
		public static EAvgTalkItemSubType[] GetValues()
		{
			return new EAvgTalkItemSubType[]
			{
				EAvgTalkItemSubType.Dialog,
				EAvgTalkItemSubType.Enter,
				EAvgTalkItemSubType.Exit,
				EAvgTalkItemSubType.Option,
				EAvgTalkItemSubType.Narration,
				EAvgTalkItemSubType.CenterText
			};
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x001DEF03 File Offset: 0x001DD103
		public static string[] GetNames()
		{
			return new string[]
			{
				"Dialog",
				"Enter",
				"Exit",
				"Option",
				"Narration",
				"CenterText"
			};
		}
	}
}
