using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129C RID: 4764
	public static class ETakePhoto2TargetTypeExtensions
	{
		// Token: 0x06006B65 RID: 27493 RVA: 0x00102070 File Offset: 0x00100270
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

		// Token: 0x06006B66 RID: 27494 RVA: 0x001020C4 File Offset: 0x001002C4
		public static ETakePhoto2TargetType FromString(string name)
		{
			ETakePhoto2TargetType result;
			if (!ETakePhoto2TargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETakePhoto2TargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x001020F0 File Offset: 0x001002F0
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

		// Token: 0x06006B68 RID: 27496 RVA: 0x00102158 File Offset: 0x00100358
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

		// Token: 0x06006B69 RID: 27497 RVA: 0x00102180 File Offset: 0x00100380
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

		// Token: 0x06006B6A RID: 27498 RVA: 0x00102193 File Offset: 0x00100393
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
