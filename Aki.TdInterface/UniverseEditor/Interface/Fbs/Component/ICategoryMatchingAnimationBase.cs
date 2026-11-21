using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548D RID: 21645
	public struct ICategoryMatchingAnimationBase : IFlatbufferObject
	{
		// Token: 0x17009A27 RID: 39463
		// (get) Token: 0x060220CF RID: 139471 RVA: 0x004B1A20 File Offset: 0x004AFC20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060220D0 RID: 139472 RVA: 0x004B1A2D File Offset: 0x004AFC2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060220D1 RID: 139473 RVA: 0x004B1A34 File Offset: 0x004AFC34
		public static ICategoryMatchingAnimationBase GetRootAsICategoryMatchingAnimationBase(ByteBuffer _bb)
		{
			return ICategoryMatchingAnimationBase.GetRootAsICategoryMatchingAnimationBase(_bb, default(ICategoryMatchingAnimationBase));
		}

		// Token: 0x060220D2 RID: 139474 RVA: 0x004B1A50 File Offset: 0x004AFC50
		public static ICategoryMatchingAnimationBase GetRootAsICategoryMatchingAnimationBase(ByteBuffer _bb, ICategoryMatchingAnimationBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060220D3 RID: 139475 RVA: 0x004B1A6D File Offset: 0x004AFC6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060220D4 RID: 139476 RVA: 0x004B1A7C File Offset: 0x004AFC7C
		public ICategoryMatchingAnimationBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A28 RID: 39464
		// (get) Token: 0x060220D5 RID: 139477 RVA: 0x004B1A8C File Offset: 0x004AFC8C
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

		// Token: 0x17009A29 RID: 39465
		// (get) Token: 0x060220D6 RID: 139478 RVA: 0x004B1AEC File Offset: 0x004AFCEC
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

		// Token: 0x17009A2A RID: 39466
		// (get) Token: 0x060220D7 RID: 139479 RVA: 0x004B1B4C File Offset: 0x004AFD4C
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

		// Token: 0x060220D8 RID: 139480 RVA: 0x004B1B83 File Offset: 0x004AFD83
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060220D9 RID: 139481 RVA: 0x004B1B92 File Offset: 0x004AFD92
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060220DA RID: 139482 RVA: 0x004B1BA0 File Offset: 0x004AFDA0
		public static Offset<ICategoryMatchingAnimationBase> CreateICategoryMatchingAnimationBase(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICategoryMatchingAnimationBase.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			ICategoryMatchingAnimationBase.AddMatchRot(builder, MatchRotOffset);
			ICategoryMatchingAnimationBase.AddMatchPos(builder, MatchPosOffset);
			return ICategoryMatchingAnimationBase.EndICategoryMatchingAnimationBase(builder);
		}

		// Token: 0x060220DB RID: 139483 RVA: 0x004B1BC4 File Offset: 0x004AFDC4
		public static void StartICategoryMatchingAnimationBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060220DC RID: 139484 RVA: 0x004B1BCD File Offset: 0x004AFDCD
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x060220DD RID: 139485 RVA: 0x004B1BDD File Offset: 0x004AFDDD
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x060220DE RID: 139486 RVA: 0x004B1BED File Offset: 0x004AFDED
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x060220DF RID: 139487 RVA: 0x004B1BFD File Offset: 0x004AFDFD
		public static Offset<ICategoryMatchingAnimationBase> EndICategoryMatchingAnimationBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingAnimationBase>(builder.EndTable());
		}

		// Token: 0x060220E0 RID: 139488 RVA: 0x004B1C0C File Offset: 0x004AFE0C
		public ICategoryMatchingAnimationBaseT UnPack()
		{
			ICategoryMatchingAnimationBaseT categoryMatchingAnimationBaseT = new ICategoryMatchingAnimationBaseT();
			this.UnPackTo(categoryMatchingAnimationBaseT);
			return categoryMatchingAnimationBaseT;
		}

		// Token: 0x060220E1 RID: 139489 RVA: 0x004B1C28 File Offset: 0x004AFE28
		public void UnPackTo(ICategoryMatchingAnimationBaseT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
		}

		// Token: 0x060220E2 RID: 139490 RVA: 0x004B1CA0 File Offset: 0x004AFEA0
		public static Offset<ICategoryMatchingAnimationBase> Pack(FlatBufferBuilder builder, ICategoryMatchingAnimationBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingAnimationBase>);
			}
			Offset<IVectorInfo> matchPosOffset = (_o.MatchPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchPos);
			Offset<IVectorInfo> matchRotOffset = (_o.MatchRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchRot);
			StringOffset matchReferenceKeyOffset = (_o.MatchReferenceKey == null) ? default(StringOffset) : builder.CreateString(_o.MatchReferenceKey);
			return ICategoryMatchingAnimationBase.CreateICategoryMatchingAnimationBase(builder, matchPosOffset, matchRotOffset, matchReferenceKeyOffset);
		}

		// Token: 0x0400E998 RID: 59800
		private Table __p;
	}
}
