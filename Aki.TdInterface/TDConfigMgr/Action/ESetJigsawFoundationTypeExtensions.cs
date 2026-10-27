using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002407 RID: 9223
	public static class ESetJigsawFoundationTypeExtensions
	{
		// Token: 0x0600C89E RID: 51358 RVA: 0x001D5BE0 File Offset: 0x001D3DE0
		public static string ToEnumString(this ESetJigsawFoundationType value)
		{
			string result;
			if (value == ESetJigsawFoundationType.SetPieceState)
			{
				result = "SetPieceState";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x001D5C08 File Offset: 0x001D3E08
		public static ESetJigsawFoundationType FromString(string name)
		{
			ESetJigsawFoundationType result;
			if (!ESetJigsawFoundationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetJigsawFoundationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x001D5C31 File Offset: 0x001D3E31
		public static bool TryFromString(string name, out ESetJigsawFoundationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetJigsawFoundationType.SetPieceState;
				return false;
			}
			if (name == "SetPieceState")
			{
				value = ESetJigsawFoundationType.SetPieceState;
				return true;
			}
			value = ESetJigsawFoundationType.SetPieceState;
			return false;
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x001D5C56 File Offset: 0x001D3E56
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetPieceState"
			};
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x001D5C66 File Offset: 0x001D3E66
		public static ESetJigsawFoundationType[] GetValues()
		{
			return new ESetJigsawFoundationType[1];
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x001D5C6E File Offset: 0x001D3E6E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SetPieceState"
			};
		}
	}
}
