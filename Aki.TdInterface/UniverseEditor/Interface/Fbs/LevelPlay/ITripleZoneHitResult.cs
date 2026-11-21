using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A40 RID: 19008
	public struct ITripleZoneHitResult : IFlatbufferObject
	{
		// Token: 0x1700855C RID: 34140
		// (get) Token: 0x0601C8BC RID: 116924 RVA: 0x00407370 File Offset: 0x00405570
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C8BD RID: 116925 RVA: 0x0040737D File Offset: 0x0040557D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C8BE RID: 116926 RVA: 0x00407384 File Offset: 0x00405584
		public static ITripleZoneHitResult GetRootAsITripleZoneHitResult(ByteBuffer _bb)
		{
			return ITripleZoneHitResult.GetRootAsITripleZoneHitResult(_bb, default(ITripleZoneHitResult));
		}

		// Token: 0x0601C8BF RID: 116927 RVA: 0x004073A0 File Offset: 0x004055A0
		public static ITripleZoneHitResult GetRootAsITripleZoneHitResult(ByteBuffer _bb, ITripleZoneHitResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C8C0 RID: 116928 RVA: 0x004073BD File Offset: 0x004055BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C8C1 RID: 116929 RVA: 0x004073CC File Offset: 0x004055CC
		public ITripleZoneHitResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700855D RID: 34141
		// (get) Token: 0x0601C8C2 RID: 116930 RVA: 0x004073DC File Offset: 0x004055DC
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

		// Token: 0x1700855E RID: 34142
		// (get) Token: 0x0601C8C3 RID: 116931 RVA: 0x00407418 File Offset: 0x00405618
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

		// Token: 0x0601C8C4 RID: 116932 RVA: 0x00407454 File Offset: 0x00405654
		public TDartboardZone ZonesType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TDartboardZone.NONE;
			}
			return (TDartboardZone)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700855F RID: 34143
		// (get) Token: 0x0601C8C5 RID: 116933 RVA: 0x00407494 File Offset: 0x00405694
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

		// Token: 0x0601C8C6 RID: 116934 RVA: 0x004074BF File Offset: 0x004056BF
		public Span<TDartboardZone> GetZonesTypeBytes()
		{
			return this.__p.__vector_as_span<TDartboardZone>(8, 1);
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x004074D0 File Offset: 0x004056D0
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

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x0040753C File Offset: 0x0040573C
		public TTable? Zones<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008560 RID: 34144
		// (get) Token: 0x0601C8C9 RID: 116937 RVA: 0x00407584 File Offset: 0x00405784
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

		// Token: 0x0601C8CA RID: 116938 RVA: 0x004075B0 File Offset: 0x004057B0
		public static Offset<ITripleZoneHitResult> CreateITripleZoneHitResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0, VectorOffset Zones_typeOffset = default(VectorOffset), VectorOffset ZonesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ITripleZoneHitResult.AddZones(builder, ZonesOffset);
			ITripleZoneHitResult.AddZonesType(builder, Zones_typeOffset);
			ITripleZoneHitResult.AddProbability(builder, Probability);
			ITripleZoneHitResult.AddType(builder, Type);
			return ITripleZoneHitResult.EndITripleZoneHitResult(builder);
		}

		// Token: 0x0601C8CB RID: 116939 RVA: 0x004075DC File Offset: 0x004057DC
		public static void StartITripleZoneHitResult(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C8CC RID: 116940 RVA: 0x004075E5 File Offset: 0x004057E5
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C8CD RID: 116941 RVA: 0x004075F0 File Offset: 0x004057F0
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601C8CE RID: 116942 RVA: 0x004075FB File Offset: 0x004057FB
		public static void AddZonesType(FlatBufferBuilder builder, VectorOffset zonesTypeOffset)
		{
			builder.AddOffset(2, zonesTypeOffset.Value, 0);
		}

		// Token: 0x0601C8CF RID: 116943 RVA: 0x0040760C File Offset: 0x0040580C
		public static VectorOffset CreateZonesTypeVector(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C8D0 RID: 116944 RVA: 0x00407643 File Offset: 0x00405843
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, TDartboardZone[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D1 RID: 116945 RVA: 0x0040765D File Offset: 0x0040585D
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartboardZone> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartboardZone>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D2 RID: 116946 RVA: 0x0040767B File Offset: 0x0040587B
		public static VectorOffset CreateZonesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartboardZone>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C8D3 RID: 116947 RVA: 0x00407694 File Offset: 0x00405894
		public static void StartZonesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601C8D4 RID: 116948 RVA: 0x0040769F File Offset: 0x0040589F
		public static void AddZones(FlatBufferBuilder builder, VectorOffset zonesOffset)
		{
			builder.AddOffset(3, zonesOffset.Value, 0);
		}

		// Token: 0x0601C8D5 RID: 116949 RVA: 0x004076B0 File Offset: 0x004058B0
		public static VectorOffset CreateZonesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C8D6 RID: 116950 RVA: 0x004076E7 File Offset: 0x004058E7
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D7 RID: 116951 RVA: 0x00407701 File Offset: 0x00405901
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C8D8 RID: 116952 RVA: 0x0040771F File Offset: 0x0040591F
		public static VectorOffset CreateZonesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C8D9 RID: 116953 RVA: 0x00407738 File Offset: 0x00405938
		public static void StartZonesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C8DA RID: 116954 RVA: 0x00407743 File Offset: 0x00405943
		public static Offset<ITripleZoneHitResult> EndITripleZoneHitResult(FlatBufferBuilder builder)
		{
			return new Offset<ITripleZoneHitResult>(builder.EndTable());
		}

		// Token: 0x0601C8DB RID: 116955 RVA: 0x00407750 File Offset: 0x00405950
		public ITripleZoneHitResultT UnPack()
		{
			ITripleZoneHitResultT tripleZoneHitResultT = new ITripleZoneHitResultT();
			this.UnPackTo(tripleZoneHitResultT);
			return tripleZoneHitResultT;
		}

		// Token: 0x0601C8DC RID: 116956 RVA: 0x0040776C File Offset: 0x0040596C
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

		// Token: 0x0601C8DD RID: 116957 RVA: 0x0040790C File Offset: 0x00405B0C
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

		// Token: 0x0400D0DC RID: 53468
		private Table __p;
	}
}
