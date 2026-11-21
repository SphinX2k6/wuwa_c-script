using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006506 RID: 25862
	public struct ICommonBtProbability : IFlatbufferObject
	{
		// Token: 0x1700BEAC RID: 48812
		// (get) Token: 0x0602C05F RID: 180319 RVA: 0x005FE44E File Offset: 0x005FC64E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C060 RID: 180320 RVA: 0x005FE45B File Offset: 0x005FC65B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C061 RID: 180321 RVA: 0x005FE464 File Offset: 0x005FC664
		public static ICommonBtProbability GetRootAsICommonBtProbability(ByteBuffer _bb)
		{
			return ICommonBtProbability.GetRootAsICommonBtProbability(_bb, default(ICommonBtProbability));
		}

		// Token: 0x0602C062 RID: 180322 RVA: 0x005FE480 File Offset: 0x005FC680
		public static ICommonBtProbability GetRootAsICommonBtProbability(ByteBuffer _bb, ICommonBtProbability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C063 RID: 180323 RVA: 0x005FE49D File Offset: 0x005FC69D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C064 RID: 180324 RVA: 0x005FE4AC File Offset: 0x005FC6AC
		public ICommonBtProbability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEAD RID: 48813
		// (get) Token: 0x0602C065 RID: 180325 RVA: 0x005FE4BC File Offset: 0x005FC6BC
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

		// Token: 0x1700BEAE RID: 48814
		// (get) Token: 0x0602C066 RID: 180326 RVA: 0x005FE4F8 File Offset: 0x005FC6F8
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

		// Token: 0x1700BEAF RID: 48815
		// (get) Token: 0x0602C067 RID: 180327 RVA: 0x005FE534 File Offset: 0x005FC734
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

		// Token: 0x0602C068 RID: 180328 RVA: 0x005FE56B File Offset: 0x005FC76B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C069 RID: 180329 RVA: 0x005FE57A File Offset: 0x005FC77A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C06A RID: 180330 RVA: 0x005FE588 File Offset: 0x005FC788
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEB0 RID: 48816
		// (get) Token: 0x0602C06B RID: 180331 RVA: 0x005FE5C8 File Offset: 0x005FC7C8
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

		// Token: 0x0602C06C RID: 180332 RVA: 0x005FE5F4 File Offset: 0x005FC7F4
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x0602C06D RID: 180333 RVA: 0x005FE604 File Offset: 0x005FC804
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

		// Token: 0x0602C06E RID: 180334 RVA: 0x005FE670 File Offset: 0x005FC870
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEB1 RID: 48817
		// (get) Token: 0x0602C06F RID: 180335 RVA: 0x005FE6B8 File Offset: 0x005FC8B8
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

		// Token: 0x1700BEB2 RID: 48818
		// (get) Token: 0x0602C070 RID: 180336 RVA: 0x005FE6E4 File Offset: 0x005FC8E4
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602C071 RID: 180337 RVA: 0x005FE724 File Offset: 0x005FC924
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BEB3 RID: 48819
		// (get) Token: 0x0602C072 RID: 180338 RVA: 0x005FE764 File Offset: 0x005FC964
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

		// Token: 0x0602C073 RID: 180339 RVA: 0x005FE790 File Offset: 0x005FC990
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x0602C074 RID: 180340 RVA: 0x005FE7A0 File Offset: 0x005FC9A0
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

		// Token: 0x0602C075 RID: 180341 RVA: 0x005FE80C File Offset: 0x005FCA0C
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BEB4 RID: 48820
		// (get) Token: 0x0602C076 RID: 180342 RVA: 0x005FE854 File Offset: 0x005FCA54
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

		// Token: 0x0602C077 RID: 180343 RVA: 0x005FE880 File Offset: 0x005FCA80
		public float RandomWeights(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BEB5 RID: 48821
		// (get) Token: 0x0602C078 RID: 180344 RVA: 0x005FE8C4 File Offset: 0x005FCAC4
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

		// Token: 0x0602C079 RID: 180345 RVA: 0x005FE8F0 File Offset: 0x005FCAF0
		public Span<float> GetRandomWeightsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0602C07A RID: 180346 RVA: 0x005FE900 File Offset: 0x005FCB00
		public float[] GetRandomWeightsArray()
		{
			return this.__p.__vector_as_array<float>(20);
		}

		// Token: 0x1700BEB6 RID: 48822
		// (get) Token: 0x0602C07B RID: 180347 RVA: 0x005FE910 File Offset: 0x005FCB10
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

		// Token: 0x0602C07C RID: 180348 RVA: 0x005FE950 File Offset: 0x005FCB50
		public static Offset<ICommonBtProbability> CreateICommonBtProbability(FlatBufferBuilder builder, ECommonBtNodeType Type = ECommonBtNodeType.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), VectorOffset Decorators_typeOffset = default(VectorOffset), VectorOffset DecoratorsOffset = default(VectorOffset), bool _foldedForTree = false, VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset RandomWeightsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			ICommonBtProbability.AddRandomWeights(builder, RandomWeightsOffset);
			ICommonBtProbability.AddChildren(builder, ChildrenOffset);
			ICommonBtProbability.AddChildrenType(builder, Children_typeOffset);
			ICommonBtProbability.AddDecorators(builder, DecoratorsOffset);
			ICommonBtProbability.AddDecoratorsType(builder, Decorators_typeOffset);
			ICommonBtProbability.AddDesc(builder, DescOffset);
			ICommonBtProbability.AddId(builder, Id);
			ICommonBtProbability.AddNullMask(builder, NullMask);
			ICommonBtProbability.Add_FoldedForTree(builder, _foldedForTree);
			ICommonBtProbability.AddType(builder, Type);
			return ICommonBtProbability.EndICommonBtProbability(builder);
		}

		// Token: 0x0602C07D RID: 180349 RVA: 0x005FE9B8 File Offset: 0x005FCBB8
		public static void StartICommonBtProbability(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602C07E RID: 180350 RVA: 0x005FE9C2 File Offset: 0x005FCBC2
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C07F RID: 180351 RVA: 0x005FE9CD File Offset: 0x005FCBCD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C080 RID: 180352 RVA: 0x005FE9D8 File Offset: 0x005FCBD8
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0602C081 RID: 180353 RVA: 0x005FE9E8 File Offset: 0x005FCBE8
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x0602C082 RID: 180354 RVA: 0x005FE9F8 File Offset: 0x005FCBF8
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C083 RID: 180355 RVA: 0x005FEA2F File Offset: 0x005FCC2F
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C084 RID: 180356 RVA: 0x005FEA49 File Offset: 0x005FCC49
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C085 RID: 180357 RVA: 0x005FEA67 File Offset: 0x005FCC67
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C086 RID: 180358 RVA: 0x005FEA80 File Offset: 0x005FCC80
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C087 RID: 180359 RVA: 0x005FEA8B File Offset: 0x005FCC8B
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x0602C088 RID: 180360 RVA: 0x005FEA9C File Offset: 0x005FCC9C
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C089 RID: 180361 RVA: 0x005FEAD3 File Offset: 0x005FCCD3
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C08A RID: 180362 RVA: 0x005FEAED File Offset: 0x005FCCED
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C08B RID: 180363 RVA: 0x005FEB0B File Offset: 0x005FCD0B
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C08C RID: 180364 RVA: 0x005FEB24 File Offset: 0x005FCD24
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C08D RID: 180365 RVA: 0x005FEB2F File Offset: 0x005FCD2F
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x0602C08E RID: 180366 RVA: 0x005FEB3A File Offset: 0x005FCD3A
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x0602C08F RID: 180367 RVA: 0x005FEB4C File Offset: 0x005FCD4C
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C090 RID: 180368 RVA: 0x005FEB83 File Offset: 0x005FCD83
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C091 RID: 180369 RVA: 0x005FEB9D File Offset: 0x005FCD9D
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C092 RID: 180370 RVA: 0x005FEBBB File Offset: 0x005FCDBB
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C093 RID: 180371 RVA: 0x005FEBD4 File Offset: 0x005FCDD4
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602C094 RID: 180372 RVA: 0x005FEBDF File Offset: 0x005FCDDF
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x0602C095 RID: 180373 RVA: 0x005FEBF0 File Offset: 0x005FCDF0
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C096 RID: 180374 RVA: 0x005FEC27 File Offset: 0x005FCE27
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C097 RID: 180375 RVA: 0x005FEC41 File Offset: 0x005FCE41
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C098 RID: 180376 RVA: 0x005FEC5F File Offset: 0x005FCE5F
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C099 RID: 180377 RVA: 0x005FEC78 File Offset: 0x005FCE78
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C09A RID: 180378 RVA: 0x005FEC83 File Offset: 0x005FCE83
		public static void AddRandomWeights(FlatBufferBuilder builder, VectorOffset randomWeightsOffset)
		{
			builder.AddOffset(8, randomWeightsOffset.Value, 0);
		}

		// Token: 0x0602C09B RID: 180379 RVA: 0x005FEC94 File Offset: 0x005FCE94
		public static VectorOffset CreateRandomWeightsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C09C RID: 180380 RVA: 0x005FECCB File Offset: 0x005FCECB
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C09D RID: 180381 RVA: 0x005FECE5 File Offset: 0x005FCEE5
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C09E RID: 180382 RVA: 0x005FED03 File Offset: 0x005FCF03
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C09F RID: 180383 RVA: 0x005FED1C File Offset: 0x005FCF1C
		public static void StartRandomWeightsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C0A0 RID: 180384 RVA: 0x005FED27 File Offset: 0x005FCF27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0602C0A1 RID: 180385 RVA: 0x005FED33 File Offset: 0x005FCF33
		public static Offset<ICommonBtProbability> EndICommonBtProbability(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtProbability>(builder.EndTable());
		}

		// Token: 0x0602C0A2 RID: 180386 RVA: 0x005FED40 File Offset: 0x005FCF40
		public ICommonBtProbabilityT UnPack()
		{
			ICommonBtProbabilityT commonBtProbabilityT = new ICommonBtProbabilityT();
			this.UnPackTo(commonBtProbabilityT);
			return commonBtProbabilityT;
		}

		// Token: 0x0602C0A3 RID: 180387 RVA: 0x005FED5C File Offset: 0x005FCF5C
		public void UnPackTo(ICommonBtProbabilityT _o)
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
			_o.RandomWeights = new List<float>();
			for (int k = 0; k < this.RandomWeightsLength; k++)
			{
				_o.RandomWeights.Add(this.RandomWeights(k));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C0A4 RID: 180388 RVA: 0x005FF0E8 File Offset: 0x005FD2E8
		public static Offset<ICommonBtProbability> Pack(FlatBufferBuilder builder, ICommonBtProbabilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtProbability>);
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
				decorators_typeOffset = ICommonBtProbability.CreateDecoratorsTypeVector(builder, array);
			}
			VectorOffset decoratorsOffset = default(VectorOffset);
			if (_o.Decorators != null)
			{
				int[] array2 = new int[_o.Decorators.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCommonBtDecoratorUnion.Pack(builder, _o.Decorators[j]);
				}
				decoratorsOffset = ICommonBtProbability.CreateDecoratorsVector(builder, array2);
			}
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TCommonBtNode[] array3 = new TCommonBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = ICommonBtProbability.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TCommonBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = ICommonBtProbability.CreateChildrenVector(builder, array4);
			}
			VectorOffset randomWeightsOffset = default(VectorOffset);
			if (_o.RandomWeights != null)
			{
				float[] data = _o.RandomWeights.ToArray();
				randomWeightsOffset = ICommonBtProbability.CreateRandomWeightsVector(builder, data);
			}
			return ICommonBtProbability.CreateICommonBtProbability(builder, _o.Type, _o.Id, descOffset, decorators_typeOffset, decoratorsOffset, _o._FoldedForTree, children_typeOffset, childrenOffset, randomWeightsOffset, _o.NullMask);
		}

		// Token: 0x040106A7 RID: 67239
		private Table __p;
	}
}
