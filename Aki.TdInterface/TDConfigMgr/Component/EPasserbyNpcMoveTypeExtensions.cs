using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7B RID: 2683
	public static class EPasserbyNpcMoveTypeExtensions
	{
		// Token: 0x06003B3C RID: 15164 RVA: 0x00098C40 File Offset: 0x00096E40
		public static string ToEnumString(this EPasserbyNpcMoveType value)
		{
			string result;
			if (value != EPasserbyNpcMoveType.Spline)
			{
				if (value != EPasserbyNpcMoveType.NpcLift)
				{
					result = value.ToString();
				}
				else
				{
					result = "NPCLift";
				}
			}
			else
			{
				result = "Spline";
			}
			return result;
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00098C78 File Offset: 0x00096E78
		public static EPasserbyNpcMoveType FromString(string name)
		{
			EPasserbyNpcMoveType result;
			if (!EPasserbyNpcMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00098CA1 File Offset: 0x00096EA1
		public static bool TryFromString(string name, out EPasserbyNpcMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcMoveType.Spline;
				return false;
			}
			if (name == "Spline")
			{
				value = EPasserbyNpcMoveType.Spline;
				return true;
			}
			if (!(name == "NPCLift"))
			{
				value = EPasserbyNpcMoveType.Spline;
				return false;
			}
			value = EPasserbyNpcMoveType.NpcLift;
			return true;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00098CDA File Offset: 0x00096EDA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline",
				"NPCLift"
			};
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00098CF2 File Offset: 0x00096EF2
		public static EPasserbyNpcMoveType[] GetValues()
		{
			return new EPasserbyNpcMoveType[]
			{
				EPasserbyNpcMoveType.Spline,
				EPasserbyNpcMoveType.NpcLift
			};
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00098CFE File Offset: 0x00096EFE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline",
				"NpcLift"
			};
		}
	}
}
