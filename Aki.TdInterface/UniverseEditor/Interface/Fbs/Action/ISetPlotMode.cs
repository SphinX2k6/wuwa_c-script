using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007824 RID: 30756
	public struct ISetPlotMode : IFlatbufferObject
	{
		// Token: 0x1700E186 RID: 57734
		// (get) Token: 0x0603610F RID: 221455 RVA: 0x0073E29C File Offset: 0x0073C49C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036110 RID: 221456 RVA: 0x0073E2A9 File Offset: 0x0073C4A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036111 RID: 221457 RVA: 0x0073E2B0 File Offset: 0x0073C4B0
		public static ISetPlotMode GetRootAsISetPlotMode(ByteBuffer _bb)
		{
			return ISetPlotMode.GetRootAsISetPlotMode(_bb, default(ISetPlotMode));
		}

		// Token: 0x06036112 RID: 221458 RVA: 0x0073E2CC File Offset: 0x0073C4CC
		public static ISetPlotMode GetRootAsISetPlotMode(ByteBuffer _bb, ISetPlotMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036113 RID: 221459 RVA: 0x0073E2E9 File Offset: 0x0073C4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036114 RID: 221460 RVA: 0x0073E2F8 File Offset: 0x0073C4F8
		public ISetPlotMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E187 RID: 57735
		// (get) Token: 0x06036115 RID: 221461 RVA: 0x0073E308 File Offset: 0x0073C508
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

		// Token: 0x06036116 RID: 221462 RVA: 0x0073E33F File Offset: 0x0073C53F
		public Span<byte> GetModeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036117 RID: 221463 RVA: 0x0073E34E File Offset: 0x0073C54E
		public byte[] GetModeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E188 RID: 57736
		// (get) Token: 0x06036118 RID: 221464 RVA: 0x0073E35C File Offset: 0x0073C55C
		public bool IsSwitchMainRole
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E189 RID: 57737
		// (get) Token: 0x06036119 RID: 221465 RVA: 0x0073E39C File Offset: 0x0073C59C
		public bool UseFlowCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18A RID: 57738
		// (get) Token: 0x0603611A RID: 221466 RVA: 0x0073E3DC File Offset: 0x0073C5DC
		public bool Interruptible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18B RID: 57739
		// (get) Token: 0x0603611B RID: 221467 RVA: 0x0073E41C File Offset: 0x0073C61C
		public bool NoSkip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18C RID: 57740
		// (get) Token: 0x0603611C RID: 221468 RVA: 0x0073E45C File Offset: 0x0073C65C
		public bool DisableAutoFadeOut
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18D RID: 57741
		// (get) Token: 0x0603611D RID: 221469 RVA: 0x0073E49C File Offset: 0x0073C69C
		public bool WaitForPlayerMotionEnd
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18E RID: 57742
		// (get) Token: 0x0603611E RID: 221470 RVA: 0x0073E4DC File Offset: 0x0073C6DC
		public bool NoUiEnterAnimation
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E18F RID: 57743
		// (get) Token: 0x0603611F RID: 221471 RVA: 0x0073E51C File Offset: 0x0073C71C
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

		// Token: 0x1700E190 RID: 57744
		// (get) Token: 0x06036120 RID: 221472 RVA: 0x0073E57C File Offset: 0x0073C77C
		public bool KeepMainRolePose
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E191 RID: 57745
		// (get) Token: 0x06036121 RID: 221473 RVA: 0x0073E5BC File Offset: 0x0073C7BC
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

		// Token: 0x06036122 RID: 221474 RVA: 0x0073E5FC File Offset: 0x0073C7FC
		public TTable? PromptStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036123 RID: 221475 RVA: 0x0073E644 File Offset: 0x0073C844
		public IPromptStyleBattle PromptStyleAsIPromptStyleBattle()
		{
			return this.PromptStyle<IPromptStyleBattle>().Value;
		}

		// Token: 0x06036124 RID: 221476 RVA: 0x0073E660 File Offset: 0x0073C860
		public IPromptStyleBattle2 PromptStyleAsIPromptStyleBattle2()
		{
			return this.PromptStyle<IPromptStyleBattle2>().Value;
		}

		// Token: 0x06036125 RID: 221477 RVA: 0x0073E67C File Offset: 0x0073C87C
		public IPromptStyleDefault PromptStyleAsIPromptStyleDefault()
		{
			return this.PromptStyle<IPromptStyleDefault>().Value;
		}

		// Token: 0x06036126 RID: 221478 RVA: 0x0073E698 File Offset: 0x0073C898
		public IPromptStylePhoto PromptStyleAsIPromptStylePhoto()
		{
			return this.PromptStyle<IPromptStylePhoto>().Value;
		}

		// Token: 0x1700E192 RID: 57746
		// (get) Token: 0x06036127 RID: 221479 RVA: 0x0073E6B4 File Offset: 0x0073C8B4
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

		// Token: 0x06036128 RID: 221480 RVA: 0x0073E6F4 File Offset: 0x0073C8F4
		public TTable? SubtitleStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036129 RID: 221481 RVA: 0x0073E73C File Offset: 0x0073C93C
		public ISubtitleStyleLevelA SubtitleStyleAsISubtitleStyleLevelA()
		{
			return this.SubtitleStyle<ISubtitleStyleLevelA>().Value;
		}

		// Token: 0x0603612A RID: 221482 RVA: 0x0073E758 File Offset: 0x0073C958
		public ISubtitleStyleNewLevelB SubtitleStyleAsISubtitleStyleNewLevelB()
		{
			return this.SubtitleStyle<ISubtitleStyleNewLevelB>().Value;
		}

		// Token: 0x1700E193 RID: 57747
		// (get) Token: 0x0603612B RID: 221483 RVA: 0x0073E774 File Offset: 0x0073C974
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

		// Token: 0x1700E194 RID: 57748
		// (get) Token: 0x0603612C RID: 221484 RVA: 0x0073E7D4 File Offset: 0x0073C9D4
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

		// Token: 0x1700E195 RID: 57749
		// (get) Token: 0x0603612D RID: 221485 RVA: 0x0073E814 File Offset: 0x0073CA14
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

		// Token: 0x1700E196 RID: 57750
		// (get) Token: 0x0603612E RID: 221486 RVA: 0x0073E854 File Offset: 0x0073CA54
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

		// Token: 0x1700E197 RID: 57751
		// (get) Token: 0x0603612F RID: 221487 RVA: 0x0073E8B4 File Offset: 0x0073CAB4
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

		// Token: 0x1700E198 RID: 57752
		// (get) Token: 0x06036130 RID: 221488 RVA: 0x0073E8F4 File Offset: 0x0073CAF4
		public bool Mp4Mode
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E199 RID: 57753
		// (get) Token: 0x06036131 RID: 221489 RVA: 0x0073E934 File Offset: 0x0073CB34
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

		// Token: 0x1700E19A RID: 57754
		// (get) Token: 0x06036132 RID: 221490 RVA: 0x0073E994 File Offset: 0x0073CB94
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

		// Token: 0x1700E19B RID: 57755
		// (get) Token: 0x06036133 RID: 221491 RVA: 0x0073E9F4 File Offset: 0x0073CBF4
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

		// Token: 0x1700E19C RID: 57756
		// (get) Token: 0x06036134 RID: 221492 RVA: 0x0073EA54 File Offset: 0x0073CC54
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

		// Token: 0x1700E19D RID: 57757
		// (get) Token: 0x06036135 RID: 221493 RVA: 0x0073EAB4 File Offset: 0x0073CCB4
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

		// Token: 0x06036136 RID: 221494 RVA: 0x0073EAF4 File Offset: 0x0073CCF4
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

		// Token: 0x06036137 RID: 221495 RVA: 0x0073EBD4 File Offset: 0x0073CDD4
		public static void StartISetPlotMode(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x06036138 RID: 221496 RVA: 0x0073EBDE File Offset: 0x0073CDDE
		public static void AddMode(FlatBufferBuilder builder, StringOffset modeOffset)
		{
			builder.AddOffset(0, modeOffset.Value, 0);
		}

		// Token: 0x06036139 RID: 221497 RVA: 0x0073EBEE File Offset: 0x0073CDEE
		public static void AddIsSwitchMainRole(FlatBufferBuilder builder, bool isSwitchMainRole)
		{
			builder.AddBool(1, isSwitchMainRole, false);
		}

		// Token: 0x0603613A RID: 221498 RVA: 0x0073EBF9 File Offset: 0x0073CDF9
		public static void AddUseFlowCamera(FlatBufferBuilder builder, bool useFlowCamera)
		{
			builder.AddBool(2, useFlowCamera, false);
		}

		// Token: 0x0603613B RID: 221499 RVA: 0x0073EC04 File Offset: 0x0073CE04
		public static void AddInterruptible(FlatBufferBuilder builder, bool interruptible)
		{
			builder.AddBool(3, interruptible, false);
		}

		// Token: 0x0603613C RID: 221500 RVA: 0x0073EC0F File Offset: 0x0073CE0F
		public static void AddNoSkip(FlatBufferBuilder builder, bool noSkip)
		{
			builder.AddBool(4, noSkip, false);
		}

		// Token: 0x0603613D RID: 221501 RVA: 0x0073EC1A File Offset: 0x0073CE1A
		public static void AddDisableAutoFadeOut(FlatBufferBuilder builder, bool disableAutoFadeOut)
		{
			builder.AddBool(5, disableAutoFadeOut, false);
		}

		// Token: 0x0603613E RID: 221502 RVA: 0x0073EC25 File Offset: 0x0073CE25
		public static void AddWaitForPlayerMotionEnd(FlatBufferBuilder builder, bool waitForPlayerMotionEnd)
		{
			builder.AddBool(6, waitForPlayerMotionEnd, false);
		}

		// Token: 0x0603613F RID: 221503 RVA: 0x0073EC30 File Offset: 0x0073CE30
		public static void AddNoUiEnterAnimation(FlatBufferBuilder builder, bool noUiEnterAnimation)
		{
			builder.AddBool(7, noUiEnterAnimation, false);
		}

		// Token: 0x06036140 RID: 221504 RVA: 0x0073EC3B File Offset: 0x0073CE3B
		public static void AddFastFadeIn(FlatBufferBuilder builder, Offset<IFadeInScreen> fastFadeInOffset)
		{
			builder.AddOffset(8, fastFadeInOffset.Value, 0);
		}

		// Token: 0x06036141 RID: 221505 RVA: 0x0073EC4B File Offset: 0x0073CE4B
		public static void AddKeepMainRolePose(FlatBufferBuilder builder, bool keepMainRolePose)
		{
			builder.AddBool(9, keepMainRolePose, false);
		}

		// Token: 0x06036142 RID: 221506 RVA: 0x0073EC57 File Offset: 0x0073CE57
		public static void AddPromptStyleType(FlatBufferBuilder builder, TPromptStyle promptStyleType)
		{
			builder.AddByte(10, (byte)promptStyleType, 0);
		}

		// Token: 0x06036143 RID: 221507 RVA: 0x0073EC63 File Offset: 0x0073CE63
		public static void AddPromptStyle(FlatBufferBuilder builder, int promptStyleOffset)
		{
			builder.AddOffset(11, promptStyleOffset, 0);
		}

		// Token: 0x06036144 RID: 221508 RVA: 0x0073EC6F File Offset: 0x0073CE6F
		public static void AddSubtitleStyleType(FlatBufferBuilder builder, TSubtitleStyle subtitleStyleType)
		{
			builder.AddByte(12, (byte)subtitleStyleType, 0);
		}

		// Token: 0x06036145 RID: 221509 RVA: 0x0073EC7B File Offset: 0x0073CE7B
		public static void AddSubtitleStyle(FlatBufferBuilder builder, int subtitleStyleOffset)
		{
			builder.AddOffset(13, subtitleStyleOffset, 0);
		}

		// Token: 0x06036146 RID: 221510 RVA: 0x0073EC87 File Offset: 0x0073CE87
		public static void AddPhoneMessageConfig(FlatBufferBuilder builder, Offset<IPhoneMessageConfig> phoneMessageConfigOffset)
		{
			builder.AddOffset(14, phoneMessageConfigOffset.Value, 0);
		}

		// Token: 0x06036147 RID: 221511 RVA: 0x0073EC98 File Offset: 0x0073CE98
		public static void AddSystemGameDialogConfigId(FlatBufferBuilder builder, int systemGameDialogConfigId)
		{
			builder.AddInt(15, systemGameDialogConfigId, 0);
		}

		// Token: 0x06036148 RID: 221512 RVA: 0x0073ECA4 File Offset: 0x0073CEA4
		public static void AddMainCharacterSkin(FlatBufferBuilder builder, EMainCharacterSkin mainCharacterSkin)
		{
			builder.AddByte(16, (byte)mainCharacterSkin, 0);
		}

		// Token: 0x06036149 RID: 221513 RVA: 0x0073ECB0 File Offset: 0x0073CEB0
		public static void AddFilmModeConfig(FlatBufferBuilder builder, Offset<IPlotFilmModeConfig> filmModeConfigOffset)
		{
			builder.AddOffset(17, filmModeConfigOffset.Value, 0);
		}

		// Token: 0x0603614A RID: 221514 RVA: 0x0073ECC1 File Offset: 0x0073CEC1
		public static void AddOverrideAudioLevel(FlatBufferBuilder builder, EOverrideAudioLevel overrideAudioLevel)
		{
			builder.AddByte(18, (byte)overrideAudioLevel, 0);
		}

		// Token: 0x0603614B RID: 221515 RVA: 0x0073ECCD File Offset: 0x0073CECD
		public static void AddMp4Mode(FlatBufferBuilder builder, bool mp4Mode)
		{
			builder.AddBool(19, mp4Mode, false);
		}

		// Token: 0x0603614C RID: 221516 RVA: 0x0073ECD9 File Offset: 0x0073CED9
		public static void AddEntityControlConfig(FlatBufferBuilder builder, Offset<IEntityControlConfig> entityControlConfigOffset)
		{
			builder.AddOffset(20, entityControlConfigOffset.Value, 0);
		}

		// Token: 0x0603614D RID: 221517 RVA: 0x0073ECEA File Offset: 0x0073CEEA
		public static void AddVisualNovelConfig(FlatBufferBuilder builder, Offset<IVisualNovelConfig> visualNovelConfigOffset)
		{
			builder.AddOffset(21, visualNovelConfigOffset.Value, 0);
		}

		// Token: 0x0603614E RID: 221518 RVA: 0x0073ECFB File Offset: 0x0073CEFB
		public static void AddUiStyle(FlatBufferBuilder builder, Offset<IPlotModeUiStyleLevelD> uiStyleOffset)
		{
			builder.AddOffset(22, uiStyleOffset.Value, 0);
		}

		// Token: 0x0603614F RID: 221519 RVA: 0x0073ED0C File Offset: 0x0073CF0C
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IPlotAudioConfig> audioConfigOffset)
		{
			builder.AddOffset(23, audioConfigOffset.Value, 0);
		}

		// Token: 0x06036150 RID: 221520 RVA: 0x0073ED1D File Offset: 0x0073CF1D
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(24, nullMask, 0);
		}

		// Token: 0x06036151 RID: 221521 RVA: 0x0073ED29 File Offset: 0x0073CF29
		public static Offset<ISetPlotMode> EndISetPlotMode(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlotMode>(builder.EndTable());
		}

		// Token: 0x06036152 RID: 221522 RVA: 0x0073ED38 File Offset: 0x0073CF38
		public ISetPlotModeT UnPack()
		{
			ISetPlotModeT setPlotModeT = new ISetPlotModeT();
			this.UnPackTo(setPlotModeT);
			return setPlotModeT;
		}

		// Token: 0x06036153 RID: 221523 RVA: 0x0073ED54 File Offset: 0x0073CF54
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

		// Token: 0x06036154 RID: 221524 RVA: 0x0073F128 File Offset: 0x0073D328
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

		// Token: 0x04012A93 RID: 76435
		private Table __p;
	}
}
