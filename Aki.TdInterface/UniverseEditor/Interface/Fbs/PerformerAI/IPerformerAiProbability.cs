using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004372 RID: 17266
	public struct IPerformerAiProbability : IFlatbufferObject
	{
		// Token: 0x170079DA RID: 31194
		// (get) Token: 0x060199E0 RID: 104928 RVA: 0x003AA7F6 File Offset: 0x003A89F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199E1 RID: 104929 RVA: 0x003AA803 File Offset: 0x003A8A03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199E2 RID: 104930 RVA: 0x003AA80C File Offset: 0x003A8A0C
		public static IPerformerAiProbability GetRootAsIPerformerAiProbability(ByteBuffer _bb)
		{
			return IPerformerAiProbability.GetRootAsIPerformerAiProbability(_bb, default(IPerformerAiProbability));
		}

		// Token: 0x060199E3 RID: 104931 RVA: 0x003AA828 File Offset: 0x003A8A28
		public static IPerformerAiProbability GetRootAsIPerformerAiProbability(ByteBuffer _bb, IPerformerAiProbability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199E4 RID: 104932 RVA: 0x003AA845 File Offset: 0x003A8A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199E5 RID: 104933 RVA: 0x003AA854 File Offset: 0x003A8A54
		public IPerformerAiProbability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079DB RID: 31195
		// (get) Token: 0x060199E6 RID: 104934 RVA: 0x003AA864 File Offset: 0x003A8A64
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

		// Token: 0x170079DC RID: 31196
		// (get) Token: 0x060199E7 RID: 104935 RVA: 0x003AA8A0 File Offset: 0x003A8AA0
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

		// Token: 0x170079DD RID: 31197
		// (get) Token: 0x060199E8 RID: 104936 RVA: 0x003AA8DC File Offset: 0x003A8ADC
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

		// Token: 0x060199E9 RID: 104937 RVA: 0x003AA913 File Offset: 0x003A8B13
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060199EA RID: 104938 RVA: 0x003AA922 File Offset: 0x003A8B22
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060199EB RID: 104939 RVA: 0x003AA930 File Offset: 0x003A8B30
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079DE RID: 31198
		// (get) Token: 0x060199EC RID: 104940 RVA: 0x003AA970 File Offset: 0x003A8B70
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

		// Token: 0x060199ED RID: 104941 RVA: 0x003AA99C File Offset: 0x003A8B9C
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x060199EE RID: 104942 RVA: 0x003AA9AC File Offset: 0x003A8BAC
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

		// Token: 0x060199EF RID: 104943 RVA: 0x003AAA18 File Offset: 0x003A8C18
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079DF RID: 31199
		// (get) Token: 0x060199F0 RID: 104944 RVA: 0x003AAA60 File Offset: 0x003A8C60
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

		// Token: 0x170079E0 RID: 31200
		// (get) Token: 0x060199F1 RID: 104945 RVA: 0x003AAA8C File Offset: 0x003A8C8C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x003AAACC File Offset: 0x003A8CCC
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170079E1 RID: 31201
		// (get) Token: 0x060199F3 RID: 104947 RVA: 0x003AAB0C File Offset: 0x003A8D0C
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

		// Token: 0x060199F4 RID: 104948 RVA: 0x003AAB38 File Offset: 0x003A8D38
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x060199F5 RID: 104949 RVA: 0x003AAB48 File Offset: 0x003A8D48
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

		// Token: 0x060199F6 RID: 104950 RVA: 0x003AABB4 File Offset: 0x003A8DB4
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170079E2 RID: 31202
		// (get) Token: 0x060199F7 RID: 104951 RVA: 0x003AABFC File Offset: 0x003A8DFC
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

		// Token: 0x060199F8 RID: 104952 RVA: 0x003AAC28 File Offset: 0x003A8E28
		public float RandomWeights(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170079E3 RID: 31203
		// (get) Token: 0x060199F9 RID: 104953 RVA: 0x003AAC6C File Offset: 0x003A8E6C
		public int RandomWeightsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060199FA RID: 104954 RVA: 0x003AAC98 File Offset: 0x003A8E98
		public Span<float> GetRandomWeightsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x060199FB RID: 104955 RVA: 0x003AACA8 File Offset: 0x003A8EA8
		public float[] GetRandomWeightsArray()
		{
			return this.__p.__vector_as_array<float>(20);
		}

		// Token: 0x170079E4 RID: 31204
		// (get) Token: 0x060199FC RID: 104956 RVA: 0x003AACB8 File Offset: 0x003A8EB8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060199FD RID: 104957 RVA: 0x003AACF8 File Offset: 0x003A8EF8
		public static Offset<IPerformerAiProbability> CreateIPerformerAiProbability(FlatBufferBuilder builder, EPerformerAiNodeType Type = EPerformerAiNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset RandomWeightsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IPerformerAiProbability.AddRandomWeights(builder, RandomWeightsOffset);
			IPerformerAiProbability.AddChildren(builder, ChildrenOffset);
			IPerformerAiProbability.AddChildrenType(builder, Children_typeOffset);
			IPerformerAiProbability.AddDecorators(builder, DecoratorsOffset);
			IPerformerAiProbability.AddDecoratorsType(builder, Decorators_typeOffset);
			IPerformerAiProbability.AddDesc(builder, DescOffset);
			IPerformerAiProbability.AddId(builder, Id);
			IPerformerAiProbability.AddNullMask(builder, NullMask);
			IPerformerAiProbability.Add_FoldedForTree(builder, _foldedForTree);
			IPerformerAiProbability.AddType(builder, Type);
			return IPerformerAiProbability.EndIPerformerAiProbability(builder);
		}

		// Token: 0x060199FE RID: 104958 RVA: 0x003AAD60 File Offset: 0x003A8F60
		public static void StartIPerformerAiProbability(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060199FF RID: 104959 RVA: 0x003AAD6A File Offset: 0x003A8F6A
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019A00 RID: 104960 RVA: 0x003AAD75 File Offset: 0x003A8F75
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019A01 RID: 104961 RVA: 0x003AAD80 File Offset: 0x003A8F80
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06019A02 RID: 104962 RVA: 0x003AAD90 File Offset: 0x003A8F90
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x06019A03 RID: 104963 RVA: 0x003AADA0 File Offset: 0x003A8FA0
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A04 RID: 104964 RVA: 0x003AADD7 File Offset: 0x003A8FD7
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A05 RID: 104965 RVA: 0x003AADF1 File Offset: 0x003A8FF1
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A06 RID: 104966 RVA: 0x003AAE0F File Offset: 0x003A900F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A07 RID: 104967 RVA: 0x003AAE28 File Offset: 0x003A9028
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019A08 RID: 104968 RVA: 0x003AAE33 File Offset: 0x003A9033
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x06019A09 RID: 104969 RVA: 0x003AAE44 File Offset: 0x003A9044
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A0A RID: 104970 RVA: 0x003AAE7B File Offset: 0x003A907B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A0B RID: 104971 RVA: 0x003AAE95 File Offset: 0x003A9095
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A0C RID: 104972 RVA: 0x003AAEB3 File Offset: 0x003A90B3
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A0D RID: 104973 RVA: 0x003AAECC File Offset: 0x003A90CC
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A0E RID: 104974 RVA: 0x003AAED7 File Offset: 0x003A90D7
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x06019A0F RID: 104975 RVA: 0x003AAEE2 File Offset: 0x003A90E2
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06019A10 RID: 104976 RVA: 0x003AAEF4 File Offset: 0x003A90F4
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A11 RID: 104977 RVA: 0x003AAF2B File Offset: 0x003A912B
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A12 RID: 104978 RVA: 0x003AAF45 File Offset: 0x003A9145
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A13 RID: 104979 RVA: 0x003AAF63 File Offset: 0x003A9163
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A14 RID: 104980 RVA: 0x003AAF7C File Offset: 0x003A917C
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06019A15 RID: 104981 RVA: 0x003AAF87 File Offset: 0x003A9187
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x06019A16 RID: 104982 RVA: 0x003AAF98 File Offset: 0x003A9198
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A17 RID: 104983 RVA: 0x003AAFCF File Offset: 0x003A91CF
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A18 RID: 104984 RVA: 0x003AAFE9 File Offset: 0x003A91E9
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A19 RID: 104985 RVA: 0x003AB007 File Offset: 0x003A9207
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A1A RID: 104986 RVA: 0x003AB020 File Offset: 0x003A9220
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A1B RID: 104987 RVA: 0x003AB02B File Offset: 0x003A922B
		public static void AddRandomWeights(FlatBufferBuilder builder, VectorOffset randomWeightsOffset)
		{
			builder.AddOffset(8, randomWeightsOffset.Value, 0);
		}

		// Token: 0x06019A1C RID: 104988 RVA: 0x003AB03C File Offset: 0x003A923C
		public static VectorOffset CreateRandomWeightsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A1D RID: 104989 RVA: 0x003AB073 File Offset: 0x003A9273
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A1E RID: 104990 RVA: 0x003AB08D File Offset: 0x003A928D
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A1F RID: 104991 RVA: 0x003AB0AB File Offset: 0x003A92AB
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A20 RID: 104992 RVA: 0x003AB0C4 File Offset: 0x003A92C4
		public static void StartRandomWeightsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A21 RID: 104993 RVA: 0x003AB0CF File Offset: 0x003A92CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06019A22 RID: 104994 RVA: 0x003AB0DB File Offset: 0x003A92DB
		public static Offset<IPerformerAiProbability> EndIPerformerAiProbability(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiProbability>(builder.EndTable());
		}

		// Token: 0x06019A23 RID: 104995 RVA: 0x003AB0E8 File Offset: 0x003A92E8
		public IPerformerAiProbabilityT UnPack()
		{
			IPerformerAiProbabilityT performerAiProbabilityT = new IPerformerAiProbabilityT();
			this.UnPackTo(performerAiProbabilityT);
			return performerAiProbabilityT;
		}

		// Token: 0x06019A24 RID: 104996 RVA: 0x003AB104 File Offset: 0x003A9304
		public void UnPackTo(IPerformerAiProbabilityT _o)
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
			_o.RandomWeights = new List<float>();
			for (int k = 0; k < this.RandomWeightsLength; k++)
			{
				_o.RandomWeights.Add(this.RandomWeights(k));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019A25 RID: 104997 RVA: 0x003AB490 File Offset: 0x003A9690
		public static Offset<IPerformerAiProbability> Pack(FlatBufferBuilder builder, IPerformerAiProbabilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiProbability>);
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
				decorators_typeOffset = IPerformerAiProbability.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPerformerAiDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = IPerformerAiProbability.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TPerformerAiNode[] array3 = new TPerformerAiNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IPerformerAiProbability.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TPerformerAiNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IPerformerAiProbability.CreateChildrenVector(builder, array4);
			}
			VectorOffset randomWeightsOffset = default(VectorOffset);
			if (_o.RandomWeights != null)
			{
				float[] data = _o.RandomWeights.ToArray();
				randomWeightsOffset = IPerformerAiProbability.CreateRandomWeightsVector(builder, data);
			}
			return IPerformerAiProbability.CreateIPerformerAiProbability(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, randomWeightsOffset, _o.NullMask);
		}

		// Token: 0x0400C175 RID: 49525
		private Table __p;
	}
}
