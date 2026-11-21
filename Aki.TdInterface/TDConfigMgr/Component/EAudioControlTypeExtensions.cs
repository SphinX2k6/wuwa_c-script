using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A3 RID: 2467
	public static class EAudioControlTypeExtensions
	{
		// Token: 0x06003770 RID: 14192 RVA: 0x0008CA84 File Offset: 0x0008AC84
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

		// Token: 0x06003771 RID: 14193 RVA: 0x0008CABC File Offset: 0x0008ACBC
		public static EAudioControlType FromString(string name)
		{
			EAudioControlType result;
			if (!EAudioControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAudioControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x0008CAE5 File Offset: 0x0008ACE5
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

		// Token: 0x06003773 RID: 14195 RVA: 0x0008CB1E File Offset: 0x0008AD1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gramophone",
				"Traffic"
			};
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0008CB36 File Offset: 0x0008AD36
		public static EAudioControlType[] GetValues()
		{
			return new EAudioControlType[]
			{
				EAudioControlType.Gramophone,
				EAudioControlType.Traffic
			};
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x0008CB42 File Offset: 0x0008AD42
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
