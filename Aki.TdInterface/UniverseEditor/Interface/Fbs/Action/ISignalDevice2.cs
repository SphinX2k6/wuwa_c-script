using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710F RID: 28943
	public struct ISignalDevice2 : IFlatbufferObject
	{
		// Token: 0x1700D724 RID: 55076
		// (get) Token: 0x060334F5 RID: 210165 RVA: 0x006EAC1E File Offset: 0x006E8E1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334F6 RID: 210166 RVA: 0x006EAC2B File Offset: 0x006E8E2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334F7 RID: 210167 RVA: 0x006EAC34 File Offset: 0x006E8E34
		public static ISignalDevice2 GetRootAsISignalDevice2(ByteBuffer _bb)
		{
			return ISignalDevice2.GetRootAsISignalDevice2(_bb, default(ISignalDevice2));
		}

		// Token: 0x060334F8 RID: 210168 RVA: 0x006EAC50 File Offset: 0x006E8E50
		public static ISignalDevice2 GetRootAsISignalDevice2(ByteBuffer _bb, ISignalDevice2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334F9 RID: 210169 RVA: 0x006EAC6D File Offset: 0x006E8E6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334FA RID: 210170 RVA: 0x006EAC7C File Offset: 0x006E8E7C
		public ISignalDevice2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D725 RID: 55077
		// (get) Token: 0x060334FB RID: 210171 RVA: 0x006EAC8C File Offset: 0x006E8E8C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060334FC RID: 210172 RVA: 0x006EACC8 File Offset: 0x006E8EC8
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700D726 RID: 55078
		// (get) Token: 0x060334FD RID: 210173 RVA: 0x006EAD1C File Offset: 0x006E8F1C
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060334FE RID: 210174 RVA: 0x006EAD47 File Offset: 0x006E8F47
		public static Offset<ISignalDevice2> CreateISignalDevice2(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISignalDevice2.AddConfig(builder, ConfigOffset);
			ISignalDevice2.AddType(builder, Type);
			return ISignalDevice2.EndISignalDevice2(builder);
		}

		// Token: 0x060334FF RID: 210175 RVA: 0x006EAD64 File Offset: 0x006E8F64
		public static void StartISignalDevice2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033500 RID: 210176 RVA: 0x006EAD6D File Offset: 0x006E8F6D
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033501 RID: 210177 RVA: 0x006EAD78 File Offset: 0x006E8F78
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06033502 RID: 210178 RVA: 0x006EAD88 File Offset: 0x006E8F88
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06033503 RID: 210179 RVA: 0x006EAD93 File Offset: 0x006E8F93
		public static Offset<ISignalDevice2> EndISignalDevice2(FlatBufferBuilder builder)
		{
			return new Offset<ISignalDevice2>(builder.EndTable());
		}

		// Token: 0x06033504 RID: 210180 RVA: 0x006EADA0 File Offset: 0x006E8FA0
		public ISignalDevice2T UnPack()
		{
			ISignalDevice2T signalDevice2T = new ISignalDevice2T();
			this.UnPackTo(signalDevice2T);
			return signalDevice2T;
		}

		// Token: 0x06033505 RID: 210181 RVA: 0x006EADBC File Offset: 0x006E8FBC
		public void UnPackTo(ISignalDevice2T _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IColorPieceT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033506 RID: 210182 RVA: 0x006EAE28 File Offset: 0x006E9028
		public static Offset<ISignalDevice2> Pack(FlatBufferBuilder builder, ISignalDevice2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ISignalDevice2>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				ISignalDevice2.StartConfigVector(builder, _o.Config.Count);
				for (int i = _o.Config.Count - 1; i >= 0; i--)
				{
					IColorPiece.Pack(builder, _o.Config[i]);
				}
				configOffset = builder.EndVector();
			}
			return ISignalDevice2.CreateISignalDevice2(builder, _o.Type, configOffset);
		}

		// Token: 0x04011B9D RID: 72605
		private Table __p;
	}
}
