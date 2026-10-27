using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Presenter;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006857 RID: 26711
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlDragCtrl
	{
		// Token: 0x17009766 RID: 38758
		// (get) Token: 0x06042AE8 RID: 273128 RVA: 0x010387BD File Offset: 0x010369BD
		public bool IsDragging
		{
			get
			{
				return this.Session != null;
			}
		}

		// Token: 0x17009767 RID: 38759
		// (get) Token: 0x06042AE9 RID: 273129 RVA: 0x010387C8 File Offset: 0x010369C8
		public int? DraggingUid
		{
			get
			{
				DragSession session = this.Session;
				if (session == null)
				{
					return null;
				}
				return new int?(session.Visual.SourceUid);
			}
		}

		// Token: 0x17009768 RID: 38760
		// (get) Token: 0x06042AEA RID: 273130 RVA: 0x010387F8 File Offset: 0x010369F8
		[Nullable(2)]
		public IDragVisual ActiveVisual
		{
			[NullableContext(2)]
			get
			{
				DragSession session = this.Session;
				if (session == null)
				{
					return null;
				}
				return session.Visual;
			}
		}

		// Token: 0x06042AEB RID: 273131 RVA: 0x0103880B File Offset: 0x01036A0B
		public DangoBrawlDragCtrl(ActivityDangoBrawlData data, DragContext context, DropResolver resolver, InteractionStateMachine fsm, DangoBrawlSourceAdapterRegistry sourceAdapters, BagHighlightPresenter highlight, DangoBrawlInteractionModeCtrl modes)
		{
			this.Data = data;
			this.Context = context;
			this.SourceAdapters = sourceAdapters;
			this.InteractionFsm = fsm;
			this.Resolver = resolver;
			this.Highlight = highlight;
			this.Modes = modes;
		}

		// Token: 0x06042AEC RID: 273132 RVA: 0x01038848 File Offset: 0x01036A48
		public UniTask BeginDrag(EDragSourceKind source, IDangoBrawlDraggableView view, FVector pointerPos)
		{
			DangoBrawlDragCtrl.<BeginDrag>d__15 <BeginDrag>d__;
			<BeginDrag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeginDrag>d__.<>4__this = this;
			<BeginDrag>d__.source = source;
			<BeginDrag>d__.view = view;
			<BeginDrag>d__.pointerPos = pointerPos;
			<BeginDrag>d__.<>1__state = -1;
			<BeginDrag>d__.<>t__builder.Start<DangoBrawlDragCtrl.<BeginDrag>d__15>(ref <BeginDrag>d__);
			return <BeginDrag>d__.<>t__builder.Task;
		}

		// Token: 0x06042AED RID: 273133 RVA: 0x010388A3 File Offset: 0x01036AA3
		public void UpdateDrag(FVector pointerPos)
		{
			if (this.Session == null)
			{
				return;
			}
			this.Session.LastPointerPos = pointerPos;
			this.Session.Visual.MoveTo(DangoBrawlUtil.PointerToLgui(pointerPos));
			this.UpdateHighlightFromPointer(pointerPos);
		}

		// Token: 0x06042AEE RID: 273134 RVA: 0x010388D8 File Offset: 0x01036AD8
		public UniTask EndDrag(FVector pointerPos)
		{
			DangoBrawlDragCtrl.<EndDrag>d__17 <EndDrag>d__;
			<EndDrag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndDrag>d__.<>4__this = this;
			<EndDrag>d__.pointerPos = pointerPos;
			<EndDrag>d__.<>1__state = -1;
			<EndDrag>d__.<>t__builder.Start<DangoBrawlDragCtrl.<EndDrag>d__17>(ref <EndDrag>d__);
			return <EndDrag>d__.<>t__builder.Task;
		}

		// Token: 0x06042AEF RID: 273135 RVA: 0x01038924 File Offset: 0x01036B24
		public void ResumeBlockingSession(FVector pointerPos)
		{
			if (this.Session != null || !this.InteractionFsm.IsBlocking())
			{
				return;
			}
			InteractionPayload payLoad = this.InteractionFsm.GetPayLoad();
			if (((payLoad != null) ? payLoad.SourceView : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(71, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[DragCtrl] ResumeBlockingSession no-op：SourceView 为 null（payLoad=");
				defaultInterpolatedStringHandler.AppendFormatted((payLoad == null) ? "null" : "非null");
				defaultInterpolatedStringHandler.AppendLiteral(" uid=");
				defaultInterpolatedStringHandler.AppendFormatted<int>((payLoad != null) ? payLoad.Visual.SourceUid : -1);
				defaultInterpolatedStringHandler.AppendLiteral("）");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IDangoBrawlDraggableView sourceView = payLoad.SourceView;
			EventSystem.Instance.Emit<EDragSourceKind, int>(EEventName.OnDangoBrawlDragWillBegin, payLoad.Visual.Source, payLoad.Visual.SourceUid);
			this.Session = new DragSession(payLoad.Adapter, payLoad.Visual, sourceView);
			sourceView.OnDragSourceBegin();
			payLoad.Visual.MoveTo(DangoBrawlUtil.PointerToLgui(pointerPos));
			this.Session.LastPointerPos = pointerPos;
			this.UpdateHighlightFromPointer(pointerPos);
			this.InteractionFsm.ExitBlocking();
			EventSystem.Instance.Emit<EDragSourceKind, int>(EEventName.OnDangoBrawlDragBegin, payLoad.Visual.Source, payLoad.Visual.ConfigId);
		}

		// Token: 0x06042AF0 RID: 273136 RVA: 0x01038A80 File Offset: 0x01036C80
		public bool IsHoveringBlockingItem()
		{
			InteractionPayload payLoad = this.InteractionFsm.GetPayLoad();
			return payLoad != null && this.Context.IsHovered(payLoad.Visual.Source, payLoad.Visual.SourceUid);
		}

		// Token: 0x06042AF1 RID: 273137 RVA: 0x01038AC0 File Offset: 0x01036CC0
		public void CancelCurrent()
		{
			DragSession session = this.Session;
			if (session == null)
			{
				return;
			}
			this.Session = null;
			ItemSucAnchor anchor = this.GetAnchor(session.Visual);
			session.Adapter.Cancel(session.Visual, anchor);
			IDangoBrawlDraggableView sourceView = session.SourceView;
			if (sourceView != null)
			{
				sourceView.OnDragSourceEnd();
			}
			this.Highlight.Clear();
			this.Context.ClearSelection();
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlDragEnd);
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlDragEndAnyWay);
		}

		// Token: 0x06042AF2 RID: 273138 RVA: 0x01038B45 File Offset: 0x01036D45
		[NullableContext(2)]
		public void ReleaseHoldingSourceView(IDangoBrawlDraggableView sourceView = null)
		{
			if (sourceView != null)
			{
				sourceView.OnDragSourceEnd();
			}
			this.Highlight.Clear();
		}

		// Token: 0x06042AF3 RID: 273139 RVA: 0x01038B5B File Offset: 0x01036D5B
		public void RepositionAfterRotate()
		{
			if (this.Session == null)
			{
				return;
			}
			this.Session.Visual.MoveTo(DangoBrawlUtil.PointerToLgui(this.Session.LastPointerPos));
			this.UpdateHighlightFromPointer(this.Session.LastPointerPos);
		}

		// Token: 0x06042AF4 RID: 273140 RVA: 0x01038B97 File Offset: 0x01036D97
		private void UpdateHighlightFromPointer(FVector pointerPos)
		{
			if (this.Session != null)
			{
				this.Highlight.UpdateFromPointer(this.Session.Visual, pointerPos);
			}
		}

		// Token: 0x06042AF5 RID: 273141 RVA: 0x01038BB8 File Offset: 0x01036DB8
		[return: Nullable(2)]
		private ItemSucAnchor GetAnchor(IDragVisual visual)
		{
			ActivityDangoBrawlData data = this.Data;
			if (visual.Source == EDragSourceKind.Bag)
			{
				DangoBrawlBackpackData bagpackData = data.BagpackData;
				if (bagpackData == null)
				{
					return null;
				}
				DangoBrawlBackpackItemData item = bagpackData.GetItem(visual.SourceUid);
				if (item == null)
				{
					return null;
				}
				return item.MyLastAnchor;
			}
			else
			{
				if (visual.Source != EDragSourceKind.Bench)
				{
					return null;
				}
				DangoBrawlBenchData benchData = data.BenchData;
				if (benchData == null)
				{
					return null;
				}
				DangoBrawlBenchItemData item2 = benchData.GetItem(visual.SourceUid);
				if (item2 == null)
				{
					return null;
				}
				return item2.MyLastAnchor;
			}
		}

		// Token: 0x06042AF6 RID: 273142 RVA: 0x01038C28 File Offset: 0x01036E28
		private void SnapHoldingVisualToGrid(IDragVisual visual, FVector2D pointerLguiPos)
		{
			DangoBrawlDropZone zone = this.Resolver.GetZone(EDragTargetKind.Bag);
			if (((zone != null) ? zone.BagExtra : null) == null)
			{
				return;
			}
			UUIItem gridContainer = zone.BagExtra.GetGridContainer();
			if (gridContainer == null || !gridContainer.IsValid())
			{
				return;
			}
			int gridSize = 136;
			ValueTuple<PanelPos, FVector2D, FVector2D> valueTuple = DangoBrawlUtil.CalcGridSnapByPointer(gridContainer, visual, pointerLguiPos, gridSize);
			visual.MoveTo(valueTuple.Item3);
		}

		// Token: 0x04022B82 RID: 142210
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022B83 RID: 142211
		private readonly DragContext Context;

		// Token: 0x04022B84 RID: 142212
		private readonly DangoBrawlSourceAdapterRegistry SourceAdapters;

		// Token: 0x04022B85 RID: 142213
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x04022B86 RID: 142214
		private readonly DropResolver Resolver;

		// Token: 0x04022B87 RID: 142215
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x04022B88 RID: 142216
		private readonly DangoBrawlInteractionModeCtrl Modes;

		// Token: 0x04022B89 RID: 142217
		[Nullable(2)]
		private DragSession Session;
	}
}
