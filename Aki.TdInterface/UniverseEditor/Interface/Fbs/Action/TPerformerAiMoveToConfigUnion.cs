using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774A RID: 30538
	public class TPerformerAiMoveToConfigUnion
	{
		// Token: 0x1700E675 RID: 58997
		// (get) Token: 0x060377B0 RID: 227248 RVA: 0x00782986 File Offset: 0x00780B86
		// (set) Token: 0x060377B1 RID: 227249 RVA: 0x0078298E File Offset: 0x00780B8E
		public TPerformerAiMoveToConfig Type { get; set; }

		// Token: 0x1700E676 RID: 58998
		// (get) Token: 0x060377B2 RID: 227250 RVA: 0x00782997 File Offset: 0x00780B97
		// (set) Token: 0x060377B3 RID: 227251 RVA: 0x0078299F File Offset: 0x00780B9F
		public object Value { get; set; }

		// Token: 0x060377B4 RID: 227252 RVA: 0x007829A8 File Offset: 0x00780BA8
		public TPerformerAiMoveToConfigUnion()
		{
			this.Type = TPerformerAiMoveToConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060377B5 RID: 227253 RVA: 0x007829BE File Offset: 0x00780BBE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377B6 RID: 227254 RVA: 0x007829D0 File Offset: 0x00780BD0
		public IPerformerAiMoveToEntityT AsIPerformerAiMoveToEntity()
		{
			return this.As<IPerformerAiMoveToEntityT>();
		}

		// Token: 0x060377B7 RID: 227255 RVA: 0x007829D8 File Offset: 0x00780BD8
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToEntity(IPerformerAiMoveToEntityT _iperformeraimovetoentity)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToEntity,
				Value = _iperformeraimovetoentity
			};
		}

		// Token: 0x060377B8 RID: 227256 RVA: 0x007829ED File Offset: 0x00780BED
		public IPerformerAiMoveToPlayerT AsIPerformerAiMoveToPlayer()
		{
			return this.As<IPerformerAiMoveToPlayerT>();
		}

		// Token: 0x060377B9 RID: 227257 RVA: 0x007829F5 File Offset: 0x00780BF5
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToPlayer(IPerformerAiMoveToPlayerT _iperformeraimovetoplayer)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToPlayer,
				Value = _iperformeraimovetoplayer
			};
		}

		// Token: 0x060377BA RID: 227258 RVA: 0x00782A0A File Offset: 0x00780C0A
		public IPerformerAiMoveToPositionT AsIPerformerAiMoveToPosition()
		{
			return this.As<IPerformerAiMoveToPositionT>();
		}

		// Token: 0x060377BB RID: 227259 RVA: 0x00782A12 File Offset: 0x00780C12
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToPosition(IPerformerAiMoveToPositionT _iperformeraimovetoposition)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToPosition,
				Value = _iperformeraimovetoposition
			};
		}

		// Token: 0x060377BC RID: 227260 RVA: 0x00782A28 File Offset: 0x00780C28
		public static int Pack(FlatBufferBuilder builder, TPerformerAiMoveToConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPerformerAiMoveToConfig.IPerformerAiMoveToEntity:
				return IPerformerAiMoveToEntity.Pack(builder, _o.AsIPerformerAiMoveToEntity()).Value;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPlayer:
				return IPerformerAiMoveToPlayer.Pack(builder, _o.AsIPerformerAiMoveToPlayer()).Value;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPosition:
				return IPerformerAiMoveToPosition.Pack(builder, _o.AsIPerformerAiMoveToPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
