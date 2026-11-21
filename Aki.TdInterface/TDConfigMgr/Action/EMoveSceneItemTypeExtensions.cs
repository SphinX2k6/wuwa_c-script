using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262A RID: 9770
	public static class EMoveSceneItemTypeExtensions
	{
		// Token: 0x0600D317 RID: 54039 RVA: 0x001EAD94 File Offset: 0x001E8F94
		public static string ToEnumString(this EMoveSceneItemType value)
		{
			string result;
			switch (value)
			{
			case EMoveSceneItemType.MoveToPoint:
				result = "MoveToPoint";
				break;
			case EMoveSceneItemType.CycleMoveToPoints:
				result = "CycleMoveToPoints";
				break;
			case EMoveSceneItemType.MoveToRelativePosition:
				result = "MoveToRelativePosition";
				break;
			case EMoveSceneItemType.MoveToEntity:
				result = "MoveToEntity";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x001EADE8 File Offset: 0x001E8FE8
		public static EMoveSceneItemType FromString(string name)
		{
			EMoveSceneItemType result;
			if (!EMoveSceneItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveSceneItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x001EAE14 File Offset: 0x001E9014
		public static bool TryFromString(string name, out EMoveSceneItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoveSceneItemType.MoveToPoint;
				return false;
			}
			if (name == "MoveToPoint")
			{
				value = EMoveSceneItemType.MoveToPoint;
				return true;
			}
			if (name == "CycleMoveToPoints")
			{
				value = EMoveSceneItemType.CycleMoveToPoints;
				return true;
			}
			if (name == "MoveToRelativePosition")
			{
				value = EMoveSceneItemType.MoveToRelativePosition;
				return true;
			}
			if (!(name == "MoveToEntity"))
			{
				value = EMoveSceneItemType.MoveToPoint;
				return false;
			}
			value = EMoveSceneItemType.MoveToEntity;
			return true;
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x001EAE7C File Offset: 0x001E907C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoveToPoint",
				"CycleMoveToPoints",
				"MoveToRelativePosition",
				"MoveToEntity"
			};
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x001EAEA4 File Offset: 0x001E90A4
		public static EMoveSceneItemType[] GetValues()
		{
			return new EMoveSceneItemType[]
			{
				EMoveSceneItemType.MoveToPoint,
				EMoveSceneItemType.CycleMoveToPoints,
				EMoveSceneItemType.MoveToRelativePosition,
				EMoveSceneItemType.MoveToEntity
			};
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x001EAEB7 File Offset: 0x001E90B7
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoveToPoint",
				"CycleMoveToPoints",
				"MoveToRelativePosition",
				"MoveToEntity"
			};
		}
	}
}
