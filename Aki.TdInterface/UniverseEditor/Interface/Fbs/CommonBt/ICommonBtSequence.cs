using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200650C RID: 25868
	public struct ICommonBtSequence : IFlatbufferObject
	{
		// Token: 0x1700BED0 RID: 48848
		// (get) Token: 0x0602C103 RID: 180483 RVA: 0x0060023C File Offset: 0x005FE43C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C104 RID: 180484 RVA: 0x00600249 File Offset: 0x005FE449
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C105 RID: 180485 RVA: 0x00600250 File Offset: 0x005FE450
		public static ICommonBtSequence GetRootAsICommonBtSequence(ByteBuffer _bb)
		{
			return ICommonBtSequence.GetRootAsICommonBtSequence(_bb, default(ICommonBtSequence));
		}

		// Token: 0x0602C106 RID: 180486 RVA: 0x0060026C File Offset: 0x005FE46C
		public static ICommonBtSequence GetRootAsICommonBtSequence(ByteBuffer _bb, ICommonBtSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C107 RID: 180487 RVA: 0x00600289 File Offset: 0x005FE489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C108 RID: 180488 RVA: 0x00600298 File Offset: 0x005FE498
		public ICommonBtSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BED1 RID: 48849
		// (get) Token: 0x0602C109 RID: 180489 RVA: 0x006002A8 File Offset: 0x005FE4A8
		public ECommonBtNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtNodeType.Start;
				}
				return (ECommonBtNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BED2 RID: 48850
		// (get) Token: 0x0602C10A RID: 180490 RVA: 0x006002E4 File Offset: 0x005FE4E4
		public int Id
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

		// Token: 0x1700BED3 RID: 48851
		// (get) Token: 0x0602C10B RID: 180491 RVA: 0x00600320 File Offset: 0x005FE520
		public string Desc
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

		// Token: 0x0602C10C RID: 180492 RVA: 0x00600357 File Offset: 0x005FE557
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C10D RID: 180493 RVA: 0x00600366 File Offset: 0x005FE566
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C10E RID: 180494 RVA: 0x00600374 File Offset: 0x005FE574
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BED4 RID: 48852
		// (get) Token: 0x0602C10F RID: 180495 RVA: 0x006003B4 File Offset: 0x005FE5B4
		public int DecoratorsTypeLength
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

		// Token: 0x0602C110 RID: 180496 RVA: 0x006003E0 File Offset: 0x005FE5E0
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C111 RID: 180497 RVA: 0x006003F0 File Offset: 0x005FE5F0
		public TCommonBtDecorator[] GetDecoratorsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCommonBtDecorator[] array = new TCommonBtDecorator[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCommonBtDecorator)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602C112 RID: 180498 RVA: 0x0060045C File Offset: 0x005FE65C
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BED5 RID: 48853
		// (get) Token: 0x0602C113 RID: 180499 RVA: 0x006004A4 File Offset: 0x005FE6A4
		public int DecoratorsLength
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

		// Token: 0x1700BED6 RID: 48854
		// (get) Token: 0x0602C114 RID: 180500 RVA: 0x006004D0 File Offset: 0x005FE6D0
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602C115 RID: 180501 RVA: 0x00600510 File Offset: 0x005FE710
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BED7 RID: 48855
		// (get) Token: 0x0602C116 RID: 180502 RVA: 0x00600550 File Offset: 0x005FE750
		public int ChildrenTypeLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C117 RID: 180503 RVA: 0x0060057C File Offset: 0x005FE77C
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x0602C118 RID: 180504 RVA: 0x0060058C File Offset: 0x005FE78C
		public TCommonBtNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCommonBtNode[] array = new TCommonBtNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCommonBtNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602C119 RID: 180505 RVA: 0x006005F8 File Offset: 0x005FE7F8
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BED8 RID: 48856
		// (get) Token: 0x0602C11A RID: 180506 RVA: 0x00600640 File Offset: 0x005FE840
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700BED9 RID: 48857
		// (get) Token: 0x0602C11B RID: 180507 RVA: 0x0060066C File Offset: 0x005FE86C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C11C RID: 180508 RVA: 0x006006AC File Offset: 0x005FE8AC
		public static Offset<ICommonBtSequence> CreateICommonBtSequence(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ICommonBtSequence.AddChildren(builder, ChildrenOffset);
			ICommonBtSequence.AddChildrenType(builder, Children_typeOffset);
			ICommonBtSequence.AddDecorators(builder, DecoratorsOffset);
			ICommonBtSequence.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtSequence.AddDesc(builder, DescOffset);
			ICommonBtSequence.AddId(builder, Id);
			ICommonBtSequence.AddNullMask(builder, NullMask);
			ICommonBtSequence.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtSequence.AddType(builder, Type);
			return ICommonBtSequence.EndICommonBtSequence(builder);
		}

		// Token: 0x0602C11D RID: 180509 RVA: 0x0060070C File Offset: 0x005FE90C
		public static void StartICommonBtSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602C11E RID: 180510 RVA: 0x00600716 File Offset: 0x005FE916
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C11F RID: 180511 RVA: 0x00600721 File Offset: 0x005FE921
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C120 RID: 180512 RVA: 0x0060072C File Offset: 0x005FE92C
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C121 RID: 180513 RVA: 0x0060073C File Offset: 0x005FE93C
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C122 RID: 180514 RVA: 0x0060074C File Offset: 0x005FE94C
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C123 RID: 180515 RVA: 0x00600783 File Offset: 0x005FE983
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C124 RID: 180516 RVA: 0x0060079D File Offset: 0x005FE99D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C125 RID: 180517 RVA: 0x006007BB File Offset: 0x005FE9BB
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C126 RID: 180518 RVA: 0x006007D4 File Offset: 0x005FE9D4
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C127 RID: 180519 RVA: 0x006007DF File Offset: 0x005FE9DF
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C128 RID: 180520 RVA: 0x006007F0 File Offset: 0x005FE9F0
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C129 RID: 180521 RVA: 0x00600827 File Offset: 0x005FEA27
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C12A RID: 180522 RVA: 0x00600841 File Offset: 0x005FEA41
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C12B RID: 180523 RVA: 0x0060085F File Offset: 0x005FEA5F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C12C RID: 180524 RVA: 0x00600878 File Offset: 0x005FEA78
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C12D RID: 180525 RVA: 0x00600883 File Offset: 0x005FEA83
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C12E RID: 180526 RVA: 0x0060088E File Offset: 0x005FEA8E
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0602C12F RID: 180527 RVA: 0x006008A0 File Offset: 0x005FEAA0
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C130 RID: 180528 RVA: 0x006008D7 File Offset: 0x005FEAD7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C131 RID: 180529 RVA: 0x006008F1 File Offset: 0x005FEAF1
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C132 RID: 180530 RVA: 0x0060090F File Offset: 0x005FEB0F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C133 RID: 180531 RVA: 0x00600928 File Offset: 0x005FEB28
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C134 RID: 180532 RVA: 0x00600933 File Offset: 0x005FEB33
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0602C135 RID: 180533 RVA: 0x00600944 File Offset: 0x005FEB44
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C136 RID: 180534 RVA: 0x0060097B File Offset: 0x005FEB7B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C137 RID: 180535 RVA: 0x00600995 File Offset: 0x005FEB95
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C138 RID: 180536 RVA: 0x006009B3 File Offset: 0x005FEBB3
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C139 RID: 180537 RVA: 0x006009CC File Offset: 0x005FEBCC
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C13A RID: 180538 RVA: 0x006009D7 File Offset: 0x005FEBD7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602C13B RID: 180539 RVA: 0x006009E2 File Offset: 0x005FEBE2
		public static Offset<ICommonBtSequence> EndICommonBtSequence(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtSequence>(builder.EndTable());
		}

		// Token: 0x0602C13C RID: 180540 RVA: 0x006009F0 File Offset: 0x005FEBF0
		public ICommonBtSequenceT UnPack()
		{
			ICommonBtSequenceT commonBtSequenceT = new ICommonBtSequenceT();
			this.UnPackTo(commonBtSequenceT);
			return commonBtSequenceT;
		}

		// Token: 0x0602C13D RID: 180541 RVA: 0x00600A0C File Offset: 0x005FEC0C
		public void UnPackTo(ICommonBtSequenceT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Decorators = new List<TCommonBtDecoratorUnion>();
			for (int i = 0; i < this.DecoratorsLength; i++)
			{
				TCommonBtDecoratorUnion tcommonBtDecoratorUnion = new TCommonBtDecoratorUnion();
				tcommonBtDecoratorUnion.Type = this.DecoratorsType(i);
				switch (this.DecoratorsType(i))
				{
				case TCommonBtDecorator.ICommonBtAlwaysFalseDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtAlwaysFalseDecorator>(i) != null) ? this.Decorators<ICommonBtAlwaysFalseDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtAlwaysTrueDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtAlwaysTrueDecorator>(i) != null) ? this.Decorators<ICommonBtAlwaysTrueDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtConditionDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtConditionDecorator>(i) != null) ? this.Decorators<ICommonBtConditionDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtCoolDownDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtCoolDownDecorator>(i) != null) ? this.Decorators<ICommonBtCoolDownDecorator>(i).Value.UnPack() : null);
					break;
				case TCommonBtDecorator.ICommonBtDoOnceDecorator:
					tcommonBtDecoratorUnion.Value = ((this.Decorators<ICommonBtDoOnceDecorator>(i) != null) ? this.Decorators<ICommonBtDoOnceDecorator>(i).Value.UnPack() : null);
					break;
				}
				_o.Decorators.Add(tcommonBtDecoratorUnion);
			}
			_o._FoldedForTree = this._FoldedForTree;
			_o.Children = new List<TCommonBtNodeUnion>();
			for (int j = 0; j < this.ChildrenLength; j++)
			{
				TCommonBtNodeUnion tcommonBtNodeUnion = new TCommonBtNodeUnion();
				tcommonBtNodeUnion.Type = this.ChildrenType(j);
				switch (this.ChildrenType(j))
				{
				case TCommonBtNode.ICommonBtProbability:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtProbability>(j) != null) ? this.Children<ICommonBtProbability>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtSelector:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtSelector>(j) != null) ? this.Children<ICommonBtSelector>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtSequence:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtSequence>(j) != null) ? this.Children<ICommonBtSequence>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtStart:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtStart>(j) != null) ? this.Children<ICommonBtStart>(j).Value.UnPack() : null);
					break;
				case TCommonBtNode.ICommonBtTask:
					tcommonBtNodeUnion.Value = ((this.Children<ICommonBtTask>(j) != null) ? this.Children<ICommonBtTask>(j).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tcommonBtNodeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C13E RID: 180542 RVA: 0x00600D68 File Offset: 0x005FEF68
		public static Offset<ICommonBtSequence> Pack(FlatBufferBuilder builder, ICommonBtSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtSequence>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset decorators_typeOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				TCommonBtDecorator[] array = new TCommonBtDecorator[_o.Decorators.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Decorators[i].Type;
				}
				decorators_typeOffset = ICommonBtSequence.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtSequence.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TCommonBtNode[] array3 = new TCommonBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = ICommonBtSequence.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TCommonBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ICommonBtSequence.CreateChildrenVector(builder, array4);
			}
			return ICommonBtSequence.CreateICommonBtSequence(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x040106B8 RID: 67256
		private Table __p;
	}
}
