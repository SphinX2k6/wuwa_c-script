using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EA RID: 2538
	public static class ERangeConstraintExtensions
	{
		// Token: 0x0600384E RID: 14414 RVA: 0x00091E58 File Offset: 0x00090058
		public static string ToEnumString(this ERangeConstraint value)
		{
			string result;
			if (value == ERangeConstraint.SearchSpawnMonsterPoint)
			{
				result = "SearchSpawnMonsterPoint";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00091E80 File Offset: 0x00090080
		public static ERangeConstraint FromString(string name)
		{
			ERangeConstraint result;
			if (!ERangeConstraintExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERangeConstraint 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00091EA9 File Offset: 0x000900A9
		public static bool TryFromString(string name, out ERangeConstraint value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERangeConstraint.SearchSpawnMonsterPoint;
				return false;
			}
			if (name == "SearchSpawnMonsterPoint")
			{
				value = ERangeConstraint.SearchSpawnMonsterPoint;
				return true;
			}
			value = ERangeConstraint.SearchSpawnMonsterPoint;
			return false;
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00091ECE File Offset: 0x000900CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SearchSpawnMonsterPoint"
			};
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00091EDE File Offset: 0x000900DE
		public static ERangeConstraint[] GetValues()
		{
			return new ERangeConstraint[1];
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00091EE6 File Offset: 0x000900E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SearchSpawnMonsterPoint"
			};
		}
	}
}
