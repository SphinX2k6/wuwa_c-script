using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491A RID: 18714
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationSelectableBase
	{
		// Token: 0x06030E45 RID: 200261 RVA: 0x00B5A5C4 File Offset: 0x00B587C4
		protected NavigationSelectableBase(ULGUIBehaviour selectable, string type, List<string> paramList)
		{
		}

		// Token: 0x06030E46 RID: 200262 RVA: 0x00B5A5FC File Offset: 0x00B587FC
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06030E47 RID: 200263 RVA: 0x00B5A604 File Offset: 0x00B58804
		public void Start()
		{
			this.OnStart();
		}

		// Token: 0x06030E48 RID: 200264 RVA: 0x00B5A60C File Offset: 0x00B5880C
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06030E49 RID: 200265 RVA: 0x00B5A614 File Offset: 0x00B58814
		public bool CanFocus()
		{
			return this.IsInteractive && this.Selectable != null && this.Selectable.IsValid() && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06030E4A RID: 200266 RVA: 0x00B5A65A File Offset: 0x00B5885A
		public bool CanFocusInScrollOrLayout()
		{
			return this.OnCanFocusInScrollOrLayout();
		}

		// Token: 0x06030E4B RID: 200267 RVA: 0x00B5A664 File Offset: 0x00B58864
		public bool IsActive()
		{
			return this.IsInteractive && this.Selectable != null && this.Selectable.IsValid() && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06030E4C RID: 200268 RVA: 0x00B5A6AA File Offset: 0x00B588AA
		public void SetIsInteractive(bool value)
		{
			this.IsInteractive = value;
		}

		// Token: 0x06030E4D RID: 200269 RVA: 0x00B5A6B3 File Offset: 0x00B588B3
		public ULGUIBehaviour GetSelectable()
		{
			return this.Selectable;
		}

		// Token: 0x06030E4E RID: 200270 RVA: 0x00B5A6BB File Offset: 0x00B588BB
		public void SetListener(TsUiNavigationBehaviorListener listener)
		{
			this.Listener = listener;
		}

		// Token: 0x06030E4F RID: 200271 RVA: 0x00B5A6C4 File Offset: 0x00B588C4
		public void SetPanelHandle(SpecialPanelHandleBase panelHandle)
		{
			this.PanelHandle = panelHandle;
		}

		// Token: 0x06030E50 RID: 200272 RVA: 0x00B5A6CD File Offset: 0x00B588CD
		public string GetTipsTextId()
		{
			return this.OnGetTipsTextId();
		}

		// Token: 0x06030E51 RID: 200273 RVA: 0x00B5A6D5 File Offset: 0x00B588D5
		public bool CheckFindNavigationBefore()
		{
			return !UiLayer.Instance.IsInMask() && this.OnCheckFindNavigationBefore();
		}

		// Token: 0x06030E52 RID: 200274 RVA: 0x00B5A6EB File Offset: 0x00B588EB
		public bool CheckFindOpposite()
		{
			return this.Listener.IsCanFocus() && this.OnCheckFindOpposite();
		}

		// Token: 0x06030E53 RID: 200275 RVA: 0x00B5A702 File Offset: 0x00B58902
		[NullableContext(2)]
		public bool CheckFindNavigationAfter(TsUiNavigationBehaviorListener findListener)
		{
			return this.OnCheckFindNavigationAfter(findListener);
		}

		// Token: 0x06030E54 RID: 200276 RVA: 0x00B5A70B File Offset: 0x00B5890B
		public bool HandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return this.IsAllowNavigationByGroup() && this.IsAllowNavigationBySelfParam(eventData) && this.IsAllowCrossNavigationGroup() && this.OnHandlePointerEnter(eventData);
		}

		// Token: 0x06030E55 RID: 200277 RVA: 0x00B5A733 File Offset: 0x00B58933
		public bool HandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return this.IsAllowCrossNavigationGroup() && this.OnHandlePointerSelect(eventData);
		}

		// Token: 0x06030E56 RID: 200278 RVA: 0x00B5A746 File Offset: 0x00B58946
		public bool IsIgnoreScrollOrLayoutCheckInSwitchGroup()
		{
			return this.OnIsIgnoreScrollOrLayoutCheck();
		}

		// Token: 0x06030E57 RID: 200279 RVA: 0x00B5A74E File Offset: 0x00B5894E
		[NullableContext(2)]
		public UUISelectableComponent FindLoopScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode)
		{
			return this.OnFindLoopScrollViewNavigationComponent(direction, wrapMode);
		}

		// Token: 0x06030E58 RID: 200280 RVA: 0x00B5A758 File Offset: 0x00B58958
		[NullableContext(2)]
		public UUISelectableComponent FindMultiTemplateScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode, UINavigationPriorityMode priorityMode, ELGUINavigationDirection directionType, float navigateTolerance, float navigateToleranceReverse)
		{
			ValueTuple<UUISelectableComponent, bool, int> valueTuple = this.OnFindMultiTemplateScrollViewNavigationComponent(direction, wrapMode, priorityMode, navigateTolerance, navigateToleranceReverse);
			UUISelectableComponent item = valueTuple.Item1;
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			TsUiNavigationBehaviorListener targetListener = obj as TsUiNavigationBehaviorListener;
			TsUiNavigationPanelConfig panelConfig = this.Listener.PanelConfig;
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = (panelConfig != null) ? panelConfig.HandleAfterFindOpposite(directionType, this.Listener, targetListener, valueTuple.Item2) : null;
			if (valueTuple.Item3 != -1 && tsUiNavigationBehaviorListener == null)
			{
				FindMultiTemplateNavigationListener findMultiTemplateNavigationListener = new FindMultiTemplateNavigationListener();
				findMultiTemplateNavigationListener.PanelConfig = this.Listener.PanelConfig;
				findMultiTemplateNavigationListener.AddParam(new object[]
				{
					this.Listener,
					valueTuple.Item3
				});
				TsUiNavigationPanelConfig panelConfig2 = this.Listener.PanelConfig;
				if (panelConfig2 != null)
				{
					panelConfig2.SetFindNavigationAction(findMultiTemplateNavigationListener);
				}
				UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			}
			if (tsUiNavigationBehaviorListener == null)
			{
				return null;
			}
			return tsUiNavigationBehaviorListener.GetSelectableComponent();
		}

		// Token: 0x06030E59 RID: 200281 RVA: 0x00B5A83A File Offset: 0x00B58A3A
		public void MultiTemplateScrollViewScrollToIndex(int findIndex, bool bScrollToTop)
		{
			(this.Listener.ScrollProxy.ScrollView as UUIMultiTemplateScrollViewComponent).TryScrollToGridIndex(findIndex, bScrollToTop);
		}

		// Token: 0x06030E5A RID: 200282 RVA: 0x00B5A858 File Offset: 0x00B58A58
		public void NotifyFocusListener(bool isSameListener)
		{
			this.OnNotifyFocusListener(isSameListener);
		}

		// Token: 0x06030E5B RID: 200283 RVA: 0x00B5A864 File Offset: 0x00B58A64
		protected bool IsAllowNavigationByGroup()
		{
			if (string.IsNullOrEmpty(this.Listener.GroupName))
			{
				return false;
			}
			NavigationGroup navigationGroup = this.Listener.PanelConfig.GetNavigationGroup(this.Listener.GroupName);
			return navigationGroup != null && navigationGroup.GroupType == 0;
		}

		// Token: 0x06030E5C RID: 200284 RVA: 0x00B5A8B4 File Offset: 0x00B58AB4
		protected virtual string OnGetTipsTextId()
		{
			string result;
			if (!this.Listener.HotKeyTipsTextIdMap.TryGetValue(EHotKeyNameStateType.Normal, out result))
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x06030E5D RID: 200285 RVA: 0x00B5A8DD File Offset: 0x00B58ADD
		protected virtual bool OnCheckFindNavigationBefore()
		{
			return true;
		}

		// Token: 0x06030E5E RID: 200286 RVA: 0x00B5A8E0 File Offset: 0x00B58AE0
		protected virtual bool OnCheckFindOpposite()
		{
			return true;
		}

		// Token: 0x06030E5F RID: 200287 RVA: 0x00B5A8E3 File Offset: 0x00B58AE3
		[NullableContext(2)]
		protected virtual bool OnCheckFindNavigationAfter(TsUiNavigationBehaviorListener findListener)
		{
			return true;
		}

		// Token: 0x06030E60 RID: 200288 RVA: 0x00B5A8E6 File Offset: 0x00B58AE6
		protected virtual bool IsAllowNavigationBySelfParam(ULGUIPointerEventData eventData)
		{
			return true;
		}

		// Token: 0x06030E61 RID: 200289 RVA: 0x00B5A8EC File Offset: 0x00B58AEC
		protected virtual bool OnCanFocusInScrollOrLayout()
		{
			return this.IsInteractive && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06030E62 RID: 200290 RVA: 0x00B5A920 File Offset: 0x00B58B20
		protected virtual bool OnHandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return true;
		}

		// Token: 0x06030E63 RID: 200291 RVA: 0x00B5A923 File Offset: 0x00B58B23
		protected virtual bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return false;
		}

		// Token: 0x06030E64 RID: 200292 RVA: 0x00B5A928 File Offset: 0x00B58B28
		[NullableContext(2)]
		protected virtual UUISelectableComponent OnFindLoopScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode)
		{
			UUISelectableComponent uuiselectableComponent = null;
			if (this.Listener.HasLoopScrollView())
			{
				int i = 0;
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.Listener;
				while (i < 20)
				{
					uuiselectableComponent = this.Listener.ScrollProxy.ScrollView.FindNavigationComponent(tsUiNavigationBehaviorListener.GetSelectableComponent(), direction, wrapMode, false);
					if (uuiselectableComponent == null)
					{
						break;
					}
					object obj;
					if (uuiselectableComponent == null)
					{
						obj = null;
					}
					else
					{
						AActor owner = uuiselectableComponent.GetOwner();
						obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
					}
					tsUiNavigationBehaviorListener = (obj as TsUiNavigationBehaviorListener);
					i++;
					if (tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsCanFocus())
					{
						break;
					}
				}
			}
			return uuiselectableComponent;
		}

		// Token: 0x06030E65 RID: 200293 RVA: 0x00B5A9B0 File Offset: 0x00B58BB0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected virtual ValueTuple<UUISelectableComponent, bool, int> OnFindMultiTemplateScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode, UINavigationPriorityMode priorityMode, float navigateTolerance, float navigateToleranceReverse)
		{
			UUISelectableComponent item = null;
			int num = -1;
			if (!this.Listener.HasMultiTemplateScrollView())
			{
				return new ValueTuple<UUISelectableComponent, bool, int>(item, true, num);
			}
			UUIMultiTemplateScrollViewComponent uuimultiTemplateScrollViewComponent = this.Listener.ScrollProxy.ScrollView as UUIMultiTemplateScrollViewComponent;
			num = uuimultiTemplateScrollViewComponent.FindNavigationIndex(this.Listener.GetSelectableComponent(), direction, wrapMode, priorityMode, navigateTolerance, navigateToleranceReverse);
			if (num == -1)
			{
				return new ValueTuple<UUISelectableComponent, bool, int>(item, true, num);
			}
			if (!uuimultiTemplateScrollViewComponent.IsInDisplayRange(num, true))
			{
				item = null;
			}
			else
			{
				item = uuimultiTemplateScrollViewComponent.GetNavigationComponentByGridIndex(num);
			}
			int gridIndexByChildComponent = uuimultiTemplateScrollViewComponent.GetGridIndexByChildComponent(this.Listener.GetSelectableComponent());
			bool multiTemplateScrollPositiveFind = this.Listener.ScrollProxy.GetMultiTemplateScrollPositiveFind(direction, gridIndexByChildComponent, num);
			NavigationGroup navigationGroup = this.Listener.GetNavigationGroup();
			if (!multiTemplateScrollPositiveFind && !this.Listener.ScrollProxy.IsNeedReturnBestPick(direction, navigationGroup))
			{
				this.Listener.ScrollProxy.SetScrollProgress(direction.X < 0f || direction.Z > 0f);
				return new ValueTuple<UUISelectableComponent, bool, int>(null, multiTemplateScrollPositiveFind, -1);
			}
			this.Listener.ScrollProxy.TryMultiTemplateScrollToGridIndex(gridIndexByChildComponent, num);
			if (this.Listener.ScrollProxy.IsNeedSlideToEdge(gridIndexByChildComponent, num, multiTemplateScrollPositiveFind, navigationGroup))
			{
				this.Listener.ScrollProxy.SetScrollProgress(direction.X > 0f || direction.Z < 0f);
			}
			return new ValueTuple<UUISelectableComponent, bool, int>(item, multiTemplateScrollPositiveFind, num);
		}

		// Token: 0x06030E66 RID: 200294 RVA: 0x00B5AB10 File Offset: 0x00B58D10
		private bool IsAllowCrossNavigationGroup()
		{
			if (this.Listener.PanelConfig == null)
			{
				return false;
			}
			if (UiNavigationGlobalData.IsAllowCrossNavigationGroup)
			{
				return true;
			}
			TsUiNavigationBehaviorListener focusListener = this.Listener.PanelConfig.GetFocusListener();
			if (focusListener == null)
			{
				return true;
			}
			NavigationGroup navigationGroup = this.Listener.PanelConfig.GetNavigationGroup(focusListener.GroupName);
			return navigationGroup != null && !(navigationGroup.GroupName != this.Listener.GroupName) && (navigationGroup.AllowNavigationInSelfDynamic || ((this.Listener.ScrollViewActor != null || focusListener.ScrollViewActor != null || this.Listener.LayoutActor != null || focusListener.LayoutActor != null) && this.Listener.ScrollViewActor == focusListener.ScrollViewActor && this.Listener.LayoutActor == focusListener.LayoutActor));
		}

		// Token: 0x06030E67 RID: 200295 RVA: 0x00B5ABE2 File Offset: 0x00B58DE2
		protected virtual void OnNotifyFocusListener(bool isSameListener)
		{
		}

		// Token: 0x06030E68 RID: 200296
		protected abstract bool OnHandlePointerSelect(ULGUIPointerEventData eventData);

		// Token: 0x06030E69 RID: 200297 RVA: 0x00B5ABE4 File Offset: 0x00B58DE4
		protected virtual void OnInit()
		{
		}

		// Token: 0x06030E6A RID: 200298 RVA: 0x00B5ABE6 File Offset: 0x00B58DE6
		protected virtual void OnStart()
		{
		}

		// Token: 0x06030E6B RID: 200299 RVA: 0x00B5ABE8 File Offset: 0x00B58DE8
		protected virtual void OnClear()
		{
		}

		// Token: 0x06030E6C RID: 200300 RVA: 0x00B5ABEA File Offset: 0x00B58DEA
		public new ENavigationSelectableDefine GetType()
		{
			return this.Type;
		}

		// Token: 0x0401A3D3 RID: 107475
		protected bool IsInteractive = true;

		// Token: 0x0401A3D4 RID: 107476
		[Nullable(2)]
		protected ULGUIBehaviour Selectable = selectable;

		// Token: 0x0401A3D5 RID: 107477
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener Listener;

		// Token: 0x0401A3D6 RID: 107478
		[Nullable(2)]
		protected SpecialPanelHandleBase PanelHandle;

		// Token: 0x0401A3D7 RID: 107479
		protected ENavigationSelectableDefine Type = (ENavigationSelectableDefine)Enum.Parse(typeof(ENavigationSelectableDefine), type);

		// Token: 0x0401A3D8 RID: 107480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> ParamList = paramList;
	}
}
