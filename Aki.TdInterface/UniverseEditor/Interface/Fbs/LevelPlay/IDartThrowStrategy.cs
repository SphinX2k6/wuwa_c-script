using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004902 RID: 18690
	public struct IDartThrowStrategy : IFlatbufferObject
	{
		// Token: 0x17008224 RID: 33316
		// (get) Token: 0x0601BB07 RID: 113415 RVA: 0x003EA293 File Offset: 0x003E8493
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BB08 RID: 113416 RVA: 0x003EA2A0 File Offset: 0x003E84A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BB09 RID: 113417 RVA: 0x003EA2A8 File Offset: 0x003E84A8
		public static IDartThrowStrategy GetRootAsIDartThrowStrategy(ByteBuffer _bb)
		{
			return IDartThrowStrategy.GetRootAsIDartThrowStrategy(_bb, default(IDartThrowStrategy));
		}

		// Token: 0x0601BB0A RID: 113418 RVA: 0x003EA2C4 File Offset: 0x003E84C4
		public static IDartThrowStrategy GetRootAsIDartThrowStrategy(ByteBuffer _bb, IDartThrowStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BB0B RID: 113419 RVA: 0x003EA2E1 File Offset: 0x003E84E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BB0C RID: 113420 RVA: 0x003EA2F0 File Offset: 0x003E84F0
		public IDartThrowStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601BB0D RID: 113421 RVA: 0x003EA300 File Offset: 0x003E8500
		public TDartboardZone FinalRoundZonesType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008225 RID: 33317
		// (get) Token: 0x0601BB0E RID: 113422 RVA: 0x003EA340 File Offset: 0x003E8540
		public int FinalRoundZonesTypeLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BB0F RID: 113423 RVA: 0x003EA36B File Offset: 0x003E856B
		public Span<TDartboardZone> GetFinalRoundZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(4, 1);
		}

		// Token: 0x0601BB10 RID: 113424 RVA: 0x003EA37C File Offset: 0x003E857C
		public TDartboardZone[] GetFinalRoundZonesTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TDartboardZone[] array = new TDartboardZone[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TDartboardZone)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601BB11 RID: 113425 RVA: 0x003EA3E8 File Offset: 0x003E85E8
		public TTable? FinalRoundZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008226 RID: 33318
		// (get) Token: 0x0601BB12 RID: 113426 RVA: 0x003EA430 File Offset: 0x003E8630
		public int FinalRoundZonesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BB13 RID: 113427 RVA: 0x003EA45C File Offset: 0x003E865C
		public TDartboardZone CatchUpZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008227 RID: 33319
		// (get) Token: 0x0601BB14 RID: 113428 RVA: 0x003EA49C File Offset: 0x003E869C
		public int CatchUpZonesTypeLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BB15 RID: 113429 RVA: 0x003EA4C7 File Offset: 0x003E86C7
		public Span<TDartboardZone> GetCatchUpZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601BB16 RID: 113430 RVA: 0x003EA4D8 File Offset: 0x003E86D8
		public TDartboardZone[] GetCatchUpZonesTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TDartboardZone[] array = new TDartboardZone[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TDartboardZone)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601BB17 RID: 113431 RVA: 0x003EA544 File Offset: 0x003E8744
		public TTable? CatchUpZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008228 RID: 33320
		// (get) Token: 0x0601BB18 RID: 113432 RVA: 0x003EA58C File Offset: 0x003E878C
		public int CatchUpZonesLength
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

		// Token: 0x0601BB19 RID: 113433 RVA: 0x003EA5B8 File Offset: 0x003E87B8
		public TDartboardZone NormalZonesType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008229 RID: 33321
		// (get) Token: 0x0601BB1A RID: 113434 RVA: 0x003EA5F8 File Offset: 0x003E87F8
		public int NormalZonesTypeLength
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

		// Token: 0x0601BB1B RID: 113435 RVA: 0x003EA624 File Offset: 0x003E8824
		public Span<TDartboardZone> GetNormalZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(12, 1);
		}

		// Token: 0x0601BB1C RID: 113436 RVA: 0x003EA634 File Offset: 0x003E8834
		public TDartboardZone[] GetNormalZonesTypeArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TDartboardZone[] array = new TDartboardZone[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TDartboardZone)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601BB1D RID: 113437 RVA: 0x003EA6A0 File Offset: 0x003E88A0
		public TTable? NormalZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700822A RID: 33322
		// (get) Token: 0x0601BB1E RID: 113438 RVA: 0x003EA6E8 File Offset: 0x003E88E8
		public int NormalZonesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700822B RID: 33323
		// (get) Token: 0x0601BB1F RID: 113439 RVA: 0x003EA714 File Offset: 0x003E8914
		public IDartStrategyError? Error
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IDartStrategyError?(default(IDartStrategyError).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601BB20 RID: 113440 RVA: 0x003EA774 File Offset: 0x003E8974
		public static Offset<IDartThrowStrategy> CreateIDartThrowStrategy(FlatBufferBuilder builder, VectorOffset FinalRoundZones_typeOffset = default(VectorOffset), VectorOffset FinalRoundZonesOffset = default(VectorOffset), VectorOffset CatchUpZones_typeOffset = default(VectorOffset), VectorOffset CatchUpZonesOffset = default(VectorOffset), VectorOffset NormalZones_typeOffset = default(VectorOffset), VectorOffset NormalZonesOffset = default(VectorOffset), Offset<IDartStrategyError> ErrorOffset = default(Offset<IDartStrategyError>))
		{
			builder.StartTable(7);
			IDartThrowStrategy.AddError(builder, ErrorOffset);
			IDartThrowStrategy.AddNormalZones(builder, NormalZonesOffset);
			IDartThrowStrategy.AddNormalZonesType(builder, NormalZones_typeOffset);
			IDartThrowStrategy.AddCatchUpZones(builder, CatchUpZonesOffset);
			IDartThrowStrategy.AddCatchUpZonesType(builder, CatchUpZones_typeOffset);
			IDartThrowStrategy.AddFinalRoundZones(builder, FinalRoundZonesOffset);
			IDartThrowStrategy.AddFinalRoundZonesType(builder, FinalRoundZones_typeOffset);
			return IDartThrowStrategy.EndIDartThrowStrategy(builder);
		}

		// Token: 0x0601BB21 RID: 113441 RVA: 0x003EA7C3 File Offset: 0x003E89C3
		public static void StartIDartThrowStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601BB22 RID: 113442 RVA: 0x003EA7CC File Offset: 0x003E89CC
		public static void AddFinalRoundZonesType(FlatBufferBuilder builder, VectorOffset finalRoundZonesTypeOffset)
		{
			builder.AddOffset(0, finalRoundZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601BB23 RID: 113443 RVA: 0x003EA7DC File Offset: 0x003E89DC
		public static VectorOffset CreateFinalRoundZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB24 RID: 113444 RVA: 0x003EA813 File Offset: 0x003E8A13
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x003EA82D File Offset: 0x003E8A2D
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB26 RID: 113446 RVA: 0x003EA84B File Offset: 0x003E8A4B
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB27 RID: 113447 RVA: 0x003EA864 File Offset: 0x003E8A64
		public static void StartFinalRoundZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BB28 RID: 113448 RVA: 0x003EA86F File Offset: 0x003E8A6F
		public static void AddFinalRoundZones(FlatBufferBuilder builder, VectorOffset finalRoundZonesOffset)
		{
			builder.AddOffset(1, finalRoundZonesOffset.Value, 0);
		}

		// Token: 0x0601BB29 RID: 113449 RVA: 0x003EA880 File Offset: 0x003E8A80
		public static VectorOffset CreateFinalRoundZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB2A RID: 113450 RVA: 0x003EA8B7 File Offset: 0x003E8AB7
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB2B RID: 113451 RVA: 0x003EA8D1 File Offset: 0x003E8AD1
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB2C RID: 113452 RVA: 0x003EA8EF File Offset: 0x003E8AEF
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB2D RID: 113453 RVA: 0x003EA908 File Offset: 0x003E8B08
		public static void StartFinalRoundZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BB2E RID: 113454 RVA: 0x003EA913 File Offset: 0x003E8B13
		public static void AddCatchUpZonesType(FlatBufferBuilder builder, VectorOffset catchUpZonesTypeOffset)
		{
			builder.AddOffset(2, catchUpZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601BB2F RID: 113455 RVA: 0x003EA924 File Offset: 0x003E8B24
		public static VectorOffset CreateCatchUpZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB30 RID: 113456 RVA: 0x003EA95B File Offset: 0x003E8B5B
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB31 RID: 113457 RVA: 0x003EA975 File Offset: 0x003E8B75
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB32 RID: 113458 RVA: 0x003EA993 File Offset: 0x003E8B93
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB33 RID: 113459 RVA: 0x003EA9AC File Offset: 0x003E8BAC
		public static void StartCatchUpZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BB34 RID: 113460 RVA: 0x003EA9B7 File Offset: 0x003E8BB7
		public static void AddCatchUpZones(FlatBufferBuilder builder, VectorOffset catchUpZonesOffset)
		{
			builder.AddOffset(3, catchUpZonesOffset.Value, 0);
		}

		// Token: 0x0601BB35 RID: 113461 RVA: 0x003EA9C8 File Offset: 0x003E8BC8
		public static VectorOffset CreateCatchUpZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB36 RID: 113462 RVA: 0x003EA9FF File Offset: 0x003E8BFF
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB37 RID: 113463 RVA: 0x003EAA19 File Offset: 0x003E8C19
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB38 RID: 113464 RVA: 0x003EAA37 File Offset: 0x003E8C37
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB39 RID: 113465 RVA: 0x003EAA50 File Offset: 0x003E8C50
		public static void StartCatchUpZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BB3A RID: 113466 RVA: 0x003EAA5B File Offset: 0x003E8C5B
		public static void AddNormalZonesType(FlatBufferBuilder builder, VectorOffset normalZonesTypeOffset)
		{
			builder.AddOffset(4, normalZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601BB3B RID: 113467 RVA: 0x003EAA6C File Offset: 0x003E8C6C
		public static VectorOffset CreateNormalZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB3C RID: 113468 RVA: 0x003EAAA3 File Offset: 0x003E8CA3
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB3D RID: 113469 RVA: 0x003EAABD File Offset: 0x003E8CBD
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB3E RID: 113470 RVA: 0x003EAADB File Offset: 0x003E8CDB
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB3F RID: 113471 RVA: 0x003EAAF4 File Offset: 0x003E8CF4
		public static void StartNormalZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BB40 RID: 113472 RVA: 0x003EAAFF File Offset: 0x003E8CFF
		public static void AddNormalZones(FlatBufferBuilder builder, VectorOffset normalZonesOffset)
		{
			builder.AddOffset(5, normalZonesOffset.Value, 0);
		}

		// Token: 0x0601BB41 RID: 113473 RVA: 0x003EAB10 File Offset: 0x003E8D10
		public static VectorOffset CreateNormalZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BB42 RID: 113474 RVA: 0x003EAB47 File Offset: 0x003E8D47
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB43 RID: 113475 RVA: 0x003EAB61 File Offset: 0x003E8D61
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BB44 RID: 113476 RVA: 0x003EAB7F File Offset: 0x003E8D7F
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BB45 RID: 113477 RVA: 0x003EAB98 File Offset: 0x003E8D98
		public static void StartNormalZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BB46 RID: 113478 RVA: 0x003EABA3 File Offset: 0x003E8DA3
		public static void AddError(FlatBufferBuilder builder, Offset<IDartStrategyError> errorOffset)
		{
			builder.AddOffset(6, errorOffset.Value, 0);
		}

		// Token: 0x0601BB47 RID: 113479 RVA: 0x003EABB3 File Offset: 0x003E8DB3
		public static Offset<IDartThrowStrategy> EndIDartThrowStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IDartThrowStrategy>(builder.EndTable());
		}

		// Token: 0x0601BB48 RID: 113480 RVA: 0x003EABC0 File Offset: 0x003E8DC0
		public IDartThrowStrategyT UnPack()
		{
			IDartThrowStrategyT dartThrowStrategyT = new IDartThrowStrategyT();
			this.UnPackTo(dartThrowStrategyT);
			return dartThrowStrategyT;
		}

		// Token: 0x0601BB49 RID: 113481 RVA: 0x003EABDC File Offset: 0x003E8DDC
		public void UnPackTo(IDartThrowStrategyT _o)
		{
			_o.FinalRoundZones = new List<TDartboardZoneUnion>();
			for (int i = 0; i < this.FinalRoundZonesLength; i++)
			{
				TDartboardZoneUnion tdartboardZoneUnion = new TDartboardZoneUnion();
				tdartboardZoneUnion.Type = this.FinalRoundZonesType(i);
				switch (this.FinalRoundZonesType(i))
				{
				case TDartboardZone.ICenterBullZone:
					tdartboardZoneUnion.Value = ((this.FinalRoundZones<ICenterBullZone>(i) != null) ? this.FinalRoundZones<ICenterBullZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.IDoubleScoreZone:
					tdartboardZoneUnion.Value = ((this.FinalRoundZones<IDoubleScoreZone>(i) != null) ? this.FinalRoundZones<IDoubleScoreZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.IOuterBullZone:
					tdartboardZoneUnion.Value = ((this.FinalRoundZones<IOuterBullZone>(i) != null) ? this.FinalRoundZones<IOuterBullZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.ISingleScoreZone:
					tdartboardZoneUnion.Value = ((this.FinalRoundZones<ISingleScoreZone>(i) != null) ? this.FinalRoundZones<ISingleScoreZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.ITripleScoreZone:
					tdartboardZoneUnion.Value = ((this.FinalRoundZones<ITripleScoreZone>(i) != null) ? this.FinalRoundZones<ITripleScoreZone>(i).Value.UnPack() : null);
					break;
				}
				_o.FinalRoundZones.Add(tdartboardZoneUnion);
			}
			_o.CatchUpZones = new List<TDartboardZoneUnion>();
			for (int j = 0; j < this.CatchUpZonesLength; j++)
			{
				TDartboardZoneUnion tdartboardZoneUnion2 = new TDartboardZoneUnion();
				tdartboardZoneUnion2.Type = this.CatchUpZonesType(j);
				switch (this.CatchUpZonesType(j))
				{
				case TDartboardZone.ICenterBullZone:
					tdartboardZoneUnion2.Value = ((this.CatchUpZones<ICenterBullZone>(j) != null) ? this.CatchUpZones<ICenterBullZone>(j).Value.UnPack() : null);
					break;
				case TDartboardZone.IDoubleScoreZone:
					tdartboardZoneUnion2.Value = ((this.CatchUpZones<IDoubleScoreZone>(j) != null) ? this.CatchUpZones<IDoubleScoreZone>(j).Value.UnPack() : null);
					break;
				case TDartboardZone.IOuterBullZone:
					tdartboardZoneUnion2.Value = ((this.CatchUpZones<IOuterBullZone>(j) != null) ? this.CatchUpZones<IOuterBullZone>(j).Value.UnPack() : null);
					break;
				case TDartboardZone.ISingleScoreZone:
					tdartboardZoneUnion2.Value = ((this.CatchUpZones<ISingleScoreZone>(j) != null) ? this.CatchUpZones<ISingleScoreZone>(j).Value.UnPack() : null);
					break;
				case TDartboardZone.ITripleScoreZone:
					tdartboardZoneUnion2.Value = ((this.CatchUpZones<ITripleScoreZone>(j) != null) ? this.CatchUpZones<ITripleScoreZone>(j).Value.UnPack() : null);
					break;
				}
				_o.CatchUpZones.Add(tdartboardZoneUnion2);
			}
			_o.NormalZones = new List<TDartboardZoneUnion>();
			for (int k = 0; k < this.NormalZonesLength; k++)
			{
				TDartboardZoneUnion tdartboardZoneUnion3 = new TDartboardZoneUnion();
				tdartboardZoneUnion3.Type = this.NormalZonesType(k);
				switch (this.NormalZonesType(k))
				{
				case TDartboardZone.ICenterBullZone:
					tdartboardZoneUnion3.Value = ((this.NormalZones<ICenterBullZone>(k) != null) ? this.NormalZones<ICenterBullZone>(k).Value.UnPack() : null);
					break;
				case TDartboardZone.IDoubleScoreZone:
					tdartboardZoneUnion3.Value = ((this.NormalZones<IDoubleScoreZone>(k) != null) ? this.NormalZones<IDoubleScoreZone>(k).Value.UnPack() : null);
					break;
				case TDartboardZone.IOuterBullZone:
					tdartboardZoneUnion3.Value = ((this.NormalZones<IOuterBullZone>(k) != null) ? this.NormalZones<IOuterBullZone>(k).Value.UnPack() : null);
					break;
				case TDartboardZone.ISingleScoreZone:
					tdartboardZoneUnion3.Value = ((this.NormalZones<ISingleScoreZone>(k) != null) ? this.NormalZones<ISingleScoreZone>(k).Value.UnPack() : null);
					break;
				case TDartboardZone.ITripleScoreZone:
					tdartboardZoneUnion3.Value = ((this.NormalZones<ITripleScoreZone>(k) != null) ? this.NormalZones<ITripleScoreZone>(k).Value.UnPack() : null);
					break;
				}
				_o.NormalZones.Add(tdartboardZoneUnion3);
			}
			_o.Error = ((this.Error != null) ? this.Error.Value.UnPack() : null);
		}

		// Token: 0x0601BB4A RID: 113482 RVA: 0x003EB0BC File Offset: 0x003E92BC
		public static Offset<IDartThrowStrategy> Pack(FlatBufferBuilder builder, IDartThrowStrategyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartThrowStrategy>);
			}
			VectorOffset finalRoundZones_typeOffset = default(VectorOffset);
			if (_o.FinalRoundZones != null)
			{
				TDartboardZone[] array = new TDartboardZone[_o.FinalRoundZones.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.FinalRoundZones[i].Type;
				}
				finalRoundZones_typeOffset = IDartThrowStrategy.CreateFinalRoundZonesTypeVector(builder, array);
			}
			VectorOffset finalRoundZonesOffset = default(VectorOffset);
			if (_o.FinalRoundZones != null)
			{
				int[] array2 = new int[_o.FinalRoundZones.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartboardZoneUnion.Pack(builder, _o.FinalRoundZones[j]);
				}
				finalRoundZonesOffset = IDartThrowStrategy.CreateFinalRoundZonesVector(builder, array2);
			}
			VectorOffset catchUpZones_typeOffset = default(VectorOffset);
			if (_o.CatchUpZones != null)
			{
				TDartboardZone[] array3 = new TDartboardZone[_o.CatchUpZones.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.CatchUpZones[k].Type;
				}
				catchUpZones_typeOffset = IDartThrowStrategy.CreateCatchUpZonesTypeVector(builder, array3);
			}
			VectorOffset catchUpZonesOffset = default(VectorOffset);
			if (_o.CatchUpZones != null)
			{
				int[] array4 = new int[_o.CatchUpZones.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TDartboardZoneUnion.Pack(builder, _o.CatchUpZones[l]);
				}
				catchUpZonesOffset = IDartThrowStrategy.CreateCatchUpZonesVector(builder, array4);
			}
			VectorOffset normalZones_typeOffset = default(VectorOffset);
			if (_o.NormalZones != null)
			{
				TDartboardZone[] array5 = new TDartboardZone[_o.NormalZones.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = _o.NormalZones[m].Type;
				}
				normalZones_typeOffset = IDartThrowStrategy.CreateNormalZonesTypeVector(builder, array5);
			}
			VectorOffset normalZonesOffset = default(VectorOffset);
			if (_o.NormalZones != null)
			{
				int[] array6 = new int[_o.NormalZones.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = TDartboardZoneUnion.Pack(builder, _o.NormalZones[n]);
				}
				normalZonesOffset = IDartThrowStrategy.CreateNormalZonesVector(builder, array6);
			}
			Offset<IDartStrategyError> errorOffset = (_o.Error == null) ? default(Offset<IDartStrategyError>) : IDartStrategyError.Pack(builder, _o.Error);
			return IDartThrowStrategy.CreateIDartThrowStrategy(builder, finalRoundZones_typeOffset, finalRoundZonesOffset, catchUpZones_typeOffset, catchUpZonesOffset, normalZones_typeOffset, normalZonesOffset, errorOffset);
		}

		// Token: 0x0400CECE RID: 52942
		private Table __p;
	}
}
