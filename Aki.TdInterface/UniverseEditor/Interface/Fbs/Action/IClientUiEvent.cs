using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006409 RID: 25609
	public struct IClientUiEvent : IFlatbufferObject
	{
		// Token: 0x1700BEB4 RID: 48820
		// (get) Token: 0x0602C4F5 RID: 181493 RVA: 0x00614FBC File Offset: 0x006131BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C4F6 RID: 181494 RVA: 0x00614FC9 File Offset: 0x006131C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C4F7 RID: 181495 RVA: 0x00614FD0 File Offset: 0x006131D0
		public static IClientUiEvent GetRootAsIClientUiEvent(ByteBuffer _bb)
		{
			return IClientUiEvent.GetRootAsIClientUiEvent(_bb, default(IClientUiEvent));
		}

		// Token: 0x0602C4F8 RID: 181496 RVA: 0x00614FEC File Offset: 0x006131EC
		public static IClientUiEvent GetRootAsIClientUiEvent(ByteBuffer _bb, IClientUiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C4F9 RID: 181497 RVA: 0x00615009 File Offset: 0x00613209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C4FA RID: 181498 RVA: 0x00615018 File Offset: 0x00613218
		public IClientUiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEB5 RID: 48821
		// (get) Token: 0x0602C4FB RID: 181499 RVA: 0x00615028 File Offset: 0x00613228
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BEB6 RID: 48822
		// (get) Token: 0x0602C4FC RID: 181500 RVA: 0x00615064 File Offset: 0x00613264
		public TClientEventUi UiType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientEventUi.NONE;
				}
				return (TClientEventUi)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C4FD RID: 181501 RVA: 0x006150A0 File Offset: 0x006132A0
		public TTable? Ui<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C4FE RID: 181502 RVA: 0x006150E4 File Offset: 0x006132E4
		public IClientEventUiFlyingFlower UiAsIClientEventUiFlyingFlower()
		{
			return this.Ui<IClientEventUiFlyingFlower>().Value;
		}

		// Token: 0x0602C4FF RID: 181503 RVA: 0x00615100 File Offset: 0x00613300
		public IClientEventUiPlayPiano UiAsIClientEventUiPlayPiano()
		{
			return this.Ui<IClientEventUiPlayPiano>().Value;
		}

		// Token: 0x0602C500 RID: 181504 RVA: 0x0061511B File Offset: 0x0061331B
		public static Offset<IClientUiEvent> CreateIClientUiEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self, TClientEventUi Ui_type = TClientEventUi.NONE, int UiOffset = 0)
		{
			builder.StartTable(3);
			IClientUiEvent.AddUi(builder, UiOffset);
			IClientUiEvent.AddUiType(builder, Ui_type);
			IClientUiEvent.AddType(builder, Type);
			return IClientUiEvent.EndIClientUiEvent(builder);
		}

		// Token: 0x0602C501 RID: 181505 RVA: 0x0061513F File Offset: 0x0061333F
		public static void StartIClientUiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C502 RID: 181506 RVA: 0x00615148 File Offset: 0x00613348
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C503 RID: 181507 RVA: 0x00615153 File Offset: 0x00613353
		public static void AddUiType(FlatBufferBuilder builder, TClientEventUi uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x0602C504 RID: 181508 RVA: 0x0061515E File Offset: 0x0061335E
		public static void AddUi(FlatBufferBuilder builder, int uiOffset)
		{
			builder.AddOffset(2, uiOffset, 0);
		}

		// Token: 0x0602C505 RID: 181509 RVA: 0x00615169 File Offset: 0x00613369
		public static Offset<IClientUiEvent> EndIClientUiEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientUiEvent>(builder.EndTable());
		}

		// Token: 0x0602C506 RID: 181510 RVA: 0x00615178 File Offset: 0x00613378
		public IClientUiEventT UnPack()
		{
			IClientUiEventT clientUiEventT = new IClientUiEventT();
			this.UnPackTo(clientUiEventT);
			return clientUiEventT;
		}

		// Token: 0x0602C507 RID: 181511 RVA: 0x00615194 File Offset: 0x00613394
		public void UnPackTo(IClientUiEventT _o)
		{
			_o.Type = this.Type;
			_o.Ui = new TClientEventUiUnion();
			_o.Ui.Type = this.UiType;
			TClientEventUi uiType = this.UiType;
			if (uiType == TClientEventUi.IClientEventUiFlyingFlower)
			{
				_o.Ui.Value = ((this.Ui<IClientEventUiFlyingFlower>() != null) ? this.Ui<IClientEventUiFlyingFlower>().Value.UnPack() : null);
				return;
			}
			if (uiType != TClientEventUi.IClientEventUiPlayPiano)
			{
				return;
			}
			_o.Ui.Value = ((this.Ui<IClientEventUiPlayPiano>() != null) ? this.Ui<IClientEventUiPlayPiano>().Value.UnPack() : null);
		}

		// Token: 0x0602C508 RID: 181512 RVA: 0x00615244 File Offset: 0x00613444
		public static Offset<IClientUiEvent> Pack(FlatBufferBuilder builder, IClientUiEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientUiEvent>);
			}
			TClientEventUi ui_type = (_o.Ui == null) ? TClientEventUi.NONE : _o.Ui.Type;
			int uiOffset = (_o.Ui == null) ? 0 : TClientEventUiUnion.Pack(builder, _o.Ui);
			return IClientUiEvent.CreateIClientUiEvent(builder, _o.Type, ui_type, uiOffset);
		}

		// Token: 0x040109F8 RID: 68088
		private Table __p;
	}
}
