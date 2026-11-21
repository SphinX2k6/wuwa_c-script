using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004941 RID: 18753
	public struct IHitZoneTimesResult : IFlatbufferObject
	{
		// Token: 0x170082A2 RID: 33442
		// (get) Token: 0x0601BD51 RID: 114001 RVA: 0x003EEB56 File Offset: 0x003ECD56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD52 RID: 114002 RVA: 0x003EEB63 File Offset: 0x003ECD63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD53 RID: 114003 RVA: 0x003EEB6C File Offset: 0x003ECD6C
		public static IHitZoneTimesResult GetRootAsIHitZoneTimesResult(ByteBuffer _bb)
		{
			return IHitZoneTimesResult.GetRootAsIHitZoneTimesResult(_bb, default(IHitZoneTimesResult));
		}

		// Token: 0x0601BD54 RID: 114004 RVA: 0x003EEB88 File Offset: 0x003ECD88
		public static IHitZoneTimesResult GetRootAsIHitZoneTimesResult(ByteBuffer _bb, IHitZoneTimesResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD55 RID: 114005 RVA: 0x003EEBA5 File Offset: 0x003ECDA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x003EEBB4 File Offset: 0x003ECDB4
		public IHitZoneTimesResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082A3 RID: 33443
		// (get) Token: 0x0601BD57 RID: 114007 RVA: 0x003EEBC4 File Offset: 0x003ECDC4
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082A4 RID: 33444
		// (get) Token: 0x0601BD58 RID: 114008 RVA: 0x003EEC00 File Offset: 0x003ECE00
		public int HitTimes
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

		// Token: 0x0601BD59 RID: 114009 RVA: 0x003EEC3C File Offset: 0x003ECE3C
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170082A5 RID: 33445
		// (get) Token: 0x0601BD5A RID: 114010 RVA: 0x003EEC7C File Offset: 0x003ECE7C
		public int ZonesTypeLength
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

		// Token: 0x0601BD5B RID: 114011 RVA: 0x003EECA7 File Offset: 0x003ECEA7
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601BD5C RID: 114012 RVA: 0x003EECB8 File Offset: 0x003ECEB8
		public TDartboardZone[] GetZonesTypeArray()
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

		// Token: 0x0601BD5D RID: 114013 RVA: 0x003EED24 File Offset: 0x003ECF24
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170082A6 RID: 33446
		// (get) Token: 0x0601BD5E RID: 114014 RVA: 0x003EED6C File Offset: 0x003ECF6C
		public int ZonesLength
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

		// Token: 0x0601BD5F RID: 114015 RVA: 0x003EED98 File Offset: 0x003ECF98
		public static Offset<IHitZoneTimesResult> CreateIHitZoneTimesResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int HitTimes = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IHitZoneTimesResult.AddZones(builder, ZonesOffset);
			IHitZoneTimesResult.AddZonesType(builder, Zones_typeOffset);
			IHitZoneTimesResult.AddHitTimes(builder, HitTimes);
			IHitZoneTimesResult.AddType(builder, Type);
			return IHitZoneTimesResult.EndIHitZoneTimesResult(builder);
		}

		// Token: 0x0601BD60 RID: 114016 RVA: 0x003EEDC4 File Offset: 0x003ECFC4
		public static void StartIHitZoneTimesResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BD61 RID: 114017 RVA: 0x003EEDCD File Offset: 0x003ECFCD
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD62 RID: 114018 RVA: 0x003EEDD8 File Offset: 0x003ECFD8
		public static void AddHitTimes(FlatBufferBuilder builder, int hitTimes)
		{
			builder.AddInt(1, hitTimes, 0);
		}

		// Token: 0x0601BD63 RID: 114019 RVA: 0x003EEDE3 File Offset: 0x003ECFE3
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(2, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601BD64 RID: 114020 RVA: 0x003EEDF4 File Offset: 0x003ECFF4
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD65 RID: 114021 RVA: 0x003EEE2B File Offset: 0x003ED02B
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD66 RID: 114022 RVA: 0x003EEE45 File Offset: 0x003ED045
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD67 RID: 114023 RVA: 0x003EEE63 File Offset: 0x003ED063
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD68 RID: 114024 RVA: 0x003EEE7C File Offset: 0x003ED07C
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BD69 RID: 114025 RVA: 0x003EEE87 File Offset: 0x003ED087
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(3, zonesOffset.Value, 0);
		}

		// Token: 0x0601BD6A RID: 114026 RVA: 0x003EEE98 File Offset: 0x003ED098
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BD6B RID: 114027 RVA: 0x003EEECF File Offset: 0x003ED0CF
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD6C RID: 114028 RVA: 0x003EEEE9 File Offset: 0x003ED0E9
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BD6D RID: 114029 RVA: 0x003EEF07 File Offset: 0x003ED107
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BD6E RID: 114030 RVA: 0x003EEF20 File Offset: 0x003ED120
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BD6F RID: 114031 RVA: 0x003EEF2B File Offset: 0x003ED12B
		public static Offset<IHitZoneTimesResult> EndIHitZoneTimesResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitZoneTimesResult>(builder.EndTable());
		}

		// Token: 0x0601BD70 RID: 114032 RVA: 0x003EEF38 File Offset: 0x003ED138
		public IHitZoneTimesResultT UnPack()
		{
			IHitZoneTimesResultT hitZoneTimesResultT = new IHitZoneTimesResultT();
			this.UnPackTo(hitZoneTimesResultT);
			return hitZoneTimesResultT;
		}

		// Token: 0x0601BD71 RID: 114033 RVA: 0x003EEF54 File Offset: 0x003ED154
		public void UnPackTo(IHitZoneTimesResultT _o)
		{
			_o.Type = this.Type;
			_o.HitTimes = this.HitTimes;
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

		// Token: 0x0601BD72 RID: 114034 RVA: 0x003EF0F4 File Offset: 0x003ED2F4
		public static Offset<IHitZoneTimesResult> Pack(FlatBufferBuilder builder, IHitZoneTimesResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitZoneTimesResult>);
			}
			VectorOffset zones_typeOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				TDartboardZone[] array = new TDartboardZone[_o.Zones.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Zones[i].Type;
				}
				zones_typeOffset = IHitZoneTimesResult.CreateZonesTypeVector(builder, array);
			}
			VectorOffset zonesOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				int[] array2 = new int[_o.Zones.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartboardZoneUnion.Pack(builder, _o.Zones[j]);
				}
				zonesOffset = IHitZoneTimesResult.CreateZonesVector(builder, array2);
			}
			return IHitZoneTimesResult.CreateIHitZoneTimesResult(builder, _o.Type, _o.HitTimes, zones_typeOffset, zonesOffset);
		}

		// Token: 0x0400CF1E RID: 53022
		private Table __p;
	}
}
