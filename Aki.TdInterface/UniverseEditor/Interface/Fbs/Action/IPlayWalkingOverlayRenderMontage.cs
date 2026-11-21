using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C5 RID: 29893
	public struct IPlayWalkingOverlayRenderMontage : IFlatbufferObject
	{
		// Token: 0x1700DBF3 RID: 56307
		// (get) Token: 0x06034663 RID: 214627 RVA: 0x0070E6E0 File Offset: 0x0070C8E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034664 RID: 214628 RVA: 0x0070E6ED File Offset: 0x0070C8ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034665 RID: 214629 RVA: 0x0070E6F4 File Offset: 0x0070C8F4
		public static IPlayWalkingOverlayRenderMontage GetRootAsIPlayWalkingOverlayRenderMontage(ByteBuffer _bb)
		{
			return IPlayWalkingOverlayRenderMontage.GetRootAsIPlayWalkingOverlayRenderMontage(_bb, default(IPlayWalkingOverlayRenderMontage));
		}

		// Token: 0x06034666 RID: 214630 RVA: 0x0070E710 File Offset: 0x0070C910
		public static IPlayWalkingOverlayRenderMontage GetRootAsIPlayWalkingOverlayRenderMontage(ByteBuffer _bb, IPlayWalkingOverlayRenderMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034667 RID: 214631 RVA: 0x0070E72D File Offset: 0x0070C92D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034668 RID: 214632 RVA: 0x0070E73C File Offset: 0x0070C93C
		public IPlayWalkingOverlayRenderMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBF4 RID: 56308
		// (get) Token: 0x06034669 RID: 214633 RVA: 0x0070E74C File Offset: 0x0070C94C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBF5 RID: 56309
		// (get) Token: 0x0603466A RID: 214634 RVA: 0x0070E788 File Offset: 0x0070C988
		public IMontageId? OverlapMontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DBF6 RID: 56310
		// (get) Token: 0x0603466B RID: 214635 RVA: 0x0070E7E8 File Offset: 0x0070C9E8
		public float LoopDuration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBF7 RID: 56311
		// (get) Token: 0x0603466C RID: 214636 RVA: 0x0070E828 File Offset: 0x0070CA28
		public int RepeatTimes
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBF8 RID: 56312
		// (get) Token: 0x0603466D RID: 214637 RVA: 0x0070E868 File Offset: 0x0070CA68
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603466E RID: 214638 RVA: 0x0070E8A5 File Offset: 0x0070CAA5
		public static Offset<IPlayWalkingOverlayRenderMontage> CreateIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder, int EntityId = 0, Offset<IMontageId> OverlapMontageIdOffset = default(Offset<IMontageId>), float LoopDuration = 0f, int RepeatTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPlayWalkingOverlayRenderMontage.AddRepeatTimes(builder, RepeatTimes);
			IPlayWalkingOverlayRenderMontage.AddLoopDuration(builder, LoopDuration);
			IPlayWalkingOverlayRenderMontage.AddOverlapMontageId(builder, OverlapMontageIdOffset);
			IPlayWalkingOverlayRenderMontage.AddEntityId(builder, EntityId);
			IPlayWalkingOverlayRenderMontage.AddNullMask(builder, NullMask);
			return IPlayWalkingOverlayRenderMontage.EndIPlayWalkingOverlayRenderMontage(builder);
		}

		// Token: 0x0603466F RID: 214639 RVA: 0x0070E8D9 File Offset: 0x0070CAD9
		public static void StartIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06034670 RID: 214640 RVA: 0x0070E8E2 File Offset: 0x0070CAE2
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06034671 RID: 214641 RVA: 0x0070E8ED File Offset: 0x0070CAED
		public static void AddOverlapMontageId(FlatBufferBuilder builder, Offset<IMontageId> overlapMontageIdOffset)
		{
			builder.AddOffset(1, overlapMontageIdOffset.Value, 0);
		}

		// Token: 0x06034672 RID: 214642 RVA: 0x0070E8FD File Offset: 0x0070CAFD
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(2, loopDuration, 0.0);
		}

		// Token: 0x06034673 RID: 214643 RVA: 0x0070E910 File Offset: 0x0070CB10
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(3, repeatTimes, 0);
		}

		// Token: 0x06034674 RID: 214644 RVA: 0x0070E91B File Offset: 0x0070CB1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06034675 RID: 214645 RVA: 0x0070E926 File Offset: 0x0070CB26
		public static Offset<IPlayWalkingOverlayRenderMontage> EndIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayWalkingOverlayRenderMontage>(builder.EndTable());
		}

		// Token: 0x06034676 RID: 214646 RVA: 0x0070E934 File Offset: 0x0070CB34
		public IPlayWalkingOverlayRenderMontageT UnPack()
		{
			IPlayWalkingOverlayRenderMontageT playWalkingOverlayRenderMontageT = new IPlayWalkingOverlayRenderMontageT();
			this.UnPackTo(playWalkingOverlayRenderMontageT);
			return playWalkingOverlayRenderMontageT;
		}

		// Token: 0x06034677 RID: 214647 RVA: 0x0070E950 File Offset: 0x0070CB50
		public void UnPackTo(IPlayWalkingOverlayRenderMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.OverlapMontageId = ((this.OverlapMontageId != null) ? this.OverlapMontageId.Value.UnPack() : null);
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034678 RID: 214648 RVA: 0x0070E9BC File Offset: 0x0070CBBC
		public static Offset<IPlayWalkingOverlayRenderMontage> Pack(FlatBufferBuilder builder, IPlayWalkingOverlayRenderMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayWalkingOverlayRenderMontage>);
			}
			Offset<IMontageId> overlapMontageIdOffset = (_o.OverlapMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.OverlapMontageId);
			return IPlayWalkingOverlayRenderMontage.CreateIPlayWalkingOverlayRenderMontage(builder, _o.EntityId, overlapMontageIdOffset, _o.LoopDuration, _o.RepeatTimes, _o.NullMask);
		}

		// Token: 0x04012678 RID: 75384
		private Table __p;
	}
}
