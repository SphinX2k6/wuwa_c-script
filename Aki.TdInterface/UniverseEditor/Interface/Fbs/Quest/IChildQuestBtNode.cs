using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419F RID: 16799
	public struct IChildQuestBtNode : IFlatbufferObject
	{
		// Token: 0x170071D4 RID: 29140
		// (get) Token: 0x0601724F RID: 94799 RVA: 0x0034CCA1 File Offset: 0x0034AEA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017250 RID: 94800 RVA: 0x0034CCAE File Offset: 0x0034AEAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017251 RID: 94801 RVA: 0x0034CCB8 File Offset: 0x0034AEB8
		public static IChildQuestBtNode GetRootAsIChildQuestBtNode(ByteBuffer _bb)
		{
			return IChildQuestBtNode.GetRootAsIChildQuestBtNode(_bb, default(IChildQuestBtNode));
		}

		// Token: 0x06017252 RID: 94802 RVA: 0x0034CCD4 File Offset: 0x0034AED4
		public static IChildQuestBtNode GetRootAsIChildQuestBtNode(ByteBuffer _bb, IChildQuestBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x0034CCF1 File Offset: 0x0034AEF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x0034CD00 File Offset: 0x0034AF00
		public IChildQuestBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071D5 RID: 29141
		// (get) Token: 0x06017255 RID: 94805 RVA: 0x0034CD10 File Offset: 0x0034AF10
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

		// Token: 0x170071D6 RID: 29142
		// (get) Token: 0x06017256 RID: 94806 RVA: 0x0034CD4C File Offset: 0x0034AF4C
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

		// Token: 0x170071D7 RID: 29143
		// (get) Token: 0x06017257 RID: 94807 RVA: 0x0034CD88 File Offset: 0x0034AF88
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

		// Token: 0x06017258 RID: 94808 RVA: 0x0034CDBF File Offset: 0x0034AFBF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06017259 RID: 94809 RVA: 0x0034CDCE File Offset: 0x0034AFCE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170071D8 RID: 29144
		// (get) Token: 0x0601725A RID: 94810 RVA: 0x0034CDDC File Offset: 0x0034AFDC
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

		// Token: 0x170071D9 RID: 29145
		// (get) Token: 0x0601725B RID: 94811 RVA: 0x0034CE3C File Offset: 0x0034B03C
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071DA RID: 29146
		// (get) Token: 0x0601725C RID: 94812 RVA: 0x0034CE7C File Offset: 0x0034B07C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071DB RID: 29147
		// (get) Token: 0x0601725D RID: 94813 RVA: 0x0034CEBC File Offset: 0x0034B0BC
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071DC RID: 29148
		// (get) Token: 0x0601725E RID: 94814 RVA: 0x0034CEFC File Offset: 0x0034B0FC
		public EItemGetUiType RewardGetUiType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EItemGetUiType.None;
				}
				return (EItemGetUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071DD RID: 29149
		// (get) Token: 0x0601725F RID: 94815 RVA: 0x0034CF3C File Offset: 0x0034B13C
		public IItemGetUiConfigSpecialQuest? RewardGetUiConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IItemGetUiConfigSpecialQuest?(default(IItemGetUiConfigSpecialQuest).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071DE RID: 29150
		// (get) Token: 0x06017260 RID: 94816 RVA: 0x0034CF9C File Offset: 0x0034B19C
		public bool HideTip
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071DF RID: 29151
		// (get) Token: 0x06017261 RID: 94817 RVA: 0x0034CFDC File Offset: 0x0034B1DC
		public string TidTip
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

		// Token: 0x06017262 RID: 94818 RVA: 0x0034D014 File Offset: 0x0034B214
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x0034D024 File Offset: 0x0034B224
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x170071E0 RID: 29152
		// (get) Token: 0x06017264 RID: 94820 RVA: 0x0034D034 File Offset: 0x0034B234
		public bool ShowTipBeforeEnterActions
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071E1 RID: 29153
		// (get) Token: 0x06017265 RID: 94821 RVA: 0x0034D074 File Offset: 0x0034B274
		public bool ShowNavigation
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071E2 RID: 29154
		// (get) Token: 0x06017266 RID: 94822 RVA: 0x0034D0B4 File Offset: 0x0034B2B4
		public ENavigationStyle NavigationStyle
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return ENavigationStyle.Default;
				}
				return (ENavigationStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071E3 RID: 29155
		// (get) Token: 0x06017267 RID: 94823 RVA: 0x0034D0F4 File Offset: 0x0034B2F4
		public bool AlwaysShowNavigation
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x0034D134 File Offset: 0x0034B334
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170071E4 RID: 29156
		// (get) Token: 0x06017269 RID: 94825 RVA: 0x0034D198 File Offset: 0x0034B398
		public int EnterActionsLength
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

		// Token: 0x0601726A RID: 94826 RVA: 0x0034D1C4 File Offset: 0x0034B3C4
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170071E5 RID: 29157
		// (get) Token: 0x0601726B RID: 94827 RVA: 0x0034D228 File Offset: 0x0034B428
		public int FinishActionsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170071E6 RID: 29158
		// (get) Token: 0x0601726C RID: 94828 RVA: 0x0034D254 File Offset: 0x0034B454
		public ITrackTarget? TrackTarget
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new ITrackTarget?(default(ITrackTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071E7 RID: 29159
		// (get) Token: 0x0601726D RID: 94829 RVA: 0x0034D2B4 File Offset: 0x0034B4B4
		public TChildQuestCondition ConditionType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return TChildQuestCondition.NONE;
				}
				return (TChildQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601726E RID: 94830 RVA: 0x0034D2F4 File Offset: 0x0034B4F4
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601726F RID: 94831 RVA: 0x0034D33C File Offset: 0x0034B53C
		public IAtomicProcess ConditionAsIAtomicProcess()
		{
			return this.Condition<IAtomicProcess>().Value;
		}

		// Token: 0x06017270 RID: 94832 RVA: 0x0034D358 File Offset: 0x0034B558
		public IAwakeAndLoadEntityCondition ConditionAsIAwakeAndLoadEntityCondition()
		{
			return this.Condition<IAwakeAndLoadEntityCondition>().Value;
		}

		// Token: 0x06017271 RID: 94833 RVA: 0x0034D374 File Offset: 0x0034B574
		public ICheckActivityStateCondition ConditionAsICheckActivityStateCondition()
		{
			return this.Condition<ICheckActivityStateCondition>().Value;
		}

		// Token: 0x06017272 RID: 94834 RVA: 0x0034D390 File Offset: 0x0034B590
		public ICheckClientConditionGroupQuestCondition ConditionAsICheckClientConditionGroupQuestCondition()
		{
			return this.Condition<ICheckClientConditionGroupQuestCondition>().Value;
		}

		// Token: 0x06017273 RID: 94835 RVA: 0x0034D3AC File Offset: 0x0034B5AC
		public ICheckConditionGroupQuestCondition ConditionAsICheckConditionGroupQuestCondition()
		{
			return this.Condition<ICheckConditionGroupQuestCondition>().Value;
		}

		// Token: 0x06017274 RID: 94836 RVA: 0x0034D3C8 File Offset: 0x0034B5C8
		public ICheckEntityStateQuestCondition ConditionAsICheckEntityStateQuestCondition()
		{
			return this.Condition<ICheckEntityStateQuestCondition>().Value;
		}

		// Token: 0x06017275 RID: 94837 RVA: 0x0034D3E4 File Offset: 0x0034B5E4
		public ICheckLevelPlayQuestCondition ConditionAsICheckLevelPlayQuestCondition()
		{
			return this.Condition<ICheckLevelPlayQuestCondition>().Value;
		}

		// Token: 0x06017276 RID: 94838 RVA: 0x0034D400 File Offset: 0x0034B600
		public ICheckPlayerInputCondition ConditionAsICheckPlayerInputCondition()
		{
			return this.Condition<ICheckPlayerInputCondition>().Value;
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x0034D41C File Offset: 0x0034B61C
		public ICheckSpringFestivalGameplayCompleted ConditionAsICheckSpringFestivalGameplayCompleted()
		{
			return this.Condition<ICheckSpringFestivalGameplayCompleted>().Value;
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x0034D438 File Offset: 0x0034B638
		public ICheckTargetBattleAttributeCondition ConditionAsICheckTargetBattleAttributeCondition()
		{
			return this.Condition<ICheckTargetBattleAttributeCondition>().Value;
		}

		// Token: 0x06017279 RID: 94841 RVA: 0x0034D454 File Offset: 0x0034B654
		public ICheckTrapDefenseEventCondition ConditionAsICheckTrapDefenseEventCondition()
		{
			return this.Condition<ICheckTrapDefenseEventCondition>().Value;
		}

		// Token: 0x0601727A RID: 94842 RVA: 0x0034D470 File Offset: 0x0034B670
		public ICheckUiGameQuestCondition ConditionAsICheckUiGameQuestCondition()
		{
			return this.Condition<ICheckUiGameQuestCondition>().Value;
		}

		// Token: 0x0601727B RID: 94843 RVA: 0x0034D48C File Offset: 0x0034B68C
		public ICompareActorVar ConditionAsICompareActorVar()
		{
			return this.Condition<ICompareActorVar>().Value;
		}

		// Token: 0x0601727C RID: 94844 RVA: 0x0034D4A8 File Offset: 0x0034B6A8
		public ICompareVarConditionInChildQuest ConditionAsICompareVarConditionInChildQuest()
		{
			return this.Condition<ICompareVarConditionInChildQuest>().Value;
		}

		// Token: 0x0601727D RID: 94845 RVA: 0x0034D4C4 File Offset: 0x0034B6C4
		public ICrossSceneSyncKillMonster ConditionAsICrossSceneSyncKillMonster()
		{
			return this.Condition<ICrossSceneSyncKillMonster>().Value;
		}

		// Token: 0x0601727E RID: 94846 RVA: 0x0034D4E0 File Offset: 0x0034B6E0
		public IDetectCombatState2Condition ConditionAsIDetectCombatState2Condition()
		{
			return this.Condition<IDetectCombatState2Condition>().Value;
		}

		// Token: 0x0601727F RID: 94847 RVA: 0x0034D4FC File Offset: 0x0034B6FC
		public IDetectCombatStateCondition ConditionAsIDetectCombatStateCondition()
		{
			return this.Condition<IDetectCombatStateCondition>().Value;
		}

		// Token: 0x06017280 RID: 94848 RVA: 0x0034D518 File Offset: 0x0034B718
		public IDoInteractQuestCondition ConditionAsIDoInteractQuestCondition()
		{
			return this.Condition<IDoInteractQuestCondition>().Value;
		}

		// Token: 0x06017281 RID: 94849 RVA: 0x0034D534 File Offset: 0x0034B734
		public IEnterDungeonCondition ConditionAsIEnterDungeonCondition()
		{
			return this.Condition<IEnterDungeonCondition>().Value;
		}

		// Token: 0x06017282 RID: 94850 RVA: 0x0034D550 File Offset: 0x0034B750
		public IFinishArcadeGameplay ConditionAsIFinishArcadeGameplay()
		{
			return this.Condition<IFinishArcadeGameplay>().Value;
		}

		// Token: 0x06017283 RID: 94851 RVA: 0x0034D56C File Offset: 0x0034B76C
		public IFinishBvbChallenge ConditionAsIFinishBvbChallenge()
		{
			return this.Condition<IFinishBvbChallenge>().Value;
		}

		// Token: 0x06017284 RID: 94852 RVA: 0x0034D588 File Offset: 0x0034B788
		public IFinishDungeonQuestCondition ConditionAsIFinishDungeonQuestCondition()
		{
			return this.Condition<IFinishDungeonQuestCondition>().Value;
		}

		// Token: 0x06017285 RID: 94853 RVA: 0x0034D5A4 File Offset: 0x0034B7A4
		public IFinishFlipperCondition ConditionAsIFinishFlipperCondition()
		{
			return this.Condition<IFinishFlipperCondition>().Value;
		}

		// Token: 0x06017286 RID: 94854 RVA: 0x0034D5C0 File Offset: 0x0034B7C0
		public IFinishJellyfishReturnCondition ConditionAsIFinishJellyfishReturnCondition()
		{
			return this.Condition<IFinishJellyfishReturnCondition>().Value;
		}

		// Token: 0x06017287 RID: 94855 RVA: 0x0034D5DC File Offset: 0x0034B7DC
		public IFinishKuroSimpleCombatKillMonster ConditionAsIFinishKuroSimpleCombatKillMonster()
		{
			return this.Condition<IFinishKuroSimpleCombatKillMonster>().Value;
		}

		// Token: 0x06017288 RID: 94856 RVA: 0x0034D5F8 File Offset: 0x0034B7F8
		public IFinishKurotatoCondition ConditionAsIFinishKurotatoCondition()
		{
			return this.Condition<IFinishKurotatoCondition>().Value;
		}

		// Token: 0x06017289 RID: 94857 RVA: 0x0034D614 File Offset: 0x0034B814
		public IFinishRhythmSpaceshipCondition ConditionAsIFinishRhythmSpaceshipCondition()
		{
			return this.Condition<IFinishRhythmSpaceshipCondition>().Value;
		}

		// Token: 0x0601728A RID: 94858 RVA: 0x0034D630 File Offset: 0x0034B830
		public IFinishRoleTowerCondition ConditionAsIFinishRoleTowerCondition()
		{
			return this.Condition<IFinishRoleTowerCondition>().Value;
		}

		// Token: 0x0601728B RID: 94859 RVA: 0x0034D64C File Offset: 0x0034B84C
		public IFinishRollBlock ConditionAsIFinishRollBlock()
		{
			return this.Condition<IFinishRollBlock>().Value;
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x0034D668 File Offset: 0x0034B868
		public IFinishSurvivorsRougeCondition ConditionAsIFinishSurvivorsRougeCondition()
		{
			return this.Condition<IFinishSurvivorsRougeCondition>().Value;
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x0034D684 File Offset: 0x0034B884
		public IFinishTetris ConditionAsIFinishTetris()
		{
			return this.Condition<IFinishTetris>().Value;
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x0034D6A0 File Offset: 0x0034B8A0
		public IFinishTrapDefenseCondition ConditionAsIFinishTrapDefenseCondition()
		{
			return this.Condition<IFinishTrapDefenseCondition>().Value;
		}

		// Token: 0x0601728F RID: 94863 RVA: 0x0034D6BC File Offset: 0x0034B8BC
		public IGetItemQuestCondition ConditionAsIGetItemQuestCondition()
		{
			return this.Condition<IGetItemQuestCondition>().Value;
		}

		// Token: 0x06017290 RID: 94864 RVA: 0x0034D6D8 File Offset: 0x0034B8D8
		public IGetSkillQuestCondition ConditionAsIGetSkillQuestCondition()
		{
			return this.Condition<IGetSkillQuestCondition>().Value;
		}

		// Token: 0x06017291 RID: 94865 RVA: 0x0034D6F4 File Offset: 0x0034B8F4
		public IGuideCondition ConditionAsIGuideCondition()
		{
			return this.Condition<IGuideCondition>().Value;
		}

		// Token: 0x06017292 RID: 94866 RVA: 0x0034D710 File Offset: 0x0034B910
		public IHandInItemsCondition ConditionAsIHandInItemsCondition()
		{
			return this.Condition<IHandInItemsCondition>().Value;
		}

		// Token: 0x06017293 RID: 94867 RVA: 0x0034D72C File Offset: 0x0034B92C
		public IInformationViewCheckCondition ConditionAsIInformationViewCheckCondition()
		{
			return this.Condition<IInformationViewCheckCondition>().Value;
		}

		// Token: 0x06017294 RID: 94868 RVA: 0x0034D748 File Offset: 0x0034B948
		public IKillChildQuestCondition ConditionAsIKillChildQuestCondition()
		{
			return this.Condition<IKillChildQuestCondition>().Value;
		}

		// Token: 0x06017295 RID: 94869 RVA: 0x0034D764 File Offset: 0x0034B964
		public ILeaveDungeonCondition ConditionAsILeaveDungeonCondition()
		{
			return this.Condition<ILeaveDungeonCondition>().Value;
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x0034D780 File Offset: 0x0034B980
		public IListenToEvent ConditionAsIListenToEvent()
		{
			return this.Condition<IListenToEvent>().Value;
		}

		// Token: 0x06017297 RID: 94871 RVA: 0x0034D79C File Offset: 0x0034B99C
		public IMonsterCreatorQuestCondition ConditionAsIMonsterCreatorQuestCondition()
		{
			return this.Condition<IMonsterCreatorQuestCondition>().Value;
		}

		// Token: 0x06017298 RID: 94872 RVA: 0x0034D7B8 File Offset: 0x0034B9B8
		public INewHandInItemsCondition ConditionAsINewHandInItemsCondition()
		{
			return this.Condition<INewHandInItemsCondition>().Value;
		}

		// Token: 0x06017299 RID: 94873 RVA: 0x0034D7D4 File Offset: 0x0034B9D4
		public IParallaxAlignQuestCondition ConditionAsIParallaxAlignQuestCondition()
		{
			return this.Condition<IParallaxAlignQuestCondition>().Value;
		}

		// Token: 0x0601729A RID: 94874 RVA: 0x0034D7F0 File Offset: 0x0034B9F0
		public IParkourQuestCondition ConditionAsIParkourQuestCondition()
		{
			return this.Condition<IParkourQuestCondition>().Value;
		}

		// Token: 0x0601729B RID: 94875 RVA: 0x0034D80C File Offset: 0x0034BA0C
		public IPlaybackShowTimelineQuestCondition ConditionAsIPlaybackShowTimelineQuestCondition()
		{
			return this.Condition<IPlaybackShowTimelineQuestCondition>().Value;
		}

		// Token: 0x0601729C RID: 94876 RVA: 0x0034D828 File Offset: 0x0034BA28
		public IPlayFlowQuestCondition ConditionAsIPlayFlowQuestCondition()
		{
			return this.Condition<IPlayFlowQuestCondition>().Value;
		}

		// Token: 0x0601729D RID: 94877 RVA: 0x0034D844 File Offset: 0x0034BA44
		public IProgramSpecialProcess ConditionAsIProgramSpecialProcess()
		{
			return this.Condition<IProgramSpecialProcess>().Value;
		}

		// Token: 0x0601729E RID: 94878 RVA: 0x0034D860 File Offset: 0x0034BA60
		public IReachAreaQuestCondition ConditionAsIReachAreaQuestCondition()
		{
			return this.Condition<IReachAreaQuestCondition>().Value;
		}

		// Token: 0x0601729F RID: 94879 RVA: 0x0034D87C File Offset: 0x0034BA7C
		public IReadMailCondition ConditionAsIReadMailCondition()
		{
			return this.Condition<IReadMailCondition>().Value;
		}

		// Token: 0x060172A0 RID: 94880 RVA: 0x0034D898 File Offset: 0x0034BA98
		public IReadPhoneMessageQuestCondition ConditionAsIReadPhoneMessageQuestCondition()
		{
			return this.Condition<IReadPhoneMessageQuestCondition>().Value;
		}

		// Token: 0x060172A1 RID: 94881 RVA: 0x0034D8B4 File Offset: 0x0034BAB4
		public IReceiveTelecomChildQuestCondition ConditionAsIReceiveTelecomChildQuestCondition()
		{
			return this.Condition<IReceiveTelecomChildQuestCondition>().Value;
		}

		// Token: 0x060172A2 RID: 94882 RVA: 0x0034D8D0 File Offset: 0x0034BAD0
		public IScheduleTimeCondition ConditionAsIScheduleTimeCondition()
		{
			return this.Condition<IScheduleTimeCondition>().Value;
		}

		// Token: 0x060172A3 RID: 94883 RVA: 0x0034D8EC File Offset: 0x0034BAEC
		public IShowUiCondition ConditionAsIShowUiCondition()
		{
			return this.Condition<IShowUiCondition>().Value;
		}

		// Token: 0x060172A4 RID: 94884 RVA: 0x0034D908 File Offset: 0x0034BB08
		public ITakePhoto2Condition ConditionAsITakePhoto2Condition()
		{
			return this.Condition<ITakePhoto2Condition>().Value;
		}

		// Token: 0x060172A5 RID: 94885 RVA: 0x0034D924 File Offset: 0x0034BB24
		public ITakePhotoCondition ConditionAsITakePhotoCondition()
		{
			return this.Condition<ITakePhotoCondition>().Value;
		}

		// Token: 0x060172A6 RID: 94886 RVA: 0x0034D940 File Offset: 0x0034BB40
		public ITimerQuestCondition ConditionAsITimerQuestCondition()
		{
			return this.Condition<ITimerQuestCondition>().Value;
		}

		// Token: 0x060172A7 RID: 94887 RVA: 0x0034D95C File Offset: 0x0034BB5C
		public ITimeScaledPhotograph ConditionAsITimeScaledPhotograph()
		{
			return this.Condition<ITimeScaledPhotograph>().Value;
		}

		// Token: 0x060172A8 RID: 94888 RVA: 0x0034D978 File Offset: 0x0034BB78
		public IUseItemCondition ConditionAsIUseItemCondition()
		{
			return this.Condition<IUseItemCondition>().Value;
		}

		// Token: 0x060172A9 RID: 94889 RVA: 0x0034D994 File Offset: 0x0034BB94
		public IUseSkillQuestCondition ConditionAsIUseSkillQuestCondition()
		{
			return this.Condition<IUseSkillQuestCondition>().Value;
		}

		// Token: 0x060172AA RID: 94890 RVA: 0x0034D9B0 File Offset: 0x0034BBB0
		public IUseWeatherSwitchCondition ConditionAsIUseWeatherSwitchCondition()
		{
			return this.Condition<IUseWeatherSwitchCondition>().Value;
		}

		// Token: 0x060172AB RID: 94891 RVA: 0x0034D9CC File Offset: 0x0034BBCC
		public IVisionSystemQuestCondition ConditionAsIVisionSystemQuestCondition()
		{
			return this.Condition<IVisionSystemQuestCondition>().Value;
		}

		// Token: 0x060172AC RID: 94892 RVA: 0x0034D9E8 File Offset: 0x0034BBE8
		public IWaitBattleCondition ConditionAsIWaitBattleCondition()
		{
			return this.Condition<IWaitBattleCondition>().Value;
		}

		// Token: 0x060172AD RID: 94893 RVA: 0x0034DA04 File Offset: 0x0034BC04
		public IWaitTimeCondition ConditionAsIWaitTimeCondition()
		{
			return this.Condition<IWaitTimeCondition>().Value;
		}

		// Token: 0x060172AE RID: 94894 RVA: 0x0034DA20 File Offset: 0x0034BC20
		public IWaitUntilLevelSequenceReachMark ConditionAsIWaitUntilLevelSequenceReachMark()
		{
			return this.Condition<IWaitUntilLevelSequenceReachMark>().Value;
		}

		// Token: 0x060172AF RID: 94895 RVA: 0x0034DA3C File Offset: 0x0034BC3C
		public IWalkingPatternCondition ConditionAsIWalkingPatternCondition()
		{
			return this.Condition<IWalkingPatternCondition>().Value;
		}

		// Token: 0x170071E8 RID: 29160
		// (get) Token: 0x060172B0 RID: 94896 RVA: 0x0034DA58 File Offset: 0x0034BC58
		public bool HideUi
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071E9 RID: 29161
		// (get) Token: 0x060172B1 RID: 94897 RVA: 0x0034DA98 File Offset: 0x0034BC98
		public bool HideUiExceptTaskList
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170071EA RID: 29162
		// (get) Token: 0x060172B2 RID: 94898 RVA: 0x0034DAD8 File Offset: 0x0034BCD8
		public TSaveConfig SaveConfigType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return TSaveConfig.NONE;
				}
				return (TSaveConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x0034DB18 File Offset: 0x0034BD18
		public TTable? SaveConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060172B4 RID: 94900 RVA: 0x0034DB60 File Offset: 0x0034BD60
		public ISaveNew SaveConfigAsISaveNew()
		{
			return this.SaveConfig<ISaveNew>().Value;
		}

		// Token: 0x060172B5 RID: 94901 RVA: 0x0034DB7C File Offset: 0x0034BD7C
		public ISavePoint SaveConfigAsISavePoint()
		{
			return this.SaveConfig<ISavePoint>().Value;
		}

		// Token: 0x170071EB RID: 29163
		// (get) Token: 0x060172B6 RID: 94902 RVA: 0x0034DB98 File Offset: 0x0034BD98
		public int CustomIcon
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071EC RID: 29164
		// (get) Token: 0x060172B7 RID: 94903 RVA: 0x0034DBD8 File Offset: 0x0034BDD8
		public int CustomTrackUiPrefabId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060172B8 RID: 94904 RVA: 0x0034DC18 File Offset: 0x0034BE18
		public IStuckCheckCondition? StuckCheck(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new IStuckCheckCondition?(default(IStuckCheckCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170071ED RID: 29165
		// (get) Token: 0x060172B9 RID: 94905 RVA: 0x0034DC7C File Offset: 0x0034BE7C
		public int StuckCheckLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170071EE RID: 29166
		// (get) Token: 0x060172BA RID: 94906 RVA: 0x0034DCA8 File Offset: 0x0034BEA8
		public ITrackAreaText? ModifyTrackAreaText
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new ITrackAreaText?(default(ITrackAreaText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071EF RID: 29167
		// (get) Token: 0x060172BB RID: 94907 RVA: 0x0034DD08 File Offset: 0x0034BF08
		public ITrackCustomBoard? TrackCustomBoard
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return new ITrackCustomBoard?(default(ITrackCustomBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170071F0 RID: 29168
		// (get) Token: 0x060172BC RID: 94908 RVA: 0x0034DD68 File Offset: 0x0034BF68
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060172BD RID: 94909 RVA: 0x0034DDA8 File Offset: 0x0034BFA8
		public static Offset<IChildQuestBtNode> CreateIChildQuestBtNode(FlatBufferBuilder builder, EBtNode Type = EBtNode.Start, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IFixProcessor> FixProcessorOffset = default(Offset<IFixProcessor>), bool _foldedForTree = false, bool Disabled = false, int RewardId = 0, EItemGetUiType RewardGetUiType = EItemGetUiType.None, Offset<IItemGetUiConfigSpecialQuest> RewardGetUiConfigOffset = default(Offset<IItemGetUiConfigSpecialQuest>), bool HideTip = false, StringOffset TidTipOffset = default(StringOffset), bool ShowTipBeforeEnterActions = false, bool ShowNavigation = false, ENavigationStyle NavigationStyle = ENavigationStyle.Default, bool AlwaysShowNavigation = false, VectorOffset EnterActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<ITrackTarget> TrackTargetOffset = default(Offset<ITrackTarget>), TChildQuestCondition Condition_type = TChildQuestCondition.NONE, int ConditionOffset = 0, bool HideUi = false, bool HideUiExceptTaskList = false, TSaveConfig SaveConfig_type = TSaveConfig.NONE, int SaveConfigOffset = 0, int CustomIcon = 0, int CustomTrackUiPrefabId = 0, VectorOffset StuckCheckOffset = default(VectorOffset), Offset<ITrackAreaText> ModifyTrackAreaTextOffset = default(Offset<ITrackAreaText>), Offset<ITrackCustomBoard> TrackCustomBoardOffset = default(Offset<ITrackCustomBoard>), ushort NullMask = 0)
		{
			builder.StartTable(30);
			IChildQuestBtNode.AddTrackCustomBoard(builder, TrackCustomBoardOffset);
			IChildQuestBtNode.AddModifyTrackAreaText(builder, ModifyTrackAreaTextOffset);
			IChildQuestBtNode.AddStuckCheck(builder, StuckCheckOffset);
			IChildQuestBtNode.AddCustomTrackUiPrefabId(builder, CustomTrackUiPrefabId);
			IChildQuestBtNode.AddCustomIcon(builder, CustomIcon);
			IChildQuestBtNode.AddSaveConfig(builder, SaveConfigOffset);
			IChildQuestBtNode.AddCondition(builder, ConditionOffset);
			IChildQuestBtNode.AddTrackTarget(builder, TrackTargetOffset);
			IChildQuestBtNode.AddFinishActions(builder, FinishActionsOffset);
			IChildQuestBtNode.AddEnterActions(builder, EnterActionsOffset);
			IChildQuestBtNode.AddTidTip(builder, TidTipOffset);
			IChildQuestBtNode.AddRewardGetUiConfig(builder, RewardGetUiConfigOffset);
			IChildQuestBtNode.AddRewardId(builder, RewardId);
			IChildQuestBtNode.AddFixProcessor(builder, FixProcessorOffset);
			IChildQuestBtNode.AddDesc(builder, DescOffset);
			IChildQuestBtNode.AddId(builder, Id);
			IChildQuestBtNode.AddNullMask(builder, NullMask);
			IChildQuestBtNode.AddSaveConfigType(builder, SaveConfig_type);
			IChildQuestBtNode.AddHideUiExceptTaskList(builder, HideUiExceptTaskList);
			IChildQuestBtNode.AddHideUi(builder, HideUi);
			IChildQuestBtNode.AddConditionType(builder, Condition_type);
			IChildQuestBtNode.AddAlwaysShowNavigation(builder, AlwaysShowNavigation);
			IChildQuestBtNode.AddNavigationStyle(builder, NavigationStyle);
			IChildQuestBtNode.AddShowNavigation(builder, ShowNavigation);
			IChildQuestBtNode.AddShowTipBeforeEnterActions(builder, ShowTipBeforeEnterActions);
			IChildQuestBtNode.AddHideTip(builder, HideTip);
			IChildQuestBtNode.AddRewardGetUiType(builder, RewardGetUiType);
			IChildQuestBtNode.AddDisabled(builder, Disabled);
			IChildQuestBtNode.Add_FoldedForTree(builder, _foldedForTree);
			IChildQuestBtNode.AddType(builder, Type);
			return IChildQuestBtNode.EndIChildQuestBtNode(builder);
		}

		// Token: 0x060172BE RID: 94910 RVA: 0x0034DEB0 File Offset: 0x0034C0B0
		public static void StartIChildQuestBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(30);
		}

		// Token: 0x060172BF RID: 94911 RVA: 0x0034DEBA File Offset: 0x0034C0BA
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060172C0 RID: 94912 RVA: 0x0034DEC5 File Offset: 0x0034C0C5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060172C1 RID: 94913 RVA: 0x0034DED0 File Offset: 0x0034C0D0
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x060172C2 RID: 94914 RVA: 0x0034DEE0 File Offset: 0x0034C0E0
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x060172C3 RID: 94915 RVA: 0x0034DEF0 File Offset: 0x0034C0F0
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x060172C4 RID: 94916 RVA: 0x0034DEFB File Offset: 0x0034C0FB
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x060172C5 RID: 94917 RVA: 0x0034DF06 File Offset: 0x0034C106
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(6, rewardId, 0);
		}

		// Token: 0x060172C6 RID: 94918 RVA: 0x0034DF11 File Offset: 0x0034C111
		public static void AddRewardGetUiType(FlatBufferBuilder builder, EItemGetUiType rewardGetUiType)
		{
			builder.AddByte(7, (byte)rewardGetUiType, 0);
		}

		// Token: 0x060172C7 RID: 94919 RVA: 0x0034DF1C File Offset: 0x0034C11C
		public static void AddRewardGetUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> rewardGetUiConfigOffset)
		{
			builder.AddOffset(8, rewardGetUiConfigOffset.Value, 0);
		}

		// Token: 0x060172C8 RID: 94920 RVA: 0x0034DF2C File Offset: 0x0034C12C
		public static void AddHideTip(FlatBufferBuilder builder, bool hideTip)
		{
			builder.AddBool(9, hideTip, false);
		}

		// Token: 0x060172C9 RID: 94921 RVA: 0x0034DF38 File Offset: 0x0034C138
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(10, tidTipOffset.Value, 0);
		}

		// Token: 0x060172CA RID: 94922 RVA: 0x0034DF49 File Offset: 0x0034C149
		public static void AddShowTipBeforeEnterActions(FlatBufferBuilder builder, bool showTipBeforeEnterActions)
		{
			builder.AddBool(11, showTipBeforeEnterActions, false);
		}

		// Token: 0x060172CB RID: 94923 RVA: 0x0034DF55 File Offset: 0x0034C155
		public static void AddShowNavigation(FlatBufferBuilder builder, bool showNavigation)
		{
			builder.AddBool(12, showNavigation, false);
		}

		// Token: 0x060172CC RID: 94924 RVA: 0x0034DF61 File Offset: 0x0034C161
		public static void AddNavigationStyle(FlatBufferBuilder builder, ENavigationStyle navigationStyle)
		{
			builder.AddByte(13, (byte)navigationStyle, 0);
		}

		// Token: 0x060172CD RID: 94925 RVA: 0x0034DF6D File Offset: 0x0034C16D
		public static void AddAlwaysShowNavigation(FlatBufferBuilder builder, bool alwaysShowNavigation)
		{
			builder.AddBool(14, alwaysShowNavigation, false);
		}

		// Token: 0x060172CE RID: 94926 RVA: 0x0034DF79 File Offset: 0x0034C179
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(15, enterActionsOffset.Value, 0);
		}

		// Token: 0x060172CF RID: 94927 RVA: 0x0034DF8C File Offset: 0x0034C18C
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060172D0 RID: 94928 RVA: 0x0034DFCC File Offset: 0x0034C1CC
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172D1 RID: 94929 RVA: 0x0034DFE6 File Offset: 0x0034C1E6
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172D2 RID: 94930 RVA: 0x0034E004 File Offset: 0x0034C204
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060172D3 RID: 94931 RVA: 0x0034E01D File Offset: 0x0034C21D
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060172D4 RID: 94932 RVA: 0x0034E028 File Offset: 0x0034C228
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(16, finishActionsOffset.Value, 0);
		}

		// Token: 0x060172D5 RID: 94933 RVA: 0x0034E03C File Offset: 0x0034C23C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060172D6 RID: 94934 RVA: 0x0034E07C File Offset: 0x0034C27C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172D7 RID: 94935 RVA: 0x0034E096 File Offset: 0x0034C296
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172D8 RID: 94936 RVA: 0x0034E0B4 File Offset: 0x0034C2B4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060172D9 RID: 94937 RVA: 0x0034E0CD File Offset: 0x0034C2CD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060172DA RID: 94938 RVA: 0x0034E0D8 File Offset: 0x0034C2D8
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<ITrackTarget> trackTargetOffset)
		{
			builder.AddOffset(17, trackTargetOffset.Value, 0);
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x0034E0E9 File Offset: 0x0034C2E9
		public static void AddConditionType(FlatBufferBuilder builder, TChildQuestCondition conditionType)
		{
			builder.AddByte(18, (byte)conditionType, 0);
		}

		// Token: 0x060172DC RID: 94940 RVA: 0x0034E0F5 File Offset: 0x0034C2F5
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(19, conditionOffset, 0);
		}

		// Token: 0x060172DD RID: 94941 RVA: 0x0034E101 File Offset: 0x0034C301
		public static void AddHideUi(FlatBufferBuilder builder, bool hideUi)
		{
			builder.AddBool(20, hideUi, false);
		}

		// Token: 0x060172DE RID: 94942 RVA: 0x0034E10D File Offset: 0x0034C30D
		public static void AddHideUiExceptTaskList(FlatBufferBuilder builder, bool hideUiExceptTaskList)
		{
			builder.AddBool(21, hideUiExceptTaskList, false);
		}

		// Token: 0x060172DF RID: 94943 RVA: 0x0034E119 File Offset: 0x0034C319
		public static void AddSaveConfigType(FlatBufferBuilder builder, TSaveConfig saveConfigType)
		{
			builder.AddByte(22, (byte)saveConfigType, 0);
		}

		// Token: 0x060172E0 RID: 94944 RVA: 0x0034E125 File Offset: 0x0034C325
		public static void AddSaveConfig(FlatBufferBuilder builder, int saveConfigOffset)
		{
			builder.AddOffset(23, saveConfigOffset, 0);
		}

		// Token: 0x060172E1 RID: 94945 RVA: 0x0034E131 File Offset: 0x0034C331
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(24, customIcon, 0);
		}

		// Token: 0x060172E2 RID: 94946 RVA: 0x0034E13D File Offset: 0x0034C33D
		public static void AddCustomTrackUiPrefabId(FlatBufferBuilder builder, int customTrackUiPrefabId)
		{
			builder.AddInt(25, customTrackUiPrefabId, 0);
		}

		// Token: 0x060172E3 RID: 94947 RVA: 0x0034E149 File Offset: 0x0034C349
		public static void AddStuckCheck(FlatBufferBuilder builder, VectorOffset stuckCheckOffset)
		{
			builder.AddOffset(26, stuckCheckOffset.Value, 0);
		}

		// Token: 0x060172E4 RID: 94948 RVA: 0x0034E15C File Offset: 0x0034C35C
		public static VectorOffset CreateStuckCheckVector(FlatBufferBuilder builder, Offset<IStuckCheckCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060172E5 RID: 94949 RVA: 0x0034E19C File Offset: 0x0034C39C
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, Offset<IStuckCheckCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStuckCheckCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172E6 RID: 94950 RVA: 0x0034E1B6 File Offset: 0x0034C3B6
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStuckCheckCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStuckCheckCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060172E7 RID: 94951 RVA: 0x0034E1D4 File Offset: 0x0034C3D4
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStuckCheckCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x0034E1ED File Offset: 0x0034C3ED
		public static void StartStuckCheckVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060172E9 RID: 94953 RVA: 0x0034E1F8 File Offset: 0x0034C3F8
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(27, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x060172EA RID: 94954 RVA: 0x0034E209 File Offset: 0x0034C409
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoard> trackCustomBoardOffset)
		{
			builder.AddOffset(28, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x060172EB RID: 94955 RVA: 0x0034E21A File Offset: 0x0034C41A
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(29, nullMask, 0);
		}

		// Token: 0x060172EC RID: 94956 RVA: 0x0034E226 File Offset: 0x0034C426
		public static Offset<IChildQuestBtNode> EndIChildQuestBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestBtNode>(builder.EndTable());
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0034E234 File Offset: 0x0034C434
		public IChildQuestBtNodeT UnPack()
		{
			IChildQuestBtNodeT childQuestBtNodeT = new IChildQuestBtNodeT();
			this.UnPackTo(childQuestBtNodeT);
			return childQuestBtNodeT;
		}

		// Token: 0x060172EE RID: 94958 RVA: 0x0034E250 File Offset: 0x0034C450
		public void UnPackTo(IChildQuestBtNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.FixProcessor = ((this.FixProcessor != null) ? this.FixProcessor.Value.UnPack() : null);
			_o._FoldedForTree = this._FoldedForTree;
			_o.Disabled = this.Disabled;
			_o.RewardId = this.RewardId;
			_o.RewardGetUiType = this.RewardGetUiType;
			_o.RewardGetUiConfig = ((this.RewardGetUiConfig != null) ? this.RewardGetUiConfig.Value.UnPack() : null);
			_o.HideTip = this.HideTip;
			_o.TidTip = this.TidTip;
			_o.ShowTipBeforeEnterActions = this.ShowTipBeforeEnterActions;
			_o.ShowNavigation = this.ShowNavigation;
			_o.NavigationStyle = this.NavigationStyle;
			_o.AlwaysShowNavigation = this.AlwaysShowNavigation;
			_o.EnterActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EnterActionsLength; i++)
			{
				_o.EnterActions.Add((this.EnterActions(i) != null) ? this.EnterActions(i).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FinishActionsLength; j++)
			{
				_o.FinishActions.Add((this.FinishActions(j) != null) ? this.FinishActions(j).Value.UnPack() : null);
			}
			_o.TrackTarget = ((this.TrackTarget != null) ? this.TrackTarget.Value.UnPack() : null);
			_o.Condition = new TChildQuestConditionUnion();
			_o.Condition.Type = this.ConditionType;
			switch (this.ConditionType)
			{
			case TChildQuestCondition.IAtomicProcess:
				_o.Condition.Value = ((this.Condition<IAtomicProcess>() != null) ? this.Condition<IAtomicProcess>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IAwakeAndLoadEntityCondition:
				_o.Condition.Value = ((this.Condition<IAwakeAndLoadEntityCondition>() != null) ? this.Condition<IAwakeAndLoadEntityCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckActivityStateCondition:
				_o.Condition.Value = ((this.Condition<ICheckActivityStateCondition>() != null) ? this.Condition<ICheckActivityStateCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckClientConditionGroupQuestCondition:
				_o.Condition.Value = ((this.Condition<ICheckClientConditionGroupQuestCondition>() != null) ? this.Condition<ICheckClientConditionGroupQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckConditionGroupQuestCondition:
				_o.Condition.Value = ((this.Condition<ICheckConditionGroupQuestCondition>() != null) ? this.Condition<ICheckConditionGroupQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckEntityStateQuestCondition:
				_o.Condition.Value = ((this.Condition<ICheckEntityStateQuestCondition>() != null) ? this.Condition<ICheckEntityStateQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckLevelPlayQuestCondition:
				_o.Condition.Value = ((this.Condition<ICheckLevelPlayQuestCondition>() != null) ? this.Condition<ICheckLevelPlayQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckPlayerInputCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerInputCondition>() != null) ? this.Condition<ICheckPlayerInputCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckSpringFestivalGameplayCompleted:
				_o.Condition.Value = ((this.Condition<ICheckSpringFestivalGameplayCompleted>() != null) ? this.Condition<ICheckSpringFestivalGameplayCompleted>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckTargetBattleAttributeCondition:
				_o.Condition.Value = ((this.Condition<ICheckTargetBattleAttributeCondition>() != null) ? this.Condition<ICheckTargetBattleAttributeCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckTrapDefenseEventCondition:
				_o.Condition.Value = ((this.Condition<ICheckTrapDefenseEventCondition>() != null) ? this.Condition<ICheckTrapDefenseEventCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICheckUiGameQuestCondition:
				_o.Condition.Value = ((this.Condition<ICheckUiGameQuestCondition>() != null) ? this.Condition<ICheckUiGameQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICompareActorVar:
				_o.Condition.Value = ((this.Condition<ICompareActorVar>() != null) ? this.Condition<ICompareActorVar>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICompareVarConditionInChildQuest:
				_o.Condition.Value = ((this.Condition<ICompareVarConditionInChildQuest>() != null) ? this.Condition<ICompareVarConditionInChildQuest>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ICrossSceneSyncKillMonster:
				_o.Condition.Value = ((this.Condition<ICrossSceneSyncKillMonster>() != null) ? this.Condition<ICrossSceneSyncKillMonster>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IDetectCombatState2Condition:
				_o.Condition.Value = ((this.Condition<IDetectCombatState2Condition>() != null) ? this.Condition<IDetectCombatState2Condition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IDetectCombatStateCondition:
				_o.Condition.Value = ((this.Condition<IDetectCombatStateCondition>() != null) ? this.Condition<IDetectCombatStateCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IDoInteractQuestCondition:
				_o.Condition.Value = ((this.Condition<IDoInteractQuestCondition>() != null) ? this.Condition<IDoInteractQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IEnterDungeonCondition:
				_o.Condition.Value = ((this.Condition<IEnterDungeonCondition>() != null) ? this.Condition<IEnterDungeonCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishArcadeGameplay:
				_o.Condition.Value = ((this.Condition<IFinishArcadeGameplay>() != null) ? this.Condition<IFinishArcadeGameplay>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishBvbChallenge:
				_o.Condition.Value = ((this.Condition<IFinishBvbChallenge>() != null) ? this.Condition<IFinishBvbChallenge>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishDungeonQuestCondition:
				_o.Condition.Value = ((this.Condition<IFinishDungeonQuestCondition>() != null) ? this.Condition<IFinishDungeonQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishFlipperCondition:
				_o.Condition.Value = ((this.Condition<IFinishFlipperCondition>() != null) ? this.Condition<IFinishFlipperCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishJellyfishReturnCondition:
				_o.Condition.Value = ((this.Condition<IFinishJellyfishReturnCondition>() != null) ? this.Condition<IFinishJellyfishReturnCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishKuroSimpleCombatKillMonster:
				_o.Condition.Value = ((this.Condition<IFinishKuroSimpleCombatKillMonster>() != null) ? this.Condition<IFinishKuroSimpleCombatKillMonster>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishKurotatoCondition:
				_o.Condition.Value = ((this.Condition<IFinishKurotatoCondition>() != null) ? this.Condition<IFinishKurotatoCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishRhythmSpaceshipCondition:
				_o.Condition.Value = ((this.Condition<IFinishRhythmSpaceshipCondition>() != null) ? this.Condition<IFinishRhythmSpaceshipCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishRoleTowerCondition:
				_o.Condition.Value = ((this.Condition<IFinishRoleTowerCondition>() != null) ? this.Condition<IFinishRoleTowerCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishRollBlock:
				_o.Condition.Value = ((this.Condition<IFinishRollBlock>() != null) ? this.Condition<IFinishRollBlock>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishSurvivorsRougeCondition:
				_o.Condition.Value = ((this.Condition<IFinishSurvivorsRougeCondition>() != null) ? this.Condition<IFinishSurvivorsRougeCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishTetris:
				_o.Condition.Value = ((this.Condition<IFinishTetris>() != null) ? this.Condition<IFinishTetris>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IFinishTrapDefenseCondition:
				_o.Condition.Value = ((this.Condition<IFinishTrapDefenseCondition>() != null) ? this.Condition<IFinishTrapDefenseCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IGetItemQuestCondition:
				_o.Condition.Value = ((this.Condition<IGetItemQuestCondition>() != null) ? this.Condition<IGetItemQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IGetSkillQuestCondition:
				_o.Condition.Value = ((this.Condition<IGetSkillQuestCondition>() != null) ? this.Condition<IGetSkillQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IGuideCondition:
				_o.Condition.Value = ((this.Condition<IGuideCondition>() != null) ? this.Condition<IGuideCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IHandInItemsCondition:
				_o.Condition.Value = ((this.Condition<IHandInItemsCondition>() != null) ? this.Condition<IHandInItemsCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IInformationViewCheckCondition:
				_o.Condition.Value = ((this.Condition<IInformationViewCheckCondition>() != null) ? this.Condition<IInformationViewCheckCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IKillChildQuestCondition:
				_o.Condition.Value = ((this.Condition<IKillChildQuestCondition>() != null) ? this.Condition<IKillChildQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ILeaveDungeonCondition:
				_o.Condition.Value = ((this.Condition<ILeaveDungeonCondition>() != null) ? this.Condition<ILeaveDungeonCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IListenToEvent:
				_o.Condition.Value = ((this.Condition<IListenToEvent>() != null) ? this.Condition<IListenToEvent>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IMonsterCreatorQuestCondition:
				_o.Condition.Value = ((this.Condition<IMonsterCreatorQuestCondition>() != null) ? this.Condition<IMonsterCreatorQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.INewHandInItemsCondition:
				_o.Condition.Value = ((this.Condition<INewHandInItemsCondition>() != null) ? this.Condition<INewHandInItemsCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IParallaxAlignQuestCondition:
				_o.Condition.Value = ((this.Condition<IParallaxAlignQuestCondition>() != null) ? this.Condition<IParallaxAlignQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IParkourQuestCondition:
				_o.Condition.Value = ((this.Condition<IParkourQuestCondition>() != null) ? this.Condition<IParkourQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IPlaybackShowTimelineQuestCondition:
				_o.Condition.Value = ((this.Condition<IPlaybackShowTimelineQuestCondition>() != null) ? this.Condition<IPlaybackShowTimelineQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IPlayFlowQuestCondition:
				_o.Condition.Value = ((this.Condition<IPlayFlowQuestCondition>() != null) ? this.Condition<IPlayFlowQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IProgramSpecialProcess:
				_o.Condition.Value = ((this.Condition<IProgramSpecialProcess>() != null) ? this.Condition<IProgramSpecialProcess>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IReachAreaQuestCondition:
				_o.Condition.Value = ((this.Condition<IReachAreaQuestCondition>() != null) ? this.Condition<IReachAreaQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IReadMailCondition:
				_o.Condition.Value = ((this.Condition<IReadMailCondition>() != null) ? this.Condition<IReadMailCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IReadPhoneMessageQuestCondition:
				_o.Condition.Value = ((this.Condition<IReadPhoneMessageQuestCondition>() != null) ? this.Condition<IReadPhoneMessageQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IReceiveTelecomChildQuestCondition:
				_o.Condition.Value = ((this.Condition<IReceiveTelecomChildQuestCondition>() != null) ? this.Condition<IReceiveTelecomChildQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IScheduleTimeCondition:
				_o.Condition.Value = ((this.Condition<IScheduleTimeCondition>() != null) ? this.Condition<IScheduleTimeCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IShowUiCondition:
				_o.Condition.Value = ((this.Condition<IShowUiCondition>() != null) ? this.Condition<IShowUiCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ITakePhoto2Condition:
				_o.Condition.Value = ((this.Condition<ITakePhoto2Condition>() != null) ? this.Condition<ITakePhoto2Condition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ITakePhotoCondition:
				_o.Condition.Value = ((this.Condition<ITakePhotoCondition>() != null) ? this.Condition<ITakePhotoCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ITimerQuestCondition:
				_o.Condition.Value = ((this.Condition<ITimerQuestCondition>() != null) ? this.Condition<ITimerQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.ITimeScaledPhotograph:
				_o.Condition.Value = ((this.Condition<ITimeScaledPhotograph>() != null) ? this.Condition<ITimeScaledPhotograph>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IUseItemCondition:
				_o.Condition.Value = ((this.Condition<IUseItemCondition>() != null) ? this.Condition<IUseItemCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IUseSkillQuestCondition:
				_o.Condition.Value = ((this.Condition<IUseSkillQuestCondition>() != null) ? this.Condition<IUseSkillQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IUseWeatherSwitchCondition:
				_o.Condition.Value = ((this.Condition<IUseWeatherSwitchCondition>() != null) ? this.Condition<IUseWeatherSwitchCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IVisionSystemQuestCondition:
				_o.Condition.Value = ((this.Condition<IVisionSystemQuestCondition>() != null) ? this.Condition<IVisionSystemQuestCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IWaitBattleCondition:
				_o.Condition.Value = ((this.Condition<IWaitBattleCondition>() != null) ? this.Condition<IWaitBattleCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IWaitTimeCondition:
				_o.Condition.Value = ((this.Condition<IWaitTimeCondition>() != null) ? this.Condition<IWaitTimeCondition>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IWaitUntilLevelSequenceReachMark:
				_o.Condition.Value = ((this.Condition<IWaitUntilLevelSequenceReachMark>() != null) ? this.Condition<IWaitUntilLevelSequenceReachMark>().Value.UnPack() : null);
				break;
			case TChildQuestCondition.IWalkingPatternCondition:
				_o.Condition.Value = ((this.Condition<IWalkingPatternCondition>() != null) ? this.Condition<IWalkingPatternCondition>().Value.UnPack() : null);
				break;
			}
			_o.HideUi = this.HideUi;
			_o.HideUiExceptTaskList = this.HideUiExceptTaskList;
			_o.SaveConfig = new TSaveConfigUnion();
			_o.SaveConfig.Type = this.SaveConfigType;
			TSaveConfig saveConfigType = this.SaveConfigType;
			if (saveConfigType != TSaveConfig.ISaveNew)
			{
				if (saveConfigType == TSaveConfig.ISavePoint)
				{
					_o.SaveConfig.Value = ((this.SaveConfig<ISavePoint>() != null) ? this.SaveConfig<ISavePoint>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SaveConfig.Value = ((this.SaveConfig<ISaveNew>() != null) ? this.SaveConfig<ISaveNew>().Value.UnPack() : null);
			}
			_o.CustomIcon = this.CustomIcon;
			_o.CustomTrackUiPrefabId = this.CustomTrackUiPrefabId;
			_o.StuckCheck = new List<IStuckCheckConditionT>();
			for (int k = 0; k < this.StuckCheckLength; k++)
			{
				_o.StuckCheck.Add((this.StuckCheck(k) != null) ? this.StuckCheck(k).Value.UnPack() : null);
			}
			_o.ModifyTrackAreaText = ((this.ModifyTrackAreaText != null) ? this.ModifyTrackAreaText.Value.UnPack() : null);
			_o.TrackCustomBoard = ((this.TrackCustomBoard != null) ? this.TrackCustomBoard.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x0034F644 File Offset: 0x0034D844
		public static Offset<IChildQuestBtNode> Pack(FlatBufferBuilder builder, IChildQuestBtNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildQuestBtNode>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IFixProcessor> fixProcessorOffset = (_o.FixProcessor == null) ? default(Offset<IFixProcessor>) : IFixProcessor.Pack(builder, _o.FixProcessor);
			Offset<IItemGetUiConfigSpecialQuest> rewardGetUiConfigOffset = (_o.RewardGetUiConfig == null) ? default(Offset<IItemGetUiConfigSpecialQuest>) : IItemGetUiConfigSpecialQuest.Pack(builder, _o.RewardGetUiConfig);
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			VectorOffset enterActionsOffset = default(VectorOffset);
			if (_o.EnterActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EnterActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EnterActions[i]);
				}
				enterActionsOffset = IChildQuestBtNode.CreateEnterActionsVector(builder, array);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.FinishActions[j]);
				}
				finishActionsOffset = IChildQuestBtNode.CreateFinishActionsVector(builder, array2);
			}
			Offset<ITrackTarget> trackTargetOffset = (_o.TrackTarget == null) ? default(Offset<ITrackTarget>) : ITrackTarget.Pack(builder, _o.TrackTarget);
			TChildQuestCondition condition_type = (_o.Condition == null) ? TChildQuestCondition.NONE : _o.Condition.Type;
			int conditionOffset = (_o.Condition == null) ? 0 : TChildQuestConditionUnion.Pack(builder, _o.Condition);
			TSaveConfig saveConfig_type = (_o.SaveConfig == null) ? TSaveConfig.NONE : _o.SaveConfig.Type;
			int saveConfigOffset = (_o.SaveConfig == null) ? 0 : TSaveConfigUnion.Pack(builder, _o.SaveConfig);
			VectorOffset stuckCheckOffset = default(VectorOffset);
			if (_o.StuckCheck != null)
			{
				Offset<IStuckCheckCondition>[] array3 = new Offset<IStuckCheckCondition>[_o.StuckCheck.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IStuckCheckCondition.Pack(builder, _o.StuckCheck[k]);
				}
				stuckCheckOffset = IChildQuestBtNode.CreateStuckCheckVector(builder, array3);
			}
			Offset<ITrackAreaText> modifyTrackAreaTextOffset = (_o.ModifyTrackAreaText == null) ? default(Offset<ITrackAreaText>) : ITrackAreaText.Pack(builder, _o.ModifyTrackAreaText);
			Offset<ITrackCustomBoard> trackCustomBoardOffset = (_o.TrackCustomBoard == null) ? default(Offset<ITrackCustomBoard>) : ITrackCustomBoard.Pack(builder, _o.TrackCustomBoard);
			return IChildQuestBtNode.CreateIChildQuestBtNode(builder, _o.Type, _o.Id, descOffset, fixProcessorOffset, _o._FoldedForTree, _o.Disabled, _o.RewardId, _o.RewardGetUiType, rewardGetUiConfigOffset, _o.HideTip, tidTipOffset, _o.ShowTipBeforeEnterActions, _o.ShowNavigation, _o.NavigationStyle, _o.AlwaysShowNavigation, enterActionsOffset, finishActionsOffset, trackTargetOffset, condition_type, conditionOffset, _o.HideUi, _o.HideUiExceptTaskList, saveConfig_type, saveConfigOffset, _o.CustomIcon, _o.CustomTrackUiPrefabId, stuckCheckOffset, modifyTrackAreaTextOffset, trackCustomBoardOffset, _o.NullMask);
		}

		// Token: 0x0400C022 RID: 49186
		private Table __p;
	}
}
