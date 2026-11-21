using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E2 RID: 5090
	public static class ETakePhoto2TargetTypeExtensions
	{
		// Token: 0x060071D3 RID: 29139 RVA: 0x00110038 File Offset: 0x0010E238
		public static string ToEnumString(this ETakePhoto2TargetType value)
		{
			string result;
			switch (value)
			{
			case ETakePhoto2TargetType.Entity:
				result = "Entity";
				break;
			case ETakePhoto2TargetType.PhotoTargetEntity:
				result = "PhotoTargetEntity";
				break;
			case ETakePhoto2TargetType.TaggedEntity:
				result = "TaggedEntity";
				break;
			case ETakePhoto2TargetType.TaggedActor:
				result = "TaggedActor";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x0011008C File Offset: 0x0010E28C
		public static ETakePhoto2TargetType FromString(string name)
		{
			ETakePhoto2TargetType result;
			if (!ETakePhoto2TargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETakePhoto2TargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x001100B8 File Offset: 0x0010E2B8
		public static bool TryFromString(string name, out ETakePhoto2TargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETakePhoto2TargetType.Entity;
				return false;
			}
			if (name == "Entity")
			{
				value = ETakePhoto2TargetType.Entity;
				return true;
			}
			if (name == "PhotoTargetEntity")
			{
				value = ETakePhoto2TargetType.PhotoTargetEntity;
				return true;
			}
			if (name == "TaggedEntity")
			{
				value = ETakePhoto2TargetType.TaggedEntity;
				return true;
			}
			if (!(name == "TaggedActor"))
			{
				value = ETakePhoto2TargetType.Entity;
				return false;
			}
			value = ETakePhoto2TargetType.TaggedActor;
			return true;
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00110120 File Offset: 0x0010E320
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"PhotoTargetEntity",
				"TaggedEntity",
				"TaggedActor"
			};
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00110148 File Offset: 0x0010E348
		public static ETakePhoto2TargetType[] GetValues()
		{
			return new ETakePhoto2TargetType[]
			{
				ETakePhoto2TargetType.Entity,
				ETakePhoto2TargetType.PhotoTargetEntity,
				ETakePhoto2TargetType.TaggedEntity,
				ETakePhoto2TargetType.TaggedActor
			};
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x0011015B File Offset: 0x0010E35B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"PhotoTargetEntity",
				"TaggedEntity",
				"TaggedActor"
			};
		}
	}
}
