using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000984 RID: 2436
	public static class EJigsawCompleteConditionExtensions
	{
		// Token: 0x06003683 RID: 13955 RVA: 0x0008E09C File Offset: 0x0008C29C
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

		// Token: 0x06003684 RID: 13956 RVA: 0x0008E0F0 File Offset: 0x0008C2F0
		public static EJigsawCompleteCondition FromString(string name)
		{
			EJigsawCompleteCondition result;
			if (!EJigsawCompleteConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EJigsawCompleteCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x0008E11C File Offset: 0x0008C31C
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

		// Token: 0x06003686 RID: 13958 RVA: 0x0008E184 File Offset: 0x0008C384
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

		// Token: 0x06003687 RID: 13959 RVA: 0x0008E1AC File Offset: 0x0008C3AC
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

		// Token: 0x06003688 RID: 13960 RVA: 0x0008E1BF File Offset: 0x0008C3BF
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
