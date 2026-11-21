using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A89 RID: 27273
	public struct IClientUiEvent : IFlatbufferObject
	{
		// Token: 0x1700C84E RID: 51278
		// (get) Token: 0x0602ECCB RID: 191691 RVA: 0x00660E48 File Offset: 0x0065F048
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECCC RID: 191692 RVA: 0x00660E55 File Offset: 0x0065F055
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECCD RID: 191693 RVA: 0x00660E5C File Offset: 0x0065F05C
		public static IClientUiEvent GetRootAsIClientUiEvent(ByteBuffer _bb)
		{
			return IClientUiEvent.GetRootAsIClientUiEvent(_bb, default(IClientUiEvent));
		}

		// Token: 0x0602ECCE RID: 191694 RVA: 0x00660E78 File Offset: 0x0065F078
		public static IClientUiEvent GetRootAsIClientUiEvent(ByteBuffer _bb, IClientUiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECCF RID: 191695 RVA: 0x00660E95 File Offset: 0x0065F095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECD0 RID: 191696 RVA: 0x00660EA4 File Offset: 0x0065F0A4
		public IClientUiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C84F RID: 51279
		// (get) Token: 0x0602ECD1 RID: 191697 RVA: 0x00660EB4 File Offset: 0x0065F0B4
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

		// Token: 0x1700C850 RID: 51280
		// (get) Token: 0x0602ECD2 RID: 191698 RVA: 0x00660EF0 File Offset: 0x0065F0F0
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

		// Token: 0x0602ECD3 RID: 191699 RVA: 0x00660F2C File Offset: 0x0065F12C
		public TTable? Ui<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602ECD4 RID: 191700 RVA: 0x00660F70 File Offset: 0x0065F170
		public IClientEventUiFlyingFlower UiAsIClientEventUiFlyingFlower()
		{
			return this.Ui<IClientEventUiFlyingFlower>().Value;
		}

		// Token: 0x0602ECD5 RID: 191701 RVA: 0x00660F8C File Offset: 0x0065F18C
		public IClientEventUiPlayPiano UiAsIClientEventUiPlayPiano()
		{
			return this.Ui<IClientEventUiPlayPiano>().Value;
		}

		// Token: 0x0602ECD6 RID: 191702 RVA: 0x00660FA7 File Offset: 0x0065F1A7
		public static Offset<IClientUiEvent> CreateIClientUiEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self, TClientEventUi Ui_type = TClientEventUi.NONE, int UiOffset = 0)
		{
			builder.StartTable(3);
			IClientUiEvent.AddUi(builder, UiOffset);
			IClientUiEvent.AddUiType(builder, Ui_type);
			IClientUiEvent.AddType(builder, Type);
			return IClientUiEvent.EndIClientUiEvent(builder);
		}

		// Token: 0x0602ECD7 RID: 191703 RVA: 0x00660FCB File Offset: 0x0065F1CB
		public static void StartIClientUiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602ECD8 RID: 191704 RVA: 0x00660FD4 File Offset: 0x0065F1D4
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECD9 RID: 191705 RVA: 0x00660FDF File Offset: 0x0065F1DF
		public static void AddUiType(FlatBufferBuilder builder, TClientEventUi uiType)
		{
			builder.AddByte(1, (byte)uiType, 0);
		}

		// Token: 0x0602ECDA RID: 191706 RVA: 0x00660FEA File Offset: 0x0065F1EA
		public static void AddUi(FlatBufferBuilder builder, int uiOffset)
		{
			builder.AddOffset(2, uiOffset, 0);
		}

		// Token: 0x0602ECDB RID: 191707 RVA: 0x00660FF5 File Offset: 0x0065F1F5
		public static Offset<IClientUiEvent> EndIClientUiEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientUiEvent>(builder.EndTable());
		}

		// Token: 0x0602ECDC RID: 191708 RVA: 0x00661004 File Offset: 0x0065F204
		public IClientUiEventT UnPack()
		{
			IClientUiEventT clientUiEventT = new IClientUiEventT();
			this.UnPackTo(clientUiEventT);
			return clientUiEventT;
		}

		// Token: 0x0602ECDD RID: 191709 RVA: 0x00661020 File Offset: 0x0065F220
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

		// Token: 0x0602ECDE RID: 191710 RVA: 0x006610D0 File Offset: 0x0065F2D0
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

		// Token: 0x0401181E RID: 71710
		private Table __p;
	}
}
