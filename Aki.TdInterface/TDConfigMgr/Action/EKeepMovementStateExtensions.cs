using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236B RID: 9067
	public static class EKeepMovementStateExtensions
	{
		// Token: 0x0600C5E0 RID: 50656 RVA: 0x001CEE18 File Offset: 0x001CD018
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

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x001CEE50 File Offset: 0x001CD050
		public static EKeepMovementState FromString(string name)
		{
			EKeepMovementState result;
			if (!EKeepMovementStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKeepMovementState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x001CEE79 File Offset: 0x001CD079
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

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x001CEEB2 File Offset: 0x001CD0B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Kite",
				"Soar"
			};
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x001CEECA File Offset: 0x001CD0CA
		public static EKeepMovementState[] GetValues()
		{
			return new EKeepMovementState[]
			{
				EKeepMovementState.Kite,
				EKeepMovementState.Soar
			};
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x001CEED6 File Offset: 0x001CD0D6
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
