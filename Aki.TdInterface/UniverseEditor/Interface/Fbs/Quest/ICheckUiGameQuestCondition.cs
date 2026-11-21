using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419C RID: 16796
	public struct ICheckUiGameQuestCondition : IFlatbufferObject
	{
		// Token: 0x170071CC RID: 29132
		// (get) Token: 0x06017225 RID: 94757 RVA: 0x0034BDE6 File Offset: 0x00349FE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017226 RID: 94758 RVA: 0x0034BDF3 File Offset: 0x00349FF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017227 RID: 94759 RVA: 0x0034BDFC File Offset: 0x00349FFC
		public static ICheckUiGameQuestCondition GetRootAsICheckUiGameQuestCondition(ByteBuffer _bb)
		{
			return ICheckUiGameQuestCondition.GetRootAsICheckUiGameQuestCondition(_bb, default(ICheckUiGameQuestCondition));
		}

		// Token: 0x06017228 RID: 94760 RVA: 0x0034BE18 File Offset: 0x0034A018
		public static ICheckUiGameQuestCondition GetRootAsICheckUiGameQuestCondition(ByteBuffer _bb, ICheckUiGameQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017229 RID: 94761 RVA: 0x0034BE35 File Offset: 0x0034A035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601722A RID: 94762 RVA: 0x0034BE44 File Offset: 0x0034A044
		public ICheckUiGameQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071CD RID: 29133
		// (get) Token: 0x0601722B RID: 94763 RVA: 0x0034BE54 File Offset: 0x0034A054
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071CE RID: 29134
		// (get) Token: 0x0601722C RID: 94764 RVA: 0x0034BE90 File Offset: 0x0034A090
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601722D RID: 94765 RVA: 0x0034BEF0 File Offset: 0x0034A0F0
		public TUiGame GameplayConfigsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TUiGame.NONE;
			}
			return (TUiGame)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170071CF RID: 29135
		// (get) Token: 0x0601722E RID: 94766 RVA: 0x0034BF30 File Offset: 0x0034A130
		public int GameplayConfigsTypeLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601722F RID: 94767 RVA: 0x0034BF5B File Offset: 0x0034A15B
		public Span<TUiGame> GetGameplayConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TUiGame>(8, 1);
		}

		// Token: 0x06017230 RID: 94768 RVA: 0x0034BF6C File Offset: 0x0034A16C
		public TUiGame[] GetGameplayConfigsTypeArray()
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TUiGame[] array = new TUiGame[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TUiGame)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017231 RID: 94769 RVA: 0x0034BFD8 File Offset: 0x0034A1D8
		public TTable? GameplayConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170071D0 RID: 29136
		// (get) Token: 0x06017232 RID: 94770 RVA: 0x0034C020 File Offset: 0x0034A220
		public int GameplayConfigsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017233 RID: 94771 RVA: 0x0034C04C File Offset: 0x0034A24C
		public static Offset<ICheckUiGameQuestCondition> CreateICheckUiGameQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset GameplayConfigs_typeOffset = default(VectorOffset), VectorOffset GameplayConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckUiGameQuestCondition.AddGameplayConfigs(builder, GameplayConfigsOffset);
			ICheckUiGameQuestCondition.AddGameplayConfigsType(builder, GameplayConfigs_typeOffset);
			ICheckUiGameQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckUiGameQuestCondition.AddType(builder, Type);
			return ICheckUiGameQuestCondition.EndICheckUiGameQuestCondition(builder);
		}

		// Token: 0x06017234 RID: 94772 RVA: 0x0034C078 File Offset: 0x0034A278
		public static void StartICheckUiGameQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017235 RID: 94773 RVA: 0x0034C081 File Offset: 0x0034A281
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017236 RID: 94774 RVA: 0x0034C08C File Offset: 0x0034A28C
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017237 RID: 94775 RVA: 0x0034C09C File Offset: 0x0034A29C
		public static void AddGameplayConfigsType(FlatBufferBuilder builder, VectorOffset gameplayConfigsTypeOffset)
		{
			builder.AddOffset(2, gameplayConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06017238 RID: 94776 RVA: 0x0034C0AC File Offset: 0x0034A2AC
		public static VectorOffset CreateGameplayConfigsTypeVector(FlatBufferBuilder builder, TUiGame[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x0034C0E3 File Offset: 0x0034A2E3
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, TUiGame[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TUiGame>(data);
			return builder.EndVector();
		}

		// Token: 0x0601723A RID: 94778 RVA: 0x0034C0FD File Offset: 0x0034A2FD
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TUiGame> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TUiGame>(data);
			return builder.EndVector();
		}

		// Token: 0x0601723B RID: 94779 RVA: 0x0034C11B File Offset: 0x0034A31B
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TUiGame>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601723C RID: 94780 RVA: 0x0034C134 File Offset: 0x0034A334
		public static void StartGameplayConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601723D RID: 94781 RVA: 0x0034C13F File Offset: 0x0034A33F
		public static void AddGameplayConfigs(FlatBufferBuilder builder, VectorOffset gameplayConfigsOffset)
		{
			builder.AddOffset(3, gameplayConfigsOffset.Value, 0);
		}

		// Token: 0x0601723E RID: 94782 RVA: 0x0034C150 File Offset: 0x0034A350
		public static VectorOffset CreateGameplayConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601723F RID: 94783 RVA: 0x0034C187 File Offset: 0x0034A387
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017240 RID: 94784 RVA: 0x0034C1A1 File Offset: 0x0034A3A1
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017241 RID: 94785 RVA: 0x0034C1BF File Offset: 0x0034A3BF
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017242 RID: 94786 RVA: 0x0034C1D8 File Offset: 0x0034A3D8
		public static void StartGameplayConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017243 RID: 94787 RVA: 0x0034C1E3 File Offset: 0x0034A3E3
		public static Offset<ICheckUiGameQuestCondition> EndICheckUiGameQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckUiGameQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017244 RID: 94788 RVA: 0x0034C1F0 File Offset: 0x0034A3F0
		public ICheckUiGameQuestConditionT UnPack()
		{
			ICheckUiGameQuestConditionT checkUiGameQuestConditionT = new ICheckUiGameQuestConditionT();
			this.UnPackTo(checkUiGameQuestConditionT);
			return checkUiGameQuestConditionT;
		}

		// Token: 0x06017245 RID: 94789 RVA: 0x0034C20C File Offset: 0x0034A40C
		public void UnPackTo(ICheckUiGameQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.GameplayConfigs = new List<TUiGameUnion>();
			for (int i = 0; i < this.GameplayConfigsLength; i++)
			{
				TUiGameUnion tuiGameUnion = new TUiGameUnion();
				tuiGameUnion.Type = this.GameplayConfigsType(i);
				switch (this.GameplayConfigsType(i))
				{
				case TUiGame.IBrokenRock:
					tuiGameUnion.Value = ((this.GameplayConfigs<IBrokenRock>(i) != null) ? this.GameplayConfigs<IBrokenRock>(i).Value.UnPack() : null);
					break;
				case TUiGame.ICipherGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<ICipherGameplay>(i) != null) ? this.GameplayConfigs<ICipherGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDaemonHack:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDaemonHack>(i) != null) ? this.GameplayConfigs<IDaemonHack>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDaolingAuthentication:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDaolingAuthentication>(i) != null) ? this.GameplayConfigs<IDaolingAuthentication>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDartGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDartGameplay>(i) != null) ? this.GameplayConfigs<IDartGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDollGrab:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDollGrab>(i) != null) ? this.GameplayConfigs<IDollGrab>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDollGrabShowcase:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDollGrabShowcase>(i) != null) ? this.GameplayConfigs<IDollGrabShowcase>(i).Value.UnPack() : null);
					break;
				case TUiGame.IDragActor:
					tuiGameUnion.Value = ((this.GameplayConfigs<IDragActor>(i) != null) ? this.GameplayConfigs<IDragActor>(i).Value.UnPack() : null);
					break;
				case TUiGame.IFindSunSpirit:
					tuiGameUnion.Value = ((this.GameplayConfigs<IFindSunSpirit>(i) != null) ? this.GameplayConfigs<IFindSunSpirit>(i).Value.UnPack() : null);
					break;
				case TUiGame.IFishingRoulette:
					tuiGameUnion.Value = ((this.GameplayConfigs<IFishingRoulette>(i) != null) ? this.GameplayConfigs<IFishingRoulette>(i).Value.UnPack() : null);
					break;
				case TUiGame.IFlowerSeaEscape:
					tuiGameUnion.Value = ((this.GameplayConfigs<IFlowerSeaEscape>(i) != null) ? this.GameplayConfigs<IFlowerSeaEscape>(i).Value.UnPack() : null);
					break;
				case TUiGame.IFrequencyDetect:
					tuiGameUnion.Value = ((this.GameplayConfigs<IFrequencyDetect>(i) != null) ? this.GameplayConfigs<IFrequencyDetect>(i).Value.UnPack() : null);
					break;
				case TUiGame.IFrequencyPaint:
					tuiGameUnion.Value = ((this.GameplayConfigs<IFrequencyPaint>(i) != null) ? this.GameplayConfigs<IFrequencyPaint>(i).Value.UnPack() : null);
					break;
				case TUiGame.IInstrumentQteGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<IInstrumentQteGameplay>(i) != null) ? this.GameplayConfigs<IInstrumentQteGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.IItemInspection:
					tuiGameUnion.Value = ((this.GameplayConfigs<IItemInspection>(i) != null) ? this.GameplayConfigs<IItemInspection>(i).Value.UnPack() : null);
					break;
				case TUiGame.ILifePoint:
					tuiGameUnion.Value = ((this.GameplayConfigs<ILifePoint>(i) != null) ? this.GameplayConfigs<ILifePoint>(i).Value.UnPack() : null);
					break;
				case TUiGame.IMorseCode:
					tuiGameUnion.Value = ((this.GameplayConfigs<IMorseCode>(i) != null) ? this.GameplayConfigs<IMorseCode>(i).Value.UnPack() : null);
					break;
				case TUiGame.IPlayPianoGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<IPlayPianoGameplay>(i) != null) ? this.GameplayConfigs<IPlayPianoGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.IProjectionMachine:
					tuiGameUnion.Value = ((this.GameplayConfigs<IProjectionMachine>(i) != null) ? this.GameplayConfigs<IProjectionMachine>(i).Value.UnPack() : null);
					break;
				case TUiGame.IProjectorPuzzle:
					tuiGameUnion.Value = ((this.GameplayConfigs<IProjectorPuzzle>(i) != null) ? this.GameplayConfigs<IProjectorPuzzle>(i).Value.UnPack() : null);
					break;
				case TUiGame.IQteHourglass:
					tuiGameUnion.Value = ((this.GameplayConfigs<IQteHourglass>(i) != null) ? this.GameplayConfigs<IQteHourglass>(i).Value.UnPack() : null);
					break;
				case TUiGame.IReigns:
					tuiGameUnion.Value = ((this.GameplayConfigs<IReigns>(i) != null) ? this.GameplayConfigs<IReigns>(i).Value.UnPack() : null);
					break;
				case TUiGame.IRenjuChess:
					tuiGameUnion.Value = ((this.GameplayConfigs<IRenjuChess>(i) != null) ? this.GameplayConfigs<IRenjuChess>(i).Value.UnPack() : null);
					break;
				case TUiGame.IRideFlyingCar:
					tuiGameUnion.Value = ((this.GameplayConfigs<IRideFlyingCar>(i) != null) ? this.GameplayConfigs<IRideFlyingCar>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISceneInspection:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISceneInspection>(i) != null) ? this.GameplayConfigs<ISceneInspection>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISheriffReasoning:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISheriffReasoning>(i) != null) ? this.GameplayConfigs<ISheriffReasoning>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISignalBreakGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISignalBreakGameplay>(i) != null) ? this.GameplayConfigs<ISignalBreakGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISignalDevice:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISignalDevice>(i) != null) ? this.GameplayConfigs<ISignalDevice>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISignalDevice2:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISignalDevice2>(i) != null) ? this.GameplayConfigs<ISignalDevice2>(i).Value.UnPack() : null);
					break;
				case TUiGame.ISundialPuzzleGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<ISundialPuzzleGameplay>(i) != null) ? this.GameplayConfigs<ISundialPuzzleGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.ITraceTracing:
					tuiGameUnion.Value = ((this.GameplayConfigs<ITraceTracing>(i) != null) ? this.GameplayConfigs<ITraceTracing>(i).Value.UnPack() : null);
					break;
				case TUiGame.ITuningStand:
					tuiGameUnion.Value = ((this.GameplayConfigs<ITuningStand>(i) != null) ? this.GameplayConfigs<ITuningStand>(i).Value.UnPack() : null);
					break;
				case TUiGame.ITurntableConnectorUiGameplay:
					tuiGameUnion.Value = ((this.GameplayConfigs<ITurntableConnectorUiGameplay>(i) != null) ? this.GameplayConfigs<ITurntableConnectorUiGameplay>(i).Value.UnPack() : null);
					break;
				case TUiGame.IWriteLetter:
					tuiGameUnion.Value = ((this.GameplayConfigs<IWriteLetter>(i) != null) ? this.GameplayConfigs<IWriteLetter>(i).Value.UnPack() : null);
					break;
				case TUiGame.IWuWaGoGame:
					tuiGameUnion.Value = ((this.GameplayConfigs<IWuWaGoGame>(i) != null) ? this.GameplayConfigs<IWuWaGoGame>(i).Value.UnPack() : null);
					break;
				}
				_o.GameplayConfigs.Add(tuiGameUnion);
			}
		}

		// Token: 0x06017246 RID: 94790 RVA: 0x0034CAF8 File Offset: 0x0034ACF8
		public static Offset<ICheckUiGameQuestCondition> Pack(FlatBufferBuilder builder, ICheckUiGameQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckUiGameQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset gameplayConfigs_typeOffset = default(VectorOffset);
			if (_o.GameplayConfigs != null)
			{
				TUiGame[] array = new TUiGame[_o.GameplayConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.GameplayConfigs[i].Type;
				}
				gameplayConfigs_typeOffset = ICheckUiGameQuestCondition.CreateGameplayConfigsTypeVector(builder, array);
			}
			VectorOffset gameplayConfigsOffset = default(VectorOffset);
			if (_o.GameplayConfigs != null)
			{
				int[] array2 = new int[_o.GameplayConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TUiGameUnion.Pack(builder, _o.GameplayConfigs[j]);
				}
				gameplayConfigsOffset = ICheckUiGameQuestCondition.CreateGameplayConfigsVector(builder, array2);
			}
			return ICheckUiGameQuestCondition.CreateICheckUiGameQuestCondition(builder, _o.Type, preConditionsOffset, gameplayConfigs_typeOffset, gameplayConfigsOffset);
		}

		// Token: 0x0400C01E RID: 49182
		private Table __p;
	}
}
