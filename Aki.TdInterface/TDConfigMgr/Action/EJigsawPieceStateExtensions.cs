using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002367 RID: 9063
	public static class EJigsawPieceStateExtensions
	{
		// Token: 0x0600C5CE RID: 50638 RVA: 0x001CEBAC File Offset: 0x001CCDAC
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

		// Token: 0x0600C5CF RID: 50639 RVA: 0x001CEBF4 File Offset: 0x001CCDF4
		public static EJigsawPieceState FromString(string name)
		{
			EJigsawPieceState result;
			if (!EJigsawPieceStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawPieceState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x001CEC20 File Offset: 0x001CCE20
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

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x001CEC76 File Offset: 0x001CCE76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Disable",
				"Correct",
				"Incorrect"
			};
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x001CEC96 File Offset: 0x001CCE96
		public static EJigsawPieceState[] GetValues()
		{
			return new EJigsawPieceState[]
			{
				EJigsawPieceState.Disable,
				EJigsawPieceState.Correct,
				EJigsawPieceState.Incorrect
			};
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x001CECA6 File Offset: 0x001CCEA6
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
