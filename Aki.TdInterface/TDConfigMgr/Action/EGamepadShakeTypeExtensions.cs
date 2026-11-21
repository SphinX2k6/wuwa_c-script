using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BA RID: 9658
	public static class EGamepadShakeTypeExtensions
	{
		// Token: 0x0600D11F RID: 53535 RVA: 0x001E4BA0 File Offset: 0x001E2DA0
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

		// Token: 0x0600D120 RID: 53536 RVA: 0x001E4BF4 File Offset: 0x001E2DF4
		public static EGamepadShakeType FromString(string name)
		{
			EGamepadShakeType result;
			if (!EGamepadShakeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGamepadShakeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x001E4C20 File Offset: 0x001E2E20
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

		// Token: 0x0600D122 RID: 53538 RVA: 0x001E4C88 File Offset: 0x001E2E88
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

		// Token: 0x0600D123 RID: 53539 RVA: 0x001E4CB0 File Offset: 0x001E2EB0
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

		// Token: 0x0600D124 RID: 53540 RVA: 0x001E4CC3 File Offset: 0x001E2EC3
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
