using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548A RID: 21642
	public struct ICategoryMatchingAnimation : IFlatbufferObject
	{
		// Token: 0x17009A1C RID: 39452
		// (get) Token: 0x060220A9 RID: 139433 RVA: 0x004B1482 File Offset: 0x004AF682
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060220AA RID: 139434 RVA: 0x004B148F File Offset: 0x004AF68F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060220AB RID: 139435 RVA: 0x004B1498 File Offset: 0x004AF698
		public static ICategoryMatchingAnimation GetRootAsICategoryMatchingAnimation(ByteBuffer _bb)
		{
			return ICategoryMatchingAnimation.GetRootAsICategoryMatchingAnimation(_bb, default(ICategoryMatchingAnimation));
		}

		// Token: 0x060220AC RID: 139436 RVA: 0x004B14B4 File Offset: 0x004AF6B4
		public static ICategoryMatchingAnimation GetRootAsICategoryMatchingAnimation(ByteBuffer _bb, ICategoryMatchingAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060220AD RID: 139437 RVA: 0x004B14D1 File Offset: 0x004AF6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060220AE RID: 139438 RVA: 0x004B14E0 File Offset: 0x004AF6E0
		public ICategoryMatchingAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A1D RID: 39453
		// (get) Token: 0x060220AF RID: 139439 RVA: 0x004B14F0 File Offset: 0x004AF6F0
		public IVectorInfo? MatchPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009A1E RID: 39454
		// (get) Token: 0x060220B0 RID: 139440 RVA: 0x004B1550 File Offset: 0x004AF750
		public IVectorInfo? MatchRot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009A1F RID: 39455
		// (get) Token: 0x060220B1 RID: 139441 RVA: 0x004B15B0 File Offset: 0x004AF7B0
		public string MatchReferenceKey
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060220B2 RID: 139442 RVA: 0x004B15E7 File Offset: 0x004AF7E7
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060220B3 RID: 139443 RVA: 0x004B15F6 File Offset: 0x004AF7F6
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009A20 RID: 39456
		// (get) Token: 0x060220B4 RID: 139444 RVA: 0x004B1604 File Offset: 0x004AF804
		public string MatchSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060220B5 RID: 139445 RVA: 0x004B163C File Offset: 0x004AF83C
		public Span<byte> GetMatchSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060220B6 RID: 139446 RVA: 0x004B164C File Offset: 0x004AF84C
		public byte[] GetMatchSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009A21 RID: 39457
		// (get) Token: 0x060220B7 RID: 139447 RVA: 0x004B165C File Offset: 0x004AF85C
		public IVectorInfo? MatchSequenceOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060220B8 RID: 139448 RVA: 0x004B16BA File Offset: 0x004AF8BA
		public static Offset<ICategoryMatchingAnimation> CreateICategoryMatchingAnimation(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset), StringOffset MatchSequenceOffset = default(StringOffset), Offset<IVectorInfo> MatchSequenceOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			ICategoryMatchingAnimation.AddMatchSequenceOffset(builder, MatchSequenceOffsetOffset);
			ICategoryMatchingAnimation.AddMatchSequence(builder, MatchSequenceOffset);
			ICategoryMatchingAnimation.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			ICategoryMatchingAnimation.AddMatchRot(builder, MatchRotOffset);
			ICategoryMatchingAnimation.AddMatchPos(builder, MatchPosOffset);
			return ICategoryMatchingAnimation.EndICategoryMatchingAnimation(builder);
		}

		// Token: 0x060220B9 RID: 139449 RVA: 0x004B16EE File Offset: 0x004AF8EE
		public static void StartICategoryMatchingAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060220BA RID: 139450 RVA: 0x004B16F7 File Offset: 0x004AF8F7
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x060220BB RID: 139451 RVA: 0x004B1707 File Offset: 0x004AF907
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x060220BC RID: 139452 RVA: 0x004B1717 File Offset: 0x004AF917
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x060220BD RID: 139453 RVA: 0x004B1727 File Offset: 0x004AF927
		public static void AddMatchSequence(FlatBufferBuilder builder, StringOffset matchSequenceOffset)
		{
			builder.AddOffset(3, matchSequenceOffset.Value, 0);
		}

		// Token: 0x060220BE RID: 139454 RVA: 0x004B1737 File Offset: 0x004AF937
		public static void AddMatchSequenceOffset(FlatBufferBuilder builder, Offset<IVectorInfo> matchSequenceOffsetOffset)
		{
			builder.AddOffset(4, matchSequenceOffsetOffset.Value, 0);
		}

		// Token: 0x060220BF RID: 139455 RVA: 0x004B1747 File Offset: 0x004AF947
		public static Offset<ICategoryMatchingAnimation> EndICategoryMatchingAnimation(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingAnimation>(builder.EndTable());
		}

		// Token: 0x060220C0 RID: 139456 RVA: 0x004B1754 File Offset: 0x004AF954
		public ICategoryMatchingAnimationT UnPack()
		{
			ICategoryMatchingAnimationT categoryMatchingAnimationT = new ICategoryMatchingAnimationT();
			this.UnPackTo(categoryMatchingAnimationT);
			return categoryMatchingAnimationT;
		}

		// Token: 0x060220C1 RID: 139457 RVA: 0x004B1770 File Offset: 0x004AF970
		public void UnPackTo(ICategoryMatchingAnimationT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
			_o.MatchSequence = this.MatchSequence;
			_o.MatchSequenceOffset = ((this.MatchSequenceOffset != null) ? this.MatchSequenceOffset.Value.UnPack() : null);
		}

		// Token: 0x060220C2 RID: 139458 RVA: 0x004B1824 File Offset: 0x004AFA24
		public static Offset<ICategoryMatchingAnimation> Pack(FlatBufferBuilder builder, ICategoryMatchingAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingAnimation>);
			}
			Offset<IVectorInfo> matchPosOffset = (_o.MatchPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchPos);
			Offset<IVectorInfo> matchRotOffset = (_o.MatchRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchRot);
			StringOffset matchReferenceKeyOffset = (_o.MatchReferenceKey == null) ? default(StringOffset) : builder.CreateString(_o.MatchReferenceKey);
			StringOffset matchSequenceOffset = (_o.MatchSequence == null) ? default(StringOffset) : builder.CreateString(_o.MatchSequence);
			Offset<IVectorInfo> matchSequenceOffsetOffset = (_o.MatchSequenceOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchSequenceOffset);
			return ICategoryMatchingAnimation.CreateICategoryMatchingAnimation(builder, matchPosOffset, matchRotOffset, matchReferenceKeyOffset, matchSequenceOffset, matchSequenceOffsetOffset);
		}

		// Token: 0x0400E992 RID: 59794
		private Table __p;
	}
}
