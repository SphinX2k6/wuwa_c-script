using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B4 RID: 29876
	public struct IUiStylePlayPianoOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700E2C2 RID: 58050
		// (get) Token: 0x06036504 RID: 222468 RVA: 0x00761B2A File Offset: 0x0075FD2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036505 RID: 222469 RVA: 0x00761B37 File Offset: 0x0075FD37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036506 RID: 222470 RVA: 0x00761B40 File Offset: 0x0075FD40
		public static IUiStylePlayPianoOfLevelD GetRootAsIUiStylePlayPianoOfLevelD(ByteBuffer _bb)
		{
			return IUiStylePlayPianoOfLevelD.GetRootAsIUiStylePlayPianoOfLevelD(_bb, default(IUiStylePlayPianoOfLevelD));
		}

		// Token: 0x06036507 RID: 222471 RVA: 0x00761B5C File Offset: 0x0075FD5C
		public static IUiStylePlayPianoOfLevelD GetRootAsIUiStylePlayPianoOfLevelD(ByteBuffer _bb, IUiStylePlayPianoOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036508 RID: 222472 RVA: 0x00761B79 File Offset: 0x0075FD79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036509 RID: 222473 RVA: 0x00761B88 File Offset: 0x0075FD88
		public IUiStylePlayPianoOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2C3 RID: 58051
		// (get) Token: 0x0603650A RID: 222474 RVA: 0x00761B98 File Offset: 0x0075FD98
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

		// Token: 0x1700E2C4 RID: 58052
		// (get) Token: 0x0603650B RID: 222475 RVA: 0x00761BD4 File Offset: 0x0075FDD4
		public IVector2? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E2C5 RID: 58053
		// (get) Token: 0x0603650C RID: 222476 RVA: 0x00761C34 File Offset: 0x0075FE34
		public IVector2? TextBoxSize
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E2C6 RID: 58054
		// (get) Token: 0x0603650D RID: 222477 RVA: 0x00761C94 File Offset: 0x0075FE94
		public int FontSize
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E2C7 RID: 58055
		// (get) Token: 0x0603650E RID: 222478 RVA: 0x00761CD4 File Offset: 0x0075FED4
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603650F RID: 222479 RVA: 0x00761D15 File Offset: 0x0075FF15
		public static Offset<IUiStylePlayPianoOfLevelD> CreateIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle, Offset<IVector2> PositionOffset = default(Offset<IVector2>), Offset<IVector2> TextBoxSizeOffset = default(Offset<IVector2>), int FontSize = 0, float Duration = 0f)
		{
			builder.StartTable(5);
			IUiStylePlayPianoOfLevelD.AddDuration(builder, Duration);
			IUiStylePlayPianoOfLevelD.AddFontSize(builder, FontSize);
			IUiStylePlayPianoOfLevelD.AddTextBoxSize(builder, TextBoxSizeOffset);
			IUiStylePlayPianoOfLevelD.AddPosition(builder, PositionOffset);
			IUiStylePlayPianoOfLevelD.AddType(builder, Type);
			return IUiStylePlayPianoOfLevelD.EndIUiStylePlayPianoOfLevelD(builder);
		}

		// Token: 0x06036510 RID: 222480 RVA: 0x00761D49 File Offset: 0x0075FF49
		public static void StartIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036511 RID: 222481 RVA: 0x00761D52 File Offset: 0x0075FF52
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036512 RID: 222482 RVA: 0x00761D5D File Offset: 0x0075FF5D
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06036513 RID: 222483 RVA: 0x00761D6D File Offset: 0x0075FF6D
		public static void AddTextBoxSize(FlatBufferBuilder builder, Offset<IVector2> textBoxSizeOffset)
		{
			builder.AddOffset(2, textBoxSizeOffset.Value, 0);
		}

		// Token: 0x06036514 RID: 222484 RVA: 0x00761D7D File Offset: 0x0075FF7D
		public static void AddFontSize(FlatBufferBuilder builder, int fontSize)
		{
			builder.AddInt(3, fontSize, 0);
		}

		// Token: 0x06036515 RID: 222485 RVA: 0x00761D88 File Offset: 0x0075FF88
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x06036516 RID: 222486 RVA: 0x00761D9B File Offset: 0x0075FF9B
		public static Offset<IUiStylePlayPianoOfLevelD> EndIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStylePlayPianoOfLevelD>(builder.EndTable());
		}

		// Token: 0x06036517 RID: 222487 RVA: 0x00761DA8 File Offset: 0x0075FFA8
		public IUiStylePlayPianoOfLevelDT UnPack()
		{
			IUiStylePlayPianoOfLevelDT uiStylePlayPianoOfLevelDT = new IUiStylePlayPianoOfLevelDT();
			this.UnPackTo(uiStylePlayPianoOfLevelDT);
			return uiStylePlayPianoOfLevelDT;
		}

		// Token: 0x06036518 RID: 222488 RVA: 0x00761DC4 File Offset: 0x0075FFC4
		public void UnPackTo(IUiStylePlayPianoOfLevelDT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.TextBoxSize = ((this.TextBoxSize != null) ? this.TextBoxSize.Value.UnPack() : null);
			_o.FontSize = this.FontSize;
			_o.Duration = this.Duration;
		}

		// Token: 0x06036519 RID: 222489 RVA: 0x00761E54 File Offset: 0x00760054
		public static Offset<IUiStylePlayPianoOfLevelD> Pack(FlatBufferBuilder builder, IUiStylePlayPianoOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStylePlayPianoOfLevelD>);
			}
			Offset<IVector2> positionOffset = (_o.Position == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Position);
			Offset<IVector2> textBoxSizeOffset = (_o.TextBoxSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.TextBoxSize);
			return IUiStylePlayPianoOfLevelD.CreateIUiStylePlayPianoOfLevelD(builder, _o.Type, positionOffset, textBoxSizeOffset, _o.FontSize, _o.Duration);
		}

		// Token: 0x0401237A RID: 74618
		private Table __p;
	}
}
