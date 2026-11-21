using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A37 RID: 2615
	public static class EJigsawCompleteConditionExtensions
	{
		// Token: 0x06003A0A RID: 14858 RVA: 0x00096008 File Offset: 0x00094208
		public static string ToEnumString(this EJigsawCompleteCondition value)
		{
			string result;
			switch (value)
			{
			case EJigsawCompleteCondition.ActivateAllCorrectPiece:
				result = "ActivateAllCorrectPiece";
				break;
			case EJigsawCompleteCondition.ActivateSpecifiedPiece:
				result = "ActivateSpecifiedPiece";
				break;
			case EJigsawCompleteCondition.PutInTheSpecifiedPiece:
				result = "PutInTheSpecifiedPiece";
				break;
			case EJigsawCompleteCondition.ActivateRenjuPiece:
				result = "ActivateRenjuPiece";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0009605C File Offset: 0x0009425C
		public static EJigsawCompleteCondition FromString(string name)
		{
			EJigsawCompleteCondition result;
			if (!EJigsawCompleteConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawCompleteCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00096088 File Offset: 0x00094288
		public static bool TryFromString(string name, out EJigsawCompleteCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EJigsawCompleteCondition.ActivateAllCorrectPiece;
				return false;
			}
			if (name == "ActivateAllCorrectPiece")
			{
				value = EJigsawCompleteCondition.ActivateAllCorrectPiece;
				return true;
			}
			if (name == "ActivateSpecifiedPiece")
			{
				value = EJigsawCompleteCondition.ActivateSpecifiedPiece;
				return true;
			}
			if (name == "PutInTheSpecifiedPiece")
			{
				value = EJigsawCompleteCondition.PutInTheSpecifiedPiece;
				return true;
			}
			if (!(name == "ActivateRenjuPiece"))
			{
				value = EJigsawCompleteCondition.ActivateAllCorrectPiece;
				return false;
			}
			value = EJigsawCompleteCondition.ActivateRenjuPiece;
			return true;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x000960F0 File Offset: 0x000942F0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ActivateAllCorrectPiece",
				"ActivateSpecifiedPiece",
				"PutInTheSpecifiedPiece",
				"ActivateRenjuPiece"
			};
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00096118 File Offset: 0x00094318
		public static EJigsawCompleteCondition[] GetValues()
		{
			return new EJigsawCompleteCondition[]
			{
				EJigsawCompleteCondition.ActivateAllCorrectPiece,
				EJigsawCompleteCondition.ActivateSpecifiedPiece,
				EJigsawCompleteCondition.PutInTheSpecifiedPiece,
				EJigsawCompleteCondition.ActivateRenjuPiece
			};
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x0009612B File Offset: 0x0009432B
		public static string[] GetNames()
		{
			return new string[]
			{
				"ActivateAllCorrectPiece",
				"ActivateSpecifiedPiece",
				"PutInTheSpecifiedPiece",
				"ActivateRenjuPiece"
			};
		}
	}
}
