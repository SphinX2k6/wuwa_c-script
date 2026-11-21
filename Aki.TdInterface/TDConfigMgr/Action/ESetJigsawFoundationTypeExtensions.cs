using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A6 RID: 9894
	public static class ESetJigsawFoundationTypeExtensions
	{
		// Token: 0x0600D545 RID: 54597 RVA: 0x001EF7DC File Offset: 0x001ED9DC
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

		// Token: 0x0600D546 RID: 54598 RVA: 0x001EF804 File Offset: 0x001EDA04
		public static ESetJigsawFoundationType FromString(string name)
		{
			ESetJigsawFoundationType result;
			if (!ESetJigsawFoundationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetJigsawFoundationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D547 RID: 54599 RVA: 0x001EF82D File Offset: 0x001EDA2D
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

		// Token: 0x0600D548 RID: 54600 RVA: 0x001EF852 File Offset: 0x001EDA52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetPieceState"
			};
		}

		// Token: 0x0600D549 RID: 54601 RVA: 0x001EF862 File Offset: 0x001EDA62
		public static ESetJigsawFoundationType[] GetValues()
		{
			return new ESetJigsawFoundationType[1];
		}

		// Token: 0x0600D54A RID: 54602 RVA: 0x001EF86A File Offset: 0x001EDA6A
		public static string[] GetNames()
		{
			return new string[]
			{
				"SetPieceState"
			};
		}
	}
}
