using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A1E RID: 14878
	public struct IBlackBoardVector : IFlatbufferObject
	{
		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x060141DD RID: 82397 RVA: 0x002F176D File Offset: 0x002EF96D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060141DE RID: 82398 RVA: 0x002F177A File Offset: 0x002EF97A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060141DF RID: 82399 RVA: 0x002F1784 File Offset: 0x002EF984
		public static IBlackBoardVector GetRootAsIBlackBoardVector(ByteBuffer _bb)
		{
			return IBlackBoardVector.GetRootAsIBlackBoardVector(_bb, default(IBlackBoardVector));
		}

		// Token: 0x060141E0 RID: 82400 RVA: 0x002F17A0 File Offset: 0x002EF9A0
		public static IBlackBoardVector GetRootAsIBlackBoardVector(ByteBuffer _bb, IBlackBoardVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060141E1 RID: 82401 RVA: 0x002F17BD File Offset: 0x002EF9BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060141E2 RID: 82402 RVA: 0x002F17CC File Offset: 0x002EF9CC
		public IBlackBoardVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x060141E3 RID: 82403 RVA: 0x002F17DC File Offset: 0x002EF9DC
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

		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x060141E4 RID: 82404 RVA: 0x002F1818 File Offset: 0x002EFA18
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

		// Token: 0x060141E5 RID: 82405 RVA: 0x002F184F File Offset: 0x002EFA4F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060141E6 RID: 82406 RVA: 0x002F185E File Offset: 0x002EFA5E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x060141E7 RID: 82407 RVA: 0x002F186C File Offset: 0x002EFA6C
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

		// Token: 0x060141E8 RID: 82408 RVA: 0x002F18C9 File Offset: 0x002EFAC9
		public static Offset<IBlackBoardVector> CreateIBlackBoardVector(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), Offset<IVectorInfo> VectorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IBlackBoardVector.AddVector(builder, VectorOffset);
			IBlackBoardVector.AddKey(builder, KeyOffset);
			IBlackBoardVector.AddType(builder, Type);
			return IBlackBoardVector.EndIBlackBoardVector(builder);
		}

		// Token: 0x060141E9 RID: 82409 RVA: 0x002F18ED File Offset: 0x002EFAED
		public static void StartIBlackBoardVector(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060141EA RID: 82410 RVA: 0x002F18F6 File Offset: 0x002EFAF6
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060141EB RID: 82411 RVA: 0x002F1901 File Offset: 0x002EFB01
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060141EC RID: 82412 RVA: 0x002F1911 File Offset: 0x002EFB11
		public static void AddVector(FlatBufferBuilder builder, Offset<IVectorInfo> vectorOffset)
		{
			builder.AddOffset(2, vectorOffset.Value, 0);
		}

		// Token: 0x060141ED RID: 82413 RVA: 0x002F1921 File Offset: 0x002EFB21
		public static Offset<IBlackBoardVector> EndIBlackBoardVector(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardVector>(builder.EndTable());
		}

		// Token: 0x060141EE RID: 82414 RVA: 0x002F1930 File Offset: 0x002EFB30
		public IBlackBoardVectorT UnPack()
		{
			IBlackBoardVectorT blackBoardVectorT = new IBlackBoardVectorT();
			this.UnPackTo(blackBoardVectorT);
			return blackBoardVectorT;
		}

		// Token: 0x060141EF RID: 82415 RVA: 0x002F194C File Offset: 0x002EFB4C
		public void UnPackTo(IBlackBoardVectorT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Vector = ((this.Vector != null) ? this.Vector.Value.UnPack() : null);
		}

		// Token: 0x060141F0 RID: 82416 RVA: 0x002F19A0 File Offset: 0x002EFBA0
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

		// Token: 0x0400AE8C RID: 44684
		private Table __p;
	}
}
