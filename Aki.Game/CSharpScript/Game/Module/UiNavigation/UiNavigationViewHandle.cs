using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004947 RID: 18759
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationViewHandle
	{
		// Token: 0x170079D5 RID: 31189
		// (get) Token: 0x06030F49 RID: 200521 RVA: 0x00B5E61E File Offset: 0x00B5C81E
		// (set) Token: 0x06030F4A RID: 200522 RVA: 0x00B5E626 File Offset: 0x00B5C826
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

		// Token: 0x06030F4B RID: 200523 RVA: 0x00B5E63C File Offset: 0x00B5C83C
		public UiNavigationViewHandle(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			this.TagId = tagId;
			this.ViewName = panelConfig.ViewName;
			this.MainPanel = panelConfig;
			this.CurrentPanel = panelConfig;
			this.ScrollBallData = new NavigationScrollbarData();
			this.InitGamepadControlMouse();
		}

		// Token: 0x06030F4C RID: 200524 RVA: 0x00B5E6D4 File Offset: 0x00B5C8D4
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

		// Token: 0x06030F4D RID: 200525 RVA: 0x00B5E754 File Offset: 0x00B5C954
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

		// Token: 0x06030F4E RID: 200526 RVA: 0x00B5E7D6 File Offset: 0x00B5C9D6
		private bool HasNavigation()
		{
			return this.State == EViewHandleState.HasNavigation;
		}

		// Token: 0x06030F4F RID: 200527 RVA: 0x00B5E7E8 File Offset: 0x00B5C9E8
		private bool NeedFindAgain()
		{
			return this.State == EViewHandleState.NavigateNext || this.State == EViewHandleState.None;
		}

		// Token: 0x06030F50 RID: 200528 RVA: 0x00B5E80E File Offset: 0x00B5CA0E
		public bool HasNavigationButDisActive()
		{
			return this.State == EViewHandleState.HasNavigationButDisActive;
		}

		// Token: 0x06030F51 RID: 200529 RVA: 0x00B5E820 File Offset: 0x00B5CA20
		public bool IsNonNavigation()
		{
			return this.State == EViewHandleState.NonNavigation;
		}

		// Token: 0x06030F52 RID: 200530 RVA: 0x00B5E832 File Offset: 0x00B5CA32
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

		// Token: 0x06030F53 RID: 200531 RVA: 0x00B5E854 File Offset: 0x00B5CA54
		public void ResetStateIfNullFocus()
		{
			if (this.FocusListener == null && this.IsNonNavigation())
			{
				this.State = EViewHandleState.None;
			}
		}

		// Token: 0x06030F54 RID: 200532 RVA: 0x00B5E871 File Offset: 0x00B5CA71
		public void SetIsUsable(bool value)
		{
			this.IsUsable = value;
			if (!value)
			{
				this.ResetState();
			}
			UiNavigationViewManager.Instance.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06030F55 RID: 200533 RVA: 0x00B5E88D File Offset: 0x00B5CA8D
		public bool GetIsUsable()
		{
			return this.IsUsable;
		}

		// Token: 0x06030F56 RID: 200534 RVA: 0x00B5E895 File Offset: 0x00B5CA95
		public void SetIsActive(bool value)
		{
			if (this.IsActive == value)
			{
				return;
			}
			this.IsActive = value;
			UiNavigationViewManager.Instance.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06030F57 RID: 200535 RVA: 0x00B5E8B2 File Offset: 0x00B5CAB2
		public bool GetIsActive()
		{
			return this.IsActive;
		}

		// Token: 0x06030F58 RID: 200536 RVA: 0x00B5E8BA File Offset: 0x00B5CABA
		public TsUiNavigationBehaviorListener GetFocusListener()
		{
			return this.FocusListener;
		}

		// Token: 0x06030F59 RID: 200537 RVA: 0x00B5E8C4 File Offset: 0x00B5CAC4
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

		// Token: 0x06030F5A RID: 200538 RVA: 0x00B5E968 File Offset: 0x00B5CB68
		[return: Nullable(2)]
		public TsUiNavigationBehaviorListener GetActiveListenerByTag(string tag)
		{
			if (!(tag == "tag1"))
			{
				return this.GetActiveListenerByNormalTag(tag);
			}
			return this.GetActiveListenerByExitTag();
		}

		// Token: 0x06030F5B RID: 200539 RVA: 0x00B5E988 File Offset: 0x00B5CB88
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

		// Token: 0x06030F5C RID: 200540 RVA: 0x00B5EA24 File Offset: 0x00B5CC24
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

		// Token: 0x06030F5D RID: 200541 RVA: 0x00B5EB14 File Offset: 0x00B5CD14
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

		// Token: 0x06030F5E RID: 200542 RVA: 0x00B5EB7C File Offset: 0x00B5CD7C
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

		// Token: 0x06030F5F RID: 200543 RVA: 0x00B5EB90 File Offset: 0x00B5CD90
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

		// Token: 0x06030F60 RID: 200544 RVA: 0x00B5EBF4 File Offset: 0x00B5CDF4
		public void AddPanelConfig(int tagId, TsUiNavigationPanelConfig panelConfig)
		{
			panelConfig.SetViewHandle(this);
			this.PanelConfigMap[tagId] = panelConfig;
			this.UpdateHotKeyVisibleMode(panelConfig);
			this.SetCurrentAddPanel(panelConfig);
			this.SkipMainPanelFallbackOnce = false;
		}

		// Token: 0x06030F61 RID: 200545 RVA: 0x00B5EC20 File Offset: 0x00B5CE20
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

		// Token: 0x06030F62 RID: 200546 RVA: 0x00B5ECAF File Offset: 0x00B5CEAF
		public OrderedDictionary<int, TsUiNavigationPanelConfig> GetPanelConfigMap()
		{
			return this.PanelConfigMap;
		}

		// Token: 0x06030F63 RID: 200547 RVA: 0x00B5ECB8 File Offset: 0x00B5CEB8
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

		// Token: 0x06030F64 RID: 200548 RVA: 0x00B5ED24 File Offset: 0x00B5CF24
		public TsUiNavigationPanelConfig GetCurrentPanel()
		{
			return this.CurrentPanel;
		}

		// Token: 0x06030F65 RID: 200549 RVA: 0x00B5ED2C File Offset: 0x00B5CF2C
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

		// Token: 0x06030F66 RID: 200550 RVA: 0x00B5ED5C File Offset: 0x00B5CF5C
		public void SetCurrentAddPanel(TsUiNavigationPanelConfig panelConfig)
		{
			this.CurrentAddPanel = panelConfig;
			UiNavigationGlobalData.NeedRefreshPanelId = this.TagId;
		}

		// Token: 0x06030F67 RID: 200551 RVA: 0x00B5ED70 File Offset: 0x00B5CF70
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

		// Token: 0x06030F68 RID: 200552 RVA: 0x00B5EDD0 File Offset: 0x00B5CFD0
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

		// Token: 0x06030F69 RID: 200553 RVA: 0x00B5EE50 File Offset: 0x00B5D050
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

		// Token: 0x06030F6A RID: 200554 RVA: 0x00B5EED0 File Offset: 0x00B5D0D0
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

		// Token: 0x06030F6B RID: 200555 RVA: 0x00B5EFB5 File Offset: 0x00B5D1B5
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

		// Token: 0x06030F6C RID: 200556 RVA: 0x00B5EFF5 File Offset: 0x00B5D1F5
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

		// Token: 0x06030F6D RID: 200557 RVA: 0x00B5F020 File Offset: 0x00B5D220
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

		// Token: 0x06030F6E RID: 200558 RVA: 0x00B5F0B4 File Offset: 0x00B5D2B4
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

		// Token: 0x06030F6F RID: 200559 RVA: 0x00B5F188 File Offset: 0x00B5D388
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

		// Token: 0x06030F70 RID: 200560 RVA: 0x00B5F1F6 File Offset: 0x00B5D3F6
		public void NotifyWaitingScrollPanelHidden()
		{
			this.SkipMainPanelFallbackOnce = true;
		}

		// Token: 0x06030F71 RID: 200561 RVA: 0x00B5F200 File Offset: 0x00B5D400
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

		// Token: 0x06030F72 RID: 200562 RVA: 0x00B5F304 File Offset: 0x00B5D504
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

		// Token: 0x06030F73 RID: 200563 RVA: 0x00B5F38B File Offset: 0x00B5D58B
		public void MarkRefreshScrollDataDirty()
		{
			this.RefreshScrollDataDirty = true;
		}

		// Token: 0x06030F74 RID: 200564 RVA: 0x00B5F394 File Offset: 0x00B5D594
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

		// Token: 0x06030F75 RID: 200565 RVA: 0x00B5F41C File Offset: 0x00B5D61C
		private void AddScrollData(List<NavigationGroup> groupArray)
		{
			this.ScrollBallData.AddScrollbar(groupArray);
		}

		// Token: 0x06030F76 RID: 200566 RVA: 0x00B5F42A File Offset: 0x00B5D62A
		[NullableContext(2)]
		private void DeleteScrollData(NavigationGroup group)
		{
			this.ScrollBallData.DeleteScrollbar(group);
		}

		// Token: 0x06030F77 RID: 200567 RVA: 0x00B5F438 File Offset: 0x00B5D638
		public void FindNextScrollData()
		{
			NavigationScrollbarData scrollBallData = this.ScrollBallData;
			if (scrollBallData == null)
			{
				return;
			}
			scrollBallData.FindNextScrollbar();
		}

		// Token: 0x06030F78 RID: 200568 RVA: 0x00B5F44A File Offset: 0x00B5D64A
		public void TryFindScrollData()
		{
			NavigationScrollbarData scrollBallData = this.ScrollBallData;
			if (scrollBallData == null)
			{
				return;
			}
			scrollBallData.TryFindScrollbar();
		}

		// Token: 0x06030F79 RID: 200569 RVA: 0x00B5F45C File Offset: 0x00B5D65C
		public NavigationScrollbarData GetScrollbarData()
		{
			return this.ScrollBallData;
		}

		// Token: 0x06030F7A RID: 200570 RVA: 0x00B5F464 File Offset: 0x00B5D664
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

		// Token: 0x06030F7B RID: 200571 RVA: 0x00B5F5DC File Offset: 0x00B5D7DC
		public void ResetNavigationListener()
		{
			this.ResetState();
			this.MarkResetCurrentPanelDirty();
			this.ClearDynamicScrollViewNavigationContext();
		}

		// Token: 0x06030F7C RID: 200572 RVA: 0x00B5F5F0 File Offset: 0x00B5D7F0
		public void MarkResetCurrentPanelDirty()
		{
			this.ResetCurrentPanelDirty = true;
		}

		// Token: 0x170079D6 RID: 31190
		// (get) Token: 0x06030F7D RID: 200573 RVA: 0x00B5F5F9 File Offset: 0x00B5D7F9
		public bool IsListenerCanFocusByPanelConfig
		{
			get
			{
				return UiNavigationViewManager.Instance.CanFocusViewHandle(this);
			}
		}

		// Token: 0x06030F7E RID: 200574 RVA: 0x00B5F606 File Offset: 0x00B5D806
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

		// Token: 0x06030F7F RID: 200575 RVA: 0x00B5F628 File Offset: 0x00B5D828
		public void UpdateAllHotKeyVisibleMode()
		{
			foreach (TsUiNavigationPanelConfig panelConfig in this.PanelConfigMap.Values)
			{
				this.UpdateHotKeyVisibleMode(panelConfig);
			}
		}

		// Token: 0x06030F80 RID: 200576 RVA: 0x00B5F680 File Offset: 0x00B5D880
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

		// Token: 0x06030F81 RID: 200577 RVA: 0x00B5F6E8 File Offset: 0x00B5D8E8
		public void MarkRefreshHotKeyDirty()
		{
			this.RefreshHotKeyDirty = true;
		}

		// Token: 0x06030F82 RID: 200578 RVA: 0x00B5F6F4 File Offset: 0x00B5D8F4
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

		// Token: 0x06030F83 RID: 200579 RVA: 0x00B5F75C File Offset: 0x00B5D95C
		public void MarkRefreshHotKeyTextIdDirty()
		{
			this.RefreshHotKeyTextIdDirty = true;
		}

		// Token: 0x06030F84 RID: 200580 RVA: 0x00B5F765 File Offset: 0x00B5D965
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

		// Token: 0x06030F85 RID: 200581 RVA: 0x00B5F7A0 File Offset: 0x00B5D9A0
		public void RestoreSwallowedRefreshNavigation()
		{
			if (!this.IsRefreshNavigationSwallowed)
			{
				return;
			}
			this.IsRefreshNavigationSwallowed = false;
			this.RefreshNavigationDirty = true;
		}

		// Token: 0x06030F86 RID: 200582 RVA: 0x00B5F7B9 File Offset: 0x00B5D9B9
		public void DiscardSwallowedRefreshNavigation()
		{
			this.IsRefreshNavigationSwallowed = false;
		}

		// Token: 0x06030F87 RID: 200583 RVA: 0x00B5F7C2 File Offset: 0x00B5D9C2
		public void MarkRefreshNavigationDirty(int instanceId = 0)
		{
			this.RefreshListenerInstanceId = instanceId;
			this.RefreshNavigationDirty = true;
		}

		// Token: 0x06030F88 RID: 200584 RVA: 0x00B5F7D2 File Offset: 0x00B5D9D2
		public void ResetNavigationDirty(int instanceId = 0)
		{
			if (this.RefreshListenerInstanceId != 0 && instanceId != 0 && this.RefreshListenerInstanceId != instanceId)
			{
				return;
			}
			this.RefreshNavigationDirty = false;
		}

		// Token: 0x06030F89 RID: 200585 RVA: 0x00B5F7F0 File Offset: 0x00B5D9F0
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

		// Token: 0x06030F8A RID: 200586 RVA: 0x00B5F83E File Offset: 0x00B5DA3E
		[NullableContext(2)]
		public void MarkSwitchNavigationFocusDirty(TsUiNavigationBehaviorListener listener)
		{
			this.SwitchNavigationFocusListener = listener;
		}

		// Token: 0x06030F8B RID: 200587 RVA: 0x00B5F848 File Offset: 0x00B5DA48
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

		// Token: 0x06030F8C RID: 200588 RVA: 0x00B5F8A3 File Offset: 0x00B5DAA3
		private void RefreshGamepadControl(float deltaTime)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.Tick(deltaTime);
		}

		// Token: 0x06030F8D RID: 200589 RVA: 0x00B5F8B6 File Offset: 0x00B5DAB6
		public bool HasGamepadControlMouse()
		{
			TsUiNavigationPanelConfig mainPanel = this.MainPanel;
			return mainPanel != null && mainPanel.IsGamepadControlMouse;
		}

		// Token: 0x06030F8E RID: 200590 RVA: 0x00B5F8C9 File Offset: 0x00B5DAC9
		public void CanOverridePositionByGamepad(bool value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.CanOverridePosition(value);
		}

		// Token: 0x06030F8F RID: 200591 RVA: 0x00B5F8DC File Offset: 0x00B5DADC
		public void SetGamepadMouseMoveForward(float value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.MoveForwardByGamepad(value);
		}

		// Token: 0x06030F90 RID: 200592 RVA: 0x00B5F8EF File Offset: 0x00B5DAEF
		public void SetGamepadMouseMoveRight(float value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.MoveRightByGamepad(value);
		}

		// Token: 0x06030F91 RID: 200593 RVA: 0x00B5F902 File Offset: 0x00B5DB02
		public void SetGamepadMouseTrigger(bool isPress)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.TriggerByGamepad(isPress);
		}

		// Token: 0x06030F92 RID: 200594 RVA: 0x00B5F915 File Offset: 0x00B5DB15
		public void UpdateMousePositionByItem(UUIItem uiItem)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.UpdateMousePositionByItem(uiItem);
		}

		// Token: 0x06030F93 RID: 200595 RVA: 0x00B5F928 File Offset: 0x00B5DB28
		public void UpdateMousePositionForGuide(UUIItem uiItem)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.UpdateMousePositionForGuide(uiItem);
		}

		// Token: 0x06030F94 RID: 200596 RVA: 0x00B5F93B File Offset: 0x00B5DB3B
		public void ResetNavigationFocusForGuide()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.ResetNavigationFocusForGuide();
		}

		// Token: 0x06030F95 RID: 200597 RVA: 0x00B5F94D File Offset: 0x00B5DB4D
		public bool IsGamepadHitListenerUseDrag()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			return gamepadControlInternal != null && gamepadControlInternal.IsNearlyListenerUseDrag();
		}

		// Token: 0x06030F96 RID: 200598 RVA: 0x00B5F960 File Offset: 0x00B5DB60
		public void SetLockUseDragState(bool value)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.SetLockUseDragState(value);
		}

		// Token: 0x06030F97 RID: 200599 RVA: 0x00B5F973 File Offset: 0x00B5DB73
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

		// Token: 0x06030F98 RID: 200600 RVA: 0x00B5F986 File Offset: 0x00B5DB86
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

		// Token: 0x06030F99 RID: 200601 RVA: 0x00B5F999 File Offset: 0x00B5DB99
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

		// Token: 0x06030F9A RID: 200602 RVA: 0x00B5F9AC File Offset: 0x00B5DBAC
		public void NotifyNavigationMousePositionDragState(bool state)
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			if (gamepadControlInternal == null)
			{
				return;
			}
			gamepadControlInternal.NotifyNavigationMousePositionDragState(state);
		}

		// Token: 0x06030F9B RID: 200603 RVA: 0x00B5F9BF File Offset: 0x00B5DBBF
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

		// Token: 0x06030F9C RID: 200604 RVA: 0x00B5F9D2 File Offset: 0x00B5DBD2
		public bool IsNavigationMousePositionDragging()
		{
			GamepadControlMouse gamepadControlInternal = this.GamepadControlInternal;
			return gamepadControlInternal != null && gamepadControlInternal.IsNavigationMousePositionDragging();
		}

		// Token: 0x06030F9D RID: 200605 RVA: 0x00B5F9E5 File Offset: 0x00B5DBE5
		public void SetDynamicScrollViewNavigationContext(NavigationDynamicScrollViewFindContext context)
		{
			if (this.DynamicScrollViewNavigationContext != null)
			{
				return;
			}
			this.DynamicScrollViewNavigationContext = context;
		}

		// Token: 0x06030F9E RID: 200606 RVA: 0x00B5F9F7 File Offset: 0x00B5DBF7
		public void ClearDynamicScrollViewNavigationContext()
		{
			this.DynamicScrollViewNavigationContext = null;
		}

		// Token: 0x170079D7 RID: 31191
		// (get) Token: 0x06030F9F RID: 200607 RVA: 0x00B5FA00 File Offset: 0x00B5DC00
		public bool IsWaitToFindDynamicGrid
		{
			get
			{
				return this.DynamicScrollViewNavigationContext != null;
			}
		}

		// Token: 0x06030FA0 RID: 200608 RVA: 0x00B5FA0B File Offset: 0x00B5DC0B
		[NullableContext(2)]
		public NavigationDynamicScrollViewFindContext GetDynamicScrollViewNavigationContext()
		{
			return this.DynamicScrollViewNavigationContext;
		}

		// Token: 0x06030FA1 RID: 200609 RVA: 0x00B5FA13 File Offset: 0x00B5DC13
		public void TickViewHandle(float deltaTime)
		{
			this.RefreshNavigation();
			this.RefreshHotKeyComponents();
			this.RefreshHotKeyTextId();
			this.RefreshScrollData();
			this.RefreshSwitchNavigationFocus();
			this.RefreshGamepadControl(deltaTime);
		}

		// Token: 0x0401A45C RID: 107612
		public readonly int TagId;

		// Token: 0x0401A45D RID: 107613
		public readonly string ViewName;

		// Token: 0x0401A45E RID: 107614
		private readonly OrderedDictionary<int, TsUiNavigationPanelConfig> PanelConfigMap = new OrderedDictionary<int, TsUiNavigationPanelConfig>();

		// Token: 0x0401A45F RID: 107615
		[Nullable(2)]
		public readonly TsUiNavigationPanelConfig MainPanel;

		// Token: 0x0401A460 RID: 107616
		[Nullable(2)]
		private TsUiNavigationPanelConfig CurrentPanel;

		// Token: 0x0401A461 RID: 107617
		[Nullable(2)]
		private TsUiNavigationPanelConfig CurrentAddPanel;

		// Token: 0x0401A462 RID: 107618
		[Nullable(2)]
		private TsUiNavigationBehaviorListener FocusListener;

		// Token: 0x0401A463 RID: 107619
		private bool IsInController = true;

		// Token: 0x0401A464 RID: 107620
		private bool IsActive = true;

		// Token: 0x0401A465 RID: 107621
		private bool IsUsable = true;

		// Token: 0x0401A466 RID: 107622
		private readonly Dictionary<TsUiNavigationPanelConfig, TsUiNavigationBehaviorListener> NonIndependentPanelFocusCache = new Dictionary<TsUiNavigationPanelConfig, TsUiNavigationBehaviorListener>();

		// Token: 0x0401A467 RID: 107623
		private readonly NavigationScrollbarData ScrollBallData;

		// Token: 0x0401A468 RID: 107624
		private EViewHandleState StateInternal = EViewHandleState.None;

		// Token: 0x0401A469 RID: 107625
		private bool ResetCurrentPanelDirty;

		// Token: 0x0401A46A RID: 107626
		private bool SkipMainPanelFallbackOnce;

		// Token: 0x0401A46B RID: 107627
		private readonly Stat StatsObject = Stat.Create("UiNavigationViewHandle", "", "");

		// Token: 0x0401A46C RID: 107628
		private bool RefreshScrollDataDirty;

		// Token: 0x0401A46D RID: 107629
		private bool RefreshHotKeyDirty;

		// Token: 0x0401A46E RID: 107630
		private bool RefreshHotKeyTextIdDirty;

		// Token: 0x0401A46F RID: 107631
		private bool RefreshNavigationDirty;

		// Token: 0x0401A470 RID: 107632
		private int RefreshListenerInstanceId;

		// Token: 0x0401A471 RID: 107633
		private bool IsRefreshNavigationSwallowed;

		// Token: 0x0401A472 RID: 107634
		[Nullable(2)]
		private TsUiNavigationBehaviorListener SwitchNavigationFocusListener;

		// Token: 0x0401A473 RID: 107635
		[Nullable(2)]
		private GamepadControlMouse GamepadControlInternal;

		// Token: 0x0401A474 RID: 107636
		[Nullable(2)]
		private NavigationDynamicScrollViewFindContext DynamicScrollViewNavigationContext;
	}
}
