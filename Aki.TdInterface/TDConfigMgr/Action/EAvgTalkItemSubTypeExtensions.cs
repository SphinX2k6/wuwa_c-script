using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B1 RID: 8881
	public static class EAvgTalkItemSubTypeExtensions
	{
		// Token: 0x0600C29B RID: 49819 RVA: 0x001C6F8C File Offset: 0x001C518C
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

		// Token: 0x0600C29C RID: 49820 RVA: 0x001C6FF8 File Offset: 0x001C51F8
		public static EAvgTalkItemSubType FromString(string name)
		{
			EAvgTalkItemSubType result;
			if (!EAvgTalkItemSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgTalkItemSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x001C7024 File Offset: 0x001C5224
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

		// Token: 0x0600C29E RID: 49822 RVA: 0x001C70B0 File Offset: 0x001C52B0
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

		// Token: 0x0600C29F RID: 49823 RVA: 0x001C70E8 File Offset: 0x001C52E8
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

		// Token: 0x0600C2A0 RID: 49824 RVA: 0x001C70FB File Offset: 0x001C52FB
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
