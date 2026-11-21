using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A95 RID: 2709
	public static class EPickInteractionExtensions
	{
		// Token: 0x06003BB1 RID: 15281 RVA: 0x0009997C File Offset: 0x00097B7C
		public static string ToEnumString(this EPickInteraction value)
		{
			string result;
			if (value == EPickInteraction.ChessmanInteract)
			{
				result = "ChessmanInteract";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x000999A4 File Offset: 0x00097BA4
		public static EPickInteraction FromString(string name)
		{
			EPickInteraction result;
			if (!EPickInteractionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPickInteraction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x000999CD File Offset: 0x00097BCD
		public static bool TryFromString(string name, out EPickInteraction value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPickInteraction.ChessmanInteract;
				return false;
			}
			if (name == "ChessmanInteract")
			{
				value = EPickInteraction.ChessmanInteract;
				return true;
			}
			value = EPickInteraction.ChessmanInteract;
			return false;
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x000999F2 File Offset: 0x00097BF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChessmanInteract"
			};
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x00099A02 File Offset: 0x00097C02
		public static EPickInteraction[] GetValues()
		{
			return new EPickInteraction[1];
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00099A0A File Offset: 0x00097C0A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChessmanInteract"
			};
		}
	}
}
