using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239F RID: 9119
	public static class EMoveSceneItemTypeExtensions
	{
		// Token: 0x0600C6CA RID: 50890 RVA: 0x001D1BF4 File Offset: 0x001CFDF4
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

		// Token: 0x0600C6CB RID: 50891 RVA: 0x001D1C48 File Offset: 0x001CFE48
		public static EMoveSceneItemType FromString(string name)
		{
			EMoveSceneItemType result;
			if (!EMoveSceneItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoveSceneItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6CC RID: 50892 RVA: 0x001D1C74 File Offset: 0x001CFE74
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

		// Token: 0x0600C6CD RID: 50893 RVA: 0x001D1CDC File Offset: 0x001CFEDC
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

		// Token: 0x0600C6CE RID: 50894 RVA: 0x001D1D04 File Offset: 0x001CFF04
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

		// Token: 0x0600C6CF RID: 50895 RVA: 0x001D1D17 File Offset: 0x001CFF17
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
