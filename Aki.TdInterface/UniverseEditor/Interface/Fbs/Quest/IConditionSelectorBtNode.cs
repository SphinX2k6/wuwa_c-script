using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C9 RID: 16841
	public struct IConditionSelectorBtNode : IFlatbufferObject
	{
		// Token: 0x17007270 RID: 29296
		// (get) Token: 0x060174C4 RID: 95428 RVA: 0x0035371F File Offset: 0x0035191F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060174C5 RID: 95429 RVA: 0x0035372C File Offset: 0x0035192C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060174C6 RID: 95430 RVA: 0x00353734 File Offset: 0x00351934
		public static IConditionSelectorBtNode GetRootAsIConditionSelectorBtNode(ByteBuffer _bb)
		{
			return IConditionSelectorBtNode.GetRootAsIConditionSelectorBtNode(_bb, default(IConditionSelectorBtNode));
		}

		// Token: 0x060174C7 RID: 95431 RVA: 0x00353750 File Offset: 0x00351950
		public static IConditionSelectorBtNode GetRootAsIConditionSelectorBtNode(ByteBuffer _bb, IConditionSelectorBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060174C8 RID: 95432 RVA: 0x0035376D File Offset: 0x0035196D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060174C9 RID: 95433 RVA: 0x0035377C File Offset: 0x0035197C
		public IConditionSelectorBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007271 RID: 29297
		// (get) Token: 0x060174CA RID: 95434 RVA: 0x0035378C File Offset: 0x0035198C
		public EBtNode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBtNode.Start;
				}
				return (EBtNode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007272 RID: 29298
		// (get) Token: 0x060174CB RID: 95435 RVA: 0x003537C8 File Offset: 0x003519C8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007273 RID: 29299
		// (get) Token: 0x060174CC RID: 95436 RVA: 0x00353804 File Offset: 0x00351A04
		public string Desc
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

		// Token: 0x060174CD RID: 95437 RVA: 0x0035383B File Offset: 0x00351A3B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060174CE RID: 95438 RVA: 0x0035384A File Offset: 0x00351A4A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007274 RID: 29300
		// (get) Token: 0x060174CF RID: 95439 RVA: 0x00353858 File Offset: 0x00351A58
		public IFixProcessor? FixProcessor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFixProcessor?(default(IFixProcessor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007275 RID: 29301
		// (get) Token: 0x060174D0 RID: 95440 RVA: 0x003538B8 File Offset: 0x00351AB8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007276 RID: 29302
		// (get) Token: 0x060174D1 RID: 95441 RVA: 0x003538F8 File Offset: 0x00351AF8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007277 RID: 29303
		// (get) Token: 0x060174D2 RID: 95442 RVA: 0x00353938 File Offset: 0x00351B38
		public IQuestScheduleConfig? UIConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IQuestScheduleConfig?(default(IQuestScheduleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007278 RID: 29304
		// (get) Token: 0x060174D3 RID: 95443 RVA: 0x00353998 File Offset: 0x00351B98
		public IInformationViewConfig? InformationView
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IInformationViewConfig?(default(IInformationViewConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007279 RID: 29305
		// (get) Token: 0x060174D4 RID: 95444 RVA: 0x003539F8 File Offset: 0x00351BF8
		public IInformationBoardConfig? InformationBoard
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IInformationBoardConfig?(default(IInformationBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700727A RID: 29306
		// (get) Token: 0x060174D5 RID: 95445 RVA: 0x00353A58 File Offset: 0x00351C58
		public string TidQuestAliasName
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060174D6 RID: 95446 RVA: 0x00353A90 File Offset: 0x00351C90
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x00353AA0 File Offset: 0x00351CA0
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700727B RID: 29307
		// (get) Token: 0x060174D8 RID: 95448 RVA: 0x00353AB0 File Offset: 0x00351CB0
		public string TidQuestAliasDesc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x00353AE8 File Offset: 0x00351CE8
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060174DA RID: 95450 RVA: 0x00353AF8 File Offset: 0x00351CF8
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x1700727C RID: 29308
		// (get) Token: 0x060174DB RID: 95451 RVA: 0x00353B08 File Offset: 0x00351D08
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700727D RID: 29309
		// (get) Token: 0x060174DC RID: 95452 RVA: 0x00353B48 File Offset: 0x00351D48
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700727E RID: 29310
		// (get) Token: 0x060174DD RID: 95453 RVA: 0x00353B88 File Offset: 0x00351D88
		public ISaveConfig? SaveConfig
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new ISaveConfig?(default(ISaveConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700727F RID: 29311
		// (get) Token: 0x060174DE RID: 95454 RVA: 0x00353BE8 File Offset: 0x00351DE8
		public IForceClosedRestriction? ForceClosedRestriction
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IForceClosedRestriction?(default(IForceClosedRestriction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060174DF RID: 95455 RVA: 0x00353C48 File Offset: 0x00351E48
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007280 RID: 29312
		// (get) Token: 0x060174E0 RID: 95456 RVA: 0x00353C84 File Offset: 0x00351E84
		public int OccupationsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007281 RID: 29313
		// (get) Token: 0x060174E1 RID: 95457 RVA: 0x00353CB0 File Offset: 0x00351EB0
		public ILogicNodeOccupation? OccupationConfig
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new ILogicNodeOccupation?(default(ILogicNodeOccupation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007282 RID: 29314
		// (get) Token: 0x060174E2 RID: 95458 RVA: 0x00353D10 File Offset: 0x00351F10
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007283 RID: 29315
		// (get) Token: 0x060174E3 RID: 95459 RVA: 0x00353D50 File Offset: 0x00351F50
		public EBudgetCameraType BudgetCameraType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return EBudgetCameraType.Role;
				}
				return (EBudgetCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007284 RID: 29316
		// (get) Token: 0x060174E4 RID: 95460 RVA: 0x00353D90 File Offset: 0x00351F90
		public IQuestStatistics? Statistics
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new IQuestStatistics?(default(IQuestStatistics).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007285 RID: 29317
		// (get) Token: 0x060174E5 RID: 95461 RVA: 0x00353DF0 File Offset: 0x00351FF0
		public ETrackViewMode CompositeTrackViewMode
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return ETrackViewMode.All;
				}
				return (ETrackViewMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007286 RID: 29318
		// (get) Token: 0x060174E6 RID: 95462 RVA: 0x00353E30 File Offset: 0x00352030
		public IQuestRewardConfig? RewardConfig
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IQuestRewardConfig?(default(IQuestRewardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007287 RID: 29319
		// (get) Token: 0x060174E7 RID: 95463 RVA: 0x00353E90 File Offset: 0x00352090
		public TSpecialGamePlayConfig SpecialGamePlayConfigType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return TSpecialGamePlayConfig.NONE;
				}
				return (TSpecialGamePlayConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060174E8 RID: 95464 RVA: 0x00353ED0 File Offset: 0x003520D0
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060174E9 RID: 95465 RVA: 0x00353F18 File Offset: 0x00352118
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x060174EA RID: 95466 RVA: 0x00353F34 File Offset: 0x00352134
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x060174EB RID: 95467 RVA: 0x00353F50 File Offset: 0x00352150
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x060174EC RID: 95468 RVA: 0x00353F6C File Offset: 0x0035216C
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17007288 RID: 29320
		// (get) Token: 0x060174ED RID: 95469 RVA: 0x00353F88 File Offset: 0x00352188
		public TEnableSystemConfig EnableSystemType
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return TEnableSystemConfig.NONE;
				}
				return (TEnableSystemConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060174EE RID: 95470 RVA: 0x00353FC8 File Offset: 0x003521C8
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060174EF RID: 95471 RVA: 0x00354010 File Offset: 0x00352210
		public IDarkTideSystemConfig EnableSystemAsIDarkTideSystemConfig()
		{
			return this.EnableSystem<IDarkTideSystemConfig>().Value;
		}

		// Token: 0x060174F0 RID: 95472 RVA: 0x0035402C File Offset: 0x0035222C
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x060174F1 RID: 95473 RVA: 0x00354048 File Offset: 0x00352248
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x060174F2 RID: 95474 RVA: 0x00354064 File Offset: 0x00352264
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x060174F3 RID: 95475 RVA: 0x00354080 File Offset: 0x00352280
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x060174F4 RID: 95476 RVA: 0x0035409C File Offset: 0x0035229C
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x060174F5 RID: 95477 RVA: 0x003540B8 File Offset: 0x003522B8
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x060174F6 RID: 95478 RVA: 0x003540D4 File Offset: 0x003522D4
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x060174F7 RID: 95479 RVA: 0x003540F0 File Offset: 0x003522F0
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x060174F8 RID: 95480 RVA: 0x0035410C File Offset: 0x0035230C
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x060174F9 RID: 95481 RVA: 0x00354128 File Offset: 0x00352328
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x060174FA RID: 95482 RVA: 0x00354144 File Offset: 0x00352344
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x060174FB RID: 95483 RVA: 0x00354160 File Offset: 0x00352360
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x060174FC RID: 95484 RVA: 0x0035417C File Offset: 0x0035237C
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x060174FD RID: 95485 RVA: 0x00354198 File Offset: 0x00352398
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17007289 RID: 29321
		// (get) Token: 0x060174FE RID: 95486 RVA: 0x003541B4 File Offset: 0x003523B4
		public IWaveConfig? StartWave
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IWaveConfig?(default(IWaveConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700728A RID: 29322
		// (get) Token: 0x060174FF RID: 95487 RVA: 0x00354214 File Offset: 0x00352414
		public IDisableTrackAnim? DisableTrackAnim
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new IDisableTrackAnim?(default(IDisableTrackAnim).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700728B RID: 29323
		// (get) Token: 0x06017500 RID: 95488 RVA: 0x00354274 File Offset: 0x00352474
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700728C RID: 29324
		// (get) Token: 0x06017501 RID: 95489 RVA: 0x003542B4 File Offset: 0x003524B4
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700728D RID: 29325
		// (get) Token: 0x06017502 RID: 95490 RVA: 0x003542F4 File Offset: 0x003524F4
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700728E RID: 29326
		// (get) Token: 0x06017503 RID: 95491 RVA: 0x00354334 File Offset: 0x00352534
		public ILogicProgramSpecialProcess? LogicProgramSpecialProcess
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new ILogicProgramSpecialProcess?(default(ILogicProgramSpecialProcess).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700728F RID: 29327
		// (get) Token: 0x06017504 RID: 95492 RVA: 0x00354394 File Offset: 0x00352594
		public IQuestBuffActiveRange? QuestBuffActiveRange
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return new IQuestBuffActiveRange?(default(IQuestBuffActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007290 RID: 29328
		// (get) Token: 0x06017505 RID: 95493 RVA: 0x003543F4 File Offset: 0x003525F4
		public ISunSpiritProcess? SunSpiritProcess
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return new ISunSpiritProcess?(default(ISunSpiritProcess).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007291 RID: 29329
		// (get) Token: 0x06017506 RID: 95494 RVA: 0x00354454 File Offset: 0x00352654
		public ITrackAreaText? ModifyTrackAreaText
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return new ITrackAreaText?(default(ITrackAreaText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007292 RID: 29330
		// (get) Token: 0x06017507 RID: 95495 RVA: 0x003544B4 File Offset: 0x003526B4
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017508 RID: 95496 RVA: 0x003544F4 File Offset: 0x003526F4
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007293 RID: 29331
		// (get) Token: 0x06017509 RID: 95497 RVA: 0x00354558 File Offset: 0x00352758
		public int DisableSystemPromptLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007294 RID: 29332
		// (get) Token: 0x0601750A RID: 95498 RVA: 0x00354584 File Offset: 0x00352784
		public ITrackCustomBoardOnBtLogicNode? TrackCustomBoard
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return new ITrackCustomBoardOnBtLogicNode?(default(ITrackCustomBoardOnBtLogicNode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007295 RID: 29333
		// (get) Token: 0x0601750B RID: 95499 RVA: 0x003545E4 File Offset: 0x003527E4
		public bool PendingClientResults
		{
			get
			{
				int num = this.__p.__offset(80);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601750C RID: 95500 RVA: 0x00354624 File Offset: 0x00352824
		public IConditionSelectorBtNodeSlot? Slots(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new IConditionSelectorBtNodeSlot?(default(IConditionSelectorBtNodeSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007296 RID: 29334
		// (get) Token: 0x0601750D RID: 95501 RVA: 0x00354688 File Offset: 0x00352888
		public int SlotsLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007297 RID: 29335
		// (get) Token: 0x0601750E RID: 95502 RVA: 0x003546B4 File Offset: 0x003528B4
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601750F RID: 95503 RVA: 0x003546F4 File Offset: 0x003528F4
		public static Offset<IConditionSelectorBtNode> CreateIConditionSelectorBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), bool PendingClientResults = false, VectorOffset SlotsOffset = default(VectorOffset), ushort NullMask = 0)
		{
			builder.StartTable(41);
			IConditionSelectorBtNode.AddSlots(builder, SlotsOffset);
			IConditionSelectorBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			IConditionSelectorBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			IConditionSelectorBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			IConditionSelectorBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			IConditionSelectorBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			IConditionSelectorBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			IConditionSelectorBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			IConditionSelectorBtNode.AddStartWave(builder, StartWaveOffset);
			IConditionSelectorBtNode.AddEnableSystem(builder, EnableSystemOffset);
			IConditionSelectorBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			IConditionSelectorBtNode.AddRewardConfig(builder, RewardConfigOffset);
			IConditionSelectorBtNode.AddStatistics(builder, StatisticsOffset);
			IConditionSelectorBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			IConditionSelectorBtNode.AddOccupations(builder, OccupationsOffset);
			IConditionSelectorBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			IConditionSelectorBtNode.AddSaveConfig(builder, SaveConfigOffset);
			IConditionSelectorBtNode.AddDungeonId(builder, DungeonId);
			IConditionSelectorBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			IConditionSelectorBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			IConditionSelectorBtNode.AddInformationBoard(builder, InformationBoardOffset);
			IConditionSelectorBtNode.AddInformationView(builder, InformationViewOffset);
			IConditionSelectorBtNode.AddUIConfig(builder, UIConfigOffset);
			IConditionSelectorBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IConditionSelectorBtNode.AddDesc(builder, DescOffset);
			IConditionSelectorBtNode.AddId(builder, Id);
			IConditionSelectorBtNode.AddNullMask(builder, NullMask);
			IConditionSelectorBtNode.AddPendingClientResults(builder, PendingClientResults);
			IConditionSelectorBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			IConditionSelectorBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			IConditionSelectorBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			IConditionSelectorBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			IConditionSelectorBtNode.AddEnableSystemType(builder, EnableSystem_type);
			IConditionSelectorBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			IConditionSelectorBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			IConditionSelectorBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			IConditionSelectorBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			IConditionSelectorBtNode.AddDisableOnline(builder, DisableOnline);
			IConditionSelectorBtNode.AddDisabled(builder, Disabled);
			IConditionSelectorBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IConditionSelectorBtNode.AddType(builder, Type);
			return IConditionSelectorBtNode.EndIConditionSelectorBtNode(builder);
		}

		// Token: 0x06017510 RID: 95504 RVA: 0x00354854 File Offset: 0x00352A54
		public static void StartIConditionSelectorBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(41);
		}

		// Token: 0x06017511 RID: 95505 RVA: 0x0035485E File Offset: 0x00352A5E
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017512 RID: 95506 RVA: 0x00354869 File Offset: 0x00352A69
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06017513 RID: 95507 RVA: 0x00354874 File Offset: 0x00352A74
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06017514 RID: 95508 RVA: 0x00354884 File Offset: 0x00352A84
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06017515 RID: 95509 RVA: 0x00354894 File Offset: 0x00352A94
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06017516 RID: 95510 RVA: 0x0035489F File Offset: 0x00352A9F
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06017517 RID: 95511 RVA: 0x003548AA File Offset: 0x00352AAA
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x06017518 RID: 95512 RVA: 0x003548BA File Offset: 0x00352ABA
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x06017519 RID: 95513 RVA: 0x003548CA File Offset: 0x00352ACA
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x0601751A RID: 95514 RVA: 0x003548DA File Offset: 0x00352ADA
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x0601751B RID: 95515 RVA: 0x003548EB File Offset: 0x00352AEB
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x0601751C RID: 95516 RVA: 0x003548FC File Offset: 0x00352AFC
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x0601751D RID: 95517 RVA: 0x00354908 File Offset: 0x00352B08
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x0601751E RID: 95518 RVA: 0x00354914 File Offset: 0x00352B14
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x0601751F RID: 95519 RVA: 0x00354925 File Offset: 0x00352B25
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x06017520 RID: 95520 RVA: 0x00354936 File Offset: 0x00352B36
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x06017521 RID: 95521 RVA: 0x00354948 File Offset: 0x00352B48
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x00354988 File Offset: 0x00352B88
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017523 RID: 95523 RVA: 0x003549A2 File Offset: 0x00352BA2
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017524 RID: 95524 RVA: 0x003549C0 File Offset: 0x00352BC0
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017525 RID: 95525 RVA: 0x003549D9 File Offset: 0x00352BD9
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017526 RID: 95526 RVA: 0x003549E4 File Offset: 0x00352BE4
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x06017527 RID: 95527 RVA: 0x003549F5 File Offset: 0x00352BF5
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x06017528 RID: 95528 RVA: 0x00354A01 File Offset: 0x00352C01
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x06017529 RID: 95529 RVA: 0x00354A0D File Offset: 0x00352C0D
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x0601752A RID: 95530 RVA: 0x00354A1E File Offset: 0x00352C1E
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x0601752B RID: 95531 RVA: 0x00354A2A File Offset: 0x00352C2A
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x0601752C RID: 95532 RVA: 0x00354A3B File Offset: 0x00352C3B
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x0601752D RID: 95533 RVA: 0x00354A47 File Offset: 0x00352C47
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x0601752E RID: 95534 RVA: 0x00354A53 File Offset: 0x00352C53
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x0601752F RID: 95535 RVA: 0x00354A5F File Offset: 0x00352C5F
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x06017530 RID: 95536 RVA: 0x00354A6B File Offset: 0x00352C6B
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x06017531 RID: 95537 RVA: 0x00354A7C File Offset: 0x00352C7C
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x06017532 RID: 95538 RVA: 0x00354A8D File Offset: 0x00352C8D
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x06017533 RID: 95539 RVA: 0x00354A99 File Offset: 0x00352C99
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x06017534 RID: 95540 RVA: 0x00354AA5 File Offset: 0x00352CA5
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x06017535 RID: 95541 RVA: 0x00354AB1 File Offset: 0x00352CB1
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x06017536 RID: 95542 RVA: 0x00354AC2 File Offset: 0x00352CC2
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x06017537 RID: 95543 RVA: 0x00354AD3 File Offset: 0x00352CD3
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x06017538 RID: 95544 RVA: 0x00354AE4 File Offset: 0x00352CE4
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x06017539 RID: 95545 RVA: 0x00354AF5 File Offset: 0x00352CF5
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x0601753A RID: 95546 RVA: 0x00354B01 File Offset: 0x00352D01
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x0601753B RID: 95547 RVA: 0x00354B14 File Offset: 0x00352D14
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601753C RID: 95548 RVA: 0x00354B54 File Offset: 0x00352D54
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601753D RID: 95549 RVA: 0x00354B6E File Offset: 0x00352D6E
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601753E RID: 95550 RVA: 0x00354B8C File Offset: 0x00352D8C
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601753F RID: 95551 RVA: 0x00354BA5 File Offset: 0x00352DA5
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017540 RID: 95552 RVA: 0x00354BB0 File Offset: 0x00352DB0
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x00354BC1 File Offset: 0x00352DC1
		public static void AddPendingClientResults(FlatBufferBuilder builder, bool pendingClientResults)
		{
			builder.AddBool(38, pendingClientResults, false);
		}

		// Token: 0x06017542 RID: 95554 RVA: 0x00354BCD File Offset: 0x00352DCD
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
			builder.AddOffset(39, slotsOffset.Value, 0);
		}

		// Token: 0x06017543 RID: 95555 RVA: 0x00354BE0 File Offset: 0x00352DE0
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, Offset<IConditionSelectorBtNodeSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017544 RID: 95556 RVA: 0x00354C20 File Offset: 0x00352E20
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, Offset<IConditionSelectorBtNodeSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017545 RID: 95557 RVA: 0x00354C3A File Offset: 0x00352E3A
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionSelectorBtNodeSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017546 RID: 95558 RVA: 0x00354C58 File Offset: 0x00352E58
		public static VectorOffset CreateSlotsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionSelectorBtNodeSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017547 RID: 95559 RVA: 0x00354C71 File Offset: 0x00352E71
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017548 RID: 95560 RVA: 0x00354C7C File Offset: 0x00352E7C
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(40, nullMask, 0);
		}

		// Token: 0x06017549 RID: 95561 RVA: 0x00354C88 File Offset: 0x00352E88
		public static Offset<IConditionSelectorBtNode> EndIConditionSelectorBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSelectorBtNode>(builder.EndTable());
		}

		// Token: 0x0601754A RID: 95562 RVA: 0x00354C98 File Offset: 0x00352E98
		public IConditionSelectorBtNodeT UnPack()
		{
			IConditionSelectorBtNodeT conditionSelectorBtNodeT = new IConditionSelectorBtNodeT();
			this.UnPackTo(conditionSelectorBtNodeT);
			return conditionSelectorBtNodeT;
		}

		// Token: 0x0601754B RID: 95563 RVA: 0x00354CB4 File Offset: 0x00352EB4
		public void UnPackTo(IConditionSelectorBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.UIConfig = ((this.UIConfig != null) ? this.UIConfig.Value.UnPack() : null);
			_o.InformationView = ((this.InformationView != null) ? this.InformationView.Value.UnPack() : null);
			_o.InformationBoard = ((this.InformationBoard != null) ? this.InformationBoard.Value.UnPack() : null);
			_o.TidQuestAliasName = this.TidQuestAliasName;
			_o.TidQuestAliasDesc = this.TidQuestAliasDesc;
			_o.DungeonId = this.DungeonId;
			_o.DisableOnline = this.DisableOnline;
			_o.SaveConfig = ((this.SaveConfig != null) ? this.SaveConfig.Value.UnPack() : null);
			_o.ForceClosedRestriction = ((this.ForceClosedRestriction != null) ? this.ForceClosedRestriction.Value.UnPack() : null);
			_o.Occupations = new List<string>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add(this.Occupations(i));
			}
			_o.OccupationConfig = ((this.OccupationConfig != null) ? this.OccupationConfig.Value.UnPack() : null);
			_o.DisableSwitchOccupation = this.DisableSwitchOccupation;
			_o.BudgetCameraType = this.BudgetCameraType;
			_o.Statistics = ((this.Statistics != null) ? this.Statistics.Value.UnPack() : null);
			_o.CompositeTrackViewMode = this.CompositeTrackViewMode;
			_o.RewardConfig = ((this.RewardConfig != null) ? this.RewardConfig.Value.UnPack() : null);
			_o.SpecialGamePlayConfig = new TSpecialGamePlayConfigUnion();
			_o.SpecialGamePlayConfig.Type = this.SpecialGamePlayConfigType;
			switch (this.SpecialGamePlayConfigType)
			{
			case TSpecialGamePlayConfig.IEavesdropGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value.UnPack() : null);
				break;
			case TSpecialGamePlayConfig.IStalkingGamePlayConfig:
				_o.SpecialGamePlayConfig.Value = ((this.SpecialGamePlayConfig<IStalkingGamePlayConfig>() != null) ? this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value.UnPack() : null);
				break;
			}
			_o.EnableSystem = new TEnableSystemConfigUnion();
			_o.EnableSystem.Type = this.EnableSystemType;
			switch (this.EnableSystemType)
			{
			case TEnableSystemConfig.IDarkTideSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IDarkTideSystemConfig>() != null) ? this.EnableSystem<IDarkTideSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IFlagChallengeSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IFlagChallengeSystemConfig>() != null) ? this.EnableSystem<IFlagChallengeSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IFlipperSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IFlipperSystemConfig>() != null) ? this.EnableSystem<IFlipperSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IGameDifficultySystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IGameDifficultySystemConfig>() != null) ? this.EnableSystem<IGameDifficultySystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IGradingSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IGradingSystemConfig>() != null) ? this.EnableSystem<IGradingSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IKuroSimpleCombatKillMonsterSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>() != null) ? this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IKurotatoSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IKurotatoSystemConfig>() != null) ? this.EnableSystem<IKurotatoSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ILinkSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ILinkSystemConfig>() != null) ? this.EnableSystem<ILinkSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IMotorFightSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IMotorFightSystemConfig>() != null) ? this.EnableSystem<IMotorFightSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IMotorRacingSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IMotorRacingSystemConfig>() != null) ? this.EnableSystem<IMotorRacingSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.INightmareSettlementSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<INightmareSettlementSystemConfig>() != null) ? this.EnableSystem<INightmareSettlementSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IRogueTowerTrialSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IRogueTowerTrialSystemConfig>() != null) ? this.EnableSystem<IRogueTowerTrialSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.IRoleTowerSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<IRoleTowerSystemConfig>() != null) ? this.EnableSystem<IRoleTowerSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ISurvivorsRougeSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ISurvivorsRougeSystemConfig>() != null) ? this.EnableSystem<ISurvivorsRougeSystemConfig>().Value.UnPack() : null);
				break;
			case TEnableSystemConfig.ITrapDefenseSystemConfig:
				_o.EnableSystem.Value = ((this.EnableSystem<ITrapDefenseSystemConfig>() != null) ? this.EnableSystem<ITrapDefenseSystemConfig>().Value.UnPack() : null);
				break;
			}
			_o.StartWave = ((this.StartWave != null) ? this.StartWave.Value.UnPack() : null);
			_o.DisableTrackAnim = ((this.DisableTrackAnim != null) ? this.DisableTrackAnim.Value.UnPack() : null);
			_o.DisableSwitchGender = this.DisableSwitchGender;
			_o.DisableFocusMode = this.DisableFocusMode;
			_o.DisableSkeletalAnimationCheck = this.DisableSkeletalAnimationCheck;
			_o.LogicProgramSpecialProcess = ((this.LogicProgramSpecialProcess != null) ? this.LogicProgramSpecialProcess.Value.UnPack() : null);
			_o.QuestBuffActiveRange = ((this.QuestBuffActiveRange != null) ? this.QuestBuffActiveRange.Value.UnPack() : null);
			_o.SunSpiritProcess = ((this.SunSpiritProcess != null) ? this.SunSpiritProcess.Value.UnPack() : null);
			_o.ModifyTrackAreaText = ((this.ModifyTrackAreaText != null) ? this.ModifyTrackAreaText.Value.UnPack() : null);
			_o.DisableGlobalTraffic = this.DisableGlobalTraffic;
			_o.DisableSystemPrompt = new List<IAreaNameSystemPromptT>();
			for (int j = 0; j < this.DisableSystemPromptLength; j++)
			{
				_o.DisableSystemPrompt.Add((this.DisableSystemPrompt(j) != null) ? this.DisableSystemPrompt(j).Value.UnPack() : null);
			}
			_o.TrackCustomBoard = ((this.TrackCustomBoard != null) ? this.TrackCustomBoard.Value.UnPack() : null);
			_o.PendingClientResults = this.PendingClientResults;
			_o.Slots = new List<IConditionSelectorBtNodeSlotT>();
			for (int k = 0; k < this.SlotsLength; k++)
			{
				_o.Slots.Add((this.Slots(k) != null) ? this.Slots(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601754C RID: 95564 RVA: 0x003556AC File Offset: 0x003538AC
		public static Offset<IConditionSelectorBtNode> Pack(FlatBufferBuilder builder, IConditionSelectorBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionSelectorBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IQuestScheduleConfig> uiconfigOffset = (_o.UIConfig == null) ? default(Offset<IQuestScheduleConfig>) : IQuestScheduleConfig.Pack(builder, _o.UIConfig);
			Offset<IInformationViewConfig> informationViewOffset = (_o.InformationView == null) ? default(Offset<IInformationViewConfig>) : IInformationViewConfig.Pack(builder, _o.InformationView);
			Offset<IInformationBoardConfig> informationBoardOffset = (_o.InformationBoard == null) ? default(Offset<IInformationBoardConfig>) : IInformationBoardConfig.Pack(builder, _o.InformationBoard);
			StringOffset tidQuestAliasNameOffset = (_o.TidQuestAliasName == null) ? default(StringOffset) : builder.CreateString(_o.TidQuestAliasName);
			StringOffset tidQuestAliasDescOffset = (_o.TidQuestAliasDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidQuestAliasDesc);
			Offset<ISaveConfig> saveConfigOffset = (_o.SaveConfig == null) ? default(Offset<ISaveConfig>) : ISaveConfig.Pack(builder, _o.SaveConfig);
			Offset<IForceClosedRestriction> forceClosedRestrictionOffset = (_o.ForceClosedRestriction == null) ? default(Offset<IForceClosedRestriction>) : IForceClosedRestriction.Pack(builder, _o.ForceClosedRestriction);
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				StringOffset[] array = new StringOffset[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Occupations[i]);
				}
				occupationsOffset = IConditionSelectorBtNode.CreateOccupationsVector(builder, array);
			}
			Offset<ILogicNodeOccupation> occupationConfigOffset = (_o.OccupationConfig == null) ? default(Offset<ILogicNodeOccupation>) : ILogicNodeOccupation.Pack(builder, _o.OccupationConfig);
			Offset<IQuestStatistics> statisticsOffset = (_o.Statistics == null) ? default(Offset<IQuestStatistics>) : IQuestStatistics.Pack(builder, _o.Statistics);
			Offset<IQuestRewardConfig> rewardConfigOffset = (_o.RewardConfig == null) ? default(Offset<IQuestRewardConfig>) : IQuestRewardConfig.Pack(builder, _o.RewardConfig);
			TSpecialGamePlayConfig specialGamePlayConfig_type = (_o.SpecialGamePlayConfig == null) ? TSpecialGamePlayConfig.NONE : _o.SpecialGamePlayConfig.Type;
			int specialGamePlayConfigOffset = (_o.SpecialGamePlayConfig == null) ? 0 : TSpecialGamePlayConfigUnion.Pack(builder, _o.SpecialGamePlayConfig);
			TEnableSystemConfig enableSystem_type = (_o.EnableSystem == null) ? TEnableSystemConfig.NONE : _o.EnableSystem.Type;
			int enableSystemOffset = (_o.EnableSystem == null) ? 0 : TEnableSystemConfigUnion.Pack(builder, _o.EnableSystem);
			Offset<IWaveConfig> startWaveOffset = (_o.StartWave == null) ? default(Offset<IWaveConfig>) : IWaveConfig.Pack(builder, _o.StartWave);
			Offset<IDisableTrackAnim> disableTrackAnimOffset = (_o.DisableTrackAnim == null) ? default(Offset<IDisableTrackAnim>) : IDisableTrackAnim.Pack(builder, _o.DisableTrackAnim);
			Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset = (_o.LogicProgramSpecialProcess == null) ? default(Offset<ILogicProgramSpecialProcess>) : ILogicProgramSpecialProcess.Pack(builder, _o.LogicProgramSpecialProcess);
			Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset = (_o.QuestBuffActiveRange == null) ? default(Offset<IQuestBuffActiveRange>) : IQuestBuffActiveRange.Pack(builder, _o.QuestBuffActiveRange);
			Offset<ISunSpiritProcess> sunSpiritProcessOffset = (_o.SunSpiritProcess == null) ? default(Offset<ISunSpiritProcess>) : ISunSpiritProcess.Pack(builder, _o.SunSpiritProcess);
			Offset<ITrackAreaText> modifyTrackAreaTextOffset = (_o.ModifyTrackAreaText == null) ? default(Offset<ITrackAreaText>) : ITrackAreaText.Pack(builder, _o.ModifyTrackAreaText);
			VectorOffset disableSystemPromptOffset = default(VectorOffset);
			if (_o.DisableSystemPrompt != null)
			{
				Offset<IAreaNameSystemPrompt>[] array2 = new Offset<IAreaNameSystemPrompt>[_o.DisableSystemPrompt.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IAreaNameSystemPrompt.Pack(builder, _o.DisableSystemPrompt[j]);
				}
				disableSystemPromptOffset = IConditionSelectorBtNode.CreateDisableSystemPromptVector(builder, array2);
			}
			Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoardOnBtLogicNode>) : ITrackCustomBoardOnBtLogicNode.Pack(builder, _o.TrackCustomBoard);
			VectorOffset slotsOffset = default(VectorOffset);
			if (_o.Slots != null)
			{
				Offset<IConditionSelectorBtNodeSlot>[] array3 = new Offset<IConditionSelectorBtNodeSlot>[_o.Slots.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IConditionSelectorBtNodeSlot.Pack(builder, _o.Slots[k]);
				}
				slotsOffset = IConditionSelectorBtNode.CreateSlotsVector(builder, array3);
			}
			return IConditionSelectorBtNode.CreateIConditionSelectorBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, _o.PendingClientResults, slotsOffset, _o.NullMask);
		}

		// Token: 0x0400C077 RID: 49271
		private Table __p;
	}
}
