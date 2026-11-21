using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C99 RID: 31897
	public class IUiGame_UnionUnion
	{
		// Token: 0x1700EED5 RID: 61141
		// (get) Token: 0x06039865 RID: 235621 RVA: 0x007C39E1 File Offset: 0x007C1BE1
		// (set) Token: 0x06039866 RID: 235622 RVA: 0x007C39E9 File Offset: 0x007C1BE9
		public IUiGame_Union Type { get; set; }

		// Token: 0x1700EED6 RID: 61142
		// (get) Token: 0x06039867 RID: 235623 RVA: 0x007C39F2 File Offset: 0x007C1BF2
		// (set) Token: 0x06039868 RID: 235624 RVA: 0x007C39FA File Offset: 0x007C1BFA
		public object Value { get; set; }

		// Token: 0x06039869 RID: 235625 RVA: 0x007C3A03 File Offset: 0x007C1C03
		public IUiGame_UnionUnion()
		{
			this.Type = IUiGame_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603986A RID: 235626 RVA: 0x007C3A19 File Offset: 0x007C1C19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603986B RID: 235627 RVA: 0x007C3A2B File Offset: 0x007C1C2B
		public IUiGameT AsIUiGame()
		{
			return this.As<IUiGameT>();
		}

		// Token: 0x0603986C RID: 235628 RVA: 0x007C3A33 File Offset: 0x007C1C33
		public static IUiGame_UnionUnion FromIUiGame(IUiGameT _iuigame)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IUiGame,
				Value = _iuigame
			};
		}

		// Token: 0x0603986D RID: 235629 RVA: 0x007C3A48 File Offset: 0x007C1C48
		public IReignsT AsIReigns()
		{
			return this.As<IReignsT>();
		}

		// Token: 0x0603986E RID: 235630 RVA: 0x007C3A50 File Offset: 0x007C1C50
		public static IUiGame_UnionUnion FromIReigns(IReignsT _ireigns)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IReigns,
				Value = _ireigns
			};
		}

		// Token: 0x0603986F RID: 235631 RVA: 0x007C3A65 File Offset: 0x007C1C65
		public IFindSunSpiritT AsIFindSunSpirit()
		{
			return this.As<IFindSunSpiritT>();
		}

		// Token: 0x06039870 RID: 235632 RVA: 0x007C3A6D File Offset: 0x007C1C6D
		public static IUiGame_UnionUnion FromIFindSunSpirit(IFindSunSpiritT _ifindsunspirit)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFindSunSpirit,
				Value = _ifindsunspirit
			};
		}

		// Token: 0x06039871 RID: 235633 RVA: 0x007C3A82 File Offset: 0x007C1C82
		public IDollGrabT AsIDollGrab()
		{
			return this.As<IDollGrabT>();
		}

		// Token: 0x06039872 RID: 235634 RVA: 0x007C3A8A File Offset: 0x007C1C8A
		public static IUiGame_UnionUnion FromIDollGrab(IDollGrabT _idollgrab)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDollGrab,
				Value = _idollgrab
			};
		}

		// Token: 0x06039873 RID: 235635 RVA: 0x007C3A9F File Offset: 0x007C1C9F
		public IDollGrabShowcaseT AsIDollGrabShowcase()
		{
			return this.As<IDollGrabShowcaseT>();
		}

		// Token: 0x06039874 RID: 235636 RVA: 0x007C3AA7 File Offset: 0x007C1CA7
		public static IUiGame_UnionUnion FromIDollGrabShowcase(IDollGrabShowcaseT _idollgrabshowcase)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDollGrabShowcase,
				Value = _idollgrabshowcase
			};
		}

		// Token: 0x06039875 RID: 235637 RVA: 0x007C3ABC File Offset: 0x007C1CBC
		public IDaemonHackT AsIDaemonHack()
		{
			return this.As<IDaemonHackT>();
		}

		// Token: 0x06039876 RID: 235638 RVA: 0x007C3AC4 File Offset: 0x007C1CC4
		public static IUiGame_UnionUnion FromIDaemonHack(IDaemonHackT _idaemonhack)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDaemonHack,
				Value = _idaemonhack
			};
		}

		// Token: 0x06039877 RID: 235639 RVA: 0x007C3AD9 File Offset: 0x007C1CD9
		public IProjectionMachineT AsIProjectionMachine()
		{
			return this.As<IProjectionMachineT>();
		}

		// Token: 0x06039878 RID: 235640 RVA: 0x007C3AE1 File Offset: 0x007C1CE1
		public static IUiGame_UnionUnion FromIProjectionMachine(IProjectionMachineT _iprojectionmachine)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IProjectionMachine,
				Value = _iprojectionmachine
			};
		}

		// Token: 0x06039879 RID: 235641 RVA: 0x007C3AF6 File Offset: 0x007C1CF6
		public IItemInspectionT AsIItemInspection()
		{
			return this.As<IItemInspectionT>();
		}

		// Token: 0x0603987A RID: 235642 RVA: 0x007C3AFE File Offset: 0x007C1CFE
		public static IUiGame_UnionUnion FromIItemInspection(IItemInspectionT _iiteminspection)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IItemInspection,
				Value = _iiteminspection
			};
		}

		// Token: 0x0603987B RID: 235643 RVA: 0x007C3B13 File Offset: 0x007C1D13
		public ICipherGameplayT AsICipherGameplay()
		{
			return this.As<ICipherGameplayT>();
		}

		// Token: 0x0603987C RID: 235644 RVA: 0x007C3B1B File Offset: 0x007C1D1B
		public static IUiGame_UnionUnion FromICipherGameplay(ICipherGameplayT _iciphergameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ICipherGameplay,
				Value = _iciphergameplay
			};
		}

		// Token: 0x0603987D RID: 235645 RVA: 0x007C3B31 File Offset: 0x007C1D31
		public ISignalBreakGameplayT AsISignalBreakGameplay()
		{
			return this.As<ISignalBreakGameplayT>();
		}

		// Token: 0x0603987E RID: 235646 RVA: 0x007C3B39 File Offset: 0x007C1D39
		public static IUiGame_UnionUnion FromISignalBreakGameplay(ISignalBreakGameplayT _isignalbreakgameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalBreakGameplay,
				Value = _isignalbreakgameplay
			};
		}

		// Token: 0x0603987F RID: 235647 RVA: 0x007C3B4F File Offset: 0x007C1D4F
		public ISundialPuzzleGameplayT AsISundialPuzzleGameplay()
		{
			return this.As<ISundialPuzzleGameplayT>();
		}

		// Token: 0x06039880 RID: 235648 RVA: 0x007C3B57 File Offset: 0x007C1D57
		public static IUiGame_UnionUnion FromISundialPuzzleGameplay(ISundialPuzzleGameplayT _isundialpuzzlegameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISundialPuzzleGameplay,
				Value = _isundialpuzzlegameplay
			};
		}

		// Token: 0x06039881 RID: 235649 RVA: 0x007C3B6D File Offset: 0x007C1D6D
		public ISignalDeviceT AsISignalDevice()
		{
			return this.As<ISignalDeviceT>();
		}

		// Token: 0x06039882 RID: 235650 RVA: 0x007C3B75 File Offset: 0x007C1D75
		public static IUiGame_UnionUnion FromISignalDevice(ISignalDeviceT _isignaldevice)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalDevice,
				Value = _isignaldevice
			};
		}

		// Token: 0x06039883 RID: 235651 RVA: 0x007C3B8B File Offset: 0x007C1D8B
		public ISignalDevice2T AsISignalDevice2()
		{
			return this.As<ISignalDevice2T>();
		}

		// Token: 0x06039884 RID: 235652 RVA: 0x007C3B93 File Offset: 0x007C1D93
		public static IUiGame_UnionUnion FromISignalDevice2(ISignalDevice2T _isignaldevice2)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISignalDevice2,
				Value = _isignaldevice2
			};
		}

		// Token: 0x06039885 RID: 235653 RVA: 0x007C3BA9 File Offset: 0x007C1DA9
		public IMorseCodeT AsIMorseCode()
		{
			return this.As<IMorseCodeT>();
		}

		// Token: 0x06039886 RID: 235654 RVA: 0x007C3BB1 File Offset: 0x007C1DB1
		public static IUiGame_UnionUnion FromIMorseCode(IMorseCodeT _imorsecode)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IMorseCode,
				Value = _imorsecode
			};
		}

		// Token: 0x06039887 RID: 235655 RVA: 0x007C3BC7 File Offset: 0x007C1DC7
		public IRenjuChessT AsIRenjuChess()
		{
			return this.As<IRenjuChessT>();
		}

		// Token: 0x06039888 RID: 235656 RVA: 0x007C3BCF File Offset: 0x007C1DCF
		public static IUiGame_UnionUnion FromIRenjuChess(IRenjuChessT _irenjuchess)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IRenjuChess,
				Value = _irenjuchess
			};
		}

		// Token: 0x06039889 RID: 235657 RVA: 0x007C3BE5 File Offset: 0x007C1DE5
		public IProjectorPuzzleT AsIProjectorPuzzle()
		{
			return this.As<IProjectorPuzzleT>();
		}

		// Token: 0x0603988A RID: 235658 RVA: 0x007C3BED File Offset: 0x007C1DED
		public static IUiGame_UnionUnion FromIProjectorPuzzle(IProjectorPuzzleT _iprojectorpuzzle)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IProjectorPuzzle,
				Value = _iprojectorpuzzle
			};
		}

		// Token: 0x0603988B RID: 235659 RVA: 0x007C3C03 File Offset: 0x007C1E03
		public ILifePointT AsILifePoint()
		{
			return this.As<ILifePointT>();
		}

		// Token: 0x0603988C RID: 235660 RVA: 0x007C3C0B File Offset: 0x007C1E0B
		public static IUiGame_UnionUnion FromILifePoint(ILifePointT _ilifepoint)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ILifePoint,
				Value = _ilifepoint
			};
		}

		// Token: 0x0603988D RID: 235661 RVA: 0x007C3C21 File Offset: 0x007C1E21
		public IBrokenRockT AsIBrokenRock()
		{
			return this.As<IBrokenRockT>();
		}

		// Token: 0x0603988E RID: 235662 RVA: 0x007C3C29 File Offset: 0x007C1E29
		public static IUiGame_UnionUnion FromIBrokenRock(IBrokenRockT _ibrokenrock)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IBrokenRock,
				Value = _ibrokenrock
			};
		}

		// Token: 0x0603988F RID: 235663 RVA: 0x007C3C3F File Offset: 0x007C1E3F
		public IFlowerSeaEscapeT AsIFlowerSeaEscape()
		{
			return this.As<IFlowerSeaEscapeT>();
		}

		// Token: 0x06039890 RID: 235664 RVA: 0x007C3C47 File Offset: 0x007C1E47
		public static IUiGame_UnionUnion FromIFlowerSeaEscape(IFlowerSeaEscapeT _iflowerseaescape)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFlowerSeaEscape,
				Value = _iflowerseaescape
			};
		}

		// Token: 0x06039891 RID: 235665 RVA: 0x007C3C5D File Offset: 0x007C1E5D
		public IRideFlyingCarT AsIRideFlyingCar()
		{
			return this.As<IRideFlyingCarT>();
		}

		// Token: 0x06039892 RID: 235666 RVA: 0x007C3C65 File Offset: 0x007C1E65
		public static IUiGame_UnionUnion FromIRideFlyingCar(IRideFlyingCarT _irideflyingcar)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IRideFlyingCar,
				Value = _irideflyingcar
			};
		}

		// Token: 0x06039893 RID: 235667 RVA: 0x007C3C7B File Offset: 0x007C1E7B
		public IFrequencyPaintT AsIFrequencyPaint()
		{
			return this.As<IFrequencyPaintT>();
		}

		// Token: 0x06039894 RID: 235668 RVA: 0x007C3C83 File Offset: 0x007C1E83
		public static IUiGame_UnionUnion FromIFrequencyPaint(IFrequencyPaintT _ifrequencypaint)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFrequencyPaint,
				Value = _ifrequencypaint
			};
		}

		// Token: 0x06039895 RID: 235669 RVA: 0x007C3C99 File Offset: 0x007C1E99
		public IFrequencyDetectT AsIFrequencyDetect()
		{
			return this.As<IFrequencyDetectT>();
		}

		// Token: 0x06039896 RID: 235670 RVA: 0x007C3CA1 File Offset: 0x007C1EA1
		public static IUiGame_UnionUnion FromIFrequencyDetect(IFrequencyDetectT _ifrequencydetect)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFrequencyDetect,
				Value = _ifrequencydetect
			};
		}

		// Token: 0x06039897 RID: 235671 RVA: 0x007C3CB7 File Offset: 0x007C1EB7
		public ITurntableConnectorUiGameplayT AsITurntableConnectorUiGameplay()
		{
			return this.As<ITurntableConnectorUiGameplayT>();
		}

		// Token: 0x06039898 RID: 235672 RVA: 0x007C3CBF File Offset: 0x007C1EBF
		public static IUiGame_UnionUnion FromITurntableConnectorUiGameplay(ITurntableConnectorUiGameplayT _iturntableconnectoruigameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ITurntableConnectorUiGameplay,
				Value = _iturntableconnectoruigameplay
			};
		}

		// Token: 0x06039899 RID: 235673 RVA: 0x007C3CD5 File Offset: 0x007C1ED5
		public IFishingRouletteT AsIFishingRoulette()
		{
			return this.As<IFishingRouletteT>();
		}

		// Token: 0x0603989A RID: 235674 RVA: 0x007C3CDD File Offset: 0x007C1EDD
		public static IUiGame_UnionUnion FromIFishingRoulette(IFishingRouletteT _ifishingroulette)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IFishingRoulette,
				Value = _ifishingroulette
			};
		}

		// Token: 0x0603989B RID: 235675 RVA: 0x007C3CF3 File Offset: 0x007C1EF3
		public IDaolingAuthenticationT AsIDaolingAuthentication()
		{
			return this.As<IDaolingAuthenticationT>();
		}

		// Token: 0x0603989C RID: 235676 RVA: 0x007C3CFB File Offset: 0x007C1EFB
		public static IUiGame_UnionUnion FromIDaolingAuthentication(IDaolingAuthenticationT _idaolingauthentication)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDaolingAuthentication,
				Value = _idaolingauthentication
			};
		}

		// Token: 0x0603989D RID: 235677 RVA: 0x007C3D11 File Offset: 0x007C1F11
		public IDragActorT AsIDragActor()
		{
			return this.As<IDragActorT>();
		}

		// Token: 0x0603989E RID: 235678 RVA: 0x007C3D19 File Offset: 0x007C1F19
		public static IUiGame_UnionUnion FromIDragActor(IDragActorT _idragactor)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDragActor,
				Value = _idragactor
			};
		}

		// Token: 0x0603989F RID: 235679 RVA: 0x007C3D2F File Offset: 0x007C1F2F
		public IWuWaGoGameT AsIWuWaGoGame()
		{
			return this.As<IWuWaGoGameT>();
		}

		// Token: 0x060398A0 RID: 235680 RVA: 0x007C3D37 File Offset: 0x007C1F37
		public static IUiGame_UnionUnion FromIWuWaGoGame(IWuWaGoGameT _iwuwagogame)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IWuWaGoGame,
				Value = _iwuwagogame
			};
		}

		// Token: 0x060398A1 RID: 235681 RVA: 0x007C3D4D File Offset: 0x007C1F4D
		public IWriteLetterT AsIWriteLetter()
		{
			return this.As<IWriteLetterT>();
		}

		// Token: 0x060398A2 RID: 235682 RVA: 0x007C3D55 File Offset: 0x007C1F55
		public static IUiGame_UnionUnion FromIWriteLetter(IWriteLetterT _iwriteletter)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IWriteLetter,
				Value = _iwriteletter
			};
		}

		// Token: 0x060398A3 RID: 235683 RVA: 0x007C3D6B File Offset: 0x007C1F6B
		public IQteHourglassT AsIQteHourglass()
		{
			return this.As<IQteHourglassT>();
		}

		// Token: 0x060398A4 RID: 235684 RVA: 0x007C3D73 File Offset: 0x007C1F73
		public static IUiGame_UnionUnion FromIQteHourglass(IQteHourglassT _iqtehourglass)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IQteHourglass,
				Value = _iqtehourglass
			};
		}

		// Token: 0x060398A5 RID: 235685 RVA: 0x007C3D89 File Offset: 0x007C1F89
		public IInstrumentQteGameplayT AsIInstrumentQteGameplay()
		{
			return this.As<IInstrumentQteGameplayT>();
		}

		// Token: 0x060398A6 RID: 235686 RVA: 0x007C3D91 File Offset: 0x007C1F91
		public static IUiGame_UnionUnion FromIInstrumentQteGameplay(IInstrumentQteGameplayT _iinstrumentqtegameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IInstrumentQteGameplay,
				Value = _iinstrumentqtegameplay
			};
		}

		// Token: 0x060398A7 RID: 235687 RVA: 0x007C3DA7 File Offset: 0x007C1FA7
		public IPlayPianoGameplayT AsIPlayPianoGameplay()
		{
			return this.As<IPlayPianoGameplayT>();
		}

		// Token: 0x060398A8 RID: 235688 RVA: 0x007C3DAF File Offset: 0x007C1FAF
		public static IUiGame_UnionUnion FromIPlayPianoGameplay(IPlayPianoGameplayT _iplaypianogameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IPlayPianoGameplay,
				Value = _iplaypianogameplay
			};
		}

		// Token: 0x060398A9 RID: 235689 RVA: 0x007C3DC5 File Offset: 0x007C1FC5
		public IDartGameplayT AsIDartGameplay()
		{
			return this.As<IDartGameplayT>();
		}

		// Token: 0x060398AA RID: 235690 RVA: 0x007C3DCD File Offset: 0x007C1FCD
		public static IUiGame_UnionUnion FromIDartGameplay(IDartGameplayT _idartgameplay)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.IDartGameplay,
				Value = _idartgameplay
			};
		}

		// Token: 0x060398AB RID: 235691 RVA: 0x007C3DE3 File Offset: 0x007C1FE3
		public ISceneInspectionT AsISceneInspection()
		{
			return this.As<ISceneInspectionT>();
		}

		// Token: 0x060398AC RID: 235692 RVA: 0x007C3DEB File Offset: 0x007C1FEB
		public static IUiGame_UnionUnion FromISceneInspection(ISceneInspectionT _isceneinspection)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISceneInspection,
				Value = _isceneinspection
			};
		}

		// Token: 0x060398AD RID: 235693 RVA: 0x007C3E01 File Offset: 0x007C2001
		public ITuningStandT AsITuningStand()
		{
			return this.As<ITuningStandT>();
		}

		// Token: 0x060398AE RID: 235694 RVA: 0x007C3E09 File Offset: 0x007C2009
		public static IUiGame_UnionUnion FromITuningStand(ITuningStandT _ituningstand)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ITuningStand,
				Value = _ituningstand
			};
		}

		// Token: 0x060398AF RID: 235695 RVA: 0x007C3E1F File Offset: 0x007C201F
		public ITraceTracingT AsITraceTracing()
		{
			return this.As<ITraceTracingT>();
		}

		// Token: 0x060398B0 RID: 235696 RVA: 0x007C3E27 File Offset: 0x007C2027
		public static IUiGame_UnionUnion FromITraceTracing(ITraceTracingT _itracetracing)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ITraceTracing,
				Value = _itracetracing
			};
		}

		// Token: 0x060398B1 RID: 235697 RVA: 0x007C3E3D File Offset: 0x007C203D
		public ISheriffReasoningT AsISheriffReasoning()
		{
			return this.As<ISheriffReasoningT>();
		}

		// Token: 0x060398B2 RID: 235698 RVA: 0x007C3E45 File Offset: 0x007C2045
		public static IUiGame_UnionUnion FromISheriffReasoning(ISheriffReasoningT _isheriffreasoning)
		{
			return new IUiGame_UnionUnion
			{
				Type = IUiGame_Union.ISheriffReasoning,
				Value = _isheriffreasoning
			};
		}

		// Token: 0x060398B3 RID: 235699 RVA: 0x007C3E5C File Offset: 0x007C205C
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
			case IUiGame_Union.IFrequencyPaint:
				return IFrequencyPaint.Pack(builder, _o.AsIFrequencyPaint()).Value;
			case IUiGame_Union.IFrequencyDetect:
				return IFrequencyDetect.Pack(builder, _o.AsIFrequencyDetect()).Value;
			case IUiGame_Union.ITurntableConnectorUiGameplay:
				return ITurntableConnectorUiGameplay.Pack(builder, _o.AsITurntableConnectorUiGameplay()).Value;
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
