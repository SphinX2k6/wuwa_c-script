using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC9 RID: 24265
	public struct ICommonBtSequence : IFlatbufferObject
	{
		// Token: 0x1700B565 RID: 46437
		// (get) Token: 0x06029A4F RID: 170575 RVA: 0x005B6D58 File Offset: 0x005B4F58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A50 RID: 170576 RVA: 0x005B6D65 File Offset: 0x005B4F65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A51 RID: 170577 RVA: 0x005B6D6C File Offset: 0x005B4F6C
		public static ICommonBtSequence GetRootAsICommonBtSequence(ByteBuffer _bb)
		{
			return ICommonBtSequence.GetRootAsICommonBtSequence(_bb, default(ICommonBtSequence));
		}

		// Token: 0x06029A52 RID: 170578 RVA: 0x005B6D88 File Offset: 0x005B4F88
		public static ICommonBtSequence GetRootAsICommonBtSequence(ByteBuffer _bb, ICommonBtSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A53 RID: 170579 RVA: 0x005B6DA5 File Offset: 0x005B4FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A54 RID: 170580 RVA: 0x005B6DB4 File Offset: 0x005B4FB4
		public ICommonBtSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B566 RID: 46438
		// (get) Token: 0x06029A55 RID: 170581 RVA: 0x005B6DC4 File Offset: 0x005B4FC4
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

		// Token: 0x1700B567 RID: 46439
		// (get) Token: 0x06029A56 RID: 170582 RVA: 0x005B6E00 File Offset: 0x005B5000
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

		// Token: 0x1700B568 RID: 46440
		// (get) Token: 0x06029A57 RID: 170583 RVA: 0x005B6E3C File Offset: 0x005B503C
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

		// Token: 0x06029A58 RID: 170584 RVA: 0x005B6E73 File Offset: 0x005B5073
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06029A59 RID: 170585 RVA: 0x005B6E82 File Offset: 0x005B5082
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06029A5A RID: 170586 RVA: 0x005B6E90 File Offset: 0x005B5090
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B569 RID: 46441
		// (get) Token: 0x06029A5B RID: 170587 RVA: 0x005B6ED0 File Offset: 0x005B50D0
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

		// Token: 0x06029A5C RID: 170588 RVA: 0x005B6EFC File Offset: 0x005B50FC
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x06029A5D RID: 170589 RVA: 0x005B6F0C File Offset: 0x005B510C
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

		// Token: 0x06029A5E RID: 170590 RVA: 0x005B6F78 File Offset: 0x005B5178
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B56A RID: 46442
		// (get) Token: 0x06029A5F RID: 170591 RVA: 0x005B6FC0 File Offset: 0x005B51C0
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

		// Token: 0x1700B56B RID: 46443
		// (get) Token: 0x06029A60 RID: 170592 RVA: 0x005B6FEC File Offset: 0x005B51EC
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029A61 RID: 170593 RVA: 0x005B702C File Offset: 0x005B522C
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B56C RID: 46444
		// (get) Token: 0x06029A62 RID: 170594 RVA: 0x005B706C File Offset: 0x005B526C
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

		// Token: 0x06029A63 RID: 170595 RVA: 0x005B7098 File Offset: 0x005B5298
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x06029A64 RID: 170596 RVA: 0x005B70A8 File Offset: 0x005B52A8
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

		// Token: 0x06029A65 RID: 170597 RVA: 0x005B7114 File Offset: 0x005B5314
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B56D RID: 46445
		// (get) Token: 0x06029A66 RID: 170598 RVA: 0x005B715C File Offset: 0x005B535C
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

		// Token: 0x1700B56E RID: 46446
		// (get) Token: 0x06029A67 RID: 170599 RVA: 0x005B7188 File Offset: 0x005B5388
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

		// Token: 0x06029A68 RID: 170600 RVA: 0x005B71C8 File Offset: 0x005B53C8
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

		// Token: 0x06029A69 RID: 170601 RVA: 0x005B7228 File Offset: 0x005B5428
		public static void StartICommonBtSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06029A6A RID: 170602 RVA: 0x005B7232 File Offset: 0x005B5432
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029A6B RID: 170603 RVA: 0x005B723D File Offset: 0x005B543D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029A6C RID: 170604 RVA: 0x005B7248 File Offset: 0x005B5448
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06029A6D RID: 170605 RVA: 0x005B7258 File Offset: 0x005B5458
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06029A6E RID: 170606 RVA: 0x005B7268 File Offset: 0x005B5468
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A6F RID: 170607 RVA: 0x005B729F File Offset: 0x005B549F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A70 RID: 170608 RVA: 0x005B72B9 File Offset: 0x005B54B9
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A71 RID: 170609 RVA: 0x005B72D7 File Offset: 0x005B54D7
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A72 RID: 170610 RVA: 0x005B72F0 File Offset: 0x005B54F0
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029A73 RID: 170611 RVA: 0x005B72FB File Offset: 0x005B54FB
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06029A74 RID: 170612 RVA: 0x005B730C File Offset: 0x005B550C
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A75 RID: 170613 RVA: 0x005B7343 File Offset: 0x005B5543
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A76 RID: 170614 RVA: 0x005B735D File Offset: 0x005B555D
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A77 RID: 170615 RVA: 0x005B737B File Offset: 0x005B557B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A78 RID: 170616 RVA: 0x005B7394 File Offset: 0x005B5594
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029A79 RID: 170617 RVA: 0x005B739F File Offset: 0x005B559F
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06029A7A RID: 170618 RVA: 0x005B73AA File Offset: 0x005B55AA
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06029A7B RID: 170619 RVA: 0x005B73BC File Offset: 0x005B55BC
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A7C RID: 170620 RVA: 0x005B73F3 File Offset: 0x005B55F3
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A7D RID: 170621 RVA: 0x005B740D File Offset: 0x005B560D
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A7E RID: 170622 RVA: 0x005B742B File Offset: 0x005B562B
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A7F RID: 170623 RVA: 0x005B7444 File Offset: 0x005B5644
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029A80 RID: 170624 RVA: 0x005B744F File Offset: 0x005B564F
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x06029A81 RID: 170625 RVA: 0x005B7460 File Offset: 0x005B5660
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029A82 RID: 170626 RVA: 0x005B7497 File Offset: 0x005B5697
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A83 RID: 170627 RVA: 0x005B74B1 File Offset: 0x005B56B1
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029A84 RID: 170628 RVA: 0x005B74CF File Offset: 0x005B56CF
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029A85 RID: 170629 RVA: 0x005B74E8 File Offset: 0x005B56E8
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029A86 RID: 170630 RVA: 0x005B74F3 File Offset: 0x005B56F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029A87 RID: 170631 RVA: 0x005B74FE File Offset: 0x005B56FE
		public static Offset<ICommonBtSequence> EndICommonBtSequence(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtSequence>(builder.EndTable());
		}

		// Token: 0x06029A88 RID: 170632 RVA: 0x005B750C File Offset: 0x005B570C
		public ICommonBtSequenceT UnPack()
		{
			ICommonBtSequenceT commonBtSequenceT = new ICommonBtSequenceT();
			this.UnPackTo(commonBtSequenceT);
			return commonBtSequenceT;
		}

		// Token: 0x06029A89 RID: 170633 RVA: 0x005B7528 File Offset: 0x005B5728
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

		// Token: 0x06029A8A RID: 170634 RVA: 0x005B7884 File Offset: 0x005B5A84
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

		// Token: 0x0400F955 RID: 63829
		private Table __p;
	}
}
