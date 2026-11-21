using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200600E RID: 24590
	public struct ISunSpiritGearPerformScaleUp : IFlatbufferObject
	{
		// Token: 0x1700B652 RID: 46674
		// (get) Token: 0x0602971C RID: 169756 RVA: 0x005A80C8 File Offset: 0x005A62C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602971D RID: 169757 RVA: 0x005A80D5 File Offset: 0x005A62D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602971E RID: 169758 RVA: 0x005A80DC File Offset: 0x005A62DC
		public static ISunSpiritGearPerformScaleUp GetRootAsISunSpiritGearPerformScaleUp(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformScaleUp.GetRootAsISunSpiritGearPerformScaleUp(_bb, default(ISunSpiritGearPerformScaleUp));
		}

		// Token: 0x0602971F RID: 169759 RVA: 0x005A80F8 File Offset: 0x005A62F8
		public static ISunSpiritGearPerformScaleUp GetRootAsISunSpiritGearPerformScaleUp(ByteBuffer _bb, ISunSpiritGearPerformScaleUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029720 RID: 169760 RVA: 0x005A8115 File Offset: 0x005A6315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029721 RID: 169761 RVA: 0x005A8124 File Offset: 0x005A6324
		public ISunSpiritGearPerformScaleUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B653 RID: 46675
		// (get) Token: 0x06029722 RID: 169762 RVA: 0x005A8134 File Offset: 0x005A6334
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

		// Token: 0x1700B654 RID: 46676
		// (get) Token: 0x06029723 RID: 169763 RVA: 0x005A8170 File Offset: 0x005A6370
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

		// Token: 0x1700B655 RID: 46677
		// (get) Token: 0x06029724 RID: 169764 RVA: 0x005A81B0 File Offset: 0x005A63B0
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

		// Token: 0x06029725 RID: 169765 RVA: 0x005A820D File Offset: 0x005A640D
		public static Offset<ISunSpiritGearPerformScaleUp> CreateISunSpiritGearPerformScaleUp(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos, float Scale = 0f, Offset<IScaleUpSpiritPerformConfig> ScaleUpPerformConfigOffset = default(Offset<IScaleUpSpiritPerformConfig>))
		{
			builder.StartTable(3);
			ISunSpiritGearPerformScaleUp.AddScaleUpPerformConfig(builder, ScaleUpPerformConfigOffset);
			ISunSpiritGearPerformScaleUp.AddScale(builder, Scale);
			ISunSpiritGearPerformScaleUp.AddType(builder, Type);
			return ISunSpiritGearPerformScaleUp.EndISunSpiritGearPerformScaleUp(builder);
		}

		// Token: 0x06029726 RID: 169766 RVA: 0x005A8231 File Offset: 0x005A6431
		public static void StartISunSpiritGearPerformScaleUp(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029727 RID: 169767 RVA: 0x005A823A File Offset: 0x005A643A
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029728 RID: 169768 RVA: 0x005A8245 File Offset: 0x005A6445
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(1, scale, 0.0);
		}

		// Token: 0x06029729 RID: 169769 RVA: 0x005A8258 File Offset: 0x005A6458
		public static void AddScaleUpPerformConfig(FlatBufferBuilder builder, Offset<IScaleUpSpiritPerformConfig> scaleUpPerformConfigOffset)
		{
			builder.AddOffset(2, scaleUpPerformConfigOffset.Value, 0);
		}

		// Token: 0x0602972A RID: 169770 RVA: 0x005A8268 File Offset: 0x005A6468
		public static Offset<ISunSpiritGearPerformScaleUp> EndISunSpiritGearPerformScaleUp(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformScaleUp>(builder.EndTable());
		}

		// Token: 0x0602972B RID: 169771 RVA: 0x005A8278 File Offset: 0x005A6478
		public ISunSpiritGearPerformScaleUpT UnPack()
		{
			ISunSpiritGearPerformScaleUpT sunSpiritGearPerformScaleUpT = new ISunSpiritGearPerformScaleUpT();
			this.UnPackTo(sunSpiritGearPerformScaleUpT);
			return sunSpiritGearPerformScaleUpT;
		}

		// Token: 0x0602972C RID: 169772 RVA: 0x005A8294 File Offset: 0x005A6494
		public void UnPackTo(ISunSpiritGearPerformScaleUpT _o)
		{
			_o.Type = this.Type;
			_o.Scale = this.Scale;
			_o.ScaleUpPerformConfig = ((this.ScaleUpPerformConfig != null) ? this.ScaleUpPerformConfig.Value.UnPack() : null);
		}

		// Token: 0x0602972D RID: 169773 RVA: 0x005A82E8 File Offset: 0x005A64E8
		public static Offset<ISunSpiritGearPerformScaleUp> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformScaleUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformScaleUp>);
			}
			Offset<IScaleUpSpiritPerformConfig> scaleUpPerformConfigOffset = (_o.ScaleUpPerformConfig == null) ? default(Offset<IScaleUpSpiritPerformConfig>) : IScaleUpSpiritPerformConfig.Pack(builder, _o.ScaleUpPerformConfig);
			return ISunSpiritGearPerformScaleUp.CreateISunSpiritGearPerformScaleUp(builder, _o.Type, _o.Scale, scaleUpPerformConfigOffset);
		}

		// Token: 0x0400FD3A RID: 64826
		private Table __p;
	}
}
