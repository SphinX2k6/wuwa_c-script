using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FF RID: 2559
	public static class EFoxJumpInteractPointRelationTypeExtensions
	{
		// Token: 0x0600390E RID: 14606 RVA: 0x000939F4 File Offset: 0x00091BF4
		public static string ToEnumString(this EFoxJumpInteractPointRelationType value)
		{
			string result;
			if (value != EFoxJumpInteractPointRelationType.ThisEntity)
			{
				if (value != EFoxJumpInteractPointRelationType.PathDrivenSpawnedActor)
				{
					result = value.ToString();
				}
				else
				{
					result = "PathDrivenSpawnedActor";
				}
			}
			else
			{
				result = "ThisEntity";
			}
			return result;
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00093A2C File Offset: 0x00091C2C
		public static EFoxJumpInteractPointRelationType FromString(string name)
		{
			EFoxJumpInteractPointRelationType result;
			if (!EFoxJumpInteractPointRelationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFoxJumpInteractPointRelationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00093A55 File Offset: 0x00091C55
		public static bool TryFromString(string name, out EFoxJumpInteractPointRelationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFoxJumpInteractPointRelationType.ThisEntity;
				return false;
			}
			if (name == "ThisEntity")
			{
				value = EFoxJumpInteractPointRelationType.ThisEntity;
				return true;
			}
			if (!(name == "PathDrivenSpawnedActor"))
			{
				value = EFoxJumpInteractPointRelationType.ThisEntity;
				return false;
			}
			value = EFoxJumpInteractPointRelationType.PathDrivenSpawnedActor;
			return true;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00093A8E File Offset: 0x00091C8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ThisEntity",
				"PathDrivenSpawnedActor"
			};
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00093AA6 File Offset: 0x00091CA6
		public static EFoxJumpInteractPointRelationType[] GetValues()
		{
			return new EFoxJumpInteractPointRelationType[]
			{
				EFoxJumpInteractPointRelationType.ThisEntity,
				EFoxJumpInteractPointRelationType.PathDrivenSpawnedActor
			};
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00093AB2 File Offset: 0x00091CB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ThisEntity",
				"PathDrivenSpawnedActor"
			};
		}
	}
}
