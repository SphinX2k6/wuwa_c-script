using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Presenter;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A9 RID: 22441
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlTouchController
	{
		// Token: 0x06037661 RID: 226913 RVA: 0x00F7A47C File Offset: 0x00F7867C
		public DangoBrawlTouchController(ActivityDangoBrawlData data)
		{
			this.Data = data;
			this.Context = new DragContext();
			this.Resolver = new DropResolver();
			this.InteractionFsm = new InteractionStateMachine();
			this.PlatformState = new DangoBrawlPlatformState();
			this.Highlight = new BagHighlightPresenter(data, this.Resolver);
			this.SourceAdapters = new DangoBrawlSourceAdapterRegistry(data, this.Context, this.PlatformState);
			this.ModesCtrl = new DangoBrawlInteractionModeCtrl(data, this.Resolver, this.InteractionFsm);
			this.DragCtrl = new DangoBrawlDragCtrl(data, this.Context, this.Resolver, this.InteractionFsm, this.SourceAdapters, this.Highlight, this.ModesCtrl);
			this.StickyCtrl = new DangoBrawlStickyCtrl(data, this.Resolver, this.InteractionFsm, this.PlatformState, this.ModesCtrl, this.SourceAdapters, this.Highlight);
			this.PlatformAdapters = new DangoBrawlPlatformAdapterRegistry(this.InteractionFsm, this.PlatformState, this.DragCtrl, this.StickyCtrl);
		}

		// Token: 0x06037662 RID: 226914 RVA: 0x00F7A588 File Offset: 0x00F78788
		public void Start()
		{
			this.Resolver.Start();
			this.Context.Start();
			this.PlatformAdapters.Start();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Add(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			this.InitStickyTickHandle();
		}

		// Token: 0x06037663 RID: 226915 RVA: 0x00F7A62C File Offset: 0x00F7882C
		public void Stop()
		{
			this.ClearStickyTickHandle();
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			this.ModesCtrl.Layer.Discard();
			this.Resolver.Stop();
			this.Context.Stop();
			this.PlatformAdapters.Stop();
			this.Highlight.Clear();
			this.CancelInteractionIfAny();
		}

		// Token: 0x06037664 RID: 226916 RVA: 0x00F7A6F1 File Offset: 0x00F788F1
		private void InitStickyTickHandle()
		{
			this.ClearStickyTickHandle();
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		}

		// Token: 0x06037665 RID: 226917 RVA: 0x00F7A722 File Offset: 0x00F78922
		private void ClearStickyTickHandle()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x06037666 RID: 226918 RVA: 0x00F7A744 File Offset: 0x00F78944
		public DragContext GetContext()
		{
			return this.Context;
		}

		// Token: 0x06037667 RID: 226919 RVA: 0x00F7A74C File Offset: 0x00F7894C
		public InteractionStateMachine GetInteractionFsm()
		{
			return this.InteractionFsm;
		}

		// Token: 0x17006AAA RID: 27306
		// (get) Token: 0x06037668 RID: 226920 RVA: 0x00F7A754 File Offset: 0x00F78954
		public bool IsFsmBlocking
		{
			get
			{
				return this.InteractionFsm.IsBlocking();
			}
		}

		// Token: 0x17006AAB RID: 27307
		// (get) Token: 0x06037669 RID: 226921 RVA: 0x00F7A761 File Offset: 0x00F78961
		public bool IsFsmHolding
		{
			get
			{
				return this.InteractionFsm.IsHolding();
			}
		}

		// Token: 0x17006AAC RID: 27308
		// (get) Token: 0x0603766A RID: 226922 RVA: 0x00F7A770 File Offset: 0x00F78970
		public int? FsmSourceUid
		{
			get
			{
				InteractionPayload payLoad = this.InteractionFsm.GetPayLoad();
				if (payLoad == null)
				{
					return null;
				}
				return new int?(payLoad.Visual.SourceUid);
			}
		}

		// Token: 0x17006AAD RID: 27309
		// (get) Token: 0x0603766B RID: 226923 RVA: 0x00F7A7A8 File Offset: 0x00F789A8
		public EDragSourceKind? FsmPayLoadSource
		{
			get
			{
				InteractionPayload payLoad = this.InteractionFsm.GetPayLoad();
				if (payLoad == null)
				{
					return null;
				}
				return new EDragSourceKind?(payLoad.Visual.Source);
			}
		}

		// Token: 0x17006AAE RID: 27310
		// (get) Token: 0x0603766C RID: 226924 RVA: 0x00F7A7DD File Offset: 0x00F789DD
		public int? DraggingUid
		{
			get
			{
				return this.DragCtrl.DraggingUid;
			}
		}

		// Token: 0x17006AAF RID: 27311
		// (get) Token: 0x0603766D RID: 226925 RVA: 0x00F7A7EA File Offset: 0x00F789EA
		public bool IsDragging
		{
			get
			{
				return this.DragCtrl.IsDragging;
			}
		}

		// Token: 0x17006AB0 RID: 27312
		// (get) Token: 0x0603766E RID: 226926 RVA: 0x00F7A7F7 File Offset: 0x00F789F7
		[Nullable(2)]
		public IDragVisual DraggingVisual
		{
			[NullableContext(2)]
			get
			{
				return this.DragCtrl.ActiveVisual;
			}
		}

		// Token: 0x0603766F RID: 226927 RVA: 0x00F7A804 File Offset: 0x00F78A04
		[NullableContext(2)]
		public IDragSourceAdapter GetSourceAdapter(EDragSourceKind source)
		{
			return this.SourceAdapters.Get(source);
		}

		// Token: 0x06037670 RID: 226928 RVA: 0x00F7A812 File Offset: 0x00F78A12
		[NullableContext(2)]
		public BagSourceAdapter GetBagSourceAdapter()
		{
			return this.SourceAdapters.Get(EDragSourceKind.Bag) as BagSourceAdapter;
		}

		// Token: 0x17006AB1 RID: 27313
		// (get) Token: 0x06037671 RID: 226929 RVA: 0x00F7A825 File Offset: 0x00F78A25
		public bool IsLayerMode
		{
			get
			{
				return this.ModesCtrl.Layer.IsActive;
			}
		}

		// Token: 0x17006AB2 RID: 27314
		// (get) Token: 0x06037672 RID: 226930 RVA: 0x00F7A837 File Offset: 0x00F78A37
		public IInteractionMode CurrentMode
		{
			get
			{
				return this.ModesCtrl.Current;
			}
		}

		// Token: 0x17006AB3 RID: 27315
		// (get) Token: 0x06037673 RID: 226931 RVA: 0x00F7A844 File Offset: 0x00F78A44
		public ICommitStrategy CurrentCommitStrategy
		{
			get
			{
				return this.CurrentMode.CommitStrategy;
			}
		}

		// Token: 0x06037674 RID: 226932 RVA: 0x00F7A851 File Offset: 0x00F78A51
		public IInteractionMode GetLayerMode()
		{
			return this.ModesCtrl.Layer;
		}

		// Token: 0x06037675 RID: 226933 RVA: 0x00F7A85E File Offset: 0x00F78A5E
		public IInteractionMode GetCurrentLayerMode()
		{
			return this.CurrentMode;
		}

		// Token: 0x06037676 RID: 226934 RVA: 0x00F7A866 File Offset: 0x00F78A66
		public void ClearSelection()
		{
			this.Context.ClearSelection();
		}

		// Token: 0x06037677 RID: 226935 RVA: 0x00F7A873 File Offset: 0x00F78A73
		[NullableContext(2)]
		public void SetDragLayer(UUIItem layer)
		{
			this.Context.DragLayer = layer;
		}

		// Token: 0x06037678 RID: 226936 RVA: 0x00F7A881 File Offset: 0x00F78A81
		[NullableContext(2)]
		public IDangoBrawlBagDropZoneExtra GetBagDropZoneExtra()
		{
			DangoBrawlDropZone zone = this.Resolver.GetZone(EDragTargetKind.Bag);
			if (zone == null)
			{
				return null;
			}
			return zone.BagExtra;
		}

		// Token: 0x06037679 RID: 226937 RVA: 0x00F7A89A File Offset: 0x00F78A9A
		[NullableContext(2)]
		public IDangoBrawlBenchDropZoneExtra GetBenchDropZoneExtra()
		{
			return this.Resolver.GetBenchDropZoneExtra();
		}

		// Token: 0x0603767A RID: 226938 RVA: 0x00F7A8A7 File Offset: 0x00F78AA7
		public void RegisterDropZone(DangoBrawlDropZone zone)
		{
			this.Resolver.RegisterZone(zone);
		}

		// Token: 0x0603767B RID: 226939 RVA: 0x00F7A8B5 File Offset: 0x00F78AB5
		public void UnregisterDropZone(EDragTargetKind kind)
		{
			this.Resolver.UnregisterZone(kind);
		}

		// Token: 0x0603767C RID: 226940 RVA: 0x00F7A8C3 File Offset: 0x00F78AC3
		public BagHighlightPresenter GetHighlight()
		{
			return this.Highlight;
		}

		// Token: 0x0603767D RID: 226941 RVA: 0x00F7A8CB File Offset: 0x00F78ACB
		public DangoBrawlPlatformState GetPlatformState()
		{
			return this.PlatformState;
		}

		// Token: 0x0603767E RID: 226942 RVA: 0x00F7A8D3 File Offset: 0x00F78AD3
		public EInputPlatform GetInputPlatform()
		{
			return this.PlatformState.Current;
		}

		// Token: 0x0603767F RID: 226943 RVA: 0x00F7A8E0 File Offset: 0x00F78AE0
		public UniTask OnPointerClick(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			DangoBrawlTouchController.<OnPointerClick>d__52 <OnPointerClick>d__;
			<OnPointerClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPointerClick>d__.<>4__this = this;
			<OnPointerClick>d__.source = source;
			<OnPointerClick>d__.view = view;
			<OnPointerClick>d__.pointerPos = pointerPos;
			<OnPointerClick>d__.<>1__state = -1;
			<OnPointerClick>d__.<>t__builder.Start<DangoBrawlTouchController.<OnPointerClick>d__52>(ref <OnPointerClick>d__);
			return <OnPointerClick>d__.<>t__builder.Task;
		}

		// Token: 0x06037680 RID: 226944 RVA: 0x00F7A93C File Offset: 0x00F78B3C
		public UniTask OnPointerBeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			DangoBrawlTouchController.<OnPointerBeginDrag>d__53 <OnPointerBeginDrag>d__;
			<OnPointerBeginDrag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPointerBeginDrag>d__.<>4__this = this;
			<OnPointerBeginDrag>d__.source = source;
			<OnPointerBeginDrag>d__.view = view;
			<OnPointerBeginDrag>d__.pointerPos = pointerPos;
			<OnPointerBeginDrag>d__.<>1__state = -1;
			<OnPointerBeginDrag>d__.<>t__builder.Start<DangoBrawlTouchController.<OnPointerBeginDrag>d__53>(ref <OnPointerBeginDrag>d__);
			return <OnPointerBeginDrag>d__.<>t__builder.Task;
		}

		// Token: 0x06037681 RID: 226945 RVA: 0x00F7A997 File Offset: 0x00F78B97
		public void OnPointerDrag(FVector pointerPos)
		{
			this.PlatformAdapters.Current.OnPointerDrag(pointerPos);
		}

		// Token: 0x06037682 RID: 226946 RVA: 0x00F7A9AC File Offset: 0x00F78BAC
		public UniTask OnPointerEndDrag(FVector pointerPos)
		{
			DangoBrawlTouchController.<OnPointerEndDrag>d__55 <OnPointerEndDrag>d__;
			<OnPointerEndDrag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPointerEndDrag>d__.<>4__this = this;
			<OnPointerEndDrag>d__.pointerPos = pointerPos;
			<OnPointerEndDrag>d__.<>1__state = -1;
			<OnPointerEndDrag>d__.<>t__builder.Start<DangoBrawlTouchController.<OnPointerEndDrag>d__55>(ref <OnPointerEndDrag>d__);
			return <OnPointerEndDrag>d__.<>t__builder.Task;
		}

		// Token: 0x06037683 RID: 226947 RVA: 0x00F7A9F7 File Offset: 0x00F78BF7
		public void TryCancelInteraction()
		{
			if (this.IsDragging || this.IsFsmBlocking)
			{
				return;
			}
			this.CancelInteractionIfAny();
		}

		// Token: 0x06037684 RID: 226948 RVA: 0x00F7AA10 File Offset: 0x00F78C10
		public void CancelInteractionIfAny()
		{
			this.CancelDragInAny();
			this.CancelBlockingInAny();
		}

		// Token: 0x06037685 RID: 226949 RVA: 0x00F7AA1E File Offset: 0x00F78C1E
		public void CancelDragInAny()
		{
			this.DragCtrl.CancelCurrent();
		}

		// Token: 0x06037686 RID: 226950 RVA: 0x00F7AA2B File Offset: 0x00F78C2B
		public void CancelBlockingInAny()
		{
			this.InteractionFsm.CancelCurrent();
			this.Highlight.Clear();
			this.Context.ClearSelection();
		}

		// Token: 0x06037687 RID: 226951 RVA: 0x00F7AA4E File Offset: 0x00F78C4E
		[NullableContext(2)]
		public void ReleaseHoldingSourceView(IDangoBrawlDraggableView sourceView = null)
		{
			this.DragCtrl.ReleaseHoldingSourceView(sourceView);
		}

		// Token: 0x06037688 RID: 226952 RVA: 0x00F7AA5C File Offset: 0x00F78C5C
		[return: Nullable(0)]
		public UniTask<EPlaceResult> TryCommit(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			return this.CurrentCommitStrategy.Commit(adapter, visual, target, anchor);
		}

		// Token: 0x06037689 RID: 226953 RVA: 0x00F7AA6E File Offset: 0x00F78C6E
		public void EnqueueLayerBagToBench(int uid)
		{
			this.ModesCtrl.Layer.EnqueueBagToBench(uid);
		}

		// Token: 0x0603768A RID: 226954 RVA: 0x00F7AA81 File Offset: 0x00F78C81
		public void TryEnterReplaceSticky([Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> abandonedFollowers, [Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> replacedItems)
		{
			this.StickyCtrl.TryEnterReplaceSticky(abandonedFollowers, replacedItems);
		}

		// Token: 0x0603768B RID: 226955 RVA: 0x00F7AA90 File Offset: 0x00F78C90
		public void RotateDrag()
		{
			this.DragCtrl.RepositionAfterRotate();
		}

		// Token: 0x0603768C RID: 226956 RVA: 0x00F7AA9D File Offset: 0x00F78C9D
		public void RotateSticky()
		{
			this.StickyCtrl.RotateVisual();
		}

		// Token: 0x0603768D RID: 226957 RVA: 0x00F7AAAA File Offset: 0x00F78CAA
		private void OnTick(float delta)
		{
			this.PlatformAdapters.Current.OnTick(delta);
		}

		// Token: 0x0603768E RID: 226958 RVA: 0x00F7AABD File Offset: 0x00F78CBD
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.PlatformState.UpdatePlatform();
			this.PlatformAdapters.UpdatePlatform();
			this.CancelInteractionIfAny();
		}

		// Token: 0x0603768F RID: 226959 RVA: 0x00F7AADB File Offset: 0x00F78CDB
		private void OnShopSold(int uid)
		{
			this.CancelInteractionIfAny();
		}

		// Token: 0x06037690 RID: 226960 RVA: 0x00F7AAE3 File Offset: 0x00F78CE3
		private void OnBagUpdated()
		{
			this.Context.ClearSelection();
			this.Highlight.Clear();
		}

		// Token: 0x06037691 RID: 226961 RVA: 0x00F7AAFB File Offset: 0x00F78CFB
		private void OnShopRefreshed()
		{
			this.Context.ClearSelection();
		}

		// Token: 0x0401D3ED RID: 119789
		public readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D3EE RID: 119790
		private readonly DragContext Context;

		// Token: 0x0401D3EF RID: 119791
		private readonly DropResolver Resolver;

		// Token: 0x0401D3F0 RID: 119792
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x0401D3F1 RID: 119793
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x0401D3F2 RID: 119794
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x0401D3F3 RID: 119795
		private readonly DangoBrawlSourceAdapterRegistry SourceAdapters;

		// Token: 0x0401D3F4 RID: 119796
		private readonly DangoBrawlPlatformAdapterRegistry PlatformAdapters;

		// Token: 0x0401D3F5 RID: 119797
		private readonly DangoBrawlInteractionModeCtrl ModesCtrl;

		// Token: 0x0401D3F6 RID: 119798
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x0401D3F7 RID: 119799
		private readonly DangoBrawlStickyCtrl StickyCtrl;

		// Token: 0x0401D3F8 RID: 119800
		[Nullable(2)]
		private TimerHandle TickHandle;
	}
}
