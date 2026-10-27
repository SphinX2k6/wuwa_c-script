using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004497 RID: 17559
	public struct IDartStrategyError : IFlatbufferObject
	{
		// Token: 0x17007BDF RID: 31711
		// (get) Token: 0x0601A310 RID: 107280 RVA: 0x003BDA0F File Offset: 0x003BBC0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A311 RID: 107281 RVA: 0x003BDA1C File Offset: 0x003BBC1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A312 RID: 107282 RVA: 0x003BDA24 File Offset: 0x003BBC24
		public static IDartStrategyError GetRootAsIDartStrategyError(ByteBuffer _bb)
		{
			return IDartStrategyError.GetRootAsIDartStrategyError(_bb, default(IDartStrategyError));
		}

		// Token: 0x0601A313 RID: 107283 RVA: 0x003BDA40 File Offset: 0x003BBC40
		public static IDartStrategyError GetRootAsIDartStrategyError(ByteBuffer _bb, IDartStrategyError obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A314 RID: 107284 RVA: 0x003BDA5D File Offset: 0x003BBC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A315 RID: 107285 RVA: 0x003BDA6C File Offset: 0x003BBC6C
		public IDartStrategyError __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BE0 RID: 31712
		// (get) Token: 0x0601A316 RID: 107286 RVA: 0x003BDA7C File Offset: 0x003BBC7C
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

		// Token: 0x0601A317 RID: 107287 RVA: 0x003BDAB8 File Offset: 0x003BBCB8
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007BE1 RID: 31713
		// (get) Token: 0x0601A318 RID: 107288 RVA: 0x003BDAF8 File Offset: 0x003BBCF8
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

		// Token: 0x0601A319 RID: 107289 RVA: 0x003BDB23 File Offset: 0x003BBD23
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(6, 1);
		}

		// Token: 0x0601A31A RID: 107290 RVA: 0x003BDB34 File Offset: 0x003BBD34
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

		// Token: 0x0601A31B RID: 107291 RVA: 0x003BDBA0 File Offset: 0x003BBDA0
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007BE2 RID: 31714
		// (get) Token: 0x0601A31C RID: 107292 RVA: 0x003BDBE8 File Offset: 0x003BBDE8
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

		// Token: 0x0601A31D RID: 107293 RVA: 0x003BDC13 File Offset: 0x003BBE13
		public static Offset<IDartStrategyError> CreateIDartStrategyError(FlatBufferBuilder builder, int Probability = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDartStrategyError.AddZones(builder, ZonesOffset);
			IDartStrategyError.AddZonesType(builder, Zones_typeOffset);
			IDartStrategyError.AddProbability(builder, Probability);
			return IDartStrategyError.EndIDartStrategyError(builder);
		}

		// Token: 0x0601A31E RID: 107294 RVA: 0x003BDC37 File Offset: 0x003BBE37
		public static void StartIDartStrategyError(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A31F RID: 107295 RVA: 0x003BDC40 File Offset: 0x003BBE40
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(0, probability, 0);
		}

		// Token: 0x0601A320 RID: 107296 RVA: 0x003BDC4B File Offset: 0x003BBE4B
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(1, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601A321 RID: 107297 RVA: 0x003BDC5C File Offset: 0x003BBE5C
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A322 RID: 107298 RVA: 0x003BDC93 File Offset: 0x003BBE93
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A323 RID: 107299 RVA: 0x003BDCAD File Offset: 0x003BBEAD
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A324 RID: 107300 RVA: 0x003BDCCB File Offset: 0x003BBECB
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A325 RID: 107301 RVA: 0x003BDCE4 File Offset: 0x003BBEE4
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A326 RID: 107302 RVA: 0x003BDCEF File Offset: 0x003BBEEF
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(2, zonesOffset.Value, 0);
		}

		// Token: 0x0601A327 RID: 107303 RVA: 0x003BDD00 File Offset: 0x003BBF00
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A328 RID: 107304 RVA: 0x003BDD37 File Offset: 0x003BBF37
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A329 RID: 107305 RVA: 0x003BDD51 File Offset: 0x003BBF51
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A32A RID: 107306 RVA: 0x003BDD6F File Offset: 0x003BBF6F
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A32B RID: 107307 RVA: 0x003BDD88 File Offset: 0x003BBF88
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A32C RID: 107308 RVA: 0x003BDD93 File Offset: 0x003BBF93
		public static Offset<IDartStrategyError> EndIDartStrategyError(FlatBufferBuilder builder)
		{
			return new Offset<IDartStrategyError>(builder.EndTable());
		}

		// Token: 0x0601A32D RID: 107309 RVA: 0x003BDDA0 File Offset: 0x003BBFA0
		public IDartStrategyErrorT UnPack()
		{
			IDartStrategyErrorT dartStrategyErrorT = new IDartStrategyErrorT();
			this.UnPackTo(dartStrategyErrorT);
			return dartStrategyErrorT;
		}

		// Token: 0x0601A32E RID: 107310 RVA: 0x003BDDBC File Offset: 0x003BBFBC
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

		// Token: 0x0601A32F RID: 107311 RVA: 0x003BDF50 File Offset: 0x003BC150
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

		// Token: 0x0400C49D RID: 50333
		private Table __p;
	}
}
