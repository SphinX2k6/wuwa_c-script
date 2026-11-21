using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200802E RID: 32814
	public class TUiGameUnion
	{
		// Token: 0x1700F341 RID: 62273
		// (get) Token: 0x0603B07B RID: 241787 RVA: 0x007ECD74 File Offset: 0x007EAF74
		// (set) Token: 0x0603B07C RID: 241788 RVA: 0x007ECD7C File Offset: 0x007EAF7C
		public TUiGame Type { get; set; }

		// Token: 0x1700F342 RID: 62274
		// (get) Token: 0x0603B07D RID: 241789 RVA: 0x007ECD85 File Offset: 0x007EAF85
		// (set) Token: 0x0603B07E RID: 241790 RVA: 0x007ECD8D File Offset: 0x007EAF8D
		public object Value { get; set; }

		// Token: 0x0603B07F RID: 241791 RVA: 0x007ECD96 File Offset: 0x007EAF96
		public TUiGameUnion()
		{
			this.Type = TUiGame.NONE;
			this.Value = null;
		}

		// Token: 0x0603B080 RID: 241792 RVA: 0x007ECDAC File Offset: 0x007EAFAC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B081 RID: 241793 RVA: 0x007ECDBE File Offset: 0x007EAFBE
		public IBrokenRockT AsIBrokenRock()
		{
			return this.As<IBrokenRockT>();
		}

		// Token: 0x0603B082 RID: 241794 RVA: 0x007ECDC6 File Offset: 0x007EAFC6
		public static TUiGameUnion FromIBrokenRock(IBrokenRockT _ibrokenrock)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IBrokenRock,
				Value = _ibrokenrock
			};
		}

		// Token: 0x0603B083 RID: 241795 RVA: 0x007ECDDB File Offset: 0x007EAFDB
		public ICipherGameplayT AsICipherGameplay()
		{
			return this.As<ICipherGameplayT>();
		}

		// Token: 0x0603B084 RID: 241796 RVA: 0x007ECDE3 File Offset: 0x007EAFE3
		public static TUiGameUnion FromICipherGameplay(ICipherGameplayT _iciphergameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ICipherGameplay,
				Value = _iciphergameplay
			};
		}

		// Token: 0x0603B085 RID: 241797 RVA: 0x007ECDF8 File Offset: 0x007EAFF8
		public IDaemonHackT AsIDaemonHack()
		{
			return this.As<IDaemonHackT>();
		}

		// Token: 0x0603B086 RID: 241798 RVA: 0x007ECE00 File Offset: 0x007EB000
		public static TUiGameUnion FromIDaemonHack(IDaemonHackT _idaemonhack)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDaemonHack,
				Value = _idaemonhack
			};
		}

		// Token: 0x0603B087 RID: 241799 RVA: 0x007ECE15 File Offset: 0x007EB015
		public IDaolingAuthenticationT AsIDaolingAuthentication()
		{
			return this.As<IDaolingAuthenticationT>();
		}

		// Token: 0x0603B088 RID: 241800 RVA: 0x007ECE1D File Offset: 0x007EB01D
		public static TUiGameUnion FromIDaolingAuthentication(IDaolingAuthenticationT _idaolingauthentication)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDaolingAuthentication,
				Value = _idaolingauthentication
			};
		}

		// Token: 0x0603B089 RID: 241801 RVA: 0x007ECE32 File Offset: 0x007EB032
		public IDartGameplayT AsIDartGameplay()
		{
			return this.As<IDartGameplayT>();
		}

		// Token: 0x0603B08A RID: 241802 RVA: 0x007ECE3A File Offset: 0x007EB03A
		public static TUiGameUnion FromIDartGameplay(IDartGameplayT _idartgameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDartGameplay,
				Value = _idartgameplay
			};
		}

		// Token: 0x0603B08B RID: 241803 RVA: 0x007ECE4F File Offset: 0x007EB04F
		public IDollGrabT AsIDollGrab()
		{
			return this.As<IDollGrabT>();
		}

		// Token: 0x0603B08C RID: 241804 RVA: 0x007ECE57 File Offset: 0x007EB057
		public static TUiGameUnion FromIDollGrab(IDollGrabT _idollgrab)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDollGrab,
				Value = _idollgrab
			};
		}

		// Token: 0x0603B08D RID: 241805 RVA: 0x007ECE6C File Offset: 0x007EB06C
		public IDollGrabShowcaseT AsIDollGrabShowcase()
		{
			return this.As<IDollGrabShowcaseT>();
		}

		// Token: 0x0603B08E RID: 241806 RVA: 0x007ECE74 File Offset: 0x007EB074
		public static TUiGameUnion FromIDollGrabShowcase(IDollGrabShowcaseT _idollgrabshowcase)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDollGrabShowcase,
				Value = _idollgrabshowcase
			};
		}

		// Token: 0x0603B08F RID: 241807 RVA: 0x007ECE89 File Offset: 0x007EB089
		public IDragActorT AsIDragActor()
		{
			return this.As<IDragActorT>();
		}

		// Token: 0x0603B090 RID: 241808 RVA: 0x007ECE91 File Offset: 0x007EB091
		public static TUiGameUnion FromIDragActor(IDragActorT _idragactor)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDragActor,
				Value = _idragactor
			};
		}

		// Token: 0x0603B091 RID: 241809 RVA: 0x007ECEA6 File Offset: 0x007EB0A6
		public IFindSunSpiritT AsIFindSunSpirit()
		{
			return this.As<IFindSunSpiritT>();
		}

		// Token: 0x0603B092 RID: 241810 RVA: 0x007ECEAE File Offset: 0x007EB0AE
		public static TUiGameUnion FromIFindSunSpirit(IFindSunSpiritT _ifindsunspirit)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFindSunSpirit,
				Value = _ifindsunspirit
			};
		}

		// Token: 0x0603B093 RID: 241811 RVA: 0x007ECEC4 File Offset: 0x007EB0C4
		public IFishingRouletteT AsIFishingRoulette()
		{
			return this.As<IFishingRouletteT>();
		}

		// Token: 0x0603B094 RID: 241812 RVA: 0x007ECECC File Offset: 0x007EB0CC
		public static TUiGameUnion FromIFishingRoulette(IFishingRouletteT _ifishingroulette)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFishingRoulette,
				Value = _ifishingroulette
			};
		}

		// Token: 0x0603B095 RID: 241813 RVA: 0x007ECEE2 File Offset: 0x007EB0E2
		public IFlowerSeaEscapeT AsIFlowerSeaEscape()
		{
			return this.As<IFlowerSeaEscapeT>();
		}

		// Token: 0x0603B096 RID: 241814 RVA: 0x007ECEEA File Offset: 0x007EB0EA
		public static TUiGameUnion FromIFlowerSeaEscape(IFlowerSeaEscapeT _iflowerseaescape)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFlowerSeaEscape,
				Value = _iflowerseaescape
			};
		}

		// Token: 0x0603B097 RID: 241815 RVA: 0x007ECF00 File Offset: 0x007EB100
		public IFrequencyDetectT AsIFrequencyDetect()
		{
			return this.As<IFrequencyDetectT>();
		}

		// Token: 0x0603B098 RID: 241816 RVA: 0x007ECF08 File Offset: 0x007EB108
		public static TUiGameUnion FromIFrequencyDetect(IFrequencyDetectT _ifrequencydetect)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFrequencyDetect,
				Value = _ifrequencydetect
			};
		}

		// Token: 0x0603B099 RID: 241817 RVA: 0x007ECF1E File Offset: 0x007EB11E
		public IFrequencyPaintT AsIFrequencyPaint()
		{
			return this.As<IFrequencyPaintT>();
		}

		// Token: 0x0603B09A RID: 241818 RVA: 0x007ECF26 File Offset: 0x007EB126
		public static TUiGameUnion FromIFrequencyPaint(IFrequencyPaintT _ifrequencypaint)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFrequencyPaint,
				Value = _ifrequencypaint
			};
		}

		// Token: 0x0603B09B RID: 241819 RVA: 0x007ECF3C File Offset: 0x007EB13C
		public IInstrumentQteGameplayT AsIInstrumentQteGameplay()
		{
			return this.As<IInstrumentQteGameplayT>();
		}

		// Token: 0x0603B09C RID: 241820 RVA: 0x007ECF44 File Offset: 0x007EB144
		public static TUiGameUnion FromIInstrumentQteGameplay(IInstrumentQteGameplayT _iinstrumentqtegameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IInstrumentQteGameplay,
				Value = _iinstrumentqtegameplay
			};
		}

		// Token: 0x0603B09D RID: 241821 RVA: 0x007ECF5A File Offset: 0x007EB15A
		public IItemInspectionT AsIItemInspection()
		{
			return this.As<IItemInspectionT>();
		}

		// Token: 0x0603B09E RID: 241822 RVA: 0x007ECF62 File Offset: 0x007EB162
		public static TUiGameUnion FromIItemInspection(IItemInspectionT _iiteminspection)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IItemInspection,
				Value = _iiteminspection
			};
		}

		// Token: 0x0603B09F RID: 241823 RVA: 0x007ECF78 File Offset: 0x007EB178
		public ILifePointT AsILifePoint()
		{
			return this.As<ILifePointT>();
		}

		// Token: 0x0603B0A0 RID: 241824 RVA: 0x007ECF80 File Offset: 0x007EB180
		public static TUiGameUnion FromILifePoint(ILifePointT _ilifepoint)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ILifePoint,
				Value = _ilifepoint
			};
		}

		// Token: 0x0603B0A1 RID: 241825 RVA: 0x007ECF96 File Offset: 0x007EB196
		public IMorseCodeT AsIMorseCode()
		{
			return this.As<IMorseCodeT>();
		}

		// Token: 0x0603B0A2 RID: 241826 RVA: 0x007ECF9E File Offset: 0x007EB19E
		public static TUiGameUnion FromIMorseCode(IMorseCodeT _imorsecode)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IMorseCode,
				Value = _imorsecode
			};
		}

		// Token: 0x0603B0A3 RID: 241827 RVA: 0x007ECFB4 File Offset: 0x007EB1B4
		public IPlayPianoGameplayT AsIPlayPianoGameplay()
		{
			return this.As<IPlayPianoGameplayT>();
		}

		// Token: 0x0603B0A4 RID: 241828 RVA: 0x007ECFBC File Offset: 0x007EB1BC
		public static TUiGameUnion FromIPlayPianoGameplay(IPlayPianoGameplayT _iplaypianogameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IPlayPianoGameplay,
				Value = _iplaypianogameplay
			};
		}

		// Token: 0x0603B0A5 RID: 241829 RVA: 0x007ECFD2 File Offset: 0x007EB1D2
		public IProjectionMachineT AsIProjectionMachine()
		{
			return this.As<IProjectionMachineT>();
		}

		// Token: 0x0603B0A6 RID: 241830 RVA: 0x007ECFDA File Offset: 0x007EB1DA
		public static TUiGameUnion FromIProjectionMachine(IProjectionMachineT _iprojectionmachine)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IProjectionMachine,
				Value = _iprojectionmachine
			};
		}

		// Token: 0x0603B0A7 RID: 241831 RVA: 0x007ECFF0 File Offset: 0x007EB1F0
		public IProjectorPuzzleT AsIProjectorPuzzle()
		{
			return this.As<IProjectorPuzzleT>();
		}

		// Token: 0x0603B0A8 RID: 241832 RVA: 0x007ECFF8 File Offset: 0x007EB1F8
		public static TUiGameUnion FromIProjectorPuzzle(IProjectorPuzzleT _iprojectorpuzzle)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IProjectorPuzzle,
				Value = _iprojectorpuzzle
			};
		}

		// Token: 0x0603B0A9 RID: 241833 RVA: 0x007ED00E File Offset: 0x007EB20E
		public IQteHourglassT AsIQteHourglass()
		{
			return this.As<IQteHourglassT>();
		}

		// Token: 0x0603B0AA RID: 241834 RVA: 0x007ED016 File Offset: 0x007EB216
		public static TUiGameUnion FromIQteHourglass(IQteHourglassT _iqtehourglass)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IQteHourglass,
				Value = _iqtehourglass
			};
		}

		// Token: 0x0603B0AB RID: 241835 RVA: 0x007ED02C File Offset: 0x007EB22C
		public IReignsT AsIReigns()
		{
			return this.As<IReignsT>();
		}

		// Token: 0x0603B0AC RID: 241836 RVA: 0x007ED034 File Offset: 0x007EB234
		public static TUiGameUnion FromIReigns(IReignsT _ireigns)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IReigns,
				Value = _ireigns
			};
		}

		// Token: 0x0603B0AD RID: 241837 RVA: 0x007ED04A File Offset: 0x007EB24A
		public IRenjuChessT AsIRenjuChess()
		{
			return this.As<IRenjuChessT>();
		}

		// Token: 0x0603B0AE RID: 241838 RVA: 0x007ED052 File Offset: 0x007EB252
		public static TUiGameUnion FromIRenjuChess(IRenjuChessT _irenjuchess)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IRenjuChess,
				Value = _irenjuchess
			};
		}

		// Token: 0x0603B0AF RID: 241839 RVA: 0x007ED068 File Offset: 0x007EB268
		public IRideFlyingCarT AsIRideFlyingCar()
		{
			return this.As<IRideFlyingCarT>();
		}

		// Token: 0x0603B0B0 RID: 241840 RVA: 0x007ED070 File Offset: 0x007EB270
		public static TUiGameUnion FromIRideFlyingCar(IRideFlyingCarT _irideflyingcar)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IRideFlyingCar,
				Value = _irideflyingcar
			};
		}

		// Token: 0x0603B0B1 RID: 241841 RVA: 0x007ED086 File Offset: 0x007EB286
		public ISceneInspectionT AsISceneInspection()
		{
			return this.As<ISceneInspectionT>();
		}

		// Token: 0x0603B0B2 RID: 241842 RVA: 0x007ED08E File Offset: 0x007EB28E
		public static TUiGameUnion FromISceneInspection(ISceneInspectionT _isceneinspection)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISceneInspection,
				Value = _isceneinspection
			};
		}

		// Token: 0x0603B0B3 RID: 241843 RVA: 0x007ED0A4 File Offset: 0x007EB2A4
		public ISheriffReasoningT AsISheriffReasoning()
		{
			return this.As<ISheriffReasoningT>();
		}

		// Token: 0x0603B0B4 RID: 241844 RVA: 0x007ED0AC File Offset: 0x007EB2AC
		public static TUiGameUnion FromISheriffReasoning(ISheriffReasoningT _isheriffreasoning)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISheriffReasoning,
				Value = _isheriffreasoning
			};
		}

		// Token: 0x0603B0B5 RID: 241845 RVA: 0x007ED0C2 File Offset: 0x007EB2C2
		public ISignalBreakGameplayT AsISignalBreakGameplay()
		{
			return this.As<ISignalBreakGameplayT>();
		}

		// Token: 0x0603B0B6 RID: 241846 RVA: 0x007ED0CA File Offset: 0x007EB2CA
		public static TUiGameUnion FromISignalBreakGameplay(ISignalBreakGameplayT _isignalbreakgameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalBreakGameplay,
				Value = _isignalbreakgameplay
			};
		}

		// Token: 0x0603B0B7 RID: 241847 RVA: 0x007ED0E0 File Offset: 0x007EB2E0
		public ISignalDeviceT AsISignalDevice()
		{
			return this.As<ISignalDeviceT>();
		}

		// Token: 0x0603B0B8 RID: 241848 RVA: 0x007ED0E8 File Offset: 0x007EB2E8
		public static TUiGameUnion FromISignalDevice(ISignalDeviceT _isignaldevice)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalDevice,
				Value = _isignaldevice
			};
		}

		// Token: 0x0603B0B9 RID: 241849 RVA: 0x007ED0FE File Offset: 0x007EB2FE
		public ISignalDevice2T AsISignalDevice2()
		{
			return this.As<ISignalDevice2T>();
		}

		// Token: 0x0603B0BA RID: 241850 RVA: 0x007ED106 File Offset: 0x007EB306
		public static TUiGameUnion FromISignalDevice2(ISignalDevice2T _isignaldevice2)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalDevice2,
				Value = _isignaldevice2
			};
		}

		// Token: 0x0603B0BB RID: 241851 RVA: 0x007ED11C File Offset: 0x007EB31C
		public ISundialPuzzleGameplayT AsISundialPuzzleGameplay()
		{
			return this.As<ISundialPuzzleGameplayT>();
		}

		// Token: 0x0603B0BC RID: 241852 RVA: 0x007ED124 File Offset: 0x007EB324
		public static TUiGameUnion FromISundialPuzzleGameplay(ISundialPuzzleGameplayT _isundialpuzzlegameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISundialPuzzleGameplay,
				Value = _isundialpuzzlegameplay
			};
		}

		// Token: 0x0603B0BD RID: 241853 RVA: 0x007ED13A File Offset: 0x007EB33A
		public ITraceTracingT AsITraceTracing()
		{
			return this.As<ITraceTracingT>();
		}

		// Token: 0x0603B0BE RID: 241854 RVA: 0x007ED142 File Offset: 0x007EB342
		public static TUiGameUnion FromITraceTracing(ITraceTracingT _itracetracing)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ITraceTracing,
				Value = _itracetracing
			};
		}

		// Token: 0x0603B0BF RID: 241855 RVA: 0x007ED158 File Offset: 0x007EB358
		public ITuningStandT AsITuningStand()
		{
			return this.As<ITuningStandT>();
		}

		// Token: 0x0603B0C0 RID: 241856 RVA: 0x007ED160 File Offset: 0x007EB360
		public static TUiGameUnion FromITuningStand(ITuningStandT _ituningstand)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ITuningStand,
				Value = _ituningstand
			};
		}

		// Token: 0x0603B0C1 RID: 241857 RVA: 0x007ED176 File Offset: 0x007EB376
		public ITurntableConnectorUiGameplayT AsITurntableConnectorUiGameplay()
		{
			return this.As<ITurntableConnectorUiGameplayT>();
		}

		// Token: 0x0603B0C2 RID: 241858 RVA: 0x007ED17E File Offset: 0x007EB37E
		public static TUiGameUnion FromITurntableConnectorUiGameplay(ITurntableConnectorUiGameplayT _iturntableconnectoruigameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ITurntableConnectorUiGameplay,
				Value = _iturntableconnectoruigameplay
			};
		}

		// Token: 0x0603B0C3 RID: 241859 RVA: 0x007ED194 File Offset: 0x007EB394
		public IWriteLetterT AsIWriteLetter()
		{
			return this.As<IWriteLetterT>();
		}

		// Token: 0x0603B0C4 RID: 241860 RVA: 0x007ED19C File Offset: 0x007EB39C
		public static TUiGameUnion FromIWriteLetter(IWriteLetterT _iwriteletter)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IWriteLetter,
				Value = _iwriteletter
			};
		}

		// Token: 0x0603B0C5 RID: 241861 RVA: 0x007ED1B2 File Offset: 0x007EB3B2
		public IWuWaGoGameT AsIWuWaGoGame()
		{
			return this.As<IWuWaGoGameT>();
		}

		// Token: 0x0603B0C6 RID: 241862 RVA: 0x007ED1BA File Offset: 0x007EB3BA
		public static TUiGameUnion FromIWuWaGoGame(IWuWaGoGameT _iwuwagogame)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IWuWaGoGame,
				Value = _iwuwagogame
			};
		}

		// Token: 0x0603B0C7 RID: 241863 RVA: 0x007ED1D0 File Offset: 0x007EB3D0
		public static int Pack(FlatBufferBuilder builder, TUiGameUnion _o)
		{
			switch (_o.Type)
			{
			case TUiGame.IBrokenRock:
				return IBrokenRock.Pack(builder, _o.AsIBrokenRock()).Value;
			case TUiGame.ICipherGameplay:
				return ICipherGameplay.Pack(builder, _o.AsICipherGameplay()).Value;
			case TUiGame.IDaemonHack:
				return IDaemonHack.Pack(builder, _o.AsIDaemonHack()).Value;
			case TUiGame.IDaolingAuthentication:
				return IDaolingAuthentication.Pack(builder, _o.AsIDaolingAuthentication()).Value;
			case TUiGame.IDartGameplay:
				return IDartGameplay.Pack(builder, _o.AsIDartGameplay()).Value;
			case TUiGame.IDollGrab:
				return IDollGrab.Pack(builder, _o.AsIDollGrab()).Value;
			case TUiGame.IDollGrabShowcase:
				return IDollGrabShowcase.Pack(builder, _o.AsIDollGrabShowcase()).Value;
			case TUiGame.IDragActor:
				return IDragActor.Pack(builder, _o.AsIDragActor()).Value;
			case TUiGame.IFindSunSpirit:
				return IFindSunSpirit.Pack(builder, _o.AsIFindSunSpirit()).Value;
			case TUiGame.IFishingRoulette:
				return IFishingRoulette.Pack(builder, _o.AsIFishingRoulette()).Value;
			case TUiGame.IFlowerSeaEscape:
				return IFlowerSeaEscape.Pack(builder, _o.AsIFlowerSeaEscape()).Value;
			case TUiGame.IFrequencyDetect:
				return IFrequencyDetect.Pack(builder, _o.AsIFrequencyDetect()).Value;
			case TUiGame.IFrequencyPaint:
				return IFrequencyPaint.Pack(builder, _o.AsIFrequencyPaint()).Value;
			case TUiGame.IInstrumentQteGameplay:
				return IInstrumentQteGameplay.Pack(builder, _o.AsIInstrumentQteGameplay()).Value;
			case TUiGame.IItemInspection:
				return IItemInspection.Pack(builder, _o.AsIItemInspection()).Value;
			case TUiGame.ILifePoint:
				return ILifePoint.Pack(builder, _o.AsILifePoint()).Value;
			case TUiGame.IMorseCode:
				return IMorseCode.Pack(builder, _o.AsIMorseCode()).Value;
			case TUiGame.IPlayPianoGameplay:
				return IPlayPianoGameplay.Pack(builder, _o.AsIPlayPianoGameplay()).Value;
			case TUiGame.IProjectionMachine:
				return IProjectionMachine.Pack(builder, _o.AsIProjectionMachine()).Value;
			case TUiGame.IProjectorPuzzle:
				return IProjectorPuzzle.Pack(builder, _o.AsIProjectorPuzzle()).Value;
			case TUiGame.IQteHourglass:
				return IQteHourglass.Pack(builder, _o.AsIQteHourglass()).Value;
			case TUiGame.IReigns:
				return IReigns.Pack(builder, _o.AsIReigns()).Value;
			case TUiGame.IRenjuChess:
				return IRenjuChess.Pack(builder, _o.AsIRenjuChess()).Value;
			case TUiGame.IRideFlyingCar:
				return IRideFlyingCar.Pack(builder, _o.AsIRideFlyingCar()).Value;
			case TUiGame.ISceneInspection:
				return ISceneInspection.Pack(builder, _o.AsISceneInspection()).Value;
			case TUiGame.ISheriffReasoning:
				return ISheriffReasoning.Pack(builder, _o.AsISheriffReasoning()).Value;
			case TUiGame.ISignalBreakGameplay:
				return ISignalBreakGameplay.Pack(builder, _o.AsISignalBreakGameplay()).Value;
			case TUiGame.ISignalDevice:
				return ISignalDevice.Pack(builder, _o.AsISignalDevice()).Value;
			case TUiGame.ISignalDevice2:
				return ISignalDevice2.Pack(builder, _o.AsISignalDevice2()).Value;
			case TUiGame.ISundialPuzzleGameplay:
				return ISundialPuzzleGameplay.Pack(builder, _o.AsISundialPuzzleGameplay()).Value;
			case TUiGame.ITraceTracing:
				return ITraceTracing.Pack(builder, _o.AsITraceTracing()).Value;
			case TUiGame.ITuningStand:
				return ITuningStand.Pack(builder, _o.AsITuningStand()).Value;
			case TUiGame.ITurntableConnectorUiGameplay:
				return ITurntableConnectorUiGameplay.Pack(builder, _o.AsITurntableConnectorUiGameplay()).Value;
			case TUiGame.IWriteLetter:
				return IWriteLetter.Pack(builder, _o.AsIWriteLetter()).Value;
			case TUiGame.IWuWaGoGame:
				return IWuWaGoGame.Pack(builder, _o.AsIWuWaGoGame()).Value;
			default:
				return 0;
			}
		}
	}
}
