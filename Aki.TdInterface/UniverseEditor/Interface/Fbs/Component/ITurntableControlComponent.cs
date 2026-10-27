using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF3 RID: 23283
	public struct ITurntableControlComponent : IFlatbufferObject
	{
		// Token: 0x1700AFA5 RID: 44965
		// (get) Token: 0x06027BEC RID: 162796 RVA: 0x0057798B File Offset: 0x00575B8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027BED RID: 162797 RVA: 0x00577998 File Offset: 0x00575B98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027BEE RID: 162798 RVA: 0x005779A0 File Offset: 0x00575BA0
		public static ITurntableControlComponent GetRootAsITurntableControlComponent(ByteBuffer _bb)
		{
			return ITurntableControlComponent.GetRootAsITurntableControlComponent(_bb, default(ITurntableControlComponent));
		}

		// Token: 0x06027BEF RID: 162799 RVA: 0x005779BC File Offset: 0x00575BBC
		public static ITurntableControlComponent GetRootAsITurntableControlComponent(ByteBuffer _bb, ITurntableControlComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027BF0 RID: 162800 RVA: 0x005779D9 File Offset: 0x00575BD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027BF1 RID: 162801 RVA: 0x005779E8 File Offset: 0x00575BE8
		public ITurntableControlComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFA6 RID: 44966
		// (get) Token: 0x06027BF2 RID: 162802 RVA: 0x005779F8 File Offset: 0x00575BF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFA7 RID: 44967
		// (get) Token: 0x06027BF3 RID: 162803 RVA: 0x00577A38 File Offset: 0x00575C38
		public TTurntableController ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTurntableController.NONE;
				}
				return (TTurntableController)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027BF4 RID: 162804 RVA: 0x00577A74 File Offset: 0x00575C74
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027BF5 RID: 162805 RVA: 0x00577AB8 File Offset: 0x00575CB8
		public IFixedAngleTurntable ConfigAsIFixedAngleTurntable()
		{
			return this.Config<IFixedAngleTurntable>().Value;
		}

		// Token: 0x06027BF6 RID: 162806 RVA: 0x00577AD4 File Offset: 0x00575CD4
		public IFreeAngleTurntable ConfigAsIFreeAngleTurntable()
		{
			return this.Config<IFreeAngleTurntable>().Value;
		}

		// Token: 0x1700AFA8 RID: 44968
		// (get) Token: 0x06027BF7 RID: 162807 RVA: 0x00577AF0 File Offset: 0x00575CF0
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

		// Token: 0x06027BF8 RID: 162808 RVA: 0x00577B2D File Offset: 0x00575D2D
		public static Offset<ITurntableControlComponent> CreateITurntableControlComponent(FlatBufferBuilder builder, bool Disabled = false, TTurntableController Config_type = TTurntableController.NONE, int ConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITurntableControlComponent.AddConfig(builder, ConfigOffset);
			ITurntableControlComponent.AddNullMask(builder, NullMask);
			ITurntableControlComponent.AddConfigType(builder, Config_type);
			ITurntableControlComponent.AddDisabled(builder, Disabled);
			return ITurntableControlComponent.EndITurntableControlComponent(builder);
		}

		// Token: 0x06027BF9 RID: 162809 RVA: 0x00577B59 File Offset: 0x00575D59
		public static void StartITurntableControlComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027BFA RID: 162810 RVA: 0x00577B62 File Offset: 0x00575D62
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027BFB RID: 162811 RVA: 0x00577B6D File Offset: 0x00575D6D
		public static void AddConfigType(FlatBufferBuilder builder, TTurntableController configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06027BFC RID: 162812 RVA: 0x00577B78 File Offset: 0x00575D78
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06027BFD RID: 162813 RVA: 0x00577B83 File Offset: 0x00575D83
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027BFE RID: 162814 RVA: 0x00577B8E File Offset: 0x00575D8E
		public static Offset<ITurntableControlComponent> EndITurntableControlComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableControlComponent>(builder.EndTable());
		}

		// Token: 0x06027BFF RID: 162815 RVA: 0x00577B9C File Offset: 0x00575D9C
		public ITurntableControlComponentT UnPack()
		{
			ITurntableControlComponentT turntableControlComponentT = new ITurntableControlComponentT();
			this.UnPackTo(turntableControlComponentT);
			return turntableControlComponentT;
		}

		// Token: 0x06027C00 RID: 162816 RVA: 0x00577BB8 File Offset: 0x00575DB8
		public void UnPackTo(ITurntableControlComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new TTurntableControllerUnion();
			_o.Config.Type = this.ConfigType;
			TTurntableController configType = this.ConfigType;
			if (configType != TTurntableController.IFixedAngleTurntable)
			{
				if (configType == TTurntableController.IFreeAngleTurntable)
				{
					_o.Config.Value = ((this.Config<IFreeAngleTurntable>() != null) ? this.Config<IFreeAngleTurntable>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Config.Value = ((this.Config<IFixedAngleTurntable>() != null) ? this.Config<IFixedAngleTurntable>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027C01 RID: 162817 RVA: 0x00577C78 File Offset: 0x00575E78
		public static Offset<ITurntableControlComponent> Pack(FlatBufferBuilder builder, ITurntableControlComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableControlComponent>);
			}
			TTurntableController config_type = (_o.Config == null) ? TTurntableController.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TTurntableControllerUnion.Pack(builder, _o.Config);
			return ITurntableControlComponent.CreateITurntableControlComponent(builder, _o.Disabled, config_type, configOffset, _o.NullMask);
		}

		// Token: 0x0400F1ED RID: 61933
		private Table __p;
	}
}
