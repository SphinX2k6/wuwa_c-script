using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B3 RID: 18611
	public struct ITwoDimensionOutlineFolderNode : IFlatbufferObject
	{
		// Token: 0x170086F2 RID: 34546
		// (get) Token: 0x0601D0E0 RID: 119008 RVA: 0x0041A4C0 File Offset: 0x004186C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0E1 RID: 119009 RVA: 0x0041A4CD File Offset: 0x004186CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0E2 RID: 119010 RVA: 0x0041A4D4 File Offset: 0x004186D4
		public static ITwoDimensionOutlineFolderNode GetRootAsITwoDimensionOutlineFolderNode(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineFolderNode.GetRootAsITwoDimensionOutlineFolderNode(_bb, default(ITwoDimensionOutlineFolderNode));
		}

		// Token: 0x0601D0E3 RID: 119011 RVA: 0x0041A4F0 File Offset: 0x004186F0
		public static ITwoDimensionOutlineFolderNode GetRootAsITwoDimensionOutlineFolderNode(ByteBuffer _bb, ITwoDimensionOutlineFolderNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0E4 RID: 119012 RVA: 0x0041A50D File Offset: 0x0041870D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x0041A51C File Offset: 0x0041871C
		public ITwoDimensionOutlineFolderNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086F3 RID: 34547
		// (get) Token: 0x0601D0E6 RID: 119014 RVA: 0x0041A52C File Offset: 0x0041872C
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

		// Token: 0x170086F4 RID: 34548
		// (get) Token: 0x0601D0E7 RID: 119015 RVA: 0x0041A568 File Offset: 0x00418768
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

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x0041A59F File Offset: 0x0041879F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D0E9 RID: 119017 RVA: 0x0041A5AE File Offset: 0x004187AE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170086F5 RID: 34549
		// (get) Token: 0x0601D0EA RID: 119018 RVA: 0x0041A5BC File Offset: 0x004187BC
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

		// Token: 0x0601D0EB RID: 119019 RVA: 0x0041A5F3 File Offset: 0x004187F3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D0EC RID: 119020 RVA: 0x0041A602 File Offset: 0x00418802
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601D0ED RID: 119021 RVA: 0x0041A610 File Offset: 0x00418810
		public TTwoDimensionOutlineNode ChildrenType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TTwoDimensionOutlineNode.NONE;
			}
			return (TTwoDimensionOutlineNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170086F6 RID: 34550
		// (get) Token: 0x0601D0EE RID: 119022 RVA: 0x0041A650 File Offset: 0x00418850
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

		// Token: 0x0601D0EF RID: 119023 RVA: 0x0041A67C File Offset: 0x0041887C
		public Span<TTwoDimensionOutlineNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TTwoDimensionOutlineNode>(10, 1);
		}

		// Token: 0x0601D0F0 RID: 119024 RVA: 0x0041A68C File Offset: 0x0041888C
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

		// Token: 0x0601D0F1 RID: 119025 RVA: 0x0041A6F8 File Offset: 0x004188F8
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170086F7 RID: 34551
		// (get) Token: 0x0601D0F2 RID: 119026 RVA: 0x0041A740 File Offset: 0x00418940
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

		// Token: 0x170086F8 RID: 34552
		// (get) Token: 0x0601D0F3 RID: 119027 RVA: 0x0041A76C File Offset: 0x0041896C
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170086F9 RID: 34553
		// (get) Token: 0x0601D0F4 RID: 119028 RVA: 0x0041A7AC File Offset: 0x004189AC
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

		// Token: 0x0601D0F5 RID: 119029 RVA: 0x0041A7EC File Offset: 0x004189EC
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

		// Token: 0x0601D0F6 RID: 119030 RVA: 0x0041A83B File Offset: 0x00418A3B
		public static void StartITwoDimensionOutlineFolderNode(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601D0F7 RID: 119031 RVA: 0x0041A844 File Offset: 0x00418A44
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0F8 RID: 119032 RVA: 0x0041A84F File Offset: 0x00418A4F
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x0601D0F9 RID: 119033 RVA: 0x0041A85F File Offset: 0x00418A5F
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x0041A86F File Offset: 0x00418A6F
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(3, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x0041A880 File Offset: 0x00418A80
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TTwoDimensionOutlineNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D0FC RID: 119036 RVA: 0x0041A8B7 File Offset: 0x00418AB7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TTwoDimensionOutlineNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTwoDimensionOutlineNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0FD RID: 119037 RVA: 0x0041A8D1 File Offset: 0x00418AD1
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTwoDimensionOutlineNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTwoDimensionOutlineNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D0FE RID: 119038 RVA: 0x0041A8EF File Offset: 0x00418AEF
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTwoDimensionOutlineNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x0041A908 File Offset: 0x00418B08
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601D100 RID: 119040 RVA: 0x0041A913 File Offset: 0x00418B13
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(4, childrenOffset.Value, 0);
		}

		// Token: 0x0601D101 RID: 119041 RVA: 0x0041A924 File Offset: 0x00418B24
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D102 RID: 119042 RVA: 0x0041A95B File Offset: 0x00418B5B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D103 RID: 119043 RVA: 0x0041A975 File Offset: 0x00418B75
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x0041A993 File Offset: 0x00418B93
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x0041A9AC File Offset: 0x00418BAC
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x0041A9B7 File Offset: 0x00418BB7
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x0601D107 RID: 119047 RVA: 0x0041A9C2 File Offset: 0x00418BC2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601D108 RID: 119048 RVA: 0x0041A9CD File Offset: 0x00418BCD
		public static Offset<ITwoDimensionOutlineFolderNode> EndITwoDimensionOutlineFolderNode(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineFolderNode>(builder.EndTable());
		}

		// Token: 0x0601D109 RID: 119049 RVA: 0x0041A9DC File Offset: 0x00418BDC
		public ITwoDimensionOutlineFolderNodeT UnPack()
		{
			ITwoDimensionOutlineFolderNodeT twoDimensionOutlineFolderNodeT = new ITwoDimensionOutlineFolderNodeT();
			this.UnPackTo(twoDimensionOutlineFolderNodeT);
			return twoDimensionOutlineFolderNodeT;
		}

		// Token: 0x0601D10A RID: 119050 RVA: 0x0041A9F8 File Offset: 0x00418BF8
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

		// Token: 0x0601D10B RID: 119051 RVA: 0x0041AAFC File Offset: 0x00418CFC
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

		// Token: 0x0400CEA5 RID: 52901
		private Table __p;
	}
}
