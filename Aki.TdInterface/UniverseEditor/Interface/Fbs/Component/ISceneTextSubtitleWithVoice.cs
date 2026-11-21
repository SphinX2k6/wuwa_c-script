using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF5 RID: 24309
	public struct ISceneTextSubtitleWithVoice : IFlatbufferObject
	{
		// Token: 0x1700B3B0 RID: 46000
		// (get) Token: 0x06028C5E RID: 167006 RVA: 0x00592A44 File Offset: 0x00590C44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C5F RID: 167007 RVA: 0x00592A51 File Offset: 0x00590C51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C60 RID: 167008 RVA: 0x00592A58 File Offset: 0x00590C58
		public static ISceneTextSubtitleWithVoice GetRootAsISceneTextSubtitleWithVoice(ByteBuffer _bb)
		{
			return ISceneTextSubtitleWithVoice.GetRootAsISceneTextSubtitleWithVoice(_bb, default(ISceneTextSubtitleWithVoice));
		}

		// Token: 0x06028C61 RID: 167009 RVA: 0x00592A74 File Offset: 0x00590C74
		public static ISceneTextSubtitleWithVoice GetRootAsISceneTextSubtitleWithVoice(ByteBuffer _bb, ISceneTextSubtitleWithVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C62 RID: 167010 RVA: 0x00592A91 File Offset: 0x00590C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C63 RID: 167011 RVA: 0x00592AA0 File Offset: 0x00590CA0
		public ISceneTextSubtitleWithVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3B1 RID: 46001
		// (get) Token: 0x06028C64 RID: 167012 RVA: 0x00592AB0 File Offset: 0x00590CB0
		public ESceneTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return (ESceneTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B2 RID: 46002
		// (get) Token: 0x06028C65 RID: 167013 RVA: 0x00592AEC File Offset: 0x00590CEC
		public IPlayFlow? Content
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B3B3 RID: 46003
		// (get) Token: 0x06028C66 RID: 167014 RVA: 0x00592B4C File Offset: 0x00590D4C
		public int FontSize
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B4 RID: 46004
		// (get) Token: 0x06028C67 RID: 167015 RVA: 0x00592B88 File Offset: 0x00590D88
		public float BoxWidth
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B5 RID: 46005
		// (get) Token: 0x06028C68 RID: 167016 RVA: 0x00592BCC File Offset: 0x00590DCC
		public float BoxHeight
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

		// Token: 0x1700B3B6 RID: 46006
		// (get) Token: 0x06028C69 RID: 167017 RVA: 0x00592C10 File Offset: 0x00590E10
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B7 RID: 46007
		// (get) Token: 0x06028C6A RID: 167018 RVA: 0x00592C54 File Offset: 0x00590E54
		public bool AutoHide
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B3B8 RID: 46008
		// (get) Token: 0x06028C6B RID: 167019 RVA: 0x00592C94 File Offset: 0x00590E94
		public ESceneTextFadeInEffect FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return ESceneTextFadeInEffect.None;
				}
				return (ESceneTextFadeInEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B9 RID: 46009
		// (get) Token: 0x06028C6C RID: 167020 RVA: 0x00592CD4 File Offset: 0x00590ED4
		public ESceneTextFadeOutEffect FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return ESceneTextFadeOutEffect.None;
				}
				return (ESceneTextFadeOutEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3BA RID: 46010
		// (get) Token: 0x06028C6D RID: 167021 RVA: 0x00592D14 File Offset: 0x00590F14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028C6E RID: 167022 RVA: 0x00592D54 File Offset: 0x00590F54
		public static Offset<ISceneTextSubtitleWithVoice> CreateISceneTextSubtitleWithVoice(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice, Offset<IPlayFlow> ContentOffset = default(Offset<IPlayFlow>), int FontSize = 0, float BoxWidth = 0f, float BoxHeight = 0f, float Duration = 0f, bool AutoHide = false, ESceneTextFadeInEffect FadeInEffect = ESceneTextFadeInEffect.None, ESceneTextFadeOutEffect FadeOutEffect = ESceneTextFadeOutEffect.None, byte NullMask = 0)
		{
			builder.StartTable(10);
			ISceneTextSubtitleWithVoice.AddDuration(builder, Duration);
			ISceneTextSubtitleWithVoice.AddBoxHeight(builder, BoxHeight);
			ISceneTextSubtitleWithVoice.AddBoxWidth(builder, BoxWidth);
			ISceneTextSubtitleWithVoice.AddFontSize(builder, FontSize);
			ISceneTextSubtitleWithVoice.AddContent(builder, ContentOffset);
			ISceneTextSubtitleWithVoice.AddNullMask(builder, NullMask);
			ISceneTextSubtitleWithVoice.AddFadeOutEffect(builder, FadeOutEffect);
			ISceneTextSubtitleWithVoice.AddFadeInEffect(builder, FadeInEffect);
			ISceneTextSubtitleWithVoice.AddAutoHide(builder, AutoHide);
			ISceneTextSubtitleWithVoice.AddType(builder, Type);
			return ISceneTextSubtitleWithVoice.EndISceneTextSubtitleWithVoice(builder);
		}

		// Token: 0x06028C6F RID: 167023 RVA: 0x00592DBC File Offset: 0x00590FBC
		public static void StartISceneTextSubtitleWithVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06028C70 RID: 167024 RVA: 0x00592DC6 File Offset: 0x00590FC6
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028C71 RID: 167025 RVA: 0x00592DD1 File Offset: 0x00590FD1
		public static void AddContent(FlatBufferBuilder builder, Offset<IPlayFlow> contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x06028C72 RID: 167026 RVA: 0x00592DE1 File Offset: 0x00590FE1
		public static void AddFontSize(FlatBufferBuilder builder, int fontSize)
		{
			builder.AddInt(2, fontSize, 0);
		}

		// Token: 0x06028C73 RID: 167027 RVA: 0x00592DEC File Offset: 0x00590FEC
		public static void AddBoxWidth(FlatBufferBuilder builder, float boxWidth)
		{
			builder.AddFloat(3, boxWidth, 0.0);
		}

		// Token: 0x06028C74 RID: 167028 RVA: 0x00592DFF File Offset: 0x00590FFF
		public static void AddBoxHeight(FlatBufferBuilder builder, float boxHeight)
		{
			builder.AddFloat(4, boxHeight, 0.0);
		}

		// Token: 0x06028C75 RID: 167029 RVA: 0x00592E12 File Offset: 0x00591012
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(5, duration, 0.0);
		}

		// Token: 0x06028C76 RID: 167030 RVA: 0x00592E25 File Offset: 0x00591025
		public static void AddAutoHide(FlatBufferBuilder builder, bool autoHide)
		{
			builder.AddBool(6, autoHide, false);
		}

		// Token: 0x06028C77 RID: 167031 RVA: 0x00592E30 File Offset: 0x00591030
		public static void AddFadeInEffect(FlatBufferBuilder builder, ESceneTextFadeInEffect fadeInEffect)
		{
			builder.AddByte(7, (byte)fadeInEffect, 0);
		}

		// Token: 0x06028C78 RID: 167032 RVA: 0x00592E3B File Offset: 0x0059103B
		public static void AddFadeOutEffect(FlatBufferBuilder builder, ESceneTextFadeOutEffect fadeOutEffect)
		{
			builder.AddByte(8, (byte)fadeOutEffect, 0);
		}

		// Token: 0x06028C79 RID: 167033 RVA: 0x00592E46 File Offset: 0x00591046
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06028C7A RID: 167034 RVA: 0x00592E52 File Offset: 0x00591052
		public static Offset<ISceneTextSubtitleWithVoice> EndISceneTextSubtitleWithVoice(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextSubtitleWithVoice>(builder.EndTable());
		}

		// Token: 0x06028C7B RID: 167035 RVA: 0x00592E60 File Offset: 0x00591060
		public ISceneTextSubtitleWithVoiceT UnPack()
		{
			ISceneTextSubtitleWithVoiceT sceneTextSubtitleWithVoiceT = new ISceneTextSubtitleWithVoiceT();
			this.UnPackTo(sceneTextSubtitleWithVoiceT);
			return sceneTextSubtitleWithVoiceT;
		}

		// Token: 0x06028C7C RID: 167036 RVA: 0x00592E7C File Offset: 0x0059107C
		public void UnPackTo(ISceneTextSubtitleWithVoiceT _o)
		{
			_o.Type = this.Type;
			_o.Content = ((this.Content != null) ? this.Content.Value.UnPack() : null);
			_o.FontSize = this.FontSize;
			_o.BoxWidth = this.BoxWidth;
			_o.BoxHeight = this.BoxHeight;
			_o.Duration = this.Duration;
			_o.AutoHide = this.AutoHide;
			_o.FadeInEffect = this.FadeInEffect;
			_o.FadeOutEffect = this.FadeOutEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028C7D RID: 167037 RVA: 0x00592F24 File Offset: 0x00591124
		public static Offset<ISceneTextSubtitleWithVoice> Pack(FlatBufferBuilder builder, ISceneTextSubtitleWithVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextSubtitleWithVoice>);
			}
			Offset<IPlayFlow> contentOffset = (_o.Content == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Content);
			return ISceneTextSubtitleWithVoice.CreateISceneTextSubtitleWithVoice(builder, _o.Type, contentOffset, _o.FontSize, _o.BoxWidth, _o.BoxHeight, _o.Duration, _o.AutoHide, _o.FadeInEffect, _o.FadeOutEffect, _o.NullMask);
		}

		// Token: 0x0400FB66 RID: 64358
		private Table __p;
	}
}
