using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EC3 RID: 24259
	public struct ICommonBtProbability : IFlatbufferObject
	{
		// Token: 0x1700B541 RID: 46401
		// (get) Token: 0x060299AB RID: 170411 RVA: 0x005B4F6A File Offset: 0x005B316A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060299AC RID: 170412 RVA: 0x005B4F77 File Offset: 0x005B3177
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060299AD RID: 170413 RVA: 0x005B4F80 File Offset: 0x005B3180
		public static ICommonBtProbability GetRootAsICommonBtProbability(ByteBuffer _bb)
		{
			return ICommonBtProbability.GetRootAsICommonBtProbability(_bb, default(ICommonBtProbability));
		}

		// Token: 0x060299AE RID: 170414 RVA: 0x005B4F9C File Offset: 0x005B319C
		public static ICommonBtProbability GetRootAsICommonBtProbability(ByteBuffer _bb, ICommonBtProbability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060299AF RID: 170415 RVA: 0x005B4FB9 File Offset: 0x005B31B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060299B0 RID: 170416 RVA: 0x005B4FC8 File Offset: 0x005B31C8
		public ICommonBtProbability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B542 RID: 46402
		// (get) Token: 0x060299B1 RID: 170417 RVA: 0x005B4FD8 File Offset: 0x005B31D8
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

		// Token: 0x1700B543 RID: 46403
		// (get) Token: 0x060299B2 RID: 170418 RVA: 0x005B5014 File Offset: 0x005B3214
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

		// Token: 0x1700B544 RID: 46404
		// (get) Token: 0x060299B3 RID: 170419 RVA: 0x005B5050 File Offset: 0x005B3250
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

		// Token: 0x060299B4 RID: 170420 RVA: 0x005B5087 File Offset: 0x005B3287
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060299B5 RID: 170421 RVA: 0x005B5096 File Offset: 0x005B3296
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060299B6 RID: 170422 RVA: 0x005B50A4 File Offset: 0x005B32A4
		public TCommonBtDecorator DecoratorsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TCommonBtDecorator.NONE;
			}
			return (TCommonBtDecorator)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B545 RID: 46405
		// (get) Token: 0x060299B7 RID: 170423 RVA: 0x005B50E4 File Offset: 0x005B32E4
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

		// Token: 0x060299B8 RID: 170424 RVA: 0x005B5110 File Offset: 0x005B3310
		public Span<TCommonBtDecorator> GetDecoratorsTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtDecorator>(10, 1);
		}

		// Token: 0x060299B9 RID: 170425 RVA: 0x005B5120 File Offset: 0x005B3320
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

		// Token: 0x060299BA RID: 170426 RVA: 0x005B518C File Offset: 0x005B338C
		public TTable? Decorators<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B546 RID: 46406
		// (get) Token: 0x060299BB RID: 170427 RVA: 0x005B51D4 File Offset: 0x005B33D4
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

		// Token: 0x1700B547 RID: 46407
		// (get) Token: 0x060299BC RID: 170428 RVA: 0x005B5200 File Offset: 0x005B3400
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060299BD RID: 170429 RVA: 0x005B5240 File Offset: 0x005B3440
		public TCommonBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return TCommonBtNode.NONE;
			}
			return (TCommonBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B548 RID: 46408
		// (get) Token: 0x060299BE RID: 170430 RVA: 0x005B5280 File Offset: 0x005B3480
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

		// Token: 0x060299BF RID: 170431 RVA: 0x005B52AC File Offset: 0x005B34AC
		public Span<TCommonBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TCommonBtNode>(16, 1);
		}

		// Token: 0x060299C0 RID: 170432 RVA: 0x005B52BC File Offset: 0x005B34BC
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

		// Token: 0x060299C1 RID: 170433 RVA: 0x005B5328 File Offset: 0x005B3528
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B549 RID: 46409
		// (get) Token: 0x060299C2 RID: 170434 RVA: 0x005B5370 File Offset: 0x005B3570
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

		// Token: 0x060299C3 RID: 170435 RVA: 0x005B539C File Offset: 0x005B359C
		public float RandomWeights(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B54A RID: 46410
		// (get) Token: 0x060299C4 RID: 170436 RVA: 0x005B53E0 File Offset: 0x005B35E0
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

		// Token: 0x060299C5 RID: 170437 RVA: 0x005B540C File Offset: 0x005B360C
		public Span<float> GetRandomWeightsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x060299C6 RID: 170438 RVA: 0x005B541C File Offset: 0x005B361C
		public float[] GetRandomWeightsArray()
		{
			return this.__p.__vector_as_array<float>(20);
		}

		// Token: 0x1700B54B RID: 46411
		// (get) Token: 0x060299C7 RID: 170439 RVA: 0x005B542C File Offset: 0x005B362C
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

		// Token: 0x060299C8 RID: 170440 RVA: 0x005B546C File Offset: 0x005B366C
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

		// Token: 0x060299C9 RID: 170441 RVA: 0x005B54D4 File Offset: 0x005B36D4
		public static void StartICommonBtProbability(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060299CA RID: 170442 RVA: 0x005B54DE File Offset: 0x005B36DE
		public static void AddType(FlatBufferBuilder builder, ECommonBtNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060299CB RID: 170443 RVA: 0x005B54E9 File Offset: 0x005B36E9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060299CC RID: 170444 RVA: 0x005B54F4 File Offset: 0x005B36F4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060299CD RID: 170445 RVA: 0x005B5504 File Offset: 0x005B3704
		public static void AddDecoratorsType(FlatBufferBuilder builder, VectorOffset decoratorsTypeOffset)
		{
			builder.AddOffset(3, decoratorsTypeOffset.Value, 0);
		}

		// Token: 0x060299CE RID: 170446 RVA: 0x005B5514 File Offset: 0x005B3714
		public static VectorOffset CreateDecoratorsTypeVector(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299CF RID: 170447 RVA: 0x005B554B File Offset: 0x005B374B
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, TCommonBtDecorator[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D0 RID: 170448 RVA: 0x005B5565 File Offset: 0x005B3765
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtDecorator> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtDecorator>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D1 RID: 170449 RVA: 0x005B5583 File Offset: 0x005B3783
		public static VectorOffset CreateDecoratorsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtDecorator>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299D2 RID: 170450 RVA: 0x005B559C File Offset: 0x005B379C
		public static void StartDecoratorsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060299D3 RID: 170451 RVA: 0x005B55A7 File Offset: 0x005B37A7
		public static void AddDecorators(FlatBufferBuilder builder, VectorOffset decoratorsOffset)
		{
			builder.AddOffset(4, decoratorsOffset.Value, 0);
		}

		// Token: 0x060299D4 RID: 170452 RVA: 0x005B55B8 File Offset: 0x005B37B8
		public static VectorOffset CreateDecoratorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299D5 RID: 170453 RVA: 0x005B55EF File Offset: 0x005B37EF
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D6 RID: 170454 RVA: 0x005B5609 File Offset: 0x005B3809
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D7 RID: 170455 RVA: 0x005B5627 File Offset: 0x005B3827
		public static VectorOffset CreateDecoratorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299D8 RID: 170456 RVA: 0x005B5640 File Offset: 0x005B3840
		public static void StartDecoratorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060299D9 RID: 170457 RVA: 0x005B564B File Offset: 0x005B384B
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(5, _FoldedForTree, false);
		}

		// Token: 0x060299DA RID: 170458 RVA: 0x005B5656 File Offset: 0x005B3856
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(6, childrenTypeOffset.Value, 0);
		}

		// Token: 0x060299DB RID: 170459 RVA: 0x005B5668 File Offset: 0x005B3868
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299DC RID: 170460 RVA: 0x005B569F File Offset: 0x005B389F
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TCommonBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060299DD RID: 170461 RVA: 0x005B56B9 File Offset: 0x005B38B9
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCommonBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCommonBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x060299DE RID: 170462 RVA: 0x005B56D7 File Offset: 0x005B38D7
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCommonBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299DF RID: 170463 RVA: 0x005B56F0 File Offset: 0x005B38F0
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060299E0 RID: 170464 RVA: 0x005B56FB File Offset: 0x005B38FB
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(7, childrenOffset.Value, 0);
		}

		// Token: 0x060299E1 RID: 170465 RVA: 0x005B570C File Offset: 0x005B390C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299E2 RID: 170466 RVA: 0x005B5743 File Offset: 0x005B3943
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299E3 RID: 170467 RVA: 0x005B575D File Offset: 0x005B395D
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299E4 RID: 170468 RVA: 0x005B577B File Offset: 0x005B397B
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299E5 RID: 170469 RVA: 0x005B5794 File Offset: 0x005B3994
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060299E6 RID: 170470 RVA: 0x005B579F File Offset: 0x005B399F
		public static void AddRandomWeights(FlatBufferBuilder builder, VectorOffset randomWeightsOffset)
		{
			builder.AddOffset(8, randomWeightsOffset.Value, 0);
		}

		// Token: 0x060299E7 RID: 170471 RVA: 0x005B57B0 File Offset: 0x005B39B0
		public static VectorOffset CreateRandomWeightsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299E8 RID: 170472 RVA: 0x005B57E7 File Offset: 0x005B39E7
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x060299E9 RID: 170473 RVA: 0x005B5801 File Offset: 0x005B3A01
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x060299EA RID: 170474 RVA: 0x005B581F File Offset: 0x005B3A1F
		public static VectorOffset CreateRandomWeightsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299EB RID: 170475 RVA: 0x005B5838 File Offset: 0x005B3A38
		public static void StartRandomWeightsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060299EC RID: 170476 RVA: 0x005B5843 File Offset: 0x005B3A43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060299ED RID: 170477 RVA: 0x005B584F File Offset: 0x005B3A4F
		public static Offset<ICommonBtProbability> EndICommonBtProbability(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtProbability>(builder.EndTable());
		}

		// Token: 0x060299EE RID: 170478 RVA: 0x005B585C File Offset: 0x005B3A5C
		public ICommonBtProbabilityT UnPack()
		{
			ICommonBtProbabilityT commonBtProbabilityT = new ICommonBtProbabilityT();
			this.UnPackTo(commonBtProbabilityT);
			return commonBtProbabilityT;
		}

		// Token: 0x060299EF RID: 170479 RVA: 0x005B5878 File Offset: 0x005B3A78
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

		// Token: 0x060299F0 RID: 170480 RVA: 0x005B5C04 File Offset: 0x005B3E04
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

		// Token: 0x0400F944 RID: 63812
		private Table __p;
	}
}
