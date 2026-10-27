using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAB RID: 16043
	public struct IInformationViewConfig : IFlatbufferObject
	{
		// Token: 0x17006F60 RID: 28512
		// (get) Token: 0x06016A7C RID: 92796 RVA: 0x003457FF File Offset: 0x003439FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A7D RID: 92797 RVA: 0x0034580C File Offset: 0x00343A0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A7E RID: 92798 RVA: 0x00345814 File Offset: 0x00343A14
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb)
		{
			return IInformationViewConfig.GetRootAsIInformationViewConfig(_bb, default(IInformationViewConfig));
		}

		// Token: 0x06016A7F RID: 92799 RVA: 0x00345830 File Offset: 0x00343A30
		public static IInformationViewConfig GetRootAsIInformationViewConfig(ByteBuffer _bb, IInformationViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A80 RID: 92800 RVA: 0x0034584D File Offset: 0x00343A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A81 RID: 92801 RVA: 0x0034585C File Offset: 0x00343A5C
		public IInformationViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F61 RID: 28513
		// (get) Token: 0x06016A82 RID: 92802 RVA: 0x0034586C File Offset: 0x00343A6C
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

		// Token: 0x06016A83 RID: 92803 RVA: 0x003458A8 File Offset: 0x00343AA8
		public TTable? InformationView<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016A84 RID: 92804 RVA: 0x003458EC File Offset: 0x00343AEC
		public IBossRushBuffInfoView InformationViewAsIBossRushBuffInfoView()
		{
			return this.InformationView<IBossRushBuffInfoView>().Value;
		}

		// Token: 0x06016A85 RID: 92805 RVA: 0x00345908 File Offset: 0x00343B08
		public IDangoAbyssInformationView InformationViewAsIDangoAbyssInformationView()
		{
			return this.InformationView<IDangoAbyssInformationView>().Value;
		}

		// Token: 0x06016A86 RID: 92806 RVA: 0x00345924 File Offset: 0x00343B24
		public ILevelPlayInformationView InformationViewAsILevelPlayInformationView()
		{
			return this.InformationView<ILevelPlayInformationView>().Value;
		}

		// Token: 0x06016A87 RID: 92807 RVA: 0x0034593F File Offset: 0x00343B3F
		public static Offset<IInformationViewConfig> CreateIInformationViewConfig(FlatBufferBuilder builder, TInformationView InformationView_type = TInformationView.NONE, int InformationViewOffset = 0)
		{
			builder.StartTable(2);
			IInformationViewConfig.AddInformationView(builder, InformationViewOffset);
			IInformationViewConfig.AddInformationViewType(builder, InformationView_type);
			return IInformationViewConfig.EndIInformationViewConfig(builder);
		}

		// Token: 0x06016A88 RID: 92808 RVA: 0x0034595C File Offset: 0x00343B5C
		public static void StartIInformationViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016A89 RID: 92809 RVA: 0x00345965 File Offset: 0x00343B65
		public static void AddInformationViewType(FlatBufferBuilder builder, TInformationView informationViewType)
		{
			builder.AddByte(0, (byte)informationViewType, 0);
		}

		// Token: 0x06016A8A RID: 92810 RVA: 0x00345970 File Offset: 0x00343B70
		public static void AddInformationView(FlatBufferBuilder builder, int informationViewOffset)
		{
			builder.AddOffset(1, informationViewOffset, 0);
		}

		// Token: 0x06016A8B RID: 92811 RVA: 0x0034597B File Offset: 0x00343B7B
		public static Offset<IInformationViewConfig> EndIInformationViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewConfig>(builder.EndTable());
		}

		// Token: 0x06016A8C RID: 92812 RVA: 0x00345988 File Offset: 0x00343B88
		public IInformationViewConfigT UnPack()
		{
			IInformationViewConfigT informationViewConfigT = new IInformationViewConfigT();
			this.UnPackTo(informationViewConfigT);
			return informationViewConfigT;
		}

		// Token: 0x06016A8D RID: 92813 RVA: 0x003459A4 File Offset: 0x00343BA4
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

		// Token: 0x06016A8E RID: 92814 RVA: 0x00345A8C File Offset: 0x00343C8C
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

		// Token: 0x0400B878 RID: 47224
		private Table __p;
	}
}
