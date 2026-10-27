using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D0 RID: 2512
	public static class EPickInteractionExtensions
	{
		// Token: 0x060037D9 RID: 14297 RVA: 0x000910BC File Offset: 0x0008F2BC
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

		// Token: 0x060037DA RID: 14298 RVA: 0x000910E4 File Offset: 0x0008F2E4
		public static EPickInteraction FromString(string name)
		{
			EPickInteraction result;
			if (!EPickInteractionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPickInteraction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x0009110D File Offset: 0x0008F30D
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

		// Token: 0x060037DC RID: 14300 RVA: 0x00091132 File Offset: 0x0008F332
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChessmanInteract"
			};
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00091142 File Offset: 0x0008F342
		public static EPickInteraction[] GetValues()
		{
			return new EPickInteraction[1];
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x0009114A File Offset: 0x0008F34A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChessmanInteract"
			};
		}
	}
}
