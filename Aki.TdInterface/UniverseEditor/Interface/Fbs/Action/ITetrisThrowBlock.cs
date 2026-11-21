using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB1 RID: 31665
	public struct ITetrisThrowBlock : IFlatbufferObject
	{
		// Token: 0x1700ED2D RID: 60717
		// (get) Token: 0x060390F6 RID: 233718 RVA: 0x007B65F6 File Offset: 0x007B47F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060390F7 RID: 233719 RVA: 0x007B6603 File Offset: 0x007B4803
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060390F8 RID: 233720 RVA: 0x007B660C File Offset: 0x007B480C
		public static ITetrisThrowBlock GetRootAsITetrisThrowBlock(ByteBuffer _bb)
		{
			return ITetrisThrowBlock.GetRootAsITetrisThrowBlock(_bb, default(ITetrisThrowBlock));
		}

		// Token: 0x060390F9 RID: 233721 RVA: 0x007B6628 File Offset: 0x007B4828
		public static ITetrisThrowBlock GetRootAsITetrisThrowBlock(ByteBuffer _bb, ITetrisThrowBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060390FA RID: 233722 RVA: 0x007B6645 File Offset: 0x007B4845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060390FB RID: 233723 RVA: 0x007B6654 File Offset: 0x007B4854
		public ITetrisThrowBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED2E RID: 60718
		// (get) Token: 0x060390FC RID: 233724 RVA: 0x007B6664 File Offset: 0x007B4864
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

		// Token: 0x060390FD RID: 233725 RVA: 0x007B669B File Offset: 0x007B489B
		public Span<byte> GetShapeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060390FE RID: 233726 RVA: 0x007B66AA File Offset: 0x007B48AA
		public byte[] GetShapeNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ED2F RID: 60719
		// (get) Token: 0x060390FF RID: 233727 RVA: 0x007B66B8 File Offset: 0x007B48B8
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

		// Token: 0x1700ED30 RID: 60720
		// (get) Token: 0x06039100 RID: 233728 RVA: 0x007B66F4 File Offset: 0x007B48F4
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

		// Token: 0x1700ED31 RID: 60721
		// (get) Token: 0x06039101 RID: 233729 RVA: 0x007B6730 File Offset: 0x007B4930
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

		// Token: 0x1700ED32 RID: 60722
		// (get) Token: 0x06039102 RID: 233730 RVA: 0x007B6770 File Offset: 0x007B4970
		public bool IsDelayFall
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED33 RID: 60723
		// (get) Token: 0x06039103 RID: 233731 RVA: 0x007B67B0 File Offset: 0x007B49B0
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

		// Token: 0x1700ED34 RID: 60724
		// (get) Token: 0x06039104 RID: 233732 RVA: 0x007B67F0 File Offset: 0x007B49F0
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

		// Token: 0x1700ED35 RID: 60725
		// (get) Token: 0x06039105 RID: 233733 RVA: 0x007B6830 File Offset: 0x007B4A30
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

		// Token: 0x06039106 RID: 233734 RVA: 0x007B6870 File Offset: 0x007B4A70
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

		// Token: 0x06039107 RID: 233735 RVA: 0x007B68C7 File Offset: 0x007B4AC7
		public static void StartITetrisThrowBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06039108 RID: 233736 RVA: 0x007B68D0 File Offset: 0x007B4AD0
		public static void AddShapeName(FlatBufferBuilder builder, StringOffset shapeNameOffset)
		{
			builder.AddOffset(0, shapeNameOffset.Value, 0);
		}

		// Token: 0x06039109 RID: 233737 RVA: 0x007B68E0 File Offset: 0x007B4AE0
		public static void AddPosIndex(FlatBufferBuilder builder, int posIndex)
		{
			builder.AddInt(1, posIndex, 0);
		}

		// Token: 0x0603910A RID: 233738 RVA: 0x007B68EB File Offset: 0x007B4AEB
		public static void AddHeightIndex(FlatBufferBuilder builder, int heightIndex)
		{
			builder.AddInt(2, heightIndex, 0);
		}

		// Token: 0x0603910B RID: 233739 RVA: 0x007B68F6 File Offset: 0x007B4AF6
		public static void AddRotation(FlatBufferBuilder builder, ETetrisRotation rotation)
		{
			builder.AddByte(3, (byte)rotation, 0);
		}

		// Token: 0x0603910C RID: 233740 RVA: 0x007B6901 File Offset: 0x007B4B01
		public static void AddIsDelayFall(FlatBufferBuilder builder, bool isDelayFall)
		{
			builder.AddBool(4, isDelayFall, false);
		}

		// Token: 0x0603910D RID: 233741 RVA: 0x007B690C File Offset: 0x007B4B0C
		public static void AddFallSpeed(FlatBufferBuilder builder, int fallSpeed)
		{
			builder.AddInt(5, fallSpeed, 0);
		}

		// Token: 0x0603910E RID: 233742 RVA: 0x007B6917 File Offset: 0x007B4B17
		public static void AddFallAcceleration(FlatBufferBuilder builder, int fallAcceleration)
		{
			builder.AddInt(6, fallAcceleration, 0);
		}

		// Token: 0x0603910F RID: 233743 RVA: 0x007B6922 File Offset: 0x007B4B22
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06039110 RID: 233744 RVA: 0x007B692D File Offset: 0x007B4B2D
		public static Offset<ITetrisThrowBlock> EndITetrisThrowBlock(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisThrowBlock>(builder.EndTable());
		}

		// Token: 0x06039111 RID: 233745 RVA: 0x007B693C File Offset: 0x007B4B3C
		public ITetrisThrowBlockT UnPack()
		{
			ITetrisThrowBlockT tetrisThrowBlockT = new ITetrisThrowBlockT();
			this.UnPackTo(tetrisThrowBlockT);
			return tetrisThrowBlockT;
		}

		// Token: 0x06039112 RID: 233746 RVA: 0x007B6958 File Offset: 0x007B4B58
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

		// Token: 0x06039113 RID: 233747 RVA: 0x007B69C8 File Offset: 0x007B4BC8
		public static Offset<ITetrisThrowBlock> Pack(FlatBufferBuilder builder, ITetrisThrowBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisThrowBlock>);
			}
			StringOffset shapeNameOffset = (_o.ShapeName == null) ? default(StringOffset) : builder.CreateString(_o.ShapeName);
			return ITetrisThrowBlock.CreateITetrisThrowBlock(builder, shapeNameOffset, _o.PosIndex, _o.HeightIndex, _o.Rotation, _o.IsDelayFall, _o.FallSpeed, _o.FallAcceleration, _o.NullMask);
		}

		// Token: 0x04013228 RID: 78376
		private Table __p;
	}
}
