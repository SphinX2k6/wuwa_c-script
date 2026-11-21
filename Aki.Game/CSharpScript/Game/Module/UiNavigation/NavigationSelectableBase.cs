using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003891 RID: 14481
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NavigationSelectableBase
	{
		// Token: 0x06025972 RID: 153970 RVA: 0x00A95434 File Offset: 0x00A93634
		protected NavigationSelectableBase(ULGUIBehaviour selectable, string type, List<string> paramList)
		{
		}

		// Token: 0x06025973 RID: 153971 RVA: 0x00A9546C File Offset: 0x00A9366C
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06025974 RID: 153972 RVA: 0x00A95474 File Offset: 0x00A93674
		public void Start()
		{
			this.OnStart();
		}

		// Token: 0x06025975 RID: 153973 RVA: 0x00A9547C File Offset: 0x00A9367C
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06025976 RID: 153974 RVA: 0x00A95484 File Offset: 0x00A93684
		public bool CanFocus()
		{
			return this.IsInteractive && this.Selectable != null && this.Selectable.IsValid() && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06025977 RID: 153975 RVA: 0x00A954CA File Offset: 0x00A936CA
		public bool CanFocusInScrollOrLayout()
		{
			return this.OnCanFocusInScrollOrLayout();
		}

		// Token: 0x06025978 RID: 153976 RVA: 0x00A954D4 File Offset: 0x00A936D4
		public bool IsActive()
		{
			return this.IsInteractive && this.Selectable != null && this.Selectable.IsValid() && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06025979 RID: 153977 RVA: 0x00A9551A File Offset: 0x00A9371A
		public void SetIsInteractive(bool value)
		{
			this.IsInteractive = value;
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x00A95523 File Offset: 0x00A93723
		public ULGUIBehaviour GetSelectable()
		{
			return this.Selectable;
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x00A9552B File Offset: 0x00A9372B
		public void SetListener(TsUiNavigationBehaviorListener listener)
		{
			this.Listener = listener;
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x00A95534 File Offset: 0x00A93734
		public void SetPanelHandle(SpecialPanelHandleBase panelHandle)
		{
			this.PanelHandle = panelHandle;
		}

		// Token: 0x0602597D RID: 153981 RVA: 0x00A9553D File Offset: 0x00A9373D
		public string GetTipsTextId()
		{
			return this.OnGetTipsTextId();
		}

		// Token: 0x0602597E RID: 153982 RVA: 0x00A95545 File Offset: 0x00A93745
		public bool CheckFindNavigationBefore()
		{
			return !UiLayer.Instance.IsInMask() && this.OnCheckFindNavigationBefore();
		}

		// Token: 0x0602597F RID: 153983 RVA: 0x00A9555B File Offset: 0x00A9375B
		public bool CheckFindOpposite()
		{
			return this.Listener.IsCanFocus() && this.OnCheckFindOpposite();
		}

		// Token: 0x06025980 RID: 153984 RVA: 0x00A95572 File Offset: 0x00A93772
		[NullableContext(2)]
		public bool CheckFindNavigationAfter(TsUiNavigationBehaviorListener findListener)
		{
			return this.OnCheckFindNavigationAfter(findListener);
		}

		// Token: 0x06025981 RID: 153985 RVA: 0x00A9557B File Offset: 0x00A9377B
		public bool HandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return this.IsAllowNavigationByGroup() && this.IsAllowNavigationBySelfParam(eventData) && this.IsAllowCrossNavigationGroup() && this.OnHandlePointerEnter(eventData);
		}

		// Token: 0x06025982 RID: 153986 RVA: 0x00A955A3 File Offset: 0x00A937A3
		public bool HandlePointerSelect(ULGUIPointerEventData eventData)
		{
			return this.IsAllowCrossNavigationGroup() && this.OnHandlePointerSelect(eventData);
		}

		// Token: 0x06025983 RID: 153987 RVA: 0x00A955B6 File Offset: 0x00A937B6
		public bool IsIgnoreScrollOrLayoutCheckInSwitchGroup()
		{
			return this.OnIsIgnoreScrollOrLayoutCheck();
		}

		// Token: 0x06025984 RID: 153988 RVA: 0x00A955BE File Offset: 0x00A937BE
		[NullableContext(2)]
		public UUISelectableComponent FindLoopScrollViewNavigationComponent(FVector direction, UINavigationWrapMode wrapMode)
		{
			return this.OnFindLoopScrollViewNavigationComponent(direction, wrapMode);
		}

		// Token: 0x06025985 RID: 153989 RVA: 0x00A955C8 File Offset: 0x00A937C8
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

		// Token: 0x06025986 RID: 153990 RVA: 0x00A956AA File Offset: 0x00A938AA
		public void MultiTemplateScrollViewScrollToIndex(int findIndex, bool bScrollToTop)
		{
			(this.Listener.ScrollProxy.ScrollView as UUIMultiTemplateScrollViewComponent).TryScrollToGridIndex(findIndex, bScrollToTop);
		}

		// Token: 0x06025987 RID: 153991 RVA: 0x00A956C8 File Offset: 0x00A938C8
		public void NotifyFocusListener(bool isSameListener)
		{
			this.OnNotifyFocusListener(isSameListener);
		}

		// Token: 0x06025988 RID: 153992 RVA: 0x00A956D4 File Offset: 0x00A938D4
		protected bool IsAllowNavigationByGroup()
		{
			if (string.IsNullOrEmpty(this.Listener.GroupName))
			{
				return false;
			}
			NavigationGroup navigationGroup = this.Listener.PanelConfig.GetNavigationGroup(this.Listener.GroupName);
			return navigationGroup != null && navigationGroup.GroupType == 0;
		}

		// Token: 0x06025989 RID: 153993 RVA: 0x00A95724 File Offset: 0x00A93924
		protected virtual string OnGetTipsTextId()
		{
			string result;
			if (!this.Listener.HotKeyTipsTextIdMap.TryGetValue(EHotKeyNameStateType.Normal, out result))
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x0602598A RID: 153994 RVA: 0x00A9574D File Offset: 0x00A9394D
		protected virtual bool OnCheckFindNavigationBefore()
		{
			return true;
		}

		// Token: 0x0602598B RID: 153995 RVA: 0x00A95750 File Offset: 0x00A93950
		protected virtual bool OnCheckFindOpposite()
		{
			return true;
		}

		// Token: 0x0602598C RID: 153996 RVA: 0x00A95753 File Offset: 0x00A93953
		[NullableContext(2)]
		protected virtual bool OnCheckFindNavigationAfter(TsUiNavigationBehaviorListener findListener)
		{
			return true;
		}

		// Token: 0x0602598D RID: 153997 RVA: 0x00A95756 File Offset: 0x00A93956
		protected virtual bool IsAllowNavigationBySelfParam(ULGUIPointerEventData eventData)
		{
			return true;
		}

		// Token: 0x0602598E RID: 153998 RVA: 0x00A9575C File Offset: 0x00A9395C
		protected virtual bool OnCanFocusInScrollOrLayout()
		{
			return this.IsInteractive && this.Selectable.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x0602598F RID: 153999 RVA: 0x00A95790 File Offset: 0x00A93990
		protected virtual bool OnHandlePointerEnter(ULGUIPointerEventData eventData)
		{
			return true;
		}

		// Token: 0x06025990 RID: 154000 RVA: 0x00A95793 File Offset: 0x00A93993
		protected virtual bool OnIsIgnoreScrollOrLayoutCheck()
		{
			return false;
		}

		// Token: 0x06025991 RID: 154001 RVA: 0x00A95798 File Offset: 0x00A93998
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

		// Token: 0x06025992 RID: 154002 RVA: 0x00A95820 File Offset: 0x00A93A20
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

		// Token: 0x06025993 RID: 154003 RVA: 0x00A95980 File Offset: 0x00A93B80
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

		// Token: 0x06025994 RID: 154004 RVA: 0x00A95A52 File Offset: 0x00A93C52
		protected virtual void OnNotifyFocusListener(bool isSameListener)
		{
		}

		// Token: 0x06025995 RID: 154005
		protected abstract bool OnHandlePointerSelect(ULGUIPointerEventData eventData);

		// Token: 0x06025996 RID: 154006 RVA: 0x00A95A54 File Offset: 0x00A93C54
		protected virtual void OnInit()
		{
		}

		// Token: 0x06025997 RID: 154007 RVA: 0x00A95A56 File Offset: 0x00A93C56
		protected virtual void OnStart()
		{
		}

		// Token: 0x06025998 RID: 154008 RVA: 0x00A95A58 File Offset: 0x00A93C58
		protected virtual void OnClear()
		{
		}

		// Token: 0x06025999 RID: 154009 RVA: 0x00A95A5A File Offset: 0x00A93C5A
		public new ENavigationSelectableDefine GetType()
		{
			return this.Type;
		}

		// Token: 0x04014C46 RID: 85062
		protected bool IsInteractive = true;

		// Token: 0x04014C47 RID: 85063
		[Nullable(2)]
		protected ULGUIBehaviour Selectable = selectable;

		// Token: 0x04014C48 RID: 85064
		[Nullable(2)]
		protected TsUiNavigationBehaviorListener Listener;

		// Token: 0x04014C49 RID: 85065
		[Nullable(2)]
		protected SpecialPanelHandleBase PanelHandle;

		// Token: 0x04014C4A RID: 85066
		protected ENavigationSelectableDefine Type = (ENavigationSelectableDefine)Enum.Parse(typeof(ENavigationSelectableDefine), type);

		// Token: 0x04014C4B RID: 85067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<string> ParamList = paramList;
	}
}
