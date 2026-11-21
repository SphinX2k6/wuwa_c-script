using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749E RID: 29854
	public struct IPlayLevelSequence : IFlatbufferObject
	{
		// Token: 0x1700DB46 RID: 56134
		// (get) Token: 0x06034430 RID: 214064 RVA: 0x00709B5A File Offset: 0x00707D5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034431 RID: 214065 RVA: 0x00709B67 File Offset: 0x00707D67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034432 RID: 214066 RVA: 0x00709B70 File Offset: 0x00707D70
		public static IPlayLevelSequence GetRootAsIPlayLevelSequence(ByteBuffer _bb)
		{
			return IPlayLevelSequence.GetRootAsIPlayLevelSequence(_bb, default(IPlayLevelSequence));
		}

		// Token: 0x06034433 RID: 214067 RVA: 0x00709B8C File Offset: 0x00707D8C
		public static IPlayLevelSequence GetRootAsIPlayLevelSequence(ByteBuffer _bb, IPlayLevelSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034434 RID: 214068 RVA: 0x00709BA9 File Offset: 0x00707DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034435 RID: 214069 RVA: 0x00709BB8 File Offset: 0x00707DB8
		public IPlayLevelSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB47 RID: 56135
		// (get) Token: 0x06034436 RID: 214070 RVA: 0x00709BC8 File Offset: 0x00707DC8
		public string LevelSequencePath
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

		// Token: 0x06034437 RID: 214071 RVA: 0x00709BFF File Offset: 0x00707DFF
		public Span<byte> GetLevelSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034438 RID: 214072 RVA: 0x00709C0E File Offset: 0x00707E0E
		public byte[] GetLevelSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DB48 RID: 56136
		// (get) Token: 0x06034439 RID: 214073 RVA: 0x00709C1C File Offset: 0x00707E1C
		public bool IsEnableCenterOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB49 RID: 56137
		// (get) Token: 0x0603443A RID: 214074 RVA: 0x00709C5C File Offset: 0x00707E5C
		public bool KeepUI
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB4A RID: 56138
		// (get) Token: 0x0603443B RID: 214075 RVA: 0x00709C9C File Offset: 0x00707E9C
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603443C RID: 214076 RVA: 0x00709CD4 File Offset: 0x00707ED4
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603443D RID: 214077 RVA: 0x00709CE4 File Offset: 0x00707EE4
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DB4B RID: 56139
		// (get) Token: 0x0603443E RID: 214078 RVA: 0x00709CF4 File Offset: 0x00707EF4
		public TPlayMode PlayMode
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TPlayMode.direct;
				}
				return (TPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB4C RID: 56140
		// (get) Token: 0x0603443F RID: 214079 RVA: 0x00709D34 File Offset: 0x00707F34
		public ILoopRange? LoopRange
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ILoopRange?(default(ILoopRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB4D RID: 56141
		// (get) Token: 0x06034440 RID: 214080 RVA: 0x00709D94 File Offset: 0x00707F94
		public TLevelSequenceTransition IntroType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TLevelSequenceTransition.NONE;
				}
				return (TLevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034441 RID: 214081 RVA: 0x00709DD4 File Offset: 0x00707FD4
		public TTable? Intro<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034442 RID: 214082 RVA: 0x00709E1C File Offset: 0x0070801C
		public ICameraTransition IntroAsICameraTransition()
		{
			return this.Intro<ICameraTransition>().Value;
		}

		// Token: 0x06034443 RID: 214083 RVA: 0x00709E38 File Offset: 0x00708038
		public IMaskTransition IntroAsIMaskTransition()
		{
			return this.Intro<IMaskTransition>().Value;
		}

		// Token: 0x1700DB4E RID: 56142
		// (get) Token: 0x06034444 RID: 214084 RVA: 0x00709E54 File Offset: 0x00708054
		public TLevelSequenceTransition OutroType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return TLevelSequenceTransition.NONE;
				}
				return (TLevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034445 RID: 214085 RVA: 0x00709E94 File Offset: 0x00708094
		public TTable? Outro<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034446 RID: 214086 RVA: 0x00709EDC File Offset: 0x007080DC
		public ICameraTransition OutroAsICameraTransition()
		{
			return this.Outro<ICameraTransition>().Value;
		}

		// Token: 0x06034447 RID: 214087 RVA: 0x00709EF8 File Offset: 0x007080F8
		public IMaskTransition OutroAsIMaskTransition()
		{
			return this.Outro<IMaskTransition>().Value;
		}

		// Token: 0x1700DB4F RID: 56143
		// (get) Token: 0x06034448 RID: 214088 RVA: 0x00709F14 File Offset: 0x00708114
		public float Rate
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB50 RID: 56144
		// (get) Token: 0x06034449 RID: 214089 RVA: 0x00709F58 File Offset: 0x00708158
		public IEaseData? RateEase
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB51 RID: 56145
		// (get) Token: 0x0603444A RID: 214090 RVA: 0x00709FB8 File Offset: 0x007081B8
		public bool IsPlayOnTeleport
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB52 RID: 56146
		// (get) Token: 0x0603444B RID: 214091 RVA: 0x00709FF8 File Offset: 0x007081F8
		public bool IsCarryCharacter
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB53 RID: 56147
		// (get) Token: 0x0603444C RID: 214092 RVA: 0x0070A038 File Offset: 0x00708238
		public IFloatingSubtitleLanguageDiff? PreprocessOperation
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IFloatingSubtitleLanguageDiff?(default(IFloatingSubtitleLanguageDiff).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB54 RID: 56148
		// (get) Token: 0x0603444D RID: 214093 RVA: 0x0070A098 File Offset: 0x00708298
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603444E RID: 214094 RVA: 0x0070A0D8 File Offset: 0x007082D8
		public static Offset<IPlayLevelSequence> CreateIPlayLevelSequence(FlatBufferBuilder builder, StringOffset LevelSequencePathOffset = default(StringOffset), bool IsEnableCenterOffset = false, bool KeepUI = false, StringOffset MarkOffset = default(StringOffset), TPlayMode PlayMode = TPlayMode.direct, Offset<ILoopRange> LoopRangeOffset = default(Offset<ILoopRange>), TLevelSequenceTransition Intro_type = TLevelSequenceTransition.NONE, int IntroOffset = 0, TLevelSequenceTransition Outro_type = TLevelSequenceTransition.NONE, int OutroOffset = 0, float Rate = 0f, Offset<IEaseData> RateEaseOffset = default(Offset<IEaseData>), bool IsPlayOnTeleport = false, bool IsCarryCharacter = false, Offset<IFloatingSubtitleLanguageDiff> PreprocessOperationOffset = default(Offset<IFloatingSubtitleLanguageDiff>), byte NullMask = 0)
		{
			builder.StartTable(16);
			IPlayLevelSequence.AddPreprocessOperation(builder, PreprocessOperationOffset);
			IPlayLevelSequence.AddRateEase(builder, RateEaseOffset);
			IPlayLevelSequence.AddRate(builder, Rate);
			IPlayLevelSequence.AddOutro(builder, OutroOffset);
			IPlayLevelSequence.AddIntro(builder, IntroOffset);
			IPlayLevelSequence.AddLoopRange(builder, LoopRangeOffset);
			IPlayLevelSequence.AddMark(builder, MarkOffset);
			IPlayLevelSequence.AddLevelSequencePath(builder, LevelSequencePathOffset);
			IPlayLevelSequence.AddNullMask(builder, NullMask);
			IPlayLevelSequence.AddIsCarryCharacter(builder, IsCarryCharacter);
			IPlayLevelSequence.AddIsPlayOnTeleport(builder, IsPlayOnTeleport);
			IPlayLevelSequence.AddOutroType(builder, Outro_type);
			IPlayLevelSequence.AddIntroType(builder, Intro_type);
			IPlayLevelSequence.AddPlayMode(builder, PlayMode);
			IPlayLevelSequence.AddKeepUI(builder, KeepUI);
			IPlayLevelSequence.AddIsEnableCenterOffset(builder, IsEnableCenterOffset);
			return IPlayLevelSequence.EndIPlayLevelSequence(builder);
		}

		// Token: 0x0603444F RID: 214095 RVA: 0x0070A170 File Offset: 0x00708370
		public static void StartIPlayLevelSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x06034450 RID: 214096 RVA: 0x0070A17A File Offset: 0x0070837A
		public static void AddLevelSequencePath(FlatBufferBuilder builder, StringOffset levelSequencePathOffset)
		{
			builder.AddOffset(0, levelSequencePathOffset.Value, 0);
		}

		// Token: 0x06034451 RID: 214097 RVA: 0x0070A18A File Offset: 0x0070838A
		public static void AddIsEnableCenterOffset(FlatBufferBuilder builder, bool isEnableCenterOffset)
		{
			builder.AddBool(1, isEnableCenterOffset, false);
		}

		// Token: 0x06034452 RID: 214098 RVA: 0x0070A195 File Offset: 0x00708395
		public static void AddKeepUI(FlatBufferBuilder builder, bool keepUI)
		{
			builder.AddBool(2, keepUI, false);
		}

		// Token: 0x06034453 RID: 214099 RVA: 0x0070A1A0 File Offset: 0x007083A0
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(3, markOffset.Value, 0);
		}

		// Token: 0x06034454 RID: 214100 RVA: 0x0070A1B0 File Offset: 0x007083B0
		public static void AddPlayMode(FlatBufferBuilder builder, TPlayMode playMode)
		{
			builder.AddByte(4, (byte)playMode, 0);
		}

		// Token: 0x06034455 RID: 214101 RVA: 0x0070A1BB File Offset: 0x007083BB
		public static void AddLoopRange(FlatBufferBuilder builder, Offset<ILoopRange> loopRangeOffset)
		{
			builder.AddOffset(5, loopRangeOffset.Value, 0);
		}

		// Token: 0x06034456 RID: 214102 RVA: 0x0070A1CB File Offset: 0x007083CB
		public static void AddIntroType(FlatBufferBuilder builder, TLevelSequenceTransition introType)
		{
			builder.AddByte(6, (byte)introType, 0);
		}

		// Token: 0x06034457 RID: 214103 RVA: 0x0070A1D6 File Offset: 0x007083D6
		public static void AddIntro(FlatBufferBuilder builder, int introOffset)
		{
			builder.AddOffset(7, introOffset, 0);
		}

		// Token: 0x06034458 RID: 214104 RVA: 0x0070A1E1 File Offset: 0x007083E1
		public static void AddOutroType(FlatBufferBuilder builder, TLevelSequenceTransition outroType)
		{
			builder.AddByte(8, (byte)outroType, 0);
		}

		// Token: 0x06034459 RID: 214105 RVA: 0x0070A1EC File Offset: 0x007083EC
		public static void AddOutro(FlatBufferBuilder builder, int outroOffset)
		{
			builder.AddOffset(9, outroOffset, 0);
		}

		// Token: 0x0603445A RID: 214106 RVA: 0x0070A1F8 File Offset: 0x007083F8
		public static void AddRate(FlatBufferBuilder builder, float rate)
		{
			builder.AddFloat(10, rate, 0.0);
		}

		// Token: 0x0603445B RID: 214107 RVA: 0x0070A20C File Offset: 0x0070840C
		public static void AddRateEase(FlatBufferBuilder builder, Offset<IEaseData> rateEaseOffset)
		{
			builder.AddOffset(11, rateEaseOffset.Value, 0);
		}

		// Token: 0x0603445C RID: 214108 RVA: 0x0070A21D File Offset: 0x0070841D
		public static void AddIsPlayOnTeleport(FlatBufferBuilder builder, bool isPlayOnTeleport)
		{
			builder.AddBool(12, isPlayOnTeleport, false);
		}

		// Token: 0x0603445D RID: 214109 RVA: 0x0070A229 File Offset: 0x00708429
		public static void AddIsCarryCharacter(FlatBufferBuilder builder, bool isCarryCharacter)
		{
			builder.AddBool(13, isCarryCharacter, false);
		}

		// Token: 0x0603445E RID: 214110 RVA: 0x0070A235 File Offset: 0x00708435
		public static void AddPreprocessOperation(FlatBufferBuilder builder, Offset<IFloatingSubtitleLanguageDiff> preprocessOperationOffset)
		{
			builder.AddOffset(14, preprocessOperationOffset.Value, 0);
		}

		// Token: 0x0603445F RID: 214111 RVA: 0x0070A246 File Offset: 0x00708446
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x06034460 RID: 214112 RVA: 0x0070A252 File Offset: 0x00708452
		public static Offset<IPlayLevelSequence> EndIPlayLevelSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPlayLevelSequence>(builder.EndTable());
		}

		// Token: 0x06034461 RID: 214113 RVA: 0x0070A260 File Offset: 0x00708460
		public IPlayLevelSequenceT UnPack()
		{
			IPlayLevelSequenceT playLevelSequenceT = new IPlayLevelSequenceT();
			this.UnPackTo(playLevelSequenceT);
			return playLevelSequenceT;
		}

		// Token: 0x06034462 RID: 214114 RVA: 0x0070A27C File Offset: 0x0070847C
		public void UnPackTo(IPlayLevelSequenceT _o)
		{
			_o.LevelSequencePath = this.LevelSequencePath;
			_o.IsEnableCenterOffset = this.IsEnableCenterOffset;
			_o.KeepUI = this.KeepUI;
			_o.Mark = this.Mark;
			_o.PlayMode = this.PlayMode;
			_o.LoopRange = ((this.LoopRange != null) ? this.LoopRange.Value.UnPack() : null);
			_o.Intro = new TLevelSequenceTransitionUnion();
			_o.Intro.Type = this.IntroType;
			TLevelSequenceTransition tlevelSequenceTransition = this.IntroType;
			if (tlevelSequenceTransition != TLevelSequenceTransition.ICameraTransition)
			{
				if (tlevelSequenceTransition == TLevelSequenceTransition.IMaskTransition)
				{
					_o.Intro.Value = ((this.Intro<IMaskTransition>() != null) ? this.Intro<IMaskTransition>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Intro.Value = ((this.Intro<ICameraTransition>() != null) ? this.Intro<ICameraTransition>().Value.UnPack() : null);
			}
			_o.Outro = new TLevelSequenceTransitionUnion();
			_o.Outro.Type = this.OutroType;
			tlevelSequenceTransition = this.OutroType;
			if (tlevelSequenceTransition != TLevelSequenceTransition.ICameraTransition)
			{
				if (tlevelSequenceTransition == TLevelSequenceTransition.IMaskTransition)
				{
					_o.Outro.Value = ((this.Outro<IMaskTransition>() != null) ? this.Outro<IMaskTransition>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Outro.Value = ((this.Outro<ICameraTransition>() != null) ? this.Outro<ICameraTransition>().Value.UnPack() : null);
			}
			_o.Rate = this.Rate;
			_o.RateEase = ((this.RateEase != null) ? this.RateEase.Value.UnPack() : null);
			_o.IsPlayOnTeleport = this.IsPlayOnTeleport;
			_o.IsCarryCharacter = this.IsCarryCharacter;
			_o.PreprocessOperation = ((this.PreprocessOperation != null) ? this.PreprocessOperation.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034463 RID: 214115 RVA: 0x0070A4C0 File Offset: 0x007086C0
		public static Offset<IPlayLevelSequence> Pack(FlatBufferBuilder builder, IPlayLevelSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayLevelSequence>);
			}
			StringOffset levelSequencePathOffset = (_o.LevelSequencePath == null) ? default(StringOffset) : builder.CreateString(_o.LevelSequencePath);
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			Offset<ILoopRange> loopRangeOffset = (_o.LoopRange == null) ? default(Offset<ILoopRange>) : ILoopRange.Pack(builder, _o.LoopRange);
			TLevelSequenceTransition intro_type = (_o.Intro == null) ? TLevelSequenceTransition.NONE : _o.Intro.Type;
			int introOffset = (_o.Intro == null) ? 0 : TLevelSequenceTransitionUnion.Pack(builder, _o.Intro);
			TLevelSequenceTransition outro_type = (_o.Outro == null) ? TLevelSequenceTransition.NONE : _o.Outro.Type;
			int outroOffset = (_o.Outro == null) ? 0 : TLevelSequenceTransitionUnion.Pack(builder, _o.Outro);
			Offset<IEaseData> rateEaseOffset = (_o.RateEase == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.RateEase);
			Offset<IFloatingSubtitleLanguageDiff> preprocessOperationOffset = (_o.PreprocessOperation == null) ? default(Offset<IFloatingSubtitleLanguageDiff>) : IFloatingSubtitleLanguageDiff.Pack(builder, _o.PreprocessOperation);
			return IPlayLevelSequence.CreateIPlayLevelSequence(builder, levelSequencePathOffset, _o.IsEnableCenterOffset, _o.KeepUI, markOffset, _o.PlayMode, loopRangeOffset, intro_type, introOffset, outro_type, outroOffset, _o.Rate, rateEaseOffset, _o.IsPlayOnTeleport, _o.IsCarryCharacter, preprocessOperationOffset, _o.NullMask);
		}

		// Token: 0x0401261B RID: 75291
		private Table __p;
	}
}
