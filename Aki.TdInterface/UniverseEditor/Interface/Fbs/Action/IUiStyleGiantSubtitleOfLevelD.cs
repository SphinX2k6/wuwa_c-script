using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B1 RID: 29873
	public struct IUiStyleGiantSubtitleOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700E2BD RID: 58045
		// (get) Token: 0x060364EE RID: 222446 RVA: 0x0076192C File Offset: 0x0075FB2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364EF RID: 222447 RVA: 0x00761939 File Offset: 0x0075FB39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364F0 RID: 222448 RVA: 0x00761940 File Offset: 0x0075FB40
		public static IUiStyleGiantSubtitleOfLevelD GetRootAsIUiStyleGiantSubtitleOfLevelD(ByteBuffer _bb)
		{
			return IUiStyleGiantSubtitleOfLevelD.GetRootAsIUiStyleGiantSubtitleOfLevelD(_bb, default(IUiStyleGiantSubtitleOfLevelD));
		}

		// Token: 0x060364F1 RID: 222449 RVA: 0x0076195C File Offset: 0x0075FB5C
		public static IUiStyleGiantSubtitleOfLevelD GetRootAsIUiStyleGiantSubtitleOfLevelD(ByteBuffer _bb, IUiStyleGiantSubtitleOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364F2 RID: 222450 RVA: 0x00761979 File Offset: 0x0075FB79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364F3 RID: 222451 RVA: 0x00761988 File Offset: 0x0075FB88
		public IUiStyleGiantSubtitleOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2BE RID: 58046
		// (get) Token: 0x060364F4 RID: 222452 RVA: 0x00761998 File Offset: 0x0075FB98
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

		// Token: 0x1700E2BF RID: 58047
		// (get) Token: 0x060364F5 RID: 222453 RVA: 0x007619D4 File Offset: 0x0075FBD4
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

		// Token: 0x060364F6 RID: 222454 RVA: 0x00761A10 File Offset: 0x0075FC10
		public static Offset<IUiStyleGiantSubtitleOfLevelD> CreateIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle, EGiantSubtitleStyle Style = EGiantSubtitleStyle.Neutral)
		{
			builder.StartTable(2);
			IUiStyleGiantSubtitleOfLevelD.AddStyle(builder, Style);
			IUiStyleGiantSubtitleOfLevelD.AddType(builder, Type);
			return IUiStyleGiantSubtitleOfLevelD.EndIUiStyleGiantSubtitleOfLevelD(builder);
		}

		// Token: 0x060364F7 RID: 222455 RVA: 0x00761A2D File Offset: 0x0075FC2D
		public static void StartIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060364F8 RID: 222456 RVA: 0x00761A36 File Offset: 0x0075FC36
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364F9 RID: 222457 RVA: 0x00761A41 File Offset: 0x0075FC41
		public static void AddStyle(FlatBufferBuilder builder, EGiantSubtitleStyle style)
		{
			builder.AddByte(1, (byte)style, 0);
		}

		// Token: 0x060364FA RID: 222458 RVA: 0x00761A4C File Offset: 0x0075FC4C
		public static Offset<IUiStyleGiantSubtitleOfLevelD> EndIUiStyleGiantSubtitleOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStyleGiantSubtitleOfLevelD>(builder.EndTable());
		}

		// Token: 0x060364FB RID: 222459 RVA: 0x00761A5C File Offset: 0x0075FC5C
		public IUiStyleGiantSubtitleOfLevelDT UnPack()
		{
			IUiStyleGiantSubtitleOfLevelDT uiStyleGiantSubtitleOfLevelDT = new IUiStyleGiantSubtitleOfLevelDT();
			this.UnPackTo(uiStyleGiantSubtitleOfLevelDT);
			return uiStyleGiantSubtitleOfLevelDT;
		}

		// Token: 0x060364FC RID: 222460 RVA: 0x00761A77 File Offset: 0x0075FC77
		public void UnPackTo(IUiStyleGiantSubtitleOfLevelDT _o)
		{
			_o.Type = this.Type;
			_o.Style = this.Style;
		}

		// Token: 0x060364FD RID: 222461 RVA: 0x00761A94 File Offset: 0x0075FC94
		public static Offset<IUiStyleGiantSubtitleOfLevelD> Pack(FlatBufferBuilder builder, IUiStyleGiantSubtitleOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStyleGiantSubtitleOfLevelD>);
			}
			return IUiStyleGiantSubtitleOfLevelD.CreateIUiStyleGiantSubtitleOfLevelD(builder, _o.Type, _o.Style);
		}

		// Token: 0x04012377 RID: 74615
		private Table __p;
	}
}
