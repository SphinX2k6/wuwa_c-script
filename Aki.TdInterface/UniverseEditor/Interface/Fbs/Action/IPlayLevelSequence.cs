using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D23 RID: 27939
	public struct IPlayLevelSequence : IFlatbufferObject
	{
		// Token: 0x1700D000 RID: 53248
		// (get) Token: 0x06031438 RID: 201784 RVA: 0x006AE516 File Offset: 0x006AC716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031439 RID: 201785 RVA: 0x006AE523 File Offset: 0x006AC723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603143A RID: 201786 RVA: 0x006AE52C File Offset: 0x006AC72C
		public static IPlayLevelSequence GetRootAsIPlayLevelSequence(ByteBuffer _bb)
		{
			return IPlayLevelSequence.GetRootAsIPlayLevelSequence(_bb, default(IPlayLevelSequence));
		}

		// Token: 0x0603143B RID: 201787 RVA: 0x006AE548 File Offset: 0x006AC748
		public static IPlayLevelSequence GetRootAsIPlayLevelSequence(ByteBuffer _bb, IPlayLevelSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603143C RID: 201788 RVA: 0x006AE565 File Offset: 0x006AC765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603143D RID: 201789 RVA: 0x006AE574 File Offset: 0x006AC774
		public IPlayLevelSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D001 RID: 53249
		// (get) Token: 0x0603143E RID: 201790 RVA: 0x006AE584 File Offset: 0x006AC784
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

		// Token: 0x0603143F RID: 201791 RVA: 0x006AE5BB File Offset: 0x006AC7BB
		public Span<byte> GetLevelSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031440 RID: 201792 RVA: 0x006AE5CA File Offset: 0x006AC7CA
		public byte[] GetLevelSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D002 RID: 53250
		// (get) Token: 0x06031441 RID: 201793 RVA: 0x006AE5D8 File Offset: 0x006AC7D8
		public bool IsEnableCenterOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D003 RID: 53251
		// (get) Token: 0x06031442 RID: 201794 RVA: 0x006AE618 File Offset: 0x006AC818
		public bool KeepUI
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D004 RID: 53252
		// (get) Token: 0x06031443 RID: 201795 RVA: 0x006AE658 File Offset: 0x006AC858
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

		// Token: 0x06031444 RID: 201796 RVA: 0x006AE690 File Offset: 0x006AC890
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06031445 RID: 201797 RVA: 0x006AE6A0 File Offset: 0x006AC8A0
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D005 RID: 53253
		// (get) Token: 0x06031446 RID: 201798 RVA: 0x006AE6B0 File Offset: 0x006AC8B0
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

		// Token: 0x1700D006 RID: 53254
		// (get) Token: 0x06031447 RID: 201799 RVA: 0x006AE6F0 File Offset: 0x006AC8F0
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

		// Token: 0x1700D007 RID: 53255
		// (get) Token: 0x06031448 RID: 201800 RVA: 0x006AE750 File Offset: 0x006AC950
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

		// Token: 0x06031449 RID: 201801 RVA: 0x006AE790 File Offset: 0x006AC990
		public TTable? Intro<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603144A RID: 201802 RVA: 0x006AE7D8 File Offset: 0x006AC9D8
		public ICameraTransition IntroAsICameraTransition()
		{
			return this.Intro<ICameraTransition>().Value;
		}

		// Token: 0x0603144B RID: 201803 RVA: 0x006AE7F4 File Offset: 0x006AC9F4
		public IMaskTransition IntroAsIMaskTransition()
		{
			return this.Intro<IMaskTransition>().Value;
		}

		// Token: 0x1700D008 RID: 53256
		// (get) Token: 0x0603144C RID: 201804 RVA: 0x006AE810 File Offset: 0x006ACA10
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

		// Token: 0x0603144D RID: 201805 RVA: 0x006AE850 File Offset: 0x006ACA50
		public TTable? Outro<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603144E RID: 201806 RVA: 0x006AE898 File Offset: 0x006ACA98
		public ICameraTransition OutroAsICameraTransition()
		{
			return this.Outro<ICameraTransition>().Value;
		}

		// Token: 0x0603144F RID: 201807 RVA: 0x006AE8B4 File Offset: 0x006ACAB4
		public IMaskTransition OutroAsIMaskTransition()
		{
			return this.Outro<IMaskTransition>().Value;
		}

		// Token: 0x1700D009 RID: 53257
		// (get) Token: 0x06031450 RID: 201808 RVA: 0x006AE8D0 File Offset: 0x006ACAD0
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

		// Token: 0x1700D00A RID: 53258
		// (get) Token: 0x06031451 RID: 201809 RVA: 0x006AE914 File Offset: 0x006ACB14
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

		// Token: 0x1700D00B RID: 53259
		// (get) Token: 0x06031452 RID: 201810 RVA: 0x006AE974 File Offset: 0x006ACB74
		public bool IsPlayOnTeleport
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D00C RID: 53260
		// (get) Token: 0x06031453 RID: 201811 RVA: 0x006AE9B4 File Offset: 0x006ACBB4
		public bool IsCarryCharacter
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D00D RID: 53261
		// (get) Token: 0x06031454 RID: 201812 RVA: 0x006AE9F4 File Offset: 0x006ACBF4
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

		// Token: 0x1700D00E RID: 53262
		// (get) Token: 0x06031455 RID: 201813 RVA: 0x006AEA54 File Offset: 0x006ACC54
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

		// Token: 0x06031456 RID: 201814 RVA: 0x006AEA94 File Offset: 0x006ACC94
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

		// Token: 0x06031457 RID: 201815 RVA: 0x006AEB2C File Offset: 0x006ACD2C
		public static void StartIPlayLevelSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x06031458 RID: 201816 RVA: 0x006AEB36 File Offset: 0x006ACD36
		public static void AddLevelSequencePath(FlatBufferBuilder builder, StringOffset levelSequencePathOffset)
		{
			builder.AddOffset(0, levelSequencePathOffset.Value, 0);
		}

		// Token: 0x06031459 RID: 201817 RVA: 0x006AEB46 File Offset: 0x006ACD46
		public static void AddIsEnableCenterOffset(FlatBufferBuilder builder, bool isEnableCenterOffset)
		{
			builder.AddBool(1, isEnableCenterOffset, false);
		}

		// Token: 0x0603145A RID: 201818 RVA: 0x006AEB51 File Offset: 0x006ACD51
		public static void AddKeepUI(FlatBufferBuilder builder, bool keepUI)
		{
			builder.AddBool(2, keepUI, false);
		}

		// Token: 0x0603145B RID: 201819 RVA: 0x006AEB5C File Offset: 0x006ACD5C
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(3, markOffset.Value, 0);
		}

		// Token: 0x0603145C RID: 201820 RVA: 0x006AEB6C File Offset: 0x006ACD6C
		public static void AddPlayMode(FlatBufferBuilder builder, TPlayMode playMode)
		{
			builder.AddByte(4, (byte)playMode, 0);
		}

		// Token: 0x0603145D RID: 201821 RVA: 0x006AEB77 File Offset: 0x006ACD77
		public static void AddLoopRange(FlatBufferBuilder builder, Offset<ILoopRange> loopRangeOffset)
		{
			builder.AddOffset(5, loopRangeOffset.Value, 0);
		}

		// Token: 0x0603145E RID: 201822 RVA: 0x006AEB87 File Offset: 0x006ACD87
		public static void AddIntroType(FlatBufferBuilder builder, TLevelSequenceTransition introType)
		{
			builder.AddByte(6, (byte)introType, 0);
		}

		// Token: 0x0603145F RID: 201823 RVA: 0x006AEB92 File Offset: 0x006ACD92
		public static void AddIntro(FlatBufferBuilder builder, int introOffset)
		{
			builder.AddOffset(7, introOffset, 0);
		}

		// Token: 0x06031460 RID: 201824 RVA: 0x006AEB9D File Offset: 0x006ACD9D
		public static void AddOutroType(FlatBufferBuilder builder, TLevelSequenceTransition outroType)
		{
			builder.AddByte(8, (byte)outroType, 0);
		}

		// Token: 0x06031461 RID: 201825 RVA: 0x006AEBA8 File Offset: 0x006ACDA8
		public static void AddOutro(FlatBufferBuilder builder, int outroOffset)
		{
			builder.AddOffset(9, outroOffset, 0);
		}

		// Token: 0x06031462 RID: 201826 RVA: 0x006AEBB4 File Offset: 0x006ACDB4
		public static void AddRate(FlatBufferBuilder builder, float rate)
		{
			builder.AddFloat(10, rate, 0.0);
		}

		// Token: 0x06031463 RID: 201827 RVA: 0x006AEBC8 File Offset: 0x006ACDC8
		public static void AddRateEase(FlatBufferBuilder builder, Offset<IEaseData> rateEaseOffset)
		{
			builder.AddOffset(11, rateEaseOffset.Value, 0);
		}

		// Token: 0x06031464 RID: 201828 RVA: 0x006AEBD9 File Offset: 0x006ACDD9
		public static void AddIsPlayOnTeleport(FlatBufferBuilder builder, bool isPlayOnTeleport)
		{
			builder.AddBool(12, isPlayOnTeleport, false);
		}

		// Token: 0x06031465 RID: 201829 RVA: 0x006AEBE5 File Offset: 0x006ACDE5
		public static void AddIsCarryCharacter(FlatBufferBuilder builder, bool isCarryCharacter)
		{
			builder.AddBool(13, isCarryCharacter, false);
		}

		// Token: 0x06031466 RID: 201830 RVA: 0x006AEBF1 File Offset: 0x006ACDF1
		public static void AddPreprocessOperation(FlatBufferBuilder builder, Offset<IFloatingSubtitleLanguageDiff> preprocessOperationOffset)
		{
			builder.AddOffset(14, preprocessOperationOffset.Value, 0);
		}

		// Token: 0x06031467 RID: 201831 RVA: 0x006AEC02 File Offset: 0x006ACE02
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x06031468 RID: 201832 RVA: 0x006AEC0E File Offset: 0x006ACE0E
		public static Offset<IPlayLevelSequence> EndIPlayLevelSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPlayLevelSequence>(builder.EndTable());
		}

		// Token: 0x06031469 RID: 201833 RVA: 0x006AEC1C File Offset: 0x006ACE1C
		public IPlayLevelSequenceT UnPack()
		{
			IPlayLevelSequenceT playLevelSequenceT = new IPlayLevelSequenceT();
			this.UnPackTo(playLevelSequenceT);
			return playLevelSequenceT;
		}

		// Token: 0x0603146A RID: 201834 RVA: 0x006AEC38 File Offset: 0x006ACE38
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

		// Token: 0x0603146B RID: 201835 RVA: 0x006AEE7C File Offset: 0x006AD07C
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

		// Token: 0x040116A0 RID: 71328
		private Table __p;
	}
}
