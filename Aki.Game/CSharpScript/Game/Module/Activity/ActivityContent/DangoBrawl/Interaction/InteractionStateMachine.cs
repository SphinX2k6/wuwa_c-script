using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction
{
	// Token: 0x020057BB RID: 22459
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionStateMachine
	{
		// Token: 0x06037761 RID: 227169 RVA: 0x00F80626 File Offset: 0x00F7E826
		[NullableContext(1)]
		public InteractionSnapshot Snapshot()
		{
			return this.Current;
		}

		// Token: 0x06037762 RID: 227170 RVA: 0x00F8062E File Offset: 0x00F7E82E
		public bool IsIdle()
		{
			return this.Current.State == EInteractionState.Idle;
		}

		// Token: 0x06037763 RID: 227171 RVA: 0x00F8063E File Offset: 0x00F7E83E
		public bool IsHolding()
		{
			return this.Current.State == EInteractionState.Holding;
		}

		// Token: 0x06037764 RID: 227172 RVA: 0x00F8064E File Offset: 0x00F7E84E
		public bool IsSticky()
		{
			return this.Current.State == EInteractionState.Sticky;
		}

		// Token: 0x06037765 RID: 227173 RVA: 0x00F8065E File Offset: 0x00F7E85E
		public bool IsBlocking()
		{
			return this.Current.State == EInteractionState.Holding || this.Current.State == EInteractionState.Sticky;
		}

		// Token: 0x06037766 RID: 227174 RVA: 0x00F8067E File Offset: 0x00F7E87E
		public InteractionPayload GetPayLoad()
		{
			return this.Current.PayLoad;
		}

		// Token: 0x06037767 RID: 227175 RVA: 0x00F8068C File Offset: 0x00F7E88C
		public bool IsBlockingOwnedBy(EDragSourceKind source, int sourceUid)
		{
			InteractionPayload payLoad = this.Current.PayLoad;
			return payLoad != null && payLoad.Visual.Source == source && payLoad.Visual.SourceUid == sourceUid;
		}

		// Token: 0x06037768 RID: 227176 RVA: 0x00F806C8 File Offset: 0x00F7E8C8
		public bool CheckIsInState(int sourceUid, EInteractionState state)
		{
			InteractionPayload payLoad = this.Current.PayLoad;
			return payLoad != null && payLoad.Visual.SourceUid == sourceUid && this.Current.State == state;
		}

		// Token: 0x06037769 RID: 227177 RVA: 0x00F80704 File Offset: 0x00F7E904
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

		// Token: 0x0603776A RID: 227178 RVA: 0x00F807C4 File Offset: 0x00F7E9C4
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

		// Token: 0x0603776B RID: 227179 RVA: 0x00F80881 File Offset: 0x00F7EA81
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

		// Token: 0x0603776C RID: 227180 RVA: 0x00F808B8 File Offset: 0x00F7EAB8
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

		// Token: 0x0603776D RID: 227181 RVA: 0x00F80920 File Offset: 0x00F7EB20
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

		// Token: 0x0603776E RID: 227182 RVA: 0x00F80994 File Offset: 0x00F7EB94
		private void EmitStateChanged()
		{
			EventSystem.Instance.Emit<EInteractionState>(EEventName.OnDangoBrawlInteractionStateChanged, this.Current.State);
		}

		// Token: 0x0401D45D RID: 119901
		[Nullable(1)]
		private InteractionSnapshot Current = new InteractionSnapshot
		{
			State = EInteractionState.Idle
		};
	}
}
