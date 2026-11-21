using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025DC RID: 9692
	public static class EJigsawPieceStateExtensions
	{
		// Token: 0x0600D1B8 RID: 53688 RVA: 0x001E6E8C File Offset: 0x001E508C
		public static string ToEnumString(this EJigsawPieceState value)
		{
			string result;
			switch (value)
			{
			case EJigsawPieceState.Disable:
				result = "Disable";
				break;
			case EJigsawPieceState.Correct:
				result = "Correct";
				break;
			case EJigsawPieceState.Incorrect:
				result = "Incorrect";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D1B9 RID: 53689 RVA: 0x001E6ED4 File Offset: 0x001E50D4
		public static EJigsawPieceState FromString(string name)
		{
			EJigsawPieceState result;
			if (!EJigsawPieceStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawPieceState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1BA RID: 53690 RVA: 0x001E6F00 File Offset: 0x001E5100
		public static bool TryFromString(string name, out EJigsawPieceState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EJigsawPieceState.Disable;
				return false;
			}
			if (name == "Disable")
			{
				value = EJigsawPieceState.Disable;
				return true;
			}
			if (name == "Correct")
			{
				value = EJigsawPieceState.Correct;
				return true;
			}
			if (!(name == "Incorrect"))
			{
				value = EJigsawPieceState.Disable;
				return false;
			}
			value = EJigsawPieceState.Incorrect;
			return true;
		}

		// Token: 0x0600D1BB RID: 53691 RVA: 0x001E6F56 File Offset: 0x001E5156
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Disable",
				"Correct",
				"Incorrect"
			};
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x001E6F76 File Offset: 0x001E5176
		public static EJigsawPieceState[] GetValues()
		{
			return new EJigsawPieceState[]
			{
				EJigsawPieceState.Disable,
				EJigsawPieceState.Correct,
				EJigsawPieceState.Incorrect
			};
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x001E6F86 File Offset: 0x001E5186
		public static string[] GetNames()
		{
			return new string[]
			{
				"Disable",
				"Correct",
				"Incorrect"
			};
		}
	}
}
