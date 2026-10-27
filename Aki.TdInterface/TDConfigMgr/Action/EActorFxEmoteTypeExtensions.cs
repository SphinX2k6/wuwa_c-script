using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228F RID: 8847
	public static class EActorFxEmoteTypeExtensions
	{
		// Token: 0x0600C202 RID: 49666 RVA: 0x001C5350 File Offset: 0x001C3550
		public static string ToEnumString(this EActorFxEmoteType value)
		{
			string result;
			if (value != EActorFxEmoteType.Play)
			{
				if (value != EActorFxEmoteType.Stop)
				{
					result = value.ToString();
				}
				else
				{
					result = "Stop";
				}
			}
			else
			{
				result = "Play";
			}
			return result;
		}

		// Token: 0x0600C203 RID: 49667 RVA: 0x001C5388 File Offset: 0x001C3588
		public static EActorFxEmoteType FromString(string name)
		{
			EActorFxEmoteType result;
			if (!EActorFxEmoteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFxEmoteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x001C53B1 File Offset: 0x001C35B1
		public static bool TryFromString(string name, out EActorFxEmoteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorFxEmoteType.Play;
				return false;
			}
			if (name == "Play")
			{
				value = EActorFxEmoteType.Play;
				return true;
			}
			if (!(name == "Stop"))
			{
				value = EActorFxEmoteType.Play;
				return false;
			}
			value = EActorFxEmoteType.Stop;
			return true;
		}

		// Token: 0x0600C205 RID: 49669 RVA: 0x001C53EA File Offset: 0x001C35EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600C206 RID: 49670 RVA: 0x001C5402 File Offset: 0x001C3602
		public static EActorFxEmoteType[] GetValues()
		{
			return new EActorFxEmoteType[]
			{
				EActorFxEmoteType.Play,
				EActorFxEmoteType.Stop
			};
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x001C540E File Offset: 0x001C360E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}
	}
}
