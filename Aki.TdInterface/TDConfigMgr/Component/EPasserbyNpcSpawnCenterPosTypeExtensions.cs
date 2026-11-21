using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7F RID: 2687
	public static class EPasserbyNpcSpawnCenterPosTypeExtensions
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x00098E30 File Offset: 0x00097030
		public static string ToEnumString(this EPasserbyNpcSpawnCenterPosType value)
		{
			string result;
			if (value == EPasserbyNpcSpawnCenterPosType.Self)
			{
				result = "Self";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00098E58 File Offset: 0x00097058
		public static EPasserbyNpcSpawnCenterPosType FromString(string name)
		{
			EPasserbyNpcSpawnCenterPosType result;
			if (!EPasserbyNpcSpawnCenterPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcSpawnCenterPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00098E81 File Offset: 0x00097081
		public static bool TryFromString(string name, out EPasserbyNpcSpawnCenterPosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcSpawnCenterPosType.Self;
				return false;
			}
			if (name == "Self")
			{
				value = EPasserbyNpcSpawnCenterPosType.Self;
				return true;
			}
			value = EPasserbyNpcSpawnCenterPosType.Self;
			return false;
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00098EA6 File Offset: 0x000970A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self"
			};
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00098EB6 File Offset: 0x000970B6
		public static EPasserbyNpcSpawnCenterPosType[] GetValues()
		{
			return new EPasserbyNpcSpawnCenterPosType[1];
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00098EBE File Offset: 0x000970BE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Self"
			};
		}
	}
}
