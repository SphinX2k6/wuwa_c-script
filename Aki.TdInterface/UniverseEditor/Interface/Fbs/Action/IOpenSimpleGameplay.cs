using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2A RID: 27690
	public struct IOpenSimpleGameplay : IFlatbufferObject
	{
		// Token: 0x1700CDF5 RID: 52725
		// (get) Token: 0x06030B3F RID: 199487 RVA: 0x0069C7A5 File Offset: 0x0069A9A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B40 RID: 199488 RVA: 0x0069C7B2 File Offset: 0x0069A9B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B41 RID: 199489 RVA: 0x0069C7BC File Offset: 0x0069A9BC
		public static IOpenSimpleGameplay GetRootAsIOpenSimpleGameplay(ByteBuffer _bb)
		{
			return IOpenSimpleGameplay.GetRootAsIOpenSimpleGameplay(_bb, default(IOpenSimpleGameplay));
		}

		// Token: 0x06030B42 RID: 199490 RVA: 0x0069C7D8 File Offset: 0x0069A9D8
		public static IOpenSimpleGameplay GetRootAsIOpenSimpleGameplay(ByteBuffer _bb, IOpenSimpleGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B43 RID: 199491 RVA: 0x0069C7F5 File Offset: 0x0069A9F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B44 RID: 199492 RVA: 0x0069C804 File Offset: 0x0069AA04
		public IOpenSimpleGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDF6 RID: 52726
		// (get) Token: 0x06030B45 RID: 199493 RVA: 0x0069C814 File Offset: 0x0069AA14
		public TUiGame GameplayConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TUiGame.NONE;
				}
				return (TUiGame)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030B46 RID: 199494 RVA: 0x0069C850 File Offset: 0x0069AA50
		public TTable? GameplayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030B47 RID: 199495 RVA: 0x0069C894 File Offset: 0x0069AA94
		public IBrokenRock GameplayConfigAsIBrokenRock()
		{
			return this.GameplayConfig<IBrokenRock>().Value;
		}

		// Token: 0x06030B48 RID: 199496 RVA: 0x0069C8B0 File Offset: 0x0069AAB0
		public ICipherGameplay GameplayConfigAsICipherGameplay()
		{
			return this.GameplayConfig<ICipherGameplay>().Value;
		}

		// Token: 0x06030B49 RID: 199497 RVA: 0x0069C8CC File Offset: 0x0069AACC
		public IDaemonHack GameplayConfigAsIDaemonHack()
		{
			return this.GameplayConfig<IDaemonHack>().Value;
		}

		// Token: 0x06030B4A RID: 199498 RVA: 0x0069C8E8 File Offset: 0x0069AAE8
		public IDaolingAuthentication GameplayConfigAsIDaolingAuthentication()
		{
			return this.GameplayConfig<IDaolingAuthentication>().Value;
		}

		// Token: 0x06030B4B RID: 199499 RVA: 0x0069C904 File Offset: 0x0069AB04
		public IDartGameplay GameplayConfigAsIDartGameplay()
		{
			return this.GameplayConfig<IDartGameplay>().Value;
		}

		// Token: 0x06030B4C RID: 199500 RVA: 0x0069C920 File Offset: 0x0069AB20
		public IDollGrab GameplayConfigAsIDollGrab()
		{
			return this.GameplayConfig<IDollGrab>().Value;
		}

		// Token: 0x06030B4D RID: 199501 RVA: 0x0069C93C File Offset: 0x0069AB3C
		public IDollGrabShowcase GameplayConfigAsIDollGrabShowcase()
		{
			return this.GameplayConfig<IDollGrabShowcase>().Value;
		}

		// Token: 0x06030B4E RID: 199502 RVA: 0x0069C958 File Offset: 0x0069AB58
		public IDragActor GameplayConfigAsIDragActor()
		{
			return this.GameplayConfig<IDragActor>().Value;
		}

		// Token: 0x06030B4F RID: 199503 RVA: 0x0069C974 File Offset: 0x0069AB74
		public IFindSunSpirit GameplayConfigAsIFindSunSpirit()
		{
			return this.GameplayConfig<IFindSunSpirit>().Value;
		}

		// Token: 0x06030B50 RID: 199504 RVA: 0x0069C990 File Offset: 0x0069AB90
		public IFishingRoulette GameplayConfigAsIFishingRoulette()
		{
			return this.GameplayConfig<IFishingRoulette>().Value;
		}

		// Token: 0x06030B51 RID: 199505 RVA: 0x0069C9AC File Offset: 0x0069ABAC
		public IFlowerSeaEscape GameplayConfigAsIFlowerSeaEscape()
		{
			return this.GameplayConfig<IFlowerSeaEscape>().Value;
		}

		// Token: 0x06030B52 RID: 199506 RVA: 0x0069C9C8 File Offset: 0x0069ABC8
		public IInstrumentQteGameplay GameplayConfigAsIInstrumentQteGameplay()
		{
			return this.GameplayConfig<IInstrumentQteGameplay>().Value;
		}

		// Token: 0x06030B53 RID: 199507 RVA: 0x0069C9E4 File Offset: 0x0069ABE4
		public IItemInspection GameplayConfigAsIItemInspection()
		{
			return this.GameplayConfig<IItemInspection>().Value;
		}

		// Token: 0x06030B54 RID: 199508 RVA: 0x0069CA00 File Offset: 0x0069AC00
		public ILifePoint GameplayConfigAsILifePoint()
		{
			return this.GameplayConfig<ILifePoint>().Value;
		}

		// Token: 0x06030B55 RID: 199509 RVA: 0x0069CA1C File Offset: 0x0069AC1C
		public IMorseCode GameplayConfigAsIMorseCode()
		{
			return this.GameplayConfig<IMorseCode>().Value;
		}

		// Token: 0x06030B56 RID: 199510 RVA: 0x0069CA38 File Offset: 0x0069AC38
		public IPlayPianoGameplay GameplayConfigAsIPlayPianoGameplay()
		{
			return this.GameplayConfig<IPlayPianoGameplay>().Value;
		}

		// Token: 0x06030B57 RID: 199511 RVA: 0x0069CA54 File Offset: 0x0069AC54
		public IProjectionMachine GameplayConfigAsIProjectionMachine()
		{
			return this.GameplayConfig<IProjectionMachine>().Value;
		}

		// Token: 0x06030B58 RID: 199512 RVA: 0x0069CA70 File Offset: 0x0069AC70
		public IProjectorPuzzle GameplayConfigAsIProjectorPuzzle()
		{
			return this.GameplayConfig<IProjectorPuzzle>().Value;
		}

		// Token: 0x06030B59 RID: 199513 RVA: 0x0069CA8C File Offset: 0x0069AC8C
		public IQteHourglass GameplayConfigAsIQteHourglass()
		{
			return this.GameplayConfig<IQteHourglass>().Value;
		}

		// Token: 0x06030B5A RID: 199514 RVA: 0x0069CAA8 File Offset: 0x0069ACA8
		public IReigns GameplayConfigAsIReigns()
		{
			return this.GameplayConfig<IReigns>().Value;
		}

		// Token: 0x06030B5B RID: 199515 RVA: 0x0069CAC4 File Offset: 0x0069ACC4
		public IRenjuChess GameplayConfigAsIRenjuChess()
		{
			return this.GameplayConfig<IRenjuChess>().Value;
		}

		// Token: 0x06030B5C RID: 199516 RVA: 0x0069CAE0 File Offset: 0x0069ACE0
		public IRideFlyingCar GameplayConfigAsIRideFlyingCar()
		{
			return this.GameplayConfig<IRideFlyingCar>().Value;
		}

		// Token: 0x06030B5D RID: 199517 RVA: 0x0069CAFC File Offset: 0x0069ACFC
		public ISceneInspection GameplayConfigAsISceneInspection()
		{
			return this.GameplayConfig<ISceneInspection>().Value;
		}

		// Token: 0x06030B5E RID: 199518 RVA: 0x0069CB18 File Offset: 0x0069AD18
		public ISheriffReasoning GameplayConfigAsISheriffReasoning()
		{
			return this.GameplayConfig<ISheriffReasoning>().Value;
		}

		// Token: 0x06030B5F RID: 199519 RVA: 0x0069CB34 File Offset: 0x0069AD34
		public ISignalBreakGameplay GameplayConfigAsISignalBreakGameplay()
		{
			return this.GameplayConfig<ISignalBreakGameplay>().Value;
		}

		// Token: 0x06030B60 RID: 199520 RVA: 0x0069CB50 File Offset: 0x0069AD50
		public ISignalDevice GameplayConfigAsISignalDevice()
		{
			return this.GameplayConfig<ISignalDevice>().Value;
		}

		// Token: 0x06030B61 RID: 199521 RVA: 0x0069CB6C File Offset: 0x0069AD6C
		public ISignalDevice2 GameplayConfigAsISignalDevice2()
		{
			return this.GameplayConfig<ISignalDevice2>().Value;
		}

		// Token: 0x06030B62 RID: 199522 RVA: 0x0069CB88 File Offset: 0x0069AD88
		public ISundialPuzzleGameplay GameplayConfigAsISundialPuzzleGameplay()
		{
			return this.GameplayConfig<ISundialPuzzleGameplay>().Value;
		}

		// Token: 0x06030B63 RID: 199523 RVA: 0x0069CBA4 File Offset: 0x0069ADA4
		public ITraceTracing GameplayConfigAsITraceTracing()
		{
			return this.GameplayConfig<ITraceTracing>().Value;
		}

		// Token: 0x06030B64 RID: 199524 RVA: 0x0069CBC0 File Offset: 0x0069ADC0
		public ITuningStand GameplayConfigAsITuningStand()
		{
			return this.GameplayConfig<ITuningStand>().Value;
		}

		// Token: 0x06030B65 RID: 199525 RVA: 0x0069CBDC File Offset: 0x0069ADDC
		public IWriteLetter GameplayConfigAsIWriteLetter()
		{
			return this.GameplayConfig<IWriteLetter>().Value;
		}

		// Token: 0x06030B66 RID: 199526 RVA: 0x0069CBF8 File Offset: 0x0069ADF8
		public IWuWaGoGame GameplayConfigAsIWuWaGoGame()
		{
			return this.GameplayConfig<IWuWaGoGame>().Value;
		}

		// Token: 0x1700CDF7 RID: 52727
		// (get) Token: 0x06030B67 RID: 199527 RVA: 0x0069CC14 File Offset: 0x0069AE14
		public string FinishSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030B68 RID: 199528 RVA: 0x0069CC4B File Offset: 0x0069AE4B
		public Span<byte> GetFinishSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030B69 RID: 199529 RVA: 0x0069CC5A File Offset: 0x0069AE5A
		public byte[] GetFinishSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CDF8 RID: 52728
		// (get) Token: 0x06030B6A RID: 199530 RVA: 0x0069CC68 File Offset: 0x0069AE68
		public string FailSendSelfEvent
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

		// Token: 0x06030B6B RID: 199531 RVA: 0x0069CCA0 File Offset: 0x0069AEA0
		public Span<byte> GetFailSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06030B6C RID: 199532 RVA: 0x0069CCB0 File Offset: 0x0069AEB0
		public byte[] GetFailSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06030B6D RID: 199533 RVA: 0x0069CCBF File Offset: 0x0069AEBF
		public static Offset<IOpenSimpleGameplay> CreateIOpenSimpleGameplay(FlatBufferBuilder builder, TUiGame GameplayConfig_type = TUiGame.NONE, int GameplayConfigOffset = 0, StringOffset FinishSendSelfEventOffset = default(StringOffset), StringOffset FailSendSelfEventOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IOpenSimpleGameplay.AddFailSendSelfEvent(builder, FailSendSelfEventOffset);
			IOpenSimpleGameplay.AddFinishSendSelfEvent(builder, FinishSendSelfEventOffset);
			IOpenSimpleGameplay.AddGameplayConfig(builder, GameplayConfigOffset);
			IOpenSimpleGameplay.AddGameplayConfigType(builder, GameplayConfig_type);
			return IOpenSimpleGameplay.EndIOpenSimpleGameplay(builder);
		}

		// Token: 0x06030B6E RID: 199534 RVA: 0x0069CCEB File Offset: 0x0069AEEB
		public static void StartIOpenSimpleGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030B6F RID: 199535 RVA: 0x0069CCF4 File Offset: 0x0069AEF4
		public static void AddGameplayConfigType(FlatBufferBuilder builder, TUiGame gameplayConfigType)
		{
			builder.AddByte(0, (byte)gameplayConfigType, 0);
		}

		// Token: 0x06030B70 RID: 199536 RVA: 0x0069CCFF File Offset: 0x0069AEFF
		public static void AddGameplayConfig(FlatBufferBuilder builder, int gameplayConfigOffset)
		{
			builder.AddOffset(1, gameplayConfigOffset, 0);
		}

		// Token: 0x06030B71 RID: 199537 RVA: 0x0069CD0A File Offset: 0x0069AF0A
		public static void AddFinishSendSelfEvent(FlatBufferBuilder builder, StringOffset finishSendSelfEventOffset)
		{
			builder.AddOffset(2, finishSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06030B72 RID: 199538 RVA: 0x0069CD1A File Offset: 0x0069AF1A
		public static void AddFailSendSelfEvent(FlatBufferBuilder builder, StringOffset failSendSelfEventOffset)
		{
			builder.AddOffset(3, failSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06030B73 RID: 199539 RVA: 0x0069CD2A File Offset: 0x0069AF2A
		public static Offset<IOpenSimpleGameplay> EndIOpenSimpleGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSimpleGameplay>(builder.EndTable());
		}

		// Token: 0x06030B74 RID: 199540 RVA: 0x0069CD38 File Offset: 0x0069AF38
		public IOpenSimpleGameplayT UnPack()
		{
			IOpenSimpleGameplayT openSimpleGameplayT = new IOpenSimpleGameplayT();
			this.UnPackTo(openSimpleGameplayT);
			return openSimpleGameplayT;
		}

		// Token: 0x06030B75 RID: 199541 RVA: 0x0069CD54 File Offset: 0x0069AF54
		public void UnPackTo(IOpenSimpleGameplayT _o)
		{
			_o.GameplayConfig = new TUiGameUnion();
			_o.GameplayConfig.Type = this.GameplayConfigType;
			switch (this.GameplayConfigType)
			{
			case TUiGame.IBrokenRock:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IBrokenRock>() != null) ? this.GameplayConfig<IBrokenRock>().Value.UnPack() : null);
				break;
			case TUiGame.ICipherGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ICipherGameplay>() != null) ? this.GameplayConfig<ICipherGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.IDaemonHack:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDaemonHack>() != null) ? this.GameplayConfig<IDaemonHack>().Value.UnPack() : null);
				break;
			case TUiGame.IDaolingAuthentication:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDaolingAuthentication>() != null) ? this.GameplayConfig<IDaolingAuthentication>().Value.UnPack() : null);
				break;
			case TUiGame.IDartGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDartGameplay>() != null) ? this.GameplayConfig<IDartGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.IDollGrab:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDollGrab>() != null) ? this.GameplayConfig<IDollGrab>().Value.UnPack() : null);
				break;
			case TUiGame.IDollGrabShowcase:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDollGrabShowcase>() != null) ? this.GameplayConfig<IDollGrabShowcase>().Value.UnPack() : null);
				break;
			case TUiGame.IDragActor:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IDragActor>() != null) ? this.GameplayConfig<IDragActor>().Value.UnPack() : null);
				break;
			case TUiGame.IFindSunSpirit:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IFindSunSpirit>() != null) ? this.GameplayConfig<IFindSunSpirit>().Value.UnPack() : null);
				break;
			case TUiGame.IFishingRoulette:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IFishingRoulette>() != null) ? this.GameplayConfig<IFishingRoulette>().Value.UnPack() : null);
				break;
			case TUiGame.IFlowerSeaEscape:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IFlowerSeaEscape>() != null) ? this.GameplayConfig<IFlowerSeaEscape>().Value.UnPack() : null);
				break;
			case TUiGame.IInstrumentQteGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IInstrumentQteGameplay>() != null) ? this.GameplayConfig<IInstrumentQteGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.IItemInspection:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IItemInspection>() != null) ? this.GameplayConfig<IItemInspection>().Value.UnPack() : null);
				break;
			case TUiGame.ILifePoint:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ILifePoint>() != null) ? this.GameplayConfig<ILifePoint>().Value.UnPack() : null);
				break;
			case TUiGame.IMorseCode:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IMorseCode>() != null) ? this.GameplayConfig<IMorseCode>().Value.UnPack() : null);
				break;
			case TUiGame.IPlayPianoGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IPlayPianoGameplay>() != null) ? this.GameplayConfig<IPlayPianoGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.IProjectionMachine:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IProjectionMachine>() != null) ? this.GameplayConfig<IProjectionMachine>().Value.UnPack() : null);
				break;
			case TUiGame.IProjectorPuzzle:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IProjectorPuzzle>() != null) ? this.GameplayConfig<IProjectorPuzzle>().Value.UnPack() : null);
				break;
			case TUiGame.IQteHourglass:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IQteHourglass>() != null) ? this.GameplayConfig<IQteHourglass>().Value.UnPack() : null);
				break;
			case TUiGame.IReigns:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IReigns>() != null) ? this.GameplayConfig<IReigns>().Value.UnPack() : null);
				break;
			case TUiGame.IRenjuChess:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IRenjuChess>() != null) ? this.GameplayConfig<IRenjuChess>().Value.UnPack() : null);
				break;
			case TUiGame.IRideFlyingCar:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IRideFlyingCar>() != null) ? this.GameplayConfig<IRideFlyingCar>().Value.UnPack() : null);
				break;
			case TUiGame.ISceneInspection:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISceneInspection>() != null) ? this.GameplayConfig<ISceneInspection>().Value.UnPack() : null);
				break;
			case TUiGame.ISheriffReasoning:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISheriffReasoning>() != null) ? this.GameplayConfig<ISheriffReasoning>().Value.UnPack() : null);
				break;
			case TUiGame.ISignalBreakGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISignalBreakGameplay>() != null) ? this.GameplayConfig<ISignalBreakGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.ISignalDevice:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISignalDevice>() != null) ? this.GameplayConfig<ISignalDevice>().Value.UnPack() : null);
				break;
			case TUiGame.ISignalDevice2:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISignalDevice2>() != null) ? this.GameplayConfig<ISignalDevice2>().Value.UnPack() : null);
				break;
			case TUiGame.ISundialPuzzleGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ISundialPuzzleGameplay>() != null) ? this.GameplayConfig<ISundialPuzzleGameplay>().Value.UnPack() : null);
				break;
			case TUiGame.ITraceTracing:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ITraceTracing>() != null) ? this.GameplayConfig<ITraceTracing>().Value.UnPack() : null);
				break;
			case TUiGame.ITuningStand:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ITuningStand>() != null) ? this.GameplayConfig<ITuningStand>().Value.UnPack() : null);
				break;
			case TUiGame.IWriteLetter:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IWriteLetter>() != null) ? this.GameplayConfig<IWriteLetter>().Value.UnPack() : null);
				break;
			case TUiGame.IWuWaGoGame:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IWuWaGoGame>() != null) ? this.GameplayConfig<IWuWaGoGame>().Value.UnPack() : null);
				break;
			}
			_o.FinishSendSelfEvent = this.FinishSendSelfEvent;
			_o.FailSendSelfEvent = this.FailSendSelfEvent;
		}

		// Token: 0x06030B76 RID: 199542 RVA: 0x0069D59C File Offset: 0x0069B79C
		public static Offset<IOpenSimpleGameplay> Pack(FlatBufferBuilder builder, IOpenSimpleGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSimpleGameplay>);
			}
			TUiGame gameplayConfig_type = (_o.GameplayConfig == null) ? TUiGame.NONE : _o.GameplayConfig.Type;
			int gameplayConfigOffset = (_o.GameplayConfig == null) ? 0 : TUiGameUnion.Pack(builder, _o.GameplayConfig);
			StringOffset finishSendSelfEventOffset = (_o.FinishSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.FinishSendSelfEvent);
			StringOffset failSendSelfEventOffset = (_o.FailSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.FailSendSelfEvent);
			return IOpenSimpleGameplay.CreateIOpenSimpleGameplay(builder, gameplayConfig_type, gameplayConfigOffset, finishSendSelfEventOffset, failSendSelfEventOffset);
		}

		// Token: 0x04011537 RID: 70967
		private Table __p;
	}
}
