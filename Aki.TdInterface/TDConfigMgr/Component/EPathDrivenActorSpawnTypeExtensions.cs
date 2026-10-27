using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C6 RID: 2502
	public static class EPathDrivenActorSpawnTypeExtensions
	{
		// Token: 0x060037AC RID: 14252 RVA: 0x00090B08 File Offset: 0x0008ED08
		public static string ToEnumString(this EPathDrivenActorSpawnType value)
		{
			string result;
			if (value == EPathDrivenActorSpawnType.IntervalSplineSpawn)
			{
				result = "IntervalSplineSpawn";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00090B30 File Offset: 0x0008ED30
		public static EPathDrivenActorSpawnType FromString(string name)
		{
			EPathDrivenActorSpawnType result;
			if (!EPathDrivenActorSpawnTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorSpawnType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00090B59 File Offset: 0x0008ED59
		public static bool TryFromString(string name, out EPathDrivenActorSpawnType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPathDrivenActorSpawnType.IntervalSplineSpawn;
				return false;
			}
			if (name == "IntervalSplineSpawn")
			{
				value = EPathDrivenActorSpawnType.IntervalSplineSpawn;
				return true;
			}
			value = EPathDrivenActorSpawnType.IntervalSplineSpawn;
			return false;
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00090B7E File Offset: 0x0008ED7E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"IntervalSplineSpawn"
			};
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00090B8E File Offset: 0x0008ED8E
		public static EPathDrivenActorSpawnType[] GetValues()
		{
			return new EPathDrivenActorSpawnType[1];
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00090B96 File Offset: 0x0008ED96
		public static string[] GetNames()
		{
			return new string[]
			{
				"IntervalSplineSpawn"
			};
		}
	}
}
