using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002347 RID: 9031
	public static class EGamepadShakeTypeExtensions
	{
		// Token: 0x0600C53E RID: 50494 RVA: 0x001CC9D4 File Offset: 0x001CABD4
		public static string ToEnumString(this EGamepadShakeType value)
		{
			string result;
			switch (value)
			{
			case EGamepadShakeType.Onetime:
				result = "Onetime";
				break;
			case EGamepadShakeType.Continual:
				result = "Continual";
				break;
			case EGamepadShakeType.Attenuated:
				result = "Attenuated";
				break;
			case EGamepadShakeType.Mp4:
				result = "Mp4";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x001CCA28 File Offset: 0x001CAC28
		public static EGamepadShakeType FromString(string name)
		{
			EGamepadShakeType result;
			if (!EGamepadShakeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x001CCA54 File Offset: 0x001CAC54
		public static bool TryFromString(string name, out EGamepadShakeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGamepadShakeType.Onetime;
				return false;
			}
			if (name == "Onetime")
			{
				value = EGamepadShakeType.Onetime;
				return true;
			}
			if (name == "Continual")
			{
				value = EGamepadShakeType.Continual;
				return true;
			}
			if (name == "Attenuated")
			{
				value = EGamepadShakeType.Attenuated;
				return true;
			}
			if (!(name == "Mp4"))
			{
				value = EGamepadShakeType.Onetime;
				return false;
			}
			value = EGamepadShakeType.Mp4;
			return true;
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x001CCABC File Offset: 0x001CACBC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Onetime",
				"Continual",
				"Attenuated",
				"Mp4"
			};
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x001CCAE4 File Offset: 0x001CACE4
		public static EGamepadShakeType[] GetValues()
		{
			return new EGamepadShakeType[]
			{
				EGamepadShakeType.Onetime,
				EGamepadShakeType.Continual,
				EGamepadShakeType.Attenuated,
				EGamepadShakeType.Mp4
			};
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x001CCAF7 File Offset: 0x001CACF7
		public static string[] GetNames()
		{
			return new string[]
			{
				"Onetime",
				"Continual",
				"Attenuated",
				"Mp4"
			};
		}
	}
}
