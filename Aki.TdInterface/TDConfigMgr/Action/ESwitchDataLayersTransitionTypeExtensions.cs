using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E2 RID: 9954
	public static class ESwitchDataLayersTransitionTypeExtensions
	{
		// Token: 0x0600D653 RID: 54867 RVA: 0x001F2400 File Offset: 0x001F0600
		public static string ToEnumString(this ESwitchDataLayersTransitionType value)
		{
			string result;
			if (value == ESwitchDataLayersTransitionType.Sequence)
			{
				result = "Sequence";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x001F2428 File Offset: 0x001F0628
		public static ESwitchDataLayersTransitionType FromString(string name)
		{
			ESwitchDataLayersTransitionType result;
			if (!ESwitchDataLayersTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchDataLayersTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x001F2451 File Offset: 0x001F0651
		public static bool TryFromString(string name, out ESwitchDataLayersTransitionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwitchDataLayersTransitionType.Sequence;
				return false;
			}
			if (name == "Sequence")
			{
				value = ESwitchDataLayersTransitionType.Sequence;
				return true;
			}
			value = ESwitchDataLayersTransitionType.Sequence;
			return false;
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x001F2476 File Offset: 0x001F0676
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Sequence"
			};
		}

		// Token: 0x0600D657 RID: 54871 RVA: 0x001F2486 File Offset: 0x001F0686
		public static ESwitchDataLayersTransitionType[] GetValues()
		{
			return new ESwitchDataLayersTransitionType[1];
		}

		// Token: 0x0600D658 RID: 54872 RVA: 0x001F248E File Offset: 0x001F068E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Sequence"
			};
		}
	}
}
