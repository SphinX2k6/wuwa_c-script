using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E8 RID: 22760
	public struct ISceneTextSubtitleWithVoice : IFlatbufferObject
	{
		// Token: 0x1700AA80 RID: 43648
		// (get) Token: 0x060266FC RID: 157436 RVA: 0x0054BEF8 File Offset: 0x0054A0F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266FD RID: 157437 RVA: 0x0054BF05 File Offset: 0x0054A105
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266FE RID: 157438 RVA: 0x0054BF0C File Offset: 0x0054A10C
		public static ISceneTextSubtitleWithVoice GetRootAsISceneTextSubtitleWithVoice(ByteBuffer _bb)
		{
			return ISceneTextSubtitleWithVoice.GetRootAsISceneTextSubtitleWithVoice(_bb, default(ISceneTextSubtitleWithVoice));
		}

		// Token: 0x060266FF RID: 157439 RVA: 0x0054BF28 File Offset: 0x0054A128
		public static ISceneTextSubtitleWithVoice GetRootAsISceneTextSubtitleWithVoice(ByteBuffer _bb, ISceneTextSubtitleWithVoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026700 RID: 157440 RVA: 0x0054BF45 File Offset: 0x0054A145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026701 RID: 157441 RVA: 0x0054BF54 File Offset: 0x0054A154
		public ISceneTextSubtitleWithVoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA81 RID: 43649
		// (get) Token: 0x06026702 RID: 157442 RVA: 0x0054BF64 File Offset: 0x0054A164
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

		// Token: 0x1700AA82 RID: 43650
		// (get) Token: 0x06026703 RID: 157443 RVA: 0x0054BFA0 File Offset: 0x0054A1A0
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

		// Token: 0x1700AA83 RID: 43651
		// (get) Token: 0x06026704 RID: 157444 RVA: 0x0054C000 File Offset: 0x0054A200
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

		// Token: 0x1700AA84 RID: 43652
		// (get) Token: 0x06026705 RID: 157445 RVA: 0x0054C03C File Offset: 0x0054A23C
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

		// Token: 0x1700AA85 RID: 43653
		// (get) Token: 0x06026706 RID: 157446 RVA: 0x0054C080 File Offset: 0x0054A280
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

		// Token: 0x1700AA86 RID: 43654
		// (get) Token: 0x06026707 RID: 157447 RVA: 0x0054C0C4 File Offset: 0x0054A2C4
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

		// Token: 0x1700AA87 RID: 43655
		// (get) Token: 0x06026708 RID: 157448 RVA: 0x0054C108 File Offset: 0x0054A308
		public bool AutoHide
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA88 RID: 43656
		// (get) Token: 0x06026709 RID: 157449 RVA: 0x0054C148 File Offset: 0x0054A348
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

		// Token: 0x0602670A RID: 157450 RVA: 0x0054C188 File Offset: 0x0054A388
		public static Offset<ISceneTextSubtitleWithVoice> CreateISceneTextSubtitleWithVoice(FlatBufferBuilder builder, ESceneTextType Type = ESceneTextType.SubtitleWithVoice, Offset<IPlayFlow> ContentOffset = default(Offset<IPlayFlow>), int FontSize = 0, float BoxWidth = 0f, float BoxHeight = 0f, float Duration = 0f, bool AutoHide = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISceneTextSubtitleWithVoice.AddDuration(builder, Duration);
			ISceneTextSubtitleWithVoice.AddBoxHeight(builder, BoxHeight);
			ISceneTextSubtitleWithVoice.AddBoxWidth(builder, BoxWidth);
			ISceneTextSubtitleWithVoice.AddFontSize(builder, FontSize);
			ISceneTextSubtitleWithVoice.AddContent(builder, ContentOffset);
			ISceneTextSubtitleWithVoice.AddNullMask(builder, NullMask);
			ISceneTextSubtitleWithVoice.AddAutoHide(builder, AutoHide);
			ISceneTextSubtitleWithVoice.AddType(builder, Type);
			return ISceneTextSubtitleWithVoice.EndISceneTextSubtitleWithVoice(builder);
		}

		// Token: 0x0602670B RID: 157451 RVA: 0x0054C1DF File Offset: 0x0054A3DF
		public static void StartISceneTextSubtitleWithVoice(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602670C RID: 157452 RVA: 0x0054C1E8 File Offset: 0x0054A3E8
		public static void AddType(FlatBufferBuilder builder, ESceneTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602670D RID: 157453 RVA: 0x0054C1F3 File Offset: 0x0054A3F3
		public static void AddContent(FlatBufferBuilder builder, Offset<IPlayFlow> contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x0602670E RID: 157454 RVA: 0x0054C203 File Offset: 0x0054A403
		public static void AddFontSize(FlatBufferBuilder builder, int fontSize)
		{
			builder.AddInt(2, fontSize, 0);
		}

		// Token: 0x0602670F RID: 157455 RVA: 0x0054C20E File Offset: 0x0054A40E
		public static void AddBoxWidth(FlatBufferBuilder builder, float boxWidth)
		{
			builder.AddFloat(3, boxWidth, 0.0);
		}

		// Token: 0x06026710 RID: 157456 RVA: 0x0054C221 File Offset: 0x0054A421
		public static void AddBoxHeight(FlatBufferBuilder builder, float boxHeight)
		{
			builder.AddFloat(4, boxHeight, 0.0);
		}

		// Token: 0x06026711 RID: 157457 RVA: 0x0054C234 File Offset: 0x0054A434
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(5, duration, 0.0);
		}

		// Token: 0x06026712 RID: 157458 RVA: 0x0054C247 File Offset: 0x0054A447
		public static void AddAutoHide(FlatBufferBuilder builder, bool autoHide)
		{
			builder.AddBool(6, autoHide, false);
		}

		// Token: 0x06026713 RID: 157459 RVA: 0x0054C252 File Offset: 0x0054A452
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06026714 RID: 157460 RVA: 0x0054C25D File Offset: 0x0054A45D
		public static Offset<ISceneTextSubtitleWithVoice> EndISceneTextSubtitleWithVoice(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextSubtitleWithVoice>(builder.EndTable());
		}

		// Token: 0x06026715 RID: 157461 RVA: 0x0054C26C File Offset: 0x0054A46C
		public ISceneTextSubtitleWithVoiceT UnPack()
		{
			ISceneTextSubtitleWithVoiceT sceneTextSubtitleWithVoiceT = new ISceneTextSubtitleWithVoiceT();
			this.UnPackTo(sceneTextSubtitleWithVoiceT);
			return sceneTextSubtitleWithVoiceT;
		}

		// Token: 0x06026716 RID: 157462 RVA: 0x0054C288 File Offset: 0x0054A488
		public void UnPackTo(ISceneTextSubtitleWithVoiceT _o)
		{
			_o.Type = this.Type;
			_o.Content = ((this.Content != null) ? this.Content.Value.UnPack() : null);
			_o.FontSize = this.FontSize;
			_o.BoxWidth = this.BoxWidth;
			_o.BoxHeight = this.BoxHeight;
			_o.Duration = this.Duration;
			_o.AutoHide = this.AutoHide;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026717 RID: 157463 RVA: 0x0054C318 File Offset: 0x0054A518
		public static Offset<ISceneTextSubtitleWithVoice> Pack(FlatBufferBuilder builder, ISceneTextSubtitleWithVoiceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextSubtitleWithVoice>);
			}
			Offset<IPlayFlow> contentOffset = (_o.Content == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Content);
			return ISceneTextSubtitleWithVoice.CreateISceneTextSubtitleWithVoice(builder, _o.Type, contentOffset, _o.FontSize, _o.BoxWidth, _o.BoxHeight, _o.Duration, _o.AutoHide, _o.NullMask);
		}

		// Token: 0x0400EE73 RID: 61043
		private Table __p;
	}
}
