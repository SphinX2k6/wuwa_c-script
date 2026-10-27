using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A01 RID: 23041
	public struct ISunSpiritGearPerformScaleUp : IFlatbufferObject
	{
		// Token: 0x1700AD1A RID: 44314
		// (get) Token: 0x060271A4 RID: 160164 RVA: 0x00561104 File Offset: 0x0055F304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271A5 RID: 160165 RVA: 0x00561111 File Offset: 0x0055F311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271A6 RID: 160166 RVA: 0x00561118 File Offset: 0x0055F318
		public static ISunSpiritGearPerformScaleUp GetRootAsISunSpiritGearPerformScaleUp(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformScaleUp.GetRootAsISunSpiritGearPerformScaleUp(_bb, default(ISunSpiritGearPerformScaleUp));
		}

		// Token: 0x060271A7 RID: 160167 RVA: 0x00561134 File Offset: 0x0055F334
		public static ISunSpiritGearPerformScaleUp GetRootAsISunSpiritGearPerformScaleUp(ByteBuffer _bb, ISunSpiritGearPerformScaleUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060271A8 RID: 160168 RVA: 0x00561151 File Offset: 0x0055F351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060271A9 RID: 160169 RVA: 0x00561160 File Offset: 0x0055F360
		public ISunSpiritGearPerformScaleUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD1B RID: 44315
		// (get) Token: 0x060271AA RID: 160170 RVA: 0x00561170 File Offset: 0x0055F370
		public ESunSpiritGearPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESunSpiritGearPerformType.ToGearRelativePos;
				}
				return (ESunSpiritGearPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD1C RID: 44316
		// (get) Token: 0x060271AB RID: 160171 RVA: 0x005611AC File Offset: 0x0055F3AC
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD1D RID: 44317
		// (get) Token: 0x060271AC RID: 160172 RVA: 0x005611EC File Offset: 0x0055F3EC
		public IScaleUpSpiritPerformConfig? ScaleUpPerformConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IScaleUpSpiritPerformConfig?(default(IScaleUpSpiritPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060271AD RID: 160173 RVA: 0x00561249 File Offset: 0x0055F449
		public static Offset<ISunSpiritGearPerformScaleUp> CreateISunSpiritGearPerformScaleUp(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos, float Scale = 0f, Offset<IScaleUpSpiritPerformConfig> ScaleUpPerformConfigOffset = default(Offset<IScaleUpSpiritPerformConfig>))
		{
			builder.StartTable(3);
			ISunSpiritGearPerformScaleUp.AddScaleUpPerformConfig(builder, ScaleUpPerformConfigOffset);
			ISunSpiritGearPerformScaleUp.AddScale(builder, Scale);
			ISunSpiritGearPerformScaleUp.AddType(builder, Type);
			return ISunSpiritGearPerformScaleUp.EndISunSpiritGearPerformScaleUp(builder);
		}

		// Token: 0x060271AE RID: 160174 RVA: 0x0056126D File Offset: 0x0055F46D
		public static void StartISunSpiritGearPerformScaleUp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060271AF RID: 160175 RVA: 0x00561276 File Offset: 0x0055F476
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060271B0 RID: 160176 RVA: 0x00561281 File Offset: 0x0055F481
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x060271B1 RID: 160177 RVA: 0x00561294 File Offset: 0x0055F494
		public static void AddScaleUpPerformConfig(FlatBufferBuilder builder, Offset<IScaleUpSpiritPerformConfig> scaleUpPerformConfigOffset)
		{
			builder.AddOffset(2, scaleUpPerformConfigOffset.Value, 0);
		}

		// Token: 0x060271B2 RID: 160178 RVA: 0x005612A4 File Offset: 0x0055F4A4
		public static Offset<ISunSpiritGearPerformScaleUp> EndISunSpiritGearPerformScaleUp(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformScaleUp>(builder.EndTable());
		}

		// Token: 0x060271B3 RID: 160179 RVA: 0x005612B4 File Offset: 0x0055F4B4
		public ISunSpiritGearPerformScaleUpT UnPack()
		{
			ISunSpiritGearPerformScaleUpT sunSpiritGearPerformScaleUpT = new ISunSpiritGearPerformScaleUpT();
			this.UnPackTo(sunSpiritGearPerformScaleUpT);
			return sunSpiritGearPerformScaleUpT;
		}

		// Token: 0x060271B4 RID: 160180 RVA: 0x005612D0 File Offset: 0x0055F4D0
		public void UnPackTo(ISunSpiritGearPerformScaleUpT _o)
		{
			_o.Type = this.Type;
			_o.Scale = this.Scale;
			_o.ScaleUpPerformConfig = ((this.ScaleUpPerformConfig != null) ? this.ScaleUpPerformConfig.Value.UnPack() : null);
		}

		// Token: 0x060271B5 RID: 160181 RVA: 0x00561324 File Offset: 0x0055F524
		public static Offset<ISunSpiritGearPerformScaleUp> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformScaleUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformScaleUp>);
			}
			Offset<IScaleUpSpiritPerformConfig> scaleUpPerformConfigOffset = (_o.ScaleUpPerformConfig == null) ? default(Offset<IScaleUpSpiritPerformConfig>) : IScaleUpSpiritPerformConfig.Pack(builder, _o.ScaleUpPerformConfig);
			return ISunSpiritGearPerformScaleUp.CreateISunSpiritGearPerformScaleUp(builder, _o.Type, _o.Scale, scaleUpPerformConfigOffset);
		}

		// Token: 0x0400F043 RID: 61507
		private Table __p;
	}
}
