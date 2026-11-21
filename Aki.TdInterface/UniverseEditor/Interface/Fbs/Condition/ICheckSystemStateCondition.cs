using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005028 RID: 20520
	public struct ICheckSystemStateCondition : IFlatbufferObject
	{
		// Token: 0x170092D6 RID: 37590
		// (get) Token: 0x060200AD RID: 131245 RVA: 0x00471EF8 File Offset: 0x004700F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060200AE RID: 131246 RVA: 0x00471F05 File Offset: 0x00470105
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060200AF RID: 131247 RVA: 0x00471F0C File Offset: 0x0047010C
		public static ICheckSystemStateCondition GetRootAsICheckSystemStateCondition(ByteBuffer _bb)
		{
			return ICheckSystemStateCondition.GetRootAsICheckSystemStateCondition(_bb, default(ICheckSystemStateCondition));
		}

		// Token: 0x060200B0 RID: 131248 RVA: 0x00471F28 File Offset: 0x00470128
		public static ICheckSystemStateCondition GetRootAsICheckSystemStateCondition(ByteBuffer _bb, ICheckSystemStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060200B1 RID: 131249 RVA: 0x00471F45 File Offset: 0x00470145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060200B2 RID: 131250 RVA: 0x00471F54 File Offset: 0x00470154
		public ICheckSystemStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092D7 RID: 37591
		// (get) Token: 0x060200B3 RID: 131251 RVA: 0x00471F64 File Offset: 0x00470164
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

		// Token: 0x170092D8 RID: 37592
		// (get) Token: 0x060200B4 RID: 131252 RVA: 0x00471FA0 File Offset: 0x004701A0
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

		// Token: 0x060200B5 RID: 131253 RVA: 0x00471FDC File Offset: 0x004701DC
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060200B6 RID: 131254 RVA: 0x00472020 File Offset: 0x00470220
		public ICheckCollectionShopState ConfigAsICheckCollectionShopState()
		{
			return this.Config<ICheckCollectionShopState>().Value;
		}

		// Token: 0x060200B7 RID: 131255 RVA: 0x0047203C File Offset: 0x0047023C
		public ICheckCoopRoleCoopLevel ConfigAsICheckCoopRoleCoopLevel()
		{
			return this.Config<ICheckCoopRoleCoopLevel>().Value;
		}

		// Token: 0x060200B8 RID: 131256 RVA: 0x00472058 File Offset: 0x00470258
		public ICheckDangoBrawlChallengeComplete ConfigAsICheckDangoBrawlChallengeComplete()
		{
			return this.Config<ICheckDangoBrawlChallengeComplete>().Value;
		}

		// Token: 0x060200B9 RID: 131257 RVA: 0x00472074 File Offset: 0x00470274
		public ICheckDropCatchGameplayCompleteLevel ConfigAsICheckDropCatchGameplayCompleteLevel()
		{
			return this.Config<ICheckDropCatchGameplayCompleteLevel>().Value;
		}

		// Token: 0x060200BA RID: 131258 RVA: 0x00472090 File Offset: 0x00470290
		public ICheckEncircleLevelComplete ConfigAsICheckEncircleLevelComplete()
		{
			return this.Config<ICheckEncircleLevelComplete>().Value;
		}

		// Token: 0x060200BB RID: 131259 RVA: 0x004720AC File Offset: 0x004702AC
		public ICheckHandBookPageComplete ConfigAsICheckHandBookPageComplete()
		{
			return this.Config<ICheckHandBookPageComplete>().Value;
		}

		// Token: 0x060200BC RID: 131260 RVA: 0x004720C8 File Offset: 0x004702C8
		public ICheckInfrActivityExp ConfigAsICheckInfrActivityExp()
		{
			return this.Config<ICheckInfrActivityExp>().Value;
		}

		// Token: 0x060200BD RID: 131261 RVA: 0x004720E4 File Offset: 0x004702E4
		public ICheckInfrastructureStage ConfigAsICheckInfrastructureStage()
		{
			return this.Config<ICheckInfrastructureStage>().Value;
		}

		// Token: 0x060200BE RID: 131262 RVA: 0x00472100 File Offset: 0x00470300
		public ICheckMoonBuildingState ConfigAsICheckMoonBuildingState()
		{
			return this.Config<ICheckMoonBuildingState>().Value;
		}

		// Token: 0x060200BF RID: 131263 RVA: 0x0047211C File Offset: 0x0047031C
		public ICheckRhythmSpaceshipReachLevelRank ConfigAsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.Config<ICheckRhythmSpaceshipReachLevelRank>().Value;
		}

		// Token: 0x060200C0 RID: 131264 RVA: 0x00472138 File Offset: 0x00470338
		public ICheckRoadBuildState ConfigAsICheckRoadBuildState()
		{
			return this.Config<ICheckRoadBuildState>().Value;
		}

		// Token: 0x060200C1 RID: 131265 RVA: 0x00472154 File Offset: 0x00470354
		public ICheckRogueState ConfigAsICheckRogueState()
		{
			return this.Config<ICheckRogueState>().Value;
		}

		// Token: 0x060200C2 RID: 131266 RVA: 0x00472170 File Offset: 0x00470370
		public ICheckSpringFestivalAtmosphereLevel ConfigAsICheckSpringFestivalAtmosphereLevel()
		{
			return this.Config<ICheckSpringFestivalAtmosphereLevel>().Value;
		}

		// Token: 0x060200C3 RID: 131267 RVA: 0x0047218C File Offset: 0x0047038C
		public ICheckSpringFestivalGuessJokerFirstComplete ConfigAsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.Config<ICheckSpringFestivalGuessJokerFirstComplete>().Value;
		}

		// Token: 0x060200C4 RID: 131268 RVA: 0x004721A8 File Offset: 0x004703A8
		public ICheckSunSpiritDeliveryLevel ConfigAsICheckSunSpiritDeliveryLevel()
		{
			return this.Config<ICheckSunSpiritDeliveryLevel>().Value;
		}

		// Token: 0x060200C5 RID: 131269 RVA: 0x004721C4 File Offset: 0x004703C4
		public ICheckTrackMoonPopularity ConfigAsICheckTrackMoonPopularity()
		{
			return this.Config<ICheckTrackMoonPopularity>().Value;
		}

		// Token: 0x060200C6 RID: 131270 RVA: 0x004721E0 File Offset: 0x004703E0
		public ICheckVillageInfrLevel ConfigAsICheckVillageInfrLevel()
		{
			return this.Config<ICheckVillageInfrLevel>().Value;
		}

		// Token: 0x060200C7 RID: 131271 RVA: 0x004721FC File Offset: 0x004703FC
		public ICheckVillageInfrTreeBuildState ConfigAsICheckVillageInfrTreeBuildState()
		{
			return this.Config<ICheckVillageInfrTreeBuildState>().Value;
		}

		// Token: 0x060200C8 RID: 131272 RVA: 0x00472217 File Offset: 0x00470417
		public static Offset<ICheckSystemStateCondition> CreateICheckSystemStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckSystemState Config_type = TCheckSystemState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ICheckSystemStateCondition.AddConfig(builder, ConfigOffset);
			ICheckSystemStateCondition.AddConfigType(builder, Config_type);
			ICheckSystemStateCondition.AddType(builder, Type);
			return ICheckSystemStateCondition.EndICheckSystemStateCondition(builder);
		}

		// Token: 0x060200C9 RID: 131273 RVA: 0x0047223B File Offset: 0x0047043B
		public static void StartICheckSystemStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060200CA RID: 131274 RVA: 0x00472244 File Offset: 0x00470444
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060200CB RID: 131275 RVA: 0x0047224F File Offset: 0x0047044F
		public static void AddConfigType(FlatBufferBuilder builder, TCheckSystemState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x060200CC RID: 131276 RVA: 0x0047225A File Offset: 0x0047045A
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x060200CD RID: 131277 RVA: 0x00472265 File Offset: 0x00470465
		public static Offset<ICheckSystemStateCondition> EndICheckSystemStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemStateCondition>(builder.EndTable());
		}

		// Token: 0x060200CE RID: 131278 RVA: 0x00472274 File Offset: 0x00470474
		public ICheckSystemStateConditionT UnPack()
		{
			ICheckSystemStateConditionT checkSystemStateConditionT = new ICheckSystemStateConditionT();
			this.UnPackTo(checkSystemStateConditionT);
			return checkSystemStateConditionT;
		}

		// Token: 0x060200CF RID: 131279 RVA: 0x00472290 File Offset: 0x00470490
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
			case TCheckSystemState.ICheckHandBookPageComplete:
				_o.Config.Value = ((this.Config<ICheckHandBookPageComplete>() != null) ? this.Config<ICheckHandBookPageComplete>().Value.UnPack() : null);
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

		// Token: 0x060200D0 RID: 131280 RVA: 0x00472708 File Offset: 0x00470908
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

		// Token: 0x0400DEE9 RID: 57065
		private Table __p;
	}
}
