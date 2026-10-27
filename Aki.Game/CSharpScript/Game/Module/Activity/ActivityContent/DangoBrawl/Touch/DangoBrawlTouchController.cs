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
	// Token: 0x02006859 RID: 26713
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlTouchController
	{
		// Token: 0x06042B0C RID: 273164 RVA: 0x01038F30 File Offset: 0x01037130
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

		// Token: 0x06042B0D RID: 273165 RVA: 0x0103903C File Offset: 0x0103723C
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

		// Token: 0x06042B0E RID: 273166 RVA: 0x010390E0 File Offset: 0x010372E0
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

		// Token: 0x06042B0F RID: 273167 RVA: 0x010391A5 File Offset: 0x010373A5
		private void InitStickyTickHandle()
		{
			this.ClearStickyTickHandle();
			this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		}

		// Token: 0x06042B10 RID: 273168 RVA: 0x010391D6 File Offset: 0x010373D6
		private void ClearStickyTickHandle()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
		}

		// Token: 0x06042B11 RID: 273169 RVA: 0x010391F8 File Offset: 0x010373F8
		public DragContext GetContext()
		{
			return this.Context;
		}

		// Token: 0x06042B12 RID: 273170 RVA: 0x01039200 File Offset: 0x01037400
		public InteractionStateMachine GetInteractionFsm()
		{
			return this.InteractionFsm;
		}

		// Token: 0x17009769 RID: 38761
		// (get) Token: 0x06042B13 RID: 273171 RVA: 0x01039208 File Offset: 0x01037408
		public bool IsFsmBlocking
		{
			get
			{
				return this.InteractionFsm.IsBlocking();
			}
		}

		// Token: 0x1700976A RID: 38762
		// (get) Token: 0x06042B14 RID: 273172 RVA: 0x01039215 File Offset: 0x01037415
		public bool IsFsmHolding
		{
			get
			{
				return this.InteractionFsm.IsHolding();
			}
		}

		// Token: 0x1700976B RID: 38763
		// (get) Token: 0x06042B15 RID: 273173 RVA: 0x01039224 File Offset: 0x01037424
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

		// Token: 0x1700976C RID: 38764
		// (get) Token: 0x06042B16 RID: 273174 RVA: 0x0103925C File Offset: 0x0103745C
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

		// Token: 0x1700976D RID: 38765
		// (get) Token: 0x06042B17 RID: 273175 RVA: 0x01039291 File Offset: 0x01037491
		public int? DraggingUid
		{
			get
			{
				return this.DragCtrl.DraggingUid;
			}
		}

		// Token: 0x1700976E RID: 38766
		// (get) Token: 0x06042B18 RID: 273176 RVA: 0x0103929E File Offset: 0x0103749E
		public bool IsDragging
		{
			get
			{
				return this.DragCtrl.IsDragging;
			}
		}

		// Token: 0x1700976F RID: 38767
		// (get) Token: 0x06042B19 RID: 273177 RVA: 0x010392AB File Offset: 0x010374AB
		[Nullable(2)]
		public IDragVisual DraggingVisual
		{
			[NullableContext(2)]
			get
			{
				return this.DragCtrl.ActiveVisual;
			}
		}

		// Token: 0x06042B1A RID: 273178 RVA: 0x010392B8 File Offset: 0x010374B8
		[NullableContext(2)]
		public IDragSourceAdapter GetSourceAdapter(EDragSourceKind source)
		{
			return this.SourceAdapters.Get(source);
		}

		// Token: 0x06042B1B RID: 273179 RVA: 0x010392C6 File Offset: 0x010374C6
		[NullableContext(2)]
		public BagSourceAdapter GetBagSourceAdapter()
		{
			return this.SourceAdapters.Get(EDragSourceKind.Bag) as BagSourceAdapter;
		}

		// Token: 0x17009770 RID: 38768
		// (get) Token: 0x06042B1C RID: 273180 RVA: 0x010392D9 File Offset: 0x010374D9
		public bool IsLayerMode
		{
			get
			{
				return this.ModesCtrl.Layer.IsActive;
			}
		}

		// Token: 0x17009771 RID: 38769
		// (get) Token: 0x06042B1D RID: 273181 RVA: 0x010392EB File Offset: 0x010374EB
		public IInteractionMode CurrentMode
		{
			get
			{
				return this.ModesCtrl.Current;
			}
		}

		// Token: 0x17009772 RID: 38770
		// (get) Token: 0x06042B1E RID: 273182 RVA: 0x010392F8 File Offset: 0x010374F8
		public ICommitStrategy CurrentCommitStrategy
		{
			get
			{
				return this.CurrentMode.CommitStrategy;
			}
		}

		// Token: 0x06042B1F RID: 273183 RVA: 0x01039305 File Offset: 0x01037505
		public IInteractionMode GetLayerMode()
		{
			return this.ModesCtrl.Layer;
		}

		// Token: 0x06042B20 RID: 273184 RVA: 0x01039312 File Offset: 0x01037512
		public IInteractionMode GetCurrentLayerMode()
		{
			return this.CurrentMode;
		}

		// Token: 0x06042B21 RID: 273185 RVA: 0x0103931A File Offset: 0x0103751A
		public void ClearSelection()
		{
			this.Context.ClearSelection();
		}

		// Token: 0x06042B22 RID: 273186 RVA: 0x01039327 File Offset: 0x01037527
		[NullableContext(2)]
		public void SetDragLayer(UUIItem layer)
		{
			this.Context.DragLayer = layer;
		}

		// Token: 0x06042B23 RID: 273187 RVA: 0x01039335 File Offset: 0x01037535
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

		// Token: 0x06042B24 RID: 273188 RVA: 0x0103934E File Offset: 0x0103754E
		[NullableContext(2)]
		public IDangoBrawlBenchDropZoneExtra GetBenchDropZoneExtra()
		{
			return this.Resolver.GetBenchDropZoneExtra();
		}

		// Token: 0x06042B25 RID: 273189 RVA: 0x0103935B File Offset: 0x0103755B
		public void RegisterDropZone(DangoBrawlDropZone zone)
		{
			this.Resolver.RegisterZone(zone);
		}

		// Token: 0x06042B26 RID: 273190 RVA: 0x01039369 File Offset: 0x01037569
		public void UnregisterDropZone(EDragTargetKind kind)
		{
			this.Resolver.UnregisterZone(kind);
		}

		// Token: 0x06042B27 RID: 273191 RVA: 0x01039377 File Offset: 0x01037577
		public BagHighlightPresenter GetHighlight()
		{
			return this.Highlight;
		}

		// Token: 0x06042B28 RID: 273192 RVA: 0x0103937F File Offset: 0x0103757F
		public DangoBrawlPlatformState GetPlatformState()
		{
			return this.PlatformState;
		}

		// Token: 0x06042B29 RID: 273193 RVA: 0x01039387 File Offset: 0x01037587
		public EInputPlatform GetInputPlatform()
		{
			return this.PlatformState.Current;
		}

		// Token: 0x06042B2A RID: 273194 RVA: 0x01039394 File Offset: 0x01037594
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

		// Token: 0x06042B2B RID: 273195 RVA: 0x010393F0 File Offset: 0x010375F0
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

		// Token: 0x06042B2C RID: 273196 RVA: 0x0103944B File Offset: 0x0103764B
		public void OnPointerDrag(FVector pointerPos)
		{
			this.PlatformAdapters.Current.OnPointerDrag(pointerPos);
		}

		// Token: 0x06042B2D RID: 273197 RVA: 0x01039460 File Offset: 0x01037660
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

		// Token: 0x06042B2E RID: 273198 RVA: 0x010394AB File Offset: 0x010376AB
		public void TryCancelInteraction()
		{
			if (this.IsDragging || this.IsFsmBlocking)
			{
				return;
			}
			this.CancelInteractionIfAny();
		}

		// Token: 0x06042B2F RID: 273199 RVA: 0x010394C4 File Offset: 0x010376C4
		public void CancelInteractionIfAny()
		{
			this.CancelDragInAny();
			this.CancelBlockingInAny();
		}

		// Token: 0x06042B30 RID: 273200 RVA: 0x010394D2 File Offset: 0x010376D2
		public void CancelDragInAny()
		{
			this.DragCtrl.CancelCurrent();
		}

		// Token: 0x06042B31 RID: 273201 RVA: 0x010394DF File Offset: 0x010376DF
		public void CancelBlockingInAny()
		{
			this.InteractionFsm.CancelCurrent();
			this.Highlight.Clear();
			this.Context.ClearSelection();
		}

		// Token: 0x06042B32 RID: 273202 RVA: 0x01039502 File Offset: 0x01037702
		[NullableContext(2)]
		public void ReleaseHoldingSourceView(IDangoBrawlDraggableView sourceView = null)
		{
			this.DragCtrl.ReleaseHoldingSourceView(sourceView);
		}

		// Token: 0x06042B33 RID: 273203 RVA: 0x01039510 File Offset: 0x01037710
		[return: Nullable(0)]
		public UniTask<EPlaceResult> TryCommit(IDragSourceAdapter adapter, IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor)
		{
			return this.CurrentCommitStrategy.Commit(adapter, visual, target, anchor);
		}

		// Token: 0x06042B34 RID: 273204 RVA: 0x01039522 File Offset: 0x01037722
		public void EnqueueLayerBagToBench(int uid)
		{
			this.ModesCtrl.Layer.EnqueueBagToBench(uid);
		}

		// Token: 0x06042B35 RID: 273205 RVA: 0x01039535 File Offset: 0x01037735
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

		// Token: 0x06042B36 RID: 273206 RVA: 0x01039544 File Offset: 0x01037744
		public void RotateDrag()
		{
			this.DragCtrl.RepositionAfterRotate();
		}

		// Token: 0x06042B37 RID: 273207 RVA: 0x01039551 File Offset: 0x01037751
		public void RotateSticky()
		{
			this.StickyCtrl.RotateVisual();
		}

		// Token: 0x06042B38 RID: 273208 RVA: 0x0103955E File Offset: 0x0103775E
		private void OnTick(float delta)
		{
			this.PlatformAdapters.Current.OnTick(delta);
		}

		// Token: 0x06042B39 RID: 273209 RVA: 0x01039571 File Offset: 0x01037771
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.PlatformState.UpdatePlatform();
			this.PlatformAdapters.UpdatePlatform();
			this.CancelInteractionIfAny();
		}

		// Token: 0x06042B3A RID: 273210 RVA: 0x0103958F File Offset: 0x0103778F
		private void OnShopSold(int uid)
		{
			this.CancelInteractionIfAny();
		}

		// Token: 0x06042B3B RID: 273211 RVA: 0x01039597 File Offset: 0x01037797
		private void OnBagUpdated()
		{
			this.Context.ClearSelection();
			this.Highlight.Clear();
		}

		// Token: 0x06042B3C RID: 273212 RVA: 0x010395AF File Offset: 0x010377AF
		private void OnShopRefreshed()
		{
			this.Context.ClearSelection();
		}

		// Token: 0x04022B90 RID: 142224
		public readonly ActivityDangoBrawlData Data;

		// Token: 0x04022B91 RID: 142225
		private readonly DragContext Context;

		// Token: 0x04022B92 RID: 142226
		private readonly DropResolver Resolver;

		// Token: 0x04022B93 RID: 142227
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x04022B94 RID: 142228
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x04022B95 RID: 142229
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x04022B96 RID: 142230
		private readonly DangoBrawlSourceAdapterRegistry SourceAdapters;

		// Token: 0x04022B97 RID: 142231
		private readonly DangoBrawlPlatformAdapterRegistry PlatformAdapters;

		// Token: 0x04022B98 RID: 142232
		private readonly DangoBrawlInteractionModeCtrl ModesCtrl;

		// Token: 0x04022B99 RID: 142233
		private readonly DangoBrawlDragCtrl DragCtrl;

		// Token: 0x04022B9A RID: 142234
		private readonly DangoBrawlStickyCtrl StickyCtrl;

		// Token: 0x04022B9B RID: 142235
		[Nullable(2)]
		private TimerHandle TickHandle;
	}
}
