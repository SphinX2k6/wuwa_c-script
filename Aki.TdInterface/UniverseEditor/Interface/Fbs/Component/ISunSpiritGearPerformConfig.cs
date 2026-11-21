using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006008 RID: 24584
	public struct ISunSpiritGearPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700B64D RID: 46669
		// (get) Token: 0x060296FC RID: 169724 RVA: 0x005A7E08 File Offset: 0x005A6008
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296FD RID: 169725 RVA: 0x005A7E15 File Offset: 0x005A6015
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296FE RID: 169726 RVA: 0x005A7E1C File Offset: 0x005A601C
		public static ISunSpiritGearPerformConfig GetRootAsISunSpiritGearPerformConfig(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformConfig.GetRootAsISunSpiritGearPerformConfig(_bb, default(ISunSpiritGearPerformConfig));
		}

		// Token: 0x060296FF RID: 169727 RVA: 0x005A7E38 File Offset: 0x005A6038
		public static ISunSpiritGearPerformConfig GetRootAsISunSpiritGearPerformConfig(ByteBuffer _bb, ISunSpiritGearPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029700 RID: 169728 RVA: 0x005A7E55 File Offset: 0x005A6055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029701 RID: 169729 RVA: 0x005A7E64 File Offset: 0x005A6064
		public ISunSpiritGearPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B64E RID: 46670
		// (get) Token: 0x06029702 RID: 169730 RVA: 0x005A7E74 File Offset: 0x005A6074
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

		// Token: 0x06029703 RID: 169731 RVA: 0x005A7EB0 File Offset: 0x005A60B0
		public static Offset<ISunSpiritGearPerformConfig> CreateISunSpiritGearPerformConfig(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos)
		{
			builder.StartTable(1);
			ISunSpiritGearPerformConfig.AddType(builder, Type);
			return ISunSpiritGearPerformConfig.EndISunSpiritGearPerformConfig(builder);
		}

		// Token: 0x06029704 RID: 169732 RVA: 0x005A7EC6 File Offset: 0x005A60C6
		public static void StartISunSpiritGearPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029705 RID: 169733 RVA: 0x005A7ECF File Offset: 0x005A60CF
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029706 RID: 169734 RVA: 0x005A7EDA File Offset: 0x005A60DA
		public static Offset<ISunSpiritGearPerformConfig> EndISunSpiritGearPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformConfig>(builder.EndTable());
		}

		// Token: 0x06029707 RID: 169735 RVA: 0x005A7EE8 File Offset: 0x005A60E8
		public ISunSpiritGearPerformConfigT UnPack()
		{
			ISunSpiritGearPerformConfigT sunSpiritGearPerformConfigT = new ISunSpiritGearPerformConfigT();
			this.UnPackTo(sunSpiritGearPerformConfigT);
			return sunSpiritGearPerformConfigT;
		}

		// Token: 0x06029708 RID: 169736 RVA: 0x005A7F03 File Offset: 0x005A6103
		public void UnPackTo(ISunSpiritGearPerformConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029709 RID: 169737 RVA: 0x005A7F14 File Offset: 0x005A6114
		public static Offset<ISunSpiritGearPerformConfig> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformConfig>);
			}
			return ISunSpiritGearPerformConfig.CreateISunSpiritGearPerformConfig(builder, _o.Type);
		}

		// Token: 0x0400FD31 RID: 64817
		private Table __p;
	}
}
