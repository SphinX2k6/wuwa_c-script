using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007130 RID: 28976
	public struct ILiveSetUi : IFlatbufferObject
	{
		// Token: 0x1700D426 RID: 54310
		// (get) Token: 0x06032562 RID: 206178 RVA: 0x006CE545 File Offset: 0x006CC745
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032563 RID: 206179 RVA: 0x006CE552 File Offset: 0x006CC752
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032564 RID: 206180 RVA: 0x006CE55C File Offset: 0x006CC75C
		public static ILiveSetUi GetRootAsILiveSetUi(ByteBuffer _bb)
		{
			return ILiveSetUi.GetRootAsILiveSetUi(_bb, default(ILiveSetUi));
		}

		// Token: 0x06032565 RID: 206181 RVA: 0x006CE578 File Offset: 0x006CC778
		public static ILiveSetUi GetRootAsILiveSetUi(ByteBuffer _bb, ILiveSetUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032566 RID: 206182 RVA: 0x006CE595 File Offset: 0x006CC795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032567 RID: 206183 RVA: 0x006CE5A4 File Offset: 0x006CC7A4
		public ILiveSetUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D427 RID: 54311
		// (get) Token: 0x06032568 RID: 206184 RVA: 0x006CE5B4 File Offset: 0x006CC7B4
		public TLiveUiConfig UiConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLiveUiConfig.NONE;
				}
				return (TLiveUiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032569 RID: 206185 RVA: 0x006CE5F0 File Offset: 0x006CC7F0
		public TTable? UiConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603256A RID: 206186 RVA: 0x006CE634 File Offset: 0x006CC834
		public ILiveUiFinishConfig UiConfigAsILiveUiFinishConfig()
		{
			return this.UiConfig<ILiveUiFinishConfig>().Value;
		}

		// Token: 0x0603256B RID: 206187 RVA: 0x006CE650 File Offset: 0x006CC850
		public ILiveUiHideConfig UiConfigAsILiveUiHideConfig()
		{
			return this.UiConfig<ILiveUiHideConfig>().Value;
		}

		// Token: 0x0603256C RID: 206188 RVA: 0x006CE66C File Offset: 0x006CC86C
		public ILiveUiPauseConfig UiConfigAsILiveUiPauseConfig()
		{
			return this.UiConfig<ILiveUiPauseConfig>().Value;
		}

		// Token: 0x0603256D RID: 206189 RVA: 0x006CE688 File Offset: 0x006CC888
		public ILiveUiResumeConfig UiConfigAsILiveUiResumeConfig()
		{
			return this.UiConfig<ILiveUiResumeConfig>().Value;
		}

		// Token: 0x0603256E RID: 206190 RVA: 0x006CE6A4 File Offset: 0x006CC8A4
		public ILiveUiShowConfig UiConfigAsILiveUiShowConfig()
		{
			return this.UiConfig<ILiveUiShowConfig>().Value;
		}

		// Token: 0x0603256F RID: 206191 RVA: 0x006CE6C0 File Offset: 0x006CC8C0
		public ILiveUiStartConfig UiConfigAsILiveUiStartConfig()
		{
			return this.UiConfig<ILiveUiStartConfig>().Value;
		}

		// Token: 0x06032570 RID: 206192 RVA: 0x006CE6DB File Offset: 0x006CC8DB
		public static Offset<ILiveSetUi> CreateILiveSetUi(FlatBufferBuilder builder, TLiveUiConfig UiConfig_type = TLiveUiConfig.NONE, int UiConfigOffset = 0)
		{
			builder.StartTable(2);
			ILiveSetUi.AddUiConfig(builder, UiConfigOffset);
			ILiveSetUi.AddUiConfigType(builder, UiConfig_type);
			return ILiveSetUi.EndILiveSetUi(builder);
		}

		// Token: 0x06032571 RID: 206193 RVA: 0x006CE6F8 File Offset: 0x006CC8F8
		public static void StartILiveSetUi(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032572 RID: 206194 RVA: 0x006CE701 File Offset: 0x006CC901
		public static void AddUiConfigType(FlatBufferBuilder builder, TLiveUiConfig uiConfigType)
		{
			builder.AddByte(0, (byte)uiConfigType, 0);
		}

		// Token: 0x06032573 RID: 206195 RVA: 0x006CE70C File Offset: 0x006CC90C
		public static void AddUiConfig(FlatBufferBuilder builder, int uiConfigOffset)
		{
			builder.AddOffset(1, uiConfigOffset, 0);
		}

		// Token: 0x06032574 RID: 206196 RVA: 0x006CE717 File Offset: 0x006CC917
		public static Offset<ILiveSetUi> EndILiveSetUi(FlatBufferBuilder builder)
		{
			return new Offset<ILiveSetUi>(builder.EndTable());
		}

		// Token: 0x06032575 RID: 206197 RVA: 0x006CE724 File Offset: 0x006CC924
		public ILiveSetUiT UnPack()
		{
			ILiveSetUiT liveSetUiT = new ILiveSetUiT();
			this.UnPackTo(liveSetUiT);
			return liveSetUiT;
		}

		// Token: 0x06032576 RID: 206198 RVA: 0x006CE740 File Offset: 0x006CC940
		public void UnPackTo(ILiveSetUiT _o)
		{
			_o.UiConfig = new TLiveUiConfigUnion();
			_o.UiConfig.Type = this.UiConfigType;
			switch (this.UiConfigType)
			{
			case TLiveUiConfig.ILiveUiFinishConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiFinishConfig>() != null) ? this.UiConfig<ILiveUiFinishConfig>().Value.UnPack() : null);
				return;
			case TLiveUiConfig.ILiveUiHideConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiHideConfig>() != null) ? this.UiConfig<ILiveUiHideConfig>().Value.UnPack() : null);
				return;
			case TLiveUiConfig.ILiveUiPauseConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiPauseConfig>() != null) ? this.UiConfig<ILiveUiPauseConfig>().Value.UnPack() : null);
				return;
			case TLiveUiConfig.ILiveUiResumeConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiResumeConfig>() != null) ? this.UiConfig<ILiveUiResumeConfig>().Value.UnPack() : null);
				return;
			case TLiveUiConfig.ILiveUiShowConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiShowConfig>() != null) ? this.UiConfig<ILiveUiShowConfig>().Value.UnPack() : null);
				return;
			case TLiveUiConfig.ILiveUiStartConfig:
				_o.UiConfig.Value = ((this.UiConfig<ILiveUiStartConfig>() != null) ? this.UiConfig<ILiveUiStartConfig>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06032577 RID: 206199 RVA: 0x006CE8DC File Offset: 0x006CCADC
		public static Offset<ILiveSetUi> Pack(FlatBufferBuilder builder, ILiveSetUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveSetUi>);
			}
			TLiveUiConfig uiConfig_type = (_o.UiConfig == null) ? TLiveUiConfig.NONE : _o.UiConfig.Type;
			int uiConfigOffset = (_o.UiConfig == null) ? 0 : TLiveUiConfigUnion.Pack(builder, _o.UiConfig);
			return ILiveSetUi.CreateILiveSetUi(builder, uiConfig_type, uiConfigOffset);
		}

		// Token: 0x04012115 RID: 74005
		private Table __p;
	}
}
