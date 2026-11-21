using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D4 RID: 18388
	public struct IPerformerAiProbability : IFlatbufferObject
	{
		// Token: 0x1700800F RID: 32783
		// (get) Token: 0x0601B16E RID: 110958 RVA: 0x003D621E File Offset: 0x003D441E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x003D622B File Offset: 0x003D442B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B170 RID: 110960 RVA: 0x003D6234 File Offset: 0x003D4434
		public static IPerformerAiProbability GetRootAsIPerformerAiProbability(ByteBuffer _bb)
		{
			return IPerformerAiProbability.GetRootAsIPerformerAiProbability(_bb, default(IPerformerAiProbability));
		}

		// Token: 0x0601B171 RID: 110961 RVA: 0x003D6250 File Offset: 0x003D4450
		public static IPerformerAiProbability GetRootAsIPerformerAiProbability(ByteBuffer _bb, IPerformerAiProbability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B172 RID: 110962 RVA: 0x003D626D File Offset: 0x003D446D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B173 RID: 110963 RVA: 0x003D627C File Offset: 0x003D447C
		public IPerformerAiProbability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008010 RID: 32784
		// (get) Token: 0x0601B174 RID: 110964 RVA: 0x003D628C File Offset: 0x003D448C
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

		// Token: 0x17008011 RID: 32785
		// (get) Token: 0x0601B175 RID: 110965 RVA: 0x003D62C8 File Offset: 0x003D44C8
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

		// Token: 0x17008012 RID: 32786
		// (get) Token: 0x0601B176 RID: 110966 RVA: 0x003D6304 File Offset: 0x003D4504
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

		// Token: 0x0601B177 RID: 110967 RVA: 0x003D633B File Offset: 0x003D453B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B178 RID: 110968 RVA: 0x003D634A File Offset: 0x003D454A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B179 RID: 110969 RVA: 0x003D6358 File Offset: 0x003D4558
		public TPerformerAiDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TPerformerAiDecorator.NONE;
			}
			return (TPerformerAiDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008013 RID: 32787
		// (get) Token: 0x0601B17A RID: 110970 RVA: 0x003D6398 File Offset: 0x003D4598
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

		// Token: 0x0601B17B RID: 110971 RVA: 0x003D63C4 File Offset: 0x003D45C4
		public Span<TPerformerAiDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiDecorator>(10, 1);
		}

		// Token: 0x0601B17C RID: 110972 RVA: 0x003D63D4 File Offset: 0x003D45D4
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

		// Token: 0x0601B17D RID: 110973 RVA: 0x003D6440 File Offset: 0x003D4640
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008014 RID: 32788
		// (get) Token: 0x0601B17E RID: 110974 RVA: 0x003D6488 File Offset: 0x003D4688
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

		// Token: 0x17008015 RID: 32789
		// (get) Token: 0x0601B17F RID: 110975 RVA: 0x003D64B4 File Offset: 0x003D46B4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601B180 RID: 110976 RVA: 0x003D64F4 File Offset: 0x003D46F4
		public TPerformerAiNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TPerformerAiNode.NONE;
			}
			return (TPerformerAiNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008016 RID: 32790
		// (get) Token: 0x0601B181 RID: 110977 RVA: 0x003D6534 File Offset: 0x003D4734
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

		// Token: 0x0601B182 RID: 110978 RVA: 0x003D6560 File Offset: 0x003D4760
		public Span<TPerformerAiNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TPerformerAiNode>(16, 1);
		}

		// Token: 0x0601B183 RID: 110979 RVA: 0x003D6570 File Offset: 0x003D4770
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

		// Token: 0x0601B184 RID: 110980 RVA: 0x003D65DC File Offset: 0x003D47DC
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008017 RID: 32791
		// (get) Token: 0x0601B185 RID: 110981 RVA: 0x003D6624 File Offset: 0x003D4824
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

		// Token: 0x0601B186 RID: 110982 RVA: 0x003D6650 File Offset: 0x003D4850
		public float RandomWeights(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008018 RID: 32792
		// (get) Token: 0x0601B187 RID: 110983 RVA: 0x003D6694 File Offset: 0x003D4894
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

		// Token: 0x0601B188 RID: 110984 RVA: 0x003D66C0 File Offset: 0x003D48C0
		public Span<float> GetRandomWeightsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0601B189 RID: 110985 RVA: 0x003D66D0 File Offset: 0x003D48D0
		public float[] GetRandomWeightsArray()
		{
			return this.__p.__vector_as_array<float>(20);
		}

		// Token: 0x17008019 RID: 32793
		// (get) Token: 0x0601B18A RID: 110986 RVA: 0x003D66E0 File Offset: 0x003D48E0
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

		// Token: 0x0601B18B RID: 110987 RVA: 0x003D6720 File Offset: 0x003D4920
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

		// Token: 0x0601B18C RID: 110988 RVA: 0x003D6788 File Offset: 0x003D4988
		public static void StartIPerformerAiProbability(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601B18D RID: 110989 RVA: 0x003D6792 File Offset: 0x003D4992
		public static void AddType(FlatBufferBuilder builder, EPerformerAiNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B18E RID: 110990 RVA: 0x003D679D File Offset: 0x003D499D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B18F RID: 110991 RVA: 0x003D67A8 File Offset: 0x003D49A8
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601B190 RID: 110992 RVA: 0x003D67B8 File Offset: 0x003D49B8
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0601B191 RID: 110993 RVA: 0x003D67C8 File Offset: 0x003D49C8
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B192 RID: 110994 RVA: 0x003D67FF File Offset: 0x003D49FF
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B193 RID: 110995 RVA: 0x003D6819 File Offset: 0x003D4A19
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B194 RID: 110996 RVA: 0x003D6837 File Offset: 0x003D4A37
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B195 RID: 110997 RVA: 0x003D6850 File Offset: 0x003D4A50
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B196 RID: 110998 RVA: 0x003D685B File Offset: 0x003D4A5B
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0601B197 RID: 110999 RVA: 0x003D686C File Offset: 0x003D4A6C
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B198 RID: 111000 RVA: 0x003D68A3 File Offset: 0x003D4AA3
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B199 RID: 111001 RVA: 0x003D68BD File Offset: 0x003D4ABD
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B19A RID: 111002 RVA: 0x003D68DB File Offset: 0x003D4ADB
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B19B RID: 111003 RVA: 0x003D68F4 File Offset: 0x003D4AF4
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B19C RID: 111004 RVA: 0x003D68FF File Offset: 0x003D4AFF
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0601B19D RID: 111005 RVA: 0x003D690A File Offset: 0x003D4B0A
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0601B19E RID: 111006 RVA: 0x003D691C File Offset: 0x003D4B1C
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B19F RID: 111007 RVA: 0x003D6953 File Offset: 0x003D4B53
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TPerformerAiNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1A0 RID: 111008 RVA: 0x003D696D File Offset: 0x003D4B6D
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPerformerAiNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPerformerAiNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1A1 RID: 111009 RVA: 0x003D698B File Offset: 0x003D4B8B
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPerformerAiNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1A2 RID: 111010 RVA: 0x003D69A4 File Offset: 0x003D4BA4
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B1A3 RID: 111011 RVA: 0x003D69AF File Offset: 0x003D4BAF
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0601B1A4 RID: 111012 RVA: 0x003D69C0 File Offset: 0x003D4BC0
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1A5 RID: 111013 RVA: 0x003D69F7 File Offset: 0x003D4BF7
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1A6 RID: 111014 RVA: 0x003D6A11 File Offset: 0x003D4C11
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1A7 RID: 111015 RVA: 0x003D6A2F File Offset: 0x003D4C2F
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1A8 RID: 111016 RVA: 0x003D6A48 File Offset: 0x003D4C48
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1A9 RID: 111017 RVA: 0x003D6A53 File Offset: 0x003D4C53
		public static void AddRandomWeights(FlatBufferBuilder builder, VectorOffset randomWeightsOffset)
		{
			builder.AddOffset(8, randomWeightsOffset.Value, 0);
		}

		// Token: 0x0601B1AA RID: 111018 RVA: 0x003D6A64 File Offset: 0x003D4C64
		public static VectorOffset CreateRandomWeightsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B1AB RID: 111019 RVA: 0x003D6A9B File Offset: 0x003D4C9B
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1AC RID: 111020 RVA: 0x003D6AB5 File Offset: 0x003D4CB5
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B1AD RID: 111021 RVA: 0x003D6AD3 File Offset: 0x003D4CD3
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B1AE RID: 111022 RVA: 0x003D6AEC File Offset: 0x003D4CEC
		public static void StartRandomWeightsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B1AF RID: 111023 RVA: 0x003D6AF7 File Offset: 0x003D4CF7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601B1B0 RID: 111024 RVA: 0x003D6B03 File Offset: 0x003D4D03
		public static Offset<IPerformerAiProbability> EndIPerformerAiProbability(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiProbability>(builder.EndTable());
		}

		// Token: 0x0601B1B1 RID: 111025 RVA: 0x003D6B10 File Offset: 0x003D4D10
		public IPerformerAiProbabilityT UnPack()
		{
			IPerformerAiProbabilityT performerAiProbabilityT = new IPerformerAiProbabilityT();
			this.UnPackTo(performerAiProbabilityT);
			return performerAiProbabilityT;
		}

		// Token: 0x0601B1B2 RID: 111026 RVA: 0x003D6B2C File Offset: 0x003D4D2C
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

		// Token: 0x0601B1B3 RID: 111027 RVA: 0x003D6EB8 File Offset: 0x003D50B8
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

		// Token: 0x0400CB93 RID: 52115
		private Table __p;
	}
}
