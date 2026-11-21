using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FF RID: 18687
	public struct IDartStrategyError : IFlatbufferObject
	{
		// Token: 0x1700821E RID: 33310
		// (get) Token: 0x0601BAE1 RID: 113377 RVA: 0x003E9C1B File Offset: 0x003E7E1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BAE2 RID: 113378 RVA: 0x003E9C28 File Offset: 0x003E7E28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BAE3 RID: 113379 RVA: 0x003E9C30 File Offset: 0x003E7E30
		public static IDartStrategyError GetRootAsIDartStrategyError(ByteBuffer _bb)
		{
			return IDartStrategyError.GetRootAsIDartStrategyError(_bb, default(IDartStrategyError));
		}

		// Token: 0x0601BAE4 RID: 113380 RVA: 0x003E9C4C File Offset: 0x003E7E4C
		public static IDartStrategyError GetRootAsIDartStrategyError(ByteBuffer _bb, IDartStrategyError obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BAE5 RID: 113381 RVA: 0x003E9C69 File Offset: 0x003E7E69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BAE6 RID: 113382 RVA: 0x003E9C78 File Offset: 0x003E7E78
		public IDartStrategyError __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700821F RID: 33311
		// (get) Token: 0x0601BAE7 RID: 113383 RVA: 0x003E9C88 File Offset: 0x003E7E88
		public int Probability
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAE8 RID: 113384 RVA: 0x003E9CC4 File Offset: 0x003E7EC4
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008220 RID: 33312
		// (get) Token: 0x0601BAE9 RID: 113385 RVA: 0x003E9D04 File Offset: 0x003E7F04
		public int ZonesTypeLength
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

		// Token: 0x0601BAEA RID: 113386 RVA: 0x003E9D2F File Offset: 0x003E7F2F
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(6, 1);
		}

		// Token: 0x0601BAEB RID: 113387 RVA: 0x003E9D40 File Offset: 0x003E7F40
		public TDartboardZone[] GetZonesTypeArray()
		{
			int num = this.__p.__offset(6);
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

		// Token: 0x0601BAEC RID: 113388 RVA: 0x003E9DAC File Offset: 0x003E7FAC
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008221 RID: 33313
		// (get) Token: 0x0601BAED RID: 113389 RVA: 0x003E9DF4 File Offset: 0x003E7FF4
		public int ZonesLength
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

		// Token: 0x0601BAEE RID: 113390 RVA: 0x003E9E1F File Offset: 0x003E801F
		public static Offset<IDartStrategyError> CreateIDartStrategyError(FlatBufferBuilder builder, int Probability = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDartStrategyError.AddZones(builder, ZonesOffset);
			IDartStrategyError.AddZonesType(builder, Zones_typeOffset);
			IDartStrategyError.AddProbability(builder, Probability);
			return IDartStrategyError.EndIDartStrategyError(builder);
		}

		// Token: 0x0601BAEF RID: 113391 RVA: 0x003E9E43 File Offset: 0x003E8043
		public static void StartIDartStrategyError(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BAF0 RID: 113392 RVA: 0x003E9E4C File Offset: 0x003E804C
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601BAF1 RID: 113393 RVA: 0x003E9E57 File Offset: 0x003E8057
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(1, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601BAF2 RID: 113394 RVA: 0x003E9E68 File Offset: 0x003E8068
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BAF3 RID: 113395 RVA: 0x003E9E9F File Offset: 0x003E809F
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x003E9EB9 File Offset: 0x003E80B9
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BAF5 RID: 113397 RVA: 0x003E9ED7 File Offset: 0x003E80D7
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BAF6 RID: 113398 RVA: 0x003E9EF0 File Offset: 0x003E80F0
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BAF7 RID: 113399 RVA: 0x003E9EFB File Offset: 0x003E80FB
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(2, zonesOffset.Value, 0);
		}

		// Token: 0x0601BAF8 RID: 113400 RVA: 0x003E9F0C File Offset: 0x003E810C
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BAF9 RID: 113401 RVA: 0x003E9F43 File Offset: 0x003E8143
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BAFA RID: 113402 RVA: 0x003E9F5D File Offset: 0x003E815D
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BAFB RID: 113403 RVA: 0x003E9F7B File Offset: 0x003E817B
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BAFC RID: 113404 RVA: 0x003E9F94 File Offset: 0x003E8194
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x003E9F9F File Offset: 0x003E819F
		public static Offset<IDartStrategyError> EndIDartStrategyError(FlatBufferBuilder builder)
		{
			return new Offset<IDartStrategyError>(builder.EndTable());
		}

		// Token: 0x0601BAFE RID: 113406 RVA: 0x003E9FAC File Offset: 0x003E81AC
		public IDartStrategyErrorT UnPack()
		{
			IDartStrategyErrorT dartStrategyErrorT = new IDartStrategyErrorT();
			this.UnPackTo(dartStrategyErrorT);
			return dartStrategyErrorT;
		}

		// Token: 0x0601BAFF RID: 113407 RVA: 0x003E9FC8 File Offset: 0x003E81C8
		public void UnPackTo(IDartStrategyErrorT _o)
		{
			_o.Probability = this.Probability;
			_o.Zones = new List<TDartboardZoneUnion>();
			for (int i = 0; i < this.ZonesLength; i++)
			{
				TDartboardZoneUnion tdartboardZoneUnion = new TDartboardZoneUnion();
				tdartboardZoneUnion.Type = this.ZonesType(i);
				switch (this.ZonesType(i))
				{
				case TDartboardZone.ICenterBullZone:
					tdartboardZoneUnion.Value = ((this.Zones<ICenterBullZone>(i) != null) ? this.Zones<ICenterBullZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.IDoubleScoreZone:
					tdartboardZoneUnion.Value = ((this.Zones<IDoubleScoreZone>(i) != null) ? this.Zones<IDoubleScoreZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.IOuterBullZone:
					tdartboardZoneUnion.Value = ((this.Zones<IOuterBullZone>(i) != null) ? this.Zones<IOuterBullZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.ISingleScoreZone:
					tdartboardZoneUnion.Value = ((this.Zones<ISingleScoreZone>(i) != null) ? this.Zones<ISingleScoreZone>(i).Value.UnPack() : null);
					break;
				case TDartboardZone.ITripleScoreZone:
					tdartboardZoneUnion.Value = ((this.Zones<ITripleScoreZone>(i) != null) ? this.Zones<ITripleScoreZone>(i).Value.UnPack() : null);
					break;
				}
				_o.Zones.Add(tdartboardZoneUnion);
			}
		}

		// Token: 0x0601BB00 RID: 113408 RVA: 0x003EA15C File Offset: 0x003E835C
		public static Offset<IDartStrategyError> Pack(FlatBufferBuilder builder, IDartStrategyErrorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartStrategyError>);
			}
			VectorOffset zones_typeOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				TDartboardZone[] array = new TDartboardZone[_o.Zones.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Zones[i].Type;
				}
				zones_typeOffset = IDartStrategyError.CreateZonesTypeVector(builder, array);
			}
			VectorOffset zonesOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				int[] array2 = new int[_o.Zones.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartboardZoneUnion.Pack(builder, _o.Zones[j]);
				}
				zonesOffset = IDartStrategyError.CreateZonesVector(builder, array2);
			}
			return IDartStrategyError.CreateIDartStrategyError(builder, _o.Probability, zones_typeOffset, zonesOffset);
		}

		// Token: 0x0400CECB RID: 52939
		private Table __p;
	}
}
