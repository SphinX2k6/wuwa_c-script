using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E0 RID: 9696
	public static class EKeepMovementStateExtensions
	{
		// Token: 0x0600D1CA RID: 53706 RVA: 0x001E70F8 File Offset: 0x001E52F8
		public static string ToEnumString(this EKeepMovementState value)
		{
			string result;
			if (value != EKeepMovementState.Kite)
			{
				if (value != EKeepMovementState.Soar)
				{
					result = value.ToString();
				}
				else
				{
					result = "Soar";
				}
			}
			else
			{
				result = "Kite";
			}
			return result;
		}

		// Token: 0x0600D1CB RID: 53707 RVA: 0x001E7130 File Offset: 0x001E5330
		public static EKeepMovementState FromString(string name)
		{
			EKeepMovementState result;
			if (!EKeepMovementStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKeepMovementState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1CC RID: 53708 RVA: 0x001E7159 File Offset: 0x001E5359
		public static bool TryFromString(string name, out EKeepMovementState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EKeepMovementState.Kite;
				return false;
			}
			if (name == "Kite")
			{
				value = EKeepMovementState.Kite;
				return true;
			}
			if (!(name == "Soar"))
			{
				value = EKeepMovementState.Kite;
				return false;
			}
			value = EKeepMovementState.Soar;
			return true;
		}

		// Token: 0x0600D1CD RID: 53709 RVA: 0x001E7192 File Offset: 0x001E5392
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Kite",
				"Soar"
			};
		}

		// Token: 0x0600D1CE RID: 53710 RVA: 0x001E71AA File Offset: 0x001E53AA
		public static EKeepMovementState[] GetValues()
		{
			return new EKeepMovementState[]
			{
				EKeepMovementState.Kite,
				EKeepMovementState.Soar
			};
		}

		// Token: 0x0600D1CF RID: 53711 RVA: 0x001E71B6 File Offset: 0x001E53B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Kite",
				"Soar"
			};
		}
	}
}
