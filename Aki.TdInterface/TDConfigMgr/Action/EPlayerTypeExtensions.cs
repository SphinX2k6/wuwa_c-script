using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D3 RID: 9171
	public static class EPlayerTypeExtensions
	{
		// Token: 0x0600C7B4 RID: 51124 RVA: 0x001D3C34 File Offset: 0x001D1E34
		public static string ToEnumString(this EPlayerType value)
		{
			string result;
			switch (value)
			{
			case EPlayerType.P1:
				result = "P1";
				break;
			case EPlayerType.P2:
				result = "P2";
				break;
			case EPlayerType.P3:
				result = "P3";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x001D3C7C File Offset: 0x001D1E7C
		public static EPlayerType FromString(string name)
		{
			EPlayerType result;
			if (!EPlayerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x001D3CA8 File Offset: 0x001D1EA8
		public static bool TryFromString(string name, out EPlayerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerType.P1;
				return false;
			}
			if (name == "P1")
			{
				value = EPlayerType.P1;
				return true;
			}
			if (name == "P2")
			{
				value = EPlayerType.P2;
				return true;
			}
			if (!(name == "P3"))
			{
				value = EPlayerType.P1;
				return false;
			}
			value = EPlayerType.P3;
			return true;
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x001D3CFE File Offset: 0x001D1EFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"P1",
				"P2",
				"P3"
			};
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x001D3D1E File Offset: 0x001D1F1E
		public static EPlayerType[] GetValues()
		{
			return new EPlayerType[]
			{
				EPlayerType.P1,
				EPlayerType.P2,
				EPlayerType.P3
			};
		}

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x001D3D2E File Offset: 0x001D1F2E
		public static string[] GetNames()
		{
			return new string[]
			{
				"P1",
				"P2",
				"P3"
			};
		}
	}
}
