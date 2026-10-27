using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction
{
	// Token: 0x0200686B RID: 26731
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionStateMachine
	{
		// Token: 0x06042C0A RID: 273418 RVA: 0x0103F146 File Offset: 0x0103D346
		[NullableContext(1)]
		public InteractionSnapshot Snapshot()
		{
			return this.Current;
		}

		// Token: 0x06042C0B RID: 273419 RVA: 0x0103F14E File Offset: 0x0103D34E
		public bool IsIdle()
		{
			return this.Current.State == EInteractionState.Idle;
		}

		// Token: 0x06042C0C RID: 273420 RVA: 0x0103F15E File Offset: 0x0103D35E
		public bool IsHolding()
		{
			return this.Current.State == EInteractionState.Holding;
		}

		// Token: 0x06042C0D RID: 273421 RVA: 0x0103F16E File Offset: 0x0103D36E
		public bool IsSticky()
		{
			return this.Current.State == EInteractionState.Sticky;
		}

		// Token: 0x06042C0E RID: 273422 RVA: 0x0103F17E File Offset: 0x0103D37E
		public bool IsBlocking()
		{
			return this.Current.State == EInteractionState.Holding || this.Current.State == EInteractionState.Sticky;
		}

		// Token: 0x06042C0F RID: 273423 RVA: 0x0103F19E File Offset: 0x0103D39E
		public InteractionPayload GetPayLoad()
		{
			return this.Current.PayLoad;
		}

		// Token: 0x06042C10 RID: 273424 RVA: 0x0103F1AC File Offset: 0x0103D3AC
		public bool IsBlockingOwnedBy(EDragSourceKind source, int sourceUid)
		{
			InteractionPayload payLoad = this.Current.PayLoad;
			return payLoad != null && payLoad.Visual.Source == source && payLoad.Visual.SourceUid == sourceUid;
		}

		// Token: 0x06042C11 RID: 273425 RVA: 0x0103F1E8 File Offset: 0x0103D3E8
		public bool CheckIsInState(int sourceUid, EInteractionState state)
		{
			InteractionPayload payLoad = this.Current.PayLoad;
			return payLoad != null && payLoad.Visual.SourceUid == sourceUid && this.Current.State == state;
		}

		// Token: 0x06042C12 RID: 273426 RVA: 0x0103F224 File Offset: 0x0103D424
		public void EnterHolding([Nullable(1)] IDragSourceAdapter adapter, [Nullable(1)] IDragVisual visual, ItemSucAnchor anchor, DragTarget lastTarget, IDangoBrawlDraggableView sourceView = null)
		{
			if (this.Current.State != EInteractionState.Idle)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[InteractionFSM] EnterHolding 时已在 ");
				defaultInterpolatedStringHandler.AppendFormatted<EInteractionState>(this.Current.State);
				defaultInterpolatedStringHandler.AppendLiteral("，先取消旧 entry");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CancelCurrent();
			}
			this.Current = new InteractionSnapshot
			{
				State = EInteractionState.Holding,
				PayLoad = new InteractionPayload
				{
					Adapter = adapter,
					Visual = visual,
					LastSucAnchor = anchor,
					LastTarget = lastTarget,
					SourceView = sourceView
				}
			};
			this.EmitStateChanged();
		}

		// Token: 0x06042C13 RID: 273427 RVA: 0x0103F2E4 File Offset: 0x0103D4E4
		public void EnterSticky([Nullable(1)] IDragSourceAdapter adapter, [Nullable(1)] IDragVisual visual, ItemSucAnchor anchor, DragTarget lastTarget, IDangoBrawlDraggableView sourceView = null)
		{
			if (this.Current.State != EInteractionState.Idle)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[InteractionFSM] EnterSticky 时已在 ");
				defaultInterpolatedStringHandler.AppendFormatted<EInteractionState>(this.Current.State);
				defaultInterpolatedStringHandler.AppendLiteral("，先取消旧 entry");
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CancelCurrent();
			}
			this.Current = new InteractionSnapshot
			{
				State = EInteractionState.Sticky,
				PayLoad = new InteractionPayload
				{
					Adapter = adapter,
					Visual = visual,
					LastSucAnchor = anchor,
					LastTarget = lastTarget,
					SourceView = sourceView
				}
			};
			this.EmitStateChanged();
		}

		// Token: 0x06042C14 RID: 273428 RVA: 0x0103F3A1 File Offset: 0x0103D5A1
		public InteractionPayload ExitBlocking()
		{
			if (this.Current.State == EInteractionState.Idle)
			{
				return null;
			}
			InteractionPayload payLoad = this.Current.PayLoad;
			this.Current = new InteractionSnapshot
			{
				State = EInteractionState.Idle
			};
			this.EmitStateChanged();
			return payLoad;
		}

		// Token: 0x06042C15 RID: 273429 RVA: 0x0103F3D8 File Offset: 0x0103D5D8
		public void StickyToHolding(DragTarget newLastTarget = null)
		{
			if (this.Current.State != EInteractionState.Sticky || this.Current.PayLoad == null)
			{
				return;
			}
			if (newLastTarget != null)
			{
				this.Current.PayLoad.LastTarget = newLastTarget;
			}
			this.Current = new InteractionSnapshot
			{
				State = EInteractionState.Holding,
				PayLoad = this.Current.PayLoad
			};
			this.EmitStateChanged();
		}

		// Token: 0x06042C16 RID: 273430 RVA: 0x0103F440 File Offset: 0x0103D640
		public void CancelCurrent()
		{
			if (this.Current.State == EInteractionState.Idle || this.Current.PayLoad == null)
			{
				return;
			}
			InteractionPayload payLoad = this.Current.PayLoad;
			this.Current = new InteractionSnapshot
			{
				State = EInteractionState.Idle
			};
			payLoad.Adapter.Cancel(payLoad.Visual, payLoad.LastSucAnchor);
			IDangoBrawlDraggableView sourceView = payLoad.SourceView;
			if (sourceView != null)
			{
				sourceView.OnDragSourceEnd();
			}
			this.EmitStateChanged();
		}

		// Token: 0x06042C17 RID: 273431 RVA: 0x0103F4B4 File Offset: 0x0103D6B4
		private void EmitStateChanged()
		{
			EventSystem.Instance.Emit<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, this.Current.State);
		}

		// Token: 0x04022C00 RID: 142336
		[Nullable(1)]
		private InteractionSnapshot Current = new InteractionSnapshot
		{
			State = EInteractionState.Idle
		};
	}
}
