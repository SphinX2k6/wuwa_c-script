using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078DB RID: 30939
	public struct ISignalDevice2 : IFlatbufferObject
	{
		// Token: 0x1700E307 RID: 58119
		// (get) Token: 0x06036797 RID: 223127 RVA: 0x0074B22A File Offset: 0x0074942A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036798 RID: 223128 RVA: 0x0074B237 File Offset: 0x00749437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036799 RID: 223129 RVA: 0x0074B240 File Offset: 0x00749440
		public static ISignalDevice2 GetRootAsISignalDevice2(ByteBuffer _bb)
		{
			return ISignalDevice2.GetRootAsISignalDevice2(_bb, default(ISignalDevice2));
		}

		// Token: 0x0603679A RID: 223130 RVA: 0x0074B25C File Offset: 0x0074945C
		public static ISignalDevice2 GetRootAsISignalDevice2(ByteBuffer _bb, ISignalDevice2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603679B RID: 223131 RVA: 0x0074B279 File Offset: 0x00749479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603679C RID: 223132 RVA: 0x0074B288 File Offset: 0x00749488
		public ISignalDevice2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E308 RID: 58120
		// (get) Token: 0x0603679D RID: 223133 RVA: 0x0074B298 File Offset: 0x00749498
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

		// Token: 0x0603679E RID: 223134 RVA: 0x0074B2D4 File Offset: 0x007494D4
		public IColorPiece? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IColorPiece?(default(IColorPiece).__assign(this.__p.__vector(num) + j, this.__p.bb));
		}

		// Token: 0x1700E309 RID: 58121
		// (get) Token: 0x0603679F RID: 223135 RVA: 0x0074B328 File Offset: 0x00749528
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

		// Token: 0x060367A0 RID: 223136 RVA: 0x0074B353 File Offset: 0x00749553
		public static Offset<ISignalDevice2> CreateISignalDevice2(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISignalDevice2.AddConfig(builder, ConfigOffset);
			ISignalDevice2.AddType(builder, Type);
			return ISignalDevice2.EndISignalDevice2(builder);
		}

		// Token: 0x060367A1 RID: 223137 RVA: 0x0074B370 File Offset: 0x00749570
		public static void StartISignalDevice2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060367A2 RID: 223138 RVA: 0x0074B379 File Offset: 0x00749579
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060367A3 RID: 223139 RVA: 0x0074B384 File Offset: 0x00749584
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x060367A4 RID: 223140 RVA: 0x0074B394 File Offset: 0x00749594
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060367A5 RID: 223141 RVA: 0x0074B39F File Offset: 0x0074959F
		public static Offset<ISignalDevice2> EndISignalDevice2(FlatBufferBuilder builder)
		{
			return new Offset<ISignalDevice2>(builder.EndTable());
		}

		// Token: 0x060367A6 RID: 223142 RVA: 0x0074B3AC File Offset: 0x007495AC
		public ISignalDevice2T UnPack()
		{
			ISignalDevice2T signalDevice2T = new ISignalDevice2T();
			this.UnPackTo(signalDevice2T);
			return signalDevice2T;
		}

		// Token: 0x060367A7 RID: 223143 RVA: 0x0074B3C8 File Offset: 0x007495C8
		public void UnPackTo(ISignalDevice2T _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IColorPieceT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060367A8 RID: 223144 RVA: 0x0074B434 File Offset: 0x00749634
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

		// Token: 0x04012B8B RID: 76683
		private Table __p;
	}
}
