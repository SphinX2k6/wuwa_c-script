using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D7 RID: 18391
	public struct IPerformerAiSelector : IFlatbufferObject
	{
		// Token: 0x17008022 RID: 32802
		// (get) Token: 0x0601B1C6 RID: 111046 RVA: 0x003D71F2 File Offset: 0x003D53F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B1C7 RID: 111047 RVA: 0x003D71FF File Offset: 0x003D53FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B1C8 RID: 111048 RVA: 0x003D7208 File Offset: 0x003D5408
		public static IPerformerAiSelector GetRootAsIPerformerAiSelector(ByteBuffer _bb)
		{
			return IPerformerAiSelector.GetRootAsIPerformerAiSelector(_bb, default(IPerformerAiSelector));
		}

		// Token: 0x0601B1C9 RID: 111049 RVA: 0x003D7224 File Offset: 0x003D5424
		public static IPerformerAiSelector GetRootAsIPerformerAiSelector(ByteBuffer _bb, IPerformerAiSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B1CA RID: 111050 RVA: 0x003D7241 File Offset: 0x003D5441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B1CB RID: 111051 RVA: 0x003D7250 File Offset: 0x003D5450
		public IPerformerAiSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008023 RID: 32803
		// (get) Token: 0x0601B1CC RID: 111052 RVA: 0x003D7260 File Offset: 0x003D5460
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

		// Token: 0x17008024 RID: 32804
		// (get) Token: 0x0601B1CD RID: 111053 RVA: 0x003D729C File Offset: 0x003D549C
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

		// Token: 0x17008025 RID: 32805
		// (get) Token: 0x0601B1CE RID: 111054 RVA: 0x003D72D8 File Offset: 0x003D54D8
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

		// Token: 0x0601B1CF RID: 111055 RVA: 0x003D730F File Offset: 0x003D550F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B1D0 RID: 111056 RVA: 0x003D731E File Offset: 0x003D551E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B1D1 RID: 111057 RVA: 0x003D732C File Offset: 0x003D552C
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008026 RID: 32806
		// (get) Token: 0x0601B1D2 RID: 111058 RVA: 0x003D736C File Offset: 0x003D556C
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

		// Token: 0x0601B1D3 RID: 111059 RVA: 0x003D7398 File Offset: 0x003D5598
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B1D4 RID: 111060 RVA: 0x003D73A8 File Offset: 0x003D55A8
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

		// Token: 0x0601B1D5 RID: 111061 RVA: 0x003D7414 File Offset: 0x003D5614
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008027 RID: 32807
		// (get) Token: 0x0601B1D6 RID: 111062 RVA: 0x003D745C File Offset: 0x003D565C
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

		// Token: 0x17008028 RID: 32808
		// (get) Token: 0x0601B1D7 RID: 111063 RVA: 0x003D7488 File Offset: 0x003D5688
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B1D8 RID: 111064 RVA: 0x003D74C8 File Offset: 0x003D56C8
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008029 RID: 32809
		// (get) Token: 0x0601B1D9 RID: 111065 RVA: 0x003D7508 File Offset: 0x003D5708
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

		// Token: 0x0601B1DA RID: 111066 RVA: 0x003D7534 File Offset: 0x003D5734
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x0601B1DB RID: 111067 RVA: 0x003D7544 File Offset: 0x003D5744
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

		// Token: 0x0601B1DC RID: 111068 RVA: 0x003D75B0 File Offset: 0x003D57B0
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700802A RID: 32810
		// (get) Token: 0x0601B1DD RID: 111069 RVA: 0x003D75F8 File Offset: 0x003D57F8
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

		// Token: 0x1700802B RID: 32811
		// (get) Token: 0x0601B1DE RID: 111070 RVA: 0x003D7624 File Offset: 0x003D5824
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

		// Token: 0x0601B1DF RID: 111071 RVA: 0x003D7664 File Offset: 0x003D5864
		public static Offset<IPerformerAiSelector> CreateIPerformerAiSelector(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPerformerAiSelector.AddChildren(builder, ChildrenOffset);
			IPerformerAiSelector.AddChildrenType(builder, Children_typeOffset);
			IPerformerAiSelector.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiSelector.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiSelector.AddDesc(builder, DescOffset);
			IPerformerAiSelector.AddId(builder, Id);
			IPerformerAiSelector.AddNullMask(builder, NullMask);
			IPerformerAiSelector.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiSelector.AddType(builder, Type);
			return IPerformerAiSelector.EndIPerformerAiSelector(builder);
		}

		// Token: 0x0601B1E0 RID: 111072 RVA: 0x003D76C4 File Offset: 0x003D58C4
		public static void StartIPerformerAiSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601B1E1 RID: 111073 RVA: 0x003D76CE File Offset: 0x003D58CE
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B1E2 RID: 111074 RVA: 0x003D76D9 File Offset: 0x003D58D9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B1E3 RID: 111075 RVA: 0x003D76E4 File Offset: 0x003D58E4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B1E4 RID: 111076 RVA: 0x003D76F4 File Offset: 0x003D58F4
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B1E5 RID: 111077 RVA: 0x003D7704 File Offset: 0x003D5904
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1E6 RID: 111078 RVA: 0x003D773B File Offset: 0x003D593B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1E7 RID: 111079 RVA: 0x003D7755 File Offset: 0x003D5955
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1E8 RID: 111080 RVA: 0x003D7773 File Offset: 0x003D5973
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1E9 RID: 111081 RVA: 0x003D778C File Offset: 0x003D598C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B1EA RID: 111082 RVA: 0x003D7797 File Offset: 0x003D5997
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B1EB RID: 111083 RVA: 0x003D77A8 File Offset: 0x003D59A8
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1EC RID: 111084 RVA: 0x003D77DF File Offset: 0x003D59DF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1ED RID: 111085 RVA: 0x003D77F9 File Offset: 0x003D59F9
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1EE RID: 111086 RVA: 0x003D7817 File Offset: 0x003D5A17
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1EF RID: 111087 RVA: 0x003D7830 File Offset: 0x003D5A30
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1F0 RID: 111088 RVA: 0x003D783B File Offset: 0x003D5A3B
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B1F1 RID: 111089 RVA: 0x003D7846 File Offset: 0x003D5A46
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0601B1F2 RID: 111090 RVA: 0x003D7858 File Offset: 0x003D5A58
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1F3 RID: 111091 RVA: 0x003D788F File Offset: 0x003D5A8F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1F4 RID: 111092 RVA: 0x003D78A9 File Offset: 0x003D5AA9
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1F5 RID: 111093 RVA: 0x003D78C7 File Offset: 0x003D5AC7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1F6 RID: 111094 RVA: 0x003D78E0 File Offset: 0x003D5AE0
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B1F7 RID: 111095 RVA: 0x003D78EB File Offset: 0x003D5AEB
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0601B1F8 RID: 111096 RVA: 0x003D78FC File Offset: 0x003D5AFC
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1F9 RID: 111097 RVA: 0x003D7933 File Offset: 0x003D5B33
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1FA RID: 111098 RVA: 0x003D794D File Offset: 0x003D5B4D
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1FB RID: 111099 RVA: 0x003D796B File Offset: 0x003D5B6B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1FC RID: 111100 RVA: 0x003D7984 File Offset: 0x003D5B84
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1FD RID: 111101 RVA: 0x003D798F File Offset: 0x003D5B8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601B1FE RID: 111102 RVA: 0x003D799A File Offset: 0x003D5B9A
		public static Offset<IPerformerAiSelector> EndIPerformerAiSelector(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSelector>(builder.EndTable());
		}

		// Token: 0x0601B1FF RID: 111103 RVA: 0x003D79A8 File Offset: 0x003D5BA8
		public IPerformerAiSelectorT UnPack()
		{
			IPerformerAiSelectorT performerAiSelectorT = new IPerformerAiSelectorT();
			this.UnPackTo(performerAiSelectorT);
			return performerAiSelectorT;
		}

		// Token: 0x0601B200 RID: 111104 RVA: 0x003D79C4 File Offset: 0x003D5BC4
		public void UnPackTo(IPerformerAiSelectorT _o)
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

		// Token: 0x0601B201 RID: 111105 RVA: 0x003D7D20 File Offset: 0x003D5F20
		public static Offset<IPerformerAiSelector> Pack(FlatBufferBuilder builder, IPerformerAiSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiSelector>);
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
				decorators_typeOffset = IPerformerAiSelector.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiSelector.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TPerformerAiNode[] array3 = new TPerformerAiNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IPerformerAiSelector.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TPerformerAiNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IPerformerAiSelector.CreateChildrenVector(builder, array4);
			}
			return IPerformerAiSelector.CreateIPerformerAiSelector(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, _o.NullMask);
		}

		// Token: 0x0400CB9C RID: 52124
		private Table __p;
	}
}
