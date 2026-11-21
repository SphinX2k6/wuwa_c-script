using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007391 RID: 29585
	public struct IOpenSimpleGameplay : IFlatbufferObject
	{
		// Token: 0x1700D910 RID: 55568
		// (get) Token: 0x06033A93 RID: 211603 RVA: 0x006F6AA1 File Offset: 0x006F4CA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A94 RID: 211604 RVA: 0x006F6AAE File Offset: 0x006F4CAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A95 RID: 211605 RVA: 0x006F6AB8 File Offset: 0x006F4CB8
		public static IOpenSimpleGameplay GetRootAsIOpenSimpleGameplay(ByteBuffer _bb)
		{
			return IOpenSimpleGameplay.GetRootAsIOpenSimpleGameplay(_bb, default(IOpenSimpleGameplay));
		}

		// Token: 0x06033A96 RID: 211606 RVA: 0x006F6AD4 File Offset: 0x006F4CD4
		public static IOpenSimpleGameplay GetRootAsIOpenSimpleGameplay(ByteBuffer _bb, IOpenSimpleGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A97 RID: 211607 RVA: 0x006F6AF1 File Offset: 0x006F4CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A98 RID: 211608 RVA: 0x006F6B00 File Offset: 0x006F4D00
		public IOpenSimpleGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D911 RID: 55569
		// (get) Token: 0x06033A99 RID: 211609 RVA: 0x006F6B10 File Offset: 0x006F4D10
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

		// Token: 0x06033A9A RID: 211610 RVA: 0x006F6B4C File Offset: 0x006F4D4C
		public TTable? GameplayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033A9B RID: 211611 RVA: 0x006F6B90 File Offset: 0x006F4D90
		public IBrokenRock GameplayConfigAsIBrokenRock()
		{
			return this.GameplayConfig<IBrokenRock>().Value;
		}

		// Token: 0x06033A9C RID: 211612 RVA: 0x006F6BAC File Offset: 0x006F4DAC
		public ICipherGameplay GameplayConfigAsICipherGameplay()
		{
			return this.GameplayConfig<ICipherGameplay>().Value;
		}

		// Token: 0x06033A9D RID: 211613 RVA: 0x006F6BC8 File Offset: 0x006F4DC8
		public IDaemonHack GameplayConfigAsIDaemonHack()
		{
			return this.GameplayConfig<IDaemonHack>().Value;
		}

		// Token: 0x06033A9E RID: 211614 RVA: 0x006F6BE4 File Offset: 0x006F4DE4
		public IDaolingAuthentication GameplayConfigAsIDaolingAuthentication()
		{
			return this.GameplayConfig<IDaolingAuthentication>().Value;
		}

		// Token: 0x06033A9F RID: 211615 RVA: 0x006F6C00 File Offset: 0x006F4E00
		public IDartGameplay GameplayConfigAsIDartGameplay()
		{
			return this.GameplayConfig<IDartGameplay>().Value;
		}

		// Token: 0x06033AA0 RID: 211616 RVA: 0x006F6C1C File Offset: 0x006F4E1C
		public IDollGrab GameplayConfigAsIDollGrab()
		{
			return this.GameplayConfig<IDollGrab>().Value;
		}

		// Token: 0x06033AA1 RID: 211617 RVA: 0x006F6C38 File Offset: 0x006F4E38
		public IDollGrabShowcase GameplayConfigAsIDollGrabShowcase()
		{
			return this.GameplayConfig<IDollGrabShowcase>().Value;
		}

		// Token: 0x06033AA2 RID: 211618 RVA: 0x006F6C54 File Offset: 0x006F4E54
		public IDragActor GameplayConfigAsIDragActor()
		{
			return this.GameplayConfig<IDragActor>().Value;
		}

		// Token: 0x06033AA3 RID: 211619 RVA: 0x006F6C70 File Offset: 0x006F4E70
		public IFindSunSpirit GameplayConfigAsIFindSunSpirit()
		{
			return this.GameplayConfig<IFindSunSpirit>().Value;
		}

		// Token: 0x06033AA4 RID: 211620 RVA: 0x006F6C8C File Offset: 0x006F4E8C
		public IFishingRoulette GameplayConfigAsIFishingRoulette()
		{
			return this.GameplayConfig<IFishingRoulette>().Value;
		}

		// Token: 0x06033AA5 RID: 211621 RVA: 0x006F6CA8 File Offset: 0x006F4EA8
		public IFlowerSeaEscape GameplayConfigAsIFlowerSeaEscape()
		{
			return this.GameplayConfig<IFlowerSeaEscape>().Value;
		}

		// Token: 0x06033AA6 RID: 211622 RVA: 0x006F6CC4 File Offset: 0x006F4EC4
		public IFrequencyDetect GameplayConfigAsIFrequencyDetect()
		{
			return this.GameplayConfig<IFrequencyDetect>().Value;
		}

		// Token: 0x06033AA7 RID: 211623 RVA: 0x006F6CE0 File Offset: 0x006F4EE0
		public IFrequencyPaint GameplayConfigAsIFrequencyPaint()
		{
			return this.GameplayConfig<IFrequencyPaint>().Value;
		}

		// Token: 0x06033AA8 RID: 211624 RVA: 0x006F6CFC File Offset: 0x006F4EFC
		public IInstrumentQteGameplay GameplayConfigAsIInstrumentQteGameplay()
		{
			return this.GameplayConfig<IInstrumentQteGameplay>().Value;
		}

		// Token: 0x06033AA9 RID: 211625 RVA: 0x006F6D18 File Offset: 0x006F4F18
		public IItemInspection GameplayConfigAsIItemInspection()
		{
			return this.GameplayConfig<IItemInspection>().Value;
		}

		// Token: 0x06033AAA RID: 211626 RVA: 0x006F6D34 File Offset: 0x006F4F34
		public ILifePoint GameplayConfigAsILifePoint()
		{
			return this.GameplayConfig<ILifePoint>().Value;
		}

		// Token: 0x06033AAB RID: 211627 RVA: 0x006F6D50 File Offset: 0x006F4F50
		public IMorseCode GameplayConfigAsIMorseCode()
		{
			return this.GameplayConfig<IMorseCode>().Value;
		}

		// Token: 0x06033AAC RID: 211628 RVA: 0x006F6D6C File Offset: 0x006F4F6C
		public IPlayPianoGameplay GameplayConfigAsIPlayPianoGameplay()
		{
			return this.GameplayConfig<IPlayPianoGameplay>().Value;
		}

		// Token: 0x06033AAD RID: 211629 RVA: 0x006F6D88 File Offset: 0x006F4F88
		public IProjectionMachine GameplayConfigAsIProjectionMachine()
		{
			return this.GameplayConfig<IProjectionMachine>().Value;
		}

		// Token: 0x06033AAE RID: 211630 RVA: 0x006F6DA4 File Offset: 0x006F4FA4
		public IProjectorPuzzle GameplayConfigAsIProjectorPuzzle()
		{
			return this.GameplayConfig<IProjectorPuzzle>().Value;
		}

		// Token: 0x06033AAF RID: 211631 RVA: 0x006F6DC0 File Offset: 0x006F4FC0
		public IQteHourglass GameplayConfigAsIQteHourglass()
		{
			return this.GameplayConfig<IQteHourglass>().Value;
		}

		// Token: 0x06033AB0 RID: 211632 RVA: 0x006F6DDC File Offset: 0x006F4FDC
		public IReigns GameplayConfigAsIReigns()
		{
			return this.GameplayConfig<IReigns>().Value;
		}

		// Token: 0x06033AB1 RID: 211633 RVA: 0x006F6DF8 File Offset: 0x006F4FF8
		public IRenjuChess GameplayConfigAsIRenjuChess()
		{
			return this.GameplayConfig<IRenjuChess>().Value;
		}

		// Token: 0x06033AB2 RID: 211634 RVA: 0x006F6E14 File Offset: 0x006F5014
		public IRideFlyingCar GameplayConfigAsIRideFlyingCar()
		{
			return this.GameplayConfig<IRideFlyingCar>().Value;
		}

		// Token: 0x06033AB3 RID: 211635 RVA: 0x006F6E30 File Offset: 0x006F5030
		public ISceneInspection GameplayConfigAsISceneInspection()
		{
			return this.GameplayConfig<ISceneInspection>().Value;
		}

		// Token: 0x06033AB4 RID: 211636 RVA: 0x006F6E4C File Offset: 0x006F504C
		public ISheriffReasoning GameplayConfigAsISheriffReasoning()
		{
			return this.GameplayConfig<ISheriffReasoning>().Value;
		}

		// Token: 0x06033AB5 RID: 211637 RVA: 0x006F6E68 File Offset: 0x006F5068
		public ISignalBreakGameplay GameplayConfigAsISignalBreakGameplay()
		{
			return this.GameplayConfig<ISignalBreakGameplay>().Value;
		}

		// Token: 0x06033AB6 RID: 211638 RVA: 0x006F6E84 File Offset: 0x006F5084
		public ISignalDevice GameplayConfigAsISignalDevice()
		{
			return this.GameplayConfig<ISignalDevice>().Value;
		}

		// Token: 0x06033AB7 RID: 211639 RVA: 0x006F6EA0 File Offset: 0x006F50A0
		public ISignalDevice2 GameplayConfigAsISignalDevice2()
		{
			return this.GameplayConfig<ISignalDevice2>().Value;
		}

		// Token: 0x06033AB8 RID: 211640 RVA: 0x006F6EBC File Offset: 0x006F50BC
		public ISundialPuzzleGameplay GameplayConfigAsISundialPuzzleGameplay()
		{
			return this.GameplayConfig<ISundialPuzzleGameplay>().Value;
		}

		// Token: 0x06033AB9 RID: 211641 RVA: 0x006F6ED8 File Offset: 0x006F50D8
		public ITraceTracing GameplayConfigAsITraceTracing()
		{
			return this.GameplayConfig<ITraceTracing>().Value;
		}

		// Token: 0x06033ABA RID: 211642 RVA: 0x006F6EF4 File Offset: 0x006F50F4
		public ITuningStand GameplayConfigAsITuningStand()
		{
			return this.GameplayConfig<ITuningStand>().Value;
		}

		// Token: 0x06033ABB RID: 211643 RVA: 0x006F6F10 File Offset: 0x006F5110
		public ITurntableConnectorUiGameplay GameplayConfigAsITurntableConnectorUiGameplay()
		{
			return this.GameplayConfig<ITurntableConnectorUiGameplay>().Value;
		}

		// Token: 0x06033ABC RID: 211644 RVA: 0x006F6F2C File Offset: 0x006F512C
		public IWriteLetter GameplayConfigAsIWriteLetter()
		{
			return this.GameplayConfig<IWriteLetter>().Value;
		}

		// Token: 0x06033ABD RID: 211645 RVA: 0x006F6F48 File Offset: 0x006F5148
		public IWuWaGoGame GameplayConfigAsIWuWaGoGame()
		{
			return this.GameplayConfig<IWuWaGoGame>().Value;
		}

		// Token: 0x1700D912 RID: 55570
		// (get) Token: 0x06033ABE RID: 211646 RVA: 0x006F6F64 File Offset: 0x006F5164
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

		// Token: 0x06033ABF RID: 211647 RVA: 0x006F6F9B File Offset: 0x006F519B
		public Span<byte> GetFinishSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06033AC0 RID: 211648 RVA: 0x006F6FAA File Offset: 0x006F51AA
		public byte[] GetFinishSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D913 RID: 55571
		// (get) Token: 0x06033AC1 RID: 211649 RVA: 0x006F6FB8 File Offset: 0x006F51B8
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

		// Token: 0x06033AC2 RID: 211650 RVA: 0x006F6FF0 File Offset: 0x006F51F0
		public Span<byte> GetFailSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06033AC3 RID: 211651 RVA: 0x006F7000 File Offset: 0x006F5200
		public byte[] GetFailSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06033AC4 RID: 211652 RVA: 0x006F700F File Offset: 0x006F520F
		public static Offset<IOpenSimpleGameplay> CreateIOpenSimpleGameplay(FlatBufferBuilder builder, TUiGame GameplayConfig_type = TUiGame.NONE, int GameplayConfigOffset = 0, StringOffset FinishSendSelfEventOffset = default(StringOffset), StringOffset FailSendSelfEventOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IOpenSimpleGameplay.AddFailSendSelfEvent(builder, FailSendSelfEventOffset);
			IOpenSimpleGameplay.AddFinishSendSelfEvent(builder, FinishSendSelfEventOffset);
			IOpenSimpleGameplay.AddGameplayConfig(builder, GameplayConfigOffset);
			IOpenSimpleGameplay.AddGameplayConfigType(builder, GameplayConfig_type);
			return IOpenSimpleGameplay.EndIOpenSimpleGameplay(builder);
		}

		// Token: 0x06033AC5 RID: 211653 RVA: 0x006F703B File Offset: 0x006F523B
		public static void StartIOpenSimpleGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033AC6 RID: 211654 RVA: 0x006F7044 File Offset: 0x006F5244
		public static void AddGameplayConfigType(FlatBufferBuilder builder, TUiGame gameplayConfigType)
		{
			builder.AddByte(0, (byte)gameplayConfigType, 0);
		}

		// Token: 0x06033AC7 RID: 211655 RVA: 0x006F704F File Offset: 0x006F524F
		public static void AddGameplayConfig(FlatBufferBuilder builder, int gameplayConfigOffset)
		{
			builder.AddOffset(1, gameplayConfigOffset, 0);
		}

		// Token: 0x06033AC8 RID: 211656 RVA: 0x006F705A File Offset: 0x006F525A
		public static void AddFinishSendSelfEvent(FlatBufferBuilder builder, StringOffset finishSendSelfEventOffset)
		{
			builder.AddOffset(2, finishSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06033AC9 RID: 211657 RVA: 0x006F706A File Offset: 0x006F526A
		public static void AddFailSendSelfEvent(FlatBufferBuilder builder, StringOffset failSendSelfEventOffset)
		{
			builder.AddOffset(3, failSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06033ACA RID: 211658 RVA: 0x006F707A File Offset: 0x006F527A
		public static Offset<IOpenSimpleGameplay> EndIOpenSimpleGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSimpleGameplay>(builder.EndTable());
		}

		// Token: 0x06033ACB RID: 211659 RVA: 0x006F7088 File Offset: 0x006F5288
		public IOpenSimpleGameplayT UnPack()
		{
			IOpenSimpleGameplayT openSimpleGameplayT = new IOpenSimpleGameplayT();
			this.UnPackTo(openSimpleGameplayT);
			return openSimpleGameplayT;
		}

		// Token: 0x06033ACC RID: 211660 RVA: 0x006F70A4 File Offset: 0x006F52A4
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
			case TUiGame.IFrequencyDetect:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IFrequencyDetect>() != null) ? this.GameplayConfig<IFrequencyDetect>().Value.UnPack() : null);
				break;
			case TUiGame.IFrequencyPaint:
				_o.GameplayConfig.Value = ((this.GameplayConfig<IFrequencyPaint>() != null) ? this.GameplayConfig<IFrequencyPaint>().Value.UnPack() : null);
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
			case TUiGame.ITurntableConnectorUiGameplay:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ITurntableConnectorUiGameplay>() != null) ? this.GameplayConfig<ITurntableConnectorUiGameplay>().Value.UnPack() : null);
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

		// Token: 0x06033ACD RID: 211661 RVA: 0x006F79AC File Offset: 0x006F5BAC
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

		// Token: 0x0401248E RID: 74894
		private Table __p;
	}
}
