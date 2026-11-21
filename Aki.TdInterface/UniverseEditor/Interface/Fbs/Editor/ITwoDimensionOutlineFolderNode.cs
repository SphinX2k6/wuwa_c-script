using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D18 RID: 19736
	public struct ITwoDimensionOutlineFolderNode : IFlatbufferObject
	{
		// Token: 0x17008D3A RID: 36154
		// (get) Token: 0x0601E8CD RID: 125133 RVA: 0x00446C5C File Offset: 0x00444E5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8CE RID: 125134 RVA: 0x00446C69 File Offset: 0x00444E69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8CF RID: 125135 RVA: 0x00446C70 File Offset: 0x00444E70
		public static ITwoDimensionOutlineFolderNode GetRootAsITwoDimensionOutlineFolderNode(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineFolderNode.GetRootAsITwoDimensionOutlineFolderNode(_bb, default(ITwoDimensionOutlineFolderNode));
		}

		// Token: 0x0601E8D0 RID: 125136 RVA: 0x00446C8C File Offset: 0x00444E8C
		public static ITwoDimensionOutlineFolderNode GetRootAsITwoDimensionOutlineFolderNode(ByteBuffer _bb, ITwoDimensionOutlineFolderNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8D1 RID: 125137 RVA: 0x00446CA9 File Offset: 0x00444EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8D2 RID: 125138 RVA: 0x00446CB8 File Offset: 0x00444EB8
		public ITwoDimensionOutlineFolderNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D3B RID: 36155
		// (get) Token: 0x0601E8D3 RID: 125139 RVA: 0x00446CC8 File Offset: 0x00444EC8
		public ETwoDimensionOutlineNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETwoDimensionOutlineNodeType.Folder;
				}
				return (ETwoDimensionOutlineNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D3C RID: 36156
		// (get) Token: 0x0601E8D4 RID: 125140 RVA: 0x00446D04 File Offset: 0x00444F04
		public string Id
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

		// Token: 0x0601E8D5 RID: 125141 RVA: 0x00446D3B File Offset: 0x00444F3B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E8D6 RID: 125142 RVA: 0x00446D4A File Offset: 0x00444F4A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D3D RID: 36157
		// (get) Token: 0x0601E8D7 RID: 125143 RVA: 0x00446D58 File Offset: 0x00444F58
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E8D8 RID: 125144 RVA: 0x00446D8F File Offset: 0x00444F8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E8D9 RID: 125145 RVA: 0x00446D9E File Offset: 0x00444F9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601E8DA RID: 125146 RVA: 0x00446DAC File Offset: 0x00444FAC
		public TTwoDimensionOutlineNode ChildrenType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTwoDimensionOutlineNode.NONE;
			}
			return (TTwoDimensionOutlineNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008D3E RID: 36158
		// (get) Token: 0x0601E8DB RID: 125147 RVA: 0x00446DEC File Offset: 0x00444FEC
		public int ChildrenTypeLength
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

		// Token: 0x0601E8DC RID: 125148 RVA: 0x00446E18 File Offset: 0x00445018
		public Span<TTwoDimensionOutlineNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionOutlineNode>(10, 1);
		}

		// Token: 0x0601E8DD RID: 125149 RVA: 0x00446E28 File Offset: 0x00445028
		public TTwoDimensionOutlineNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTwoDimensionOutlineNode[] array = new TTwoDimensionOutlineNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTwoDimensionOutlineNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601E8DE RID: 125150 RVA: 0x00446E94 File Offset: 0x00445094
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008D3F RID: 36159
		// (get) Token: 0x0601E8DF RID: 125151 RVA: 0x00446EDC File Offset: 0x004450DC
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008D40 RID: 36160
		// (get) Token: 0x0601E8E0 RID: 125152 RVA: 0x00446F08 File Offset: 0x00445108
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008D41 RID: 36161
		// (get) Token: 0x0601E8E1 RID: 125153 RVA: 0x00446F48 File Offset: 0x00445148
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E8E2 RID: 125154 RVA: 0x00446F88 File Offset: 0x00445188
		public static Offset<ITwoDimensionOutlineFolderNode> CreateITwoDimensionOutlineFolderNode(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType Type = ETwoDimensionOutlineNodeType.Folder, StringOffset IdOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), bool _folded = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ITwoDimensionOutlineFolderNode.AddChildren(builder, ChildrenOffset);
			ITwoDimensionOutlineFolderNode.AddChildrenType(builder, Children_typeOffset);
			ITwoDimensionOutlineFolderNode.AddName(builder, NameOffset);
			ITwoDimensionOutlineFolderNode.AddId(builder, IdOffset);
			ITwoDimensionOutlineFolderNode.AddNullMask(builder, NullMask);
			ITwoDimensionOutlineFolderNode.Add_Folded(builder, _folded);
			ITwoDimensionOutlineFolderNode.AddType(builder, Type);
			return ITwoDimensionOutlineFolderNode.EndITwoDimensionOutlineFolderNode(builder);
		}

		// Token: 0x0601E8E3 RID: 125155 RVA: 0x00446FD7 File Offset: 0x004451D7
		public static void StartITwoDimensionOutlineFolderNode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601E8E4 RID: 125156 RVA: 0x00446FE0 File Offset: 0x004451E0
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E8E5 RID: 125157 RVA: 0x00446FEB File Offset: 0x004451EB
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x0601E8E6 RID: 125158 RVA: 0x00446FFB File Offset: 0x004451FB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x0601E8E7 RID: 125159 RVA: 0x0044700B File Offset: 0x0044520B
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(3, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0601E8E8 RID: 125160 RVA: 0x0044701C File Offset: 0x0044521C
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TTwoDimensionOutlineNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E8E9 RID: 125161 RVA: 0x00447053 File Offset: 0x00445253
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionOutlineNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionOutlineNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E8EA RID: 125162 RVA: 0x0044706D File Offset: 0x0044526D
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionOutlineNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionOutlineNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E8EB RID: 125163 RVA: 0x0044708B File Offset: 0x0044528B
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionOutlineNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E8EC RID: 125164 RVA: 0x004470A4 File Offset: 0x004452A4
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601E8ED RID: 125165 RVA: 0x004470AF File Offset: 0x004452AF
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(4, childrenOffset.Value, 0);
		}

		// Token: 0x0601E8EE RID: 125166 RVA: 0x004470C0 File Offset: 0x004452C0
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E8EF RID: 125167 RVA: 0x004470F7 File Offset: 0x004452F7
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E8F0 RID: 125168 RVA: 0x00447111 File Offset: 0x00445311
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E8F1 RID: 125169 RVA: 0x0044712F File Offset: 0x0044532F
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E8F2 RID: 125170 RVA: 0x00447148 File Offset: 0x00445348
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E8F3 RID: 125171 RVA: 0x00447153 File Offset: 0x00445353
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x0601E8F4 RID: 125172 RVA: 0x0044715E File Offset: 0x0044535E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601E8F5 RID: 125173 RVA: 0x00447169 File Offset: 0x00445369
		public static Offset<ITwoDimensionOutlineFolderNode> EndITwoDimensionOutlineFolderNode(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineFolderNode>(builder.EndTable());
		}

		// Token: 0x0601E8F6 RID: 125174 RVA: 0x00447178 File Offset: 0x00445378
		public ITwoDimensionOutlineFolderNodeT UnPack()
		{
			ITwoDimensionOutlineFolderNodeT twoDimensionOutlineFolderNodeT = new ITwoDimensionOutlineFolderNodeT();
			this.UnPackTo(twoDimensionOutlineFolderNodeT);
			return twoDimensionOutlineFolderNodeT;
		}

		// Token: 0x0601E8F7 RID: 125175 RVA: 0x00447194 File Offset: 0x00445394
		public void UnPackTo(ITwoDimensionOutlineFolderNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.Children = new List<TTwoDimensionOutlineNodeUnion>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				TTwoDimensionOutlineNodeUnion ttwoDimensionOutlineNodeUnion = new TTwoDimensionOutlineNodeUnion();
				ttwoDimensionOutlineNodeUnion.Type = this.ChildrenType(i);
				TTwoDimensionOutlineNode ttwoDimensionOutlineNode = this.ChildrenType(i);
				if (ttwoDimensionOutlineNode != TTwoDimensionOutlineNode.ITwoDimensionOutlineFolderNode)
				{
					if (ttwoDimensionOutlineNode == TTwoDimensionOutlineNode.ITwoDimensionOutlineItemNode)
					{
						ttwoDimensionOutlineNodeUnion.Value = ((this.Children<ITwoDimensionOutlineItemNode>(i) != null) ? this.Children<ITwoDimensionOutlineItemNode>(i).Value.UnPack() : null);
					}
				}
				else
				{
					ttwoDimensionOutlineNodeUnion.Value = ((this.Children<ITwoDimensionOutlineFolderNode>(i) != null) ? this.Children<ITwoDimensionOutlineFolderNode>(i).Value.UnPack() : null);
				}
				_o.Children.Add(ttwoDimensionOutlineNodeUnion);
			}
			_o._Folded = this._Folded;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E8F8 RID: 125176 RVA: 0x00447298 File Offset: 0x00445498
		public static Offset<ITwoDimensionOutlineFolderNode> Pack(FlatBufferBuilder builder, ITwoDimensionOutlineFolderNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionOutlineFolderNode>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TTwoDimensionOutlineNode[] array = new TTwoDimensionOutlineNode[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Children[i].Type;
				}
				children_typeOffset = ITwoDimensionOutlineFolderNode.CreateChildrenTypeVector(builder, array);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array2 = new int[_o.Children.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TTwoDimensionOutlineNodeUnion.Pack(builder, _o.Children[j]);
				}
				childrenOffset = ITwoDimensionOutlineFolderNode.CreateChildrenVector(builder, array2);
			}
			return ITwoDimensionOutlineFolderNode.CreateITwoDimensionOutlineFolderNode(builder, _o.Type, idOffset, nameOffset, children_typeOffset, childrenOffset, _o._Folded, _o.NullMask);
		}

		// Token: 0x0400D8DE RID: 55518
		private Table __p;
	}
}
