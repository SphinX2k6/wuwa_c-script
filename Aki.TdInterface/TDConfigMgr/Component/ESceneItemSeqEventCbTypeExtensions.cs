using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC7 RID: 2759
	public static class ESceneItemSeqEventCbTypeExtensions
	{
		// Token: 0x06003C92 RID: 15506 RVA: 0x0009B470 File Offset: 0x00099670
		public static string ToEnumString(this ESceneItemSeqEventCbType value)
		{
			string result;
			if (value != ESceneItemSeqEventCbType.ANS)
			{
				if (value != ESceneItemSeqEventCbType.AN)
				{
					result = value.ToString();
				}
				else
				{
					result = "AN";
				}
			}
			else
			{
				result = "ANS";
			}
			return result;
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x0009B4A8 File Offset: 0x000996A8
		public static ESceneItemSeqEventCbType FromString(string name)
		{
			ESceneItemSeqEventCbType result;
			if (!ESceneItemSeqEventCbTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemSeqEventCbType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0009B4D1 File Offset: 0x000996D1
		public static bool TryFromString(string name, out ESceneItemSeqEventCbType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneItemSeqEventCbType.ANS;
				return false;
			}
			if (name == "ANS")
			{
				value = ESceneItemSeqEventCbType.ANS;
				return true;
			}
			if (!(name == "AN"))
			{
				value = ESceneItemSeqEventCbType.ANS;
				return false;
			}
			value = ESceneItemSeqEventCbType.AN;
			return true;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0009B50A File Offset: 0x0009970A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ANS",
				"AN"
			};
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0009B522 File Offset: 0x00099722
		public static ESceneItemSeqEventCbType[] GetValues()
		{
			return new ESceneItemSeqEventCbType[]
			{
				ESceneItemSeqEventCbType.ANS,
				ESceneItemSeqEventCbType.AN
			};
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0009B52E File Offset: 0x0009972E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ANS",
				"AN"
			};
		}
	}
}
