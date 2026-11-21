using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A83 RID: 2691
	public static class EPathDrivenActorInitialSpawnHandleTypeExtensions
	{
		// Token: 0x06003B60 RID: 15200 RVA: 0x00099020 File Offset: 0x00097220
		public static string ToEnumString(this EPathDrivenActorInitialSpawnHandleType value)
		{
			string result;
			if (value == EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation)
			{
				result = "WaterBoxStagnation";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00099048 File Offset: 0x00097248
		public static EPathDrivenActorInitialSpawnHandleType FromString(string name)
		{
			EPathDrivenActorInitialSpawnHandleType result;
			if (!EPathDrivenActorInitialSpawnHandleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorInitialSpawnHandleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00099071 File Offset: 0x00097271
		public static bool TryFromString(string name, out EPathDrivenActorInitialSpawnHandleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
				return false;
			}
			if (name == "WaterBoxStagnation")
			{
				value = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
				return true;
			}
			value = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
			return false;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00099096 File Offset: 0x00097296
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WaterBoxStagnation"
			};
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000990A6 File Offset: 0x000972A6
		public static EPathDrivenActorInitialSpawnHandleType[] GetValues()
		{
			return new EPathDrivenActorInitialSpawnHandleType[1];
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000990AE File Offset: 0x000972AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"WaterBoxStagnation"
			};
		}
	}
}
