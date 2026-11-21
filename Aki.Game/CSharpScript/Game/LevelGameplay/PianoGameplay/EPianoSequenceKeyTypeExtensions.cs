using System;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2A RID: 23594
	public static class EPianoSequenceKeyTypeExtensions
	{
		// Token: 0x06039F48 RID: 237384 RVA: 0x0104D304 File Offset: 0x0104B504
		public static string ToEnumString(this EPianoSequenceKeyType value)
		{
			string result;
			if (value != EPianoSequenceKeyType.ShowKey)
			{
				if (value != EPianoSequenceKeyType.SeqEnd)
				{
					result = value.ToString();
				}
				else
				{
					result = "SeqEnd";
				}
			}
			else
			{
				result = "ShowKey";
			}
			return result;
		}

		// Token: 0x06039F49 RID: 237385 RVA: 0x0104D33C File Offset: 0x0104B53C
		public static EPianoSequenceKeyType FromString(string name)
		{
			EPianoSequenceKeyType result;
			if (!EPianoSequenceKeyTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPianoSequenceKeyType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039F4A RID: 237386 RVA: 0x0104D365 File Offset: 0x0104B565
		public static bool TryFromString(string name, out EPianoSequenceKeyType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPianoSequenceKeyType.ShowKey;
				return false;
			}
			if (name == "ShowKey")
			{
				value = EPianoSequenceKeyType.ShowKey;
				return true;
			}
			if (!(name == "SeqEnd"))
			{
				value = EPianoSequenceKeyType.ShowKey;
				return false;
			}
			value = EPianoSequenceKeyType.SeqEnd;
			return true;
		}

		// Token: 0x06039F4B RID: 237387 RVA: 0x0104D39E File Offset: 0x0104B59E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ShowKey",
				"SeqEnd"
			};
		}

		// Token: 0x06039F4C RID: 237388 RVA: 0x0104D3B6 File Offset: 0x0104B5B6
		public static EPianoSequenceKeyType[] GetValues()
		{
			return new EPianoSequenceKeyType[]
			{
				EPianoSequenceKeyType.ShowKey,
				EPianoSequenceKeyType.SeqEnd
			};
		}

		// Token: 0x06039F4D RID: 237389 RVA: 0x0104D3C2 File Offset: 0x0104B5C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ShowKey",
				"SeqEnd"
			};
		}
	}
}
