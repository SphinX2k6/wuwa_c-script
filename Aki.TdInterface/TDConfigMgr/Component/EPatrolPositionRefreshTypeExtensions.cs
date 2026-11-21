using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8D RID: 2701
	public static class EPatrolPositionRefreshTypeExtensions
	{
		// Token: 0x06003B8D RID: 15245 RVA: 0x000994DC File Offset: 0x000976DC
		public static string ToEnumString(this EPatrolPositionRefreshType value)
		{
			string result;
			if (value == EPatrolPositionRefreshType.NearestSplinePointToPlayer)
			{
				result = "NearestSplinePointToPlayer";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00099504 File Offset: 0x00097704
		public static EPatrolPositionRefreshType FromString(string name)
		{
			EPatrolPositionRefreshType result;
			if (!EPatrolPositionRefreshTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPatrolPositionRefreshType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x0009952D File Offset: 0x0009772D
		public static bool TryFromString(string name, out EPatrolPositionRefreshType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPatrolPositionRefreshType.NearestSplinePointToPlayer;
				return false;
			}
			if (name == "NearestSplinePointToPlayer")
			{
				value = EPatrolPositionRefreshType.NearestSplinePointToPlayer;
				return true;
			}
			value = EPatrolPositionRefreshType.NearestSplinePointToPlayer;
			return false;
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00099552 File Offset: 0x00097752
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NearestSplinePointToPlayer"
			};
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00099562 File Offset: 0x00097762
		public static EPatrolPositionRefreshType[] GetValues()
		{
			return new EPatrolPositionRefreshType[1];
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x0009956A File Offset: 0x0009776A
		public static string[] GetNames()
		{
			return new string[]
			{
				"NearestSplinePointToPlayer"
			};
		}
	}
}
