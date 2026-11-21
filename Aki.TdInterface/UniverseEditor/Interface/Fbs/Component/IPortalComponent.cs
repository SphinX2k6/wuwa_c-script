using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D70 RID: 23920
	public struct IPortalComponent : IFlatbufferObject
	{
		// Token: 0x1700B009 RID: 45065
		// (get) Token: 0x06027D1B RID: 163099 RVA: 0x005726CC File Offset: 0x005708CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D1C RID: 163100 RVA: 0x005726D9 File Offset: 0x005708D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D1D RID: 163101 RVA: 0x005726E0 File Offset: 0x005708E0
		public static IPortalComponent GetRootAsIPortalComponent(ByteBuffer _bb)
		{
			return IPortalComponent.GetRootAsIPortalComponent(_bb, default(IPortalComponent));
		}

		// Token: 0x06027D1E RID: 163102 RVA: 0x005726FC File Offset: 0x005708FC
		public static IPortalComponent GetRootAsIPortalComponent(ByteBuffer _bb, IPortalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D1F RID: 163103 RVA: 0x00572719 File Offset: 0x00570919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D20 RID: 163104 RVA: 0x00572728 File Offset: 0x00570928
		public IPortalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B00A RID: 45066
		// (get) Token: 0x06027D21 RID: 163105 RVA: 0x00572738 File Offset: 0x00570938
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B00B RID: 45067
		// (get) Token: 0x06027D22 RID: 163106 RVA: 0x00572778 File Offset: 0x00570978
		public TPortalConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPortalConfig.NONE;
				}
				return (TPortalConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027D23 RID: 163107 RVA: 0x005727B4 File Offset: 0x005709B4
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027D24 RID: 163108 RVA: 0x005727F8 File Offset: 0x005709F8
		public IDynamicPortal ConfigAsIDynamicPortal()
		{
			return this.Config<IDynamicPortal>().Value;
		}

		// Token: 0x06027D25 RID: 163109 RVA: 0x00572814 File Offset: 0x00570A14
		public IStaticPortal ConfigAsIStaticPortal()
		{
			return this.Config<IStaticPortal>().Value;
		}

		// Token: 0x1700B00C RID: 45068
		// (get) Token: 0x06027D26 RID: 163110 RVA: 0x00572830 File Offset: 0x00570A30
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

		// Token: 0x06027D27 RID: 163111 RVA: 0x0057286D File Offset: 0x00570A6D
		public static Offset<IPortalComponent> CreateIPortalComponent(FlatBufferBuilder builder, bool Disabled = false, TPortalConfig Config_type = TPortalConfig.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPortalComponent.AddConfig(builder, ConfigOffset);
			IPortalComponent.AddNullMask(builder, NullMask);
			IPortalComponent.AddConfigType(builder, Config_type);
			IPortalComponent.AddDisabled(builder, Disabled);
			return IPortalComponent.EndIPortalComponent(builder);
		}

		// Token: 0x06027D28 RID: 163112 RVA: 0x00572899 File Offset: 0x00570A99
		public static void StartIPortalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027D29 RID: 163113 RVA: 0x005728A2 File Offset: 0x00570AA2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027D2A RID: 163114 RVA: 0x005728AD File Offset: 0x00570AAD
		public static void AddConfigType(FlatBufferBuilder builder, TPortalConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06027D2B RID: 163115 RVA: 0x005728B8 File Offset: 0x00570AB8
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06027D2C RID: 163116 RVA: 0x005728C3 File Offset: 0x00570AC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027D2D RID: 163117 RVA: 0x005728CE File Offset: 0x00570ACE
		public static Offset<IPortalComponent> EndIPortalComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPortalComponent>(builder.EndTable());
		}

		// Token: 0x06027D2E RID: 163118 RVA: 0x005728DC File Offset: 0x00570ADC
		public IPortalComponentT UnPack()
		{
			IPortalComponentT portalComponentT = new IPortalComponentT();
			this.UnPackTo(portalComponentT);
			return portalComponentT;
		}

		// Token: 0x06027D2F RID: 163119 RVA: 0x005728F8 File Offset: 0x00570AF8
		public void UnPackTo(IPortalComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new TPortalConfigUnion();
			_o.Config.Type = this.ConfigType;
			TPortalConfig configType = this.ConfigType;
			if (configType != TPortalConfig.IDynamicPortal)
			{
				if (configType == TPortalConfig.IStaticPortal)
				{
					_o.Config.Value = ((this.Config<IStaticPortal>() != null) ? this.Config<IStaticPortal>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Config.Value = ((this.Config<IDynamicPortal>() != null) ? this.Config<IDynamicPortal>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027D30 RID: 163120 RVA: 0x005729B8 File Offset: 0x00570BB8
		public static Offset<IPortalComponent> Pack(FlatBufferBuilder builder, IPortalComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPortalComponent>);
			}
			TPortalConfig config_type = (_o.Config == null) ? TPortalConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TPortalConfigUnion.Pack(builder, _o.Config);
			return IPortalComponent.CreateIPortalComponent(builder, _o.Disabled, config_type, configOffset, _o.NullMask);
		}

		// Token: 0x0400F8F7 RID: 63735
		private Table __p;
	}
}
