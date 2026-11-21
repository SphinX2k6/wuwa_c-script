using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038BF RID: 14527
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationViewManager : Singleton
	{
		// Token: 0x06025ACE RID: 154318 RVA: 0x00A9A87E File Offset: 0x00A98A7E
		public void Initialize()
		{
			this.AddEventListener();
			this.AddTick();
		}

		// Token: 0x06025ACF RID: 154319 RVA: 0x00A9A88C File Offset: 0x00A98A8C
		public void Clear()
		{
			this.RemoveEventListener();
			this.RemoveTick();
		}

		// Token: 0x06025AD0 RID: 154320 RVA: 0x00A9A89A File Offset: 0x00A98A9A
		private void PrePhysicTick(float deltaTime)
		{
			if (this.NeedSkipFindNavigationByCache())
			{
				return;
			}
			this.FindDefaultNavigation();
		}

		// Token: 0x06025AD1 RID: 154321 RVA: 0x00A9A8AB File Offset: 0x00A98AAB
		private void EndPhysicTick(float deltaTime)
		{
			this.RefreshCurrentPanel();
			this.TickCurrentViewHandle(deltaTime);
			this.UpdateCurrentPanel();
			this.HandleCachePanelConfigToCurrentPanel();
			this.HandleCachePopPanelConfig();
			this.SetNavigationFocusForViewInternal(this.CacheUiItem, this.CacheCheckDirty);
		}

		// Token: 0x06025AD2 RID: 154322 RVA: 0x00A9A8E0 File Offset: 0x00A98AE0
		private void AddTick()
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.PrePhysicTick), "UiNavigationViewManager", ETickingGroup.TG_PrePhysics, true, 0, false);
			this.PrePhysicsTickId = ((ticker != null) ? ticker.Id : -1);
			Ticker ticker2 = TickSystem.Instance.Add(new Action<float>(this.EndPhysicTick), "UiNavigationViewManager", ETickingGroup.TG_EndPhysics, true, 0, false);
			this.EndPhysicTickId = ((ticker2 != null) ? ticker2.Id : -1);
		}

		// Token: 0x06025AD3 RID: 154323 RVA: 0x00A9A950 File Offset: 0x00A98B50
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

		// Token: 0x06025AD4 RID: 154324 RVA: 0x00A9A9A0 File Offset: 0x00A98BA0
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.NavigationViewCreate, new Action<int, AActor>(this.NavigationViewCreate));
			EventSystem.Instance.Add(EEventName.NavigationViewDestroy, new Action<int, AActor>(this.NavigationViewDestroy));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.ResetNavigationListener));
		}

		// Token: 0x06025AD5 RID: 154325 RVA: 0x00A9AA04 File Offset: 0x00A98C04
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.NavigationViewCreate, new Action<int, AActor>(this.NavigationViewCreate));
			EventSystem.Instance.Remove(EEventName.NavigationViewDestroy, new Action<int, AActor>(this.NavigationViewDestroy));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.ResetNavigationListener));
		}

		// Token: 0x06025AD6 RID: 154326 RVA: 0x00A9AA68 File Offset: 0x00A98C68
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

		// Token: 0x06025AD7 RID: 154327 RVA: 0x00A9AAEC File Offset: 0x00A98CEC
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

		// Token: 0x06025AD8 RID: 154328 RVA: 0x00A9ABF9 File Offset: 0x00A98DF9
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

		// Token: 0x06025AD9 RID: 154329 RVA: 0x00A9AC1E File Offset: 0x00A98E1E
		private void ResetNavigationListener()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.ResetNavigationListener();
			UiNavigationModel.Instance.MarkMoveInstantly();
		}

		// Token: 0x06025ADA RID: 154330 RVA: 0x00A9AC40 File Offset: 0x00A98E40
		private void CreateNavigationViewHandle(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			UiNavigationViewHandle uiNavigationViewHandle = new UiNavigationViewHandle(tagId, panelConfig);
			uiNavigationViewHandle.AddPanelConfig(tagId, panelConfig);
			this.NavigationViewMap[tagId] = uiNavigationViewHandle;
			this.PanelConfigMap[tagId] = uiNavigationViewHandle;
		}

		// Token: 0x06025ADB RID: 154331 RVA: 0x00A9AC78 File Offset: 0x00A98E78
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

		// Token: 0x06025ADC RID: 154332 RVA: 0x00A9AD0C File Offset: 0x00A98F0C
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

		// Token: 0x06025ADD RID: 154333 RVA: 0x00A9AD90 File Offset: 0x00A98F90
		private bool InsertNavigationViewPanelConfig(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			if (UiNavigationGlobalData.NeedCalculateCurrentPanel)
			{
				this.CacheInsertPanelConfigMap[tagId] = panelConfig;
				return true;
			}
			return this.InsertPanelConfigToCurrentHandle(tagId, panelConfig);
		}

		// Token: 0x06025ADE RID: 154334 RVA: 0x00A9ADB0 File Offset: 0x00A98FB0
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

		// Token: 0x06025ADF RID: 154335 RVA: 0x00A9ADEC File Offset: 0x00A98FEC
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

		// Token: 0x06025AE0 RID: 154336 RVA: 0x00A9AE70 File Offset: 0x00A99070
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

		// Token: 0x06025AE1 RID: 154337 RVA: 0x00A9AEE5 File Offset: 0x00A990E5
		public void MarkCalculateCurrentPanelDirty()
		{
			UiNavigationGlobalData.NeedCalculateCurrentPanel = true;
		}

		// Token: 0x06025AE2 RID: 154338 RVA: 0x00A9AEED File Offset: 0x00A990ED
		private void UpdateCurrentPanel()
		{
			if (!UiNavigationGlobalData.NeedCalculateCurrentPanel)
			{
				return;
			}
			UiNavigationGlobalData.NeedCalculateCurrentPanel = false;
			this.CalculateCurrentPanel();
		}

		// Token: 0x06025AE3 RID: 154339 RVA: 0x00A9AF04 File Offset: 0x00A99104
		private bool CheckDepthValid(UiNavigationViewHandle newHandle, UiNavigationViewHandle oldHandle)
		{
			int depth = newHandle.GetDepth();
			int depth2 = oldHandle.GetDepth();
			return depth != -1 && depth2 != -1;
		}

		// Token: 0x06025AE4 RID: 154340 RVA: 0x00A9AF2C File Offset: 0x00A9912C
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

		// Token: 0x06025AE5 RID: 154341 RVA: 0x00A9B08C File Offset: 0x00A9928C
		private void FindDefaultNavigation()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.FindDefaultNavigation();
		}

		// Token: 0x06025AE6 RID: 154342 RVA: 0x00A9B0A4 File Offset: 0x00A992A4
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

		// Token: 0x06025AE7 RID: 154343 RVA: 0x00A9B114 File Offset: 0x00A99314
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

		// Token: 0x06025AE8 RID: 154344 RVA: 0x00A9B190 File Offset: 0x00A99390
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

		// Token: 0x06025AE9 RID: 154345 RVA: 0x00A9B2B4 File Offset: 0x00A994B4
		private void TickCurrentViewHandle(float deltaTime)
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.TickViewHandle(deltaTime);
		}

		// Token: 0x06025AEA RID: 154346 RVA: 0x00A9B2CB File Offset: 0x00A994CB
		public UiNavigationViewHandle GetCurrentViewHandle()
		{
			return this.CurrentHandle;
		}

		// Token: 0x06025AEB RID: 154347 RVA: 0x00A9B2D3 File Offset: 0x00A994D3
		public void RefreshCurrentHotKey()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025AEC RID: 154348 RVA: 0x00A9B2E9 File Offset: 0x00A994E9
		public void RefreshCurrentHotKeyTextId()
		{
			if (this.CurrentHandle == null)
			{
				return;
			}
			this.CurrentHandle.MarkRefreshHotKeyTextIdDirty();
		}

		// Token: 0x06025AED RID: 154349 RVA: 0x00A9B2FF File Offset: 0x00A994FF
		public bool CanFocusViewHandle(UiNavigationViewHandle viewHandle)
		{
			UiNavigationViewHandle currentHandle = this.CurrentHandle;
			return currentHandle == null || !currentHandle.HasGamepadControlMouse() || this.CurrentHandle == viewHandle;
		}

		// Token: 0x06025AEE RID: 154350 RVA: 0x00A9B321 File Offset: 0x00A99521
		public bool NeedSkipFindNavigationByCache()
		{
			return this.CacheUiItem != null && this.CacheSuppressDefaultFind;
		}

		// Token: 0x06025AEF RID: 154351 RVA: 0x00A9B333 File Offset: 0x00A99533
		private void ClearNavigationFocusCache()
		{
			this.CacheUiItem = null;
			this.CacheCheckDirty = false;
			this.CacheSuppressDefaultFind = false;
		}

		// Token: 0x06025AF0 RID: 154352 RVA: 0x00A9B34C File Offset: 0x00A9954C
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

		// Token: 0x06025AF1 RID: 154353 RVA: 0x00A9B3E2 File Offset: 0x00A995E2
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

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x06025AF2 RID: 154354 RVA: 0x00A9B406 File Offset: 0x00A99606
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

		// Token: 0x06025AF3 RID: 154355 RVA: 0x00A9B429 File Offset: 0x00A99629
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025AF4 RID: 154356 RVA: 0x00A9B42B File Offset: 0x00A9962B
		public static void ResetStaticDefaultValue()
		{
			UiNavigationViewManager instance = UiNavigationViewManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiNavigationViewManager._instance = null;
		}

		// Token: 0x06025AF5 RID: 154357 RVA: 0x00A9B444 File Offset: 0x00A99644
		static UiNavigationViewManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationViewManager.CreateStaticDefaultValue), new Action(UiNavigationViewManager.ResetStaticDefaultValue));
		}

		// Token: 0x04014CE8 RID: 85224
		[Nullable(2)]
		private UiNavigationViewHandle CurrentHandle;

		// Token: 0x04014CE9 RID: 85225
		private readonly OrderedDictionary<int, UiNavigationViewHandle> NavigationViewMap = new OrderedDictionary<int, UiNavigationViewHandle>();

		// Token: 0x04014CEA RID: 85226
		private readonly Dictionary<int, UiNavigationViewHandle> PanelConfigMap = new Dictionary<int, UiNavigationViewHandle>();

		// Token: 0x04014CEB RID: 85227
		private readonly OrderedDictionary<int, TsUiNavigationPanelConfig> CacheInsertPanelConfigMap = new OrderedDictionary<int, TsUiNavigationPanelConfig>();

		// Token: 0x04014CEC RID: 85228
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly OrderedDictionary<ValueTuple<int, TsUiNavigationPanelConfig>, TsUiNavigationPanelConfig> CacheInsertPopPanelConfigMap = new OrderedDictionary<ValueTuple<int, TsUiNavigationPanelConfig>, TsUiNavigationPanelConfig>();

		// Token: 0x04014CED RID: 85229
		private int PrePhysicsTickId = -1;

		// Token: 0x04014CEE RID: 85230
		private int EndPhysicTickId = -1;

		// Token: 0x04014CEF RID: 85231
		[Nullable(2)]
		protected UUIItem CacheUiItem;

		// Token: 0x04014CF0 RID: 85232
		protected bool CacheCheckDirty;

		// Token: 0x04014CF1 RID: 85233
		protected bool CacheSuppressDefaultFind;

		// Token: 0x04014CF2 RID: 85234
		[Nullable(2)]
		private static UiNavigationViewManager _instance;
	}
}
