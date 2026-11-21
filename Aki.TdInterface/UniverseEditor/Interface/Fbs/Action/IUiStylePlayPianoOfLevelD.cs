using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CAA RID: 31914
	public struct IUiStylePlayPianoOfLevelD : IFlatbufferObject
	{
		// Token: 0x1700EEE6 RID: 61158
		// (get) Token: 0x0603990D RID: 235789 RVA: 0x007C4BB6 File Offset: 0x007C2DB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603990E RID: 235790 RVA: 0x007C4BC3 File Offset: 0x007C2DC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603990F RID: 235791 RVA: 0x007C4BCC File Offset: 0x007C2DCC
		public static IUiStylePlayPianoOfLevelD GetRootAsIUiStylePlayPianoOfLevelD(ByteBuffer _bb)
		{
			return IUiStylePlayPianoOfLevelD.GetRootAsIUiStylePlayPianoOfLevelD(_bb, default(IUiStylePlayPianoOfLevelD));
		}

		// Token: 0x06039910 RID: 235792 RVA: 0x007C4BE8 File Offset: 0x007C2DE8
		public static IUiStylePlayPianoOfLevelD GetRootAsIUiStylePlayPianoOfLevelD(ByteBuffer _bb, IUiStylePlayPianoOfLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039911 RID: 235793 RVA: 0x007C4C05 File Offset: 0x007C2E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039912 RID: 235794 RVA: 0x007C4C14 File Offset: 0x007C2E14
		public IUiStylePlayPianoOfLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEE7 RID: 61159
		// (get) Token: 0x06039913 RID: 235795 RVA: 0x007C4C24 File Offset: 0x007C2E24
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

		// Token: 0x1700EEE8 RID: 61160
		// (get) Token: 0x06039914 RID: 235796 RVA: 0x007C4C60 File Offset: 0x007C2E60
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

		// Token: 0x1700EEE9 RID: 61161
		// (get) Token: 0x06039915 RID: 235797 RVA: 0x007C4CC0 File Offset: 0x007C2EC0
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

		// Token: 0x1700EEEA RID: 61162
		// (get) Token: 0x06039916 RID: 235798 RVA: 0x007C4D20 File Offset: 0x007C2F20
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

		// Token: 0x1700EEEB RID: 61163
		// (get) Token: 0x06039917 RID: 235799 RVA: 0x007C4D60 File Offset: 0x007C2F60
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

		// Token: 0x1700EEEC RID: 61164
		// (get) Token: 0x06039918 RID: 235800 RVA: 0x007C4DA4 File Offset: 0x007C2FA4
		public EPlayPianoFadeInEffect FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EPlayPianoFadeInEffect.None;
				}
				return (EPlayPianoFadeInEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EEED RID: 61165
		// (get) Token: 0x06039919 RID: 235801 RVA: 0x007C4DE4 File Offset: 0x007C2FE4
		public EPlayPianoFadeOutEffect FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return EPlayPianoFadeOutEffect.None;
				}
				return (EPlayPianoFadeOutEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EEEE RID: 61166
		// (get) Token: 0x0603991A RID: 235802 RVA: 0x007C4E24 File Offset: 0x007C3024
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603991B RID: 235803 RVA: 0x007C4E64 File Offset: 0x007C3064
		public static Offset<IUiStylePlayPianoOfLevelD> CreateIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder, EUiStyleTypeOfLevelD Type = EUiStyleTypeOfLevelD.GiantSubtitle, Offset<IVector2> PositionOffset = default(Offset<IVector2>), Offset<IVector2> TextBoxSizeOffset = default(Offset<IVector2>), int FontSize = 0, float Duration = 0f, EPlayPianoFadeInEffect FadeInEffect = EPlayPianoFadeInEffect.None, EPlayPianoFadeOutEffect FadeOutEffect = EPlayPianoFadeOutEffect.None, byte NullMask = 0)
		{
			builder.StartTable(8);
			IUiStylePlayPianoOfLevelD.AddDuration(builder, Duration);
			IUiStylePlayPianoOfLevelD.AddFontSize(builder, FontSize);
			IUiStylePlayPianoOfLevelD.AddTextBoxSize(builder, TextBoxSizeOffset);
			IUiStylePlayPianoOfLevelD.AddPosition(builder, PositionOffset);
			IUiStylePlayPianoOfLevelD.AddNullMask(builder, NullMask);
			IUiStylePlayPianoOfLevelD.AddFadeOutEffect(builder, FadeOutEffect);
			IUiStylePlayPianoOfLevelD.AddFadeInEffect(builder, FadeInEffect);
			IUiStylePlayPianoOfLevelD.AddType(builder, Type);
			return IUiStylePlayPianoOfLevelD.EndIUiStylePlayPianoOfLevelD(builder);
		}

		// Token: 0x0603991C RID: 235804 RVA: 0x007C4EBB File Offset: 0x007C30BB
		public static void StartIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0603991D RID: 235805 RVA: 0x007C4EC4 File Offset: 0x007C30C4
		public static void AddType(FlatBufferBuilder builder, EUiStyleTypeOfLevelD type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603991E RID: 235806 RVA: 0x007C4ECF File Offset: 0x007C30CF
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVector2> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x0603991F RID: 235807 RVA: 0x007C4EDF File Offset: 0x007C30DF
		public static void AddTextBoxSize(FlatBufferBuilder builder, Offset<IVector2> textBoxSizeOffset)
		{
			builder.AddOffset(2, textBoxSizeOffset.Value, 0);
		}

		// Token: 0x06039920 RID: 235808 RVA: 0x007C4EEF File Offset: 0x007C30EF
		public static void AddFontSize(FlatBufferBuilder builder, int fontSize)
		{
			builder.AddInt(3, fontSize, 0);
		}

		// Token: 0x06039921 RID: 235809 RVA: 0x007C4EFA File Offset: 0x007C30FA
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x06039922 RID: 235810 RVA: 0x007C4F0D File Offset: 0x007C310D
		public static void AddFadeInEffect(FlatBufferBuilder builder, EPlayPianoFadeInEffect fadeInEffect)
		{
			builder.AddByte(5, (byte)fadeInEffect, 0);
		}

		// Token: 0x06039923 RID: 235811 RVA: 0x007C4F18 File Offset: 0x007C3118
		public static void AddFadeOutEffect(FlatBufferBuilder builder, EPlayPianoFadeOutEffect fadeOutEffect)
		{
			builder.AddByte(6, (byte)fadeOutEffect, 0);
		}

		// Token: 0x06039924 RID: 235812 RVA: 0x007C4F23 File Offset: 0x007C3123
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06039925 RID: 235813 RVA: 0x007C4F2E File Offset: 0x007C312E
		public static Offset<IUiStylePlayPianoOfLevelD> EndIUiStylePlayPianoOfLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IUiStylePlayPianoOfLevelD>(builder.EndTable());
		}

		// Token: 0x06039926 RID: 235814 RVA: 0x007C4F3C File Offset: 0x007C313C
		public IUiStylePlayPianoOfLevelDT UnPack()
		{
			IUiStylePlayPianoOfLevelDT uiStylePlayPianoOfLevelDT = new IUiStylePlayPianoOfLevelDT();
			this.UnPackTo(uiStylePlayPianoOfLevelDT);
			return uiStylePlayPianoOfLevelDT;
		}

		// Token: 0x06039927 RID: 235815 RVA: 0x007C4F58 File Offset: 0x007C3158
		public void UnPackTo(IUiStylePlayPianoOfLevelDT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.TextBoxSize = ((this.TextBoxSize != null) ? this.TextBoxSize.Value.UnPack() : null);
			_o.FontSize = this.FontSize;
			_o.Duration = this.Duration;
			_o.FadeInEffect = this.FadeInEffect;
			_o.FadeOutEffect = this.FadeOutEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039928 RID: 235816 RVA: 0x007C500C File Offset: 0x007C320C
		public static Offset<IUiStylePlayPianoOfLevelD> Pack(FlatBufferBuilder builder, IUiStylePlayPianoOfLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiStylePlayPianoOfLevelD>);
			}
			Offset<IVector2> positionOffset = (_o.Position == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Position);
			Offset<IVector2> textBoxSizeOffset = (_o.TextBoxSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.TextBoxSize);
			return IUiStylePlayPianoOfLevelD.CreateIUiStylePlayPianoOfLevelD(builder, _o.Type, positionOffset, textBoxSizeOffset, _o.FontSize, _o.Duration, _o.FadeInEffect, _o.FadeOutEffect, _o.NullMask);
		}

		// Token: 0x040133A8 RID: 78760
		private Table __p;
	}
}
