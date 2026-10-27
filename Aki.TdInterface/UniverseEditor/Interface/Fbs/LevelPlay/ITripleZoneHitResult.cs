using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D8 RID: 17880
	public struct ITripleZoneHitResult : IFlatbufferObject
	{
		// Token: 0x17007F1B RID: 32539
		// (get) Token: 0x0601B0E7 RID: 110823 RVA: 0x003DB0D4 File Offset: 0x003D92D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0E8 RID: 110824 RVA: 0x003DB0E1 File Offset: 0x003D92E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0E9 RID: 110825 RVA: 0x003DB0E8 File Offset: 0x003D92E8
		public static ITripleZoneHitResult GetRootAsITripleZoneHitResult(ByteBuffer _bb)
		{
			return ITripleZoneHitResult.GetRootAsITripleZoneHitResult(_bb, default(ITripleZoneHitResult));
		}

		// Token: 0x0601B0EA RID: 110826 RVA: 0x003DB104 File Offset: 0x003D9304
		public static ITripleZoneHitResult GetRootAsITripleZoneHitResult(ByteBuffer _bb, ITripleZoneHitResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0EB RID: 110827 RVA: 0x003DB121 File Offset: 0x003D9321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0EC RID: 110828 RVA: 0x003DB130 File Offset: 0x003D9330
		public ITripleZoneHitResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F1C RID: 32540
		// (get) Token: 0x0601B0ED RID: 110829 RVA: 0x003DB140 File Offset: 0x003D9340
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

		// Token: 0x17007F1D RID: 32541
		// (get) Token: 0x0601B0EE RID: 110830 RVA: 0x003DB17C File Offset: 0x003D937C
		public int Probability
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

		// Token: 0x0601B0EF RID: 110831 RVA: 0x003DB1B8 File Offset: 0x003D93B8
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17007F1E RID: 32542
		// (get) Token: 0x0601B0F0 RID: 110832 RVA: 0x003DB1F8 File Offset: 0x003D93F8
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

		// Token: 0x0601B0F1 RID: 110833 RVA: 0x003DB223 File Offset: 0x003D9423
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601B0F2 RID: 110834 RVA: 0x003DB234 File Offset: 0x003D9434
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

		// Token: 0x0601B0F3 RID: 110835 RVA: 0x003DB2A0 File Offset: 0x003D94A0
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17007F1F RID: 32543
		// (get) Token: 0x0601B0F4 RID: 110836 RVA: 0x003DB2E8 File Offset: 0x003D94E8
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

		// Token: 0x0601B0F5 RID: 110837 RVA: 0x003DB314 File Offset: 0x003D9514
		public static Offset<ITripleZoneHitResult> CreateITripleZoneHitResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITripleZoneHitResult.AddZones(builder, ZonesOffset);
			ITripleZoneHitResult.AddZonesType(builder, Zones_typeOffset);
			ITripleZoneHitResult.AddProbability(builder, Probability);
			ITripleZoneHitResult.AddType(builder, Type);
			return ITripleZoneHitResult.EndITripleZoneHitResult(builder);
		}

		// Token: 0x0601B0F6 RID: 110838 RVA: 0x003DB340 File Offset: 0x003D9540
		public static void StartITripleZoneHitResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B0F7 RID: 110839 RVA: 0x003DB349 File Offset: 0x003D9549
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B0F8 RID: 110840 RVA: 0x003DB354 File Offset: 0x003D9554
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601B0F9 RID: 110841 RVA: 0x003DB35F File Offset: 0x003D955F
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(2, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601B0FA RID: 110842 RVA: 0x003DB370 File Offset: 0x003D9570
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B0FB RID: 110843 RVA: 0x003DB3A7 File Offset: 0x003D95A7
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B0FC RID: 110844 RVA: 0x003DB3C1 File Offset: 0x003D95C1
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B0FD RID: 110845 RVA: 0x003DB3DF File Offset: 0x003D95DF
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B0FE RID: 110846 RVA: 0x003DB3F8 File Offset: 0x003D95F8
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601B0FF RID: 110847 RVA: 0x003DB403 File Offset: 0x003D9603
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(3, zonesOffset.Value, 0);
		}

		// Token: 0x0601B100 RID: 110848 RVA: 0x003DB414 File Offset: 0x003D9614
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B101 RID: 110849 RVA: 0x003DB44B File Offset: 0x003D964B
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B102 RID: 110850 RVA: 0x003DB465 File Offset: 0x003D9665
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B103 RID: 110851 RVA: 0x003DB483 File Offset: 0x003D9683
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B104 RID: 110852 RVA: 0x003DB49C File Offset: 0x003D969C
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B105 RID: 110853 RVA: 0x003DB4A7 File Offset: 0x003D96A7
		public static Offset<ITripleZoneHitResult> EndITripleZoneHitResult(FlatBufferBuilder builder)
		{
			return new Offset<ITripleZoneHitResult>(builder.EndTable());
		}

		// Token: 0x0601B106 RID: 110854 RVA: 0x003DB4B4 File Offset: 0x003D96B4
		public ITripleZoneHitResultT UnPack()
		{
			ITripleZoneHitResultT tripleZoneHitResultT = new ITripleZoneHitResultT();
			this.UnPackTo(tripleZoneHitResultT);
			return tripleZoneHitResultT;
		}

		// Token: 0x0601B107 RID: 110855 RVA: 0x003DB4D0 File Offset: 0x003D96D0
		public void UnPackTo(ITripleZoneHitResultT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x0601B108 RID: 110856 RVA: 0x003DB670 File Offset: 0x003D9870
		public static Offset<ITripleZoneHitResult> Pack(FlatBufferBuilder builder, ITripleZoneHitResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITripleZoneHitResult>);
			}
			VectorOffset zones_typeOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				TDartboardZone[] array = new TDartboardZone[_o.Zones.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Zones[i].Type;
				}
				zones_typeOffset = ITripleZoneHitResult.CreateZonesTypeVector(builder, array);
			}
			VectorOffset zonesOffset = default(VectorOffset);
			if (_o.Zones != null)
			{
				int[] array2 = new int[_o.Zones.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartboardZoneUnion.Pack(builder, _o.Zones[j]);
				}
				zonesOffset = ITripleZoneHitResult.CreateZonesVector(builder, array2);
			}
			return ITripleZoneHitResult.CreateITripleZoneHitResult(builder, _o.Type, _o.Probability, zones_typeOffset, zonesOffset);
		}

		// Token: 0x0400C6AD RID: 50861
		private Table __p;
	}
}
