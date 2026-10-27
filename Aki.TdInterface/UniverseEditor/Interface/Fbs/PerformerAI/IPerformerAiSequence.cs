using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004378 RID: 17272
	public struct IPerformerAiSequence : IFlatbufferObject
	{
		// Token: 0x170079FE RID: 31230
		// (get) Token: 0x06019A84 RID: 105092 RVA: 0x003AC5E4 File Offset: 0x003AA7E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A85 RID: 105093 RVA: 0x003AC5F1 File Offset: 0x003AA7F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A86 RID: 105094 RVA: 0x003AC5F8 File Offset: 0x003AA7F8
		public static IPerformerAiSequence GetRootAsIPerformerAiSequence(ByteBuffer _bb)
		{
			return IPerformerAiSequence.GetRootAsIPerformerAiSequence(_bb, default(IPerformerAiSequence));
		}

		// Token: 0x06019A87 RID: 105095 RVA: 0x003AC614 File Offset: 0x003AA814
		public static IPerformerAiSequence GetRootAsIPerformerAiSequence(ByteBuffer _bb, IPerformerAiSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A88 RID: 105096 RVA: 0x003AC631 File Offset: 0x003AA831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A89 RID: 105097 RVA: 0x003AC640 File Offset: 0x003AA840
		public IPerformerAiSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079FF RID: 31231
		// (get) Token: 0x06019A8A RID: 105098 RVA: 0x003AC650 File Offset: 0x003AA850
		public EPerformerAiNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiNodeType.Start;
				}
				return (EPerformerAiNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A00 RID: 31232
		// (get) Token: 0x06019A8B RID: 105099 RVA: 0x003AC68C File Offset: 0x003AA88C
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

		// Token: 0x17007A01 RID: 31233
		// (get) Token: 0x06019A8C RID: 105100 RVA: 0x003AC6C8 File Offset: 0x003AA8C8
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

		// Token: 0x06019A8D RID: 105101 RVA: 0x003AC6FF File Offset: 0x003AA8FF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019A8E RID: 105102 RVA: 0x003AC70E File Offset: 0x003AA90E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06019A8F RID: 105103 RVA: 0x003AC71C File Offset: 0x003AA91C
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A02 RID: 31234
		// (get) Token: 0x06019A90 RID: 105104 RVA: 0x003AC75C File Offset: 0x003AA95C
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

		// Token: 0x06019A91 RID: 105105 RVA: 0x003AC788 File Offset: 0x003AA988
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x06019A92 RID: 105106 RVA: 0x003AC798 File Offset: 0x003AA998
		public TPerformerAiDecorator[] GetDecoratorsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformerAiDecorator[] array = new TPerformerAiDecorator[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformerAiDecorator)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06019A93 RID: 105107 RVA: 0x003AC804 File Offset: 0x003AAA04
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007A03 RID: 31235
		// (get) Token: 0x06019A94 RID: 105108 RVA: 0x003AC84C File Offset: 0x003AAA4C
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

		// Token: 0x17007A04 RID: 31236
		// (get) Token: 0x06019A95 RID: 105109 RVA: 0x003AC878 File Offset: 0x003AAA78
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019A96 RID: 105110 RVA: 0x003AC8B8 File Offset: 0x003AAAB8
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007A05 RID: 31237
		// (get) Token: 0x06019A97 RID: 105111 RVA: 0x003AC8F8 File Offset: 0x003AAAF8
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

		// Token: 0x06019A98 RID: 105112 RVA: 0x003AC924 File Offset: 0x003AAB24
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x06019A99 RID: 105113 RVA: 0x003AC934 File Offset: 0x003AAB34
		public TPerformerAiNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPerformerAiNode[] array = new TPerformerAiNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPerformerAiNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06019A9A RID: 105114 RVA: 0x003AC9A0 File Offset: 0x003AABA0
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007A06 RID: 31238
		// (get) Token: 0x06019A9B RID: 105115 RVA: 0x003AC9E8 File Offset: 0x003AABE8
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

		// Token: 0x17007A07 RID: 31239
		// (get) Token: 0x06019A9C RID: 105116 RVA: 0x003ACA14 File Offset: 0x003AAC14
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

		// Token: 0x06019A9D RID: 105117 RVA: 0x003ACA54 File Offset: 0x003AAC54
		public static Offset<IPerformerAiSequence> CreateIPerformerAiSequence(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPerformerAiSequence.AddChildren(builder, ChildrenOffset);
			IPerformerAiSequence.AddChildrenType(builder, Children_typeOffset);
			IPerformerAiSequence.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiSequence.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiSequence.AddDesc(builder, DescOffset);
			IPerformerAiSequence.AddId(builder, Id);
			IPerformerAiSequence.AddNullMask(builder, NullMask);
			IPerformerAiSequence.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiSequence.AddType(builder, Type);
			return IPerformerAiSequence.EndIPerformerAiSequence(builder);
		}

		// Token: 0x06019A9E RID: 105118 RVA: 0x003ACAB4 File Offset: 0x003AACB4
		public static void StartIPerformerAiSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019A9F RID: 105119 RVA: 0x003ACABE File Offset: 0x003AACBE
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019AA0 RID: 105120 RVA: 0x003ACAC9 File Offset: 0x003AACC9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019AA1 RID: 105121 RVA: 0x003ACAD4 File Offset: 0x003AACD4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019AA2 RID: 105122 RVA: 0x003ACAE4 File Offset: 0x003AACE4
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06019AA3 RID: 105123 RVA: 0x003ACAF4 File Offset: 0x003AACF4
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AA4 RID: 105124 RVA: 0x003ACB2B File Offset: 0x003AAD2B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AA5 RID: 105125 RVA: 0x003ACB45 File Offset: 0x003AAD45
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AA6 RID: 105126 RVA: 0x003ACB63 File Offset: 0x003AAD63
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019AA7 RID: 105127 RVA: 0x003ACB7C File Offset: 0x003AAD7C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019AA8 RID: 105128 RVA: 0x003ACB87 File Offset: 0x003AAD87
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06019AA9 RID: 105129 RVA: 0x003ACB98 File Offset: 0x003AAD98
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AAA RID: 105130 RVA: 0x003ACBCF File Offset: 0x003AADCF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AAB RID: 105131 RVA: 0x003ACBE9 File Offset: 0x003AADE9
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AAC RID: 105132 RVA: 0x003ACC07 File Offset: 0x003AAE07
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019AAD RID: 105133 RVA: 0x003ACC20 File Offset: 0x003AAE20
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019AAE RID: 105134 RVA: 0x003ACC2B File Offset: 0x003AAE2B
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06019AAF RID: 105135 RVA: 0x003ACC36 File Offset: 0x003AAE36
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06019AB0 RID: 105136 RVA: 0x003ACC48 File Offset: 0x003AAE48
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AB1 RID: 105137 RVA: 0x003ACC7F File Offset: 0x003AAE7F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AB2 RID: 105138 RVA: 0x003ACC99 File Offset: 0x003AAE99
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AB3 RID: 105139 RVA: 0x003ACCB7 File Offset: 0x003AAEB7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019AB4 RID: 105140 RVA: 0x003ACCD0 File Offset: 0x003AAED0
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019AB5 RID: 105141 RVA: 0x003ACCDB File Offset: 0x003AAEDB
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x06019AB6 RID: 105142 RVA: 0x003ACCEC File Offset: 0x003AAEEC
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019AB7 RID: 105143 RVA: 0x003ACD23 File Offset: 0x003AAF23
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AB8 RID: 105144 RVA: 0x003ACD3D File Offset: 0x003AAF3D
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019AB9 RID: 105145 RVA: 0x003ACD5B File Offset: 0x003AAF5B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019ABA RID: 105146 RVA: 0x003ACD74 File Offset: 0x003AAF74
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019ABB RID: 105147 RVA: 0x003ACD7F File Offset: 0x003AAF7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019ABC RID: 105148 RVA: 0x003ACD8A File Offset: 0x003AAF8A
		public static Offset<IPerformerAiSequence> EndIPerformerAiSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSequence>(builder.EndTable());
		}

		// Token: 0x06019ABD RID: 105149 RVA: 0x003ACD98 File Offset: 0x003AAF98
		public IPerformerAiSequenceT UnPack()
		{
			IPerformerAiSequenceT performerAiSequenceT = new IPerformerAiSequenceT();
			this.UnPackTo(performerAiSequenceT);
			return performerAiSequenceT;
		}

		// Token: 0x06019ABE RID: 105150 RVA: 0x003ACDB4 File Offset: 0x003AAFB4
		public void UnPackTo(IPerformerAiSequenceT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Decorators = new List<TPerformerAiDecoratorUnion>();
			for (int i = 0; i < this.DecoratorsLength; i++)
			{
				TPerformerAiDecoratorUnion tperformerAiDecoratorUnion = new TPerformerAiDecoratorUnion();
				tperformerAiDecoratorUnion.Type = this.DecoratorsType(i);
				switch (this.DecoratorsType(i))
				{
				case TPerformerAiDecorator.IPerformerAiAlwaysFalseDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysFalseDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysFalseDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiAlwaysTrueDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiAlwaysTrueDecorator>(i) != null) ? this.Decorators<IPerformerAiAlwaysTrueDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiConditionDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiConditionDecorator>(i) != null) ? this.Decorators<IPerformerAiConditionDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiCoolDownDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiCoolDownDecorator>(i) != null) ? this.Decorators<IPerformerAiCoolDownDecorator>(i).Value.UnPack() : null);
					break;
				case TPerformerAiDecorator.IPerformerAiDoOnceDecorator:
					tperformerAiDecoratorUnion.Value = ((this.Decorators<IPerformerAiDoOnceDecorator>(i) != null) ? this.Decorators<IPerformerAiDoOnceDecorator>(i).Value.UnPack() : null);
					break;
				}
				_o.Decorators.Add(tperformerAiDecoratorUnion);
			}
			_o._FoldedForTree = this._FoldedForTree;
			_o.Children = new List<TPerformerAiNodeUnion>();
			for (int j = 0; j < this.ChildrenLength; j++)
			{
				TPerformerAiNodeUnion tperformerAiNodeUnion = new TPerformerAiNodeUnion();
				tperformerAiNodeUnion.Type = this.ChildrenType(j);
				switch (this.ChildrenType(j))
				{
				case TPerformerAiNode.IPerformerAiProbability:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiProbability>(j) != null) ? this.Children<IPerformerAiProbability>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiSelector:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiSelector>(j) != null) ? this.Children<IPerformerAiSelector>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiSequence:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiSequence>(j) != null) ? this.Children<IPerformerAiSequence>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiStart:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiStart>(j) != null) ? this.Children<IPerformerAiStart>(j).Value.UnPack() : null);
					break;
				case TPerformerAiNode.IPerformerAiTask:
					tperformerAiNodeUnion.Value = ((this.Children<IPerformerAiTask>(j) != null) ? this.Children<IPerformerAiTask>(j).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tperformerAiNodeUnion);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019ABF RID: 105151 RVA: 0x003AD110 File Offset: 0x003AB310
		public static Offset<IPerformerAiSequence> Pack(FlatBufferBuilder builder, IPerformerAiSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiSequence>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			VectorOffset decorators_typeOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				TPerformerAiDecorator[] array = new TPerformerAiDecorator[_o.Decorators.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Decorators[i].Type;
				}
				decorators_typeOffset = IPerformerAiSequence.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiSequence.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TPerformerAiNode[] array3 = new TPerformerAiNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IPerformerAiSequence.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TPerformerAiNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IPerformerAiSequence.CreateChildrenVector(builder, array4);
			}
			return IPerformerAiSequence.CreateIPerformerAiSequence(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x0400C186 RID: 49542
		private Table __p;
	}
}
