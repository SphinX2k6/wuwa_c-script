using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F0 RID: 30704
	public class TUiGameUnion
	{
		// Token: 0x1700E6E3 RID: 59107
		// (get) Token: 0x06037ADC RID: 228060 RVA: 0x007874C8 File Offset: 0x007856C8
		// (set) Token: 0x06037ADD RID: 228061 RVA: 0x007874D0 File Offset: 0x007856D0
		public TUiGame Type { get; set; }

		// Token: 0x1700E6E4 RID: 59108
		// (get) Token: 0x06037ADE RID: 228062 RVA: 0x007874D9 File Offset: 0x007856D9
		// (set) Token: 0x06037ADF RID: 228063 RVA: 0x007874E1 File Offset: 0x007856E1
		public object Value { get; set; }

		// Token: 0x06037AE0 RID: 228064 RVA: 0x007874EA File Offset: 0x007856EA
		public TUiGameUnion()
		{
			this.Type = TUiGame.NONE;
			this.Value = null;
		}

		// Token: 0x06037AE1 RID: 228065 RVA: 0x00787500 File Offset: 0x00785700
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037AE2 RID: 228066 RVA: 0x00787512 File Offset: 0x00785712
		public IBrokenRockT AsIBrokenRock()
		{
			return this.As<IBrokenRockT>();
		}

		// Token: 0x06037AE3 RID: 228067 RVA: 0x0078751A File Offset: 0x0078571A
		public static TUiGameUnion FromIBrokenRock(IBrokenRockT _ibrokenrock)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IBrokenRock,
				Value = _ibrokenrock
			};
		}

		// Token: 0x06037AE4 RID: 228068 RVA: 0x0078752F File Offset: 0x0078572F
		public ICipherGameplayT AsICipherGameplay()
		{
			return this.As<ICipherGameplayT>();
		}

		// Token: 0x06037AE5 RID: 228069 RVA: 0x00787537 File Offset: 0x00785737
		public static TUiGameUnion FromICipherGameplay(ICipherGameplayT _iciphergameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ICipherGameplay,
				Value = _iciphergameplay
			};
		}

		// Token: 0x06037AE6 RID: 228070 RVA: 0x0078754C File Offset: 0x0078574C
		public IDaemonHackT AsIDaemonHack()
		{
			return this.As<IDaemonHackT>();
		}

		// Token: 0x06037AE7 RID: 228071 RVA: 0x00787554 File Offset: 0x00785754
		public static TUiGameUnion FromIDaemonHack(IDaemonHackT _idaemonhack)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDaemonHack,
				Value = _idaemonhack
			};
		}

		// Token: 0x06037AE8 RID: 228072 RVA: 0x00787569 File Offset: 0x00785769
		public IDaolingAuthenticationT AsIDaolingAuthentication()
		{
			return this.As<IDaolingAuthenticationT>();
		}

		// Token: 0x06037AE9 RID: 228073 RVA: 0x00787571 File Offset: 0x00785771
		public static TUiGameUnion FromIDaolingAuthentication(IDaolingAuthenticationT _idaolingauthentication)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDaolingAuthentication,
				Value = _idaolingauthentication
			};
		}

		// Token: 0x06037AEA RID: 228074 RVA: 0x00787586 File Offset: 0x00785786
		public IDartGameplayT AsIDartGameplay()
		{
			return this.As<IDartGameplayT>();
		}

		// Token: 0x06037AEB RID: 228075 RVA: 0x0078758E File Offset: 0x0078578E
		public static TUiGameUnion FromIDartGameplay(IDartGameplayT _idartgameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDartGameplay,
				Value = _idartgameplay
			};
		}

		// Token: 0x06037AEC RID: 228076 RVA: 0x007875A3 File Offset: 0x007857A3
		public IDollGrabT AsIDollGrab()
		{
			return this.As<IDollGrabT>();
		}

		// Token: 0x06037AED RID: 228077 RVA: 0x007875AB File Offset: 0x007857AB
		public static TUiGameUnion FromIDollGrab(IDollGrabT _idollgrab)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDollGrab,
				Value = _idollgrab
			};
		}

		// Token: 0x06037AEE RID: 228078 RVA: 0x007875C0 File Offset: 0x007857C0
		public IDollGrabShowcaseT AsIDollGrabShowcase()
		{
			return this.As<IDollGrabShowcaseT>();
		}

		// Token: 0x06037AEF RID: 228079 RVA: 0x007875C8 File Offset: 0x007857C8
		public static TUiGameUnion FromIDollGrabShowcase(IDollGrabShowcaseT _idollgrabshowcase)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDollGrabShowcase,
				Value = _idollgrabshowcase
			};
		}

		// Token: 0x06037AF0 RID: 228080 RVA: 0x007875DD File Offset: 0x007857DD
		public IDragActorT AsIDragActor()
		{
			return this.As<IDragActorT>();
		}

		// Token: 0x06037AF1 RID: 228081 RVA: 0x007875E5 File Offset: 0x007857E5
		public static TUiGameUnion FromIDragActor(IDragActorT _idragactor)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IDragActor,
				Value = _idragactor
			};
		}

		// Token: 0x06037AF2 RID: 228082 RVA: 0x007875FA File Offset: 0x007857FA
		public IFindSunSpiritT AsIFindSunSpirit()
		{
			return this.As<IFindSunSpiritT>();
		}

		// Token: 0x06037AF3 RID: 228083 RVA: 0x00787602 File Offset: 0x00785802
		public static TUiGameUnion FromIFindSunSpirit(IFindSunSpiritT _ifindsunspirit)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFindSunSpirit,
				Value = _ifindsunspirit
			};
		}

		// Token: 0x06037AF4 RID: 228084 RVA: 0x00787618 File Offset: 0x00785818
		public IFishingRouletteT AsIFishingRoulette()
		{
			return this.As<IFishingRouletteT>();
		}

		// Token: 0x06037AF5 RID: 228085 RVA: 0x00787620 File Offset: 0x00785820
		public static TUiGameUnion FromIFishingRoulette(IFishingRouletteT _ifishingroulette)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFishingRoulette,
				Value = _ifishingroulette
			};
		}

		// Token: 0x06037AF6 RID: 228086 RVA: 0x00787636 File Offset: 0x00785836
		public IFlowerSeaEscapeT AsIFlowerSeaEscape()
		{
			return this.As<IFlowerSeaEscapeT>();
		}

		// Token: 0x06037AF7 RID: 228087 RVA: 0x0078763E File Offset: 0x0078583E
		public static TUiGameUnion FromIFlowerSeaEscape(IFlowerSeaEscapeT _iflowerseaescape)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IFlowerSeaEscape,
				Value = _iflowerseaescape
			};
		}

		// Token: 0x06037AF8 RID: 228088 RVA: 0x00787654 File Offset: 0x00785854
		public IInstrumentQteGameplayT AsIInstrumentQteGameplay()
		{
			return this.As<IInstrumentQteGameplayT>();
		}

		// Token: 0x06037AF9 RID: 228089 RVA: 0x0078765C File Offset: 0x0078585C
		public static TUiGameUnion FromIInstrumentQteGameplay(IInstrumentQteGameplayT _iinstrumentqtegameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IInstrumentQteGameplay,
				Value = _iinstrumentqtegameplay
			};
		}

		// Token: 0x06037AFA RID: 228090 RVA: 0x00787672 File Offset: 0x00785872
		public IItemInspectionT AsIItemInspection()
		{
			return this.As<IItemInspectionT>();
		}

		// Token: 0x06037AFB RID: 228091 RVA: 0x0078767A File Offset: 0x0078587A
		public static TUiGameUnion FromIItemInspection(IItemInspectionT _iiteminspection)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IItemInspection,
				Value = _iiteminspection
			};
		}

		// Token: 0x06037AFC RID: 228092 RVA: 0x00787690 File Offset: 0x00785890
		public ILifePointT AsILifePoint()
		{
			return this.As<ILifePointT>();
		}

		// Token: 0x06037AFD RID: 228093 RVA: 0x00787698 File Offset: 0x00785898
		public static TUiGameUnion FromILifePoint(ILifePointT _ilifepoint)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ILifePoint,
				Value = _ilifepoint
			};
		}

		// Token: 0x06037AFE RID: 228094 RVA: 0x007876AE File Offset: 0x007858AE
		public IMorseCodeT AsIMorseCode()
		{
			return this.As<IMorseCodeT>();
		}

		// Token: 0x06037AFF RID: 228095 RVA: 0x007876B6 File Offset: 0x007858B6
		public static TUiGameUnion FromIMorseCode(IMorseCodeT _imorsecode)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IMorseCode,
				Value = _imorsecode
			};
		}

		// Token: 0x06037B00 RID: 228096 RVA: 0x007876CC File Offset: 0x007858CC
		public IPlayPianoGameplayT AsIPlayPianoGameplay()
		{
			return this.As<IPlayPianoGameplayT>();
		}

		// Token: 0x06037B01 RID: 228097 RVA: 0x007876D4 File Offset: 0x007858D4
		public static TUiGameUnion FromIPlayPianoGameplay(IPlayPianoGameplayT _iplaypianogameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IPlayPianoGameplay,
				Value = _iplaypianogameplay
			};
		}

		// Token: 0x06037B02 RID: 228098 RVA: 0x007876EA File Offset: 0x007858EA
		public IProjectionMachineT AsIProjectionMachine()
		{
			return this.As<IProjectionMachineT>();
		}

		// Token: 0x06037B03 RID: 228099 RVA: 0x007876F2 File Offset: 0x007858F2
		public static TUiGameUnion FromIProjectionMachine(IProjectionMachineT _iprojectionmachine)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IProjectionMachine,
				Value = _iprojectionmachine
			};
		}

		// Token: 0x06037B04 RID: 228100 RVA: 0x00787708 File Offset: 0x00785908
		public IProjectorPuzzleT AsIProjectorPuzzle()
		{
			return this.As<IProjectorPuzzleT>();
		}

		// Token: 0x06037B05 RID: 228101 RVA: 0x00787710 File Offset: 0x00785910
		public static TUiGameUnion FromIProjectorPuzzle(IProjectorPuzzleT _iprojectorpuzzle)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IProjectorPuzzle,
				Value = _iprojectorpuzzle
			};
		}

		// Token: 0x06037B06 RID: 228102 RVA: 0x00787726 File Offset: 0x00785926
		public IQteHourglassT AsIQteHourglass()
		{
			return this.As<IQteHourglassT>();
		}

		// Token: 0x06037B07 RID: 228103 RVA: 0x0078772E File Offset: 0x0078592E
		public static TUiGameUnion FromIQteHourglass(IQteHourglassT _iqtehourglass)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IQteHourglass,
				Value = _iqtehourglass
			};
		}

		// Token: 0x06037B08 RID: 228104 RVA: 0x00787744 File Offset: 0x00785944
		public IReignsT AsIReigns()
		{
			return this.As<IReignsT>();
		}

		// Token: 0x06037B09 RID: 228105 RVA: 0x0078774C File Offset: 0x0078594C
		public static TUiGameUnion FromIReigns(IReignsT _ireigns)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IReigns,
				Value = _ireigns
			};
		}

		// Token: 0x06037B0A RID: 228106 RVA: 0x00787762 File Offset: 0x00785962
		public IRenjuChessT AsIRenjuChess()
		{
			return this.As<IRenjuChessT>();
		}

		// Token: 0x06037B0B RID: 228107 RVA: 0x0078776A File Offset: 0x0078596A
		public static TUiGameUnion FromIRenjuChess(IRenjuChessT _irenjuchess)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IRenjuChess,
				Value = _irenjuchess
			};
		}

		// Token: 0x06037B0C RID: 228108 RVA: 0x00787780 File Offset: 0x00785980
		public IRideFlyingCarT AsIRideFlyingCar()
		{
			return this.As<IRideFlyingCarT>();
		}

		// Token: 0x06037B0D RID: 228109 RVA: 0x00787788 File Offset: 0x00785988
		public static TUiGameUnion FromIRideFlyingCar(IRideFlyingCarT _irideflyingcar)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IRideFlyingCar,
				Value = _irideflyingcar
			};
		}

		// Token: 0x06037B0E RID: 228110 RVA: 0x0078779E File Offset: 0x0078599E
		public ISceneInspectionT AsISceneInspection()
		{
			return this.As<ISceneInspectionT>();
		}

		// Token: 0x06037B0F RID: 228111 RVA: 0x007877A6 File Offset: 0x007859A6
		public static TUiGameUnion FromISceneInspection(ISceneInspectionT _isceneinspection)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISceneInspection,
				Value = _isceneinspection
			};
		}

		// Token: 0x06037B10 RID: 228112 RVA: 0x007877BC File Offset: 0x007859BC
		public ISheriffReasoningT AsISheriffReasoning()
		{
			return this.As<ISheriffReasoningT>();
		}

		// Token: 0x06037B11 RID: 228113 RVA: 0x007877C4 File Offset: 0x007859C4
		public static TUiGameUnion FromISheriffReasoning(ISheriffReasoningT _isheriffreasoning)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISheriffReasoning,
				Value = _isheriffreasoning
			};
		}

		// Token: 0x06037B12 RID: 228114 RVA: 0x007877DA File Offset: 0x007859DA
		public ISignalBreakGameplayT AsISignalBreakGameplay()
		{
			return this.As<ISignalBreakGameplayT>();
		}

		// Token: 0x06037B13 RID: 228115 RVA: 0x007877E2 File Offset: 0x007859E2
		public static TUiGameUnion FromISignalBreakGameplay(ISignalBreakGameplayT _isignalbreakgameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalBreakGameplay,
				Value = _isignalbreakgameplay
			};
		}

		// Token: 0x06037B14 RID: 228116 RVA: 0x007877F8 File Offset: 0x007859F8
		public ISignalDeviceT AsISignalDevice()
		{
			return this.As<ISignalDeviceT>();
		}

		// Token: 0x06037B15 RID: 228117 RVA: 0x00787800 File Offset: 0x00785A00
		public static TUiGameUnion FromISignalDevice(ISignalDeviceT _isignaldevice)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalDevice,
				Value = _isignaldevice
			};
		}

		// Token: 0x06037B16 RID: 228118 RVA: 0x00787816 File Offset: 0x00785A16
		public ISignalDevice2T AsISignalDevice2()
		{
			return this.As<ISignalDevice2T>();
		}

		// Token: 0x06037B17 RID: 228119 RVA: 0x0078781E File Offset: 0x00785A1E
		public static TUiGameUnion FromISignalDevice2(ISignalDevice2T _isignaldevice2)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISignalDevice2,
				Value = _isignaldevice2
			};
		}

		// Token: 0x06037B18 RID: 228120 RVA: 0x00787834 File Offset: 0x00785A34
		public ISundialPuzzleGameplayT AsISundialPuzzleGameplay()
		{
			return this.As<ISundialPuzzleGameplayT>();
		}

		// Token: 0x06037B19 RID: 228121 RVA: 0x0078783C File Offset: 0x00785A3C
		public static TUiGameUnion FromISundialPuzzleGameplay(ISundialPuzzleGameplayT _isundialpuzzlegameplay)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ISundialPuzzleGameplay,
				Value = _isundialpuzzlegameplay
			};
		}

		// Token: 0x06037B1A RID: 228122 RVA: 0x00787852 File Offset: 0x00785A52
		public ITraceTracingT AsITraceTracing()
		{
			return this.As<ITraceTracingT>();
		}

		// Token: 0x06037B1B RID: 228123 RVA: 0x0078785A File Offset: 0x00785A5A
		public static TUiGameUnion FromITraceTracing(ITraceTracingT _itracetracing)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ITraceTracing,
				Value = _itracetracing
			};
		}

		// Token: 0x06037B1C RID: 228124 RVA: 0x00787870 File Offset: 0x00785A70
		public ITuningStandT AsITuningStand()
		{
			return this.As<ITuningStandT>();
		}

		// Token: 0x06037B1D RID: 228125 RVA: 0x00787878 File Offset: 0x00785A78
		public static TUiGameUnion FromITuningStand(ITuningStandT _ituningstand)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.ITuningStand,
				Value = _ituningstand
			};
		}

		// Token: 0x06037B1E RID: 228126 RVA: 0x0078788E File Offset: 0x00785A8E
		public IWriteLetterT AsIWriteLetter()
		{
			return this.As<IWriteLetterT>();
		}

		// Token: 0x06037B1F RID: 228127 RVA: 0x00787896 File Offset: 0x00785A96
		public static TUiGameUnion FromIWriteLetter(IWriteLetterT _iwriteletter)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IWriteLetter,
				Value = _iwriteletter
			};
		}

		// Token: 0x06037B20 RID: 228128 RVA: 0x007878AC File Offset: 0x00785AAC
		public IWuWaGoGameT AsIWuWaGoGame()
		{
			return this.As<IWuWaGoGameT>();
		}

		// Token: 0x06037B21 RID: 228129 RVA: 0x007878B4 File Offset: 0x00785AB4
		public static TUiGameUnion FromIWuWaGoGame(IWuWaGoGameT _iwuwagogame)
		{
			return new TUiGameUnion
			{
				Type = TUiGame.IWuWaGoGame,
				Value = _iwuwagogame
			};
		}

		// Token: 0x06037B22 RID: 228130 RVA: 0x007878CC File Offset: 0x00785ACC
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
