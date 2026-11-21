using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268A RID: 9866
	public static class ERoadNetworkNavigationTargetExtensions
	{
		// Token: 0x0600D4C7 RID: 54471 RVA: 0x001EE7F4 File Offset: 0x001EC9F4
		public static string ToEnumString(this ERoadNetworkNavigationTarget value)
		{
			string result;
			if (value == ERoadNetworkNavigationTarget.SceneItem)
			{
				result = "SceneItem";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x001EE81C File Offset: 0x001ECA1C
		public static ERoadNetworkNavigationTarget FromString(string name)
		{
			ERoadNetworkNavigationTarget result;
			if (!ERoadNetworkNavigationTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadNetworkNavigationTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x001EE845 File Offset: 0x001ECA45
		public static bool TryFromString(string name, out ERoadNetworkNavigationTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoadNetworkNavigationTarget.SceneItem;
				return false;
			}
			if (name == "SceneItem")
			{
				value = ERoadNetworkNavigationTarget.SceneItem;
				return true;
			}
			value = ERoadNetworkNavigationTarget.SceneItem;
			return false;
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x001EE86A File Offset: 0x001ECA6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneItem"
			};
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x001EE87A File Offset: 0x001ECA7A
		public static ERoadNetworkNavigationTarget[] GetValues()
		{
			return new ERoadNetworkNavigationTarget[1];
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x001EE882 File Offset: 0x001ECA82
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneItem"
			};
		}
	}
}
