using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D9 RID: 17625
	public struct IHitZoneTimesResult : IFlatbufferObject
	{
		// Token: 0x17007C63 RID: 31843
		// (get) Token: 0x0601A580 RID: 107904 RVA: 0x003C294A File Offset: 0x003C0B4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x003C2957 File Offset: 0x003C0B57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x003C2960 File Offset: 0x003C0B60
		public static IHitZoneTimesResult GetRootAsIHitZoneTimesResult(ByteBuffer _bb)
		{
			return IHitZoneTimesResult.GetRootAsIHitZoneTimesResult(_bb, default(IHitZoneTimesResult));
		}

		// Token: 0x0601A583 RID: 107907 RVA: 0x003C297C File Offset: 0x003C0B7C
		public static IHitZoneTimesResult GetRootAsIHitZoneTimesResult(ByteBuffer _bb, IHitZoneTimesResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A584 RID: 107908 RVA: 0x003C2999 File Offset: 0x003C0B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A585 RID: 107909 RVA: 0x003C29A8 File Offset: 0x003C0BA8
		public IHitZoneTimesResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C64 RID: 31844
		// (get) Token: 0x0601A586 RID: 107910 RVA: 0x003C29B8 File Offset: 0x003C0BB8
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

		// Token: 0x17007C65 RID: 31845
		// (get) Token: 0x0601A587 RID: 107911 RVA: 0x003C29F4 File Offset: 0x003C0BF4
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

		// Token: 0x0601A588 RID: 107912 RVA: 0x003C2A30 File Offset: 0x003C0C30
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007C66 RID: 31846
		// (get) Token: 0x0601A589 RID: 107913 RVA: 0x003C2A70 File Offset: 0x003C0C70
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

		// Token: 0x0601A58A RID: 107914 RVA: 0x003C2A9B File Offset: 0x003C0C9B
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601A58B RID: 107915 RVA: 0x003C2AAC File Offset: 0x003C0CAC
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

		// Token: 0x0601A58C RID: 107916 RVA: 0x003C2B18 File Offset: 0x003C0D18
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007C67 RID: 31847
		// (get) Token: 0x0601A58D RID: 107917 RVA: 0x003C2B60 File Offset: 0x003C0D60
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

		// Token: 0x0601A58E RID: 107918 RVA: 0x003C2B8C File Offset: 0x003C0D8C
		public static Offset<IHitZoneTimesResult> CreateIHitZoneTimesResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int HitTimes = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IHitZoneTimesResult.AddZones(builder, ZonesOffset);
			IHitZoneTimesResult.AddZonesType(builder, Zones_typeOffset);
			IHitZoneTimesResult.AddHitTimes(builder, HitTimes);
			IHitZoneTimesResult.AddType(builder, Type);
			return IHitZoneTimesResult.EndIHitZoneTimesResult(builder);
		}

		// Token: 0x0601A58F RID: 107919 RVA: 0x003C2BB8 File Offset: 0x003C0DB8
		public static void StartIHitZoneTimesResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A590 RID: 107920 RVA: 0x003C2BC1 File Offset: 0x003C0DC1
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A591 RID: 107921 RVA: 0x003C2BCC File Offset: 0x003C0DCC
		public static void AddHitTimes(FlatBufferBuilder builder, int hitTimes)
		{
			builder.AddInt(1, hitTimes, 0);
		}

		// Token: 0x0601A592 RID: 107922 RVA: 0x003C2BD7 File Offset: 0x003C0DD7
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(2, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601A593 RID: 107923 RVA: 0x003C2BE8 File Offset: 0x003C0DE8
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A594 RID: 107924 RVA: 0x003C2C1F File Offset: 0x003C0E1F
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A595 RID: 107925 RVA: 0x003C2C39 File Offset: 0x003C0E39
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A596 RID: 107926 RVA: 0x003C2C57 File Offset: 0x003C0E57
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A597 RID: 107927 RVA: 0x003C2C70 File Offset: 0x003C0E70
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601A598 RID: 107928 RVA: 0x003C2C7B File Offset: 0x003C0E7B
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(3, zonesOffset.Value, 0);
		}

		// Token: 0x0601A599 RID: 107929 RVA: 0x003C2C8C File Offset: 0x003C0E8C
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A59A RID: 107930 RVA: 0x003C2CC3 File Offset: 0x003C0EC3
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A59B RID: 107931 RVA: 0x003C2CDD File Offset: 0x003C0EDD
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A59C RID: 107932 RVA: 0x003C2CFB File Offset: 0x003C0EFB
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A59D RID: 107933 RVA: 0x003C2D14 File Offset: 0x003C0F14
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A59E RID: 107934 RVA: 0x003C2D1F File Offset: 0x003C0F1F
		public static Offset<IHitZoneTimesResult> EndIHitZoneTimesResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitZoneTimesResult>(builder.EndTable());
		}

		// Token: 0x0601A59F RID: 107935 RVA: 0x003C2D2C File Offset: 0x003C0F2C
		public IHitZoneTimesResultT UnPack()
		{
			IHitZoneTimesResultT hitZoneTimesResultT = new IHitZoneTimesResultT();
			this.UnPackTo(hitZoneTimesResultT);
			return hitZoneTimesResultT;
		}

		// Token: 0x0601A5A0 RID: 107936 RVA: 0x003C2D48 File Offset: 0x003C0F48
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

		// Token: 0x0601A5A1 RID: 107937 RVA: 0x003C2EE8 File Offset: 0x003C10E8
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

		// Token: 0x0400C4F0 RID: 50416
		private Table __p;
	}
}
