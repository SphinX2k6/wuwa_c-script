using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007845 RID: 30789
	public struct ISetSportsState : IFlatbufferObject
	{
		// Token: 0x1700E1DD RID: 57821
		// (get) Token: 0x06036245 RID: 221765 RVA: 0x00740AAA File Offset: 0x0073ECAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036246 RID: 221766 RVA: 0x00740AB7 File Offset: 0x0073ECB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036247 RID: 221767 RVA: 0x00740AC0 File Offset: 0x0073ECC0
		public static ISetSportsState GetRootAsISetSportsState(ByteBuffer _bb)
		{
			return ISetSportsState.GetRootAsISetSportsState(_bb, default(ISetSportsState));
		}

		// Token: 0x06036248 RID: 221768 RVA: 0x00740ADC File Offset: 0x0073ECDC
		public static ISetSportsState GetRootAsISetSportsState(ByteBuffer _bb, ISetSportsState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036249 RID: 221769 RVA: 0x00740AF9 File Offset: 0x0073ECF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603624A RID: 221770 RVA: 0x00740B08 File Offset: 0x0073ED08
		public ISetSportsState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1DE RID: 57822
		// (get) Token: 0x0603624B RID: 221771 RVA: 0x00740B18 File Offset: 0x0073ED18
		public TSportState ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSportState.NONE;
				}
				return (TSportState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603624C RID: 221772 RVA: 0x00740B54 File Offset: 0x0073ED54
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603624D RID: 221773 RVA: 0x00740B98 File Offset: 0x0073ED98
		public IPetalFlyConfig ConfigAsIPetalFlyConfig()
		{
			return this.Config<IPetalFlyConfig>().Value;
		}

		// Token: 0x0603624E RID: 221774 RVA: 0x00740BB4 File Offset: 0x0073EDB4
		public IPetalGrabConfig ConfigAsIPetalGrabConfig()
		{
			return this.Config<IPetalGrabConfig>().Value;
		}

		// Token: 0x0603624F RID: 221775 RVA: 0x00740BD0 File Offset: 0x0073EDD0
		public ISkiConfig ConfigAsISkiConfig()
		{
			return this.Config<ISkiConfig>().Value;
		}

		// Token: 0x06036250 RID: 221776 RVA: 0x00740BEC File Offset: 0x0073EDEC
		public ISlideConfig ConfigAsISlideConfig()
		{
			return this.Config<ISlideConfig>().Value;
		}

		// Token: 0x06036251 RID: 221777 RVA: 0x00740C07 File Offset: 0x0073EE07
		public static Offset<ISetSportsState> CreateISetSportsState(FlatBufferBuilder builder, TSportState Config_type = TSportState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetSportsState.AddConfig(builder, ConfigOffset);
			ISetSportsState.AddConfigType(builder, Config_type);
			return ISetSportsState.EndISetSportsState(builder);
		}

		// Token: 0x06036252 RID: 221778 RVA: 0x00740C24 File Offset: 0x0073EE24
		public static void StartISetSportsState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036253 RID: 221779 RVA: 0x00740C2D File Offset: 0x0073EE2D
		public static void AddConfigType(FlatBufferBuilder builder, TSportState configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06036254 RID: 221780 RVA: 0x00740C38 File Offset: 0x0073EE38
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06036255 RID: 221781 RVA: 0x00740C43 File Offset: 0x0073EE43
		public static Offset<ISetSportsState> EndISetSportsState(FlatBufferBuilder builder)
		{
			return new Offset<ISetSportsState>(builder.EndTable());
		}

		// Token: 0x06036256 RID: 221782 RVA: 0x00740C50 File Offset: 0x0073EE50
		public ISetSportsStateT UnPack()
		{
			ISetSportsStateT setSportsStateT = new ISetSportsStateT();
			this.UnPackTo(setSportsStateT);
			return setSportsStateT;
		}

		// Token: 0x06036257 RID: 221783 RVA: 0x00740C6C File Offset: 0x0073EE6C
		public void UnPackTo(ISetSportsStateT _o)
		{
			_o.Config = new TSportStateUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TSportState.IPetalFlyConfig:
				_o.Config.Value = ((this.Config<IPetalFlyConfig>() != null) ? this.Config<IPetalFlyConfig>().Value.UnPack() : null);
				return;
			case TSportState.IPetalGrabConfig:
				_o.Config.Value = ((this.Config<IPetalGrabConfig>() != null) ? this.Config<IPetalGrabConfig>().Value.UnPack() : null);
				return;
			case TSportState.ISkiConfig:
				_o.Config.Value = ((this.Config<ISkiConfig>() != null) ? this.Config<ISkiConfig>().Value.UnPack() : null);
				return;
			case TSportState.ISlideConfig:
				_o.Config.Value = ((this.Config<ISlideConfig>() != null) ? this.Config<ISlideConfig>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036258 RID: 221784 RVA: 0x00740D90 File Offset: 0x0073EF90
		public static Offset<ISetSportsState> Pack(FlatBufferBuilder builder, ISetSportsStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSportsState>);
			}
			TSportState config_type = (_o.Config == null) ? TSportState.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSportStateUnion.Pack(builder, _o.Config);
			return ISetSportsState.CreateISetSportsState(builder, config_type, configOffset);
		}

		// Token: 0x04012ACD RID: 76493
		private Table __p;
	}
}
