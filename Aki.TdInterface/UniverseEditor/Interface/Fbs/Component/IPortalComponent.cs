using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005769 RID: 22377
	public struct IPortalComponent : IFlatbufferObject
	{
		// Token: 0x1700A6E5 RID: 42725
		// (get) Token: 0x060257FB RID: 153595 RVA: 0x0052C540 File Offset: 0x0052A740
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060257FC RID: 153596 RVA: 0x0052C54D File Offset: 0x0052A74D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060257FD RID: 153597 RVA: 0x0052C554 File Offset: 0x0052A754
		public static IPortalComponent GetRootAsIPortalComponent(ByteBuffer _bb)
		{
			return IPortalComponent.GetRootAsIPortalComponent(_bb, default(IPortalComponent));
		}

		// Token: 0x060257FE RID: 153598 RVA: 0x0052C570 File Offset: 0x0052A770
		public static IPortalComponent GetRootAsIPortalComponent(ByteBuffer _bb, IPortalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060257FF RID: 153599 RVA: 0x0052C58D File Offset: 0x0052A78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025800 RID: 153600 RVA: 0x0052C59C File Offset: 0x0052A79C
		public IPortalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6E6 RID: 42726
		// (get) Token: 0x06025801 RID: 153601 RVA: 0x0052C5AC File Offset: 0x0052A7AC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6E7 RID: 42727
		// (get) Token: 0x06025802 RID: 153602 RVA: 0x0052C5EC File Offset: 0x0052A7EC
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

		// Token: 0x06025803 RID: 153603 RVA: 0x0052C628 File Offset: 0x0052A828
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025804 RID: 153604 RVA: 0x0052C66C File Offset: 0x0052A86C
		public IDynamicPortal ConfigAsIDynamicPortal()
		{
			return this.Config<IDynamicPortal>().Value;
		}

		// Token: 0x06025805 RID: 153605 RVA: 0x0052C688 File Offset: 0x0052A888
		public IStaticPortal ConfigAsIStaticPortal()
		{
			return this.Config<IStaticPortal>().Value;
		}

		// Token: 0x1700A6E8 RID: 42728
		// (get) Token: 0x06025806 RID: 153606 RVA: 0x0052C6A4 File Offset: 0x0052A8A4
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

		// Token: 0x06025807 RID: 153607 RVA: 0x0052C6E1 File Offset: 0x0052A8E1
		public static Offset<IPortalComponent> CreateIPortalComponent(FlatBufferBuilder builder, bool Disabled = false, TPortalConfig Config_type = TPortalConfig.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPortalComponent.AddConfig(builder, ConfigOffset);
			IPortalComponent.AddNullMask(builder, NullMask);
			IPortalComponent.AddConfigType(builder, Config_type);
			IPortalComponent.AddDisabled(builder, Disabled);
			return IPortalComponent.EndIPortalComponent(builder);
		}

		// Token: 0x06025808 RID: 153608 RVA: 0x0052C70D File Offset: 0x0052A90D
		public static void StartIPortalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025809 RID: 153609 RVA: 0x0052C716 File Offset: 0x0052A916
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602580A RID: 153610 RVA: 0x0052C721 File Offset: 0x0052A921
		public static void AddConfigType(FlatBufferBuilder builder, TPortalConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602580B RID: 153611 RVA: 0x0052C72C File Offset: 0x0052A92C
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602580C RID: 153612 RVA: 0x0052C737 File Offset: 0x0052A937
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602580D RID: 153613 RVA: 0x0052C742 File Offset: 0x0052A942
		public static Offset<IPortalComponent> EndIPortalComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPortalComponent>(builder.EndTable());
		}

		// Token: 0x0602580E RID: 153614 RVA: 0x0052C750 File Offset: 0x0052A950
		public IPortalComponentT UnPack()
		{
			IPortalComponentT portalComponentT = new IPortalComponentT();
			this.UnPackTo(portalComponentT);
			return portalComponentT;
		}

		// Token: 0x0602580F RID: 153615 RVA: 0x0052C76C File Offset: 0x0052A96C
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

		// Token: 0x06025810 RID: 153616 RVA: 0x0052C82C File Offset: 0x0052AA2C
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

		// Token: 0x0400EC0C RID: 60428
		private Table __p;
	}
}
