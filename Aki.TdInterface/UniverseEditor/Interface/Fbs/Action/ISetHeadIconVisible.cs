using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C7 RID: 30663
	public struct ISetHeadIconVisible : IFlatbufferObject
	{
		// Token: 0x1700E0C8 RID: 57544
		// (get) Token: 0x06035DC4 RID: 220612 RVA: 0x007375EC File Offset: 0x007357EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035DC5 RID: 220613 RVA: 0x007375F9 File Offset: 0x007357F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035DC6 RID: 220614 RVA: 0x00737600 File Offset: 0x00735800
		public static ISetHeadIconVisible GetRootAsISetHeadIconVisible(ByteBuffer _bb)
		{
			return ISetHeadIconVisible.GetRootAsISetHeadIconVisible(_bb, default(ISetHeadIconVisible));
		}

		// Token: 0x06035DC7 RID: 220615 RVA: 0x0073761C File Offset: 0x0073581C
		public static ISetHeadIconVisible GetRootAsISetHeadIconVisible(ByteBuffer _bb, ISetHeadIconVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035DC8 RID: 220616 RVA: 0x00737639 File Offset: 0x00735839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035DC9 RID: 220617 RVA: 0x00737648 File Offset: 0x00735848
		public ISetHeadIconVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0C9 RID: 57545
		// (get) Token: 0x06035DCA RID: 220618 RVA: 0x00737658 File Offset: 0x00735858
		public THeadStyle HeadStyleConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THeadStyle.NONE;
				}
				return (THeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DCB RID: 220619 RVA: 0x00737694 File Offset: 0x00735894
		public TTable? HeadStyleConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035DCC RID: 220620 RVA: 0x007376D8 File Offset: 0x007358D8
		public IHeadStyleMonsterDisplay HeadStyleConfigAsIHeadStyleMonsterDisplay()
		{
			return this.HeadStyleConfig<IHeadStyleMonsterDisplay>().Value;
		}

		// Token: 0x06035DCD RID: 220621 RVA: 0x007376F4 File Offset: 0x007358F4
		public IHeadStyleNormal HeadStyleConfigAsIHeadStyleNormal()
		{
			return this.HeadStyleConfig<IHeadStyleNormal>().Value;
		}

		// Token: 0x06035DCE RID: 220622 RVA: 0x00737710 File Offset: 0x00735910
		public IHeadStyleVoiceOnly HeadStyleConfigAsIHeadStyleVoiceOnly()
		{
			return this.HeadStyleConfig<IHeadStyleVoiceOnly>().Value;
		}

		// Token: 0x06035DCF RID: 220623 RVA: 0x0073772C File Offset: 0x0073592C
		public IHeadStyleWarning HeadStyleConfigAsIHeadStyleWarning()
		{
			return this.HeadStyleConfig<IHeadStyleWarning>().Value;
		}

		// Token: 0x06035DD0 RID: 220624 RVA: 0x00737748 File Offset: 0x00735948
		public IHeadStyleWeakSignal HeadStyleConfigAsIHeadStyleWeakSignal()
		{
			return this.HeadStyleConfig<IHeadStyleWeakSignal>().Value;
		}

		// Token: 0x1700E0CA RID: 57546
		// (get) Token: 0x06035DD1 RID: 220625 RVA: 0x00737764 File Offset: 0x00735964
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035DD2 RID: 220626 RVA: 0x007377A3 File Offset: 0x007359A3
		public static Offset<ISetHeadIconVisible> CreateISetHeadIconVisible(FlatBufferBuilder builder, THeadStyle HeadStyleConfig_type = THeadStyle.NONE, int HeadStyleConfigOffset = 0, bool Visible = false)
		{
			builder.StartTable(3);
			ISetHeadIconVisible.AddHeadStyleConfig(builder, HeadStyleConfigOffset);
			ISetHeadIconVisible.AddVisible(builder, Visible);
			ISetHeadIconVisible.AddHeadStyleConfigType(builder, HeadStyleConfig_type);
			return ISetHeadIconVisible.EndISetHeadIconVisible(builder);
		}

		// Token: 0x06035DD3 RID: 220627 RVA: 0x007377C7 File Offset: 0x007359C7
		public static void StartISetHeadIconVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035DD4 RID: 220628 RVA: 0x007377D0 File Offset: 0x007359D0
		public static void AddHeadStyleConfigType(FlatBufferBuilder builder, THeadStyle headStyleConfigType)
		{
			builder.AddByte(0, (byte)headStyleConfigType, 0);
		}

		// Token: 0x06035DD5 RID: 220629 RVA: 0x007377DB File Offset: 0x007359DB
		public static void AddHeadStyleConfig(FlatBufferBuilder builder, int headStyleConfigOffset)
		{
			builder.AddOffset(1, headStyleConfigOffset, 0);
		}

		// Token: 0x06035DD6 RID: 220630 RVA: 0x007377E6 File Offset: 0x007359E6
		public static void AddVisible(FlatBufferBuilder builder, bool visible)
		{
			builder.AddBool(2, visible, false);
		}

		// Token: 0x06035DD7 RID: 220631 RVA: 0x007377F1 File Offset: 0x007359F1
		public static Offset<ISetHeadIconVisible> EndISetHeadIconVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetHeadIconVisible>(builder.EndTable());
		}

		// Token: 0x06035DD8 RID: 220632 RVA: 0x00737800 File Offset: 0x00735A00
		public ISetHeadIconVisibleT UnPack()
		{
			ISetHeadIconVisibleT setHeadIconVisibleT = new ISetHeadIconVisibleT();
			this.UnPackTo(setHeadIconVisibleT);
			return setHeadIconVisibleT;
		}

		// Token: 0x06035DD9 RID: 220633 RVA: 0x0073781C File Offset: 0x00735A1C
		public void UnPackTo(ISetHeadIconVisibleT _o)
		{
			_o.HeadStyleConfig = new THeadStyleUnion();
			_o.HeadStyleConfig.Type = this.HeadStyleConfigType;
			switch (this.HeadStyleConfigType)
			{
			case THeadStyle.IHeadStyleMonsterDisplay:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleMonsterDisplay>() != null) ? this.HeadStyleConfig<IHeadStyleMonsterDisplay>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleNormal:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleNormal>() != null) ? this.HeadStyleConfig<IHeadStyleNormal>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleVoiceOnly:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleVoiceOnly>() != null) ? this.HeadStyleConfig<IHeadStyleVoiceOnly>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleWarning:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleWarning>() != null) ? this.HeadStyleConfig<IHeadStyleWarning>().Value.UnPack() : null);
				break;
			case THeadStyle.IHeadStyleWeakSignal:
				_o.HeadStyleConfig.Value = ((this.HeadStyleConfig<IHeadStyleWeakSignal>() != null) ? this.HeadStyleConfig<IHeadStyleWeakSignal>().Value.UnPack() : null);
				break;
			}
			_o.Visible = this.Visible;
		}

		// Token: 0x06035DDA RID: 220634 RVA: 0x00737998 File Offset: 0x00735B98
		public static Offset<ISetHeadIconVisible> Pack(FlatBufferBuilder builder, ISetHeadIconVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetHeadIconVisible>);
			}
			THeadStyle headStyleConfig_type = (_o.HeadStyleConfig == null) ? THeadStyle.NONE : _o.HeadStyleConfig.Type;
			int headStyleConfigOffset = (_o.HeadStyleConfig == null) ? 0 : THeadStyleUnion.Pack(builder, _o.HeadStyleConfig);
			return ISetHeadIconVisible.CreateISetHeadIconVisible(builder, headStyleConfig_type, headStyleConfigOffset, _o.Visible);
		}

		// Token: 0x04012A07 RID: 76295
		private Table __p;
	}
}
