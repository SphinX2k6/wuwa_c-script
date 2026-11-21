using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002606 RID: 9734
	public static class EMapMarkStateExtensions
	{
		// Token: 0x0600D275 RID: 53877 RVA: 0x001E9820 File Offset: 0x001E7A20
		public static string ToEnumString(this EMapMarkState value)
		{
			string result;
			switch (value)
			{
			case EMapMarkState.Show:
				result = "Show";
				break;
			case EMapMarkState.Hide:
				result = "Hide";
				break;
			case EMapMarkState.Disable:
				result = "Disable";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x001E9868 File Offset: 0x001E7A68
		public static EMapMarkState FromString(string name)
		{
			EMapMarkState result;
			if (!EMapMarkStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapMarkState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x001E9894 File Offset: 0x001E7A94
		public static bool TryFromString(string name, out EMapMarkState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMapMarkState.Show;
				return false;
			}
			if (name == "Show")
			{
				value = EMapMarkState.Show;
				return true;
			}
			if (name == "Hide")
			{
				value = EMapMarkState.Hide;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EMapMarkState.Show;
				return false;
			}
			value = EMapMarkState.Disable;
			return true;
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x001E98EA File Offset: 0x001E7AEA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"Disable"
			};
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x001E990A File Offset: 0x001E7B0A
		public static EMapMarkState[] GetValues()
		{
			return new EMapMarkState[]
			{
				EMapMarkState.Show,
				EMapMarkState.Hide,
				EMapMarkState.Disable
			};
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x001E991A File Offset: 0x001E7B1A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Show",
				"Hide",
				"Disable"
			};
		}
	}
}
