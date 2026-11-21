using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FA RID: 9722
	public static class ELiveUiTypeExtensions
	{
		// Token: 0x0600D23F RID: 53823 RVA: 0x001E90D4 File Offset: 0x001E72D4
		public static string ToEnumString(this ELiveUiType value)
		{
			string result;
			switch (value)
			{
			case ELiveUiType.Start:
				result = "Start";
				break;
			case ELiveUiType.Resume:
				result = "Resume";
				break;
			case ELiveUiType.Show:
				result = "Show";
				break;
			case ELiveUiType.Finish:
				result = "Finish";
				break;
			case ELiveUiType.Pause:
				result = "Pause";
				break;
			case ELiveUiType.Hide:
				result = "Hide";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x001E9140 File Offset: 0x001E7340
		public static ELiveUiType FromString(string name)
		{
			ELiveUiType result;
			if (!ELiveUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x001E916C File Offset: 0x001E736C
		public static bool TryFromString(string name, out ELiveUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveUiType.Start;
				return false;
			}
			if (name == "Start")
			{
				value = ELiveUiType.Start;
				return true;
			}
			if (name == "Resume")
			{
				value = ELiveUiType.Resume;
				return true;
			}
			if (name == "Show")
			{
				value = ELiveUiType.Show;
				return true;
			}
			if (name == "Finish")
			{
				value = ELiveUiType.Finish;
				return true;
			}
			if (name == "Pause")
			{
				value = ELiveUiType.Pause;
				return true;
			}
			if (!(name == "Hide"))
			{
				value = ELiveUiType.Start;
				return false;
			}
			value = ELiveUiType.Hide;
			return true;
		}

		// Token: 0x0600D242 RID: 53826 RVA: 0x001E91F8 File Offset: 0x001E73F8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start",
				"Resume",
				"Show",
				"Finish",
				"Pause",
				"Hide"
			};
		}

		// Token: 0x0600D243 RID: 53827 RVA: 0x001E9230 File Offset: 0x001E7430
		public static ELiveUiType[] GetValues()
		{
			return new ELiveUiType[]
			{
				ELiveUiType.Start,
				ELiveUiType.Resume,
				ELiveUiType.Show,
				ELiveUiType.Finish,
				ELiveUiType.Pause,
				ELiveUiType.Hide
			};
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x001E9243 File Offset: 0x001E7443
		public static string[] GetNames()
		{
			return new string[]
			{
				"Start",
				"Resume",
				"Show",
				"Finish",
				"Pause",
				"Hide"
			};
		}
	}
}
