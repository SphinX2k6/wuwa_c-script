using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006509 RID: 25865
	public struct ICommonBtSelector : IFlatbufferObject
	{
		// Token: 0x1700BEBF RID: 48831
		// (get) Token: 0x0602C0B7 RID: 180407 RVA: 0x005FF422 File Offset: 0x005FD622
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0B8 RID: 180408 RVA: 0x005FF42F File Offset: 0x005FD62F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0B9 RID: 180409 RVA: 0x005FF438 File Offset: 0x005FD638
		public static ICommonBtSelector GetRootAsICommonBtSelector(ByteBuffer _bb)
		{
			return ICommonBtSelector.GetRootAsICommonBtSelector(_bb, default(ICommonBtSelector));
		}

		// Token: 0x0602C0BA RID: 180410 RVA: 0x005FF454 File Offset: 0x005FD654
		public static ICommonBtSelector GetRootAsICommonBtSelector(ByteBuffer _bb, ICommonBtSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0BB RID: 180411 RVA: 0x005FF471 File Offset: 0x005FD671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0BC RID: 180412 RVA: 0x005FF480 File Offset: 0x005FD680
		public ICommonBtSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEC0 RID: 48832
		// (get) Token: 0x0602C0BD RID: 180413 RVA: 0x005FF490 File Offset: 0x005FD690
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

		// Token: 0x1700BEC1 RID: 48833
		// (get) Token: 0x0602C0BE RID: 180414 RVA: 0x005FF4CC File Offset: 0x005FD6CC
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

		// Token: 0x1700BEC2 RID: 48834
		// (get) Token: 0x0602C0BF RID: 180415 RVA: 0x005FF508 File Offset: 0x005FD708
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

		// Token: 0x0602C0C0 RID: 180416 RVA: 0x005FF53F File Offset: 0x005FD73F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C0C1 RID: 180417 RVA: 0x005FF54E File Offset: 0x005FD74E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C0C2 RID: 180418 RVA: 0x005FF55C File Offset: 0x005FD75C
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEC3 RID: 48835
		// (get) Token: 0x0602C0C3 RID: 180419 RVA: 0x005FF59C File Offset: 0x005FD79C
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

		// Token: 0x0602C0C4 RID: 180420 RVA: 0x005FF5C8 File Offset: 0x005FD7C8
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C0C5 RID: 180421 RVA: 0x005FF5D8 File Offset: 0x005FD7D8
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

		// Token: 0x0602C0C6 RID: 180422 RVA: 0x005FF644 File Offset: 0x005FD844
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEC4 RID: 48836
		// (get) Token: 0x0602C0C7 RID: 180423 RVA: 0x005FF68C File Offset: 0x005FD88C
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

		// Token: 0x1700BEC5 RID: 48837
		// (get) Token: 0x0602C0C8 RID: 180424 RVA: 0x005FF6B8 File Offset: 0x005FD8B8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602C0C9 RID: 180425 RVA: 0x005FF6F8 File Offset: 0x005FD8F8
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEC6 RID: 48838
		// (get) Token: 0x0602C0CA RID: 180426 RVA: 0x005FF738 File Offset: 0x005FD938
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

		// Token: 0x0602C0CB RID: 180427 RVA: 0x005FF764 File Offset: 0x005FD964
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x0602C0CC RID: 180428 RVA: 0x005FF774 File Offset: 0x005FD974
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

		// Token: 0x0602C0CD RID: 180429 RVA: 0x005FF7E0 File Offset: 0x005FD9E0
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEC7 RID: 48839
		// (get) Token: 0x0602C0CE RID: 180430 RVA: 0x005FF828 File Offset: 0x005FDA28
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

		// Token: 0x1700BEC8 RID: 48840
		// (get) Token: 0x0602C0CF RID: 180431 RVA: 0x005FF854 File Offset: 0x005FDA54
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

		// Token: 0x0602C0D0 RID: 180432 RVA: 0x005FF894 File Offset: 0x005FDA94
		public static Offset<ICommonBtSelector> CreateICommonBtSelector(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ICommonBtSelector.AddChildren(builder, ChildrenOffset);
			ICommonBtSelector.AddChildrenType(builder, Children_typeOffset);
			ICommonBtSelector.AddDecorators(builder, DecoratorsOffset);
			ICommonBtSelector.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtSelector.AddDesc(builder, DescOffset);
			ICommonBtSelector.AddId(builder, Id);
			ICommonBtSelector.AddNullMask(builder, NullMask);
			ICommonBtSelector.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtSelector.AddType(builder, Type);
			return ICommonBtSelector.EndICommonBtSelector(builder);
		}

		// Token: 0x0602C0D1 RID: 180433 RVA: 0x005FF8F4 File Offset: 0x005FDAF4
		public static void StartICommonBtSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602C0D2 RID: 180434 RVA: 0x005FF8FE File Offset: 0x005FDAFE
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C0D3 RID: 180435 RVA: 0x005FF909 File Offset: 0x005FDB09
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C0D4 RID: 180436 RVA: 0x005FF914 File Offset: 0x005FDB14
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C0D5 RID: 180437 RVA: 0x005FF924 File Offset: 0x005FDB24
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C0D6 RID: 180438 RVA: 0x005FF934 File Offset: 0x005FDB34
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C0D7 RID: 180439 RVA: 0x005FF96B File Offset: 0x005FDB6B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0D8 RID: 180440 RVA: 0x005FF985 File Offset: 0x005FDB85
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0D9 RID: 180441 RVA: 0x005FF9A3 File Offset: 0x005FDBA3
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C0DA RID: 180442 RVA: 0x005FF9BC File Offset: 0x005FDBBC
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C0DB RID: 180443 RVA: 0x005FF9C7 File Offset: 0x005FDBC7
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C0DC RID: 180444 RVA: 0x005FF9D8 File Offset: 0x005FDBD8
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C0DD RID: 180445 RVA: 0x005FFA0F File Offset: 0x005FDC0F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0DE RID: 180446 RVA: 0x005FFA29 File Offset: 0x005FDC29
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0DF RID: 180447 RVA: 0x005FFA47 File Offset: 0x005FDC47
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C0E0 RID: 180448 RVA: 0x005FFA60 File Offset: 0x005FDC60
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C0E1 RID: 180449 RVA: 0x005FFA6B File Offset: 0x005FDC6B
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C0E2 RID: 180450 RVA: 0x005FFA76 File Offset: 0x005FDC76
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0602C0E3 RID: 180451 RVA: 0x005FFA88 File Offset: 0x005FDC88
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C0E4 RID: 180452 RVA: 0x005FFABF File Offset: 0x005FDCBF
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0E5 RID: 180453 RVA: 0x005FFAD9 File Offset: 0x005FDCD9
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0E6 RID: 180454 RVA: 0x005FFAF7 File Offset: 0x005FDCF7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C0E7 RID: 180455 RVA: 0x005FFB10 File Offset: 0x005FDD10
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C0E8 RID: 180456 RVA: 0x005FFB1B File Offset: 0x005FDD1B
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0602C0E9 RID: 180457 RVA: 0x005FFB2C File Offset: 0x005FDD2C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C0EA RID: 180458 RVA: 0x005FFB63 File Offset: 0x005FDD63
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0EB RID: 180459 RVA: 0x005FFB7D File Offset: 0x005FDD7D
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C0EC RID: 180460 RVA: 0x005FFB9B File Offset: 0x005FDD9B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C0ED RID: 180461 RVA: 0x005FFBB4 File Offset: 0x005FDDB4
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C0EE RID: 180462 RVA: 0x005FFBBF File Offset: 0x005FDDBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602C0EF RID: 180463 RVA: 0x005FFBCA File Offset: 0x005FDDCA
		public static Offset<ICommonBtSelector> EndICommonBtSelector(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtSelector>(builder.EndTable());
		}

		// Token: 0x0602C0F0 RID: 180464 RVA: 0x005FFBD8 File Offset: 0x005FDDD8
		public ICommonBtSelectorT UnPack()
		{
			ICommonBtSelectorT commonBtSelectorT = new ICommonBtSelectorT();
			this.UnPackTo(commonBtSelectorT);
			return commonBtSelectorT;
		}

		// Token: 0x0602C0F1 RID: 180465 RVA: 0x005FFBF4 File Offset: 0x005FDDF4
		public void UnPackTo(ICommonBtSelectorT _o)
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

		// Token: 0x0602C0F2 RID: 180466 RVA: 0x005FFF50 File Offset: 0x005FE150
		public static Offset<ICommonBtSelector> Pack(FlatBufferBuilder builder, ICommonBtSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtSelector>);
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
				decorators_typeOffset = ICommonBtSelector.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtSelector.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TCommonBtNode[] array3 = new TCommonBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = ICommonBtSelector.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TCommonBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ICommonBtSelector.CreateChildrenVector(builder, array4);
			}
			return ICommonBtSelector.CreateICommonBtSelector(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x040106B0 RID: 67248
		private Table __p;
	}
}
