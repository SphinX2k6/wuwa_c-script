using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200387E RID: 14462
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationScrollProxy
	{
		// Token: 0x0602592D RID: 153901 RVA: 0x00A9477C File Offset: 0x00A9297C
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

		// Token: 0x0602592E RID: 153902 RVA: 0x00A9482D File Offset: 0x00A92A2D
		public void InitScrollView(AActor scrollViewActor, TsUiNavigationBehaviorListener listener)
		{
			this.Listener = listener;
			this.ScrollView = (scrollViewActor.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) as UUIScrollViewWithScrollbarComponent);
		}

		// Token: 0x0602592F RID: 153903 RVA: 0x00A94854 File Offset: 0x00A92A54
		public bool IsScrollViewActive()
		{
			return this.ScrollView != null && this.ScrollView.RootUIComp.Get().IsUIActiveInHierarchy();
		}

		// Token: 0x06025930 RID: 153904 RVA: 0x00A94883 File Offset: 0x00A92A83
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

		// Token: 0x17004D2E RID: 19758
		// (get) Token: 0x06025931 RID: 153905 RVA: 0x00A948B5 File Offset: 0x00A92AB5
		public bool IsVertical
		{
			get
			{
				return this.ScrollView != null && this.ScrollView.Vertical;
			}
		}

		// Token: 0x06025932 RID: 153906 RVA: 0x00A948CC File Offset: 0x00A92ACC
		public bool HasNormalScrollView()
		{
			return this.ScrollView != null && !this.HasLoopScrollView() && !this.HasMultiTemplateScrollView() && !this.HasDynamicScrollView();
		}

		// Token: 0x06025933 RID: 153907 RVA: 0x00A948F8 File Offset: 0x00A92AF8
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

		// Token: 0x06025934 RID: 153908 RVA: 0x00A94939 File Offset: 0x00A92B39
		public void BindScrollView(UUISelectableComponent selectableComponent)
		{
			if (!this.HasLoopScrollView() && !this.HasMultiTemplateScrollView())
			{
				return;
			}
			this.ScrollView.BindParentUIItem(selectableComponent);
		}

		// Token: 0x06025935 RID: 153909 RVA: 0x00A94958 File Offset: 0x00A92B58
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

		// Token: 0x06025936 RID: 153910 RVA: 0x00A94985 File Offset: 0x00A92B85
		public bool HasLoopScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUILoopScrollViewComponent;
		}

		// Token: 0x06025937 RID: 153911 RVA: 0x00A949A1 File Offset: 0x00A92BA1
		public void SetLoopScrollViewNavigationIndex(int gridIndex)
		{
			if (!this.HasLoopScrollView())
			{
				return;
			}
			(this.ScrollView as UUILoopScrollViewComponent).SetNavigationIndex(gridIndex);
		}

		// Token: 0x06025938 RID: 153912 RVA: 0x00A949BD File Offset: 0x00A92BBD
		public int GetLoopScrollViewNavigationIndex()
		{
			if (!this.HasLoopScrollView())
			{
				return -1;
			}
			return (this.ScrollView as UUILoopScrollViewComponent).NavigationIndex;
		}

		// Token: 0x06025939 RID: 153913 RVA: 0x00A949D9 File Offset: 0x00A92BD9
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

		// Token: 0x0602593A RID: 153914 RVA: 0x00A94A00 File Offset: 0x00A92C00
		public bool IsInLoopScrollDisplay(int gridIndex)
		{
			if (!this.HasLoopScrollView())
			{
				return true;
			}
			UUILoopScrollViewComponent uuiloopScrollViewComponent = this.ScrollView as UUILoopScrollViewComponent;
			return uuiloopScrollViewComponent.NavigationIndex == -1 || uuiloopScrollViewComponent.NavigationIndex == gridIndex;
		}

		// Token: 0x0602593B RID: 153915 RVA: 0x00A94A38 File Offset: 0x00A92C38
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

		// Token: 0x0602593C RID: 153916 RVA: 0x00A94AB0 File Offset: 0x00A92CB0
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

		// Token: 0x0602593D RID: 153917 RVA: 0x00A94B28 File Offset: 0x00A92D28
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

		// Token: 0x0602593E RID: 153918 RVA: 0x00A94B9D File Offset: 0x00A92D9D
		public bool HasDynamicScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUIDynScrollViewComponent;
		}

		// Token: 0x0602593F RID: 153919 RVA: 0x00A94BBC File Offset: 0x00A92DBC
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

		// Token: 0x06025940 RID: 153920 RVA: 0x00A94C34 File Offset: 0x00A92E34
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

		// Token: 0x06025941 RID: 153921 RVA: 0x00A94CCD File Offset: 0x00A92ECD
		public bool IsNeedSlideToEdge(int lastIndex, int findIndex, bool isPositiveFind, NavigationGroup groupConfig)
		{
			return !isPositiveFind && ((findIndex < lastIndex && groupConfig.SlideToLeftOrTop) || (findIndex > lastIndex && groupConfig.SlideToRightOrDown));
		}

		// Token: 0x06025942 RID: 153922 RVA: 0x00A94CF4 File Offset: 0x00A92EF4
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

		// Token: 0x06025943 RID: 153923 RVA: 0x00A94E0A File Offset: 0x00A9300A
		public void SetScrollProgress(bool isScrollToTop)
		{
			UUIScrollViewWithScrollbarComponent scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.SetScrollProgress(!isScrollToTop);
		}

		// Token: 0x06025944 RID: 153924 RVA: 0x00A94E24 File Offset: 0x00A93024
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

		// Token: 0x06025945 RID: 153925 RVA: 0x00A94E5B File Offset: 0x00A9305B
		public bool HasMultiTemplateScrollView()
		{
			return this.ScrollView != null && this.ScrollView is UUIMultiTemplateScrollViewComponent;
		}

		// Token: 0x06025946 RID: 153926 RVA: 0x00A94E78 File Offset: 0x00A93078
		public void RecordFocusListenerIndexInMultiTemplateScrollView()
		{
			if (!this.HasMultiTemplateScrollView())
			{
				return;
			}
			UUIMultiTemplateScrollViewComponent uuimultiTemplateScrollViewComponent = this.ScrollView as UUIMultiTemplateScrollViewComponent;
			this.FocusListenerIndexInMultiTemplateScrollView = uuimultiTemplateScrollViewComponent.GetGridIndexByChildComponent(this.Listener.GetSelectableComponent());
		}

		// Token: 0x06025947 RID: 153927 RVA: 0x00A94EB4 File Offset: 0x00A930B4
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

		// Token: 0x04014C41 RID: 85057
		private const float ERRORTOLERANCE = 0.001f;

		// Token: 0x04014C42 RID: 85058
		[Nullable(2)]
		public UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x04014C43 RID: 85059
		protected TsUiNavigationBehaviorListener Listener;

		// Token: 0x04014C44 RID: 85060
		private int FocusListenerIndexInMultiTemplateScrollView = -1;
	}
}
