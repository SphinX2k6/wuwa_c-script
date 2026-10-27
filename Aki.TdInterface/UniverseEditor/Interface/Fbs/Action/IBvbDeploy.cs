using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200623F RID: 25151
	public struct IBvbDeploy : IFlatbufferObject
	{
		// Token: 0x1700BB6C RID: 47980
		// (get) Token: 0x0602B5C6 RID: 177606 RVA: 0x005F83A8 File Offset: 0x005F65A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5C7 RID: 177607 RVA: 0x005F83B5 File Offset: 0x005F65B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5C8 RID: 177608 RVA: 0x005F83BC File Offset: 0x005F65BC
		public static IBvbDeploy GetRootAsIBvbDeploy(ByteBuffer _bb)
		{
			return IBvbDeploy.GetRootAsIBvbDeploy(_bb, default(IBvbDeploy));
		}

		// Token: 0x0602B5C9 RID: 177609 RVA: 0x005F83D8 File Offset: 0x005F65D8
		public static IBvbDeploy GetRootAsIBvbDeploy(ByteBuffer _bb, IBvbDeploy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5CA RID: 177610 RVA: 0x005F83F5 File Offset: 0x005F65F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5CB RID: 177611 RVA: 0x005F8404 File Offset: 0x005F6604
		public IBvbDeploy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB6D RID: 47981
		// (get) Token: 0x0602B5CC RID: 177612 RVA: 0x005F8414 File Offset: 0x005F6614
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

		// Token: 0x1700BB6E RID: 47982
		// (get) Token: 0x0602B5CD RID: 177613 RVA: 0x005F8450 File Offset: 0x005F6650
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

		// Token: 0x1700BB6F RID: 47983
		// (get) Token: 0x0602B5CE RID: 177614 RVA: 0x005F848C File Offset: 0x005F668C
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

		// Token: 0x0602B5CF RID: 177615 RVA: 0x005F84C8 File Offset: 0x005F66C8
		public int BoardPosIndexList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BB70 RID: 47984
		// (get) Token: 0x0602B5D0 RID: 177616 RVA: 0x005F8508 File Offset: 0x005F6708
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

		// Token: 0x0602B5D1 RID: 177617 RVA: 0x005F8534 File Offset: 0x005F6734
		public Span<int> GetBoardPosIndexListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602B5D2 RID: 177618 RVA: 0x005F8544 File Offset: 0x005F6744
		public int[] GetBoardPosIndexListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700BB71 RID: 47985
		// (get) Token: 0x0602B5D3 RID: 177619 RVA: 0x005F8554 File Offset: 0x005F6754
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

		// Token: 0x0602B5D4 RID: 177620 RVA: 0x005F8591 File Offset: 0x005F6791
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

		// Token: 0x0602B5D5 RID: 177621 RVA: 0x005F85C5 File Offset: 0x005F67C5
		public static void StartIBvbDeploy(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B5D6 RID: 177622 RVA: 0x005F85CE File Offset: 0x005F67CE
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5D7 RID: 177623 RVA: 0x005F85D9 File Offset: 0x005F67D9
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602B5D8 RID: 177624 RVA: 0x005F85E4 File Offset: 0x005F67E4
		public static void AddBoardPosIndex(FlatBufferBuilder builder, int boardPosIndex)
		{
			builder.AddInt(2, boardPosIndex, 0);
		}

		// Token: 0x0602B5D9 RID: 177625 RVA: 0x005F85EF File Offset: 0x005F67EF
		public static void AddBoardPosIndexList(FlatBufferBuilder builder, VectorOffset boardPosIndexListOffset)
		{
			builder.AddOffset(3, boardPosIndexListOffset.Value, 0);
		}

		// Token: 0x0602B5DA RID: 177626 RVA: 0x005F8600 File Offset: 0x005F6800
		public static VectorOffset CreateBoardPosIndexListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B5DB RID: 177627 RVA: 0x005F8637 File Offset: 0x005F6837
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B5DC RID: 177628 RVA: 0x005F8651 File Offset: 0x005F6851
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B5DD RID: 177629 RVA: 0x005F866F File Offset: 0x005F686F
		public static VectorOffset CreateBoardPosIndexListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B5DE RID: 177630 RVA: 0x005F8688 File Offset: 0x005F6888
		public static void StartBoardPosIndexListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B5DF RID: 177631 RVA: 0x005F8693 File Offset: 0x005F6893
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602B5E0 RID: 177632 RVA: 0x005F869E File Offset: 0x005F689E
		public static Offset<IBvbDeploy> EndIBvbDeploy(FlatBufferBuilder builder)
		{
			return new Offset<IBvbDeploy>(builder.EndTable());
		}

		// Token: 0x0602B5E1 RID: 177633 RVA: 0x005F86AC File Offset: 0x005F68AC
		public IBvbDeployT UnPack()
		{
			IBvbDeployT bvbDeployT = new IBvbDeployT();
			this.UnPackTo(bvbDeployT);
			return bvbDeployT;
		}

		// Token: 0x0602B5E2 RID: 177634 RVA: 0x005F86C8 File Offset: 0x005F68C8
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

		// Token: 0x0602B5E3 RID: 177635 RVA: 0x005F8734 File Offset: 0x005F6934
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

		// Token: 0x04010787 RID: 67463
		private Table __p;
	}
}
