using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADF RID: 2783
	public static class ESpecialNpcTypeExtensions
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x0009C208 File Offset: 0x0009A408
		public static string ToEnumString(this ESpecialNpcType value)
		{
			string result;
			if (value == ESpecialNpcType.BaseRoleNpc)
			{
				result = "BaseRoleNpc";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0009C230 File Offset: 0x0009A430
		public static ESpecialNpcType FromString(string name)
		{
			ESpecialNpcType result;
			if (!ESpecialNpcTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialNpcType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0009C259 File Offset: 0x0009A459
		public static bool TryFromString(string name, out ESpecialNpcType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialNpcType.BaseRoleNpc;
				return false;
			}
			if (name == "BaseRoleNpc")
			{
				value = ESpecialNpcType.BaseRoleNpc;
				return true;
			}
			value = ESpecialNpcType.BaseRoleNpc;
			return false;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0009C27E File Offset: 0x0009A47E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BaseRoleNpc"
			};
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0009C28E File Offset: 0x0009A48E
		public static ESpecialNpcType[] GetValues()
		{
			return new ESpecialNpcType[1];
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x0009C296 File Offset: 0x0009A496
		public static string[] GetNames()
		{
			return new string[]
			{
				"BaseRoleNpc"
			};
		}
	}
}
