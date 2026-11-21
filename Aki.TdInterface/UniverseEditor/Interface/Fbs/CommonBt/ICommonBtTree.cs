using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006518 RID: 25880
	public struct ICommonBtTree : IFlatbufferObject
	{
		// Token: 0x1700BF04 RID: 48900
		// (get) Token: 0x0602C1E0 RID: 180704 RVA: 0x006027F5 File Offset: 0x006009F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1E1 RID: 180705 RVA: 0x00602802 File Offset: 0x00600A02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1E2 RID: 180706 RVA: 0x0060280C File Offset: 0x00600A0C
		public static ICommonBtTree GetRootAsICommonBtTree(ByteBuffer _bb)
		{
			return ICommonBtTree.GetRootAsICommonBtTree(_bb, default(ICommonBtTree));
		}

		// Token: 0x0602C1E3 RID: 180707 RVA: 0x00602828 File Offset: 0x00600A28
		public static ICommonBtTree GetRootAsICommonBtTree(ByteBuffer _bb, ICommonBtTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1E4 RID: 180708 RVA: 0x00602845 File Offset: 0x00600A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1E5 RID: 180709 RVA: 0x00602854 File Offset: 0x00600A54
		public ICommonBtTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF05 RID: 48901
		// (get) Token: 0x0602C1E6 RID: 180710 RVA: 0x00602864 File Offset: 0x00600A64
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

		// Token: 0x0602C1E7 RID: 180711 RVA: 0x006028C4 File Offset: 0x00600AC4
		public int _SelectedNodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BF06 RID: 48902
		// (get) Token: 0x0602C1E8 RID: 180712 RVA: 0x00602904 File Offset: 0x00600B04
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

		// Token: 0x0602C1E9 RID: 180713 RVA: 0x0060292F File Offset: 0x00600B2F
		public Span<int> Get_SelectedNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602C1EA RID: 180714 RVA: 0x0060293E File Offset: 0x00600B3E
		public int[] Get_SelectedNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700BF07 RID: 48903
		// (get) Token: 0x0602C1EB RID: 180715 RVA: 0x0060294C File Offset: 0x00600B4C
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

		// Token: 0x0602C1EC RID: 180716 RVA: 0x00602988 File Offset: 0x00600B88
		public static Offset<ICommonBtTree> CreateICommonBtTree(FlatBufferBuilder builder, Offset<ICommonBtStart> RootOffset = default(Offset<ICommonBtStart>), VectorOffset _selectedNodeIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ICommonBtTree.Add_SelectedNodeIds(builder, _selectedNodeIdsOffset);
			ICommonBtTree.AddRoot(builder, RootOffset);
			ICommonBtTree.AddNullMask(builder, NullMask);
			return ICommonBtTree.EndICommonBtTree(builder);
		}

		// Token: 0x0602C1ED RID: 180717 RVA: 0x006029AC File Offset: 0x00600BAC
		public static void StartICommonBtTree(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C1EE RID: 180718 RVA: 0x006029B5 File Offset: 0x00600BB5
		public static void AddRoot(FlatBufferBuilder builder, Offset<ICommonBtStart> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x0602C1EF RID: 180719 RVA: 0x006029C5 File Offset: 0x00600BC5
		public static void Add_SelectedNodeIds(FlatBufferBuilder builder, VectorOffset _SelectedNodeIdsOffset)
		{
			builder.AddOffset(1, _SelectedNodeIdsOffset.Value, 0);
		}

		// Token: 0x0602C1F0 RID: 180720 RVA: 0x006029D8 File Offset: 0x00600BD8
		public static VectorOffset Create_SelectedNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C1F1 RID: 180721 RVA: 0x00602A0F File Offset: 0x00600C0F
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1F2 RID: 180722 RVA: 0x00602A29 File Offset: 0x00600C29
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C1F3 RID: 180723 RVA: 0x00602A47 File Offset: 0x00600C47
		public static VectorOffset Create_SelectedNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C1F4 RID: 180724 RVA: 0x00602A60 File Offset: 0x00600C60
		public static void Start_SelectedNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C1F5 RID: 180725 RVA: 0x00602A6B File Offset: 0x00600C6B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C1F6 RID: 180726 RVA: 0x00602A76 File Offset: 0x00600C76
		public static Offset<ICommonBtTree> EndICommonBtTree(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTree>(builder.EndTable());
		}

		// Token: 0x0602C1F7 RID: 180727 RVA: 0x00602A84 File Offset: 0x00600C84
		public ICommonBtTreeT UnPack()
		{
			ICommonBtTreeT commonBtTreeT = new ICommonBtTreeT();
			this.UnPackTo(commonBtTreeT);
			return commonBtTreeT;
		}

		// Token: 0x0602C1F8 RID: 180728 RVA: 0x00602AA0 File Offset: 0x00600CA0
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

		// Token: 0x0602C1F9 RID: 180729 RVA: 0x00602B18 File Offset: 0x00600D18
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

		// Token: 0x040106D2 RID: 67282
		private Table __p;
	}
}
