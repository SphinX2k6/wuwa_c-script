using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CDC RID: 19676
	public struct ISystemStateConditon : IFlatbufferObject
	{
		// Token: 0x17008ED5 RID: 36565
		// (get) Token: 0x0601F39B RID: 127899 RVA: 0x0045B980 File Offset: 0x00459B80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F39C RID: 127900 RVA: 0x0045B98D File Offset: 0x00459B8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F39D RID: 127901 RVA: 0x0045B994 File Offset: 0x00459B94
		public static ISystemStateConditon GetRootAsISystemStateConditon(ByteBuffer _bb)
		{
			return ISystemStateConditon.GetRootAsISystemStateConditon(_bb, default(ISystemStateConditon));
		}

		// Token: 0x0601F39E RID: 127902 RVA: 0x0045B9B0 File Offset: 0x00459BB0
		public static ISystemStateConditon GetRootAsISystemStateConditon(ByteBuffer _bb, ISystemStateConditon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F39F RID: 127903 RVA: 0x0045B9CD File Offset: 0x00459BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3A0 RID: 127904 RVA: 0x0045B9DC File Offset: 0x00459BDC
		public ISystemStateConditon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ED6 RID: 36566
		// (get) Token: 0x0601F3A1 RID: 127905 RVA: 0x0045B9EC File Offset: 0x00459BEC
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ED7 RID: 36567
		// (get) Token: 0x0601F3A2 RID: 127906 RVA: 0x0045BA28 File Offset: 0x00459C28
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

		// Token: 0x0601F3A3 RID: 127907 RVA: 0x0045BA64 File Offset: 0x00459C64
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F3A4 RID: 127908 RVA: 0x0045BAA8 File Offset: 0x00459CA8
		public ICheckCollectionShopState ConfigAsICheckCollectionShopState()
		{
			return this.Config<ICheckCollectionShopState>().Value;
		}

		// Token: 0x0601F3A5 RID: 127909 RVA: 0x0045BAC4 File Offset: 0x00459CC4
		public ICheckCoopRoleCoopLevel ConfigAsICheckCoopRoleCoopLevel()
		{
			return this.Config<ICheckCoopRoleCoopLevel>().Value;
		}

		// Token: 0x0601F3A6 RID: 127910 RVA: 0x0045BAE0 File Offset: 0x00459CE0
		public ICheckDangoBrawlChallengeComplete ConfigAsICheckDangoBrawlChallengeComplete()
		{
			return this.Config<ICheckDangoBrawlChallengeComplete>().Value;
		}

		// Token: 0x0601F3A7 RID: 127911 RVA: 0x0045BAFC File Offset: 0x00459CFC
		public ICheckDropCatchGameplayCompleteLevel ConfigAsICheckDropCatchGameplayCompleteLevel()
		{
			return this.Config<ICheckDropCatchGameplayCompleteLevel>().Value;
		}

		// Token: 0x0601F3A8 RID: 127912 RVA: 0x0045BB18 File Offset: 0x00459D18
		public ICheckEncircleLevelComplete ConfigAsICheckEncircleLevelComplete()
		{
			return this.Config<ICheckEncircleLevelComplete>().Value;
		}

		// Token: 0x0601F3A9 RID: 127913 RVA: 0x0045BB34 File Offset: 0x00459D34
		public ICheckInfrActivityExp ConfigAsICheckInfrActivityExp()
		{
			return this.Config<ICheckInfrActivityExp>().Value;
		}

		// Token: 0x0601F3AA RID: 127914 RVA: 0x0045BB50 File Offset: 0x00459D50
		public ICheckInfrastructureStage ConfigAsICheckInfrastructureStage()
		{
			return this.Config<ICheckInfrastructureStage>().Value;
		}

		// Token: 0x0601F3AB RID: 127915 RVA: 0x0045BB6C File Offset: 0x00459D6C
		public ICheckMoonBuildingState ConfigAsICheckMoonBuildingState()
		{
			return this.Config<ICheckMoonBuildingState>().Value;
		}

		// Token: 0x0601F3AC RID: 127916 RVA: 0x0045BB88 File Offset: 0x00459D88
		public ICheckRhythmSpaceshipReachLevelRank ConfigAsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.Config<ICheckRhythmSpaceshipReachLevelRank>().Value;
		}

		// Token: 0x0601F3AD RID: 127917 RVA: 0x0045BBA4 File Offset: 0x00459DA4
		public ICheckRoadBuildState ConfigAsICheckRoadBuildState()
		{
			return this.Config<ICheckRoadBuildState>().Value;
		}

		// Token: 0x0601F3AE RID: 127918 RVA: 0x0045BBC0 File Offset: 0x00459DC0
		public ICheckRogueState ConfigAsICheckRogueState()
		{
			return this.Config<ICheckRogueState>().Value;
		}

		// Token: 0x0601F3AF RID: 127919 RVA: 0x0045BBDC File Offset: 0x00459DDC
		public ICheckSpringFestivalAtmosphereLevel ConfigAsICheckSpringFestivalAtmosphereLevel()
		{
			return this.Config<ICheckSpringFestivalAtmosphereLevel>().Value;
		}

		// Token: 0x0601F3B0 RID: 127920 RVA: 0x0045BBF8 File Offset: 0x00459DF8
		public ICheckSpringFestivalGuessJokerFirstComplete ConfigAsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.Config<ICheckSpringFestivalGuessJokerFirstComplete>().Value;
		}

		// Token: 0x0601F3B1 RID: 127921 RVA: 0x0045BC14 File Offset: 0x00459E14
		public ICheckSunSpiritDeliveryLevel ConfigAsICheckSunSpiritDeliveryLevel()
		{
			return this.Config<ICheckSunSpiritDeliveryLevel>().Value;
		}

		// Token: 0x0601F3B2 RID: 127922 RVA: 0x0045BC30 File Offset: 0x00459E30
		public ICheckTrackMoonPopularity ConfigAsICheckTrackMoonPopularity()
		{
			return this.Config<ICheckTrackMoonPopularity>().Value;
		}

		// Token: 0x0601F3B3 RID: 127923 RVA: 0x0045BC4C File Offset: 0x00459E4C
		public ICheckVillageInfrLevel ConfigAsICheckVillageInfrLevel()
		{
			return this.Config<ICheckVillageInfrLevel>().Value;
		}

		// Token: 0x0601F3B4 RID: 127924 RVA: 0x0045BC68 File Offset: 0x00459E68
		public ICheckVillageInfrTreeBuildState ConfigAsICheckVillageInfrTreeBuildState()
		{
			return this.Config<ICheckVillageInfrTreeBuildState>().Value;
		}

		// Token: 0x0601F3B5 RID: 127925 RVA: 0x0045BC83 File Offset: 0x00459E83
		public static Offset<ISystemStateConditon> CreateISystemStateConditon(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, TCheckSystemState Config_type = TCheckSystemState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISystemStateConditon.AddConfig(builder, ConfigOffset);
			ISystemStateConditon.AddConfigType(builder, Config_type);
			ISystemStateConditon.AddType(builder, Type);
			return ISystemStateConditon.EndISystemStateConditon(builder);
		}

		// Token: 0x0601F3B6 RID: 127926 RVA: 0x0045BCA7 File Offset: 0x00459EA7
		public static void StartISystemStateConditon(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F3B7 RID: 127927 RVA: 0x0045BCB0 File Offset: 0x00459EB0
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F3B8 RID: 127928 RVA: 0x0045BCBB File Offset: 0x00459EBB
		public static void AddConfigType(FlatBufferBuilder builder, TCheckSystemState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0601F3B9 RID: 127929 RVA: 0x0045BCC6 File Offset: 0x00459EC6
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0601F3BA RID: 127930 RVA: 0x0045BCD1 File Offset: 0x00459ED1
		public static Offset<ISystemStateConditon> EndISystemStateConditon(FlatBufferBuilder builder)
		{
			return new Offset<ISystemStateConditon>(builder.EndTable());
		}

		// Token: 0x0601F3BB RID: 127931 RVA: 0x0045BCE0 File Offset: 0x00459EE0
		public ISystemStateConditonT UnPack()
		{
			ISystemStateConditonT systemStateConditonT = new ISystemStateConditonT();
			this.UnPackTo(systemStateConditonT);
			return systemStateConditonT;
		}

		// Token: 0x0601F3BC RID: 127932 RVA: 0x0045BCFC File Offset: 0x00459EFC
		public void UnPackTo(ISystemStateConditonT _o)
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

		// Token: 0x0601F3BD RID: 127933 RVA: 0x0045C138 File Offset: 0x0045A338
		public static Offset<ISystemStateConditon> Pack(FlatBufferBuilder builder, ISystemStateConditonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemStateConditon>);
			}
			TCheckSystemState config_type = (_o.Config == null) ? TCheckSystemState.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TCheckSystemStateUnion.Pack(builder, _o.Config);
			return ISystemStateConditon.CreateISystemStateConditon(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x0400D6AD RID: 54957
		private Table __p;
	}
}
