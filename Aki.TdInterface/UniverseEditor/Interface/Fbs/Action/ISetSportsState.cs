using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007079 RID: 28793
	public struct ISetSportsState : IFlatbufferObject
	{
		// Token: 0x1700D5FA RID: 54778
		// (get) Token: 0x06032FA4 RID: 208804 RVA: 0x006E04F6 File Offset: 0x006DE6F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FA5 RID: 208805 RVA: 0x006E0503 File Offset: 0x006DE703
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FA6 RID: 208806 RVA: 0x006E050C File Offset: 0x006DE70C
		public static ISetSportsState GetRootAsISetSportsState(ByteBuffer _bb)
		{
			return ISetSportsState.GetRootAsISetSportsState(_bb, default(ISetSportsState));
		}

		// Token: 0x06032FA7 RID: 208807 RVA: 0x006E0528 File Offset: 0x006DE728
		public static ISetSportsState GetRootAsISetSportsState(ByteBuffer _bb, ISetSportsState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FA8 RID: 208808 RVA: 0x006E0545 File Offset: 0x006DE745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FA9 RID: 208809 RVA: 0x006E0554 File Offset: 0x006DE754
		public ISetSportsState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5FB RID: 54779
		// (get) Token: 0x06032FAA RID: 208810 RVA: 0x006E0564 File Offset: 0x006DE764
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

		// Token: 0x06032FAB RID: 208811 RVA: 0x006E05A0 File Offset: 0x006DE7A0
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032FAC RID: 208812 RVA: 0x006E05E4 File Offset: 0x006DE7E4
		public IPetalGrabConfig ConfigAsIPetalGrabConfig()
		{
			return this.Config<IPetalGrabConfig>().Value;
		}

		// Token: 0x06032FAD RID: 208813 RVA: 0x006E0600 File Offset: 0x006DE800
		public ISkiConfig ConfigAsISkiConfig()
		{
			return this.Config<ISkiConfig>().Value;
		}

		// Token: 0x06032FAE RID: 208814 RVA: 0x006E061C File Offset: 0x006DE81C
		public ISlideConfig ConfigAsISlideConfig()
		{
			return this.Config<ISlideConfig>().Value;
		}

		// Token: 0x06032FAF RID: 208815 RVA: 0x006E0637 File Offset: 0x006DE837
		public static Offset<ISetSportsState> CreateISetSportsState(FlatBufferBuilder builder, TSportState Config_type = TSportState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			ISetSportsState.AddConfig(builder, ConfigOffset);
			ISetSportsState.AddConfigType(builder, Config_type);
			return ISetSportsState.EndISetSportsState(builder);
		}

		// Token: 0x06032FB0 RID: 208816 RVA: 0x006E0654 File Offset: 0x006DE854
		public static void StartISetSportsState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032FB1 RID: 208817 RVA: 0x006E065D File Offset: 0x006DE85D
		public static void AddConfigType(FlatBufferBuilder builder, TSportState configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06032FB2 RID: 208818 RVA: 0x006E0668 File Offset: 0x006DE868
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06032FB3 RID: 208819 RVA: 0x006E0673 File Offset: 0x006DE873
		public static Offset<ISetSportsState> EndISetSportsState(FlatBufferBuilder builder)
		{
			return new Offset<ISetSportsState>(builder.EndTable());
		}

		// Token: 0x06032FB4 RID: 208820 RVA: 0x006E0680 File Offset: 0x006DE880
		public ISetSportsStateT UnPack()
		{
			ISetSportsStateT setSportsStateT = new ISetSportsStateT();
			this.UnPackTo(setSportsStateT);
			return setSportsStateT;
		}

		// Token: 0x06032FB5 RID: 208821 RVA: 0x006E069C File Offset: 0x006DE89C
		public void UnPackTo(ISetSportsStateT _o)
		{
			_o.Config = new TSportStateUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
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

		// Token: 0x06032FB6 RID: 208822 RVA: 0x006E0784 File Offset: 0x006DE984
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

		// Token: 0x04011ADF RID: 72415
		private Table __p;
	}
}
