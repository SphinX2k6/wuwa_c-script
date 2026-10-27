using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F71 RID: 16241
	public struct IParallelSelectBtNode : IFlatbufferObject
	{
		// Token: 0x17007108 RID: 28936
		// (get) Token: 0x060171E6 RID: 94694 RVA: 0x00354F4F File Offset: 0x0035314F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060171E7 RID: 94695 RVA: 0x00354F5C File Offset: 0x0035315C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060171E8 RID: 94696 RVA: 0x00354F64 File Offset: 0x00353164
		public static IParallelSelectBtNode GetRootAsIParallelSelectBtNode(ByteBuffer _bb)
		{
			return IParallelSelectBtNode.GetRootAsIParallelSelectBtNode(_bb, default(IParallelSelectBtNode));
		}

		// Token: 0x060171E9 RID: 94697 RVA: 0x00354F80 File Offset: 0x00353180
		public static IParallelSelectBtNode GetRootAsIParallelSelectBtNode(ByteBuffer _bb, IParallelSelectBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060171EA RID: 94698 RVA: 0x00354F9D File Offset: 0x0035319D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060171EB RID: 94699 RVA: 0x00354FAC File Offset: 0x003531AC
		public IParallelSelectBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007109 RID: 28937
		// (get) Token: 0x060171EC RID: 94700 RVA: 0x00354FBC File Offset: 0x003531BC
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

		// Token: 0x1700710A RID: 28938
		// (get) Token: 0x060171ED RID: 94701 RVA: 0x00354FF8 File Offset: 0x003531F8
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

		// Token: 0x1700710B RID: 28939
		// (get) Token: 0x060171EE RID: 94702 RVA: 0x00355034 File Offset: 0x00353234
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

		// Token: 0x060171EF RID: 94703 RVA: 0x0035506B File Offset: 0x0035326B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060171F0 RID: 94704 RVA: 0x0035507A File Offset: 0x0035327A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700710C RID: 28940
		// (get) Token: 0x060171F1 RID: 94705 RVA: 0x00355088 File Offset: 0x00353288
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

		// Token: 0x1700710D RID: 28941
		// (get) Token: 0x060171F2 RID: 94706 RVA: 0x003550E8 File Offset: 0x003532E8
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700710E RID: 28942
		// (get) Token: 0x060171F3 RID: 94707 RVA: 0x00355128 File Offset: 0x00353328
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700710F RID: 28943
		// (get) Token: 0x060171F4 RID: 94708 RVA: 0x00355168 File Offset: 0x00353368
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

		// Token: 0x17007110 RID: 28944
		// (get) Token: 0x060171F5 RID: 94709 RVA: 0x003551C8 File Offset: 0x003533C8
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

		// Token: 0x17007111 RID: 28945
		// (get) Token: 0x060171F6 RID: 94710 RVA: 0x00355228 File Offset: 0x00353428
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

		// Token: 0x17007112 RID: 28946
		// (get) Token: 0x060171F7 RID: 94711 RVA: 0x00355288 File Offset: 0x00353488
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

		// Token: 0x060171F8 RID: 94712 RVA: 0x003552C0 File Offset: 0x003534C0
		public Span<byte> GetTidQuestAliasNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060171F9 RID: 94713 RVA: 0x003552D0 File Offset: 0x003534D0
		public byte[] GetTidQuestAliasNameArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17007113 RID: 28947
		// (get) Token: 0x060171FA RID: 94714 RVA: 0x003552E0 File Offset: 0x003534E0
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

		// Token: 0x060171FB RID: 94715 RVA: 0x00355318 File Offset: 0x00353518
		public Span<byte> GetTidQuestAliasDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060171FC RID: 94716 RVA: 0x00355328 File Offset: 0x00353528
		public byte[] GetTidQuestAliasDescArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17007114 RID: 28948
		// (get) Token: 0x060171FD RID: 94717 RVA: 0x00355338 File Offset: 0x00353538
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

		// Token: 0x17007115 RID: 28949
		// (get) Token: 0x060171FE RID: 94718 RVA: 0x00355378 File Offset: 0x00353578
		public bool DisableOnline
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007116 RID: 28950
		// (get) Token: 0x060171FF RID: 94719 RVA: 0x003553B8 File Offset: 0x003535B8
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

		// Token: 0x17007117 RID: 28951
		// (get) Token: 0x06017200 RID: 94720 RVA: 0x00355418 File Offset: 0x00353618
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

		// Token: 0x06017201 RID: 94721 RVA: 0x00355478 File Offset: 0x00353678
		public string Occupations(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007118 RID: 28952
		// (get) Token: 0x06017202 RID: 94722 RVA: 0x003554B4 File Offset: 0x003536B4
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

		// Token: 0x17007119 RID: 28953
		// (get) Token: 0x06017203 RID: 94723 RVA: 0x003554E0 File Offset: 0x003536E0
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

		// Token: 0x1700711A RID: 28954
		// (get) Token: 0x06017204 RID: 94724 RVA: 0x00355540 File Offset: 0x00353740
		public bool DisableSwitchOccupation
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700711B RID: 28955
		// (get) Token: 0x06017205 RID: 94725 RVA: 0x00355580 File Offset: 0x00353780
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

		// Token: 0x1700711C RID: 28956
		// (get) Token: 0x06017206 RID: 94726 RVA: 0x003555C0 File Offset: 0x003537C0
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

		// Token: 0x1700711D RID: 28957
		// (get) Token: 0x06017207 RID: 94727 RVA: 0x00355620 File Offset: 0x00353820
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

		// Token: 0x1700711E RID: 28958
		// (get) Token: 0x06017208 RID: 94728 RVA: 0x00355660 File Offset: 0x00353860
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

		// Token: 0x1700711F RID: 28959
		// (get) Token: 0x06017209 RID: 94729 RVA: 0x003556C0 File Offset: 0x003538C0
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

		// Token: 0x0601720A RID: 94730 RVA: 0x00355700 File Offset: 0x00353900
		public TTable? SpecialGamePlayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601720B RID: 94731 RVA: 0x00355748 File Offset: 0x00353948
		public IEavesdropGamePlayConfig SpecialGamePlayConfigAsIEavesdropGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IEavesdropGamePlayConfig>().Value;
		}

		// Token: 0x0601720C RID: 94732 RVA: 0x00355764 File Offset: 0x00353964
		public IFirstPersonTurretGamePlayConfig SpecialGamePlayConfigAsIFirstPersonTurretGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFirstPersonTurretGamePlayConfig>().Value;
		}

		// Token: 0x0601720D RID: 94733 RVA: 0x00355780 File Offset: 0x00353980
		public IFreezeOnSightGamePlayConfig SpecialGamePlayConfigAsIFreezeOnSightGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IFreezeOnSightGamePlayConfig>().Value;
		}

		// Token: 0x0601720E RID: 94734 RVA: 0x0035579C File Offset: 0x0035399C
		public IStalkingGamePlayConfig SpecialGamePlayConfigAsIStalkingGamePlayConfig()
		{
			return this.SpecialGamePlayConfig<IStalkingGamePlayConfig>().Value;
		}

		// Token: 0x17007120 RID: 28960
		// (get) Token: 0x0601720F RID: 94735 RVA: 0x003557B8 File Offset: 0x003539B8
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

		// Token: 0x06017210 RID: 94736 RVA: 0x003557F8 File Offset: 0x003539F8
		public TTable? EnableSystem<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017211 RID: 94737 RVA: 0x00355840 File Offset: 0x00353A40
		public IFlagChallengeSystemConfig EnableSystemAsIFlagChallengeSystemConfig()
		{
			return this.EnableSystem<IFlagChallengeSystemConfig>().Value;
		}

		// Token: 0x06017212 RID: 94738 RVA: 0x0035585C File Offset: 0x00353A5C
		public IFlipperSystemConfig EnableSystemAsIFlipperSystemConfig()
		{
			return this.EnableSystem<IFlipperSystemConfig>().Value;
		}

		// Token: 0x06017213 RID: 94739 RVA: 0x00355878 File Offset: 0x00353A78
		public IGameDifficultySystemConfig EnableSystemAsIGameDifficultySystemConfig()
		{
			return this.EnableSystem<IGameDifficultySystemConfig>().Value;
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x00355894 File Offset: 0x00353A94
		public IGradingSystemConfig EnableSystemAsIGradingSystemConfig()
		{
			return this.EnableSystem<IGradingSystemConfig>().Value;
		}

		// Token: 0x06017215 RID: 94741 RVA: 0x003558B0 File Offset: 0x00353AB0
		public IKuroSimpleCombatKillMonsterSystemConfig EnableSystemAsIKuroSimpleCombatKillMonsterSystemConfig()
		{
			return this.EnableSystem<IKuroSimpleCombatKillMonsterSystemConfig>().Value;
		}

		// Token: 0x06017216 RID: 94742 RVA: 0x003558CC File Offset: 0x00353ACC
		public IKurotatoSystemConfig EnableSystemAsIKurotatoSystemConfig()
		{
			return this.EnableSystem<IKurotatoSystemConfig>().Value;
		}

		// Token: 0x06017217 RID: 94743 RVA: 0x003558E8 File Offset: 0x00353AE8
		public ILinkSystemConfig EnableSystemAsILinkSystemConfig()
		{
			return this.EnableSystem<ILinkSystemConfig>().Value;
		}

		// Token: 0x06017218 RID: 94744 RVA: 0x00355904 File Offset: 0x00353B04
		public IMotorFightSystemConfig EnableSystemAsIMotorFightSystemConfig()
		{
			return this.EnableSystem<IMotorFightSystemConfig>().Value;
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x00355920 File Offset: 0x00353B20
		public IMotorRacingSystemConfig EnableSystemAsIMotorRacingSystemConfig()
		{
			return this.EnableSystem<IMotorRacingSystemConfig>().Value;
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x0035593C File Offset: 0x00353B3C
		public INightmareSettlementSystemConfig EnableSystemAsINightmareSettlementSystemConfig()
		{
			return this.EnableSystem<INightmareSettlementSystemConfig>().Value;
		}

		// Token: 0x0601721B RID: 94747 RVA: 0x00355958 File Offset: 0x00353B58
		public IRogueTowerTrialSystemConfig EnableSystemAsIRogueTowerTrialSystemConfig()
		{
			return this.EnableSystem<IRogueTowerTrialSystemConfig>().Value;
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x00355974 File Offset: 0x00353B74
		public IRoleTowerSystemConfig EnableSystemAsIRoleTowerSystemConfig()
		{
			return this.EnableSystem<IRoleTowerSystemConfig>().Value;
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x00355990 File Offset: 0x00353B90
		public ISurvivorsRougeSystemConfig EnableSystemAsISurvivorsRougeSystemConfig()
		{
			return this.EnableSystem<ISurvivorsRougeSystemConfig>().Value;
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x003559AC File Offset: 0x00353BAC
		public ITrapDefenseSystemConfig EnableSystemAsITrapDefenseSystemConfig()
		{
			return this.EnableSystem<ITrapDefenseSystemConfig>().Value;
		}

		// Token: 0x17007121 RID: 28961
		// (get) Token: 0x0601721F RID: 94751 RVA: 0x003559C8 File Offset: 0x00353BC8
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

		// Token: 0x17007122 RID: 28962
		// (get) Token: 0x06017220 RID: 94752 RVA: 0x00355A28 File Offset: 0x00353C28
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

		// Token: 0x17007123 RID: 28963
		// (get) Token: 0x06017221 RID: 94753 RVA: 0x00355A88 File Offset: 0x00353C88
		public bool DisableSwitchGender
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007124 RID: 28964
		// (get) Token: 0x06017222 RID: 94754 RVA: 0x00355AC8 File Offset: 0x00353CC8
		public bool DisableFocusMode
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007125 RID: 28965
		// (get) Token: 0x06017223 RID: 94755 RVA: 0x00355B08 File Offset: 0x00353D08
		public bool DisableSkeletalAnimationCheck
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007126 RID: 28966
		// (get) Token: 0x06017224 RID: 94756 RVA: 0x00355B48 File Offset: 0x00353D48
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

		// Token: 0x17007127 RID: 28967
		// (get) Token: 0x06017225 RID: 94757 RVA: 0x00355BA8 File Offset: 0x00353DA8
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

		// Token: 0x17007128 RID: 28968
		// (get) Token: 0x06017226 RID: 94758 RVA: 0x00355C08 File Offset: 0x00353E08
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

		// Token: 0x17007129 RID: 28969
		// (get) Token: 0x06017227 RID: 94759 RVA: 0x00355C68 File Offset: 0x00353E68
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

		// Token: 0x1700712A RID: 28970
		// (get) Token: 0x06017228 RID: 94760 RVA: 0x00355CC8 File Offset: 0x00353EC8
		public bool DisableGlobalTraffic
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017229 RID: 94761 RVA: 0x00355D08 File Offset: 0x00353F08
		public IAreaNameSystemPrompt? DisableSystemPrompt(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IAreaNameSystemPrompt?(default(IAreaNameSystemPrompt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700712B RID: 28971
		// (get) Token: 0x0601722A RID: 94762 RVA: 0x00355D6C File Offset: 0x00353F6C
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

		// Token: 0x1700712C RID: 28972
		// (get) Token: 0x0601722B RID: 94763 RVA: 0x00355D98 File Offset: 0x00353F98
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

		// Token: 0x0601722C RID: 94764 RVA: 0x00355DF8 File Offset: 0x00353FF8
		public TBtNode ChildrenType(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return TBtNode.NONE;
			}
			return (TBtNode)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700712D RID: 28973
		// (get) Token: 0x0601722D RID: 94765 RVA: 0x00355E38 File Offset: 0x00354038
		public int ChildrenTypeLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601722E RID: 94766 RVA: 0x00355E64 File Offset: 0x00354064
		public Span<TBtNode> GetChildrenTypeBytes()
		{
			return this.__p.__vector_as_span<TBtNode>(80, 1);
		}

		// Token: 0x0601722F RID: 94767 RVA: 0x00355E74 File Offset: 0x00354074
		public TBtNode[] GetChildrenTypeArray()
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBtNode[] array = new TBtNode[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBtNode)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06017230 RID: 94768 RVA: 0x00355EE0 File Offset: 0x003540E0
		public TTable? Children<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700712E RID: 28974
		// (get) Token: 0x06017231 RID: 94769 RVA: 0x00355F28 File Offset: 0x00354128
		public int ChildrenLength
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

		// Token: 0x1700712F RID: 28975
		// (get) Token: 0x06017232 RID: 94770 RVA: 0x00355F54 File Offset: 0x00354154
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007130 RID: 28976
		// (get) Token: 0x06017233 RID: 94771 RVA: 0x00355F94 File Offset: 0x00354194
		public IPerformanceSetting? PerformanceSetting
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return new IPerformanceSetting?(default(IPerformanceSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007131 RID: 28977
		// (get) Token: 0x06017234 RID: 94772 RVA: 0x00355FF4 File Offset: 0x003541F4
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017235 RID: 94773 RVA: 0x00356034 File Offset: 0x00354234
		public static Offset<IParallelSelectBtNode> CreateIParallelSelectBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, Offset<IQuestScheduleConfig> UIConfigOffset = default(Offset<IQuestScheduleConfig>), Offset<IInformationViewConfig> InformationViewOffset = default(Offset<IInformationViewConfig>), Offset<IInformationBoardConfig> InformationBoardOffset = default(Offset<IInformationBoardConfig>), StringOffset TidQuestAliasNameOffset = default(StringOffset), StringOffset TidQuestAliasDescOffset = default(StringOffset), int DungeonId = 0, bool DisableOnline = false, Offset<ISaveConfig> SaveConfigOffset = default(Offset<ISaveConfig>), Offset<IForceClosedRestriction> ForceClosedRestrictionOffset = default(Offset<IForceClosedRestriction>), VectorOffset OccupationsOffset = default(VectorOffset), Offset<ILogicNodeOccupation> OccupationConfigOffset = default(Offset<ILogicNodeOccupation>), bool DisableSwitchOccupation = false, EBudgetCameraType BudgetCameraType = EBudgetCameraType.Role, Offset<IQuestStatistics> StatisticsOffset = default(Offset<IQuestStatistics>), ETrackViewMode CompositeTrackViewMode = ETrackViewMode.All, Offset<IQuestRewardConfig> RewardConfigOffset = default(Offset<IQuestRewardConfig>), TSpecialGamePlayConfig SpecialGamePlayConfig_type = TSpecialGamePlayConfig.NONE, int SpecialGamePlayConfigOffset = 0, TEnableSystemConfig EnableSystem_type = TEnableSystemConfig.NONE, int EnableSystemOffset = 0, Offset<IWaveConfig> StartWaveOffset = default(Offset<IWaveConfig>), Offset<IDisableTrackAnim> DisableTrackAnimOffset = default(Offset<IDisableTrackAnim>), bool DisableSwitchGender = false, bool DisableFocusMode = false, bool DisableSkeletalAnimationCheck = false, Offset<ILogicProgramSpecialProcess> LogicProgramSpecialProcessOffset = default(Offset<ILogicProgramSpecialProcess>), Offset<IQuestBuffActiveRange> QuestBuffActiveRangeOffset = default(Offset<IQuestBuffActiveRange>), Offset<ISunSpiritProcess> SunSpiritProcessOffset = default(Offset<ISunSpiritProcess>), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), bool DisableGlobalTraffic = false, VectorOffset DisableSystemPromptOffset = default(VectorOffset), Offset<ITrackCustomBoardOnBtLogicNode> TrackCustomBoardOffset = default(Offset<ITrackCustomBoardOnBtLogicNode>), VectorOffset Children_typeOffset = default(VectorOffset), VectorOffset ChildrenOffset = default(VectorOffset), EConditionCount Count = EConditionCount.All, Offset<IPerformanceSetting> PerformanceSettingOffset = default(Offset<IPerformanceSetting>), ushort NullMask = 0)
		{
			builder.StartTable(43);
			IParallelSelectBtNode.AddPerformanceSetting(builder, PerformanceSettingOffset);
			IParallelSelectBtNode.AddChildren(builder, ChildrenOffset);
			IParallelSelectBtNode.AddChildrenType(builder, Children_typeOffset);
			IParallelSelectBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			IParallelSelectBtNode.AddDisableSystemPrompt(builder, DisableSystemPromptOffset);
			IParallelSelectBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			IParallelSelectBtNode.AddSunSpiritProcess(builder, SunSpiritProcessOffset);
			IParallelSelectBtNode.AddQuestBuffActiveRange(builder, QuestBuffActiveRangeOffset);
			IParallelSelectBtNode.AddLogicProgramSpecialProcess(builder, LogicProgramSpecialProcessOffset);
			IParallelSelectBtNode.AddDisableTrackAnim(builder, DisableTrackAnimOffset);
			IParallelSelectBtNode.AddStartWave(builder, StartWaveOffset);
			IParallelSelectBtNode.AddEnableSystem(builder, EnableSystemOffset);
			IParallelSelectBtNode.AddSpecialGamePlayConfig(builder, SpecialGamePlayConfigOffset);
			IParallelSelectBtNode.AddRewardConfig(builder, RewardConfigOffset);
			IParallelSelectBtNode.AddStatistics(builder, StatisticsOffset);
			IParallelSelectBtNode.AddOccupationConfig(builder, OccupationConfigOffset);
			IParallelSelectBtNode.AddOccupations(builder, OccupationsOffset);
			IParallelSelectBtNode.AddForceClosedRestriction(builder, ForceClosedRestrictionOffset);
			IParallelSelectBtNode.AddSaveConfig(builder, SaveConfigOffset);
			IParallelSelectBtNode.AddDungeonId(builder, DungeonId);
			IParallelSelectBtNode.AddTidQuestAliasDesc(builder, TidQuestAliasDescOffset);
			IParallelSelectBtNode.AddTidQuestAliasName(builder, TidQuestAliasNameOffset);
			IParallelSelectBtNode.AddInformationBoard(builder, InformationBoardOffset);
			IParallelSelectBtNode.AddInformationView(builder, InformationViewOffset);
			IParallelSelectBtNode.AddUIConfig(builder, UIConfigOffset);
			IParallelSelectBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IParallelSelectBtNode.AddDesc(builder, DescOffset);
			IParallelSelectBtNode.AddId(builder, Id);
			IParallelSelectBtNode.AddNullMask(builder, NullMask);
			IParallelSelectBtNode.AddCount(builder, Count);
			IParallelSelectBtNode.AddDisableGlobalTraffic(builder, DisableGlobalTraffic);
			IParallelSelectBtNode.AddDisableSkeletalAnimationCheck(builder, DisableSkeletalAnimationCheck);
			IParallelSelectBtNode.AddDisableFocusMode(builder, DisableFocusMode);
			IParallelSelectBtNode.AddDisableSwitchGender(builder, DisableSwitchGender);
			IParallelSelectBtNode.AddEnableSystemType(builder, EnableSystem_type);
			IParallelSelectBtNode.AddSpecialGamePlayConfigType(builder, SpecialGamePlayConfig_type);
			IParallelSelectBtNode.AddCompositeTrackViewMode(builder, CompositeTrackViewMode);
			IParallelSelectBtNode.AddBudgetCameraType(builder, BudgetCameraType);
			IParallelSelectBtNode.AddDisableSwitchOccupation(builder, DisableSwitchOccupation);
			IParallelSelectBtNode.AddDisableOnline(builder, DisableOnline);
			IParallelSelectBtNode.AddDisabled(builder, Disabled);
			IParallelSelectBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IParallelSelectBtNode.AddType(builder, Type);
			return IParallelSelectBtNode.EndIParallelSelectBtNode(builder);
		}

		// Token: 0x06017236 RID: 94774 RVA: 0x003561A4 File Offset: 0x003543A4
		public static void StartIParallelSelectBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(43);
		}

		// Token: 0x06017237 RID: 94775 RVA: 0x003561AE File Offset: 0x003543AE
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017238 RID: 94776 RVA: 0x003561B9 File Offset: 0x003543B9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x003561C4 File Offset: 0x003543C4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x0601723A RID: 94778 RVA: 0x003561D4 File Offset: 0x003543D4
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x0601723B RID: 94779 RVA: 0x003561E4 File Offset: 0x003543E4
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x0601723C RID: 94780 RVA: 0x003561EF File Offset: 0x003543EF
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x0601723D RID: 94781 RVA: 0x003561FA File Offset: 0x003543FA
		public static void AddUIConfig(FlatBufferBuilder builder, Offset<IQuestScheduleConfig> uIConfigOffset)
		{
			builder.AddOffset(6, uIConfigOffset.Value, 0);
		}

		// Token: 0x0601723E RID: 94782 RVA: 0x0035620A File Offset: 0x0035440A
		public static void AddInformationView(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewOffset)
		{
			builder.AddOffset(7, informationViewOffset.Value, 0);
		}

		// Token: 0x0601723F RID: 94783 RVA: 0x0035621A File Offset: 0x0035441A
		public static void AddInformationBoard(FlatBufferBuilder builder, Offset<IInformationBoardConfig> informationBoardOffset)
		{
			builder.AddOffset(8, informationBoardOffset.Value, 0);
		}

		// Token: 0x06017240 RID: 94784 RVA: 0x0035622A File Offset: 0x0035442A
		public static void AddTidQuestAliasName(FlatBufferBuilder builder, StringOffset tidQuestAliasNameOffset)
		{
			builder.AddOffset(9, tidQuestAliasNameOffset.Value, 0);
		}

		// Token: 0x06017241 RID: 94785 RVA: 0x0035623B File Offset: 0x0035443B
		public static void AddTidQuestAliasDesc(FlatBufferBuilder builder, StringOffset tidQuestAliasDescOffset)
		{
			builder.AddOffset(10, tidQuestAliasDescOffset.Value, 0);
		}

		// Token: 0x06017242 RID: 94786 RVA: 0x0035624C File Offset: 0x0035444C
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(11, dungeonId, 0);
		}

		// Token: 0x06017243 RID: 94787 RVA: 0x00356258 File Offset: 0x00354458
		public static void AddDisableOnline(FlatBufferBuilder builder, bool disableOnline)
		{
			builder.AddBool(12, disableOnline, false);
		}

		// Token: 0x06017244 RID: 94788 RVA: 0x00356264 File Offset: 0x00354464
		public static void AddSaveConfig(FlatBufferBuilder builder, Offset<ISaveConfig> saveConfigOffset)
		{
			builder.AddOffset(13, saveConfigOffset.Value, 0);
		}

		// Token: 0x06017245 RID: 94789 RVA: 0x00356275 File Offset: 0x00354475
		public static void AddForceClosedRestriction(FlatBufferBuilder builder, Offset<IForceClosedRestriction> forceClosedRestrictionOffset)
		{
			builder.AddOffset(14, forceClosedRestrictionOffset.Value, 0);
		}

		// Token: 0x06017246 RID: 94790 RVA: 0x00356286 File Offset: 0x00354486
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(15, occupationsOffset.Value, 0);
		}

		// Token: 0x06017247 RID: 94791 RVA: 0x00356298 File Offset: 0x00354498
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017248 RID: 94792 RVA: 0x003562D8 File Offset: 0x003544D8
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017249 RID: 94793 RVA: 0x003562F2 File Offset: 0x003544F2
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x00356310 File Offset: 0x00354510
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601724B RID: 94795 RVA: 0x00356329 File Offset: 0x00354529
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601724C RID: 94796 RVA: 0x00356334 File Offset: 0x00354534
		public static void AddOccupationConfig(FlatBufferBuilder builder, Offset<ILogicNodeOccupation> occupationConfigOffset)
		{
			builder.AddOffset(16, occupationConfigOffset.Value, 0);
		}

		// Token: 0x0601724D RID: 94797 RVA: 0x00356345 File Offset: 0x00354545
		public static void AddDisableSwitchOccupation(FlatBufferBuilder builder, bool disableSwitchOccupation)
		{
			builder.AddBool(17, disableSwitchOccupation, false);
		}

		// Token: 0x0601724E RID: 94798 RVA: 0x00356351 File Offset: 0x00354551
		public static void AddBudgetCameraType(FlatBufferBuilder builder, EBudgetCameraType budgetCameraType)
		{
			builder.AddByte(18, (byte)budgetCameraType, 0);
		}

		// Token: 0x0601724F RID: 94799 RVA: 0x0035635D File Offset: 0x0035455D
		public static void AddStatistics(FlatBufferBuilder builder, Offset<IQuestStatistics> statisticsOffset)
		{
			builder.AddOffset(19, statisticsOffset.Value, 0);
		}

		// Token: 0x06017250 RID: 94800 RVA: 0x0035636E File Offset: 0x0035456E
		public static void AddCompositeTrackViewMode(FlatBufferBuilder builder, ETrackViewMode compositeTrackViewMode)
		{
			builder.AddByte(20, (byte)compositeTrackViewMode, 0);
		}

		// Token: 0x06017251 RID: 94801 RVA: 0x0035637A File Offset: 0x0035457A
		public static void AddRewardConfig(FlatBufferBuilder builder, Offset<IQuestRewardConfig> rewardConfigOffset)
		{
			builder.AddOffset(21, rewardConfigOffset.Value, 0);
		}

		// Token: 0x06017252 RID: 94802 RVA: 0x0035638B File Offset: 0x0035458B
		public static void AddSpecialGamePlayConfigType(FlatBufferBuilder builder, TSpecialGamePlayConfig specialGamePlayConfigType)
		{
			builder.AddByte(22, (byte)specialGamePlayConfigType, 0);
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x00356397 File Offset: 0x00354597
		public static void AddSpecialGamePlayConfig(FlatBufferBuilder builder, int specialGamePlayConfigOffset)
		{
			builder.AddOffset(23, specialGamePlayConfigOffset, 0);
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x003563A3 File Offset: 0x003545A3
		public static void AddEnableSystemType(FlatBufferBuilder builder, TEnableSystemConfig enableSystemType)
		{
			builder.AddByte(24, (byte)enableSystemType, 0);
		}

		// Token: 0x06017255 RID: 94805 RVA: 0x003563AF File Offset: 0x003545AF
		public static void AddEnableSystem(FlatBufferBuilder builder, int enableSystemOffset)
		{
			builder.AddOffset(25, enableSystemOffset, 0);
		}

		// Token: 0x06017256 RID: 94806 RVA: 0x003563BB File Offset: 0x003545BB
		public static void AddStartWave(FlatBufferBuilder builder, Offset<IWaveConfig> startWaveOffset)
		{
			builder.AddOffset(26, startWaveOffset.Value, 0);
		}

		// Token: 0x06017257 RID: 94807 RVA: 0x003563CC File Offset: 0x003545CC
		public static void AddDisableTrackAnim(FlatBufferBuilder builder, Offset<IDisableTrackAnim> disableTrackAnimOffset)
		{
			builder.AddOffset(27, disableTrackAnimOffset.Value, 0);
		}

		// Token: 0x06017258 RID: 94808 RVA: 0x003563DD File Offset: 0x003545DD
		public static void AddDisableSwitchGender(FlatBufferBuilder builder, bool disableSwitchGender)
		{
			builder.AddBool(28, disableSwitchGender, false);
		}

		// Token: 0x06017259 RID: 94809 RVA: 0x003563E9 File Offset: 0x003545E9
		public static void AddDisableFocusMode(FlatBufferBuilder builder, bool disableFocusMode)
		{
			builder.AddBool(29, disableFocusMode, false);
		}

		// Token: 0x0601725A RID: 94810 RVA: 0x003563F5 File Offset: 0x003545F5
		public static void AddDisableSkeletalAnimationCheck(FlatBufferBuilder builder, bool disableSkeletalAnimationCheck)
		{
			builder.AddBool(30, disableSkeletalAnimationCheck, false);
		}

		// Token: 0x0601725B RID: 94811 RVA: 0x00356401 File Offset: 0x00354601
		public static void AddLogicProgramSpecialProcess(FlatBufferBuilder builder, Offset<ILogicProgramSpecialProcess> logicProgramSpecialProcessOffset)
		{
			builder.AddOffset(31, logicProgramSpecialProcessOffset.Value, 0);
		}

		// Token: 0x0601725C RID: 94812 RVA: 0x00356412 File Offset: 0x00354612
		public static void AddQuestBuffActiveRange(FlatBufferBuilder builder, Offset<IQuestBuffActiveRange> questBuffActiveRangeOffset)
		{
			builder.AddOffset(32, questBuffActiveRangeOffset.Value, 0);
		}

		// Token: 0x0601725D RID: 94813 RVA: 0x00356423 File Offset: 0x00354623
		public static void AddSunSpiritProcess(FlatBufferBuilder builder, Offset<ISunSpiritProcess> sunSpiritProcessOffset)
		{
			builder.AddOffset(33, sunSpiritProcessOffset.Value, 0);
		}

		// Token: 0x0601725E RID: 94814 RVA: 0x00356434 File Offset: 0x00354634
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(34, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x0601725F RID: 94815 RVA: 0x00356445 File Offset: 0x00354645
		public static void AddDisableGlobalTraffic(FlatBufferBuilder builder, bool disableGlobalTraffic)
		{
			builder.AddBool(35, disableGlobalTraffic, false);
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x00356451 File Offset: 0x00354651
		public static void AddDisableSystemPrompt(FlatBufferBuilder builder, VectorOffset disableSystemPromptOffset)
		{
			builder.AddOffset(36, disableSystemPromptOffset.Value, 0);
		}

		// Token: 0x06017261 RID: 94817 RVA: 0x00356464 File Offset: 0x00354664
		public static VectorOffset CreateDisableSystemPromptVector(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017262 RID: 94818 RVA: 0x003564A4 File Offset: 0x003546A4
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, Offset<IAreaNameSystemPrompt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x003564BE File Offset: 0x003546BE
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAreaNameSystemPrompt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAreaNameSystemPrompt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x003564DC File Offset: 0x003546DC
		public static VectorOffset CreateDisableSystemPromptVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAreaNameSystemPrompt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x003564F5 File Offset: 0x003546F5
		public static void StartDisableSystemPromptVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017266 RID: 94822 RVA: 0x00356500 File Offset: 0x00354700
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset)
		{
			builder.AddOffset(37, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06017267 RID: 94823 RVA: 0x00356511 File Offset: 0x00354711
		public static void AddChildrenType(FlatBufferBuilder builder, VectorOffset childrenTypeOffset)
		{
			builder.AddOffset(38, childrenTypeOffset.Value, 0);
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x00356524 File Offset: 0x00354724
		public static VectorOffset CreateChildrenTypeVector(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017269 RID: 94825 RVA: 0x0035655B File Offset: 0x0035475B
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, TBtNode[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601726A RID: 94826 RVA: 0x00356575 File Offset: 0x00354775
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBtNode> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBtNode>(data);
			return builder.EndVector();
		}

		// Token: 0x0601726B RID: 94827 RVA: 0x00356593 File Offset: 0x00354793
		public static VectorOffset CreateChildrenTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBtNode>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601726C RID: 94828 RVA: 0x003565AC File Offset: 0x003547AC
		public static void StartChildrenTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601726D RID: 94829 RVA: 0x003565B7 File Offset: 0x003547B7
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(39, childrenOffset.Value, 0);
		}

		// Token: 0x0601726E RID: 94830 RVA: 0x003565C8 File Offset: 0x003547C8
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601726F RID: 94831 RVA: 0x003565FF File Offset: 0x003547FF
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017270 RID: 94832 RVA: 0x00356619 File Offset: 0x00354819
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017271 RID: 94833 RVA: 0x00356637 File Offset: 0x00354837
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017272 RID: 94834 RVA: 0x00356650 File Offset: 0x00354850
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017273 RID: 94835 RVA: 0x0035665B File Offset: 0x0035485B
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(40, (byte)count, 0);
		}

		// Token: 0x06017274 RID: 94836 RVA: 0x00356667 File Offset: 0x00354867
		public static void AddPerformanceSetting(FlatBufferBuilder builder, Offset<IPerformanceSetting> performanceSettingOffset)
		{
			builder.AddOffset(41, performanceSettingOffset.Value, 0);
		}

		// Token: 0x06017275 RID: 94837 RVA: 0x00356678 File Offset: 0x00354878
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(42, nullMask, 0);
		}

		// Token: 0x06017276 RID: 94838 RVA: 0x00356684 File Offset: 0x00354884
		public static Offset<IParallelSelectBtNode> EndIParallelSelectBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IParallelSelectBtNode>(builder.EndTable());
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x00356694 File Offset: 0x00354894
		public IParallelSelectBtNodeT UnPack()
		{
			IParallelSelectBtNodeT parallelSelectBtNodeT = new IParallelSelectBtNodeT();
			this.UnPackTo(parallelSelectBtNodeT);
			return parallelSelectBtNodeT;
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x003566B0 File Offset: 0x003548B0
		public void UnPackTo(IParallelSelectBtNodeT _o)
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
			_o.Children = new List<TBtNodeUnion>();
			for (int k = 0; k < this.ChildrenLength; k++)
			{
				TBtNodeUnion tbtNodeUnion = new TBtNodeUnion();
				tbtNodeUnion.Type = this.ChildrenType(k);
				switch (this.ChildrenType(k))
				{
				case TBtNode.IActionBtNode:
					tbtNodeUnion.Value = ((this.Children<IActionBtNode>(k) != null) ? this.Children<IActionBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IActionWithResultBtNode:
					tbtNodeUnion.Value = ((this.Children<IActionWithResultBtNode>(k) != null) ? this.Children<IActionWithResultBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IAlwaysFalseBtNode:
					tbtNodeUnion.Value = ((this.Children<IAlwaysFalseBtNode>(k) != null) ? this.Children<IAlwaysFalseBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IAlwaysTrueBtNode:
					tbtNodeUnion.Value = ((this.Children<IAlwaysTrueBtNode>(k) != null) ? this.Children<IAlwaysTrueBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IChildQuestBtNode:
					tbtNodeUnion.Value = ((this.Children<IChildQuestBtNode>(k) != null) ? this.Children<IChildQuestBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IConditionBtNode:
					tbtNodeUnion.Value = ((this.Children<IConditionBtNode>(k) != null) ? this.Children<IConditionBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IConditionSelectorBtNode:
					tbtNodeUnion.Value = ((this.Children<IConditionSelectorBtNode>(k) != null) ? this.Children<IConditionSelectorBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IParallelSelectBtNode:
					tbtNodeUnion.Value = ((this.Children<IParallelSelectBtNode>(k) != null) ? this.Children<IParallelSelectBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IQuestFailedBtNode:
					tbtNodeUnion.Value = ((this.Children<IQuestFailedBtNode>(k) != null) ? this.Children<IQuestFailedBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IQuestSucceedBtNode:
					tbtNodeUnion.Value = ((this.Children<IQuestSucceedBtNode>(k) != null) ? this.Children<IQuestSucceedBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IRepeaterBtNode:
					tbtNodeUnion.Value = ((this.Children<IRepeaterBtNode>(k) != null) ? this.Children<IRepeaterBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.ISelectBtNode:
					tbtNodeUnion.Value = ((this.Children<ISelectBtNode>(k) != null) ? this.Children<ISelectBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.ISequenceBtNode:
					tbtNodeUnion.Value = ((this.Children<ISequenceBtNode>(k) != null) ? this.Children<ISequenceBtNode>(k).Value.UnPack() : null);
					break;
				case TBtNode.IStartBtNode:
					tbtNodeUnion.Value = ((this.Children<IStartBtNode>(k) != null) ? this.Children<IStartBtNode>(k).Value.UnPack() : null);
					break;
				}
				_o.Children.Add(tbtNodeUnion);
			}
			_o.Count = this.Count;
			_o.PerformanceSetting = ((this.PerformanceSetting != null) ? this.PerformanceSetting.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017279 RID: 94841 RVA: 0x00357414 File Offset: 0x00355614
		public static Offset<IParallelSelectBtNode> Pack(FlatBufferBuilder builder, IParallelSelectBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParallelSelectBtNode>);
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
				occupationsOffset = IParallelSelectBtNode.CreateOccupationsVector(builder, array);
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
				disableSystemPromptOffset = IParallelSelectBtNode.CreateDisableSystemPromptVector(builder, array2);
			}
			Offset<ITrackCustomBoardOnBtLogicNode> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoardOnBtLogicNode>) : ITrackCustomBoardOnBtLogicNode.Pack(builder, _o.TrackCustomBoard);
			VectorOffset children_typeOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				TBtNode[] array3 = new TBtNode[_o.Children.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = _o.Children[k].Type;
				}
				children_typeOffset = IParallelSelectBtNode.CreateChildrenTypeVector(builder, array3);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				int[] array4 = new int[_o.Children.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = TBtNodeUnion.Pack(builder, _o.Children[l]);
				}
				childrenOffset = IParallelSelectBtNode.CreateChildrenVector(builder, array4);
			}
			Offset<IPerformanceSetting> performanceSettingOffset = (_o.PerformanceSetting == null) ? default(Offset<IPerformanceSetting>) : IPerformanceSetting.Pack(builder, _o.PerformanceSetting);
			return IParallelSelectBtNode.CreateIParallelSelectBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, uiconfigOffset, informationViewOffset, informationBoardOffset, tidQuestAliasNameOffset, tidQuestAliasDescOffset, _o.DungeonId, _o.DisableOnline, saveConfigOffset, forceClosedRestrictionOffset, occupationsOffset, occupationConfigOffset, _o.DisableSwitchOccupation, _o.BudgetCameraType, statisticsOffset, _o.CompositeTrackViewMode, rewardConfigOffset, specialGamePlayConfig_type, specialGamePlayConfigOffset, enableSystem_type, enableSystemOffset, startWaveOffset, disableTrackAnimOffset, _o.DisableSwitchGender, _o.DisableFocusMode, _o.DisableSkeletalAnimationCheck, logicProgramSpecialProcessOffset, questBuffActiveRangeOffset, sunSpiritProcessOffset, modifyTrackAreaTextOffset, _o.DisableGlobalTraffic, disableSystemPromptOffset, trackCustomBoardOffset, children_typeOffset, childrenOffset, _o.Count, performanceSettingOffset, _o.NullMask);
		}

		// Token: 0x0400B999 RID: 47513
		private Table __p;
	}
}
