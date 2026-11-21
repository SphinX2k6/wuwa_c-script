using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038BE RID: 14526
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationViewHandle
	{
		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x06025A75 RID: 154229 RVA: 0x00A99462 File Offset: 0x00A97662
		// (set) Token: 0x06025A76 RID: 154230 RVA: 0x00A9946A File Offset: 0x00A9766A
		public EViewHandleState State
		{
			get
			{
				return this.StateInternal;
			}
			set
			{
				this.StateInternal != value;
				this.StateInternal = value;
			}
		}

		// Token: 0x06025A77 RID: 154231 RVA: 0x00A99480 File Offset: 0x00A97680
		public UiNavigationViewHandle(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			this.TagId = tagId;
			this.ViewName = panelConfig.ViewName;
			this.MainPanel = panelConfig;
			this.CurrentPanel = panelConfig;
			this.ScrollBallData = new NavigationScrollbarData();
			this.InitGamepadControlMouse();
		}

		// Token: 0x06025A78 RID: 154232 RVA: 0x00A99518 File Offset: 0x00A97718
		private void ResetState()
		{
			this.State = EViewHandleState.None;
			if (this.FocusListener != null)
			{
				UiNavigationNewController.Instance.SwitchNavigationFocus(null);
			}
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				SpecialPanelHandleBase panelHandle = tsUiNavigationPanelConfig.GetPanelHandle();
				if (panelHandle != null)
				{
					panelHandle.ResetGroupConfigMemory();
				}
			}
		}

		// Token: 0x06025A79 RID: 154233 RVA: 0x00A99598 File Offset: 0x00A97798
		public int GetDepth()
		{
			if (this.CurrentPanel == null || !this.CurrentPanel.IsValid() || !this.CurrentPanel.RootUIComp.IsValid(false, false))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "查找对象深度索引异常,对象无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			return this.CurrentPanel.RootUIComp.Get().GetFlattenHierarchyIndex();
		}

		// Token: 0x06025A7A RID: 154234 RVA: 0x00A9961A File Offset: 0x00A9781A
		private bool HasNavigation()
		{
			return this.State == EViewHandleState.HasNavigation;
		}

		// Token: 0x06025A7B RID: 154235 RVA: 0x00A9962C File Offset: 0x00A9782C
		private bool NeedFindAgain()
		{
			return this.State == EViewHandleState.NavigateNext || this.State == EViewHandleState.None;
		}

		// Token: 0x06025A7C RID: 154236 RVA: 0x00A99652 File Offset: 0x00A97852
		public bool HasNavigationButDisActive()
		{
			return this.State == EViewHandleState.HasNavigationButDisActive;
		}

		// Token: 0x06025A7D RID: 154237 RVA: 0x00A99664 File Offset: 0x00A97864
		public bool IsNonNavigation()
		{
			return this.State == EViewHandleState.NonNavigation;
		}

		// Token: 0x06025A7E RID: 154238 RVA: 0x00A99676 File Offset: 0x00A97876
		public void SetIsInController(bool value)
		{
			if (this.IsInController == value)
			{
				return;
			}
			this.IsInController = value;
			this.UpdateAllHotKeyVisibleMode();
			if (!value)
			{
				this.PauseNavigation();
			}
		}

		// Token: 0x06025A7F RID: 154239 RVA: 0x00A99698 File Offset: 0x00A97898
		public void ResetStateIfNullFocus()
		{
			if (this.FocusListener == null && this.IsNonNavigation())
			{
				this.State = EViewHandleState.None;
			}
		}

		// Token: 0x06025A80 RID: 154240 RVA: 0x00A996B5 File Offset: 0x00A978B5
		public void SetIsUsable(bool value)
		{
			this.IsUsable = value;
			if (!value)
			{
				this.ResetState();
			}
			UiNavigationViewManager.Instance.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06025A81 RID: 154241 RVA: 0x00A996D1 File Offset: 0x00A978D1
		public bool GetIsUsable()
		{
			return this.IsUsable;
		}

		// Token: 0x06025A82 RID: 154242 RVA: 0x00A996D9 File Offset: 0x00A978D9
		public void SetIsActive(bool value)
		{
			if (this.IsActive == value)
			{
				return;
			}
			this.IsActive = value;
			UiNavigationViewManager.Instance.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06025A83 RID: 154243 RVA: 0x00A996F6 File Offset: 0x00A978F6
		public bool GetIsActive()
		{
			return this.IsActive;
		}

		// Token: 0x06025A84 RID: 154244 RVA: 0x00A996FE File Offset: 0x00A978FE
		public TsUiNavigationBehaviorListener GetFocusListener()
		{
			return this.FocusListener;
		}

		// Token: 0x06025A85 RID: 154245 RVA: 0x00A99708 File Offset: 0x00A97908
		public List<TsUiNavigationBehaviorListener> GetActiveListenerListByTag(string tag)
		{
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in tsUiNavigationPanelConfig.GetListenerListByTag(tag))
				{
					if (tsUiNavigationBehaviorListener.IsListenerActive())
					{
						list.Add(tsUiNavigationBehaviorListener);
					}
				}
			}
			return list;
		}

		// Token: 0x06025A86 RID: 154246 RVA: 0x00A997AC File Offset: 0x00A979AC
		[return: Nullable(2)]
		public TsUiNavigationBehaviorListener GetActiveListenerByTag(string tag)
		{
			if (!(tag == "tag1"))
			{
				return this.GetActiveListenerByNormalTag(tag);
			}
			return this.GetActiveListenerByExitTag();
		}

		// Token: 0x06025A87 RID: 154247 RVA: 0x00A997CC File Offset: 0x00A979CC
		[return: Nullable(2)]
		private TsUiNavigationBehaviorListener GetActiveListenerByNormalTag(string tag)
		{
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in tsUiNavigationPanelConfig.GetListenerListByTag(tag))
				{
					if (tsUiNavigationBehaviorListener.IsListenerActive())
					{
						return tsUiNavigationBehaviorListener;
					}
				}
			}
			return null;
		}

		// Token: 0x06025A88 RID: 154248 RVA: 0x00A99868 File Offset: 0x00A97A68
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetActiveListenerByExitTag()
		{
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in tsUiNavigationPanelConfig.GetPanelHandle().GetListenerSet())
				{
					if (tsUiNavigationBehaviorListener.IsListenerActive() && tsUiNavigationBehaviorListener.TagArray.Contains("tag1"))
					{
						list.Add(tsUiNavigationBehaviorListener);
					}
				}
			}
			list.Sort(delegate(TsUiNavigationBehaviorListener aListener, TsUiNavigationBehaviorListener bListener)
			{
				if (aListener.ExitTagPriority >= bListener.ExitTagPriority)
				{
					return 1;
				}
				return -1;
			});
			if (list.Count <= 0)
			{
				return null;
			}
			return list[0];
		}

		// Token: 0x06025A89 RID: 154249 RVA: 0x00A99958 File Offset: 0x00A97B58
		[return: Nullable(2)]
		public NavigationGroup GetActiveNavigationGroupByNameCheckAll(string groupName)
		{
			NavigationGroup navigationGroup = null;
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				navigationGroup = tsUiNavigationPanelConfig.GetNavigationGroup(groupName);
				if (UiNavigationLogic.HasActiveListenerInGroup(navigationGroup))
				{
					return navigationGroup;
				}
			}
			return navigationGroup;
		}

		// Token: 0x06025A8A RID: 154250 RVA: 0x00A999C0 File Offset: 0x00A97BC0
		[return: Nullable(2)]
		public NavigationGroup GetNavigationGroupByName(string groupName)
		{
			TsUiNavigationPanelConfig currentPanel = this.CurrentPanel;
			if (currentPanel == null)
			{
				return null;
			}
			return currentPanel.GetNavigationGroup(groupName);
		}

		// Token: 0x06025A8B RID: 154251 RVA: 0x00A999D4 File Offset: 0x00A97BD4
		private void FindSuitablePanel()
		{
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				if (tsUiNavigationPanelConfig.IsInActive)
				{
					this.CurrentPanel = tsUiNavigationPanelConfig;
					break;
				}
			}
		}

		// Token: 0x06025A8C RID: 154252 RVA: 0x00A99A38 File Offset: 0x00A97C38
		public void AddPanelConfig(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			panelConfig.SetViewHandle(this);
			this.PanelConfigMap[tagId] = panelConfig;
			this.UpdateHotKeyVisibleMode(panelConfig);
			this.SetCurrentAddPanel(panelConfig);
			this.SkipMainPanelFallbackOnce = false;
		}

		// Token: 0x06025A8D RID: 154253 RVA: 0x00A99A64 File Offset: 0x00A97C64
		public void DeletePanelConfig(int tagId)
		{
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig;
			if (!this.PanelConfigMap.Remove(tagId, out tsUiNavigationPanelConfig))
			{
				return;
			}
			this.NonIndependentPanelFocusCache.Remove(tsUiNavigationPanelConfig);
			if (this.CurrentPanel == tsUiNavigationPanelConfig)
			{
				this.CurrentPanel = null;
				this.FocusListener = null;
				this.FindSuitableNavigation(false);
			}
			if (this.CurrentAddPanel == tsUiNavigationPanelConfig)
			{
				this.CurrentAddPanel = null;
				TsUiNavigationBehaviorListener focusListener = this.FocusListener;
				if (((focusListener != null) ? focusListener.PanelConfig : null) == tsUiNavigationPanelConfig)
				{
					this.FocusListener = null;
					this.FindSuitableNavigation(false);
				}
			}
			tsUiNavigationPanelConfig.SetViewHandle(null);
			this.DeleteScrollData(tsUiNavigationPanelConfig.TsScrollBarGroup);
		}

		// Token: 0x06025A8E RID: 154254 RVA: 0x00A99AF3 File Offset: 0x00A97CF3
		public OrderedDictionary<int, TsUiNavigationPanelConfig> GetPanelConfigMap()
		{
			return this.PanelConfigMap;
		}

		// Token: 0x06025A8F RID: 154255 RVA: 0x00A99AFC File Offset: 0x00A97CFC
		[NullableContext(2)]
		public TsUiNavigationPanelConfig GetPanelConfigByType(ESpecialPanelHandleDefine type)
		{
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				if (tsUiNavigationPanelConfig.GetPanelHandle().GetType() == type)
				{
					return tsUiNavigationPanelConfig;
				}
			}
			return null;
		}

		// Token: 0x06025A90 RID: 154256 RVA: 0x00A99B68 File Offset: 0x00A97D68
		public TsUiNavigationPanelConfig GetCurrentPanel()
		{
			return this.CurrentPanel;
		}

		// Token: 0x06025A91 RID: 154257 RVA: 0x00A99B70 File Offset: 0x00A97D70
		public void ClearPanelConfig()
		{
			this.PanelConfigMap.Clear();
			this.NonIndependentPanelFocusCache.Clear();
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal != null)
			{
				gamepadControlInternal.Clear();
			}
			this.CurrentPanel = null;
		}

		// Token: 0x06025A92 RID: 154258 RVA: 0x00A99BA0 File Offset: 0x00A97DA0
		public void SetCurrentAddPanel(TsUiNavigationPanelConfig panelConfig)
		{
			this.CurrentAddPanel = panelConfig;
			UiNavigationGlobalData.NeedRefreshPanelId = this.TagId;
		}

		// Token: 0x06025A93 RID: 154259 RVA: 0x00A99BB4 File Offset: 0x00A97DB4
		public bool HasAnyPanelActive()
		{
			using (OrderedDictionary<int, TsUiNavigationPanelConfig>.ValueCollection.Enumerator enumerator = this.PanelConfigMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsInActive)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06025A94 RID: 154260 RVA: 0x00A99C14 File Offset: 0x00A97E14
		private void ResumeNavigation()
		{
			TsUiNavigationBehaviorListener focusListener = this.FocusListener;
			if (focusListener != null && focusListener.IsValid() && focusListener.GetScrollOrLayoutActor() != null && focusListener.IsInScrollOrLayoutAnimation())
			{
				NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
				if (navigationGroup == null || navigationGroup.WaitScrollAnimation)
				{
					return;
				}
			}
			this.ScrollBallData.ResumeLastListener();
			TsUiNavigationBehaviorListener resumeListener = this.GetResumeListener();
			if (resumeListener != null)
			{
				this.State = EViewHandleState.HasNavigation;
				UiNavigationNewController.Instance.SwitchNavigationFocus(resumeListener);
				return;
			}
			this.State = EViewHandleState.None;
			this.FocusListener = null;
		}

		// Token: 0x06025A95 RID: 154261 RVA: 0x00A99C94 File Offset: 0x00A97E94
		private bool HasOtherActiveSubPanel()
		{
			TsUiNavigationBehaviorListener focusListener = this.FocusListener;
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = (focusListener != null) ? focusListener.PanelConfig : null;
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig2 in this.PanelConfigMap.Values)
			{
				if (tsUiNavigationPanelConfig2 != tsUiNavigationPanelConfig && tsUiNavigationPanelConfig2 != this.MainPanel && tsUiNavigationPanelConfig2.IsInActive)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06025A96 RID: 154262 RVA: 0x00A99D14 File Offset: 0x00A97F14
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetResumeListener()
		{
			TsUiNavigationBehaviorListener focusListener = this.FocusListener;
			if (focusListener == null || !focusListener.IsValid())
			{
				return null;
			}
			if (this.FocusListener.IsInScrollOrLayoutCanFocus())
			{
				if (this.FocusListener.ScrollProxy == null || !this.FocusListener.ScrollProxy.HasMultiTemplateScrollView())
				{
					return this.FocusListener;
				}
				UiNavigationScrollProxy scrollProxy = this.FocusListener.ScrollProxy;
				if (scrollProxy == null)
				{
					return null;
				}
				return scrollProxy.GetCurrentFocusListenerInMultiTemplateScrollView();
			}
			else
			{
				NavigationGroup navigationGroup = this.FocusListener.GetNavigationGroup();
				AActor scrollOrLayoutActor = this.FocusListener.GetScrollOrLayoutActor();
				int i = 0;
				int count = navigationGroup.ListenerList.Count;
				while (i < count)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = navigationGroup.ListenerList[i];
					if (tsUiNavigationBehaviorListener.IsScrollOrLayoutActor() && (scrollOrLayoutActor == null || tsUiNavigationBehaviorListener.GetScrollOrLayoutActor() == scrollOrLayoutActor) && tsUiNavigationBehaviorListener.IsInScrollOrLayoutCanFocus())
					{
						return tsUiNavigationBehaviorListener;
					}
					i++;
				}
				if (this.FocusListener.IsListenerActive())
				{
					return this.FocusListener;
				}
				return null;
			}
		}

		// Token: 0x06025A97 RID: 154263 RVA: 0x00A99DF9 File Offset: 0x00A97FF9
		private void PauseNavigation()
		{
			if (this.HasNavigation())
			{
				this.State = EViewHandleState.HasNavigationButDisActive;
				UiNavigationModel instance = UiNavigationModel.Instance;
				if (instance != null)
				{
					instance.SetCursorFollowItem(null);
				}
				TsUiNavigationBehaviorListener focusListener = this.FocusListener;
				if (focusListener == null)
				{
					return;
				}
				UiNavigationScrollProxy scrollProxy = focusListener.ScrollProxy;
				if (scrollProxy == null)
				{
					return;
				}
				scrollProxy.RecordFocusListenerIndexInMultiTemplateScrollView();
			}
		}

		// Token: 0x06025A98 RID: 154264 RVA: 0x00A99E39 File Offset: 0x00A98039
		public void FindDefaultNavigation()
		{
			if (this.SwitchNavigationFocusListener != null)
			{
				return;
			}
			if (this.HasNavigationButDisActive())
			{
				this.ResumeNavigation();
				return;
			}
			if (this.NeedFindAgain())
			{
				this.FindSuitableNavigation(true);
			}
		}

		// Token: 0x06025A99 RID: 154265 RVA: 0x00A99E64 File Offset: 0x00A98064
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener TryRestoreNonIndependentPanelFocus()
		{
			foreach (KeyValuePair<TsUiNavigationPanelConfig, TsUiNavigationBehaviorListener> keyValuePair in this.NonIndependentPanelFocusCache)
			{
				TsUiNavigationPanelConfig tsUiNavigationPanelConfig;
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener;
				keyValuePair.Deconstruct(out tsUiNavigationPanelConfig, out tsUiNavigationBehaviorListener);
				TsUiNavigationPanelConfig tsUiNavigationPanelConfig2 = tsUiNavigationPanelConfig;
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = tsUiNavigationBehaviorListener;
				if (tsUiNavigationPanelConfig2.IsInActive)
				{
					this.NonIndependentPanelFocusCache.Remove(tsUiNavigationPanelConfig2);
					if (tsUiNavigationBehaviorListener2.IsValid() && (tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus() || tsUiNavigationBehaviorListener2.IsListenerActive()))
					{
						return tsUiNavigationBehaviorListener2;
					}
				}
			}
			return null;
		}

		// Token: 0x06025A9A RID: 154266 RVA: 0x00A99EF8 File Offset: 0x00A980F8
		public void FindSuitableNavigation(bool isDefault)
		{
			TsUiNavigationPanelConfig mainPanel = this.MainPanel;
			if (mainPanel != null && mainPanel.IsGamepadControlMouse)
			{
				return;
			}
			if (this.CurrentPanel == null || this.ResetCurrentPanelDirty)
			{
				this.ResetCurrentPanelDirty = false;
				this.FindSuitablePanel();
			}
			if (this.CurrentPanel == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "找不到合适的导航面板";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.FocusListener != null)
			{
				this.State = EViewHandleState.HasNavigation;
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.TryRestoreNonIndependentPanelFocus();
			if (tsUiNavigationBehaviorListener != null)
			{
				this.State = EViewHandleState.HasNavigation;
				UiNavigationNewController.Instance.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
				return;
			}
			this.CurrentPanel.FindSuitableNavigation(isDefault);
			if (this.IsNonNavigation())
			{
				this.MarkRefreshHotKeyDirty();
				this.FindNavigationInAllPanel(this.CurrentPanel, isDefault);
			}
		}

		// Token: 0x06025A9B RID: 154267 RVA: 0x00A99FCC File Offset: 0x00A981CC
		public void FindAddPanelConfigNavigation()
		{
			if (!this.IsNonNavigation())
			{
				return;
			}
			if (this.CurrentAddPanel == null)
			{
				return;
			}
			if (!this.CurrentAddPanel.Independent)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.TryRestoreNonIndependentPanelFocus();
				if (tsUiNavigationBehaviorListener != null)
				{
					this.State = EViewHandleState.HasNavigation;
					UiNavigationNewController.Instance.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
					return;
				}
			}
			this.CurrentAddPanel.FindSuitableNavigation(false);
			if (this.IsNonNavigation())
			{
				this.FindNavigationInAllPanel(this.CurrentAddPanel, false);
			}
		}

		// Token: 0x06025A9C RID: 154268 RVA: 0x00A9A03A File Offset: 0x00A9823A
		public void NotifyWaitingScrollPanelHidden()
		{
			this.SkipMainPanelFallbackOnce = true;
		}

		// Token: 0x06025A9D RID: 154269 RVA: 0x00A9A044 File Offset: 0x00A98244
		private void FindNavigationInAllPanel(TsUiNavigationPanelConfig excludePanelConfig, bool isDefault)
		{
			if (this.SkipMainPanelFallbackOnce)
			{
				this.SkipMainPanelFallbackOnce = false;
				this.State = EViewHandleState.NavigateNext;
				return;
			}
			if (excludePanelConfig.FirstFindFromSubPanelWhenFindNone)
			{
				foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
				{
					if (tsUiNavigationPanelConfig != excludePanelConfig && tsUiNavigationPanelConfig != this.MainPanel)
					{
						if (!this.IsNonNavigation())
						{
							break;
						}
						tsUiNavigationPanelConfig.FindSuitableNavigation(isDefault);
					}
				}
				if (this.IsNonNavigation())
				{
					TsUiNavigationPanelConfig mainPanel = this.MainPanel;
					if (mainPanel == null)
					{
						return;
					}
					mainPanel.FindSuitableNavigation(isDefault);
					return;
				}
			}
			else
			{
				foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig2 in this.PanelConfigMap.Values)
				{
					if (tsUiNavigationPanelConfig2 != excludePanelConfig)
					{
						if (!this.IsNonNavigation())
						{
							break;
						}
						tsUiNavigationPanelConfig2.FindSuitableNavigation(isDefault);
					}
				}
			}
		}

		// Token: 0x06025A9E RID: 154270 RVA: 0x00A9A148 File Offset: 0x00A98348
		public void NotifySuitableNavigation(FindNavigationResult result)
		{
			if (result.IsFindNavigation())
			{
				this.State = EViewHandleState.HasNavigation;
				UiNavigationNewController.Instance.SwitchNavigationFocus(result.Listener);
				return;
			}
			if (!result.IsNotFindNavigation())
			{
				if (this.FocusListener != null)
				{
					UiNavigationNewController.Instance.SwitchNavigationFocus(result.Listener);
				}
				this.State = EViewHandleState.NavigateNext;
				return;
			}
			if (this.IsUsable)
			{
				this.State = EViewHandleState.NonNavigation;
				UiNavigationNewController.Instance.SwitchNavigationFocus(result.Listener);
				return;
			}
			this.ResetState();
		}

		// Token: 0x06025A9F RID: 154271 RVA: 0x00A9A1CF File Offset: 0x00A983CF
		public void MarkRefreshScrollDataDirty()
		{
			this.RefreshScrollDataDirty = true;
		}

		// Token: 0x06025AA0 RID: 154272 RVA: 0x00A9A1D8 File Offset: 0x00A983D8
		private void RefreshScrollData()
		{
			if (!this.RefreshScrollDataDirty)
			{
				return;
			}
			this.RefreshScrollDataDirty = false;
			List<NavigationGroup> list = new List<NavigationGroup>();
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				if (tsUiNavigationPanelConfig.TsScrollBarGroup != null)
				{
					list.Add(tsUiNavigationPanelConfig.TsScrollBarGroup);
				}
			}
			this.AddScrollData(list);
			this.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025AA1 RID: 154273 RVA: 0x00A9A260 File Offset: 0x00A98460
		private void AddScrollData(List<NavigationGroup> groupArray)
		{
			this.ScrollBallData.AddScrollbar(groupArray);
		}

		// Token: 0x06025AA2 RID: 154274 RVA: 0x00A9A26E File Offset: 0x00A9846E
		[NullableContext(2)]
		private void DeleteScrollData(NavigationGroup group)
		{
			this.ScrollBallData.DeleteScrollbar(group);
		}

		// Token: 0x06025AA3 RID: 154275 RVA: 0x00A9A27C File Offset: 0x00A9847C
		public void FindNextScrollData()
		{
			NavigationScrollbarData scrollBallData = this.ScrollBallData;
			if (scrollBallData == null)
			{
				return;
			}
			scrollBallData.FindNextScrollbar();
		}

		// Token: 0x06025AA4 RID: 154276 RVA: 0x00A9A28E File Offset: 0x00A9848E
		public void TryFindScrollData()
		{
			NavigationScrollbarData scrollBallData = this.ScrollBallData;
			if (scrollBallData == null)
			{
				return;
			}
			scrollBallData.TryFindScrollbar();
		}

		// Token: 0x06025AA5 RID: 154277 RVA: 0x00A9A2A0 File Offset: 0x00A984A0
		public NavigationScrollbarData GetScrollbarData()
		{
			return this.ScrollBallData;
		}

		// Token: 0x06025AA6 RID: 154278 RVA: 0x00A9A2A8 File Offset: 0x00A984A8
		[NullableContext(2)]
		public unsafe void UpdateFocus(TsUiNavigationBehaviorListener listener)
		{
			if (this.HasGamepadControlMouse())
			{
				return;
			}
			bool flag = this.FocusListener == listener;
			if (this.FocusListener != null && !flag)
			{
				this.FocusListener.ResetNavigationState();
			}
			TsUiNavigationBehaviorListener focusListener = this.FocusListener;
			if (focusListener != null && focusListener.PanelConfig != null && !this.FocusListener.PanelConfig.Independent && this.FocusListener.PanelConfig.NeedCacheListener)
			{
				this.NonIndependentPanelFocusCache[this.FocusListener.PanelConfig] = this.FocusListener;
			}
			this.FocusListener = listener;
			if (listener != null)
			{
				this.CurrentPanel = listener.PanelConfig;
			}
			if (this.IsInController)
			{
				if (UiNavigationModel.Instance.IsOpenLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiNavigation;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "设置当前的导航对象";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DisplayName", (listener != null) ? listener.RootUIComp.Get().displayName : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", this.ViewName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Path", (listener != null) ? UiNavigationUtil.GetFullPathOfActor(listener.GetOwner()) : "");
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				UiNavigationLogic.UpdateNavigationListener(listener);
				if (listener != null)
				{
					this.State = EViewHandleState.HasNavigation;
					listener.ActiveNavigationState(flag);
				}
			}
			this.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025AA7 RID: 154279 RVA: 0x00A9A420 File Offset: 0x00A98620
		public void ResetNavigationListener()
		{
			this.ResetState();
			this.MarkResetCurrentPanelDirty();
			this.ClearDynamicScrollViewNavigationContext();
		}

		// Token: 0x06025AA8 RID: 154280 RVA: 0x00A9A434 File Offset: 0x00A98634
		public void MarkResetCurrentPanelDirty()
		{
			this.ResetCurrentPanelDirty = true;
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x06025AA9 RID: 154281 RVA: 0x00A9A43D File Offset: 0x00A9863D
		public bool IsListenerCanFocusByPanelConfig
		{
			get
			{
				return UiNavigationViewManager.Instance.CanFocusViewHandle(this);
			}
		}

		// Token: 0x06025AAA RID: 154282 RVA: 0x00A9A44A File Offset: 0x00A9864A
		public void UpdateHotKeyVisibleMode(TsUiNavigationPanelConfig panelConfig)
		{
			if (this.IsInController)
			{
				panelConfig.SetHotKeyVisibleMode(HotKeyViewDefine.ELogicMode.BlockView, true);
			}
			else
			{
				panelConfig.SetHotKeyVisibleMode(HotKeyViewDefine.ELogicMode.BlockView, false);
			}
			this.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025AAB RID: 154283 RVA: 0x00A9A46C File Offset: 0x00A9866C
		public void UpdateAllHotKeyVisibleMode()
		{
			foreach (TsUiNavigationPanelConfig panelConfig in this.PanelConfigMap.Values)
			{
				this.UpdateHotKeyVisibleMode(panelConfig);
			}
		}

		// Token: 0x06025AAC RID: 154284 RVA: 0x00A9A4C4 File Offset: 0x00A986C4
		private void RefreshHotKeyComponents()
		{
			if (!this.RefreshHotKeyDirty)
			{
				return;
			}
			this.RefreshHotKeyDirty = false;
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				tsUiNavigationPanelConfig.RefreshHotKeyComponents();
			}
		}

		// Token: 0x06025AAD RID: 154285 RVA: 0x00A9A52C File Offset: 0x00A9872C
		public void MarkRefreshHotKeyDirty()
		{
			this.RefreshHotKeyDirty = true;
		}

		// Token: 0x06025AAE RID: 154286 RVA: 0x00A9A538 File Offset: 0x00A98738
		private void RefreshHotKeyTextId()
		{
			if (!this.RefreshHotKeyTextIdDirty)
			{
				return;
			}
			this.RefreshHotKeyTextIdDirty = false;
			foreach (TsUiNavigationPanelConfig tsUiNavigationPanelConfig in this.PanelConfigMap.Values)
			{
				tsUiNavigationPanelConfig.RefreshHotKeyTextId();
			}
		}

		// Token: 0x06025AAF RID: 154287 RVA: 0x00A9A5A0 File Offset: 0x00A987A0
		public void MarkRefreshHotKeyTextIdDirty()
		{
			this.RefreshHotKeyTextIdDirty = true;
		}

		// Token: 0x06025AB0 RID: 154288 RVA: 0x00A9A5A9 File Offset: 0x00A987A9
		private void RefreshNavigation()
		{
			if (!this.RefreshNavigationDirty)
			{
				return;
			}
			this.RefreshNavigationDirty = false;
			if (UiNavigationViewManager.Instance.NeedSkipFindNavigationByCache() || this.SwitchNavigationFocusListener != null)
			{
				this.IsRefreshNavigationSwallowed = true;
				return;
			}
			this.ResetState();
			this.FindSuitableNavigation(false);
		}

		// Token: 0x06025AB1 RID: 154289 RVA: 0x00A9A5E4 File Offset: 0x00A987E4
		public void RestoreSwallowedRefreshNavigation()
		{
			if (!this.IsRefreshNavigationSwallowed)
			{
				return;
			}
			this.IsRefreshNavigationSwallowed = false;
			this.RefreshNavigationDirty = true;
		}

		// Token: 0x06025AB2 RID: 154290 RVA: 0x00A9A5FD File Offset: 0x00A987FD
		public void DiscardSwallowedRefreshNavigation()
		{
			this.IsRefreshNavigationSwallowed = false;
		}

		// Token: 0x06025AB3 RID: 154291 RVA: 0x00A9A606 File Offset: 0x00A98806
		public void MarkRefreshNavigationDirty(int instanceId = 0)
		{
			this.RefreshListenerInstanceId = instanceId;
			this.RefreshNavigationDirty = true;
		}

		// Token: 0x06025AB4 RID: 154292 RVA: 0x00A9A616 File Offset: 0x00A98816
		public void ResetNavigationDirty(int instanceId = 0)
		{
			if (this.RefreshListenerInstanceId != 0 && instanceId != 0 && this.RefreshListenerInstanceId != instanceId)
			{
				return;
			}
			this.RefreshNavigationDirty = false;
		}

		// Token: 0x06025AB5 RID: 154293 RVA: 0x00A9A634 File Offset: 0x00A98834
		private void RefreshSwitchNavigationFocus()
		{
			if (this.SwitchNavigationFocusListener == null)
			{
				return;
			}
			if (!this.SwitchNavigationFocusListener.IsValid())
			{
				this.SwitchNavigationFocusListener = null;
				this.RestoreSwallowedRefreshNavigation();
				return;
			}
			UiNavigationNewController.Instance.SwitchNavigationFocus(this.SwitchNavigationFocusListener);
			this.SwitchNavigationFocusListener = null;
			this.DiscardSwallowedRefreshNavigation();
		}

		// Token: 0x06025AB6 RID: 154294 RVA: 0x00A9A682 File Offset: 0x00A98882
		[NullableContext(2)]
		public void MarkSwitchNavigationFocusDirty(TsUiNavigationBehaviorListener listener)
		{
			this.SwitchNavigationFocusListener = listener;
		}

		// Token: 0x06025AB7 RID: 154295 RVA: 0x00A9A68C File Offset: 0x00A9888C
		private void InitGamepadControlMouse()
		{
			if (this.HasGamepadControlMouse())
			{
				this.GamepadControlInternal = new GamepadControlMouse(this.MainPanel.GamepadMouseItem, this);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "UiNavigation:GamepadControlMouse 初始化手柄控制鼠标";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", this.ViewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06025AB8 RID: 154296 RVA: 0x00A9A6E7 File Offset: 0x00A988E7
		private void RefreshGamepadControl(float deltaTime)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.Tick(deltaTime);
		}

		// Token: 0x06025AB9 RID: 154297 RVA: 0x00A9A6FA File Offset: 0x00A988FA
		public bool HasGamepadControlMouse()
		{
			TsUiNavigationPanelConfig mainPanel = this.MainPanel;
			return mainPanel != null && mainPanel.IsGamepadControlMouse;
		}

		// Token: 0x06025ABA RID: 154298 RVA: 0x00A9A70D File Offset: 0x00A9890D
		public void CanOverridePositionByGamepad(bool value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.CanOverridePosition(value);
		}

		// Token: 0x06025ABB RID: 154299 RVA: 0x00A9A720 File Offset: 0x00A98920
		public void SetGamepadMouseMoveForward(float value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.MoveForwardByGamepad(value);
		}

		// Token: 0x06025ABC RID: 154300 RVA: 0x00A9A733 File Offset: 0x00A98933
		public void SetGamepadMouseMoveRight(float value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.MoveRightByGamepad(value);
		}

		// Token: 0x06025ABD RID: 154301 RVA: 0x00A9A746 File Offset: 0x00A98946
		public void SetGamepadMouseTrigger(bool isPress)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.TriggerByGamepad(isPress);
		}

		// Token: 0x06025ABE RID: 154302 RVA: 0x00A9A759 File Offset: 0x00A98959
		public void UpdateMousePositionByItem(UUIItem uiItem)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.UpdateMousePositionByItem(uiItem);
		}

		// Token: 0x06025ABF RID: 154303 RVA: 0x00A9A76C File Offset: 0x00A9896C
		public void UpdateMousePositionForGuide(UUIItem uiItem)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.UpdateMousePositionForGuide(uiItem);
		}

		// Token: 0x06025AC0 RID: 154304 RVA: 0x00A9A77F File Offset: 0x00A9897F
		public void ResetNavigationFocusForGuide()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.ResetNavigationFocusForGuide();
		}

		// Token: 0x06025AC1 RID: 154305 RVA: 0x00A9A791 File Offset: 0x00A98991
		public bool IsGamepadHitListenerUseDrag()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			return gamepadControlInternal != null && gamepadControlInternal.IsNearlyListenerUseDrag();
		}

		// Token: 0x06025AC2 RID: 154306 RVA: 0x00A9A7A4 File Offset: 0x00A989A4
		public void SetLockUseDragState(bool value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.SetLockUseDragState(value);
		}

		// Token: 0x06025AC3 RID: 154307 RVA: 0x00A9A7B7 File Offset: 0x00A989B7
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetHitComponentListener()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return null;
			}
			return gamepadControlInternal.GetHitComponentListener();
		}

		// Token: 0x06025AC4 RID: 154308 RVA: 0x00A9A7CA File Offset: 0x00A989CA
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetGuideUiListener()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return null;
			}
			return gamepadControlInternal.GetGuideUiListener();
		}

		// Token: 0x06025AC5 RID: 154309 RVA: 0x00A9A7DD File Offset: 0x00A989DD
		[NullableContext(2)]
		public TsUiNavigationBehaviorListener GetAdsorbedListener()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return null;
			}
			return gamepadControlInternal.GetAdsorbedListener();
		}

		// Token: 0x06025AC6 RID: 154310 RVA: 0x00A9A7F0 File Offset: 0x00A989F0
		public void NotifyNavigationMousePositionDragState(bool state)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.NotifyNavigationMousePositionDragState(state);
		}

		// Token: 0x06025AC7 RID: 154311 RVA: 0x00A9A803 File Offset: 0x00A98A03
		[NullableContext(2)]
		public Vector2D GetMouseViewportPosition()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return null;
			}
			return gamepadControlInternal.GetMouseViewportPosition();
		}

		// Token: 0x06025AC8 RID: 154312 RVA: 0x00A9A816 File Offset: 0x00A98A16
		public bool IsNavigationMousePositionDragging()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			return gamepadControlInternal != null && gamepadControlInternal.IsNavigationMousePositionDragging();
		}

		// Token: 0x06025AC9 RID: 154313 RVA: 0x00A9A829 File Offset: 0x00A98A29
		public void SetDynamicScrollViewNavigationContext(NavigationDynamicScrollViewFindContext context)
		{
			if (this.DynamicScrollViewNavigationContext != null)
			{
				return;
			}
			this.DynamicScrollViewNavigationContext = context;
		}

		// Token: 0x06025ACA RID: 154314 RVA: 0x00A9A83B File Offset: 0x00A98A3B
		public void ClearDynamicScrollViewNavigationContext()
		{
			this.DynamicScrollViewNavigationContext = null;
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x06025ACB RID: 154315 RVA: 0x00A9A844 File Offset: 0x00A98A44
		public bool IsWaitToFindDynamicGrid
		{
			get
			{
				return this.DynamicScrollViewNavigationContext != null;
			}
		}

		// Token: 0x06025ACC RID: 154316 RVA: 0x00A9A84F File Offset: 0x00A98A4F
		[NullableContext(2)]
		public NavigationDynamicScrollViewFindContext GetDynamicScrollViewNavigationContext()
		{
			return this.DynamicScrollViewNavigationContext;
		}

		// Token: 0x06025ACD RID: 154317 RVA: 0x00A9A857 File Offset: 0x00A98A57
		public void TickViewHandle(float deltaTime)
		{
			this.RefreshNavigation();
			this.RefreshHotKeyComponents();
			this.RefreshHotKeyTextId();
			this.RefreshScrollData();
			this.RefreshSwitchNavigationFocus();
			this.RefreshGamepadControl(deltaTime);
		}

		// Token: 0x04014CCF RID: 85199
		public readonly int TagId;

		// Token: 0x04014CD0 RID: 85200
		public readonly string ViewName;

		// Token: 0x04014CD1 RID: 85201
		private readonly OrderedDictionary<int, TsUiNavigationPanelConfig> PanelConfigMap = new OrderedDictionary<int, TsUiNavigationPanelConfig>();

		// Token: 0x04014CD2 RID: 85202
		[Nullable(2)]
		public readonly TsUiNavigationPanelConfig MainPanel;

		// Token: 0x04014CD3 RID: 85203
		[Nullable(2)]
		private TsUiNavigationPanelConfig CurrentPanel;

		// Token: 0x04014CD4 RID: 85204
		[Nullable(2)]
		private TsUiNavigationPanelConfig CurrentAddPanel;

		// Token: 0x04014CD5 RID: 85205
		[Nullable(2)]
		private TsUiNavigationBehaviorListener FocusListener;

		// Token: 0x04014CD6 RID: 85206
		private bool IsInController = true;

		// Token: 0x04014CD7 RID: 85207
		private bool IsActive = true;

		// Token: 0x04014CD8 RID: 85208
		private bool IsUsable = true;

		// Token: 0x04014CD9 RID: 85209
		private readonly Dictionary<TsUiNavigationPanelConfig, TsUiNavigationBehaviorListener> NonIndependentPanelFocusCache = new Dictionary<TsUiNavigationPanelConfig, TsUiNavigationBehaviorListener>();

		// Token: 0x04014CDA RID: 85210
		private readonly NavigationScrollbarData ScrollBallData;

		// Token: 0x04014CDB RID: 85211
		private EViewHandleState StateInternal = EViewHandleState.None;

		// Token: 0x04014CDC RID: 85212
		private bool ResetCurrentPanelDirty;

		// Token: 0x04014CDD RID: 85213
		private bool SkipMainPanelFallbackOnce;

		// Token: 0x04014CDE RID: 85214
		private readonly Stat StatsObject = Stat.Create("UiNavigationViewHandle", "", "");

		// Token: 0x04014CDF RID: 85215
		private bool RefreshScrollDataDirty;

		// Token: 0x04014CE0 RID: 85216
		private bool RefreshHotKeyDirty;

		// Token: 0x04014CE1 RID: 85217
		private bool RefreshHotKeyTextIdDirty;

		// Token: 0x04014CE2 RID: 85218
		private bool RefreshNavigationDirty;

		// Token: 0x04014CE3 RID: 85219
		private int RefreshListenerInstanceId;

		// Token: 0x04014CE4 RID: 85220
		private bool IsRefreshNavigationSwallowed;

		// Token: 0x04014CE5 RID: 85221
		[Nullable(2)]
		private TsUiNavigationBehaviorListener SwitchNavigationFocusListener;

		// Token: 0x04014CE6 RID: 85222
		[Nullable(2)]
		private GamepadControlMouse GamepadControlInternal;

		// Token: 0x04014CE7 RID: 85223
		[Nullable(2)]
		private NavigationDynamicScrollViewFindContext DynamicScrollViewNavigationContext;
	}
}
