using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C2 RID: 2498
	public static class EPathDrivenActorInitialSpawnHandleTypeExtensions
	{
		// Token: 0x0600379A RID: 14234 RVA: 0x00090950 File Offset: 0x0008EB50
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

		// Token: 0x0600379B RID: 14235 RVA: 0x00090978 File Offset: 0x0008EB78
		public static EPathDrivenActorInitialSpawnHandleType FromString(string name)
		{
			EPathDrivenActorInitialSpawnHandleType result;
			if (!EPathDrivenActorInitialSpawnHandleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPathDrivenActorInitialSpawnHandleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x000909A1 File Offset: 0x0008EBA1
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

		// Token: 0x0600379D RID: 14237 RVA: 0x000909C6 File Offset: 0x0008EBC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WaterBoxStagnation"
			};
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000909D6 File Offset: 0x0008EBD6
		public static EPathDrivenActorInitialSpawnHandleType[] GetValues()
		{
			return new EPathDrivenActorInitialSpawnHandleType[1];
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000909DE File Offset: 0x0008EBDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"WaterBoxStagnation"
			};
		}
	}
}
