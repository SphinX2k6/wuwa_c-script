using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004907 RID: 18695
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationScrollProxy
	{
		// Token: 0x06030E00 RID: 200192 RVA: 0x00B5990C File Offset: 0x00B57B0C
		private float GetErrorTolerance(bool isVertical)
		{
			FVector relativeScale3D = this.Listener.RootUIComp.Get().RelativeScale3D;
			float num = 0.0002f;
			if (isVertical && relativeScale3D.Y > 1f)
			{
				float num2 = relativeScale3D.Y - 1f;
				num += num2 * this.Listener.RootUIComp.Get().Height / 2f;
			}
			else if (!isVertical && relativeScale3D.X > 1f)
			{
				float num3 = relativeScale3D.X - 1f;
				num += num3 * this.Listener.RootUIComp.Get().Width / 2f;
			}
			return num;
		}

		// Token: 0x06030E01 RID: 200193 RVA: 0x00B599BD File Offset: 0x00B57BBD
		public void InitScrollView(AActor scrollViewActor, TsUiNavigationBehaviorListener listener)
		{
			this.Listener = listener;
			this.ScrollView = (scrollViewActor.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) as UUIScrollViewWithScrollbarComponent);
		}

		// Token: 0x06030E02 RID: 200194 RVA: 0x00B599E4 File Offset: 0x00B57BE4
		public bool IsScrollViewActive()
		{
			return this.ScrollView != null && this.ScrollView.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06030E03 RID: 200195 RVA: 0x00B59A13 File Offset: 0x00B57C13
		[NullableContext(2)]
		public UUIInturnAnimController GetInturnAnimController()
		{
			if (this.ScrollView == null)
			{
				return null;
			}
			AUIBaseActor content = this.ScrollView.GetContent();
			return ((content != null) ? content.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController;
		}

		// Token: 0x170079C6 RID: 31174
		// (get) Token: 0x06030E04 RID: 200196 RVA: 0x00B59A45 File Offset: 0x00B57C45
		public bool IsVertical
		{
			get
			{
				return this.ScrollView != null && this.ScrollView.Vertical;
			}
		}

		// Token: 0x06030E05 RID: 200197 RVA: 0x00B59A5C File Offset: 0x00B57C5C
		public bool HasNormalScrollView()
		{
			return this.ScrollView != null && !this.HasLoopScrollView() && !this.HasMultiTemplateScrollView() && !this.HasDynamicScrollView();
		}

		// Token: 0x06030E06 RID: 200198 RVA: 0x00B59A88 File Offset: 0x00B57C88
		public bool IsInNormalScrollDisplayByGridActor(AUIBaseActor gridBaseActor)
		{
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.NotOut;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.NotOut;
			this.ScrollView.GetOutOfBottomBoundsType(gridBaseActor.GetUIItem(), ref eoutOfBoundsType, ref eoutOfBoundsType2, 0f);
			if (this.ScrollView.Vertical)
			{
				return eoutOfBoundsType == EOutOfBoundsType.NotOut;
			}
			return eoutOfBoundsType2 == EOutOfBoundsType.NotOut;
		}

		// Token: 0x06030E07 RID: 200199 RVA: 0x00B59AC9 File Offset: 0x00B57CC9
		public void BindScrollView(UUISelectableComponent selectableComponent)
		{
			if (!this.HasLoopScrollView() && !this.HasMultiTemplateScrollView())
			{
				return;
			}
			this.ScrollView.BindParentUIItem(selectableComponent);
		}

		// Token: 0x06030E08 RID: 200200 RVA: 0x00B59AE8 File Offset: 0x00B57CE8
		public void UnBindScrollView(UUISelectableComponent selectableComponent)
		{
			if (!this.HasLoopScrollView() && !this.HasMultiTemplateScrollView())
			{
				return;
			}
			if (!this.ScrollView.IsValid())
			{
				return;
			}
			this.ScrollView.UnBindParentUIItem(selectableComponent);
		}

		// Token: 0x06030E09 RID: 200201 RVA: 0x00B59B15 File Offset: 0x00B57D15
		public bool HasLoopScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUILoopScrollViewComponent;
		}

		// Token: 0x06030E0A RID: 200202 RVA: 0x00B59B31 File Offset: 0x00B57D31
		public void SetLoopScrollViewNavigationIndex(int gridIndex)
		{
			if (!this.HasLoopScrollView())
			{
				return;
			}
			(this.ScrollView as UUILoopScrollViewComponent).SetNavigationIndex(gridIndex);
		}

		// Token: 0x06030E0B RID: 200203 RVA: 0x00B59B4D File Offset: 0x00B57D4D
		public int GetLoopScrollViewNavigationIndex()
		{
			if (!this.HasLoopScrollView())
			{
				return -1;
			}
			return (this.ScrollView as UUILoopScrollViewComponent).NavigationIndex;
		}

		// Token: 0x06030E0C RID: 200204 RVA: 0x00B59B69 File Offset: 0x00B57D69
		public bool CheckLoopScrollChangeNavigation()
		{
			if (this.ScrollView == null)
			{
				return false;
			}
			if (!this.ScrollView.IsChangeNavigation)
			{
				return false;
			}
			this.ScrollView.ResetIsChangeNavigation();
			return true;
		}

		// Token: 0x06030E0D RID: 200205 RVA: 0x00B59B90 File Offset: 0x00B57D90
		public bool IsInLoopScrollDisplay(int gridIndex)
		{
			if (!this.HasLoopScrollView())
			{
				return true;
			}
			UUILoopScrollViewComponent uuiloopScrollViewComponent = this.ScrollView as UUILoopScrollViewComponent;
			return uuiloopScrollViewComponent.NavigationIndex == -1 || uuiloopScrollViewComponent.NavigationIndex == gridIndex;
		}

		// Token: 0x06030E0E RID: 200206 RVA: 0x00B59BC8 File Offset: 0x00B57DC8
		[NullableContext(2)]
		public bool IsInLoopScrollDisplayByGridActor(AUIBaseActor gridBaseActor)
		{
			if (!this.HasLoopScrollView())
			{
				return true;
			}
			UUILoopScrollViewComponent uuiloopScrollViewComponent = this.ScrollView as UUILoopScrollViewComponent;
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.NotOut;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.NotOut;
			float errorTolerance = this.GetErrorTolerance(uuiloopScrollViewComponent.Vertical);
			UUIItem uiitem;
			if (gridBaseActor != null)
			{
				uiitem = gridBaseActor.GetUIItem();
			}
			else
			{
				uiitem = this.Listener.RootUIComp.Get();
			}
			uuiloopScrollViewComponent.GetOutOfBottomBoundsType(uiitem, ref eoutOfBoundsType, ref eoutOfBoundsType2, errorTolerance);
			if (uuiloopScrollViewComponent.Vertical)
			{
				return eoutOfBoundsType == EOutOfBoundsType.NotOut;
			}
			return eoutOfBoundsType2 == EOutOfBoundsType.NotOut;
		}

		// Token: 0x06030E0F RID: 200207 RVA: 0x00B59C40 File Offset: 0x00B57E40
		[NullableContext(2)]
		public bool IsScrollDisplayByGridActor(AUIBaseActor gridBaseActor)
		{
			if (this.ScrollView == null)
			{
				return true;
			}
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.NotOut;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.NotOut;
			float errorTolerance = this.GetErrorTolerance(this.ScrollView.Vertical);
			UUIItem uiitem;
			if (gridBaseActor != null)
			{
				uiitem = gridBaseActor.GetUIItem();
			}
			else
			{
				uiitem = this.Listener.RootUIComp.Get();
			}
			this.ScrollView.GetOutOfBottomBoundsType(uiitem, ref eoutOfBoundsType, ref eoutOfBoundsType2, errorTolerance);
			if (this.ScrollView.Vertical)
			{
				return eoutOfBoundsType == EOutOfBoundsType.NotOut;
			}
			return eoutOfBoundsType2 == EOutOfBoundsType.NotOut;
		}

		// Token: 0x06030E10 RID: 200208 RVA: 0x00B59CB8 File Offset: 0x00B57EB8
		[NullableContext(2)]
		public AActor GetDynamicGridActor()
		{
			if (!this.HasDynamicScrollView())
			{
				return null;
			}
			UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
			AUIBaseActor auibaseActor = (scrollView != null) ? scrollView.GetContent() : null;
			if (auibaseActor == null)
			{
				return null;
			}
			AActor aactor = this.Listener.RootUIComp.Get().GetOwner();
			bool flag = false;
			while (aactor != null && aactor.IsValid() && aactor != auibaseActor)
			{
				if (aactor.GetAttachParentActor() == auibaseActor)
				{
					flag = true;
					break;
				}
				aactor = aactor.GetAttachParentActor();
			}
			if (!flag)
			{
				return null;
			}
			return aactor;
		}

		// Token: 0x06030E11 RID: 200209 RVA: 0x00B59D2D File Offset: 0x00B57F2D
		public bool HasDynamicScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUIDynScrollViewComponent;
		}

		// Token: 0x06030E12 RID: 200210 RVA: 0x00B59D4C File Offset: 0x00B57F4C
		[NullableContext(2)]
		public bool IsInDynScrollDisplay(AUIBaseActor gridBaseActor)
		{
			if (!this.HasDynamicScrollView())
			{
				return true;
			}
			UUIDynScrollViewComponent uuidynScrollViewComponent = this.ScrollView as UUIDynScrollViewComponent;
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.NotOut;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.NotOut;
			float errorTolerance = this.GetErrorTolerance(uuidynScrollViewComponent.Vertical);
			UUIItem uiitem;
			if (gridBaseActor != null)
			{
				uiitem = gridBaseActor.GetUIItem();
			}
			else
			{
				uiitem = this.Listener.RootUIComp.Get();
			}
			uuidynScrollViewComponent.GetOutOfBottomBoundsType(uiitem, ref eoutOfBoundsType, ref eoutOfBoundsType2, errorTolerance);
			if (uuidynScrollViewComponent.Vertical)
			{
				return eoutOfBoundsType == EOutOfBoundsType.NotOut;
			}
			return eoutOfBoundsType2 == EOutOfBoundsType.NotOut;
		}

		// Token: 0x06030E13 RID: 200211 RVA: 0x00B59DC4 File Offset: 0x00B57FC4
		public bool GetMultiTemplateScrollPositiveFind(FVector direction, int lastIndex, int index)
		{
			if (this.ScrollView == null)
			{
				return true;
			}
			if (this.ScrollView.Vertical)
			{
				if (direction.Z != 0f)
				{
					if (direction.Z <= 0f)
					{
						return index > lastIndex;
					}
					return index < lastIndex;
				}
				else
				{
					if (direction.X <= 0f)
					{
						return index < lastIndex;
					}
					return index > lastIndex;
				}
			}
			else if (direction.X != 0f)
			{
				if (direction.X <= 0f)
				{
					return index < lastIndex;
				}
				return index > lastIndex;
			}
			else
			{
				if (direction.Z <= 0f)
				{
					return index > lastIndex;
				}
				return index < lastIndex;
			}
		}

		// Token: 0x06030E14 RID: 200212 RVA: 0x00B59E5D File Offset: 0x00B5805D
		public bool IsNeedSlideToEdge(int lastIndex, int findIndex, bool isPositiveFind, NavigationGroup groupConfig)
		{
			return !isPositiveFind && ((findIndex < lastIndex && groupConfig.SlideToLeftOrTop) || (findIndex > lastIndex && groupConfig.SlideToRightOrDown));
		}

		// Token: 0x06030E15 RID: 200213 RVA: 0x00B59E84 File Offset: 0x00B58084
		public bool IsNeedReturnBestPick(FVector direction, NavigationGroup groupConfig)
		{
			UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return true;
			}
			if (scrollView.CheckContentUnderSize())
			{
				return true;
			}
			if (scrollView.Horizontal && direction.X != 0f)
			{
				UUIScrollbarComponent uuiscrollbarComponent = scrollView.HorizontalScrollbarComp.Get();
				if (uuiscrollbarComponent == null || !uuiscrollbarComponent.IsValid())
				{
					return true;
				}
				float value = uuiscrollbarComponent.Value;
				bool flag = direction.X > 0f;
				return (value >= 0.999f || !flag || !groupConfig.SlideToRightOrDown) && (value <= 0.001f || flag || !groupConfig.SlideToLeftOrTop);
			}
			else
			{
				if (!scrollView.Vertical || direction.Z == 0f)
				{
					return true;
				}
				UUIScrollbarComponent uuiscrollbarComponent2 = scrollView.VerticalScrollbarComp.Get();
				if (uuiscrollbarComponent2 == null || !uuiscrollbarComponent2.IsValid())
				{
					return true;
				}
				float value2 = uuiscrollbarComponent2.Value;
				bool flag2 = direction.Z < 0f;
				return (value2 >= 0.999f || !flag2 || !groupConfig.SlideToRightOrDown) && (value2 <= 0.001f || flag2 || !groupConfig.SlideToLeftOrTop);
			}
		}

		// Token: 0x06030E16 RID: 200214 RVA: 0x00B59F9A File Offset: 0x00B5819A
		public void SetScrollProgress(bool isScrollToTop)
		{
			UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.SetScrollProgress(!isScrollToTop);
		}

		// Token: 0x06030E17 RID: 200215 RVA: 0x00B59FB4 File Offset: 0x00B581B4
		public void TryMultiTemplateScrollToGridIndex(int lastIndex, int gridIndex)
		{
			if (this.ScrollView == null)
			{
				return;
			}
			UUIMultiTemplateScrollViewComponent uuimultiTemplateScrollViewComponent = this.ScrollView as UUIMultiTemplateScrollViewComponent;
			if (gridIndex > lastIndex)
			{
				uuimultiTemplateScrollViewComponent.TryScrollToGridIndex(gridIndex, false);
				return;
			}
			uuimultiTemplateScrollViewComponent.TryScrollToGridIndex(gridIndex, true);
		}

		// Token: 0x06030E18 RID: 200216 RVA: 0x00B59FEB File Offset: 0x00B581EB
		public bool HasMultiTemplateScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUIMultiTemplateScrollViewComponent;
		}

		// Token: 0x06030E19 RID: 200217 RVA: 0x00B5A008 File Offset: 0x00B58208
		public void RecordFocusListenerIndexInMultiTemplateScrollView()
		{
			if (!this.HasMultiTemplateScrollView())
			{
				return;
			}
			UUIMultiTemplateScrollViewComponent uuimultiTemplateScrollViewComponent = this.ScrollView as UUIMultiTemplateScrollViewComponent;
			this.FocusListenerIndexInMultiTemplateScrollView = uuimultiTemplateScrollViewComponent.GetGridIndexByChildComponent(this.Listener.GetSelectableComponent());
		}

		// Token: 0x06030E1A RID: 200218 RVA: 0x00B5A044 File Offset: 0x00B58244
		public TsUiNavigationBehaviorListener GetCurrentFocusListenerInMultiTemplateScrollView()
		{
			if (!this.HasMultiTemplateScrollView())
			{
				return this.Listener;
			}
			if (this.FocusListenerIndexInMultiTemplateScrollView == -1)
			{
				return this.Listener;
			}
			UUISelectableComponent navigationComponentByGridIndex = (this.ScrollView as UUIMultiTemplateScrollViewComponent).GetNavigationComponentByGridIndex(this.FocusListenerIndexInMultiTemplateScrollView);
			object obj;
			if (navigationComponentByGridIndex == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = navigationComponentByGridIndex.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = obj as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null)
			{
				return this.Listener;
			}
			return tsUiNavigationBehaviorListener;
		}

		// Token: 0x0401A3CE RID: 107470
		private const float ERRORTOLERANCE = 0.001f;

		// Token: 0x0401A3CF RID: 107471
		[Nullable(2)]
		public UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x0401A3D0 RID: 107472
		protected TsUiNavigationBehaviorListener Listener;

		// Token: 0x0401A3D1 RID: 107473
		private int FocusListenerIndexInMultiTemplateScrollView = -1;
	}
}
