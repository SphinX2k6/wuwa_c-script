using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711E RID: 28958
	public struct ISkiConfig : IFlatbufferObject
	{
		// Token: 0x1700D745 RID: 55109
		// (get) Token: 0x06033575 RID: 210293 RVA: 0x006EBA25 File Offset: 0x006E9C25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033576 RID: 210294 RVA: 0x006EBA32 File Offset: 0x006E9C32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033577 RID: 210295 RVA: 0x006EBA3C File Offset: 0x006E9C3C
		public static ISkiConfig GetRootAsISkiConfig(ByteBuffer _bb)
		{
			return ISkiConfig.GetRootAsISkiConfig(_bb, default(ISkiConfig));
		}

		// Token: 0x06033578 RID: 210296 RVA: 0x006EBA58 File Offset: 0x006E9C58
		public static ISkiConfig GetRootAsISkiConfig(ByteBuffer _bb, ISkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033579 RID: 210297 RVA: 0x006EBA75 File Offset: 0x006E9C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603357A RID: 210298 RVA: 0x006EBA84 File Offset: 0x006E9C84
		public ISkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D746 RID: 55110
		// (get) Token: 0x0603357B RID: 210299 RVA: 0x006EBA94 File Offset: 0x006E9C94
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D747 RID: 55111
		// (get) Token: 0x0603357C RID: 210300 RVA: 0x006EBAD0 File Offset: 0x006E9CD0
		public TSkiConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSkiConfig.NONE;
				}
				return (TSkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603357D RID: 210301 RVA: 0x006EBB0C File Offset: 0x006E9D0C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603357E RID: 210302 RVA: 0x006EBB50 File Offset: 0x006E9D50
		public IAccelerateSkiConfig ConfigAsIAccelerateSkiConfig()
		{
			return this.Config<IAccelerateSkiConfig>().Value;
		}

		// Token: 0x0603357F RID: 210303 RVA: 0x006EBB6C File Offset: 0x006E9D6C
		public ICloseSkiConfig ConfigAsICloseSkiConfig()
		{
			return this.Config<ICloseSkiConfig>().Value;
		}

		// Token: 0x06033580 RID: 210304 RVA: 0x006EBB88 File Offset: 0x006E9D88
		public IOpenSkiConfig ConfigAsIOpenSkiConfig()
		{
			return this.Config<IOpenSkiConfig>().Value;
		}

		// Token: 0x06033581 RID: 210305 RVA: 0x006EBBA3 File Offset: 0x006E9DA3
		public static Offset<ISkiConfig> CreateISkiConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide, TSkiConfig Config_type = TSkiConfig.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISkiConfig.AddConfig(builder, ConfigOffset);
			ISkiConfig.AddConfigType(builder, Config_type);
			ISkiConfig.AddType(builder, Type);
			return ISkiConfig.EndISkiConfig(builder);
		}

		// Token: 0x06033582 RID: 210306 RVA: 0x006EBBC7 File Offset: 0x006E9DC7
		public static void StartISkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033583 RID: 210307 RVA: 0x006EBBD0 File Offset: 0x006E9DD0
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033584 RID: 210308 RVA: 0x006EBBDB File Offset: 0x006E9DDB
		public static void AddConfigType(FlatBufferBuilder builder, TSkiConfig configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06033585 RID: 210309 RVA: 0x006EBBE6 File Offset: 0x006E9DE6
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06033586 RID: 210310 RVA: 0x006EBBF1 File Offset: 0x006E9DF1
		public static Offset<ISkiConfig> EndISkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISkiConfig>(builder.EndTable());
		}

		// Token: 0x06033587 RID: 210311 RVA: 0x006EBC00 File Offset: 0x006E9E00
		public ISkiConfigT UnPack()
		{
			ISkiConfigT skiConfigT = new ISkiConfigT();
			this.UnPackTo(skiConfigT);
			return skiConfigT;
		}

		// Token: 0x06033588 RID: 210312 RVA: 0x006EBC1C File Offset: 0x006E9E1C
		public void UnPackTo(ISkiConfigT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TSkiConfigUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TSkiConfig.IAccelerateSkiConfig:
				_o.Config.Value = ((this.Config<IAccelerateSkiConfig>() != null) ? this.Config<IAccelerateSkiConfig>().Value.UnPack() : null);
				return;
			case TSkiConfig.ICloseSkiConfig:
				_o.Config.Value = ((this.Config<ICloseSkiConfig>() != null) ? this.Config<ICloseSkiConfig>().Value.UnPack() : null);
				return;
			case TSkiConfig.IOpenSkiConfig:
				_o.Config.Value = ((this.Config<IOpenSkiConfig>() != null) ? this.Config<IOpenSkiConfig>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033589 RID: 210313 RVA: 0x006EBD10 File Offset: 0x006E9F10
		public static Offset<ISkiConfig> Pack(FlatBufferBuilder builder, ISkiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkiConfig>);
			}
			TSkiConfig config_type = (_o.Config == null) ? TSkiConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSkiConfigUnion.Pack(builder, _o.Config);
			return ISkiConfig.CreateISkiConfig(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x04011BB0 RID: 72624
		private Table __p;
	}
}
