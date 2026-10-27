using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BB RID: 9147
	public static class EOverrideAudioLevelExtensions
	{
		// Token: 0x0600C748 RID: 51016 RVA: 0x001D2C8C File Offset: 0x001D0E8C
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

		// Token: 0x0600C749 RID: 51017 RVA: 0x001D2CE0 File Offset: 0x001D0EE0
		public static EOverrideAudioLevel FromString(string name)
		{
			EOverrideAudioLevel result;
			if (!EOverrideAudioLevelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOverrideAudioLevel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x001D2D0C File Offset: 0x001D0F0C
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

		// Token: 0x0600C74B RID: 51019 RVA: 0x001D2D74 File Offset: 0x001D0F74
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

		// Token: 0x0600C74C RID: 51020 RVA: 0x001D2D9C File Offset: 0x001D0F9C
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

		// Token: 0x0600C74D RID: 51021 RVA: 0x001D2DAF File Offset: 0x001D0FAF
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
