using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003980 RID: 14720
	[NullableContext(1)]
	[Nullable(0)]
	public static class HotKeyComponentUtil
	{
		// Token: 0x06025E27 RID: 155175 RVA: 0x00AA36DC File Offset: 0x00AA18DC
		private static List<T> GetComponentsFromPanel<[Nullable(0)] T>([Nullable(2)] TsUiNavigationPanelConfig panelConfig, Type componentClass) where T : HotKeyComponent
		{
			List<T> list = new List<T>();
			if (((panelConfig != null) ? panelConfig.HotKeyItemSet : null) == null)
			{
				return list;
			}
			foreach (HotKeyItem hotKeyItem in panelConfig.HotKeyItemSet)
			{
				foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
				{
					if (((hotKeyComponent != null) ? hotKeyComponent.GetType() : null) == componentClass || (hotKeyComponent != null && hotKeyComponent.GetType().IsSubclassOf(componentClass)))
					{
						T t = hotKeyComponent as T;
						if (t != null)
						{
							list.Add(t);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06025E28 RID: 155176 RVA: 0x00AA37C0 File Offset: 0x00AA19C0
		[NullableContext(2)]
		private static TsUiNavigationPanelConfig GetPanelConfigByRootItem(UUIItem rootItem)
		{
			if (rootItem == null || !rootItem.IsValid())
			{
				return null;
			}
			AActor owner = rootItem.GetOwner();
			if (owner == null || !owner.IsValid())
			{
				return null;
			}
			return owner.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) as TsUiNavigationPanelConfig;
		}

		// Token: 0x06025E29 RID: 155177 RVA: 0x00AA3810 File Offset: 0x00AA1A10
		public static void SetupComponents<[Nullable(0)] T>([Nullable(2)] UUIItem rootItem, EHotKeyCacheKey cacheKey, Action<T> configure) where T : HotKeyComponent
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			TsUiNavigationPanelConfig panelConfigByRootItem = HotKeyComponentUtil.GetPanelConfigByRootItem(rootItem);
			if (panelConfigByRootItem == null)
			{
				return;
			}
			Type componentClass;
			if (!HotKeyUtilConfig.CacheKey2CompMap.TryGetValue(cacheKey, out componentClass))
			{
				return;
			}
			List<T> componentsFromPanel = HotKeyComponentUtil.GetComponentsFromPanel<T>(panelConfigByRootItem, componentClass);
			if (componentsFromPanel.Count > 0)
			{
				using (List<T>.Enumerator enumerator = componentsFromPanel.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T t = enumerator.Current;
						if (t != null)
						{
							T obj = t;
							configure(obj);
						}
					}
					return;
				}
			}
			HotKeyComponentUtil.SetCacheCallback<T>(panelConfigByRootItem, cacheKey, componentClass, configure);
		}

		// Token: 0x06025E2A RID: 155178 RVA: 0x00AA38B0 File Offset: 0x00AA1AB0
		public static int ExecuteOnComponents<[Nullable(0)] T>([Nullable(2)] UUIItem rootItem, Type componentClass, Action<T> actionFn) where T : HotKeyComponent
		{
			if (Info.Instance.IsInTouch())
			{
				return 0;
			}
			return HotKeyComponentUtil.ExecuteOnPanelComponents<T>(HotKeyComponentUtil.GetPanelConfigByRootItem(rootItem), componentClass, actionFn);
		}

		// Token: 0x06025E2B RID: 155179 RVA: 0x00AA38D0 File Offset: 0x00AA1AD0
		private static int ExecuteOnPanelComponents<[Nullable(0)] T>([Nullable(2)] TsUiNavigationPanelConfig panelConfig, Type componentClass, Action<T> actionFn) where T : HotKeyComponent
		{
			List<T> componentsFromPanel = HotKeyComponentUtil.GetComponentsFromPanel<T>(panelConfig, componentClass);
			foreach (T obj in componentsFromPanel)
			{
				actionFn(obj);
			}
			return componentsFromPanel.Count;
		}

		// Token: 0x06025E2C RID: 155180 RVA: 0x00AA392C File Offset: 0x00AA1B2C
		private static void SetCacheCallback<[Nullable(0)] T>(TsUiNavigationPanelConfig panelConfig, EHotKeyCacheKey cacheKey, Type componentClass, Action<T> configure) where T : HotKeyComponent
		{
			if (panelConfig.CacheHotKeyComponentCallbackMap == null)
			{
				panelConfig.CacheHotKeyComponentCallbackMap = new Dictionary<EHotKeyCacheKey, Action<HotKeyItem>>();
			}
			panelConfig.CacheHotKeyComponentCallbackMap[cacheKey] = delegate(HotKeyItem hotKeyItem)
			{
				foreach (HotKeyComponent hotKeyComponent in hotKeyItem.GetHotKeyComponentArray())
				{
					if (((hotKeyComponent != null) ? hotKeyComponent.GetType() : null) == componentClass || (hotKeyComponent != null && hotKeyComponent.GetType().IsSubclassOf(componentClass)))
					{
						T t = hotKeyComponent as T;
						if (t != null)
						{
							configure(t);
						}
					}
				}
			};
		}

		// Token: 0x06025E2D RID: 155181 RVA: 0x00AA3978 File Offset: 0x00AA1B78
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static Action<HotKeyItem> GetCacheCallback(TsUiNavigationPanelConfig panelConfig, EHotKeyCacheKey cacheKey)
		{
			Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> cacheHotKeyComponentCallbackMap = panelConfig.CacheHotKeyComponentCallbackMap;
			if (cacheHotKeyComponentCallbackMap == null)
			{
				return null;
			}
			return cacheHotKeyComponentCallbackMap.GetValueOrDefault(cacheKey);
		}

		// Token: 0x06025E2E RID: 155182 RVA: 0x00AA398C File Offset: 0x00AA1B8C
		public static void ClearCacheCallback(TsUiNavigationPanelConfig panelConfig, EHotKeyCacheKey cacheKey)
		{
			Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> cacheHotKeyComponentCallbackMap = panelConfig.CacheHotKeyComponentCallbackMap;
			if (cacheHotKeyComponentCallbackMap == null)
			{
				return;
			}
			cacheHotKeyComponentCallbackMap.Remove(cacheKey);
		}

		// Token: 0x06025E2F RID: 155183 RVA: 0x00AA39A0 File Offset: 0x00AA1BA0
		public static void ClearAllCacheCallbacks(TsUiNavigationPanelConfig panelConfig)
		{
			Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> cacheHotKeyComponentCallbackMap = panelConfig.CacheHotKeyComponentCallbackMap;
			if (cacheHotKeyComponentCallbackMap == null)
			{
				return;
			}
			cacheHotKeyComponentCallbackMap.Clear();
		}
	}
}
