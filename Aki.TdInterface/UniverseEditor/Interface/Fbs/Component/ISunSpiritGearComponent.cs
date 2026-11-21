using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006005 RID: 24581
	public struct ISunSpiritGearComponent : IFlatbufferObject
	{
		// Token: 0x1700B646 RID: 46662
		// (get) Token: 0x060296DE RID: 169694 RVA: 0x005A79F7 File Offset: 0x005A5BF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296DF RID: 169695 RVA: 0x005A7A04 File Offset: 0x005A5C04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296E0 RID: 169696 RVA: 0x005A7A0C File Offset: 0x005A5C0C
		public static ISunSpiritGearComponent GetRootAsISunSpiritGearComponent(ByteBuffer _bb)
		{
			return ISunSpiritGearComponent.GetRootAsISunSpiritGearComponent(_bb, default(ISunSpiritGearComponent));
		}

		// Token: 0x060296E1 RID: 169697 RVA: 0x005A7A28 File Offset: 0x005A5C28
		public static ISunSpiritGearComponent GetRootAsISunSpiritGearComponent(ByteBuffer _bb, ISunSpiritGearComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296E2 RID: 169698 RVA: 0x005A7A45 File Offset: 0x005A5C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296E3 RID: 169699 RVA: 0x005A7A54 File Offset: 0x005A5C54
		public ISunSpiritGearComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B647 RID: 46663
		// (get) Token: 0x060296E4 RID: 169700 RVA: 0x005A7A64 File Offset: 0x005A5C64
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B648 RID: 46664
		// (get) Token: 0x060296E5 RID: 169701 RVA: 0x005A7AA4 File Offset: 0x005A5CA4
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

		// Token: 0x060296E6 RID: 169702 RVA: 0x005A7AE0 File Offset: 0x005A5CE0
		public TTable? PerformConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060296E7 RID: 169703 RVA: 0x005A7B24 File Offset: 0x005A5D24
		public ISunSpiritGearPerformScaleUp PerformConfigAsISunSpiritGearPerformScaleUp()
		{
			return this.PerformConfig<ISunSpiritGearPerformScaleUp>().Value;
		}

		// Token: 0x060296E8 RID: 169704 RVA: 0x005A7B40 File Offset: 0x005A5D40
		public ISunSpiritGearPerformToGearRelativePos PerformConfigAsISunSpiritGearPerformToGearRelativePos()
		{
			return this.PerformConfig<ISunSpiritGearPerformToGearRelativePos>().Value;
		}

		// Token: 0x1700B649 RID: 46665
		// (get) Token: 0x060296E9 RID: 169705 RVA: 0x005A7B5C File Offset: 0x005A5D5C
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

		// Token: 0x060296EA RID: 169706 RVA: 0x005A7B99 File Offset: 0x005A5D99
		public static Offset<ISunSpiritGearComponent> CreateISunSpiritGearComponent(FlatBufferBuilder builder, bool Disabled = false, TSunSpiritGearPerformConfig PerformConfig_type = TSunSpiritGearPerformConfig.NONE, int PerformConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISunSpiritGearComponent.AddPerformConfig(builder, PerformConfigOffset);
			ISunSpiritGearComponent.AddNullMask(builder, NullMask);
			ISunSpiritGearComponent.AddPerformConfigType(builder, PerformConfig_type);
			ISunSpiritGearComponent.AddDisabled(builder, Disabled);
			return ISunSpiritGearComponent.EndISunSpiritGearComponent(builder);
		}

		// Token: 0x060296EB RID: 169707 RVA: 0x005A7BC5 File Offset: 0x005A5DC5
		public static void StartISunSpiritGearComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060296EC RID: 169708 RVA: 0x005A7BCE File Offset: 0x005A5DCE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060296ED RID: 169709 RVA: 0x005A7BD9 File Offset: 0x005A5DD9
		public static void AddPerformConfigType(FlatBufferBuilder builder, TSunSpiritGearPerformConfig performConfigType)
		{
			builder.AddByte(1, (byte)performConfigType, 0);
		}

		// Token: 0x060296EE RID: 169710 RVA: 0x005A7BE4 File Offset: 0x005A5DE4
		public static void AddPerformConfig(FlatBufferBuilder builder, int performConfigOffset)
		{
			builder.AddOffset(2, performConfigOffset, 0);
		}

		// Token: 0x060296EF RID: 169711 RVA: 0x005A7BEF File Offset: 0x005A5DEF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060296F0 RID: 169712 RVA: 0x005A7BFA File Offset: 0x005A5DFA
		public static Offset<ISunSpiritGearComponent> EndISunSpiritGearComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritGearComponent>(builder.EndTable());
		}

		// Token: 0x060296F1 RID: 169713 RVA: 0x005A7C08 File Offset: 0x005A5E08
		public ISunSpiritGearComponentT UnPack()
		{
			ISunSpiritGearComponentT sunSpiritGearComponentT = new ISunSpiritGearComponentT();
			this.UnPackTo(sunSpiritGearComponentT);
			return sunSpiritGearComponentT;
		}

		// Token: 0x060296F2 RID: 169714 RVA: 0x005A7C24 File Offset: 0x005A5E24
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

		// Token: 0x060296F3 RID: 169715 RVA: 0x005A7CE4 File Offset: 0x005A5EE4
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

		// Token: 0x0400FD2D RID: 64813
		private Table __p;
	}
}
