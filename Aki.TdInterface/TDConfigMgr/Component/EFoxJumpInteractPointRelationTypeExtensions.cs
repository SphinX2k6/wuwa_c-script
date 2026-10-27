using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094E RID: 2382
	public static class EFoxJumpInteractPointRelationTypeExtensions
	{
		// Token: 0x06003590 RID: 13712 RVA: 0x0008BC28 File Offset: 0x00089E28
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

		// Token: 0x06003591 RID: 13713 RVA: 0x0008BC60 File Offset: 0x00089E60
		public static EFoxJumpInteractPointRelationType FromString(string name)
		{
			EFoxJumpInteractPointRelationType result;
			if (!EFoxJumpInteractPointRelationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFoxJumpInteractPointRelationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0008BC89 File Offset: 0x00089E89
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

		// Token: 0x06003593 RID: 13715 RVA: 0x0008BCC2 File Offset: 0x00089EC2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ThisEntity",
				"PathDrivenSpawnedActor"
			};
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0008BCDA File Offset: 0x00089EDA
		public static EFoxJumpInteractPointRelationType[] GetValues()
		{
			return new EFoxJumpInteractPointRelationType[]
			{
				EFoxJumpInteractPointRelationType.ThisEntity,
				EFoxJumpInteractPointRelationType.PathDrivenSpawnedActor
			};
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x0008BCE6 File Offset: 0x00089EE6
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
