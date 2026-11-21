using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B0 RID: 26800
	public struct IBvbDeploy : IFlatbufferObject
	{
		// Token: 0x1700C4F4 RID: 50420
		// (get) Token: 0x0602DD27 RID: 187687 RVA: 0x006431B0 File Offset: 0x006413B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD28 RID: 187688 RVA: 0x006431BD File Offset: 0x006413BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD29 RID: 187689 RVA: 0x006431C4 File Offset: 0x006413C4
		public static IBvbDeploy GetRootAsIBvbDeploy(ByteBuffer _bb)
		{
			return IBvbDeploy.GetRootAsIBvbDeploy(_bb, default(IBvbDeploy));
		}

		// Token: 0x0602DD2A RID: 187690 RVA: 0x006431E0 File Offset: 0x006413E0
		public static IBvbDeploy GetRootAsIBvbDeploy(ByteBuffer _bb, IBvbDeploy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD2B RID: 187691 RVA: 0x006431FD File Offset: 0x006413FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD2C RID: 187692 RVA: 0x0064320C File Offset: 0x0064140C
		public IBvbDeploy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4F5 RID: 50421
		// (get) Token: 0x0602DD2D RID: 187693 RVA: 0x0064321C File Offset: 0x0064141C
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4F6 RID: 50422
		// (get) Token: 0x0602DD2E RID: 187694 RVA: 0x00643258 File Offset: 0x00641458
		public int HandCardIndex
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

		// Token: 0x1700C4F7 RID: 50423
		// (get) Token: 0x0602DD2F RID: 187695 RVA: 0x00643294 File Offset: 0x00641494
		public int BoardPosIndex
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

		// Token: 0x0602DD30 RID: 187696 RVA: 0x006432D0 File Offset: 0x006414D0
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C4F8 RID: 50424
		// (get) Token: 0x0602DD31 RID: 187697 RVA: 0x00643310 File Offset: 0x00641510
		public int BoardPosIndexListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602DD32 RID: 187698 RVA: 0x0064333C File Offset: 0x0064153C
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602DD33 RID: 187699 RVA: 0x0064334C File Offset: 0x0064154C
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700C4F9 RID: 50425
		// (get) Token: 0x0602DD34 RID: 187700 RVA: 0x0064335C File Offset: 0x0064155C
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

		// Token: 0x0602DD35 RID: 187701 RVA: 0x00643399 File Offset: 0x00641599
		public static Offset<IBvbDeploy> CreateIBvbDeploy(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, int BoardPosIndex = 0, VectorOffset BoardPosIndexListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBvbDeploy.AddBoardPosIndexList(builder, BoardPosIndexListOffset);
			IBvbDeploy.AddBoardPosIndex(builder, BoardPosIndex);
			IBvbDeploy.AddHandCardIndex(builder, HandCardIndex);
			IBvbDeploy.AddNullMask(builder, NullMask);
			IBvbDeploy.AddType(builder, Type);
			return IBvbDeploy.EndIBvbDeploy(builder);
		}

		// Token: 0x0602DD36 RID: 187702 RVA: 0x006433CD File Offset: 0x006415CD
		public static void StartIBvbDeploy(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DD37 RID: 187703 RVA: 0x006433D6 File Offset: 0x006415D6
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD38 RID: 187704 RVA: 0x006433E1 File Offset: 0x006415E1
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602DD39 RID: 187705 RVA: 0x006433EC File Offset: 0x006415EC
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(2, boardPosIndex, 0);
		}

		// Token: 0x0602DD3A RID: 187706 RVA: 0x006433F7 File Offset: 0x006415F7
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(3, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602DD3B RID: 187707 RVA: 0x00643408 File Offset: 0x00641608
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DD3C RID: 187708 RVA: 0x0064343F File Offset: 0x0064163F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DD3D RID: 187709 RVA: 0x00643459 File Offset: 0x00641659
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DD3E RID: 187710 RVA: 0x00643477 File Offset: 0x00641677
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DD3F RID: 187711 RVA: 0x00643490 File Offset: 0x00641690
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DD40 RID: 187712 RVA: 0x0064349B File Offset: 0x0064169B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DD41 RID: 187713 RVA: 0x006434A6 File Offset: 0x006416A6
		public static Offset<IBvbDeploy> EndIBvbDeploy(FlatBufferBuilder builder)
		{
			return new Offset<IBvbDeploy>(builder.EndTable());
		}

		// Token: 0x0602DD42 RID: 187714 RVA: 0x006434B4 File Offset: 0x006416B4
		public IBvbDeployT UnPack()
		{
			IBvbDeployT bvbDeployT = new IBvbDeployT();
			this.UnPackTo(bvbDeployT);
			return bvbDeployT;
		}

		// Token: 0x0602DD43 RID: 187715 RVA: 0x006434D0 File Offset: 0x006416D0
		public void UnPackTo(IBvbDeployT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.BoardPosIndex = this.BoardPosIndex;
			_o.BoardPosIndexList = new List<int>();
			for (int i = 0; i < this.BoardPosIndexListLength; i++)
			{
				_o.BoardPosIndexList.Add(this.BoardPosIndexList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DD44 RID: 187716 RVA: 0x0064353C File Offset: 0x0064173C
		public static Offset<IBvbDeploy> Pack(FlatBufferBuilder builder, IBvbDeployT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbDeploy>);
			}
			VectorOffset boardPosIndexListOffset = default(VectorOffset);
			if (_o.BoardPosIndexList != null)
			{
				int[] data = _o.BoardPosIndexList.ToArray();
				boardPosIndexListOffset = IBvbDeploy.CreateBoardPosIndexListVector(builder, data);
			}
			return IBvbDeploy.CreateIBvbDeploy(builder, _o.Type, _o.HandCardIndex, _o.BoardPosIndex, boardPosIndexListOffset, _o.NullMask);
		}

		// Token: 0x0401159C RID: 71068
		private Table __p;
	}
}
