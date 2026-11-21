using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E7A RID: 32378
	public class TCheckFlowLookAtTargetUnion
	{
		// Token: 0x1700F219 RID: 61977
		// (get) Token: 0x0603A783 RID: 239491 RVA: 0x007DEFB8 File Offset: 0x007DD1B8
		// (set) Token: 0x0603A784 RID: 239492 RVA: 0x007DEFC0 File Offset: 0x007DD1C0
		public TCheckFlowLookAtTarget Type { get; set; }

		// Token: 0x1700F21A RID: 61978
		// (get) Token: 0x0603A785 RID: 239493 RVA: 0x007DEFC9 File Offset: 0x007DD1C9
		// (set) Token: 0x0603A786 RID: 239494 RVA: 0x007DEFD1 File Offset: 0x007DD1D1
		public object Value { get; set; }

		// Token: 0x0603A787 RID: 239495 RVA: 0x007DEFDA File Offset: 0x007DD1DA
		public TCheckFlowLookAtTargetUnion()
		{
			this.Type = TCheckFlowLookAtTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603A788 RID: 239496 RVA: 0x007DEFF0 File Offset: 0x007DD1F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A789 RID: 239497 RVA: 0x007DF002 File Offset: 0x007DD202
		public ICheckFlowLookAtEntityT AsICheckFlowLookAtEntity()
		{
			return this.As<ICheckFlowLookAtEntityT>();
		}

		// Token: 0x0603A78A RID: 239498 RVA: 0x007DF00A File Offset: 0x007DD20A
		public static TCheckFlowLookAtTargetUnion FromICheckFlowLookAtEntity(ICheckFlowLookAtEntityT _icheckflowlookatentity)
		{
			return new TCheckFlowLookAtTargetUnion
			{
				Type = TCheckFlowLookAtTarget.ICheckFlowLookAtEntity,
				Value = _icheckflowlookatentity
			};
		}

		// Token: 0x0603A78B RID: 239499 RVA: 0x007DF01F File Offset: 0x007DD21F
		public ICheckFlowLookAtPlayerT AsICheckFlowLookAtPlayer()
		{
			return this.As<ICheckFlowLookAtPlayerT>();
		}

		// Token: 0x0603A78C RID: 239500 RVA: 0x007DF027 File Offset: 0x007DD227
		public static TCheckFlowLookAtTargetUnion FromICheckFlowLookAtPlayer(ICheckFlowLookAtPlayerT _icheckflowlookatplayer)
		{
			return new TCheckFlowLookAtTargetUnion
			{
				Type = TCheckFlowLookAtTarget.ICheckFlowLookAtPlayer,
				Value = _icheckflowlookatplayer
			};
		}

		// Token: 0x0603A78D RID: 239501 RVA: 0x007DF03C File Offset: 0x007DD23C
		public static int Pack(FlatBufferBuilder builder, TCheckFlowLookAtTargetUnion _o)
		{
			TCheckFlowLookAtTarget type = _o.Type;
			if (type == TCheckFlowLookAtTarget.ICheckFlowLookAtEntity)
			{
				return ICheckFlowLookAtEntity.Pack(builder, _o.AsICheckFlowLookAtEntity()).Value;
			}
			if (type != TCheckFlowLookAtTarget.ICheckFlowLookAtPlayer)
			{
				return 0;
			}
			return ICheckFlowLookAtPlayer.Pack(builder, _o.AsICheckFlowLookAtPlayer()).Value;
		}
	}
}
