using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D85 RID: 15749
	public struct ICheckUiGameQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006C12 RID: 27666
		// (get) Token: 0x06015CED RID: 89325 RVA: 0x00324B6E File Offset: 0x00322D6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015CEE RID: 89326 RVA: 0x00324B7B File Offset: 0x00322D7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015CEF RID: 89327 RVA: 0x00324B84 File Offset: 0x00322D84
		public static ICheckUiGameQuestCondition GetRootAsICheckUiGameQuestCondition(ByteBuffer _bb)
		{
			return ICheckUiGameQuestCondition.GetRootAsICheckUiGameQuestCondition(_bb, default(ICheckUiGameQuestCondition));
		}

		// Token: 0x06015CF0 RID: 89328 RVA: 0x00324BA0 File Offset: 0x00322DA0
		public static ICheckUiGameQuestCondition GetRootAsICheckUiGameQuestCondition(ByteBuffer _bb, ICheckUiGameQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015CF1 RID: 89329 RVA: 0x00324BBD File Offset: 0x00322DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015CF2 RID: 89330 RVA: 0x00324BCC File Offset: 0x00322DCC
		public ICheckUiGameQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C13 RID: 27667
		// (get) Token: 0x06015CF3 RID: 89331 RVA: 0x00324BDC File Offset: 0x00322DDC
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

		// Token: 0x17006C14 RID: 27668
		// (get) Token: 0x06015CF4 RID: 89332 RVA: 0x00324C18 File Offset: 0x00322E18
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

		// Token: 0x06015CF5 RID: 89333 RVA: 0x00324C78 File Offset: 0x00322E78
		public TUiGame GameplayConfigsType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return TUiGame.NONE;
			}
			return (TUiGame)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006C15 RID: 27669
		// (get) Token: 0x06015CF6 RID: 89334 RVA: 0x00324CB8 File Offset: 0x00322EB8
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

		// Token: 0x06015CF7 RID: 89335 RVA: 0x00324CE3 File Offset: 0x00322EE3
		public Span<TUiGame> GetGameplayConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TUiGame>(8, 1);
		}

		// Token: 0x06015CF8 RID: 89336 RVA: 0x00324CF4 File Offset: 0x00322EF4
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

		// Token: 0x06015CF9 RID: 89337 RVA: 0x00324D60 File Offset: 0x00322F60
		public TTable? GameplayConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006C16 RID: 27670
		// (get) Token: 0x06015CFA RID: 89338 RVA: 0x00324DA8 File Offset: 0x00322FA8
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

		// Token: 0x06015CFB RID: 89339 RVA: 0x00324DD4 File Offset: 0x00322FD4
		public static Offset<ICheckUiGameQuestCondition> CreateICheckUiGameQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset GameplayConfigs_typeOffset = default(VectorOffset), VectorOffset GameplayConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckUiGameQuestCondition.AddGameplayConfigs(builder, GameplayConfigsOffset);
			ICheckUiGameQuestCondition.AddGameplayConfigsType(builder, GameplayConfigs_typeOffset);
			ICheckUiGameQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckUiGameQuestCondition.AddType(builder, Type);
			return ICheckUiGameQuestCondition.EndICheckUiGameQuestCondition(builder);
		}

		// Token: 0x06015CFC RID: 89340 RVA: 0x00324E00 File Offset: 0x00323000
		public static void StartICheckUiGameQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015CFD RID: 89341 RVA: 0x00324E09 File Offset: 0x00323009
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015CFE RID: 89342 RVA: 0x00324E14 File Offset: 0x00323014
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015CFF RID: 89343 RVA: 0x00324E24 File Offset: 0x00323024
		public static void AddGameplayConfigsType(FlatBufferBuilder builder, VectorOffset gameplayConfigsTypeOffset)
		{
			builder.AddOffset(2, gameplayConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06015D00 RID: 89344 RVA: 0x00324E34 File Offset: 0x00323034
		public static VectorOffset CreateGameplayConfigsTypeVector(FlatBufferBuilder builder, TUiGame[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015D01 RID: 89345 RVA: 0x00324E6B File Offset: 0x0032306B
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, TUiGame[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TUiGame>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D02 RID: 89346 RVA: 0x00324E85 File Offset: 0x00323085
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TUiGame> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TUiGame>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D03 RID: 89347 RVA: 0x00324EA3 File Offset: 0x003230A3
		public static VectorOffset CreateGameplayConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TUiGame>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015D04 RID: 89348 RVA: 0x00324EBC File Offset: 0x003230BC
		public static void StartGameplayConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06015D05 RID: 89349 RVA: 0x00324EC7 File Offset: 0x003230C7
		public static void AddGameplayConfigs(FlatBufferBuilder builder, VectorOffset gameplayConfigsOffset)
		{
			builder.AddOffset(3, gameplayConfigsOffset.Value, 0);
		}

		// Token: 0x06015D06 RID: 89350 RVA: 0x00324ED8 File Offset: 0x003230D8
		public static VectorOffset CreateGameplayConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015D07 RID: 89351 RVA: 0x00324F0F File Offset: 0x0032310F
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D08 RID: 89352 RVA: 0x00324F29 File Offset: 0x00323129
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D09 RID: 89353 RVA: 0x00324F47 File Offset: 0x00323147
		public static VectorOffset CreateGameplayConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015D0A RID: 89354 RVA: 0x00324F60 File Offset: 0x00323160
		public static void StartGameplayConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015D0B RID: 89355 RVA: 0x00324F6B File Offset: 0x0032316B
		public static Offset<ICheckUiGameQuestCondition> EndICheckUiGameQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckUiGameQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015D0C RID: 89356 RVA: 0x00324F78 File Offset: 0x00323178
		public ICheckUiGameQuestConditionT UnPack()
		{
			ICheckUiGameQuestConditionT checkUiGameQuestConditionT = new ICheckUiGameQuestConditionT();
			this.UnPackTo(checkUiGameQuestConditionT);
			return checkUiGameQuestConditionT;
		}

		// Token: 0x06015D0D RID: 89357 RVA: 0x00324F94 File Offset: 0x00323194
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

		// Token: 0x06015D0E RID: 89358 RVA: 0x003257CC File Offset: 0x003239CC
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

		// Token: 0x0400B671 RID: 46705
		private Table __p;
	}
}
