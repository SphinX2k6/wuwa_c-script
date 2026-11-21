using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047DA RID: 18394
	public struct IPerformerAiSequence : IFlatbufferObject
	{
		// Token: 0x17008033 RID: 32819
		// (get) Token: 0x0601B212 RID: 111122 RVA: 0x003D800C File Offset: 0x003D620C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B213 RID: 111123 RVA: 0x003D8019 File Offset: 0x003D6219
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B214 RID: 111124 RVA: 0x003D8020 File Offset: 0x003D6220
		public static IPerformerAiSequence GetRootAsIPerformerAiSequence(ByteBuffer _bb)
		{
			return IPerformerAiSequence.GetRootAsIPerformerAiSequence(_bb, default(IPerformerAiSequence));
		}

		// Token: 0x0601B215 RID: 111125 RVA: 0x003D803C File Offset: 0x003D623C
		public static IPerformerAiSequence GetRootAsIPerformerAiSequence(ByteBuffer _bb, IPerformerAiSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B216 RID: 111126 RVA: 0x003D8059 File Offset: 0x003D6259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B217 RID: 111127 RVA: 0x003D8068 File Offset: 0x003D6268
		public IPerformerAiSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008034 RID: 32820
		// (get) Token: 0x0601B218 RID: 111128 RVA: 0x003D8078 File Offset: 0x003D6278
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

		// Token: 0x17008035 RID: 32821
		// (get) Token: 0x0601B219 RID: 111129 RVA: 0x003D80B4 File Offset: 0x003D62B4
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

		// Token: 0x17008036 RID: 32822
		// (get) Token: 0x0601B21A RID: 111130 RVA: 0x003D80F0 File Offset: 0x003D62F0
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

		// Token: 0x0601B21B RID: 111131 RVA: 0x003D8127 File Offset: 0x003D6327
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B21C RID: 111132 RVA: 0x003D8136 File Offset: 0x003D6336
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B21D RID: 111133 RVA: 0x003D8144 File Offset: 0x003D6344
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008037 RID: 32823
		// (get) Token: 0x0601B21E RID: 111134 RVA: 0x003D8184 File Offset: 0x003D6384
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

		// Token: 0x0601B21F RID: 111135 RVA: 0x003D81B0 File Offset: 0x003D63B0
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B220 RID: 111136 RVA: 0x003D81C0 File Offset: 0x003D63C0
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

		// Token: 0x0601B221 RID: 111137 RVA: 0x003D822C File Offset: 0x003D642C
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008038 RID: 32824
		// (get) Token: 0x0601B222 RID: 111138 RVA: 0x003D8274 File Offset: 0x003D6474
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

		// Token: 0x17008039 RID: 32825
		// (get) Token: 0x0601B223 RID: 111139 RVA: 0x003D82A0 File Offset: 0x003D64A0
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B224 RID: 111140 RVA: 0x003D82E0 File Offset: 0x003D64E0
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700803A RID: 32826
		// (get) Token: 0x0601B225 RID: 111141 RVA: 0x003D8320 File Offset: 0x003D6520
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

		// Token: 0x0601B226 RID: 111142 RVA: 0x003D834C File Offset: 0x003D654C
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x0601B227 RID: 111143 RVA: 0x003D835C File Offset: 0x003D655C
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

		// Token: 0x0601B228 RID: 111144 RVA: 0x003D83C8 File Offset: 0x003D65C8
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700803B RID: 32827
		// (get) Token: 0x0601B229 RID: 111145 RVA: 0x003D8410 File Offset: 0x003D6610
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

		// Token: 0x1700803C RID: 32828
		// (get) Token: 0x0601B22A RID: 111146 RVA: 0x003D843C File Offset: 0x003D663C
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

		// Token: 0x0601B22B RID: 111147 RVA: 0x003D847C File Offset: 0x003D667C
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

		// Token: 0x0601B22C RID: 111148 RVA: 0x003D84DC File Offset: 0x003D66DC
		public static void StartIPerformerAiSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601B22D RID: 111149 RVA: 0x003D84E6 File Offset: 0x003D66E6
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B22E RID: 111150 RVA: 0x003D84F1 File Offset: 0x003D66F1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B22F RID: 111151 RVA: 0x003D84FC File Offset: 0x003D66FC
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B230 RID: 111152 RVA: 0x003D850C File Offset: 0x003D670C
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B231 RID: 111153 RVA: 0x003D851C File Offset: 0x003D671C
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B232 RID: 111154 RVA: 0x003D8553 File Offset: 0x003D6753
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x003D856D File Offset: 0x003D676D
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B234 RID: 111156 RVA: 0x003D858B File Offset: 0x003D678B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B235 RID: 111157 RVA: 0x003D85A4 File Offset: 0x003D67A4
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B236 RID: 111158 RVA: 0x003D85AF File Offset: 0x003D67AF
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B237 RID: 111159 RVA: 0x003D85C0 File Offset: 0x003D67C0
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B238 RID: 111160 RVA: 0x003D85F7 File Offset: 0x003D67F7
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B239 RID: 111161 RVA: 0x003D8611 File Offset: 0x003D6811
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B23A RID: 111162 RVA: 0x003D862F File Offset: 0x003D682F
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B23B RID: 111163 RVA: 0x003D8648 File Offset: 0x003D6848
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B23C RID: 111164 RVA: 0x003D8653 File Offset: 0x003D6853
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B23D RID: 111165 RVA: 0x003D865E File Offset: 0x003D685E
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0601B23E RID: 111166 RVA: 0x003D8670 File Offset: 0x003D6870
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B23F RID: 111167 RVA: 0x003D86A7 File Offset: 0x003D68A7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B240 RID: 111168 RVA: 0x003D86C1 File Offset: 0x003D68C1
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B241 RID: 111169 RVA: 0x003D86DF File Offset: 0x003D68DF
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B242 RID: 111170 RVA: 0x003D86F8 File Offset: 0x003D68F8
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B243 RID: 111171 RVA: 0x003D8703 File Offset: 0x003D6903
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0601B244 RID: 111172 RVA: 0x003D8714 File Offset: 0x003D6914
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B245 RID: 111173 RVA: 0x003D874B File Offset: 0x003D694B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B246 RID: 111174 RVA: 0x003D8765 File Offset: 0x003D6965
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B247 RID: 111175 RVA: 0x003D8783 File Offset: 0x003D6983
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B248 RID: 111176 RVA: 0x003D879C File Offset: 0x003D699C
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B249 RID: 111177 RVA: 0x003D87A7 File Offset: 0x003D69A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601B24A RID: 111178 RVA: 0x003D87B2 File Offset: 0x003D69B2
		public static Offset<IPerformerAiSequence> EndIPerformerAiSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSequence>(builder.EndTable());
		}

		// Token: 0x0601B24B RID: 111179 RVA: 0x003D87C0 File Offset: 0x003D69C0
		public IPerformerAiSequenceT UnPack()
		{
			IPerformerAiSequenceT performerAiSequenceT = new IPerformerAiSequenceT();
			this.UnPackTo(performerAiSequenceT);
			return performerAiSequenceT;
		}

		// Token: 0x0601B24C RID: 111180 RVA: 0x003D87DC File Offset: 0x003D69DC
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

		// Token: 0x0601B24D RID: 111181 RVA: 0x003D8B38 File Offset: 0x003D6D38
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

		// Token: 0x0400CBA4 RID: 52132
		private Table __p;
	}
}
