using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED5 RID: 24277
	public struct ICommonBtTree : IFlatbufferObject
	{
		// Token: 0x1700B599 RID: 46489
		// (get) Token: 0x06029B2C RID: 170796 RVA: 0x005B9311 File Offset: 0x005B7511
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B2D RID: 170797 RVA: 0x005B931E File Offset: 0x005B751E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B2E RID: 170798 RVA: 0x005B9328 File Offset: 0x005B7528
		public static ICommonBtTree GetRootAsICommonBtTree(ByteBuffer _bb)
		{
			return ICommonBtTree.GetRootAsICommonBtTree(_bb, default(ICommonBtTree));
		}

		// Token: 0x06029B2F RID: 170799 RVA: 0x005B9344 File Offset: 0x005B7544
		public static ICommonBtTree GetRootAsICommonBtTree(ByteBuffer _bb, ICommonBtTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B30 RID: 170800 RVA: 0x005B9361 File Offset: 0x005B7561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B31 RID: 170801 RVA: 0x005B9370 File Offset: 0x005B7570
		public ICommonBtTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B59A RID: 46490
		// (get) Token: 0x06029B32 RID: 170802 RVA: 0x005B9380 File Offset: 0x005B7580
		public ICommonBtStart? Root
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtStart?(default(ICommonBtStart).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029B33 RID: 170803 RVA: 0x005B93E0 File Offset: 0x005B75E0
		public int _SelectedNodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B59B RID: 46491
		// (get) Token: 0x06029B34 RID: 170804 RVA: 0x005B9420 File Offset: 0x005B7620
		public int _SelectedNodeIdsLength
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

		// Token: 0x06029B35 RID: 170805 RVA: 0x005B944B File Offset: 0x005B764B
		public Span<int> Get_SelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06029B36 RID: 170806 RVA: 0x005B945A File Offset: 0x005B765A
		public int[] Get_SelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700B59C RID: 46492
		// (get) Token: 0x06029B37 RID: 170807 RVA: 0x005B9468 File Offset: 0x005B7668
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B38 RID: 170808 RVA: 0x005B94A4 File Offset: 0x005B76A4
		public static Offset<ICommonBtTree> CreateICommonBtTree(FlatBufferBuilder builder, Offset<ICommonBtStart> RootOffset = default(Offset<ICommonBtStart>), VectorOffset _selectedNodeIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICommonBtTree.Add_SelectedNodeIds(builder, _selectedNodeIdsOffset);
			ICommonBtTree.AddRoot(builder, RootOffset);
			ICommonBtTree.AddNullMask(builder, NullMask);
			return ICommonBtTree.EndICommonBtTree(builder);
		}

		// Token: 0x06029B39 RID: 170809 RVA: 0x005B94C8 File Offset: 0x005B76C8
		public static void StartICommonBtTree(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029B3A RID: 170810 RVA: 0x005B94D1 File Offset: 0x005B76D1
		public static void AddRoot(FlatBufferBuilder builder, Offset<ICommonBtStart> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x06029B3B RID: 170811 RVA: 0x005B94E1 File Offset: 0x005B76E1
		public static void Add_SelectedNodeIds(FlatBufferBuilder builder, VectorOffset _SelectedNodeIdsOffset)
		{
			builder.AddOffset(1, _SelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x06029B3C RID: 170812 RVA: 0x005B94F4 File Offset: 0x005B76F4
		public static VectorOffset Create_SelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B3D RID: 170813 RVA: 0x005B952B File Offset: 0x005B772B
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B3E RID: 170814 RVA: 0x005B9545 File Offset: 0x005B7745
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B3F RID: 170815 RVA: 0x005B9563 File Offset: 0x005B7763
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B40 RID: 170816 RVA: 0x005B957C File Offset: 0x005B777C
		public static void Start_SelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B41 RID: 170817 RVA: 0x005B9587 File Offset: 0x005B7787
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06029B42 RID: 170818 RVA: 0x005B9592 File Offset: 0x005B7792
		public static Offset<ICommonBtTree> EndICommonBtTree(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTree>(builder.EndTable());
		}

		// Token: 0x06029B43 RID: 170819 RVA: 0x005B95A0 File Offset: 0x005B77A0
		public ICommonBtTreeT UnPack()
		{
			ICommonBtTreeT commonBtTreeT = new ICommonBtTreeT();
			this.UnPackTo(commonBtTreeT);
			return commonBtTreeT;
		}

		// Token: 0x06029B44 RID: 170820 RVA: 0x005B95BC File Offset: 0x005B77BC
		public void UnPackTo(ICommonBtTreeT _o)
		{
			_o.Root = ((this.Root != null) ? this.Root.Value.UnPack() : null);
			_o._SelectedNodeIds = new List<int>();
			for (int i = 0; i < this._SelectedNodeIdsLength; i++)
			{
				_o._SelectedNodeIds.Add(this._SelectedNodeIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029B45 RID: 170821 RVA: 0x005B9634 File Offset: 0x005B7834
		public static Offset<ICommonBtTree> Pack(FlatBufferBuilder builder, ICommonBtTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtTree>);
			}
			Offset<ICommonBtStart> rootOffset = (_o.Root == null) ? default(Offset<ICommonBtStart>) : ICommonBtStart.Pack(builder, _o.Root);
			VectorOffset selectedNodeIdsOffset = default(VectorOffset);
			if (_o._SelectedNodeIds != null)
			{
				int[] data = _o._SelectedNodeIds.ToArray();
				selectedNodeIdsOffset = ICommonBtTree.Create_SelectedNodeIdsVector(builder, data);
			}
			return ICommonBtTree.CreateICommonBtTree(builder, rootOffset, selectedNodeIdsOffset, _o.NullMask);
		}

		// Token: 0x0400F96F RID: 63855
		private Table __p;
	}
}
