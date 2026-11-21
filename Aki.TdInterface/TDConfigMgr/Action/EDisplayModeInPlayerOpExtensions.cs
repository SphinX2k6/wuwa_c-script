using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002572 RID: 9586
	public static class EDisplayModeInPlayerOpExtensions
	{
		// Token: 0x0600CFDB RID: 53211 RVA: 0x001E1EAC File Offset: 0x001E00AC
		public static string ToEnumString(this EDisplayModeInPlayerOp value)
		{
			string result;
			if (value != EDisplayModeInPlayerOp.ShowUi)
			{
				if (value != EDisplayModeInPlayerOp.HideUi)
				{
					result = value.ToString();
				}
				else
				{
					result = "HideUi";
				}
			}
			else
			{
				result = "ShowUi";
			}
			return result;
		}

		// Token: 0x0600CFDC RID: 53212 RVA: 0x001E1EE4 File Offset: 0x001E00E4
		public static EDisplayModeInPlayerOp FromString(string name)
		{
			EDisplayModeInPlayerOp result;
			if (!EDisplayModeInPlayerOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDisplayModeInPlayerOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x001E1F0D File Offset: 0x001E010D
		public static bool TryFromString(string name, out EDisplayModeInPlayerOp value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return false;
			}
			if (name == "ShowUi")
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return true;
			}
			if (!(name == "HideUi"))
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return false;
			}
			value = EDisplayModeInPlayerOp.HideUi;
			return true;
		}

		// Token: 0x0600CFDE RID: 53214 RVA: 0x001E1F46 File Offset: 0x001E0146
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ShowUi",
				"HideUi"
			};
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x001E1F5E File Offset: 0x001E015E
		public static EDisplayModeInPlayerOp[] GetValues()
		{
			return new EDisplayModeInPlayerOp[]
			{
				EDisplayModeInPlayerOp.ShowUi,
				EDisplayModeInPlayerOp.HideUi
			};
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x001E1F6A File Offset: 0x001E016A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ShowUi",
				"HideUi"
			};
		}
	}
}
