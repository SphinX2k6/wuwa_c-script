using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B41 RID: 19265
	public struct ICheckSystemStateCondition : IFlatbufferObject
	{
		// Token: 0x17008BC6 RID: 35782
		// (get) Token: 0x0601E522 RID: 124194 RVA: 0x0043F74C File Offset: 0x0043D94C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E523 RID: 124195 RVA: 0x0043F759 File Offset: 0x0043D959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E524 RID: 124196 RVA: 0x0043F760 File Offset: 0x0043D960
		public static ICheckSystemStateCondition GetRootAsICheckSystemStateCondition(ByteBuffer _bb)
		{
			return ICheckSystemStateCondition.GetRootAsICheckSystemStateCondition(_bb, default(ICheckSystemStateCondition));
		}

		// Token: 0x0601E525 RID: 124197 RVA: 0x0043F77C File Offset: 0x0043D97C
		public static ICheckSystemStateCondition GetRootAsICheckSystemStateCondition(ByteBuffer _bb, ICheckSystemStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E526 RID: 124198 RVA: 0x0043F799 File Offset: 0x0043D999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E527 RID: 124199 RVA: 0x0043F7A8 File Offset: 0x0043D9A8
		public ICheckSystemStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BC7 RID: 35783
		// (get) Token: 0x0601E528 RID: 124200 RVA: 0x0043F7B8 File Offset: 0x0043D9B8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008BC8 RID: 35784
		// (get) Token: 0x0601E529 RID: 124201 RVA: 0x0043F7F4 File Offset: 0x0043D9F4
		public TCheckSystemState ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckSystemState.NONE;
				}
				return (TCheckSystemState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E52A RID: 124202 RVA: 0x0043F830 File Offset: 0x0043DA30
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E52B RID: 124203 RVA: 0x0043F874 File Offset: 0x0043DA74
		public ICheckCollectionShopState ConfigAsICheckCollectionShopState()
		{
			return this.Config<ICheckCollectionShopState>().Value;
		}

		// Token: 0x0601E52C RID: 124204 RVA: 0x0043F890 File Offset: 0x0043DA90
		public ICheckCoopRoleCoopLevel ConfigAsICheckCoopRoleCoopLevel()
		{
			return this.Config<ICheckCoopRoleCoopLevel>().Value;
		}

		// Token: 0x0601E52D RID: 124205 RVA: 0x0043F8AC File Offset: 0x0043DAAC
		public ICheckDangoBrawlChallengeComplete ConfigAsICheckDangoBrawlChallengeComplete()
		{
			return this.Config<ICheckDangoBrawlChallengeComplete>().Value;
		}

		// Token: 0x0601E52E RID: 124206 RVA: 0x0043F8C8 File Offset: 0x0043DAC8
		public ICheckDropCatchGameplayCompleteLevel ConfigAsICheckDropCatchGameplayCompleteLevel()
		{
			return this.Config<ICheckDropCatchGameplayCompleteLevel>().Value;
		}

		// Token: 0x0601E52F RID: 124207 RVA: 0x0043F8E4 File Offset: 0x0043DAE4
		public ICheckEncircleLevelComplete ConfigAsICheckEncircleLevelComplete()
		{
			return this.Config<ICheckEncircleLevelComplete>().Value;
		}

		// Token: 0x0601E530 RID: 124208 RVA: 0x0043F900 File Offset: 0x0043DB00
		public ICheckInfrActivityExp ConfigAsICheckInfrActivityExp()
		{
			return this.Config<ICheckInfrActivityExp>().Value;
		}

		// Token: 0x0601E531 RID: 124209 RVA: 0x0043F91C File Offset: 0x0043DB1C
		public ICheckInfrastructureStage ConfigAsICheckInfrastructureStage()
		{
			return this.Config<ICheckInfrastructureStage>().Value;
		}

		// Token: 0x0601E532 RID: 124210 RVA: 0x0043F938 File Offset: 0x0043DB38
		public ICheckMoonBuildingState ConfigAsICheckMoonBuildingState()
		{
			return this.Config<ICheckMoonBuildingState>().Value;
		}

		// Token: 0x0601E533 RID: 124211 RVA: 0x0043F954 File Offset: 0x0043DB54
		public ICheckRhythmSpaceshipReachLevelRank ConfigAsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.Config<ICheckRhythmSpaceshipReachLevelRank>().Value;
		}

		// Token: 0x0601E534 RID: 124212 RVA: 0x0043F970 File Offset: 0x0043DB70
		public ICheckRoadBuildState ConfigAsICheckRoadBuildState()
		{
			return this.Config<ICheckRoadBuildState>().Value;
		}

		// Token: 0x0601E535 RID: 124213 RVA: 0x0043F98C File Offset: 0x0043DB8C
		public ICheckRogueState ConfigAsICheckRogueState()
		{
			return this.Config<ICheckRogueState>().Value;
		}

		// Token: 0x0601E536 RID: 124214 RVA: 0x0043F9A8 File Offset: 0x0043DBA8
		public ICheckSpringFestivalAtmosphereLevel ConfigAsICheckSpringFestivalAtmosphereLevel()
		{
			return this.Config<ICheckSpringFestivalAtmosphereLevel>().Value;
		}

		// Token: 0x0601E537 RID: 124215 RVA: 0x0043F9C4 File Offset: 0x0043DBC4
		public ICheckSpringFestivalGuessJokerFirstComplete ConfigAsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.Config<ICheckSpringFestivalGuessJokerFirstComplete>().Value;
		}

		// Token: 0x0601E538 RID: 124216 RVA: 0x0043F9E0 File Offset: 0x0043DBE0
		public ICheckSunSpiritDeliveryLevel ConfigAsICheckSunSpiritDeliveryLevel()
		{
			return this.Config<ICheckSunSpiritDeliveryLevel>().Value;
		}

		// Token: 0x0601E539 RID: 124217 RVA: 0x0043F9FC File Offset: 0x0043DBFC
		public ICheckTrackMoonPopularity ConfigAsICheckTrackMoonPopularity()
		{
			return this.Config<ICheckTrackMoonPopularity>().Value;
		}

		// Token: 0x0601E53A RID: 124218 RVA: 0x0043FA18 File Offset: 0x0043DC18
		public ICheckVillageInfrLevel ConfigAsICheckVillageInfrLevel()
		{
			return this.Config<ICheckVillageInfrLevel>().Value;
		}

		// Token: 0x0601E53B RID: 124219 RVA: 0x0043FA34 File Offset: 0x0043DC34
		public ICheckVillageInfrTreeBuildState ConfigAsICheckVillageInfrTreeBuildState()
		{
			return this.Config<ICheckVillageInfrTreeBuildState>().Value;
		}

		// Token: 0x0601E53C RID: 124220 RVA: 0x0043FA4F File Offset: 0x0043DC4F
		public static Offset<ICheckSystemStateCondition> CreateICheckSystemStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckSystemState Config_type = TCheckSystemState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ICheckSystemStateCondition.AddConfig(builder, ConfigOffset);
			ICheckSystemStateCondition.AddConfigType(builder, Config_type);
			ICheckSystemStateCondition.AddType(builder, Type);
			return ICheckSystemStateCondition.EndICheckSystemStateCondition(builder);
		}

		// Token: 0x0601E53D RID: 124221 RVA: 0x0043FA73 File Offset: 0x0043DC73
		public static void StartICheckSystemStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E53E RID: 124222 RVA: 0x0043FA7C File Offset: 0x0043DC7C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E53F RID: 124223 RVA: 0x0043FA87 File Offset: 0x0043DC87
		public static void AddConfigType(FlatBufferBuilder builder, TCheckSystemState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0601E540 RID: 124224 RVA: 0x0043FA92 File Offset: 0x0043DC92
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0601E541 RID: 124225 RVA: 0x0043FA9D File Offset: 0x0043DC9D
		public static Offset<ICheckSystemStateCondition> EndICheckSystemStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E542 RID: 124226 RVA: 0x0043FAAC File Offset: 0x0043DCAC
		public ICheckSystemStateConditionT UnPack()
		{
			ICheckSystemStateConditionT checkSystemStateConditionT = new ICheckSystemStateConditionT();
			this.UnPackTo(checkSystemStateConditionT);
			return checkSystemStateConditionT;
		}

		// Token: 0x0601E543 RID: 124227 RVA: 0x0043FAC8 File Offset: 0x0043DCC8
		public void UnPackTo(ICheckSystemStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TCheckSystemStateUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TCheckSystemState.ICheckCollectionShopState:
				_o.Config.Value = ((this.Config<ICheckCollectionShopState>() != null) ? this.Config<ICheckCollectionShopState>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckCoopRoleCoopLevel:
				_o.Config.Value = ((this.Config<ICheckCoopRoleCoopLevel>() != null) ? this.Config<ICheckCoopRoleCoopLevel>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckDangoBrawlChallengeComplete:
				_o.Config.Value = ((this.Config<ICheckDangoBrawlChallengeComplete>() != null) ? this.Config<ICheckDangoBrawlChallengeComplete>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckDropCatchGameplayCompleteLevel:
				_o.Config.Value = ((this.Config<ICheckDropCatchGameplayCompleteLevel>() != null) ? this.Config<ICheckDropCatchGameplayCompleteLevel>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckEncircleLevelComplete:
				_o.Config.Value = ((this.Config<ICheckEncircleLevelComplete>() != null) ? this.Config<ICheckEncircleLevelComplete>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckInfrActivityExp:
				_o.Config.Value = ((this.Config<ICheckInfrActivityExp>() != null) ? this.Config<ICheckInfrActivityExp>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckInfrastructureStage:
				_o.Config.Value = ((this.Config<ICheckInfrastructureStage>() != null) ? this.Config<ICheckInfrastructureStage>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckMoonBuildingState:
				_o.Config.Value = ((this.Config<ICheckMoonBuildingState>() != null) ? this.Config<ICheckMoonBuildingState>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckRhythmSpaceshipReachLevelRank:
				_o.Config.Value = ((this.Config<ICheckRhythmSpaceshipReachLevelRank>() != null) ? this.Config<ICheckRhythmSpaceshipReachLevelRank>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckRoadBuildState:
				_o.Config.Value = ((this.Config<ICheckRoadBuildState>() != null) ? this.Config<ICheckRoadBuildState>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckRogueState:
				_o.Config.Value = ((this.Config<ICheckRogueState>() != null) ? this.Config<ICheckRogueState>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckSpringFestivalAtmosphereLevel:
				_o.Config.Value = ((this.Config<ICheckSpringFestivalAtmosphereLevel>() != null) ? this.Config<ICheckSpringFestivalAtmosphereLevel>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckSpringFestivalGuessJokerFirstComplete:
				_o.Config.Value = ((this.Config<ICheckSpringFestivalGuessJokerFirstComplete>() != null) ? this.Config<ICheckSpringFestivalGuessJokerFirstComplete>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckSunSpiritDeliveryLevel:
				_o.Config.Value = ((this.Config<ICheckSunSpiritDeliveryLevel>() != null) ? this.Config<ICheckSunSpiritDeliveryLevel>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckTrackMoonPopularity:
				_o.Config.Value = ((this.Config<ICheckTrackMoonPopularity>() != null) ? this.Config<ICheckTrackMoonPopularity>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckVillageInfrLevel:
				_o.Config.Value = ((this.Config<ICheckVillageInfrLevel>() != null) ? this.Config<ICheckVillageInfrLevel>().Value.UnPack() : null);
				return;
			case TCheckSystemState.ICheckVillageInfrTreeBuildState:
				_o.Config.Value = ((this.Config<ICheckVillageInfrTreeBuildState>() != null) ? this.Config<ICheckVillageInfrTreeBuildState>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601E544 RID: 124228 RVA: 0x0043FF04 File Offset: 0x0043E104
		public static Offset<ICheckSystemStateCondition> Pack(FlatBufferBuilder builder, ICheckSystemStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemStateCondition>);
			}
			TCheckSystemState config_type = (_o.Config == null) ? TCheckSystemState.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TCheckSystemStateUnion.Pack(builder, _o.Config);
			return ICheckSystemStateCondition.CreateICheckSystemStateCondition(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x0400D3EA RID: 54250
		private Table __p;
	}
}
