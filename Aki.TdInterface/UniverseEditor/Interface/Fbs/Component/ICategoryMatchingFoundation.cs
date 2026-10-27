using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6A RID: 20330
	public struct ICategoryMatchingFoundation : IFlatbufferObject
	{
		// Token: 0x170092CA RID: 37578
		// (get) Token: 0x060203E9 RID: 132073 RVA: 0x0047CA05 File Offset: 0x0047AC05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203EA RID: 132074 RVA: 0x0047CA12 File Offset: 0x0047AC12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203EB RID: 132075 RVA: 0x0047CA1C File Offset: 0x0047AC1C
		public static ICategoryMatchingFoundation GetRootAsICategoryMatchingFoundation(ByteBuffer _bb)
		{
			return ICategoryMatchingFoundation.GetRootAsICategoryMatchingFoundation(_bb, default(ICategoryMatchingFoundation));
		}

		// Token: 0x060203EC RID: 132076 RVA: 0x0047CA38 File Offset: 0x0047AC38
		public static ICategoryMatchingFoundation GetRootAsICategoryMatchingFoundation(ByteBuffer _bb, ICategoryMatchingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203ED RID: 132077 RVA: 0x0047CA55 File Offset: 0x0047AC55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203EE RID: 132078 RVA: 0x0047CA64 File Offset: 0x0047AC64
		public ICategoryMatchingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092CB RID: 37579
		// (get) Token: 0x060203EF RID: 132079 RVA: 0x0047CA74 File Offset: 0x0047AC74
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092CC RID: 37580
		// (get) Token: 0x060203F0 RID: 132080 RVA: 0x0047CAB0 File Offset: 0x0047ACB0
		public int InitMatchEntity
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

		// Token: 0x060203F1 RID: 132081 RVA: 0x0047CAEC File Offset: 0x0047ACEC
		public ICategoryMatchingConfig? MatchingConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICategoryMatchingConfig?(default(ICategoryMatchingConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170092CD RID: 37581
		// (get) Token: 0x060203F2 RID: 132082 RVA: 0x0047CB4C File Offset: 0x0047AD4C
		public int MatchingConfigsLength
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

		// Token: 0x170092CE RID: 37582
		// (get) Token: 0x060203F3 RID: 132083 RVA: 0x0047CB78 File Offset: 0x0047AD78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060203F4 RID: 132084 RVA: 0x0047CBB5 File Offset: 0x0047ADB5
		public static Offset<ICategoryMatchingFoundation> CreateICategoryMatchingFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching, int InitMatchEntity = 0, VectorOffset MatchingConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICategoryMatchingFoundation.AddMatchingConfigs(builder, MatchingConfigsOffset);
			ICategoryMatchingFoundation.AddInitMatchEntity(builder, InitMatchEntity);
			ICategoryMatchingFoundation.AddNullMask(builder, NullMask);
			ICategoryMatchingFoundation.AddType(builder, Type);
			return ICategoryMatchingFoundation.EndICategoryMatchingFoundation(builder);
		}

		// Token: 0x060203F5 RID: 132085 RVA: 0x0047CBE1 File Offset: 0x0047ADE1
		public static void StartICategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060203F6 RID: 132086 RVA: 0x0047CBEA File Offset: 0x0047ADEA
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060203F7 RID: 132087 RVA: 0x0047CBF5 File Offset: 0x0047ADF5
		public static void AddInitMatchEntity(FlatBufferBuilder builder, int initMatchEntity)
		{
			builder.AddInt(1, initMatchEntity, 0);
		}

		// Token: 0x060203F8 RID: 132088 RVA: 0x0047CC00 File Offset: 0x0047AE00
		public static void AddMatchingConfigs(FlatBufferBuilder builder, VectorOffset matchingConfigsOffset)
		{
			builder.AddOffset(2, matchingConfigsOffset.Value, 0);
		}

		// Token: 0x060203F9 RID: 132089 RVA: 0x0047CC10 File Offset: 0x0047AE10
		public static VectorOffset CreateMatchingConfigsVector(FlatBufferBuilder builder, Offset<ICategoryMatchingConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060203FA RID: 132090 RVA: 0x0047CC50 File Offset: 0x0047AE50
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICategoryMatchingConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICategoryMatchingConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060203FB RID: 132091 RVA: 0x0047CC6A File Offset: 0x0047AE6A
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICategoryMatchingConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICategoryMatchingConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060203FC RID: 132092 RVA: 0x0047CC88 File Offset: 0x0047AE88
		public static VectorOffset CreateMatchingConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICategoryMatchingConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060203FD RID: 132093 RVA: 0x0047CCA1 File Offset: 0x0047AEA1
		public static void StartMatchingConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060203FE RID: 132094 RVA: 0x0047CCAC File Offset: 0x0047AEAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060203FF RID: 132095 RVA: 0x0047CCB7 File Offset: 0x0047AEB7
		public static Offset<ICategoryMatchingFoundation> EndICategoryMatchingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingFoundation>(builder.EndTable());
		}

		// Token: 0x06020400 RID: 132096 RVA: 0x0047CCC4 File Offset: 0x0047AEC4
		public ICategoryMatchingFoundationT UnPack()
		{
			ICategoryMatchingFoundationT categoryMatchingFoundationT = new ICategoryMatchingFoundationT();
			this.UnPackTo(categoryMatchingFoundationT);
			return categoryMatchingFoundationT;
		}

		// Token: 0x06020401 RID: 132097 RVA: 0x0047CCE0 File Offset: 0x0047AEE0
		public void UnPackTo(ICategoryMatchingFoundationT _o)
		{
			_o.Type = this.Type;
			_o.InitMatchEntity = this.InitMatchEntity;
			_o.MatchingConfigs = new List<ICategoryMatchingConfigT>();
			for (int i = 0; i < this.MatchingConfigsLength; i++)
			{
				_o.MatchingConfigs.Add((this.MatchingConfigs(i) != null) ? this.MatchingConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020402 RID: 132098 RVA: 0x0047CD64 File Offset: 0x0047AF64
		public static Offset<ICategoryMatchingFoundation> Pack(FlatBufferBuilder builder, ICategoryMatchingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingFoundation>);
			}
			VectorOffset matchingConfigsOffset = default(VectorOffset);
			if (_o.MatchingConfigs != null)
			{
				Offset<ICategoryMatchingConfig>[] array = new Offset<ICategoryMatchingConfig>[_o.MatchingConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICategoryMatchingConfig.Pack(builder, _o.MatchingConfigs[i]);
				}
				matchingConfigsOffset = ICategoryMatchingFoundation.CreateMatchingConfigsVector(builder, array);
			}
			return ICategoryMatchingFoundation.CreateICategoryMatchingFoundation(builder, _o.Type, _o.InitMatchEntity, matchingConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400DDFE RID: 56830
		private Table __p;
	}
}
