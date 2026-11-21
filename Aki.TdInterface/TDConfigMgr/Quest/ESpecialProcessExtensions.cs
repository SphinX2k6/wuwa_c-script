using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D2 RID: 5074
	public static class ESpecialProcessExtensions
	{
		// Token: 0x0600718B RID: 29067 RVA: 0x0010F2F4 File Offset: 0x0010D4F4
		public static string ToEnumString(this ESpecialProcess value)
		{
			string result;
			if (value == ESpecialProcess.LowMemorySceneSwitch)
			{
				result = "LowMemorySceneSwitch";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x0010F31C File Offset: 0x0010D51C
		public static ESpecialProcess FromString(string name)
		{
			ESpecialProcess result;
			if (!ESpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x0010F345 File Offset: 0x0010D545
		public static bool TryFromString(string name, out ESpecialProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialProcess.LowMemorySceneSwitch;
				return false;
			}
			if (name == "LowMemorySceneSwitch")
			{
				value = ESpecialProcess.LowMemorySceneSwitch;
				return true;
			}
			value = ESpecialProcess.LowMemorySceneSwitch;
			return false;
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x0010F36A File Offset: 0x0010D56A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LowMemorySceneSwitch"
			};
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x0010F37A File Offset: 0x0010D57A
		public static ESpecialProcess[] GetValues()
		{
			return new ESpecialProcess[1];
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x0010F382 File Offset: 0x0010D582
		public static string[] GetNames()
		{
			return new string[]
			{
				"LowMemorySceneSwitch"
			};
		}
	}
}
