using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E9 RID: 17129
	public struct IInformationViewConfig : IFlatbufferObject
	{
		// Token: 0x1700754D RID: 30029
		// (get) Token: 0x060180C9 RID: 98505 RVA: 0x0036E787 File Offset: 0x0036C987
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180CA RID: 98506 RVA: 0x0036E794 File Offset: 0x0036C994
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180CB RID: 98507 RVA: 0x0036E79C File Offset: 0x0036C99C
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb)
		{
			return IInformationViewConfig.GetRootAsIInformationViewConfig(_bb, default(IInformationViewConfig));
		}

		// Token: 0x060180CC RID: 98508 RVA: 0x0036E7B8 File Offset: 0x0036C9B8
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb, IInformationViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180CD RID: 98509 RVA: 0x0036E7D5 File Offset: 0x0036C9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180CE RID: 98510 RVA: 0x0036E7E4 File Offset: 0x0036C9E4
		public IInformationViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700754E RID: 30030
		// (get) Token: 0x060180CF RID: 98511 RVA: 0x0036E7F4 File Offset: 0x0036C9F4
		public TInformationView InformationViewType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TInformationView.NONE;
				}
				return (TInformationView)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180D0 RID: 98512 RVA: 0x0036E830 File Offset: 0x0036CA30
		public TTable? InformationView<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060180D1 RID: 98513 RVA: 0x0036E874 File Offset: 0x0036CA74
		public IBossRushBuffInfoView InformationViewAsIBossRushBuffInfoView()
		{
			return this.InformationView<IBossRushBuffInfoView>().Value;
		}

		// Token: 0x060180D2 RID: 98514 RVA: 0x0036E890 File Offset: 0x0036CA90
		public IDangoAbyssInformationView InformationViewAsIDangoAbyssInformationView()
		{
			return this.InformationView<IDangoAbyssInformationView>().Value;
		}

		// Token: 0x060180D3 RID: 98515 RVA: 0x0036E8AC File Offset: 0x0036CAAC
		public ILevelPlayInformationView InformationViewAsILevelPlayInformationView()
		{
			return this.InformationView<ILevelPlayInformationView>().Value;
		}

		// Token: 0x060180D4 RID: 98516 RVA: 0x0036E8C7 File Offset: 0x0036CAC7
		public static Offset<IInformationViewConfig> CreateIInformationViewConfig(FlatBufferBuilder builder, TInformationView InformationView_type = TInformationView.NONE, int InformationViewOffset = 0)
		{
			builder.StartTable(2);
			IInformationViewConfig.AddInformationView(builder, InformationViewOffset);
			IInformationViewConfig.AddInformationViewType(builder, InformationView_type);
			return IInformationViewConfig.EndIInformationViewConfig(builder);
		}

		// Token: 0x060180D5 RID: 98517 RVA: 0x0036E8E4 File Offset: 0x0036CAE4
		public static void StartIInformationViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060180D6 RID: 98518 RVA: 0x0036E8ED File Offset: 0x0036CAED
		public static void AddInformationViewType(FlatBufferBuilder builder, TInformationView informationViewType)
		{
			builder.AddByte(0, (byte)informationViewType, 0);
		}

		// Token: 0x060180D7 RID: 98519 RVA: 0x0036E8F8 File Offset: 0x0036CAF8
		public static void AddInformationView(FlatBufferBuilder builder, int informationViewOffset)
		{
			builder.AddOffset(1, informationViewOffset, 0);
		}

		// Token: 0x060180D8 RID: 98520 RVA: 0x0036E903 File Offset: 0x0036CB03
		public static Offset<IInformationViewConfig> EndIInformationViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewConfig>(builder.EndTable());
		}

		// Token: 0x060180D9 RID: 98521 RVA: 0x0036E910 File Offset: 0x0036CB10
		public IInformationViewConfigT UnPack()
		{
			IInformationViewConfigT informationViewConfigT = new IInformationViewConfigT();
			this.UnPackTo(informationViewConfigT);
			return informationViewConfigT;
		}

		// Token: 0x060180DA RID: 98522 RVA: 0x0036E92C File Offset: 0x0036CB2C
		public void UnPackTo(IInformationViewConfigT _o)
		{
			_o.InformationView = new TInformationViewUnion();
			_o.InformationView.Type = this.InformationViewType;
			switch (this.InformationViewType)
			{
			case TInformationView.IBossRushBuffInfoView:
				_o.InformationView.Value = ((this.InformationView<IBossRushBuffInfoView>() != null) ? this.InformationView<IBossRushBuffInfoView>().Value.UnPack() : null);
				return;
			case TInformationView.IDangoAbyssInformationView:
				_o.InformationView.Value = ((this.InformationView<IDangoAbyssInformationView>() != null) ? this.InformationView<IDangoAbyssInformationView>().Value.UnPack() : null);
				return;
			case TInformationView.ILevelPlayInformationView:
				_o.InformationView.Value = ((this.InformationView<ILevelPlayInformationView>() != null) ? this.InformationView<ILevelPlayInformationView>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060180DB RID: 98523 RVA: 0x0036EA14 File Offset: 0x0036CC14
		public static Offset<IInformationViewConfig> Pack(FlatBufferBuilder builder, IInformationViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewConfig>);
			}
			TInformationView informationView_type = (_o.InformationView == null) ? TInformationView.NONE : _o.InformationView.Type;
			int informationViewOffset = (_o.InformationView == null) ? 0 : TInformationViewUnion.Pack(builder, _o.InformationView);
			return IInformationViewConfig.CreateIInformationViewConfig(builder, informationView_type, informationViewOffset);
		}

		// Token: 0x0400C254 RID: 49748
		private Table __p;
	}
}
