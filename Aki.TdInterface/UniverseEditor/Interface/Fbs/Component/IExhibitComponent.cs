using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005733 RID: 22323
	public struct IExhibitComponent : IFlatbufferObject
	{
		// Token: 0x1700A133 RID: 41267
		// (get) Token: 0x06023EA2 RID: 147106 RVA: 0x004EFF77 File Offset: 0x004EE177
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EA3 RID: 147107 RVA: 0x004EFF84 File Offset: 0x004EE184
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EA4 RID: 147108 RVA: 0x004EFF8C File Offset: 0x004EE18C
		public static IExhibitComponent GetRootAsIExhibitComponent(ByteBuffer _bb)
		{
			return IExhibitComponent.GetRootAsIExhibitComponent(_bb, default(IExhibitComponent));
		}

		// Token: 0x06023EA5 RID: 147109 RVA: 0x004EFFA8 File Offset: 0x004EE1A8
		public static IExhibitComponent GetRootAsIExhibitComponent(ByteBuffer _bb, IExhibitComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023EA6 RID: 147110 RVA: 0x004EFFC5 File Offset: 0x004EE1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023EA7 RID: 147111 RVA: 0x004EFFD4 File Offset: 0x004EE1D4
		public IExhibitComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A134 RID: 41268
		// (get) Token: 0x06023EA8 RID: 147112 RVA: 0x004EFFE4 File Offset: 0x004EE1E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A135 RID: 41269
		// (get) Token: 0x06023EA9 RID: 147113 RVA: 0x004F0024 File Offset: 0x004EE224
		public TExhibitConfig ExhibitConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExhibitConfig.NONE;
				}
				return (TExhibitConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023EAA RID: 147114 RVA: 0x004F0060 File Offset: 0x004EE260
		public TTable? ExhibitConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023EAB RID: 147115 RVA: 0x004F00A4 File Offset: 0x004EE2A4
		public IPhantomExhibitConfig ExhibitConfigAsIPhantomExhibitConfig()
		{
			return this.ExhibitConfig<IPhantomExhibitConfig>().Value;
		}

		// Token: 0x06023EAC RID: 147116 RVA: 0x004F00C0 File Offset: 0x004EE2C0
		public IWeaponExhibitConfig ExhibitConfigAsIWeaponExhibitConfig()
		{
			return this.ExhibitConfig<IWeaponExhibitConfig>().Value;
		}

		// Token: 0x1700A136 RID: 41270
		// (get) Token: 0x06023EAD RID: 147117 RVA: 0x004F00DC File Offset: 0x004EE2DC
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

		// Token: 0x06023EAE RID: 147118 RVA: 0x004F0119 File Offset: 0x004EE319
		public static Offset<IExhibitComponent> CreateIExhibitComponent(FlatBufferBuilder builder, bool Disabled = false, TExhibitConfig ExhibitConfig_type = TExhibitConfig.NONE, int ExhibitConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IExhibitComponent.AddExhibitConfig(builder, ExhibitConfigOffset);
			IExhibitComponent.AddNullMask(builder, NullMask);
			IExhibitComponent.AddExhibitConfigType(builder, ExhibitConfig_type);
			IExhibitComponent.AddDisabled(builder, Disabled);
			return IExhibitComponent.EndIExhibitComponent(builder);
		}

		// Token: 0x06023EAF RID: 147119 RVA: 0x004F0145 File Offset: 0x004EE345
		public static void StartIExhibitComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023EB0 RID: 147120 RVA: 0x004F014E File Offset: 0x004EE34E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023EB1 RID: 147121 RVA: 0x004F0159 File Offset: 0x004EE359
		public static void AddExhibitConfigType(FlatBufferBuilder builder, TExhibitConfig exhibitConfigType)
		{
			builder.AddByte(1, (byte)exhibitConfigType, 0);
		}

		// Token: 0x06023EB2 RID: 147122 RVA: 0x004F0164 File Offset: 0x004EE364
		public static void AddExhibitConfig(FlatBufferBuilder builder, int exhibitConfigOffset)
		{
			builder.AddOffset(2, exhibitConfigOffset, 0);
		}

		// Token: 0x06023EB3 RID: 147123 RVA: 0x004F016F File Offset: 0x004EE36F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023EB4 RID: 147124 RVA: 0x004F017A File Offset: 0x004EE37A
		public static Offset<IExhibitComponent> EndIExhibitComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitComponent>(builder.EndTable());
		}

		// Token: 0x06023EB5 RID: 147125 RVA: 0x004F0188 File Offset: 0x004EE388
		public IExhibitComponentT UnPack()
		{
			IExhibitComponentT exhibitComponentT = new IExhibitComponentT();
			this.UnPackTo(exhibitComponentT);
			return exhibitComponentT;
		}

		// Token: 0x06023EB6 RID: 147126 RVA: 0x004F01A4 File Offset: 0x004EE3A4
		public void UnPackTo(IExhibitComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExhibitConfig = new TExhibitConfigUnion();
			_o.ExhibitConfig.Type = this.ExhibitConfigType;
			TExhibitConfig exhibitConfigType = this.ExhibitConfigType;
			if (exhibitConfigType != TExhibitConfig.IPhantomExhibitConfig)
			{
				if (exhibitConfigType == TExhibitConfig.IWeaponExhibitConfig)
				{
					_o.ExhibitConfig.Value = ((this.ExhibitConfig<IWeaponExhibitConfig>() != null) ? this.ExhibitConfig<IWeaponExhibitConfig>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ExhibitConfig.Value = ((this.ExhibitConfig<IPhantomExhibitConfig>() != null) ? this.ExhibitConfig<IPhantomExhibitConfig>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023EB7 RID: 147127 RVA: 0x004F0264 File Offset: 0x004EE464
		public static Offset<IExhibitComponent> Pack(FlatBufferBuilder builder, IExhibitComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitComponent>);
			}
			TExhibitConfig exhibitConfig_type = (_o.ExhibitConfig == null) ? TExhibitConfig.NONE : _o.ExhibitConfig.Type;
			int exhibitConfigOffset = (_o.ExhibitConfig == null) ? 0 : TExhibitConfigUnion.Pack(builder, _o.ExhibitConfig);
			return IExhibitComponent.CreateIExhibitComponent(builder, _o.Disabled, exhibitConfig_type, exhibitConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EED0 RID: 61136
		private Table __p;
	}
}
