using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA7 RID: 31911
	public struct IUiStyleGiantSubtitleOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700EEE1 RID: 61153
		// (get) Token: 0x060398F7 RID: 235767 RVA: 0x007C49B8 File Offset: 0x007C2BB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060398F8 RID: 235768 RVA: 0x007C49C5 File Offset: 0x007C2BC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060398F9 RID: 235769 RVA: 0x007C49CC File Offset: 0x007C2BCC
		public static IUiStyleGiantSubtitleOfLevelD GetRootAsIUiStyleGiantSubtitleOfLevelD(ByteBuffer _bb)
		{
			return IUiStyleGiantSubtitleOfLevelD.GetRootAsIUiStyleGiantSubtitleOfLevelD(_bb, default(IUiStyleGiantSubtitleOfLevelD));
		}

		// Token: 0x060398FA RID: 235770 RVA: 0x007C49E8 File Offset: 0x007C2BE8
		public static IUiStyleGiantSubtitleOfLevelD GetRootAsIUiStyleGiantSubtitleOfLevelD(ByteBuffer _bb, IUiStyleGiantSubtitleOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060398FB RID: 235771 RVA: 0x007C4A05 File Offset: 0x007C2C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060398FC RID: 235772 RVA: 0x007C4A14 File Offset: 0x007C2C14
		public IUiStyleGiantSubtitleOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEE2 RID: 61154
		// (get) Token: 0x060398FD RID: 235773 RVA: 0x007C4A24 File Offset: 0x007C2C24
		public EUiStyleTypeOfLevelD Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return (EUiStyleTypeOfLevelD)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EEE3 RID: 61155
		// (get) Token: 0x060398FE RID: 235774 RVA: 0x007C4A60 File Offset: 0x007C2C60
		public EGiantSubtitleStyle Style
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantSubtitleStyle.Neutral;
				}
				return (EGiantSubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060398FF RID: 235775 RVA: 0x007C4A9C File Offset: 0x007C2C9C
		public static Offset<IUiStyleGiantSubtitleOfLevelD> CreateIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle, EGiantSubtitleStyle Style = EGiantSubtitleStyle.Neutral)
		{
			builder.StartTable(2);
			IUiStyleGiantSubtitleOfLevelD.AddStyle(builder, Style);
			IUiStyleGiantSubtitleOfLevelD.AddType(builder, Type);
			return IUiStyleGiantSubtitleOfLevelD.EndIUiStyleGiantSubtitleOfLevelD(builder);
		}

		// Token: 0x06039900 RID: 235776 RVA: 0x007C4AB9 File Offset: 0x007C2CB9
		public static void StartIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039901 RID: 235777 RVA: 0x007C4AC2 File Offset: 0x007C2CC2
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039902 RID: 235778 RVA: 0x007C4ACD File Offset: 0x007C2CCD
		public static void AddStyle(FlatBufferBuilder builder, EGiantSubtitleStyle style)
		{
			builder.AddByte(1, (byte)style, 0);
		}

		// Token: 0x06039903 RID: 235779 RVA: 0x007C4AD8 File Offset: 0x007C2CD8
		public static Offset<IUiStyleGiantSubtitleOfLevelD> EndIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStyleGiantSubtitleOfLevelD>(builder.EndTable());
		}

		// Token: 0x06039904 RID: 235780 RVA: 0x007C4AE8 File Offset: 0x007C2CE8
		public IUiStyleGiantSubtitleOfLevelDT UnPack()
		{
			IUiStyleGiantSubtitleOfLevelDT uiStyleGiantSubtitleOfLevelDT = new IUiStyleGiantSubtitleOfLevelDT();
			this.UnPackTo(uiStyleGiantSubtitleOfLevelDT);
			return uiStyleGiantSubtitleOfLevelDT;
		}

		// Token: 0x06039905 RID: 235781 RVA: 0x007C4B03 File Offset: 0x007C2D03
		public void UnPackTo(IUiStyleGiantSubtitleOfLevelDT _o)
		{
			_o.Type = this.Type;
			_o.Style = this.Style;
		}

		// Token: 0x06039906 RID: 235782 RVA: 0x007C4B20 File Offset: 0x007C2D20
		public static Offset<IUiStyleGiantSubtitleOfLevelD> Pack(FlatBufferBuilder builder, IUiStyleGiantSubtitleOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStyleGiantSubtitleOfLevelD>);
			}
			return IUiStyleGiantSubtitleOfLevelD.CreateIUiStyleGiantSubtitleOfLevelD(builder, _o.Type, _o.Style);
		}

		// Token: 0x040133A5 RID: 78757
		private Table __p;
	}
}
