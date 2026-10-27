using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004948 RID: 18760
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationViewManager : Singleton
	{
		// Token: 0x06030FA2 RID: 200610 RVA: 0x00B5FA3A File Offset: 0x00B5DC3A
		public void Initialize()
		{
			this.AddEventListener();
			this.AddTick();
		}

		// Token: 0x06030FA3 RID: 200611 RVA: 0x00B5FA48 File Offset: 0x00B5DC48
		public void Clear()
		{
			this.RemoveEventListener();
			this.RemoveTick();
		}

		// Token: 0x06030FA4 RID: 200612 RVA: 0x00B5FA56 File Offset: 0x00B5DC56
		private void PrePhysicTick(float deltaTime)
		{
			if (this.NeedSkipFindNavigationByCache())
			{
				return;
			}
			this.FindDefaultNavigation();
		}

		// Token: 0x06030FA5 RID: 200613 RVA: 0x00B5FA67 File Offset: 0x00B5DC67
		private void EndPhysicTick(float deltaTime)
		{
			this.RefreshCurrentPanel();
			this.TickCurrentViewHandle(deltaTime);
			this.UpdateCurrentPanel();
			this.HandleCachePanelConfigToCurrentPanel();
			this.HandleCachePopPanelConfig();
			this.SetNavigationFocusForViewInternal(this.CacheUiItem, this.CacheCheckDirty);
		}

		// Token: 0x06030FA6 RID: 200614 RVA: 0x00B5FA9C File Offset: 0x00B5DC9C
		private void AddTick()
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PrePhysicTick), "UiNavigationViewManager", ETickingGroup.TG_PrePhysics, true, 0, false);
			this.PrePhysicsTickId = ((ticker != null) ? ticker.Id : -1);
			Ticker ticker2 = TickSystem.Instance.Add(new Action<float>(this.EndPhysicTick), "UiNavigationViewManager", ETickingGroup.TG_EndPhysics, true, 0, false);
			this.EndPhysicTickId = ((ticker2 != null) ? ticker2.Id : -1);
		}

		// Token: 0x06030FA7 RID: 200615 RVA: 0x00B5FB0C File Offset: 0x00B5DD0C
		private void RemoveTick()
		{
			if (this.PrePhysicsTickId != -1)
			{
				TickSystem.Instance.Remove(this.PrePhysicsTickId);
				this.PrePhysicsTickId = -1;
			}
			if (this.EndPhysicTickId != -1)
			{
				TickSystem.Instance.Remove(this.EndPhysicTickId);
				this.EndPhysicTickId = -1;
			}
		}

		// Token: 0x06030FA8 RID: 200616 RVA: 0x00B5FB5C File Offset: 0x00B5DD5C
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.NavigationViewCreate, new Action<int, AActor>(this.NavigationViewCreate));
			EventSystem.Instance.Add(EEventName.NavigationViewDestroy, new Action<int, AActor>(this.NavigationViewDestroy));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.ResetNavigationListener));
		}

		// Token: 0x06030FA9 RID: 200617 RVA: 0x00B5FBC0 File Offset: 0x00B5DDC0
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationViewCreate, new Action<int, AActor>(this.NavigationViewCreate));
			EventSystem.Instance.Remove(EEventName.NavigationViewDestroy, new Action<int, AActor>(this.NavigationViewDestroy));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.ResetNavigationListener));
		}

		// Token: 0x06030FAA RID: 200618 RVA: 0x00B5FC24 File Offset: 0x00B5DE24
		[NullableContext(2)]
		private void NavigationViewCreate(int tagId, AActor actor)
		{
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = actor.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) as TsUiNavigationPanelConfig;
			if (tsUiNavigationPanelConfig == null)
			{
				return;
			}
			if (Info.Instance.IsInTouch())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "移动端出现PC配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", tsUiNavigationPanelConfig.ViewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (tsUiNavigationPanelConfig.Independent)
			{
				this.CreateNavigationViewHandle(tagId, tsUiNavigationPanelConfig);
				this.MarkCalculateCurrentPanelDirty();
				return;
			}
			this.CheckAndInsertPanelConfig(tagId, tsUiNavigationPanelConfig);
		}

		// Token: 0x06030FAB RID: 200619 RVA: 0x00B5FCA8 File Offset: 0x00B5DEA8
		private void CheckAndInsertPanelConfig(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			if (panelConfig.ViewName != "弹窗通用")
			{
				this.InsertNavigationViewPanelConfig(tagId, panelConfig);
				return;
			}
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(panelConfig.GetOwner(), TsUiNavigationPanelConfig.StaticClass(), false);
			if (componentsInChildren.Num() > 0)
			{
				int i = componentsInChildren.Num() - 1;
				while (i >= 0)
				{
					TsUiNavigationPanelConfig tsUiNavigationPanelConfig = componentsInChildren.Get(i) as TsUiNavigationPanelConfig;
					if (tsUiNavigationPanelConfig.Independent && !(tsUiNavigationPanelConfig.ViewName != "弹窗通用"))
					{
						if (this.IsExistInNavigationViewMap(tsUiNavigationPanelConfig))
						{
							this.InsertNavigationViewPanelConfig(tagId, panelConfig);
							return;
						}
						this.CacheInsertPopPanelConfigMap[new ValueTuple<int, TsUiNavigationPanelConfig>(tagId, panelConfig)] = tsUiNavigationPanelConfig;
						return;
					}
					else
					{
						i--;
					}
				}
				return;
			}
			if (this.CacheInsertPopPanelConfigMap.Count > 0)
			{
				TsUiNavigationPanelConfig tsUiNavigationPanelConfig2 = UiNavigationLogic.FindUiNavigationPanelConfig(panelConfig.GetOwner());
				if (tsUiNavigationPanelConfig2 != null)
				{
					this.CacheInsertPopPanelConfigMap[new ValueTuple<int, TsUiNavigationPanelConfig>(tagId, panelConfig)] = tsUiNavigationPanelConfig2;
				}
				return;
			}
			if (!this.InsertNavigationViewPanelConfig(tagId, panelConfig))
			{
				TsUiNavigationPanelConfig tsUiNavigationPanelConfig3 = UiNavigationLogic.FindUiNavigationPanelConfig(panelConfig.GetOwner());
				if (tsUiNavigationPanelConfig3 != null)
				{
					this.CacheInsertPopPanelConfigMap[new ValueTuple<int, TsUiNavigationPanelConfig>(tagId, panelConfig)] = tsUiNavigationPanelConfig3;
				}
			}
		}

		// Token: 0x06030FAC RID: 200620 RVA: 0x00B5FDB5 File Offset: 0x00B5DFB5
		private void NavigationViewDestroy(int tagId, AActor actor)
		{
			if (actor == null)
			{
				return;
			}
			if (!this.DeleteNavigationViewPanelConfig(tagId))
			{
				return;
			}
			this.DestroyNavigationViewHandle(tagId);
			this.ResetCurrentHandle(tagId);
			this.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06030FAD RID: 200621 RVA: 0x00B5FDDA File Offset: 0x00B5DFDA
		private void ResetNavigationListener()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.ResetNavigationListener();
			UiNavigationModel.Instance.MarkMoveInstantly();
		}

		// Token: 0x06030FAE RID: 200622 RVA: 0x00B5FDFC File Offset: 0x00B5DFFC
		private void CreateNavigationViewHandle(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			UiNavigationViewHandle uiNavigationViewHandle = new UiNavigationViewHandle(tagId, panelConfig);
			uiNavigationViewHandle.AddPanelConfig(tagId, panelConfig);
			this.NavigationViewMap[tagId] = uiNavigationViewHandle;
			this.PanelConfigMap[tagId] = uiNavigationViewHandle;
		}

		// Token: 0x06030FAF RID: 200623 RVA: 0x00B5FE34 File Offset: 0x00B5E034
		private bool IsExistInNavigationViewMap(TsUiNavigationPanelConfig panelConfig)
		{
			foreach (UiNavigationViewHandle uiNavigationViewHandle in this.NavigationViewMap.Values)
			{
				TsUiNavigationPanelConfig mainPanel = uiNavigationViewHandle.MainPanel;
				IntPtr? intPtr = (mainPanel != null) ? new IntPtr?(mainPanel.GetNativePtr_Unchecked()) : null;
				IntPtr nativePtr_Unchecked = panelConfig.GetNativePtr_Unchecked();
				if (intPtr.GetValueOrDefault() == nativePtr_Unchecked & intPtr != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06030FB0 RID: 200624 RVA: 0x00B5FEC8 File Offset: 0x00B5E0C8
		private bool InsertPanelConfigToCurrentHandle(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			UiNavigationViewHandle uiNavigationViewHandle = null;
			foreach (UiNavigationViewHandle uiNavigationViewHandle2 in this.NavigationViewMap.Values)
			{
				if (uiNavigationViewHandle2.ViewName == panelConfig.ViewName)
				{
					uiNavigationViewHandle = uiNavigationViewHandle2;
				}
			}
			if (uiNavigationViewHandle == null)
			{
				return false;
			}
			uiNavigationViewHandle.AddPanelConfig(tagId, panelConfig);
			this.PanelConfigMap[tagId] = uiNavigationViewHandle;
			return true;
		}

		// Token: 0x06030FB1 RID: 200625 RVA: 0x00B5FF4C File Offset: 0x00B5E14C
		private bool InsertNavigationViewPanelConfig(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			if (UiNavigationGlobalData.NeedCalculateCurrentPanel)
			{
				this.CacheInsertPanelConfigMap[tagId] = panelConfig;
				return true;
			}
			return this.InsertPanelConfigToCurrentHandle(tagId, panelConfig);
		}

		// Token: 0x06030FB2 RID: 200626 RVA: 0x00B5FF6C File Offset: 0x00B5E16C
		private bool DeleteNavigationViewPanelConfig(int tagId)
		{
			UiNavigationViewHandle uiNavigationViewHandle;
			if (this.PanelConfigMap.TryGetValue(tagId, out uiNavigationViewHandle))
			{
				this.PanelConfigMap.Remove(tagId);
				uiNavigationViewHandle.DeletePanelConfig(tagId);
				return tagId == uiNavigationViewHandle.TagId;
			}
			return false;
		}

		// Token: 0x06030FB3 RID: 200627 RVA: 0x00B5FFA8 File Offset: 0x00B5E1A8
		private bool DestroyNavigationViewHandle(int tagId)
		{
			UiNavigationViewHandle uiNavigationViewHandle;
			if (this.NavigationViewMap.TryGetValue(tagId, out uiNavigationViewHandle))
			{
				this.NavigationViewMap.Remove(tagId);
				foreach (int key in uiNavigationViewHandle.GetPanelConfigMap().Keys)
				{
					this.PanelConfigMap.Remove(key);
				}
				uiNavigationViewHandle.ClearPanelConfig();
				return true;
			}
			return false;
		}

		// Token: 0x06030FB4 RID: 200628 RVA: 0x00B6002C File Offset: 0x00B5E22C
		private void ResetCurrentHandle(int tagId)
		{
			if (this.CurrentHandle == null)
			{
				Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "当前导航面板不存在,将导航对象置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiNavigationLogic.UpdateNavigationListener(null);
				return;
			}
			if (this.CurrentHandle.TagId == tagId)
			{
				Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "当前导航面板销毁,将导航对象置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiNavigationLogic.UpdateNavigationListener(null);
				this.CurrentHandle = null;
			}
		}

		// Token: 0x06030FB5 RID: 200629 RVA: 0x00B600A1 File Offset: 0x00B5E2A1
		public void MarkCalculateCurrentPanelDirty()
		{
			UiNavigationGlobalData.NeedCalculateCurrentPanel = true;
		}

		// Token: 0x06030FB6 RID: 200630 RVA: 0x00B600A9 File Offset: 0x00B5E2A9
		private void UpdateCurrentPanel()
		{
			if (!UiNavigationGlobalData.NeedCalculateCurrentPanel)
			{
				return;
			}
			UiNavigationGlobalData.NeedCalculateCurrentPanel = false;
			this.CalculateCurrentPanel();
		}

		// Token: 0x06030FB7 RID: 200631 RVA: 0x00B600C0 File Offset: 0x00B5E2C0
		private bool CheckDepthValid(UiNavigationViewHandle newHandle, UiNavigationViewHandle oldHandle)
		{
			int depth = newHandle.GetDepth();
			int depth2 = oldHandle.GetDepth();
			return depth != -1 && depth2 != -1;
		}

		// Token: 0x06030FB8 RID: 200632 RVA: 0x00B600E8 File Offset: 0x00B5E2E8
		private void CalculateCurrentPanel()
		{
			if (this.NavigationViewMap.Count <= 0)
			{
				this.CurrentHandle = null;
				Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "当前没有导航面板,将导航对象置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiNavigationLogic.UpdateNavigationListener(null);
				return;
			}
			UiNavigationViewHandle uiNavigationViewHandle = null;
			bool flag = true;
			foreach (UiNavigationViewHandle uiNavigationViewHandle2 in this.NavigationViewMap.Values)
			{
				if (uiNavigationViewHandle2.GetIsActive() && uiNavigationViewHandle2.GetIsUsable())
				{
					if (uiNavigationViewHandle == null)
					{
						uiNavigationViewHandle = uiNavigationViewHandle2;
					}
					else
					{
						if (!this.CheckDepthValid(uiNavigationViewHandle2, uiNavigationViewHandle))
						{
							flag = false;
							break;
						}
						if (uiNavigationViewHandle2.GetDepth() > uiNavigationViewHandle.GetDepth())
						{
							uiNavigationViewHandle = uiNavigationViewHandle2;
						}
						else
						{
							uiNavigationViewHandle2.SetIsInController(false);
						}
					}
				}
			}
			if (!flag)
			{
				this.MarkCalculateCurrentPanelDirty();
				return;
			}
			if (this.CurrentHandle != uiNavigationViewHandle)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "查找当前导航界面句柄";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", (uiNavigationViewHandle != null) ? uiNavigationViewHandle.ViewName : null);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (this.CurrentHandle != null)
				{
					this.CurrentHandle.SetIsInController(false);
					this.CurrentHandle.CanOverridePositionByGamepad(false);
				}
				if (uiNavigationViewHandle != null)
				{
					uiNavigationViewHandle.SetIsInController(true);
					uiNavigationViewHandle.CanOverridePositionByGamepad(true);
					uiNavigationViewHandle.ResetStateIfNullFocus();
				}
				this.CurrentHandle = uiNavigationViewHandle;
			}
		}

		// Token: 0x06030FB9 RID: 200633 RVA: 0x00B60248 File Offset: 0x00B5E448
		private void FindDefaultNavigation()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.FindDefaultNavigation();
		}

		// Token: 0x06030FBA RID: 200634 RVA: 0x00B60260 File Offset: 0x00B5E460
		private void RefreshCurrentPanel()
		{
			if (UiNavigationGlobalData.NeedRefreshPanelId == 0)
			{
				return;
			}
			if (this.NeedSkipFindNavigationByCache())
			{
				return;
			}
			if (this.CurrentHandle == null || this.CurrentHandle.TagId != UiNavigationGlobalData.NeedRefreshPanelId)
			{
				UiNavigationGlobalData.NeedRefreshPanelId = 0;
				return;
			}
			UiNavigationGlobalData.NeedRefreshPanelId = 0;
			if (this.CurrentHandle == null)
			{
				return;
			}
			if (!this.CurrentHandle.HasAnyPanelActive())
			{
				this.MarkCalculateCurrentPanelDirty();
				return;
			}
			this.CurrentHandle.FindAddPanelConfigNavigation();
		}

		// Token: 0x06030FBB RID: 200635 RVA: 0x00B602D0 File Offset: 0x00B5E4D0
		private void HandleCachePanelConfigToCurrentPanel()
		{
			if (this.CacheInsertPanelConfigMap.Count <= 0)
			{
				return;
			}
			foreach (KeyValuePair<int, TsUiNavigationPanelConfig> keyValuePair in this.CacheInsertPanelConfigMap)
			{
				this.InsertPanelConfigToCurrentHandle(keyValuePair.Key, keyValuePair.Value);
			}
			this.CacheInsertPanelConfigMap.Clear();
		}

		// Token: 0x06030FBC RID: 200636 RVA: 0x00B6034C File Offset: 0x00B5E54C
		private void HandleCachePopPanelConfig()
		{
			if (this.CacheInsertPopPanelConfigMap.Count <= 0)
			{
				return;
			}
			if (this.CurrentHandle == null)
			{
				return;
			}
			List<ValueTuple<int, TsUiNavigationPanelConfig>> list = new List<ValueTuple<int, TsUiNavigationPanelConfig>>();
			foreach (KeyValuePair<ValueTuple<int, TsUiNavigationPanelConfig>, TsUiNavigationPanelConfig> keyValuePair in this.CacheInsertPopPanelConfigMap)
			{
				IntPtr nativePtr_Unchecked = keyValuePair.Value.GetNativePtr_Unchecked();
				TsUiNavigationPanelConfig mainPanel = this.CurrentHandle.MainPanel;
				IntPtr? intPtr = (mainPanel != null) ? new IntPtr?(mainPanel.GetNativePtr_Unchecked()) : null;
				if (nativePtr_Unchecked == intPtr.GetValueOrDefault() & intPtr != null)
				{
					list.Add(keyValuePair.Key);
					this.InsertNavigationViewPanelConfig(keyValuePair.Key.Item1, keyValuePair.Key.Item2);
				}
			}
			foreach (ValueTuple<int, TsUiNavigationPanelConfig> key in list)
			{
				this.CacheInsertPopPanelConfigMap.Remove(key);
			}
		}

		// Token: 0x06030FBD RID: 200637 RVA: 0x00B60470 File Offset: 0x00B5E670
		private void TickCurrentViewHandle(float deltaTime)
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.TickViewHandle(deltaTime);
		}

		// Token: 0x06030FBE RID: 200638 RVA: 0x00B60487 File Offset: 0x00B5E687
		public UiNavigationViewHandle GetCurrentViewHandle()
		{
			return this.CurrentHandle;
		}

		// Token: 0x06030FBF RID: 200639 RVA: 0x00B6048F File Offset: 0x00B5E68F
		public void RefreshCurrentHotKey()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06030FC0 RID: 200640 RVA: 0x00B604A5 File Offset: 0x00B5E6A5
		public void RefreshCurrentHotKeyTextId()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.MarkRefreshHotKeyTextIdDirty();
		}

		// Token: 0x06030FC1 RID: 200641 RVA: 0x00B604BB File Offset: 0x00B5E6BB
		public bool CanFocusViewHandle(UiNavigationViewHandle viewHandle)
		{
			UiNavigationViewHandle currentHandle = this.CurrentHandle;
			return currentHandle == null || !currentHandle.HasGamepadControlMouse() || this.CurrentHandle == viewHandle;
		}

		// Token: 0x06030FC2 RID: 200642 RVA: 0x00B604DD File Offset: 0x00B5E6DD
		public bool NeedSkipFindNavigationByCache()
		{
			return this.CacheUiItem != null && this.CacheSuppressDefaultFind;
		}

		// Token: 0x06030FC3 RID: 200643 RVA: 0x00B604EF File Offset: 0x00B5E6EF
		private void ClearNavigationFocusCache()
		{
			this.CacheUiItem = null;
			this.CacheCheckDirty = false;
			this.CacheSuppressDefaultFind = false;
		}

		// Token: 0x06030FC4 RID: 200644 RVA: 0x00B60508 File Offset: 0x00B5E708
		[NullableContext(2)]
		private void SetNavigationFocusForViewInternal(UUIItem uiItem, bool checkDirty = false)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			if (uiItem == null)
			{
				return;
			}
			if (!uiItem.IsValid())
			{
				Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.SYB, "缓存的导航对象已无效,放弃本次设置", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ClearNavigationFocusCache();
				UiNavigationViewHandle currentHandle = this.CurrentHandle;
				if (currentHandle == null)
				{
					return;
				}
				currentHandle.RestoreSwallowedRefreshNavigation();
				return;
			}
			else
			{
				bool flag = UiNavigationNewController.Instance.SetNavigationFocusForView(uiItem, checkDirty, false, false);
				this.ClearNavigationFocusCache();
				if (flag)
				{
					if (!checkDirty)
					{
						UiNavigationViewHandle currentHandle2 = this.CurrentHandle;
						if (currentHandle2 == null)
						{
							return;
						}
						currentHandle2.DiscardSwallowedRefreshNavigation();
					}
					return;
				}
				UiNavigationViewHandle currentHandle3 = this.CurrentHandle;
				if (currentHandle3 == null)
				{
					return;
				}
				currentHandle3.RestoreSwallowedRefreshNavigation();
				return;
			}
		}

		// Token: 0x06030FC5 RID: 200645 RVA: 0x00B6059E File Offset: 0x00B5E79E
		public void SetNavigationFocusForView(UUIItem uiItem, bool checkDirty = false, bool suppressDefaultFind = false)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.CacheUiItem = uiItem;
			this.CacheCheckDirty = checkDirty;
			this.CacheSuppressDefaultFind = suppressDefaultFind;
		}

		// Token: 0x170079D8 RID: 31192
		// (get) Token: 0x06030FC6 RID: 200646 RVA: 0x00B605C2 File Offset: 0x00B5E7C2
		public static UiNavigationViewManager Instance
		{
			get
			{
				if (UiNavigationViewManager._instance == null)
				{
					UiNavigationViewManager._instance = new UiNavigationViewManager();
					UiNavigationViewManager._instance.OnInit();
				}
				return UiNavigationViewManager._instance;
			}
		}

		// Token: 0x06030FC7 RID: 200647 RVA: 0x00B605E5 File Offset: 0x00B5E7E5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030FC8 RID: 200648 RVA: 0x00B605E7 File Offset: 0x00B5E7E7
		public static void ResetStaticDefaultValue()
		{
			UiNavigationViewManager instance = UiNavigationViewManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiNavigationViewManager._instance = null;
		}

		// Token: 0x06030FC9 RID: 200649 RVA: 0x00B60600 File Offset: 0x00B5E800
		static UiNavigationViewManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationViewManager.CreateStaticDefaultValue), new Action(UiNavigationViewManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401A475 RID: 107637
		[Nullable(2)]
		private UiNavigationViewHandle CurrentHandle;

		// Token: 0x0401A476 RID: 107638
		private readonly OrderedDictionary<int, UiNavigationViewHandle> NavigationViewMap = new OrderedDictionary<int, UiNavigationViewHandle>();

		// Token: 0x0401A477 RID: 107639
		private readonly Dictionary<int, UiNavigationViewHandle> PanelConfigMap = new Dictionary<int, UiNavigationViewHandle>();

		// Token: 0x0401A478 RID: 107640
		private readonly OrderedDictionary<int, TsUiNavigationPanelConfig> CacheInsertPanelConfigMap = new OrderedDictionary<int, TsUiNavigationPanelConfig>();

		// Token: 0x0401A479 RID: 107641
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly OrderedDictionary<ValueTuple<int, TsUiNavigationPanelConfig>, TsUiNavigationPanelConfig> CacheInsertPopPanelConfigMap = new OrderedDictionary<ValueTuple<int, TsUiNavigationPanelConfig>, TsUiNavigationPanelConfig>();

		// Token: 0x0401A47A RID: 107642
		private int PrePhysicsTickId = -1;

		// Token: 0x0401A47B RID: 107643
		private int EndPhysicTickId = -1;

		// Token: 0x0401A47C RID: 107644
		[Nullable(2)]
		protected UUIItem CacheUiItem;

		// Token: 0x0401A47D RID: 107645
		protected bool CacheCheckDirty;

		// Token: 0x0401A47E RID: 107646
		protected bool CacheSuppressDefaultFind;

		// Token: 0x0401A47F RID: 107647
		[Nullable(2)]
		private static UiNavigationViewManager _instance;
	}
}
