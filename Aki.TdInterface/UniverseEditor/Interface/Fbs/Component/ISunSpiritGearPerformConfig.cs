using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FB RID: 23035
	public struct ISunSpiritGearPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700AD15 RID: 44309
		// (get) Token: 0x06027184 RID: 160132 RVA: 0x00560E44 File Offset: 0x0055F044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027185 RID: 160133 RVA: 0x00560E51 File Offset: 0x0055F051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027186 RID: 160134 RVA: 0x00560E58 File Offset: 0x0055F058
		public static ISunSpiritGearPerformConfig GetRootAsISunSpiritGearPerformConfig(ByteBuffer _bb)
		{
			return ISunSpiritGearPerformConfig.GetRootAsISunSpiritGearPerformConfig(_bb, default(ISunSpiritGearPerformConfig));
		}

		// Token: 0x06027187 RID: 160135 RVA: 0x00560E74 File Offset: 0x0055F074
		public static ISunSpiritGearPerformConfig GetRootAsISunSpiritGearPerformConfig(ByteBuffer _bb, ISunSpiritGearPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027188 RID: 160136 RVA: 0x00560E91 File Offset: 0x0055F091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027189 RID: 160137 RVA: 0x00560EA0 File Offset: 0x0055F0A0
		public ISunSpiritGearPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD16 RID: 44310
		// (get) Token: 0x0602718A RID: 160138 RVA: 0x00560EB0 File Offset: 0x0055F0B0
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

		// Token: 0x0602718B RID: 160139 RVA: 0x00560EEC File Offset: 0x0055F0EC
		public static Offset<ISunSpiritGearPerformConfig> CreateISunSpiritGearPerformConfig(FlatBufferBuilder builder, ESunSpiritGearPerformType Type = ESunSpiritGearPerformType.ToGearRelativePos)
		{
			builder.StartTable(1);
			ISunSpiritGearPerformConfig.AddType(builder, Type);
			return ISunSpiritGearPerformConfig.EndISunSpiritGearPerformConfig(builder);
		}

		// Token: 0x0602718C RID: 160140 RVA: 0x00560F02 File Offset: 0x0055F102
		public static void StartISunSpiritGearPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602718D RID: 160141 RVA: 0x00560F0B File Offset: 0x0055F10B
		public static void AddType(FlatBufferBuilder builder, ESunSpiritGearPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602718E RID: 160142 RVA: 0x00560F16 File Offset: 0x0055F116
		public static Offset<ISunSpiritGearPerformConfig> EndISunSpiritGearPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602718F RID: 160143 RVA: 0x00560F24 File Offset: 0x0055F124
		public ISunSpiritGearPerformConfigT UnPack()
		{
			ISunSpiritGearPerformConfigT sunSpiritGearPerformConfigT = new ISunSpiritGearPerformConfigT();
			this.UnPackTo(sunSpiritGearPerformConfigT);
			return sunSpiritGearPerformConfigT;
		}

		// Token: 0x06027190 RID: 160144 RVA: 0x00560F3F File Offset: 0x0055F13F
		public void UnPackTo(ISunSpiritGearPerformConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027191 RID: 160145 RVA: 0x00560F50 File Offset: 0x0055F150
		public static Offset<ISunSpiritGearPerformConfig> Pack(FlatBufferBuilder builder, ISunSpiritGearPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearPerformConfig>);
			}
			return ISunSpiritGearPerformConfig.CreateISunSpiritGearPerformConfig(builder, _o.Type);
		}

		// Token: 0x0400F03A RID: 61498
		private Table __p;
	}
}
