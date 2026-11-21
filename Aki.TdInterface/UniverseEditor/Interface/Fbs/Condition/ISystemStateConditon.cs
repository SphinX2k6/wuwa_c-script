using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D8 RID: 20952
	public struct ISystemStateConditon : IFlatbufferObject
	{
		// Token: 0x1700960E RID: 38414
		// (get) Token: 0x06020FDF RID: 135135 RVA: 0x0048F878 File Offset: 0x0048DA78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FE0 RID: 135136 RVA: 0x0048F885 File Offset: 0x0048DA85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FE1 RID: 135137 RVA: 0x0048F88C File Offset: 0x0048DA8C
		public static ISystemStateConditon GetRootAsISystemStateConditon(ByteBuffer _bb)
		{
			return ISystemStateConditon.GetRootAsISystemStateConditon(_bb, default(ISystemStateConditon));
		}

		// Token: 0x06020FE2 RID: 135138 RVA: 0x0048F8A8 File Offset: 0x0048DAA8
		public static ISystemStateConditon GetRootAsISystemStateConditon(ByteBuffer _bb, ISystemStateConditon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FE3 RID: 135139 RVA: 0x0048F8C5 File Offset: 0x0048DAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FE4 RID: 135140 RVA: 0x0048F8D4 File Offset: 0x0048DAD4
		public ISystemStateConditon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700960F RID: 38415
		// (get) Token: 0x06020FE5 RID: 135141 RVA: 0x0048F8E4 File Offset: 0x0048DAE4
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

		// Token: 0x17009610 RID: 38416
		// (get) Token: 0x06020FE6 RID: 135142 RVA: 0x0048F920 File Offset: 0x0048DB20
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

		// Token: 0x06020FE7 RID: 135143 RVA: 0x0048F95C File Offset: 0x0048DB5C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020FE8 RID: 135144 RVA: 0x0048F9A0 File Offset: 0x0048DBA0
		public ICheckCollectionShopState ConfigAsICheckCollectionShopState()
		{
			return this.Config<ICheckCollectionShopState>().Value;
		}

		// Token: 0x06020FE9 RID: 135145 RVA: 0x0048F9BC File Offset: 0x0048DBBC
		public ICheckCoopRoleCoopLevel ConfigAsICheckCoopRoleCoopLevel()
		{
			return this.Config<ICheckCoopRoleCoopLevel>().Value;
		}

		// Token: 0x06020FEA RID: 135146 RVA: 0x0048F9D8 File Offset: 0x0048DBD8
		public ICheckDangoBrawlChallengeComplete ConfigAsICheckDangoBrawlChallengeComplete()
		{
			return this.Config<ICheckDangoBrawlChallengeComplete>().Value;
		}

		// Token: 0x06020FEB RID: 135147 RVA: 0x0048F9F4 File Offset: 0x0048DBF4
		public ICheckDropCatchGameplayCompleteLevel ConfigAsICheckDropCatchGameplayCompleteLevel()
		{
			return this.Config<ICheckDropCatchGameplayCompleteLevel>().Value;
		}

		// Token: 0x06020FEC RID: 135148 RVA: 0x0048FA10 File Offset: 0x0048DC10
		public ICheckEncircleLevelComplete ConfigAsICheckEncircleLevelComplete()
		{
			return this.Config<ICheckEncircleLevelComplete>().Value;
		}

		// Token: 0x06020FED RID: 135149 RVA: 0x0048FA2C File Offset: 0x0048DC2C
		public ICheckHandBookPageComplete ConfigAsICheckHandBookPageComplete()
		{
			return this.Config<ICheckHandBookPageComplete>().Value;
		}

		// Token: 0x06020FEE RID: 135150 RVA: 0x0048FA48 File Offset: 0x0048DC48
		public ICheckInfrActivityExp ConfigAsICheckInfrActivityExp()
		{
			return this.Config<ICheckInfrActivityExp>().Value;
		}

		// Token: 0x06020FEF RID: 135151 RVA: 0x0048FA64 File Offset: 0x0048DC64
		public ICheckInfrastructureStage ConfigAsICheckInfrastructureStage()
		{
			return this.Config<ICheckInfrastructureStage>().Value;
		}

		// Token: 0x06020FF0 RID: 135152 RVA: 0x0048FA80 File Offset: 0x0048DC80
		public ICheckMoonBuildingState ConfigAsICheckMoonBuildingState()
		{
			return this.Config<ICheckMoonBuildingState>().Value;
		}

		// Token: 0x06020FF1 RID: 135153 RVA: 0x0048FA9C File Offset: 0x0048DC9C
		public ICheckRhythmSpaceshipReachLevelRank ConfigAsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.Config<ICheckRhythmSpaceshipReachLevelRank>().Value;
		}

		// Token: 0x06020FF2 RID: 135154 RVA: 0x0048FAB8 File Offset: 0x0048DCB8
		public ICheckRoadBuildState ConfigAsICheckRoadBuildState()
		{
			return this.Config<ICheckRoadBuildState>().Value;
		}

		// Token: 0x06020FF3 RID: 135155 RVA: 0x0048FAD4 File Offset: 0x0048DCD4
		public ICheckRogueState ConfigAsICheckRogueState()
		{
			return this.Config<ICheckRogueState>().Value;
		}

		// Token: 0x06020FF4 RID: 135156 RVA: 0x0048FAF0 File Offset: 0x0048DCF0
		public ICheckSpringFestivalAtmosphereLevel ConfigAsICheckSpringFestivalAtmosphereLevel()
		{
			return this.Config<ICheckSpringFestivalAtmosphereLevel>().Value;
		}

		// Token: 0x06020FF5 RID: 135157 RVA: 0x0048FB0C File Offset: 0x0048DD0C
		public ICheckSpringFestivalGuessJokerFirstComplete ConfigAsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.Config<ICheckSpringFestivalGuessJokerFirstComplete>().Value;
		}

		// Token: 0x06020FF6 RID: 135158 RVA: 0x0048FB28 File Offset: 0x0048DD28
		public ICheckSunSpiritDeliveryLevel ConfigAsICheckSunSpiritDeliveryLevel()
		{
			return this.Config<ICheckSunSpiritDeliveryLevel>().Value;
		}

		// Token: 0x06020FF7 RID: 135159 RVA: 0x0048FB44 File Offset: 0x0048DD44
		public ICheckTrackMoonPopularity ConfigAsICheckTrackMoonPopularity()
		{
			return this.Config<ICheckTrackMoonPopularity>().Value;
		}

		// Token: 0x06020FF8 RID: 135160 RVA: 0x0048FB60 File Offset: 0x0048DD60
		public ICheckVillageInfrLevel ConfigAsICheckVillageInfrLevel()
		{
			return this.Config<ICheckVillageInfrLevel>().Value;
		}

		// Token: 0x06020FF9 RID: 135161 RVA: 0x0048FB7C File Offset: 0x0048DD7C
		public ICheckVillageInfrTreeBuildState ConfigAsICheckVillageInfrTreeBuildState()
		{
			return this.Config<ICheckVillageInfrTreeBuildState>().Value;
		}

		// Token: 0x06020FFA RID: 135162 RVA: 0x0048FB97 File Offset: 0x0048DD97
		public static Offset<ISystemStateConditon> CreateISystemStateConditon(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, TCheckSystemState Config_type = TCheckSystemState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISystemStateConditon.AddConfig(builder, ConfigOffset);
			ISystemStateConditon.AddConfigType(builder, Config_type);
			ISystemStateConditon.AddType(builder, Type);
			return ISystemStateConditon.EndISystemStateConditon(builder);
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x0048FBBB File Offset: 0x0048DDBB
		public static void StartISystemStateConditon(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x0048FBC4 File Offset: 0x0048DDC4
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FFD RID: 135165 RVA: 0x0048FBCF File Offset: 0x0048DDCF
		public static void AddConfigType(FlatBufferBuilder builder, TCheckSystemState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06020FFE RID: 135166 RVA: 0x0048FBDA File Offset: 0x0048DDDA
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06020FFF RID: 135167 RVA: 0x0048FBE5 File Offset: 0x0048DDE5
		public static Offset<ISystemStateConditon> EndISystemStateConditon(FlatBufferBuilder builder)
		{
			return new Offset<ISystemStateConditon>(builder.EndTable());
		}

		// Token: 0x06021000 RID: 135168 RVA: 0x0048FBF4 File Offset: 0x0048DDF4
		public ISystemStateConditonT UnPack()
		{
			ISystemStateConditonT systemStateConditonT = new ISystemStateConditonT();
			this.UnPackTo(systemStateConditonT);
			return systemStateConditonT;
		}

		// Token: 0x06021001 RID: 135169 RVA: 0x0048FC10 File Offset: 0x0048DE10
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

		// Token: 0x06021002 RID: 135170 RVA: 0x00490088 File Offset: 0x0048E288
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

		// Token: 0x0400E1DA RID: 57818
		private Table __p;
	}
}
