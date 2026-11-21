using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF9 RID: 15865
	public struct IBlackBoardVector : IFlatbufferObject
	{
		// Token: 0x17006B2D RID: 27437
		// (get) Token: 0x060154F9 RID: 87289 RVA: 0x00314959 File Offset: 0x00312B59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154FA RID: 87290 RVA: 0x00314966 File Offset: 0x00312B66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154FB RID: 87291 RVA: 0x00314970 File Offset: 0x00312B70
		public static IBlackBoardVector GetRootAsIBlackBoardVector(ByteBuffer _bb)
		{
			return IBlackBoardVector.GetRootAsIBlackBoardVector(_bb, default(IBlackBoardVector));
		}

		// Token: 0x060154FC RID: 87292 RVA: 0x0031498C File Offset: 0x00312B8C
		public static IBlackBoardVector GetRootAsIBlackBoardVector(ByteBuffer _bb, IBlackBoardVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154FD RID: 87293 RVA: 0x003149A9 File Offset: 0x00312BA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154FE RID: 87294 RVA: 0x003149B8 File Offset: 0x00312BB8
		public IBlackBoardVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B2E RID: 27438
		// (get) Token: 0x060154FF RID: 87295 RVA: 0x003149C8 File Offset: 0x00312BC8
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B2F RID: 27439
		// (get) Token: 0x06015500 RID: 87296 RVA: 0x00314A04 File Offset: 0x00312C04
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015501 RID: 87297 RVA: 0x00314A3B File Offset: 0x00312C3B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015502 RID: 87298 RVA: 0x00314A4A File Offset: 0x00312C4A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B30 RID: 27440
		// (get) Token: 0x06015503 RID: 87299 RVA: 0x00314A58 File Offset: 0x00312C58
		public IVectorInfo? Vector
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015504 RID: 87300 RVA: 0x00314AB5 File Offset: 0x00312CB5
		public static Offset<IBlackBoardVector> CreateIBlackBoardVector(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), Offset<IVectorInfo> VectorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IBlackBoardVector.AddVector(builder, VectorOffset);
			IBlackBoardVector.AddKey(builder, KeyOffset);
			IBlackBoardVector.AddType(builder, Type);
			return IBlackBoardVector.EndIBlackBoardVector(builder);
		}

		// Token: 0x06015505 RID: 87301 RVA: 0x00314AD9 File Offset: 0x00312CD9
		public static void StartIBlackBoardVector(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015506 RID: 87302 RVA: 0x00314AE2 File Offset: 0x00312CE2
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015507 RID: 87303 RVA: 0x00314AED File Offset: 0x00312CED
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06015508 RID: 87304 RVA: 0x00314AFD File Offset: 0x00312CFD
		public static void AddVector(FlatBufferBuilder builder, Offset<IVectorInfo> vectorOffset)
		{
			builder.AddOffset(2, vectorOffset.Value, 0);
		}

		// Token: 0x06015509 RID: 87305 RVA: 0x00314B0D File Offset: 0x00312D0D
		public static Offset<IBlackBoardVector> EndIBlackBoardVector(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardVector>(builder.EndTable());
		}

		// Token: 0x0601550A RID: 87306 RVA: 0x00314B1C File Offset: 0x00312D1C
		public IBlackBoardVectorT UnPack()
		{
			IBlackBoardVectorT blackBoardVectorT = new IBlackBoardVectorT();
			this.UnPackTo(blackBoardVectorT);
			return blackBoardVectorT;
		}

		// Token: 0x0601550B RID: 87307 RVA: 0x00314B38 File Offset: 0x00312D38
		public void UnPackTo(IBlackBoardVectorT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Vector = ((this.Vector != null) ? this.Vector.Value.UnPack() : null);
		}

		// Token: 0x0601550C RID: 87308 RVA: 0x00314B8C File Offset: 0x00312D8C
		public static Offset<IBlackBoardVector> Pack(FlatBufferBuilder builder, IBlackBoardVectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardVector>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IVectorInfo> vectorOffset = (_o.Vector == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Vector);
			return IBlackBoardVector.CreateIBlackBoardVector(builder, _o.Type, keyOffset, vectorOffset);
		}

		// Token: 0x0400B7AE RID: 47022
		private Table __p;
	}
}
