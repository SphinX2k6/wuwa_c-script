using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F8 RID: 23032
	public struct ISunSpiritGearComponent : IFlatbufferObject
	{
		// Token: 0x1700AD0E RID: 44302
		// (get) Token: 0x06027166 RID: 160102 RVA: 0x00560A33 File Offset: 0x0055EC33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027167 RID: 160103 RVA: 0x00560A40 File Offset: 0x0055EC40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027168 RID: 160104 RVA: 0x00560A48 File Offset: 0x0055EC48
		public static ISunSpiritGearComponent GetRootAsISunSpiritGearComponent(ByteBuffer _bb)
		{
			return ISunSpiritGearComponent.GetRootAsISunSpiritGearComponent(_bb, default(ISunSpiritGearComponent));
		}

		// Token: 0x06027169 RID: 160105 RVA: 0x00560A64 File Offset: 0x0055EC64
		public static ISunSpiritGearComponent GetRootAsISunSpiritGearComponent(ByteBuffer _bb, ISunSpiritGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602716A RID: 160106 RVA: 0x00560A81 File Offset: 0x0055EC81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602716B RID: 160107 RVA: 0x00560A90 File Offset: 0x0055EC90
		public ISunSpiritGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD0F RID: 44303
		// (get) Token: 0x0602716C RID: 160108 RVA: 0x00560AA0 File Offset: 0x0055ECA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD10 RID: 44304
		// (get) Token: 0x0602716D RID: 160109 RVA: 0x00560AE0 File Offset: 0x0055ECE0
		public TSunSpiritGearPerformConfig PerformConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSunSpiritGearPerformConfig.NONE;
				}
				return (TSunSpiritGearPerformConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602716E RID: 160110 RVA: 0x00560B1C File Offset: 0x0055ED1C
		public TTable? PerformConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602716F RID: 160111 RVA: 0x00560B60 File Offset: 0x0055ED60
		public ISunSpiritGearPerformScaleUp PerformConfigAsISunSpiritGearPerformScaleUp()
		{
			return this.PerformConfig<ISunSpiritGearPerformScaleUp>().Value;
		}

		// Token: 0x06027170 RID: 160112 RVA: 0x00560B7C File Offset: 0x0055ED7C
		public ISunSpiritGearPerformToGearRelativePos PerformConfigAsISunSpiritGearPerformToGearRelativePos()
		{
			return this.PerformConfig<ISunSpiritGearPerformToGearRelativePos>().Value;
		}

		// Token: 0x1700AD11 RID: 44305
		// (get) Token: 0x06027171 RID: 160113 RVA: 0x00560B98 File Offset: 0x0055ED98
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

		// Token: 0x06027172 RID: 160114 RVA: 0x00560BD5 File Offset: 0x0055EDD5
		public static Offset<ISunSpiritGearComponent> CreateISunSpiritGearComponent(FlatBufferBuilder builder, bool Disabled = false, TSunSpiritGearPerformConfig PerformConfig_type = TSunSpiritGearPerformConfig.NONE, int PerformConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISunSpiritGearComponent.AddPerformConfig(builder, PerformConfigOffset);
			ISunSpiritGearComponent.AddNullMask(builder, NullMask);
			ISunSpiritGearComponent.AddPerformConfigType(builder, PerformConfig_type);
			ISunSpiritGearComponent.AddDisabled(builder, Disabled);
			return ISunSpiritGearComponent.EndISunSpiritGearComponent(builder);
		}

		// Token: 0x06027173 RID: 160115 RVA: 0x00560C01 File Offset: 0x0055EE01
		public static void StartISunSpiritGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027174 RID: 160116 RVA: 0x00560C0A File Offset: 0x0055EE0A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027175 RID: 160117 RVA: 0x00560C15 File Offset: 0x0055EE15
		public static void AddPerformConfigType(FlatBufferBuilder builder, TSunSpiritGearPerformConfig performConfigType)
		{
			builder.AddByte(1, (byte)performConfigType, 0);
		}

		// Token: 0x06027176 RID: 160118 RVA: 0x00560C20 File Offset: 0x0055EE20
		public static void AddPerformConfig(FlatBufferBuilder builder, int performConfigOffset)
		{
			builder.AddOffset(2, performConfigOffset, 0);
		}

		// Token: 0x06027177 RID: 160119 RVA: 0x00560C2B File Offset: 0x0055EE2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027178 RID: 160120 RVA: 0x00560C36 File Offset: 0x0055EE36
		public static Offset<ISunSpiritGearComponent> EndISunSpiritGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearComponent>(builder.EndTable());
		}

		// Token: 0x06027179 RID: 160121 RVA: 0x00560C44 File Offset: 0x0055EE44
		public ISunSpiritGearComponentT UnPack()
		{
			ISunSpiritGearComponentT sunSpiritGearComponentT = new ISunSpiritGearComponentT();
			this.UnPackTo(sunSpiritGearComponentT);
			return sunSpiritGearComponentT;
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x00560C60 File Offset: 0x0055EE60
		public void UnPackTo(ISunSpiritGearComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.PerformConfig = new TSunSpiritGearPerformConfigUnion();
			_o.PerformConfig.Type = this.PerformConfigType;
			TSunSpiritGearPerformConfig performConfigType = this.PerformConfigType;
			if (performConfigType != TSunSpiritGearPerformConfig.ISunSpiritGearPerformScaleUp)
			{
				if (performConfigType == TSunSpiritGearPerformConfig.ISunSpiritGearPerformToGearRelativePos)
				{
					_o.PerformConfig.Value = ((this.PerformConfig<ISunSpiritGearPerformToGearRelativePos>() != null) ? this.PerformConfig<ISunSpiritGearPerformToGearRelativePos>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.PerformConfig.Value = ((this.PerformConfig<ISunSpiritGearPerformScaleUp>() != null) ? this.PerformConfig<ISunSpiritGearPerformScaleUp>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602717B RID: 160123 RVA: 0x00560D20 File Offset: 0x0055EF20
		public static Offset<ISunSpiritGearComponent> Pack(FlatBufferBuilder builder, ISunSpiritGearComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritGearComponent>);
			}
			TSunSpiritGearPerformConfig performConfig_type = (_o.PerformConfig == null) ? TSunSpiritGearPerformConfig.NONE : _o.PerformConfig.Type;
			int performConfigOffset = (_o.PerformConfig == null) ? 0 : TSunSpiritGearPerformConfigUnion.Pack(builder, _o.PerformConfig);
			return ISunSpiritGearComponent.CreateISunSpiritGearComponent(builder, _o.Disabled, performConfig_type, performConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F036 RID: 61494
		private Table __p;
	}
}
