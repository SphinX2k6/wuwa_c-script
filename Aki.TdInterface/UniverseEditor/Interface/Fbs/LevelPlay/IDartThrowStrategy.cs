using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200449A RID: 17562
	public struct IDartThrowStrategy : IFlatbufferObject
	{
		// Token: 0x17007BE5 RID: 31717
		// (get) Token: 0x0601A336 RID: 107318 RVA: 0x003BE087 File Offset: 0x003BC287
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A337 RID: 107319 RVA: 0x003BE094 File Offset: 0x003BC294
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A338 RID: 107320 RVA: 0x003BE09C File Offset: 0x003BC29C
		public static IDartThrowStrategy GetRootAsIDartThrowStrategy(ByteBuffer _bb)
		{
			return IDartThrowStrategy.GetRootAsIDartThrowStrategy(_bb, default(IDartThrowStrategy));
		}

		// Token: 0x0601A339 RID: 107321 RVA: 0x003BE0B8 File Offset: 0x003BC2B8
		public static IDartThrowStrategy GetRootAsIDartThrowStrategy(ByteBuffer _bb, IDartThrowStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A33A RID: 107322 RVA: 0x003BE0D5 File Offset: 0x003BC2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A33B RID: 107323 RVA: 0x003BE0E4 File Offset: 0x003BC2E4
		public IDartThrowStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A33C RID: 107324 RVA: 0x003BE0F4 File Offset: 0x003BC2F4
		public TDartboardZone FinalRoundZonesType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BE6 RID: 31718
		// (get) Token: 0x0601A33D RID: 107325 RVA: 0x003BE134 File Offset: 0x003BC334
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

		// Token: 0x0601A33E RID: 107326 RVA: 0x003BE15F File Offset: 0x003BC35F
		public Span<TDartboardZone> GetFinalRoundZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(4, 1);
		}

		// Token: 0x0601A33F RID: 107327 RVA: 0x003BE170 File Offset: 0x003BC370
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

		// Token: 0x0601A340 RID: 107328 RVA: 0x003BE1DC File Offset: 0x003BC3DC
		public TTable? FinalRoundZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BE7 RID: 31719
		// (get) Token: 0x0601A341 RID: 107329 RVA: 0x003BE224 File Offset: 0x003BC424
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

		// Token: 0x0601A342 RID: 107330 RVA: 0x003BE250 File Offset: 0x003BC450
		public TDartboardZone CatchUpZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BE8 RID: 31720
		// (get) Token: 0x0601A343 RID: 107331 RVA: 0x003BE290 File Offset: 0x003BC490
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

		// Token: 0x0601A344 RID: 107332 RVA: 0x003BE2BB File Offset: 0x003BC4BB
		public Span<TDartboardZone> GetCatchUpZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601A345 RID: 107333 RVA: 0x003BE2CC File Offset: 0x003BC4CC
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

		// Token: 0x0601A346 RID: 107334 RVA: 0x003BE338 File Offset: 0x003BC538
		public TTable? CatchUpZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BE9 RID: 31721
		// (get) Token: 0x0601A347 RID: 107335 RVA: 0x003BE380 File Offset: 0x003BC580
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

		// Token: 0x0601A348 RID: 107336 RVA: 0x003BE3AC File Offset: 0x003BC5AC
		public TDartboardZone NormalZonesType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BEA RID: 31722
		// (get) Token: 0x0601A349 RID: 107337 RVA: 0x003BE3EC File Offset: 0x003BC5EC
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

		// Token: 0x0601A34A RID: 107338 RVA: 0x003BE418 File Offset: 0x003BC618
		public Span<TDartboardZone> GetNormalZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(12, 1);
		}

		// Token: 0x0601A34B RID: 107339 RVA: 0x003BE428 File Offset: 0x003BC628
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

		// Token: 0x0601A34C RID: 107340 RVA: 0x003BE494 File Offset: 0x003BC694
		public TTable? NormalZones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BEB RID: 31723
		// (get) Token: 0x0601A34D RID: 107341 RVA: 0x003BE4DC File Offset: 0x003BC6DC
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

		// Token: 0x17007BEC RID: 31724
		// (get) Token: 0x0601A34E RID: 107342 RVA: 0x003BE508 File Offset: 0x003BC708
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

		// Token: 0x0601A34F RID: 107343 RVA: 0x003BE568 File Offset: 0x003BC768
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

		// Token: 0x0601A350 RID: 107344 RVA: 0x003BE5B7 File Offset: 0x003BC7B7
		public static void StartIDartThrowStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A351 RID: 107345 RVA: 0x003BE5C0 File Offset: 0x003BC7C0
		public static void AddFinalRoundZonesType(FlatBufferBuilder builder, VectorOffset finalRoundZonesTypeOffset)
		{
			builder.AddOffset(0, finalRoundZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601A352 RID: 107346 RVA: 0x003BE5D0 File Offset: 0x003BC7D0
		public static VectorOffset CreateFinalRoundZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A353 RID: 107347 RVA: 0x003BE607 File Offset: 0x003BC807
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A354 RID: 107348 RVA: 0x003BE621 File Offset: 0x003BC821
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A355 RID: 107349 RVA: 0x003BE63F File Offset: 0x003BC83F
		public static VectorOffset CreateFinalRoundZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A356 RID: 107350 RVA: 0x003BE658 File Offset: 0x003BC858
		public static void StartFinalRoundZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A357 RID: 107351 RVA: 0x003BE663 File Offset: 0x003BC863
		public static void AddFinalRoundZones(FlatBufferBuilder builder, VectorOffset finalRoundZonesOffset)
		{
			builder.AddOffset(1, finalRoundZonesOffset.Value, 0);
		}

		// Token: 0x0601A358 RID: 107352 RVA: 0x003BE674 File Offset: 0x003BC874
		public static VectorOffset CreateFinalRoundZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A359 RID: 107353 RVA: 0x003BE6AB File Offset: 0x003BC8AB
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A35A RID: 107354 RVA: 0x003BE6C5 File Offset: 0x003BC8C5
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A35B RID: 107355 RVA: 0x003BE6E3 File Offset: 0x003BC8E3
		public static VectorOffset CreateFinalRoundZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A35C RID: 107356 RVA: 0x003BE6FC File Offset: 0x003BC8FC
		public static void StartFinalRoundZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A35D RID: 107357 RVA: 0x003BE707 File Offset: 0x003BC907
		public static void AddCatchUpZonesType(FlatBufferBuilder builder, VectorOffset catchUpZonesTypeOffset)
		{
			builder.AddOffset(2, catchUpZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601A35E RID: 107358 RVA: 0x003BE718 File Offset: 0x003BC918
		public static VectorOffset CreateCatchUpZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A35F RID: 107359 RVA: 0x003BE74F File Offset: 0x003BC94F
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A360 RID: 107360 RVA: 0x003BE769 File Offset: 0x003BC969
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A361 RID: 107361 RVA: 0x003BE787 File Offset: 0x003BC987
		public static VectorOffset CreateCatchUpZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A362 RID: 107362 RVA: 0x003BE7A0 File Offset: 0x003BC9A0
		public static void StartCatchUpZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A363 RID: 107363 RVA: 0x003BE7AB File Offset: 0x003BC9AB
		public static void AddCatchUpZones(FlatBufferBuilder builder, VectorOffset catchUpZonesOffset)
		{
			builder.AddOffset(3, catchUpZonesOffset.Value, 0);
		}

		// Token: 0x0601A364 RID: 107364 RVA: 0x003BE7BC File Offset: 0x003BC9BC
		public static VectorOffset CreateCatchUpZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A365 RID: 107365 RVA: 0x003BE7F3 File Offset: 0x003BC9F3
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A366 RID: 107366 RVA: 0x003BE80D File Offset: 0x003BCA0D
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A367 RID: 107367 RVA: 0x003BE82B File Offset: 0x003BCA2B
		public static VectorOffset CreateCatchUpZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A368 RID: 107368 RVA: 0x003BE844 File Offset: 0x003BCA44
		public static void StartCatchUpZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A369 RID: 107369 RVA: 0x003BE84F File Offset: 0x003BCA4F
		public static void AddNormalZonesType(FlatBufferBuilder builder, VectorOffset normalZonesTypeOffset)
		{
			builder.AddOffset(4, normalZonesTypeOffset.Value, 0);
		}

		// Token: 0x0601A36A RID: 107370 RVA: 0x003BE860 File Offset: 0x003BCA60
		public static VectorOffset CreateNormalZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A36B RID: 107371 RVA: 0x003BE897 File Offset: 0x003BCA97
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A36C RID: 107372 RVA: 0x003BE8B1 File Offset: 0x003BCAB1
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A36D RID: 107373 RVA: 0x003BE8CF File Offset: 0x003BCACF
		public static VectorOffset CreateNormalZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A36E RID: 107374 RVA: 0x003BE8E8 File Offset: 0x003BCAE8
		public static void StartNormalZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A36F RID: 107375 RVA: 0x003BE8F3 File Offset: 0x003BCAF3
		public static void AddNormalZones(FlatBufferBuilder builder, VectorOffset normalZonesOffset)
		{
			builder.AddOffset(5, normalZonesOffset.Value, 0);
		}

		// Token: 0x0601A370 RID: 107376 RVA: 0x003BE904 File Offset: 0x003BCB04
		public static VectorOffset CreateNormalZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A371 RID: 107377 RVA: 0x003BE93B File Offset: 0x003BCB3B
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A372 RID: 107378 RVA: 0x003BE955 File Offset: 0x003BCB55
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A373 RID: 107379 RVA: 0x003BE973 File Offset: 0x003BCB73
		public static VectorOffset CreateNormalZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A374 RID: 107380 RVA: 0x003BE98C File Offset: 0x003BCB8C
		public static void StartNormalZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A375 RID: 107381 RVA: 0x003BE997 File Offset: 0x003BCB97
		public static void AddError(FlatBufferBuilder builder, Offset<IDartStrategyError> errorOffset)
		{
			builder.AddOffset(6, errorOffset.Value, 0);
		}

		// Token: 0x0601A376 RID: 107382 RVA: 0x003BE9A7 File Offset: 0x003BCBA7
		public static Offset<IDartThrowStrategy> EndIDartThrowStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IDartThrowStrategy>(builder.EndTable());
		}

		// Token: 0x0601A377 RID: 107383 RVA: 0x003BE9B4 File Offset: 0x003BCBB4
		public IDartThrowStrategyT UnPack()
		{
			IDartThrowStrategyT dartThrowStrategyT = new IDartThrowStrategyT();
			this.UnPackTo(dartThrowStrategyT);
			return dartThrowStrategyT;
		}

		// Token: 0x0601A378 RID: 107384 RVA: 0x003BE9D0 File Offset: 0x003BCBD0
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

		// Token: 0x0601A379 RID: 107385 RVA: 0x003BEEB0 File Offset: 0x003BD0B0
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

		// Token: 0x0400C4A0 RID: 50336
		private Table __p;
	}
}
