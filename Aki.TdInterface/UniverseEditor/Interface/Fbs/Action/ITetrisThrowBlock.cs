using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CA RID: 29642
	public struct ITetrisThrowBlock : IFlatbufferObject
	{
		// Token: 0x1700E11D RID: 57629
		// (get) Token: 0x06035D5B RID: 220507 RVA: 0x007540B6 File Offset: 0x007522B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D5C RID: 220508 RVA: 0x007540C3 File Offset: 0x007522C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D5D RID: 220509 RVA: 0x007540CC File Offset: 0x007522CC
		public static ITetrisThrowBlock GetRootAsITetrisThrowBlock(ByteBuffer _bb)
		{
			return ITetrisThrowBlock.GetRootAsITetrisThrowBlock(_bb, default(ITetrisThrowBlock));
		}

		// Token: 0x06035D5E RID: 220510 RVA: 0x007540E8 File Offset: 0x007522E8
		public static ITetrisThrowBlock GetRootAsITetrisThrowBlock(ByteBuffer _bb, ITetrisThrowBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D5F RID: 220511 RVA: 0x00754105 File Offset: 0x00752305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D60 RID: 220512 RVA: 0x00754114 File Offset: 0x00752314
		public ITetrisThrowBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E11E RID: 57630
		// (get) Token: 0x06035D61 RID: 220513 RVA: 0x00754124 File Offset: 0x00752324
		public string ShapeName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D62 RID: 220514 RVA: 0x0075415B File Offset: 0x0075235B
		public Span<byte> GetShapeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035D63 RID: 220515 RVA: 0x0075416A File Offset: 0x0075236A
		public byte[] GetShapeNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E11F RID: 57631
		// (get) Token: 0x06035D64 RID: 220516 RVA: 0x00754178 File Offset: 0x00752378
		public int PosIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E120 RID: 57632
		// (get) Token: 0x06035D65 RID: 220517 RVA: 0x007541B4 File Offset: 0x007523B4
		public int HeightIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E121 RID: 57633
		// (get) Token: 0x06035D66 RID: 220518 RVA: 0x007541F0 File Offset: 0x007523F0
		public ETetrisRotation Rotation
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETetrisRotation.Origin;
				}
				return (ETetrisRotation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E122 RID: 57634
		// (get) Token: 0x06035D67 RID: 220519 RVA: 0x00754230 File Offset: 0x00752430
		public bool IsDelayFall
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E123 RID: 57635
		// (get) Token: 0x06035D68 RID: 220520 RVA: 0x00754270 File Offset: 0x00752470
		public int FallSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E124 RID: 57636
		// (get) Token: 0x06035D69 RID: 220521 RVA: 0x007542B0 File Offset: 0x007524B0
		public int FallAcceleration
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E125 RID: 57637
		// (get) Token: 0x06035D6A RID: 220522 RVA: 0x007542F0 File Offset: 0x007524F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D6B RID: 220523 RVA: 0x00754330 File Offset: 0x00752530
		public static Offset<ITetrisThrowBlock> CreateITetrisThrowBlock(FlatBufferBuilder builder, StringOffset ShapeNameOffset = default(StringOffset), int PosIndex = 0, int HeightIndex = 0, ETetrisRotation Rotation = ETetrisRotation.Origin, bool IsDelayFall = false, int FallSpeed = 0, int FallAcceleration = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			ITetrisThrowBlock.AddFallAcceleration(builder, FallAcceleration);
			ITetrisThrowBlock.AddFallSpeed(builder, FallSpeed);
			ITetrisThrowBlock.AddHeightIndex(builder, HeightIndex);
			ITetrisThrowBlock.AddPosIndex(builder, PosIndex);
			ITetrisThrowBlock.AddShapeName(builder, ShapeNameOffset);
			ITetrisThrowBlock.AddNullMask(builder, NullMask);
			ITetrisThrowBlock.AddIsDelayFall(builder, IsDelayFall);
			ITetrisThrowBlock.AddRotation(builder, Rotation);
			return ITetrisThrowBlock.EndITetrisThrowBlock(builder);
		}

		// Token: 0x06035D6C RID: 220524 RVA: 0x00754387 File Offset: 0x00752587
		public static void StartITetrisThrowBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06035D6D RID: 220525 RVA: 0x00754390 File Offset: 0x00752590
		public static void AddShapeName(FlatBufferBuilder builder, StringOffset shapeNameOffset)
		{
			builder.AddOffset(0, shapeNameOffset.Value, 0);
		}

		// Token: 0x06035D6E RID: 220526 RVA: 0x007543A0 File Offset: 0x007525A0
		public static void AddPosIndex(FlatBufferBuilder builder, int posIndex)
		{
			builder.AddInt(1, posIndex, 0);
		}

		// Token: 0x06035D6F RID: 220527 RVA: 0x007543AB File Offset: 0x007525AB
		public static void AddHeightIndex(FlatBufferBuilder builder, int heightIndex)
		{
			builder.AddInt(2, heightIndex, 0);
		}

		// Token: 0x06035D70 RID: 220528 RVA: 0x007543B6 File Offset: 0x007525B6
		public static void AddRotation(FlatBufferBuilder builder, ETetrisRotation rotation)
		{
			builder.AddByte(3, (byte)rotation, 0);
		}

		// Token: 0x06035D71 RID: 220529 RVA: 0x007543C1 File Offset: 0x007525C1
		public static void AddIsDelayFall(FlatBufferBuilder builder, bool isDelayFall)
		{
			builder.AddBool(4, isDelayFall, false);
		}

		// Token: 0x06035D72 RID: 220530 RVA: 0x007543CC File Offset: 0x007525CC
		public static void AddFallSpeed(FlatBufferBuilder builder, int fallSpeed)
		{
			builder.AddInt(5, fallSpeed, 0);
		}

		// Token: 0x06035D73 RID: 220531 RVA: 0x007543D7 File Offset: 0x007525D7
		public static void AddFallAcceleration(FlatBufferBuilder builder, int fallAcceleration)
		{
			builder.AddInt(6, fallAcceleration, 0);
		}

		// Token: 0x06035D74 RID: 220532 RVA: 0x007543E2 File Offset: 0x007525E2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06035D75 RID: 220533 RVA: 0x007543ED File Offset: 0x007525ED
		public static Offset<ITetrisThrowBlock> EndITetrisThrowBlock(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisThrowBlock>(builder.EndTable());
		}

		// Token: 0x06035D76 RID: 220534 RVA: 0x007543FC File Offset: 0x007525FC
		public ITetrisThrowBlockT UnPack()
		{
			ITetrisThrowBlockT tetrisThrowBlockT = new ITetrisThrowBlockT();
			this.UnPackTo(tetrisThrowBlockT);
			return tetrisThrowBlockT;
		}

		// Token: 0x06035D77 RID: 220535 RVA: 0x00754418 File Offset: 0x00752618
		public void UnPackTo(ITetrisThrowBlockT _o)
		{
			_o.ShapeName = this.ShapeName;
			_o.PosIndex = this.PosIndex;
			_o.HeightIndex = this.HeightIndex;
			_o.Rotation = this.Rotation;
			_o.IsDelayFall = this.IsDelayFall;
			_o.FallSpeed = this.FallSpeed;
			_o.FallAcceleration = this.FallAcceleration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035D78 RID: 220536 RVA: 0x00754488 File Offset: 0x00752688
		public static Offset<ITetrisThrowBlock> Pack(FlatBufferBuilder builder, ITetrisThrowBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisThrowBlock>);
			}
			StringOffset shapeNameOffset = (_o.ShapeName == null) ? default(StringOffset) : builder.CreateString(_o.ShapeName);
			return ITetrisThrowBlock.CreateITetrisThrowBlock(builder, shapeNameOffset, _o.PosIndex, _o.HeightIndex, _o.Rotation, _o.IsDelayFall, _o.FallSpeed, _o.FallAcceleration, _o.NullMask);
		}

		// Token: 0x0401220F RID: 74255
		private Table __p;
	}
}
