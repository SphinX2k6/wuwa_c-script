using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02004A04 RID: 18948
	[NullableContext(1)]
	[Nullable(0)]
	public static class HotKeyComponentUtil
	{
		// Token: 0x060312D9 RID: 201433 RVA: 0x00B67F70 File Offset: 0x00B66170
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

		// Token: 0x060312DA RID: 201434 RVA: 0x00B68054 File Offset: 0x00B66254
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

		// Token: 0x060312DB RID: 201435 RVA: 0x00B680A4 File Offset: 0x00B662A4
		public static void SetupComponents<[Nullable(0)] T>([Nullable(2)] UUIItem rootItem, EHotKeyCacheKey cacheKey, Func<object> callbackFn) where T : HotKeyComponent
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
							T t2 = t;
							t2.SetDataCallback(callbackFn);
						}
					}
					return;
				}
			}
			HotKeyComponentUtil.SetCacheCallback<T>(panelConfigByRootItem, cacheKey, componentClass, callbackFn);
		}

		// Token: 0x060312DC RID: 201436 RVA: 0x00B68148 File Offset: 0x00B66348
		public static int ExecuteOnComponents<[Nullable(0)] T>([Nullable(2)] UUIItem rootItem, Type componentClass, Action<T> actionFn) where T : HotKeyComponent
		{
			if (Info.Instance.IsInTouch())
			{
				return 0;
			}
			return HotKeyComponentUtil.ExecuteOnPanelComponents<T>(HotKeyComponentUtil.GetPanelConfigByRootItem(rootItem), componentClass, actionFn);
		}

		// Token: 0x060312DD RID: 201437 RVA: 0x00B68168 File Offset: 0x00B66368
		private static int ExecuteOnPanelComponents<[Nullable(0)] T>([Nullable(2)] TsUiNavigationPanelConfig panelConfig, Type componentClass, Action<T> actionFn) where T : HotKeyComponent
		{
			List<T> componentsFromPanel = HotKeyComponentUtil.GetComponentsFromPanel<T>(panelConfig, componentClass);
			foreach (T obj in componentsFromPanel)
			{
				actionFn(obj);
			}
			return componentsFromPanel.Count;
		}

		// Token: 0x060312DE RID: 201438 RVA: 0x00B681C4 File Offset: 0x00B663C4
		private static void SetCacheCallback<[Nullable(0)] T>(TsUiNavigationPanelConfig panelConfig, EHotKeyCacheKey cacheKey, Type componentClass, Func<object> callbackFn) where T : HotKeyComponent
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
							t.SetDataCallback(callbackFn);
						}
					}
				}
			};
		}

		// Token: 0x060312DF RID: 201439 RVA: 0x00B68210 File Offset: 0x00B66410
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

		// Token: 0x060312E0 RID: 201440 RVA: 0x00B68224 File Offset: 0x00B66424
		public static void ClearCacheCallback(TsUiNavigationPanelConfig panelConfig, EHotKeyCacheKey cacheKey)
		{
			Dictionary<EHotKeyCacheKey, Action<HotKeyItem>> cacheHotKeyComponentCallbackMap = panelConfig.CacheHotKeyComponentCallbackMap;
			if (cacheHotKeyComponentCallbackMap == null)
			{
				return;
			}
			cacheHotKeyComponentCallbackMap.Remove(cacheKey);
		}

		// Token: 0x060312E1 RID: 201441 RVA: 0x00B68238 File Offset: 0x00B66438
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
