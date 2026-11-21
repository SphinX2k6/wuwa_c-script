using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A87 RID: 2695
	public static class EPathDrivenActorSpawnTypeExtensions
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x000991D8 File Offset: 0x000973D8
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

		// Token: 0x06003B73 RID: 15219 RVA: 0x00099200 File Offset: 0x00097400
		public static EPathDrivenActorSpawnType FromString(string name)
		{
			EPathDrivenActorSpawnType result;
			if (!EPathDrivenActorSpawnTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorSpawnType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00099229 File Offset: 0x00097429
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

		// Token: 0x06003B75 RID: 15221 RVA: 0x0009924E File Offset: 0x0009744E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"IntervalSplineSpawn"
			};
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x0009925E File Offset: 0x0009745E
		public static EPathDrivenActorSpawnType[] GetValues()
		{
			return new EPathDrivenActorSpawnType[1];
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00099266 File Offset: 0x00097466
		public static string[] GetNames()
		{
			return new string[]
			{
				"IntervalSplineSpawn"
			};
		}
	}
}
