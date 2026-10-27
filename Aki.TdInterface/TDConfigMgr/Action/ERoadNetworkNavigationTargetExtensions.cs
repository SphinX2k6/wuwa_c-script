using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F3 RID: 9203
	public static class ERoadNetworkNavigationTargetExtensions
	{
		// Token: 0x0600C844 RID: 51268 RVA: 0x001D5048 File Offset: 0x001D3248
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

		// Token: 0x0600C845 RID: 51269 RVA: 0x001D5070 File Offset: 0x001D3270
		public static ERoadNetworkNavigationTarget FromString(string name)
		{
			ERoadNetworkNavigationTarget result;
			if (!ERoadNetworkNavigationTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoadNetworkNavigationTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x001D5099 File Offset: 0x001D3299
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

		// Token: 0x0600C847 RID: 51271 RVA: 0x001D50BE File Offset: 0x001D32BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneItem"
			};
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x001D50CE File Offset: 0x001D32CE
		public static ERoadNetworkNavigationTarget[] GetValues()
		{
			return new ERoadNetworkNavigationTarget[1];
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x001D50D6 File Offset: 0x001D32D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneItem"
			};
		}
	}
}
