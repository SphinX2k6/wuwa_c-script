using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264E RID: 9806
	public static class EOverrideAudioLevelExtensions
	{
		// Token: 0x0600D3B9 RID: 54201 RVA: 0x001EC248 File Offset: 0x001EA448
		public static string ToEnumString(this EOverrideAudioLevel value)
		{
			string result;
			switch (value)
			{
			case EOverrideAudioLevel.LevelA:
				result = "LevelA";
				break;
			case EOverrideAudioLevel.LevelB:
				result = "LevelB";
				break;
			case EOverrideAudioLevel.LevelC:
				result = "LevelC";
				break;
			case EOverrideAudioLevel.LevelD:
				result = "LevelD";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x001EC29C File Offset: 0x001EA49C
		public static EOverrideAudioLevel FromString(string name)
		{
			EOverrideAudioLevel result;
			if (!EOverrideAudioLevelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOverrideAudioLevel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x001EC2C8 File Offset: 0x001EA4C8
		public static bool TryFromString(string name, out EOverrideAudioLevel value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOverrideAudioLevel.LevelA;
				return false;
			}
			if (name == "LevelA")
			{
				value = EOverrideAudioLevel.LevelA;
				return true;
			}
			if (name == "LevelB")
			{
				value = EOverrideAudioLevel.LevelB;
				return true;
			}
			if (name == "LevelC")
			{
				value = EOverrideAudioLevel.LevelC;
				return true;
			}
			if (!(name == "LevelD"))
			{
				value = EOverrideAudioLevel.LevelA;
				return false;
			}
			value = EOverrideAudioLevel.LevelD;
			return true;
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x001EC330 File Offset: 0x001EA530
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD"
			};
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x001EC358 File Offset: 0x001EA558
		public static EOverrideAudioLevel[] GetValues()
		{
			return new EOverrideAudioLevel[]
			{
				EOverrideAudioLevel.LevelA,
				EOverrideAudioLevel.LevelB,
				EOverrideAudioLevel.LevelC,
				EOverrideAudioLevel.LevelD
			};
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x001EC36B File Offset: 0x001EA56B
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelA",
				"LevelB",
				"LevelC",
				"LevelD"
			};
		}
	}
}
