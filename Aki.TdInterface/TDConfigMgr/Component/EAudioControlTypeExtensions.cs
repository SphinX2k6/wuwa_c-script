using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FA RID: 2298
	public static class EAudioControlTypeExtensions
	{
		// Token: 0x06003416 RID: 13334 RVA: 0x00085214 File Offset: 0x00083414
		public static string ToEnumString(this EAudioControlType value)
		{
			string result;
			if (value != EAudioControlType.Gramophone)
			{
				if (value != EAudioControlType.Traffic)
				{
					result = value.ToString();
				}
				else
				{
					result = "Traffic";
				}
			}
			else
			{
				result = "Gramophone";
			}
			return result;
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0008524C File Offset: 0x0008344C
		public static EAudioControlType FromString(string name)
		{
			EAudioControlType result;
			if (!EAudioControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00085275 File Offset: 0x00083475
		public static bool TryFromString(string name, out EAudioControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAudioControlType.Gramophone;
				return false;
			}
			if (name == "Gramophone")
			{
				value = EAudioControlType.Gramophone;
				return true;
			}
			if (!(name == "Traffic"))
			{
				value = EAudioControlType.Gramophone;
				return false;
			}
			value = EAudioControlType.Traffic;
			return true;
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000852AE File Offset: 0x000834AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gramophone",
				"Traffic"
			};
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000852C6 File Offset: 0x000834C6
		public static EAudioControlType[] GetValues()
		{
			return new EAudioControlType[]
			{
				EAudioControlType.Gramophone,
				EAudioControlType.Traffic
			};
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000852D2 File Offset: 0x000834D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Gramophone",
				"Traffic"
			};
		}
	}
}
