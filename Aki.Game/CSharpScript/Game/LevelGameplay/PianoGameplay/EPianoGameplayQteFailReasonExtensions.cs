using System;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2E RID: 23598
	public static class EPianoGameplayQteFailReasonExtensions
	{
		// Token: 0x06039F5A RID: 237402 RVA: 0x0104D68C File Offset: 0x0104B88C
		public static string ToEnumString(this EPianoGameplayQteFailReason value)
		{
			string result;
			if (value != EPianoGameplayQteFailReason.Timeout)
			{
				if (value != EPianoGameplayQteFailReason.WrongKey)
				{
					result = value.ToString();
				}
				else
				{
					result = "按下按键顺序错误";
				}
			}
			else
			{
				result = "超时";
			}
			return result;
		}

		// Token: 0x06039F5B RID: 237403 RVA: 0x0104D6C4 File Offset: 0x0104B8C4
		public static EPianoGameplayQteFailReason FromString(string name)
		{
			EPianoGameplayQteFailReason result;
			if (!EPianoGameplayQteFailReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPianoGameplayQteFailReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039F5C RID: 237404 RVA: 0x0104D6ED File Offset: 0x0104B8ED
		public static bool TryFromString(string name, out EPianoGameplayQteFailReason value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPianoGameplayQteFailReason.Timeout;
				return false;
			}
			if (name == "超时")
			{
				value = EPianoGameplayQteFailReason.Timeout;
				return true;
			}
			if (!(name == "按下按键顺序错误"))
			{
				value = EPianoGameplayQteFailReason.Timeout;
				return false;
			}
			value = EPianoGameplayQteFailReason.WrongKey;
			return true;
		}

		// Token: 0x06039F5D RID: 237405 RVA: 0x0104D726 File Offset: 0x0104B926
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"超时",
				"按下按键顺序错误"
			};
		}

		// Token: 0x06039F5E RID: 237406 RVA: 0x0104D73E File Offset: 0x0104B93E
		public static EPianoGameplayQteFailReason[] GetValues()
		{
			return new EPianoGameplayQteFailReason[]
			{
				EPianoGameplayQteFailReason.Timeout,
				EPianoGameplayQteFailReason.WrongKey
			};
		}

		// Token: 0x06039F5F RID: 237407 RVA: 0x0104D74A File Offset: 0x0104B94A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Timeout",
				"WrongKey"
			};
		}
	}
}
