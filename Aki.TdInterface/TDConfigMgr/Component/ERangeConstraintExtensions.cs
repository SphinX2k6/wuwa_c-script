using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAF RID: 2735
	public static class ERangeConstraintExtensions
	{
		// Token: 0x06003C26 RID: 15398 RVA: 0x0009A718 File Offset: 0x00098918
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

		// Token: 0x06003C27 RID: 15399 RVA: 0x0009A740 File Offset: 0x00098940
		public static ERangeConstraint FromString(string name)
		{
			ERangeConstraint result;
			if (!ERangeConstraintExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERangeConstraint 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0009A769 File Offset: 0x00098969
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

		// Token: 0x06003C29 RID: 15401 RVA: 0x0009A78E File Offset: 0x0009898E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SearchSpawnMonsterPoint"
			};
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0009A79E File Offset: 0x0009899E
		public static ERangeConstraint[] GetValues()
		{
			return new ERangeConstraint[1];
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0009A7A6 File Offset: 0x000989A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SearchSpawnMonsterPoint"
			};
		}
	}
}
