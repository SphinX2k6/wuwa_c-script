using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007058 RID: 28760
	public struct ISetPlotMode : IFlatbufferObject
	{
		// Token: 0x1700D5A3 RID: 54691
		// (get) Token: 0x06032E6E RID: 208494 RVA: 0x006DDCE5 File Offset: 0x006DBEE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E6F RID: 208495 RVA: 0x006DDCF2 File Offset: 0x006DBEF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E70 RID: 208496 RVA: 0x006DDCFC File Offset: 0x006DBEFC
		public static ISetPlotMode GetRootAsISetPlotMode(ByteBuffer _bb)
		{
			return ISetPlotMode.GetRootAsISetPlotMode(_bb, default(ISetPlotMode));
		}

		// Token: 0x06032E71 RID: 208497 RVA: 0x006DDD18 File Offset: 0x006DBF18
		public static ISetPlotMode GetRootAsISetPlotMode(ByteBuffer _bb, ISetPlotMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E72 RID: 208498 RVA: 0x006DDD35 File Offset: 0x006DBF35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E73 RID: 208499 RVA: 0x006DDD44 File Offset: 0x006DBF44
		public ISetPlotMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5A4 RID: 54692
		// (get) Token: 0x06032E74 RID: 208500 RVA: 0x006DDD54 File Offset: 0x006DBF54
		public string Mode
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E75 RID: 208501 RVA: 0x006DDD8B File Offset: 0x006DBF8B
		public Span<byte> GetModeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032E76 RID: 208502 RVA: 0x006DDD9A File Offset: 0x006DBF9A
		public byte[] GetModeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D5A5 RID: 54693
		// (get) Token: 0x06032E77 RID: 208503 RVA: 0x006DDDA8 File Offset: 0x006DBFA8
		public bool IsSwitchMainRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5A6 RID: 54694
		// (get) Token: 0x06032E78 RID: 208504 RVA: 0x006DDDE8 File Offset: 0x006DBFE8
		public bool UseFlowCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5A7 RID: 54695
		// (get) Token: 0x06032E79 RID: 208505 RVA: 0x006DDE28 File Offset: 0x006DC028
		public bool Interruptible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5A8 RID: 54696
		// (get) Token: 0x06032E7A RID: 208506 RVA: 0x006DDE68 File Offset: 0x006DC068
		public bool NoSkip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5A9 RID: 54697
		// (get) Token: 0x06032E7B RID: 208507 RVA: 0x006DDEA8 File Offset: 0x006DC0A8
		public bool DisableAutoFadeOut
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5AA RID: 54698
		// (get) Token: 0x06032E7C RID: 208508 RVA: 0x006DDEE8 File Offset: 0x006DC0E8
		public bool WaitForPlayerMotionEnd
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5AB RID: 54699
		// (get) Token: 0x06032E7D RID: 208509 RVA: 0x006DDF28 File Offset: 0x006DC128
		public bool NoUiEnterAnimation
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5AC RID: 54700
		// (get) Token: 0x06032E7E RID: 208510 RVA: 0x006DDF68 File Offset: 0x006DC168
		public IFadeInScreen? FastFadeIn
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IFadeInScreen?(default(IFadeInScreen).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5AD RID: 54701
		// (get) Token: 0x06032E7F RID: 208511 RVA: 0x006DDFC8 File Offset: 0x006DC1C8
		public bool KeepMainRolePose
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5AE RID: 54702
		// (get) Token: 0x06032E80 RID: 208512 RVA: 0x006DE008 File Offset: 0x006DC208
		public TPromptStyle PromptStyleType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return TPromptStyle.NONE;
				}
				return (TPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E81 RID: 208513 RVA: 0x006DE048 File Offset: 0x006DC248
		public TTable? PromptStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032E82 RID: 208514 RVA: 0x006DE090 File Offset: 0x006DC290
		public IPromptStyleBattle PromptStyleAsIPromptStyleBattle()
		{
			return this.PromptStyle<IPromptStyleBattle>().Value;
		}

		// Token: 0x06032E83 RID: 208515 RVA: 0x006DE0AC File Offset: 0x006DC2AC
		public IPromptStyleBattle2 PromptStyleAsIPromptStyleBattle2()
		{
			return this.PromptStyle<IPromptStyleBattle2>().Value;
		}

		// Token: 0x06032E84 RID: 208516 RVA: 0x006DE0C8 File Offset: 0x006DC2C8
		public IPromptStyleDefault PromptStyleAsIPromptStyleDefault()
		{
			return this.PromptStyle<IPromptStyleDefault>().Value;
		}

		// Token: 0x06032E85 RID: 208517 RVA: 0x006DE0E4 File Offset: 0x006DC2E4
		public IPromptStylePhoto PromptStyleAsIPromptStylePhoto()
		{
			return this.PromptStyle<IPromptStylePhoto>().Value;
		}

		// Token: 0x1700D5AF RID: 54703
		// (get) Token: 0x06032E86 RID: 208518 RVA: 0x006DE100 File Offset: 0x006DC300
		public TSubtitleStyle SubtitleStyleType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return TSubtitleStyle.NONE;
				}
				return (TSubtitleStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E87 RID: 208519 RVA: 0x006DE140 File Offset: 0x006DC340
		public TTable? SubtitleStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032E88 RID: 208520 RVA: 0x006DE188 File Offset: 0x006DC388
		public ISubtitleStyleLevelA SubtitleStyleAsISubtitleStyleLevelA()
		{
			return this.SubtitleStyle<ISubtitleStyleLevelA>().Value;
		}

		// Token: 0x06032E89 RID: 208521 RVA: 0x006DE1A4 File Offset: 0x006DC3A4
		public ISubtitleStyleNewLevelB SubtitleStyleAsISubtitleStyleNewLevelB()
		{
			return this.SubtitleStyle<ISubtitleStyleNewLevelB>().Value;
		}

		// Token: 0x1700D5B0 RID: 54704
		// (get) Token: 0x06032E8A RID: 208522 RVA: 0x006DE1C0 File Offset: 0x006DC3C0
		public IPhoneMessageConfig? PhoneMessageConfig
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IPhoneMessageConfig?(default(IPhoneMessageConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5B1 RID: 54705
		// (get) Token: 0x06032E8B RID: 208523 RVA: 0x006DE220 File Offset: 0x006DC420
		public int SystemGameDialogConfigId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5B2 RID: 54706
		// (get) Token: 0x06032E8C RID: 208524 RVA: 0x006DE260 File Offset: 0x006DC460
		public EMainCharacterSkin MainCharacterSkin
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return EMainCharacterSkin.Uniform;
				}
				return (EMainCharacterSkin)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5B3 RID: 54707
		// (get) Token: 0x06032E8D RID: 208525 RVA: 0x006DE2A0 File Offset: 0x006DC4A0
		public IPlotFilmModeConfig? FilmModeConfig
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new IPlotFilmModeConfig?(default(IPlotFilmModeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5B4 RID: 54708
		// (get) Token: 0x06032E8E RID: 208526 RVA: 0x006DE300 File Offset: 0x006DC500
		public EOverrideAudioLevel OverrideAudioLevel
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return EOverrideAudioLevel.LevelA;
				}
				return (EOverrideAudioLevel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5B5 RID: 54709
		// (get) Token: 0x06032E8F RID: 208527 RVA: 0x006DE340 File Offset: 0x006DC540
		public bool Mp4Mode
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D5B6 RID: 54710
		// (get) Token: 0x06032E90 RID: 208528 RVA: 0x006DE380 File Offset: 0x006DC580
		public IEntityControlConfig? EntityControlConfig
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new IEntityControlConfig?(default(IEntityControlConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5B7 RID: 54711
		// (get) Token: 0x06032E91 RID: 208529 RVA: 0x006DE3E0 File Offset: 0x006DC5E0
		public IVisualNovelConfig? VisualNovelConfig
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelConfig?(default(IVisualNovelConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5B8 RID: 54712
		// (get) Token: 0x06032E92 RID: 208530 RVA: 0x006DE440 File Offset: 0x006DC640
		public IPlotModeUiStyleLevelD? UiStyle
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IPlotModeUiStyleLevelD?(default(IPlotModeUiStyleLevelD).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5B9 RID: 54713
		// (get) Token: 0x06032E93 RID: 208531 RVA: 0x006DE4A0 File Offset: 0x006DC6A0
		public IPlotAudioConfig? AudioConfig
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new IPlotAudioConfig?(default(IPlotAudioConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D5BA RID: 54714
		// (get) Token: 0x06032E94 RID: 208532 RVA: 0x006DE500 File Offset: 0x006DC700
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E95 RID: 208533 RVA: 0x006DE540 File Offset: 0x006DC740
		public static Offset<ISetPlotMode> CreateISetPlotMode(FlatBufferBuilder builder, StringOffset ModeOffset = default(StringOffset), bool IsSwitchMainRole = false, bool UseFlowCamera = false, bool Interruptible = false, bool NoSkip = false, bool DisableAutoFadeOut = false, bool WaitForPlayerMotionEnd = false, bool NoUiEnterAnimation = false, Offset<IFadeInScreen> FastFadeInOffset = default(Offset<IFadeInScreen>), bool KeepMainRolePose = false, TPromptStyle PromptStyle_type = TPromptStyle.NONE, int PromptStyleOffset = 0, TSubtitleStyle SubtitleStyle_type = TSubtitleStyle.NONE, int SubtitleStyleOffset = 0, Offset<IPhoneMessageConfig> PhoneMessageConfigOffset = default(Offset<IPhoneMessageConfig>), int SystemGameDialogConfigId = 0, EMainCharacterSkin MainCharacterSkin = EMainCharacterSkin.Uniform, Offset<IPlotFilmModeConfig> FilmModeConfigOffset = default(Offset<IPlotFilmModeConfig>), EOverrideAudioLevel OverrideAudioLevel = EOverrideAudioLevel.LevelA, bool Mp4Mode = false, Offset<IEntityControlConfig> EntityControlConfigOffset = default(Offset<IEntityControlConfig>), Offset<IVisualNovelConfig> VisualNovelConfigOffset = default(Offset<IVisualNovelConfig>), Offset<IPlotModeUiStyleLevelD> UiStyleOffset = default(Offset<IPlotModeUiStyleLevelD>), Offset<IPlotAudioConfig> AudioConfigOffset = default(Offset<IPlotAudioConfig>), ushort NullMask = 0)
		{
			builder.StartTable(25);
			ISetPlotMode.AddAudioConfig(builder, AudioConfigOffset);
			ISetPlotMode.AddUiStyle(builder, UiStyleOffset);
			ISetPlotMode.AddVisualNovelConfig(builder, VisualNovelConfigOffset);
			ISetPlotMode.AddEntityControlConfig(builder, EntityControlConfigOffset);
			ISetPlotMode.AddFilmModeConfig(builder, FilmModeConfigOffset);
			ISetPlotMode.AddSystemGameDialogConfigId(builder, SystemGameDialogConfigId);
			ISetPlotMode.AddPhoneMessageConfig(builder, PhoneMessageConfigOffset);
			ISetPlotMode.AddSubtitleStyle(builder, SubtitleStyleOffset);
			ISetPlotMode.AddPromptStyle(builder, PromptStyleOffset);
			ISetPlotMode.AddFastFadeIn(builder, FastFadeInOffset);
			ISetPlotMode.AddMode(builder, ModeOffset);
			ISetPlotMode.AddNullMask(builder, NullMask);
			ISetPlotMode.AddMp4Mode(builder, Mp4Mode);
			ISetPlotMode.AddOverrideAudioLevel(builder, OverrideAudioLevel);
			ISetPlotMode.AddMainCharacterSkin(builder, MainCharacterSkin);
			ISetPlotMode.AddSubtitleStyleType(builder, SubtitleStyle_type);
			ISetPlotMode.AddPromptStyleType(builder, PromptStyle_type);
			ISetPlotMode.AddKeepMainRolePose(builder, KeepMainRolePose);
			ISetPlotMode.AddNoUiEnterAnimation(builder, NoUiEnterAnimation);
			ISetPlotMode.AddWaitForPlayerMotionEnd(builder, WaitForPlayerMotionEnd);
			ISetPlotMode.AddDisableAutoFadeOut(builder, DisableAutoFadeOut);
			ISetPlotMode.AddNoSkip(builder, NoSkip);
			ISetPlotMode.AddInterruptible(builder, Interruptible);
			ISetPlotMode.AddUseFlowCamera(builder, UseFlowCamera);
			ISetPlotMode.AddIsSwitchMainRole(builder, IsSwitchMainRole);
			return ISetPlotMode.EndISetPlotMode(builder);
		}

		// Token: 0x06032E96 RID: 208534 RVA: 0x006DE620 File Offset: 0x006DC820
		public static void StartISetPlotMode(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x06032E97 RID: 208535 RVA: 0x006DE62A File Offset: 0x006DC82A
		public static void AddMode(FlatBufferBuilder builder, StringOffset modeOffset)
		{
			builder.AddOffset(0, modeOffset.Value, 0);
		}

		// Token: 0x06032E98 RID: 208536 RVA: 0x006DE63A File Offset: 0x006DC83A
		public static void AddIsSwitchMainRole(FlatBufferBuilder builder, bool isSwitchMainRole)
		{
			builder.AddBool(1, isSwitchMainRole, false);
		}

		// Token: 0x06032E99 RID: 208537 RVA: 0x006DE645 File Offset: 0x006DC845
		public static void AddUseFlowCamera(FlatBufferBuilder builder, bool useFlowCamera)
		{
			builder.AddBool(2, useFlowCamera, false);
		}

		// Token: 0x06032E9A RID: 208538 RVA: 0x006DE650 File Offset: 0x006DC850
		public static void AddInterruptible(FlatBufferBuilder builder, bool interruptible)
		{
			builder.AddBool(3, interruptible, false);
		}

		// Token: 0x06032E9B RID: 208539 RVA: 0x006DE65B File Offset: 0x006DC85B
		public static void AddNoSkip(FlatBufferBuilder builder, bool noSkip)
		{
			builder.AddBool(4, noSkip, false);
		}

		// Token: 0x06032E9C RID: 208540 RVA: 0x006DE666 File Offset: 0x006DC866
		public static void AddDisableAutoFadeOut(FlatBufferBuilder builder, bool disableAutoFadeOut)
		{
			builder.AddBool(5, disableAutoFadeOut, false);
		}

		// Token: 0x06032E9D RID: 208541 RVA: 0x006DE671 File Offset: 0x006DC871
		public static void AddWaitForPlayerMotionEnd(FlatBufferBuilder builder, bool waitForPlayerMotionEnd)
		{
			builder.AddBool(6, waitForPlayerMotionEnd, false);
		}

		// Token: 0x06032E9E RID: 208542 RVA: 0x006DE67C File Offset: 0x006DC87C
		public static void AddNoUiEnterAnimation(FlatBufferBuilder builder, bool noUiEnterAnimation)
		{
			builder.AddBool(7, noUiEnterAnimation, false);
		}

		// Token: 0x06032E9F RID: 208543 RVA: 0x006DE687 File Offset: 0x006DC887
		public static void AddFastFadeIn(FlatBufferBuilder builder, Offset<IFadeInScreen> fastFadeInOffset)
		{
			builder.AddOffset(8, fastFadeInOffset.Value, 0);
		}

		// Token: 0x06032EA0 RID: 208544 RVA: 0x006DE697 File Offset: 0x006DC897
		public static void AddKeepMainRolePose(FlatBufferBuilder builder, bool keepMainRolePose)
		{
			builder.AddBool(9, keepMainRolePose, false);
		}

		// Token: 0x06032EA1 RID: 208545 RVA: 0x006DE6A3 File Offset: 0x006DC8A3
		public static void AddPromptStyleType(FlatBufferBuilder builder, TPromptStyle promptStyleType)
		{
			builder.AddByte(10, (byte)promptStyleType, 0);
		}

		// Token: 0x06032EA2 RID: 208546 RVA: 0x006DE6AF File Offset: 0x006DC8AF
		public static void AddPromptStyle(FlatBufferBuilder builder, int promptStyleOffset)
		{
			builder.AddOffset(11, promptStyleOffset, 0);
		}

		// Token: 0x06032EA3 RID: 208547 RVA: 0x006DE6BB File Offset: 0x006DC8BB
		public static void AddSubtitleStyleType(FlatBufferBuilder builder, TSubtitleStyle subtitleStyleType)
		{
			builder.AddByte(12, (byte)subtitleStyleType, 0);
		}

		// Token: 0x06032EA4 RID: 208548 RVA: 0x006DE6C7 File Offset: 0x006DC8C7
		public static void AddSubtitleStyle(FlatBufferBuilder builder, int subtitleStyleOffset)
		{
			builder.AddOffset(13, subtitleStyleOffset, 0);
		}

		// Token: 0x06032EA5 RID: 208549 RVA: 0x006DE6D3 File Offset: 0x006DC8D3
		public static void AddPhoneMessageConfig(FlatBufferBuilder builder, Offset<IPhoneMessageConfig> phoneMessageConfigOffset)
		{
			builder.AddOffset(14, phoneMessageConfigOffset.Value, 0);
		}

		// Token: 0x06032EA6 RID: 208550 RVA: 0x006DE6E4 File Offset: 0x006DC8E4
		public static void AddSystemGameDialogConfigId(FlatBufferBuilder builder, int systemGameDialogConfigId)
		{
			builder.AddInt(15, systemGameDialogConfigId, 0);
		}

		// Token: 0x06032EA7 RID: 208551 RVA: 0x006DE6F0 File Offset: 0x006DC8F0
		public static void AddMainCharacterSkin(FlatBufferBuilder builder, EMainCharacterSkin mainCharacterSkin)
		{
			builder.AddByte(16, (byte)mainCharacterSkin, 0);
		}

		// Token: 0x06032EA8 RID: 208552 RVA: 0x006DE6FC File Offset: 0x006DC8FC
		public static void AddFilmModeConfig(FlatBufferBuilder builder, Offset<IPlotFilmModeConfig> filmModeConfigOffset)
		{
			builder.AddOffset(17, filmModeConfigOffset.Value, 0);
		}

		// Token: 0x06032EA9 RID: 208553 RVA: 0x006DE70D File Offset: 0x006DC90D
		public static void AddOverrideAudioLevel(FlatBufferBuilder builder, EOverrideAudioLevel overrideAudioLevel)
		{
			builder.AddByte(18, (byte)overrideAudioLevel, 0);
		}

		// Token: 0x06032EAA RID: 208554 RVA: 0x006DE719 File Offset: 0x006DC919
		public static void AddMp4Mode(FlatBufferBuilder builder, bool mp4Mode)
		{
			builder.AddBool(19, mp4Mode, false);
		}

		// Token: 0x06032EAB RID: 208555 RVA: 0x006DE725 File Offset: 0x006DC925
		public static void AddEntityControlConfig(FlatBufferBuilder builder, Offset<IEntityControlConfig> entityControlConfigOffset)
		{
			builder.AddOffset(20, entityControlConfigOffset.Value, 0);
		}

		// Token: 0x06032EAC RID: 208556 RVA: 0x006DE736 File Offset: 0x006DC936
		public static void AddVisualNovelConfig(FlatBufferBuilder builder, Offset<IVisualNovelConfig> visualNovelConfigOffset)
		{
			builder.AddOffset(21, visualNovelConfigOffset.Value, 0);
		}

		// Token: 0x06032EAD RID: 208557 RVA: 0x006DE747 File Offset: 0x006DC947
		public static void AddUiStyle(FlatBufferBuilder builder, Offset<IPlotModeUiStyleLevelD> uiStyleOffset)
		{
			builder.AddOffset(22, uiStyleOffset.Value, 0);
		}

		// Token: 0x06032EAE RID: 208558 RVA: 0x006DE758 File Offset: 0x006DC958
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IPlotAudioConfig> audioConfigOffset)
		{
			builder.AddOffset(23, audioConfigOffset.Value, 0);
		}

		// Token: 0x06032EAF RID: 208559 RVA: 0x006DE769 File Offset: 0x006DC969
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(24, nullMask, 0);
		}

		// Token: 0x06032EB0 RID: 208560 RVA: 0x006DE775 File Offset: 0x006DC975
		public static Offset<ISetPlotMode> EndISetPlotMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlotMode>(builder.EndTable());
		}

		// Token: 0x06032EB1 RID: 208561 RVA: 0x006DE784 File Offset: 0x006DC984
		public ISetPlotModeT UnPack()
		{
			ISetPlotModeT setPlotModeT = new ISetPlotModeT();
			this.UnPackTo(setPlotModeT);
			return setPlotModeT;
		}

		// Token: 0x06032EB2 RID: 208562 RVA: 0x006DE7A0 File Offset: 0x006DC9A0
		public void UnPackTo(ISetPlotModeT _o)
		{
			_o.Mode = this.Mode;
			_o.IsSwitchMainRole = this.IsSwitchMainRole;
			_o.UseFlowCamera = this.UseFlowCamera;
			_o.Interruptible = this.Interruptible;
			_o.NoSkip = this.NoSkip;
			_o.DisableAutoFadeOut = this.DisableAutoFadeOut;
			_o.WaitForPlayerMotionEnd = this.WaitForPlayerMotionEnd;
			_o.NoUiEnterAnimation = this.NoUiEnterAnimation;
			_o.FastFadeIn = ((this.FastFadeIn != null) ? this.FastFadeIn.Value.UnPack() : null);
			_o.KeepMainRolePose = this.KeepMainRolePose;
			_o.PromptStyle = new TPromptStyleUnion();
			_o.PromptStyle.Type = this.PromptStyleType;
			switch (this.PromptStyleType)
			{
			case TPromptStyle.IPromptStyleBattle:
				_o.PromptStyle.Value = ((this.PromptStyle<IPromptStyleBattle>() != null) ? this.PromptStyle<IPromptStyleBattle>().Value.UnPack() : null);
				break;
			case TPromptStyle.IPromptStyleBattle2:
				_o.PromptStyle.Value = ((this.PromptStyle<IPromptStyleBattle2>() != null) ? this.PromptStyle<IPromptStyleBattle2>().Value.UnPack() : null);
				break;
			case TPromptStyle.IPromptStyleDefault:
				_o.PromptStyle.Value = ((this.PromptStyle<IPromptStyleDefault>() != null) ? this.PromptStyle<IPromptStyleDefault>().Value.UnPack() : null);
				break;
			case TPromptStyle.IPromptStylePhoto:
				_o.PromptStyle.Value = ((this.PromptStyle<IPromptStylePhoto>() != null) ? this.PromptStyle<IPromptStylePhoto>().Value.UnPack() : null);
				break;
			}
			_o.SubtitleStyle = new TSubtitleStyleUnion();
			_o.SubtitleStyle.Type = this.SubtitleStyleType;
			TSubtitleStyle subtitleStyleType = this.SubtitleStyleType;
			if (subtitleStyleType != TSubtitleStyle.ISubtitleStyleLevelA)
			{
				if (subtitleStyleType == TSubtitleStyle.ISubtitleStyleNewLevelB)
				{
					_o.SubtitleStyle.Value = ((this.SubtitleStyle<ISubtitleStyleNewLevelB>() != null) ? this.SubtitleStyle<ISubtitleStyleNewLevelB>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SubtitleStyle.Value = ((this.SubtitleStyle<ISubtitleStyleLevelA>() != null) ? this.SubtitleStyle<ISubtitleStyleLevelA>().Value.UnPack() : null);
			}
			_o.PhoneMessageConfig = ((this.PhoneMessageConfig != null) ? this.PhoneMessageConfig.Value.UnPack() : null);
			_o.SystemGameDialogConfigId = this.SystemGameDialogConfigId;
			_o.MainCharacterSkin = this.MainCharacterSkin;
			_o.FilmModeConfig = ((this.FilmModeConfig != null) ? this.FilmModeConfig.Value.UnPack() : null);
			_o.OverrideAudioLevel = this.OverrideAudioLevel;
			_o.Mp4Mode = this.Mp4Mode;
			_o.EntityControlConfig = ((this.EntityControlConfig != null) ? this.EntityControlConfig.Value.UnPack() : null);
			_o.VisualNovelConfig = ((this.VisualNovelConfig != null) ? this.VisualNovelConfig.Value.UnPack() : null);
			_o.UiStyle = ((this.UiStyle != null) ? this.UiStyle.Value.UnPack() : null);
			_o.AudioConfig = ((this.AudioConfig != null) ? this.AudioConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032EB3 RID: 208563 RVA: 0x006DEB74 File Offset: 0x006DCD74
		public static Offset<ISetPlotMode> Pack(FlatBufferBuilder builder, ISetPlotModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlotMode>);
			}
			StringOffset modeOffset = (_o.Mode == null) ? default(StringOffset) : builder.CreateString(_o.Mode);
			Offset<IFadeInScreen> fastFadeInOffset = (_o.FastFadeIn == null) ? default(Offset<IFadeInScreen>) : IFadeInScreen.Pack(builder, _o.FastFadeIn);
			TPromptStyle promptStyle_type = (_o.PromptStyle == null) ? TPromptStyle.NONE : _o.PromptStyle.Type;
			int promptStyleOffset = (_o.PromptStyle == null) ? 0 : TPromptStyleUnion.Pack(builder, _o.PromptStyle);
			TSubtitleStyle subtitleStyle_type = (_o.SubtitleStyle == null) ? TSubtitleStyle.NONE : _o.SubtitleStyle.Type;
			int subtitleStyleOffset = (_o.SubtitleStyle == null) ? 0 : TSubtitleStyleUnion.Pack(builder, _o.SubtitleStyle);
			Offset<IPhoneMessageConfig> phoneMessageConfigOffset = (_o.PhoneMessageConfig == null) ? default(Offset<IPhoneMessageConfig>) : IPhoneMessageConfig.Pack(builder, _o.PhoneMessageConfig);
			Offset<IPlotFilmModeConfig> filmModeConfigOffset = (_o.FilmModeConfig == null) ? default(Offset<IPlotFilmModeConfig>) : IPlotFilmModeConfig.Pack(builder, _o.FilmModeConfig);
			Offset<IEntityControlConfig> entityControlConfigOffset = (_o.EntityControlConfig == null) ? default(Offset<IEntityControlConfig>) : IEntityControlConfig.Pack(builder, _o.EntityControlConfig);
			Offset<IVisualNovelConfig> visualNovelConfigOffset = (_o.VisualNovelConfig == null) ? default(Offset<IVisualNovelConfig>) : IVisualNovelConfig.Pack(builder, _o.VisualNovelConfig);
			Offset<IPlotModeUiStyleLevelD> uiStyleOffset = (_o.UiStyle == null) ? default(Offset<IPlotModeUiStyleLevelD>) : IPlotModeUiStyleLevelD.Pack(builder, _o.UiStyle);
			Offset<IPlotAudioConfig> audioConfigOffset = (_o.AudioConfig == null) ? default(Offset<IPlotAudioConfig>) : IPlotAudioConfig.Pack(builder, _o.AudioConfig);
			return ISetPlotMode.CreateISetPlotMode(builder, modeOffset, _o.IsSwitchMainRole, _o.UseFlowCamera, _o.Interruptible, _o.NoSkip, _o.DisableAutoFadeOut, _o.WaitForPlayerMotionEnd, _o.NoUiEnterAnimation, fastFadeInOffset, _o.KeepMainRolePose, promptStyle_type, promptStyleOffset, subtitleStyle_type, subtitleStyleOffset, phoneMessageConfigOffset, _o.SystemGameDialogConfigId, _o.MainCharacterSkin, filmModeConfigOffset, _o.OverrideAudioLevel, _o.Mp4Mode, entityControlConfigOffset, visualNovelConfigOffset, uiStyleOffset, audioConfigOffset, _o.NullMask);
		}

		// Token: 0x04011AA5 RID: 72357
		private Table __p;
	}
}
