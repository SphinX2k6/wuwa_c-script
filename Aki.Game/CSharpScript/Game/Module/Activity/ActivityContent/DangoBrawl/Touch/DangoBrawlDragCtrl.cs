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
	// Token: 0x020057A7 RID: 22439
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlDragCtrl
	{
		// Token: 0x17006AA7 RID: 27303
		// (get) Token: 0x0603763D RID: 226877 RVA: 0x00F79D09 File Offset: 0x00F77F09
		public bool IsDragging
		{
			get
			{
				return this.Session != null;
			}
		}

		// Token: 0x17006AA8 RID: 27304
		// (get) Token: 0x0603763E RID: 226878 RVA: 0x00F79D14 File Offset: 0x00F77F14
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

		// Token: 0x17006AA9 RID: 27305
		// (get) Token: 0x0603763F RID: 226879 RVA: 0x00F79D44 File Offset: 0x00F77F44
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

		// Token: 0x06037640 RID: 226880 RVA: 0x00F79D57 File Offset: 0x00F77F57
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

		// Token: 0x06037641 RID: 226881 RVA: 0x00F79D94 File Offset: 0x00F77F94
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

		// Token: 0x06037642 RID: 226882 RVA: 0x00F79DEF File Offset: 0x00F77FEF
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

		// Token: 0x06037643 RID: 226883 RVA: 0x00F79E24 File Offset: 0x00F78024
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

		// Token: 0x06037644 RID: 226884 RVA: 0x00F79E70 File Offset: 0x00F78070
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

		// Token: 0x06037645 RID: 226885 RVA: 0x00F79FCC File Offset: 0x00F781CC
		public bool IsHoveringBlockingItem()
		{
			InteractionPayload payLoad = this.InteractionFsm.GetPayLoad();
			return payLoad != null && this.Context.IsHovered(payLoad.Visual.Source, payLoad.Visual.SourceUid);
		}

		// Token: 0x06037646 RID: 226886 RVA: 0x00F7A00C File Offset: 0x00F7820C
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

		// Token: 0x06037647 RID: 226887 RVA: 0x00F7A091 File Offset: 0x00F78291
		[NullableContext(2)]
		public void ReleaseHoldingSourceView(IDangoBrawlDraggableView sourceView = null)
		{
			if (sourceView != null)
			{
				sourceView.OnDragSourceEnd();
			}
			this.Highlight.Clear();
		}

		// Token: 0x06037648 RID: 226888 RVA: 0x00F7A0A7 File Offset: 0x00F782A7
		public void RepositionAfterRotate()
		{
			if (this.Session == null)
			{
				return;
			}
			this.Session.Visual.MoveTo(DangoBrawlUtil.PointerToLgui(this.Session.LastPointerPos));
			this.UpdateHighlightFromPointer(this.Session.LastPointerPos);
		}

		// Token: 0x06037649 RID: 226889 RVA: 0x00F7A0E3 File Offset: 0x00F782E3
		private void UpdateHighlightFromPointer(FVector pointerPos)
		{
			if (this.Session != null)
			{
				this.Highlight.UpdateFromPointer(this.Session.Visual, pointerPos);
			}
		}

		// Token: 0x0603764A RID: 226890 RVA: 0x00F7A104 File Offset: 0x00F78304
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

		// Token: 0x0603764B RID: 226891 RVA: 0x00F7A174 File Offset: 0x00F78374
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

		// Token: 0x0401D3DF RID: 119775
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D3E0 RID: 119776
		private readonly DragContext Context;

		// Token: 0x0401D3E1 RID: 119777
		private readonly DangoBrawlSourceAdapterRegistry SourceAdapters;

		// Token: 0x0401D3E2 RID: 119778
		private readonly InteractionStateMachine InteractionFsm;

		// Token: 0x0401D3E3 RID: 119779
		private readonly DropResolver Resolver;

		// Token: 0x0401D3E4 RID: 119780
		private readonly BagHighlightPresenter Highlight;

		// Token: 0x0401D3E5 RID: 119781
		private readonly DangoBrawlInteractionModeCtrl Modes;

		// Token: 0x0401D3E6 RID: 119782
		[Nullable(2)]
		private DragSession Session;
	}
}
