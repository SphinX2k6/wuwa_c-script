using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A3 RID: 29859
	public class IUiGame_UnionUnion
	{
		// Token: 0x1700E2B1 RID: 58033
		// (get) Token: 0x06036462 RID: 222306 RVA: 0x00760A25 File Offset: 0x0075EC25
		// (set) Token: 0x06036463 RID: 222307 RVA: 0x00760A2D File Offset: 0x0075EC2D
		public IUiGame_Union Type { get; set; }

		// Token: 0x1700E2B2 RID: 58034
		// (get) Token: 0x06036464 RID: 222308 RVA: 0x00760A36 File Offset: 0x0075EC36
		// (set) Token: 0x06036465 RID: 222309 RVA: 0x00760A3E File Offset: 0x0075EC3E
		public object Value { get; set; }

		// Token: 0x06036466 RID: 222310 RVA: 0x00760A47 File Offset: 0x0075EC47
		public IUiGame_UnionUnion()
		{
			this.Type = IUiGame_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036467 RID: 222311 RVA: 0x00760A5D File Offset: 0x0075EC5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036468 RID: 222312 RVA: 0x00760A6F File Offset: 0x0075EC6F
		public IUiGameT AsIUiGame()
		{
			return this.As<IUiGameT>();
		}

		// Token: 0x06036469 RID: 222313 RVA: 0x00760A77 File Offset: 0x0075EC77
		public static IUiGame_UnionUnion FromIUiGame(IUiGameT _iuigame)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IUiGame,
				Value = _iuigame
			};
		}

		// Token: 0x0603646A RID: 222314 RVA: 0x00760A8C File Offset: 0x0075EC8C
		public IReignsT AsIReigns()
		{
			return this.As<IReignsT>();
		}

		// Token: 0x0603646B RID: 222315 RVA: 0x00760A94 File Offset: 0x0075EC94
		public static IUiGame_UnionUnion FromIReigns(IReignsT _ireigns)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IReigns,
				Value = _ireigns
			};
		}

		// Token: 0x0603646C RID: 222316 RVA: 0x00760AA9 File Offset: 0x0075ECA9
		public IFindSunSpiritT AsIFindSunSpirit()
		{
			return this.As<IFindSunSpiritT>();
		}

		// Token: 0x0603646D RID: 222317 RVA: 0x00760AB1 File Offset: 0x0075ECB1
		public static IUiGame_UnionUnion FromIFindSunSpirit(IFindSunSpiritT _ifindsunspirit)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFindSunSpirit,
				Value = _ifindsunspirit
			};
		}

		// Token: 0x0603646E RID: 222318 RVA: 0x00760AC6 File Offset: 0x0075ECC6
		public IDollGrabT AsIDollGrab()
		{
			return this.As<IDollGrabT>();
		}

		// Token: 0x0603646F RID: 222319 RVA: 0x00760ACE File Offset: 0x0075ECCE
		public static IUiGame_UnionUnion FromIDollGrab(IDollGrabT _idollgrab)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDollGrab,
				Value = _idollgrab
			};
		}

		// Token: 0x06036470 RID: 222320 RVA: 0x00760AE3 File Offset: 0x0075ECE3
		public IDollGrabShowcaseT AsIDollGrabShowcase()
		{
			return this.As<IDollGrabShowcaseT>();
		}

		// Token: 0x06036471 RID: 222321 RVA: 0x00760AEB File Offset: 0x0075ECEB
		public static IUiGame_UnionUnion FromIDollGrabShowcase(IDollGrabShowcaseT _idollgrabshowcase)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDollGrabShowcase,
				Value = _idollgrabshowcase
			};
		}

		// Token: 0x06036472 RID: 222322 RVA: 0x00760B00 File Offset: 0x0075ED00
		public IDaemonHackT AsIDaemonHack()
		{
			return this.As<IDaemonHackT>();
		}

		// Token: 0x06036473 RID: 222323 RVA: 0x00760B08 File Offset: 0x0075ED08
		public static IUiGame_UnionUnion FromIDaemonHack(IDaemonHackT _idaemonhack)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDaemonHack,
				Value = _idaemonhack
			};
		}

		// Token: 0x06036474 RID: 222324 RVA: 0x00760B1D File Offset: 0x0075ED1D
		public IProjectionMachineT AsIProjectionMachine()
		{
			return this.As<IProjectionMachineT>();
		}

		// Token: 0x06036475 RID: 222325 RVA: 0x00760B25 File Offset: 0x0075ED25
		public static IUiGame_UnionUnion FromIProjectionMachine(IProjectionMachineT _iprojectionmachine)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IProjectionMachine,
				Value = _iprojectionmachine
			};
		}

		// Token: 0x06036476 RID: 222326 RVA: 0x00760B3A File Offset: 0x0075ED3A
		public IItemInspectionT AsIItemInspection()
		{
			return this.As<IItemInspectionT>();
		}

		// Token: 0x06036477 RID: 222327 RVA: 0x00760B42 File Offset: 0x0075ED42
		public static IUiGame_UnionUnion FromIItemInspection(IItemInspectionT _iiteminspection)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IItemInspection,
				Value = _iiteminspection
			};
		}

		// Token: 0x06036478 RID: 222328 RVA: 0x00760B57 File Offset: 0x0075ED57
		public ICipherGameplayT AsICipherGameplay()
		{
			return this.As<ICipherGameplayT>();
		}

		// Token: 0x06036479 RID: 222329 RVA: 0x00760B5F File Offset: 0x0075ED5F
		public static IUiGame_UnionUnion FromICipherGameplay(ICipherGameplayT _iciphergameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ICipherGameplay,
				Value = _iciphergameplay
			};
		}

		// Token: 0x0603647A RID: 222330 RVA: 0x00760B75 File Offset: 0x0075ED75
		public ISignalBreakGameplayT AsISignalBreakGameplay()
		{
			return this.As<ISignalBreakGameplayT>();
		}

		// Token: 0x0603647B RID: 222331 RVA: 0x00760B7D File Offset: 0x0075ED7D
		public static IUiGame_UnionUnion FromISignalBreakGameplay(ISignalBreakGameplayT _isignalbreakgameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalBreakGameplay,
				Value = _isignalbreakgameplay
			};
		}

		// Token: 0x0603647C RID: 222332 RVA: 0x00760B93 File Offset: 0x0075ED93
		public ISundialPuzzleGameplayT AsISundialPuzzleGameplay()
		{
			return this.As<ISundialPuzzleGameplayT>();
		}

		// Token: 0x0603647D RID: 222333 RVA: 0x00760B9B File Offset: 0x0075ED9B
		public static IUiGame_UnionUnion FromISundialPuzzleGameplay(ISundialPuzzleGameplayT _isundialpuzzlegameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISundialPuzzleGameplay,
				Value = _isundialpuzzlegameplay
			};
		}

		// Token: 0x0603647E RID: 222334 RVA: 0x00760BB1 File Offset: 0x0075EDB1
		public ISignalDeviceT AsISignalDevice()
		{
			return this.As<ISignalDeviceT>();
		}

		// Token: 0x0603647F RID: 222335 RVA: 0x00760BB9 File Offset: 0x0075EDB9
		public static IUiGame_UnionUnion FromISignalDevice(ISignalDeviceT _isignaldevice)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalDevice,
				Value = _isignaldevice
			};
		}

		// Token: 0x06036480 RID: 222336 RVA: 0x00760BCF File Offset: 0x0075EDCF
		public ISignalDevice2T AsISignalDevice2()
		{
			return this.As<ISignalDevice2T>();
		}

		// Token: 0x06036481 RID: 222337 RVA: 0x00760BD7 File Offset: 0x0075EDD7
		public static IUiGame_UnionUnion FromISignalDevice2(ISignalDevice2T _isignaldevice2)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalDevice2,
				Value = _isignaldevice2
			};
		}

		// Token: 0x06036482 RID: 222338 RVA: 0x00760BED File Offset: 0x0075EDED
		public IMorseCodeT AsIMorseCode()
		{
			return this.As<IMorseCodeT>();
		}

		// Token: 0x06036483 RID: 222339 RVA: 0x00760BF5 File Offset: 0x0075EDF5
		public static IUiGame_UnionUnion FromIMorseCode(IMorseCodeT _imorsecode)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IMorseCode,
				Value = _imorsecode
			};
		}

		// Token: 0x06036484 RID: 222340 RVA: 0x00760C0B File Offset: 0x0075EE0B
		public IRenjuChessT AsIRenjuChess()
		{
			return this.As<IRenjuChessT>();
		}

		// Token: 0x06036485 RID: 222341 RVA: 0x00760C13 File Offset: 0x0075EE13
		public static IUiGame_UnionUnion FromIRenjuChess(IRenjuChessT _irenjuchess)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IRenjuChess,
				Value = _irenjuchess
			};
		}

		// Token: 0x06036486 RID: 222342 RVA: 0x00760C29 File Offset: 0x0075EE29
		public IProjectorPuzzleT AsIProjectorPuzzle()
		{
			return this.As<IProjectorPuzzleT>();
		}

		// Token: 0x06036487 RID: 222343 RVA: 0x00760C31 File Offset: 0x0075EE31
		public static IUiGame_UnionUnion FromIProjectorPuzzle(IProjectorPuzzleT _iprojectorpuzzle)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IProjectorPuzzle,
				Value = _iprojectorpuzzle
			};
		}

		// Token: 0x06036488 RID: 222344 RVA: 0x00760C47 File Offset: 0x0075EE47
		public ILifePointT AsILifePoint()
		{
			return this.As<ILifePointT>();
		}

		// Token: 0x06036489 RID: 222345 RVA: 0x00760C4F File Offset: 0x0075EE4F
		public static IUiGame_UnionUnion FromILifePoint(ILifePointT _ilifepoint)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ILifePoint,
				Value = _ilifepoint
			};
		}

		// Token: 0x0603648A RID: 222346 RVA: 0x00760C65 File Offset: 0x0075EE65
		public IBrokenRockT AsIBrokenRock()
		{
			return this.As<IBrokenRockT>();
		}

		// Token: 0x0603648B RID: 222347 RVA: 0x00760C6D File Offset: 0x0075EE6D
		public static IUiGame_UnionUnion FromIBrokenRock(IBrokenRockT _ibrokenrock)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IBrokenRock,
				Value = _ibrokenrock
			};
		}

		// Token: 0x0603648C RID: 222348 RVA: 0x00760C83 File Offset: 0x0075EE83
		public IFlowerSeaEscapeT AsIFlowerSeaEscape()
		{
			return this.As<IFlowerSeaEscapeT>();
		}

		// Token: 0x0603648D RID: 222349 RVA: 0x00760C8B File Offset: 0x0075EE8B
		public static IUiGame_UnionUnion FromIFlowerSeaEscape(IFlowerSeaEscapeT _iflowerseaescape)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFlowerSeaEscape,
				Value = _iflowerseaescape
			};
		}

		// Token: 0x0603648E RID: 222350 RVA: 0x00760CA1 File Offset: 0x0075EEA1
		public IRideFlyingCarT AsIRideFlyingCar()
		{
			return this.As<IRideFlyingCarT>();
		}

		// Token: 0x0603648F RID: 222351 RVA: 0x00760CA9 File Offset: 0x0075EEA9
		public static IUiGame_UnionUnion FromIRideFlyingCar(IRideFlyingCarT _irideflyingcar)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IRideFlyingCar,
				Value = _irideflyingcar
			};
		}

		// Token: 0x06036490 RID: 222352 RVA: 0x00760CBF File Offset: 0x0075EEBF
		public IFishingRouletteT AsIFishingRoulette()
		{
			return this.As<IFishingRouletteT>();
		}

		// Token: 0x06036491 RID: 222353 RVA: 0x00760CC7 File Offset: 0x0075EEC7
		public static IUiGame_UnionUnion FromIFishingRoulette(IFishingRouletteT _ifishingroulette)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFishingRoulette,
				Value = _ifishingroulette
			};
		}

		// Token: 0x06036492 RID: 222354 RVA: 0x00760CDD File Offset: 0x0075EEDD
		public IDaolingAuthenticationT AsIDaolingAuthentication()
		{
			return this.As<IDaolingAuthenticationT>();
		}

		// Token: 0x06036493 RID: 222355 RVA: 0x00760CE5 File Offset: 0x0075EEE5
		public static IUiGame_UnionUnion FromIDaolingAuthentication(IDaolingAuthenticationT _idaolingauthentication)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDaolingAuthentication,
				Value = _idaolingauthentication
			};
		}

		// Token: 0x06036494 RID: 222356 RVA: 0x00760CFB File Offset: 0x0075EEFB
		public IDragActorT AsIDragActor()
		{
			return this.As<IDragActorT>();
		}

		// Token: 0x06036495 RID: 222357 RVA: 0x00760D03 File Offset: 0x0075EF03
		public static IUiGame_UnionUnion FromIDragActor(IDragActorT _idragactor)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDragActor,
				Value = _idragactor
			};
		}

		// Token: 0x06036496 RID: 222358 RVA: 0x00760D19 File Offset: 0x0075EF19
		public IWuWaGoGameT AsIWuWaGoGame()
		{
			return this.As<IWuWaGoGameT>();
		}

		// Token: 0x06036497 RID: 222359 RVA: 0x00760D21 File Offset: 0x0075EF21
		public static IUiGame_UnionUnion FromIWuWaGoGame(IWuWaGoGameT _iwuwagogame)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IWuWaGoGame,
				Value = _iwuwagogame
			};
		}

		// Token: 0x06036498 RID: 222360 RVA: 0x00760D37 File Offset: 0x0075EF37
		public IWriteLetterT AsIWriteLetter()
		{
			return this.As<IWriteLetterT>();
		}

		// Token: 0x06036499 RID: 222361 RVA: 0x00760D3F File Offset: 0x0075EF3F
		public static IUiGame_UnionUnion FromIWriteLetter(IWriteLetterT _iwriteletter)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IWriteLetter,
				Value = _iwriteletter
			};
		}

		// Token: 0x0603649A RID: 222362 RVA: 0x00760D55 File Offset: 0x0075EF55
		public IQteHourglassT AsIQteHourglass()
		{
			return this.As<IQteHourglassT>();
		}

		// Token: 0x0603649B RID: 222363 RVA: 0x00760D5D File Offset: 0x0075EF5D
		public static IUiGame_UnionUnion FromIQteHourglass(IQteHourglassT _iqtehourglass)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IQteHourglass,
				Value = _iqtehourglass
			};
		}

		// Token: 0x0603649C RID: 222364 RVA: 0x00760D73 File Offset: 0x0075EF73
		public IInstrumentQteGameplayT AsIInstrumentQteGameplay()
		{
			return this.As<IInstrumentQteGameplayT>();
		}

		// Token: 0x0603649D RID: 222365 RVA: 0x00760D7B File Offset: 0x0075EF7B
		public static IUiGame_UnionUnion FromIInstrumentQteGameplay(IInstrumentQteGameplayT _iinstrumentqtegameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IInstrumentQteGameplay,
				Value = _iinstrumentqtegameplay
			};
		}

		// Token: 0x0603649E RID: 222366 RVA: 0x00760D91 File Offset: 0x0075EF91
		public IPlayPianoGameplayT AsIPlayPianoGameplay()
		{
			return this.As<IPlayPianoGameplayT>();
		}

		// Token: 0x0603649F RID: 222367 RVA: 0x00760D99 File Offset: 0x0075EF99
		public static IUiGame_UnionUnion FromIPlayPianoGameplay(IPlayPianoGameplayT _iplaypianogameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IPlayPianoGameplay,
				Value = _iplaypianogameplay
			};
		}

		// Token: 0x060364A0 RID: 222368 RVA: 0x00760DAF File Offset: 0x0075EFAF
		public IDartGameplayT AsIDartGameplay()
		{
			return this.As<IDartGameplayT>();
		}

		// Token: 0x060364A1 RID: 222369 RVA: 0x00760DB7 File Offset: 0x0075EFB7
		public static IUiGame_UnionUnion FromIDartGameplay(IDartGameplayT _idartgameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDartGameplay,
				Value = _idartgameplay
			};
		}

		// Token: 0x060364A2 RID: 222370 RVA: 0x00760DCD File Offset: 0x0075EFCD
		public ISceneInspectionT AsISceneInspection()
		{
			return this.As<ISceneInspectionT>();
		}

		// Token: 0x060364A3 RID: 222371 RVA: 0x00760DD5 File Offset: 0x0075EFD5
		public static IUiGame_UnionUnion FromISceneInspection(ISceneInspectionT _isceneinspection)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISceneInspection,
				Value = _isceneinspection
			};
		}

		// Token: 0x060364A4 RID: 222372 RVA: 0x00760DEB File Offset: 0x0075EFEB
		public ITuningStandT AsITuningStand()
		{
			return this.As<ITuningStandT>();
		}

		// Token: 0x060364A5 RID: 222373 RVA: 0x00760DF3 File Offset: 0x0075EFF3
		public static IUiGame_UnionUnion FromITuningStand(ITuningStandT _ituningstand)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ITuningStand,
				Value = _ituningstand
			};
		}

		// Token: 0x060364A6 RID: 222374 RVA: 0x00760E09 File Offset: 0x0075F009
		public ITraceTracingT AsITraceTracing()
		{
			return this.As<ITraceTracingT>();
		}

		// Token: 0x060364A7 RID: 222375 RVA: 0x00760E11 File Offset: 0x0075F011
		public static IUiGame_UnionUnion FromITraceTracing(ITraceTracingT _itracetracing)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ITraceTracing,
				Value = _itracetracing
			};
		}

		// Token: 0x060364A8 RID: 222376 RVA: 0x00760E27 File Offset: 0x0075F027
		public ISheriffReasoningT AsISheriffReasoning()
		{
			return this.As<ISheriffReasoningT>();
		}

		// Token: 0x060364A9 RID: 222377 RVA: 0x00760E2F File Offset: 0x0075F02F
		public static IUiGame_UnionUnion FromISheriffReasoning(ISheriffReasoningT _isheriffreasoning)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISheriffReasoning,
				Value = _isheriffreasoning
			};
		}

		// Token: 0x060364AA RID: 222378 RVA: 0x00760E48 File Offset: 0x0075F048
		public static int Pack(FlatBufferBuilder builder, IUiGame_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUiGame_Union.IUiGame:
				return IUiGame.Pack(builder, _o.AsIUiGame()).Value;
			case IUiGame_Union.IReigns:
				return IReigns.Pack(builder, _o.AsIReigns()).Value;
			case IUiGame_Union.IFindSunSpirit:
				return IFindSunSpirit.Pack(builder, _o.AsIFindSunSpirit()).Value;
			case IUiGame_Union.IDollGrab:
				return IDollGrab.Pack(builder, _o.AsIDollGrab()).Value;
			case IUiGame_Union.IDollGrabShowcase:
				return IDollGrabShowcase.Pack(builder, _o.AsIDollGrabShowcase()).Value;
			case IUiGame_Union.IDaemonHack:
				return IDaemonHack.Pack(builder, _o.AsIDaemonHack()).Value;
			case IUiGame_Union.IProjectionMachine:
				return IProjectionMachine.Pack(builder, _o.AsIProjectionMachine()).Value;
			case IUiGame_Union.IItemInspection:
				return IItemInspection.Pack(builder, _o.AsIItemInspection()).Value;
			case IUiGame_Union.ICipherGameplay:
				return ICipherGameplay.Pack(builder, _o.AsICipherGameplay()).Value;
			case IUiGame_Union.ISignalBreakGameplay:
				return ISignalBreakGameplay.Pack(builder, _o.AsISignalBreakGameplay()).Value;
			case IUiGame_Union.ISundialPuzzleGameplay:
				return ISundialPuzzleGameplay.Pack(builder, _o.AsISundialPuzzleGameplay()).Value;
			case IUiGame_Union.ISignalDevice:
				return ISignalDevice.Pack(builder, _o.AsISignalDevice()).Value;
			case IUiGame_Union.ISignalDevice2:
				return ISignalDevice2.Pack(builder, _o.AsISignalDevice2()).Value;
			case IUiGame_Union.IMorseCode:
				return IMorseCode.Pack(builder, _o.AsIMorseCode()).Value;
			case IUiGame_Union.IRenjuChess:
				return IRenjuChess.Pack(builder, _o.AsIRenjuChess()).Value;
			case IUiGame_Union.IProjectorPuzzle:
				return IProjectorPuzzle.Pack(builder, _o.AsIProjectorPuzzle()).Value;
			case IUiGame_Union.ILifePoint:
				return ILifePoint.Pack(builder, _o.AsILifePoint()).Value;
			case IUiGame_Union.IBrokenRock:
				return IBrokenRock.Pack(builder, _o.AsIBrokenRock()).Value;
			case IUiGame_Union.IFlowerSeaEscape:
				return IFlowerSeaEscape.Pack(builder, _o.AsIFlowerSeaEscape()).Value;
			case IUiGame_Union.IRideFlyingCar:
				return IRideFlyingCar.Pack(builder, _o.AsIRideFlyingCar()).Value;
			case IUiGame_Union.IFishingRoulette:
				return IFishingRoulette.Pack(builder, _o.AsIFishingRoulette()).Value;
			case IUiGame_Union.IDaolingAuthentication:
				return IDaolingAuthentication.Pack(builder, _o.AsIDaolingAuthentication()).Value;
			case IUiGame_Union.IDragActor:
				return IDragActor.Pack(builder, _o.AsIDragActor()).Value;
			case IUiGame_Union.IWuWaGoGame:
				return IWuWaGoGame.Pack(builder, _o.AsIWuWaGoGame()).Value;
			case IUiGame_Union.IWriteLetter:
				return IWriteLetter.Pack(builder, _o.AsIWriteLetter()).Value;
			case IUiGame_Union.IQteHourglass:
				return IQteHourglass.Pack(builder, _o.AsIQteHourglass()).Value;
			case IUiGame_Union.IInstrumentQteGameplay:
				return IInstrumentQteGameplay.Pack(builder, _o.AsIInstrumentQteGameplay()).Value;
			case IUiGame_Union.IPlayPianoGameplay:
				return IPlayPianoGameplay.Pack(builder, _o.AsIPlayPianoGameplay()).Value;
			case IUiGame_Union.IDartGameplay:
				return IDartGameplay.Pack(builder, _o.AsIDartGameplay()).Value;
			case IUiGame_Union.ISceneInspection:
				return ISceneInspection.Pack(builder, _o.AsISceneInspection()).Value;
			case IUiGame_Union.ITuningStand:
				return ITuningStand.Pack(builder, _o.AsITuningStand()).Value;
			case IUiGame_Union.ITraceTracing:
				return ITraceTracing.Pack(builder, _o.AsITraceTracing()).Value;
			case IUiGame_Union.ISheriffReasoning:
				return ISheriffReasoning.Pack(builder, _o.AsISheriffReasoning()).Value;
			default:
				return 0;
			}
		}
	}
}
