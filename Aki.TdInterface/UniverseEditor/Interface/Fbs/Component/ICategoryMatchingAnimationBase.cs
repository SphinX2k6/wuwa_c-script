using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F5E RID: 20318
	public struct ICategoryMatchingAnimationBase : IFlatbufferObject
	{
		// Token: 0x170092AE RID: 37550
		// (get) Token: 0x0602037D RID: 131965 RVA: 0x0047BA30 File Offset: 0x00479C30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602037E RID: 131966 RVA: 0x0047BA3D File Offset: 0x00479C3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602037F RID: 131967 RVA: 0x0047BA44 File Offset: 0x00479C44
		public static ICategoryMatchingAnimationBase GetRootAsICategoryMatchingAnimationBase(ByteBuffer _bb)
		{
			return ICategoryMatchingAnimationBase.GetRootAsICategoryMatchingAnimationBase(_bb, default(ICategoryMatchingAnimationBase));
		}

		// Token: 0x06020380 RID: 131968 RVA: 0x0047BA60 File Offset: 0x00479C60
		public static ICategoryMatchingAnimationBase GetRootAsICategoryMatchingAnimationBase(ByteBuffer _bb, ICategoryMatchingAnimationBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020381 RID: 131969 RVA: 0x0047BA7D File Offset: 0x00479C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x0047BA8C File Offset: 0x00479C8C
		public ICategoryMatchingAnimationBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092AF RID: 37551
		// (get) Token: 0x06020383 RID: 131971 RVA: 0x0047BA9C File Offset: 0x00479C9C
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

		// Token: 0x170092B0 RID: 37552
		// (get) Token: 0x06020384 RID: 131972 RVA: 0x0047BAFC File Offset: 0x00479CFC
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

		// Token: 0x170092B1 RID: 37553
		// (get) Token: 0x06020385 RID: 131973 RVA: 0x0047BB5C File Offset: 0x00479D5C
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

		// Token: 0x06020386 RID: 131974 RVA: 0x0047BB93 File Offset: 0x00479D93
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020387 RID: 131975 RVA: 0x0047BBA2 File Offset: 0x00479DA2
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06020388 RID: 131976 RVA: 0x0047BBB0 File Offset: 0x00479DB0
		public static Offset<ICategoryMatchingAnimationBase> CreateICategoryMatchingAnimationBase(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICategoryMatchingAnimationBase.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			ICategoryMatchingAnimationBase.AddMatchRot(builder, MatchRotOffset);
			ICategoryMatchingAnimationBase.AddMatchPos(builder, MatchPosOffset);
			return ICategoryMatchingAnimationBase.EndICategoryMatchingAnimationBase(builder);
		}

		// Token: 0x06020389 RID: 131977 RVA: 0x0047BBD4 File Offset: 0x00479DD4
		public static void StartICategoryMatchingAnimationBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602038A RID: 131978 RVA: 0x0047BBDD File Offset: 0x00479DDD
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x0602038B RID: 131979 RVA: 0x0047BBED File Offset: 0x00479DED
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x0602038C RID: 131980 RVA: 0x0047BBFD File Offset: 0x00479DFD
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x0602038D RID: 131981 RVA: 0x0047BC0D File Offset: 0x00479E0D
		public static Offset<ICategoryMatchingAnimationBase> EndICategoryMatchingAnimationBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingAnimationBase>(builder.EndTable());
		}

		// Token: 0x0602038E RID: 131982 RVA: 0x0047BC1C File Offset: 0x00479E1C
		public ICategoryMatchingAnimationBaseT UnPack()
		{
			ICategoryMatchingAnimationBaseT categoryMatchingAnimationBaseT = new ICategoryMatchingAnimationBaseT();
			this.UnPackTo(categoryMatchingAnimationBaseT);
			return categoryMatchingAnimationBaseT;
		}

		// Token: 0x0602038F RID: 131983 RVA: 0x0047BC38 File Offset: 0x00479E38
		public void UnPackTo(ICategoryMatchingAnimationBaseT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
		}

		// Token: 0x06020390 RID: 131984 RVA: 0x0047BCB0 File Offset: 0x00479EB0
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

		// Token: 0x0400DDEE RID: 56814
		private Table __p;
	}
}
