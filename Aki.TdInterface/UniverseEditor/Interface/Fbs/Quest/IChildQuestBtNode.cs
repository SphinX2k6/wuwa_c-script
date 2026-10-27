using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D88 RID: 15752
	public struct IChildQuestBtNode : IFlatbufferObject
	{
		// Token: 0x17006C1A RID: 27674
		// (get) Token: 0x06015D17 RID: 89367 RVA: 0x00325975 File Offset: 0x00323B75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D18 RID: 89368 RVA: 0x00325982 File Offset: 0x00323B82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D19 RID: 89369 RVA: 0x0032598C File Offset: 0x00323B8C
		public static IChildQuestBtNode GetRootAsIChildQuestBtNode(ByteBuffer _bb)
		{
			return IChildQuestBtNode.GetRootAsIChildQuestBtNode(_bb, default(IChildQuestBtNode));
		}

		// Token: 0x06015D1A RID: 89370 RVA: 0x003259A8 File Offset: 0x00323BA8
		public static IChildQuestBtNode GetRootAsIChildQuestBtNode(ByteBuffer _bb, IChildQuestBtNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D1B RID: 89371 RVA: 0x003259C5 File Offset: 0x00323BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D1C RID: 89372 RVA: 0x003259D4 File Offset: 0x00323BD4
		public IChildQuestBtNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C1B RID: 27675
		// (get) Token: 0x06015D1D RID: 89373 RVA: 0x003259E4 File Offset: 0x00323BE4
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

		// Token: 0x17006C1C RID: 27676
		// (get) Token: 0x06015D1E RID: 89374 RVA: 0x00325A20 File Offset: 0x00323C20
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

		// Token: 0x17006C1D RID: 27677
		// (get) Token: 0x06015D1F RID: 89375 RVA: 0x00325A5C File Offset: 0x00323C5C
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

		// Token: 0x06015D20 RID: 89376 RVA: 0x00325A93 File Offset: 0x00323C93
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015D21 RID: 89377 RVA: 0x00325AA2 File Offset: 0x00323CA2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006C1E RID: 27678
		// (get) Token: 0x06015D22 RID: 89378 RVA: 0x00325AB0 File Offset: 0x00323CB0
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

		// Token: 0x17006C1F RID: 27679
		// (get) Token: 0x06015D23 RID: 89379 RVA: 0x00325B10 File Offset: 0x00323D10
		public bool _FoldedForTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C20 RID: 27680
		// (get) Token: 0x06015D24 RID: 89380 RVA: 0x00325B50 File Offset: 0x00323D50
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C21 RID: 27681
		// (get) Token: 0x06015D25 RID: 89381 RVA: 0x00325B90 File Offset: 0x00323D90
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

		// Token: 0x17006C22 RID: 27682
		// (get) Token: 0x06015D26 RID: 89382 RVA: 0x00325BD0 File Offset: 0x00323DD0
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

		// Token: 0x17006C23 RID: 27683
		// (get) Token: 0x06015D27 RID: 89383 RVA: 0x00325C10 File Offset: 0x00323E10
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

		// Token: 0x17006C24 RID: 27684
		// (get) Token: 0x06015D28 RID: 89384 RVA: 0x00325C70 File Offset: 0x00323E70
		public bool HideTip
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C25 RID: 27685
		// (get) Token: 0x06015D29 RID: 89385 RVA: 0x00325CB0 File Offset: 0x00323EB0
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

		// Token: 0x06015D2A RID: 89386 RVA: 0x00325CE8 File Offset: 0x00323EE8
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06015D2B RID: 89387 RVA: 0x00325CF8 File Offset: 0x00323EF8
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17006C26 RID: 27686
		// (get) Token: 0x06015D2C RID: 89388 RVA: 0x00325D08 File Offset: 0x00323F08
		public bool ShowTipBeforeEnterActions
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C27 RID: 27687
		// (get) Token: 0x06015D2D RID: 89389 RVA: 0x00325D48 File Offset: 0x00323F48
		public bool ShowNavigation
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C28 RID: 27688
		// (get) Token: 0x06015D2E RID: 89390 RVA: 0x00325D88 File Offset: 0x00323F88
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

		// Token: 0x17006C29 RID: 27689
		// (get) Token: 0x06015D2F RID: 89391 RVA: 0x00325DC8 File Offset: 0x00323FC8
		public bool AlwaysShowNavigation
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015D30 RID: 89392 RVA: 0x00325E08 File Offset: 0x00324008
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C2A RID: 27690
		// (get) Token: 0x06015D31 RID: 89393 RVA: 0x00325E6C File Offset: 0x0032406C
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

		// Token: 0x06015D32 RID: 89394 RVA: 0x00325E98 File Offset: 0x00324098
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C2B RID: 27691
		// (get) Token: 0x06015D33 RID: 89395 RVA: 0x00325EFC File Offset: 0x003240FC
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

		// Token: 0x17006C2C RID: 27692
		// (get) Token: 0x06015D34 RID: 89396 RVA: 0x00325F28 File Offset: 0x00324128
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

		// Token: 0x17006C2D RID: 27693
		// (get) Token: 0x06015D35 RID: 89397 RVA: 0x00325F88 File Offset: 0x00324188
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

		// Token: 0x06015D36 RID: 89398 RVA: 0x00325FC8 File Offset: 0x003241C8
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015D37 RID: 89399 RVA: 0x00326010 File Offset: 0x00324210
		public IAtomicProcess ConditionAsIAtomicProcess()
		{
			return this.Condition<IAtomicProcess>().Value;
		}

		// Token: 0x06015D38 RID: 89400 RVA: 0x0032602C File Offset: 0x0032422C
		public IAwakeAndLoadEntityCondition ConditionAsIAwakeAndLoadEntityCondition()
		{
			return this.Condition<IAwakeAndLoadEntityCondition>().Value;
		}

		// Token: 0x06015D39 RID: 89401 RVA: 0x00326048 File Offset: 0x00324248
		public ICheckActivityStateCondition ConditionAsICheckActivityStateCondition()
		{
			return this.Condition<ICheckActivityStateCondition>().Value;
		}

		// Token: 0x06015D3A RID: 89402 RVA: 0x00326064 File Offset: 0x00324264
		public ICheckClientConditionGroupQuestCondition ConditionAsICheckClientConditionGroupQuestCondition()
		{
			return this.Condition<ICheckClientConditionGroupQuestCondition>().Value;
		}

		// Token: 0x06015D3B RID: 89403 RVA: 0x00326080 File Offset: 0x00324280
		public ICheckConditionGroupQuestCondition ConditionAsICheckConditionGroupQuestCondition()
		{
			return this.Condition<ICheckConditionGroupQuestCondition>().Value;
		}

		// Token: 0x06015D3C RID: 89404 RVA: 0x0032609C File Offset: 0x0032429C
		public ICheckEntityStateQuestCondition ConditionAsICheckEntityStateQuestCondition()
		{
			return this.Condition<ICheckEntityStateQuestCondition>().Value;
		}

		// Token: 0x06015D3D RID: 89405 RVA: 0x003260B8 File Offset: 0x003242B8
		public ICheckLevelPlayQuestCondition ConditionAsICheckLevelPlayQuestCondition()
		{
			return this.Condition<ICheckLevelPlayQuestCondition>().Value;
		}

		// Token: 0x06015D3E RID: 89406 RVA: 0x003260D4 File Offset: 0x003242D4
		public ICheckPlayerInputCondition ConditionAsICheckPlayerInputCondition()
		{
			return this.Condition<ICheckPlayerInputCondition>().Value;
		}

		// Token: 0x06015D3F RID: 89407 RVA: 0x003260F0 File Offset: 0x003242F0
		public ICheckSpringFestivalGameplayCompleted ConditionAsICheckSpringFestivalGameplayCompleted()
		{
			return this.Condition<ICheckSpringFestivalGameplayCompleted>().Value;
		}

		// Token: 0x06015D40 RID: 89408 RVA: 0x0032610C File Offset: 0x0032430C
		public ICheckTargetBattleAttributeCondition ConditionAsICheckTargetBattleAttributeCondition()
		{
			return this.Condition<ICheckTargetBattleAttributeCondition>().Value;
		}

		// Token: 0x06015D41 RID: 89409 RVA: 0x00326128 File Offset: 0x00324328
		public ICheckTrapDefenseEventCondition ConditionAsICheckTrapDefenseEventCondition()
		{
			return this.Condition<ICheckTrapDefenseEventCondition>().Value;
		}

		// Token: 0x06015D42 RID: 89410 RVA: 0x00326144 File Offset: 0x00324344
		public ICheckUiGameQuestCondition ConditionAsICheckUiGameQuestCondition()
		{
			return this.Condition<ICheckUiGameQuestCondition>().Value;
		}

		// Token: 0x06015D43 RID: 89411 RVA: 0x00326160 File Offset: 0x00324360
		public ICompareActorVar ConditionAsICompareActorVar()
		{
			return this.Condition<ICompareActorVar>().Value;
		}

		// Token: 0x06015D44 RID: 89412 RVA: 0x0032617C File Offset: 0x0032437C
		public ICompareVarConditionInChildQuest ConditionAsICompareVarConditionInChildQuest()
		{
			return this.Condition<ICompareVarConditionInChildQuest>().Value;
		}

		// Token: 0x06015D45 RID: 89413 RVA: 0x00326198 File Offset: 0x00324398
		public ICrossSceneSyncKillMonster ConditionAsICrossSceneSyncKillMonster()
		{
			return this.Condition<ICrossSceneSyncKillMonster>().Value;
		}

		// Token: 0x06015D46 RID: 89414 RVA: 0x003261B4 File Offset: 0x003243B4
		public IDetectCombatState2Condition ConditionAsIDetectCombatState2Condition()
		{
			return this.Condition<IDetectCombatState2Condition>().Value;
		}

		// Token: 0x06015D47 RID: 89415 RVA: 0x003261D0 File Offset: 0x003243D0
		public IDetectCombatStateCondition ConditionAsIDetectCombatStateCondition()
		{
			return this.Condition<IDetectCombatStateCondition>().Value;
		}

		// Token: 0x06015D48 RID: 89416 RVA: 0x003261EC File Offset: 0x003243EC
		public IDoInteractQuestCondition ConditionAsIDoInteractQuestCondition()
		{
			return this.Condition<IDoInteractQuestCondition>().Value;
		}

		// Token: 0x06015D49 RID: 89417 RVA: 0x00326208 File Offset: 0x00324408
		public IEnterDungeonCondition ConditionAsIEnterDungeonCondition()
		{
			return this.Condition<IEnterDungeonCondition>().Value;
		}

		// Token: 0x06015D4A RID: 89418 RVA: 0x00326224 File Offset: 0x00324424
		public IFinishArcadeGameplay ConditionAsIFinishArcadeGameplay()
		{
			return this.Condition<IFinishArcadeGameplay>().Value;
		}

		// Token: 0x06015D4B RID: 89419 RVA: 0x00326240 File Offset: 0x00324440
		public IFinishBvbChallenge ConditionAsIFinishBvbChallenge()
		{
			return this.Condition<IFinishBvbChallenge>().Value;
		}

		// Token: 0x06015D4C RID: 89420 RVA: 0x0032625C File Offset: 0x0032445C
		public IFinishDungeonQuestCondition ConditionAsIFinishDungeonQuestCondition()
		{
			return this.Condition<IFinishDungeonQuestCondition>().Value;
		}

		// Token: 0x06015D4D RID: 89421 RVA: 0x00326278 File Offset: 0x00324478
		public IFinishFlipperCondition ConditionAsIFinishFlipperCondition()
		{
			return this.Condition<IFinishFlipperCondition>().Value;
		}

		// Token: 0x06015D4E RID: 89422 RVA: 0x00326294 File Offset: 0x00324494
		public IFinishJellyfishReturnCondition ConditionAsIFinishJellyfishReturnCondition()
		{
			return this.Condition<IFinishJellyfishReturnCondition>().Value;
		}

		// Token: 0x06015D4F RID: 89423 RVA: 0x003262B0 File Offset: 0x003244B0
		public IFinishKuroSimpleCombatKillMonster ConditionAsIFinishKuroSimpleCombatKillMonster()
		{
			return this.Condition<IFinishKuroSimpleCombatKillMonster>().Value;
		}

		// Token: 0x06015D50 RID: 89424 RVA: 0x003262CC File Offset: 0x003244CC
		public IFinishKurotatoCondition ConditionAsIFinishKurotatoCondition()
		{
			return this.Condition<IFinishKurotatoCondition>().Value;
		}

		// Token: 0x06015D51 RID: 89425 RVA: 0x003262E8 File Offset: 0x003244E8
		public IFinishRhythmSpaceshipCondition ConditionAsIFinishRhythmSpaceshipCondition()
		{
			return this.Condition<IFinishRhythmSpaceshipCondition>().Value;
		}

		// Token: 0x06015D52 RID: 89426 RVA: 0x00326304 File Offset: 0x00324504
		public IFinishRoleTowerCondition ConditionAsIFinishRoleTowerCondition()
		{
			return this.Condition<IFinishRoleTowerCondition>().Value;
		}

		// Token: 0x06015D53 RID: 89427 RVA: 0x00326320 File Offset: 0x00324520
		public IFinishRollBlock ConditionAsIFinishRollBlock()
		{
			return this.Condition<IFinishRollBlock>().Value;
		}

		// Token: 0x06015D54 RID: 89428 RVA: 0x0032633C File Offset: 0x0032453C
		public IFinishSurvivorsRougeCondition ConditionAsIFinishSurvivorsRougeCondition()
		{
			return this.Condition<IFinishSurvivorsRougeCondition>().Value;
		}

		// Token: 0x06015D55 RID: 89429 RVA: 0x00326358 File Offset: 0x00324558
		public IFinishTetris ConditionAsIFinishTetris()
		{
			return this.Condition<IFinishTetris>().Value;
		}

		// Token: 0x06015D56 RID: 89430 RVA: 0x00326374 File Offset: 0x00324574
		public IFinishTrapDefenseCondition ConditionAsIFinishTrapDefenseCondition()
		{
			return this.Condition<IFinishTrapDefenseCondition>().Value;
		}

		// Token: 0x06015D57 RID: 89431 RVA: 0x00326390 File Offset: 0x00324590
		public IGetItemQuestCondition ConditionAsIGetItemQuestCondition()
		{
			return this.Condition<IGetItemQuestCondition>().Value;
		}

		// Token: 0x06015D58 RID: 89432 RVA: 0x003263AC File Offset: 0x003245AC
		public IGetSkillQuestCondition ConditionAsIGetSkillQuestCondition()
		{
			return this.Condition<IGetSkillQuestCondition>().Value;
		}

		// Token: 0x06015D59 RID: 89433 RVA: 0x003263C8 File Offset: 0x003245C8
		public IGuideCondition ConditionAsIGuideCondition()
		{
			return this.Condition<IGuideCondition>().Value;
		}

		// Token: 0x06015D5A RID: 89434 RVA: 0x003263E4 File Offset: 0x003245E4
		public IHandInItemsCondition ConditionAsIHandInItemsCondition()
		{
			return this.Condition<IHandInItemsCondition>().Value;
		}

		// Token: 0x06015D5B RID: 89435 RVA: 0x00326400 File Offset: 0x00324600
		public IInformationViewCheckCondition ConditionAsIInformationViewCheckCondition()
		{
			return this.Condition<IInformationViewCheckCondition>().Value;
		}

		// Token: 0x06015D5C RID: 89436 RVA: 0x0032641C File Offset: 0x0032461C
		public IKillChildQuestCondition ConditionAsIKillChildQuestCondition()
		{
			return this.Condition<IKillChildQuestCondition>().Value;
		}

		// Token: 0x06015D5D RID: 89437 RVA: 0x00326438 File Offset: 0x00324638
		public ILeaveDungeonCondition ConditionAsILeaveDungeonCondition()
		{
			return this.Condition<ILeaveDungeonCondition>().Value;
		}

		// Token: 0x06015D5E RID: 89438 RVA: 0x00326454 File Offset: 0x00324654
		public IListenToEvent ConditionAsIListenToEvent()
		{
			return this.Condition<IListenToEvent>().Value;
		}

		// Token: 0x06015D5F RID: 89439 RVA: 0x00326470 File Offset: 0x00324670
		public IMonsterCreatorQuestCondition ConditionAsIMonsterCreatorQuestCondition()
		{
			return this.Condition<IMonsterCreatorQuestCondition>().Value;
		}

		// Token: 0x06015D60 RID: 89440 RVA: 0x0032648C File Offset: 0x0032468C
		public INewHandInItemsCondition ConditionAsINewHandInItemsCondition()
		{
			return this.Condition<INewHandInItemsCondition>().Value;
		}

		// Token: 0x06015D61 RID: 89441 RVA: 0x003264A8 File Offset: 0x003246A8
		public IParallaxAlignQuestCondition ConditionAsIParallaxAlignQuestCondition()
		{
			return this.Condition<IParallaxAlignQuestCondition>().Value;
		}

		// Token: 0x06015D62 RID: 89442 RVA: 0x003264C4 File Offset: 0x003246C4
		public IParkourQuestCondition ConditionAsIParkourQuestCondition()
		{
			return this.Condition<IParkourQuestCondition>().Value;
		}

		// Token: 0x06015D63 RID: 89443 RVA: 0x003264E0 File Offset: 0x003246E0
		public IPlaybackShowTimelineQuestCondition ConditionAsIPlaybackShowTimelineQuestCondition()
		{
			return this.Condition<IPlaybackShowTimelineQuestCondition>().Value;
		}

		// Token: 0x06015D64 RID: 89444 RVA: 0x003264FC File Offset: 0x003246FC
		public IPlayFlowQuestCondition ConditionAsIPlayFlowQuestCondition()
		{
			return this.Condition<IPlayFlowQuestCondition>().Value;
		}

		// Token: 0x06015D65 RID: 89445 RVA: 0x00326518 File Offset: 0x00324718
		public IProgramSpecialProcess ConditionAsIProgramSpecialProcess()
		{
			return this.Condition<IProgramSpecialProcess>().Value;
		}

		// Token: 0x06015D66 RID: 89446 RVA: 0x00326534 File Offset: 0x00324734
		public IReachAreaQuestCondition ConditionAsIReachAreaQuestCondition()
		{
			return this.Condition<IReachAreaQuestCondition>().Value;
		}

		// Token: 0x06015D67 RID: 89447 RVA: 0x00326550 File Offset: 0x00324750
		public IReadMailCondition ConditionAsIReadMailCondition()
		{
			return this.Condition<IReadMailCondition>().Value;
		}

		// Token: 0x06015D68 RID: 89448 RVA: 0x0032656C File Offset: 0x0032476C
		public IReadPhoneMessageQuestCondition ConditionAsIReadPhoneMessageQuestCondition()
		{
			return this.Condition<IReadPhoneMessageQuestCondition>().Value;
		}

		// Token: 0x06015D69 RID: 89449 RVA: 0x00326588 File Offset: 0x00324788
		public IReceiveTelecomChildQuestCondition ConditionAsIReceiveTelecomChildQuestCondition()
		{
			return this.Condition<IReceiveTelecomChildQuestCondition>().Value;
		}

		// Token: 0x06015D6A RID: 89450 RVA: 0x003265A4 File Offset: 0x003247A4
		public IScheduleTimeCondition ConditionAsIScheduleTimeCondition()
		{
			return this.Condition<IScheduleTimeCondition>().Value;
		}

		// Token: 0x06015D6B RID: 89451 RVA: 0x003265C0 File Offset: 0x003247C0
		public IShowUiCondition ConditionAsIShowUiCondition()
		{
			return this.Condition<IShowUiCondition>().Value;
		}

		// Token: 0x06015D6C RID: 89452 RVA: 0x003265DC File Offset: 0x003247DC
		public ITakePhoto2Condition ConditionAsITakePhoto2Condition()
		{
			return this.Condition<ITakePhoto2Condition>().Value;
		}

		// Token: 0x06015D6D RID: 89453 RVA: 0x003265F8 File Offset: 0x003247F8
		public ITakePhotoCondition ConditionAsITakePhotoCondition()
		{
			return this.Condition<ITakePhotoCondition>().Value;
		}

		// Token: 0x06015D6E RID: 89454 RVA: 0x00326614 File Offset: 0x00324814
		public ITimerQuestCondition ConditionAsITimerQuestCondition()
		{
			return this.Condition<ITimerQuestCondition>().Value;
		}

		// Token: 0x06015D6F RID: 89455 RVA: 0x00326630 File Offset: 0x00324830
		public ITimeScaledPhotograph ConditionAsITimeScaledPhotograph()
		{
			return this.Condition<ITimeScaledPhotograph>().Value;
		}

		// Token: 0x06015D70 RID: 89456 RVA: 0x0032664C File Offset: 0x0032484C
		public IUseItemCondition ConditionAsIUseItemCondition()
		{
			return this.Condition<IUseItemCondition>().Value;
		}

		// Token: 0x06015D71 RID: 89457 RVA: 0x00326668 File Offset: 0x00324868
		public IUseSkillQuestCondition ConditionAsIUseSkillQuestCondition()
		{
			return this.Condition<IUseSkillQuestCondition>().Value;
		}

		// Token: 0x06015D72 RID: 89458 RVA: 0x00326684 File Offset: 0x00324884
		public IUseWeatherSwitchCondition ConditionAsIUseWeatherSwitchCondition()
		{
			return this.Condition<IUseWeatherSwitchCondition>().Value;
		}

		// Token: 0x06015D73 RID: 89459 RVA: 0x003266A0 File Offset: 0x003248A0
		public IVisionSystemQuestCondition ConditionAsIVisionSystemQuestCondition()
		{
			return this.Condition<IVisionSystemQuestCondition>().Value;
		}

		// Token: 0x06015D74 RID: 89460 RVA: 0x003266BC File Offset: 0x003248BC
		public IWaitBattleCondition ConditionAsIWaitBattleCondition()
		{
			return this.Condition<IWaitBattleCondition>().Value;
		}

		// Token: 0x06015D75 RID: 89461 RVA: 0x003266D8 File Offset: 0x003248D8
		public IWaitTimeCondition ConditionAsIWaitTimeCondition()
		{
			return this.Condition<IWaitTimeCondition>().Value;
		}

		// Token: 0x06015D76 RID: 89462 RVA: 0x003266F4 File Offset: 0x003248F4
		public IWaitUntilLevelSequenceReachMark ConditionAsIWaitUntilLevelSequenceReachMark()
		{
			return this.Condition<IWaitUntilLevelSequenceReachMark>().Value;
		}

		// Token: 0x06015D77 RID: 89463 RVA: 0x00326710 File Offset: 0x00324910
		public IWalkingPatternCondition ConditionAsIWalkingPatternCondition()
		{
			return this.Condition<IWalkingPatternCondition>().Value;
		}

		// Token: 0x17006C2E RID: 27694
		// (get) Token: 0x06015D78 RID: 89464 RVA: 0x0032672C File Offset: 0x0032492C
		public bool HideUi
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C2F RID: 27695
		// (get) Token: 0x06015D79 RID: 89465 RVA: 0x0032676C File Offset: 0x0032496C
		public bool HideUiExceptTaskList
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C30 RID: 27696
		// (get) Token: 0x06015D7A RID: 89466 RVA: 0x003267AC File Offset: 0x003249AC
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

		// Token: 0x06015D7B RID: 89467 RVA: 0x003267EC File Offset: 0x003249EC
		public TTable? SaveConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015D7C RID: 89468 RVA: 0x00326834 File Offset: 0x00324A34
		public ISaveNew SaveConfigAsISaveNew()
		{
			return this.SaveConfig<ISaveNew>().Value;
		}

		// Token: 0x06015D7D RID: 89469 RVA: 0x00326850 File Offset: 0x00324A50
		public ISavePoint SaveConfigAsISavePoint()
		{
			return this.SaveConfig<ISavePoint>().Value;
		}

		// Token: 0x17006C31 RID: 27697
		// (get) Token: 0x06015D7E RID: 89470 RVA: 0x0032686C File Offset: 0x00324A6C
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

		// Token: 0x17006C32 RID: 27698
		// (get) Token: 0x06015D7F RID: 89471 RVA: 0x003268AC File Offset: 0x00324AAC
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

		// Token: 0x06015D80 RID: 89472 RVA: 0x003268EC File Offset: 0x00324AEC
		public IStuckCheckCondition? StuckCheck(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new IStuckCheckCondition?(default(IStuckCheckCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C33 RID: 27699
		// (get) Token: 0x06015D81 RID: 89473 RVA: 0x00326950 File Offset: 0x00324B50
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

		// Token: 0x17006C34 RID: 27700
		// (get) Token: 0x06015D82 RID: 89474 RVA: 0x0032697C File Offset: 0x00324B7C
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

		// Token: 0x17006C35 RID: 27701
		// (get) Token: 0x06015D83 RID: 89475 RVA: 0x003269DC File Offset: 0x00324BDC
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

		// Token: 0x17006C36 RID: 27702
		// (get) Token: 0x06015D84 RID: 89476 RVA: 0x00326A3C File Offset: 0x00324C3C
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

		// Token: 0x06015D85 RID: 89477 RVA: 0x00326A7C File Offset: 0x00324C7C
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

		// Token: 0x06015D86 RID: 89478 RVA: 0x00326B84 File Offset: 0x00324D84
		public static void StartIChildQuestBtNode(FlatBufferBuilder builder)
		{
			builder.StartTable(30);
		}

		// Token: 0x06015D87 RID: 89479 RVA: 0x00326B8E File Offset: 0x00324D8E
		public static void AddType(FlatBufferBuilder builder, EBtNode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D88 RID: 89480 RVA: 0x00326B99 File Offset: 0x00324D99
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06015D89 RID: 89481 RVA: 0x00326BA4 File Offset: 0x00324DA4
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(2, descOffset.Value, 0);
		}

		// Token: 0x06015D8A RID: 89482 RVA: 0x00326BB4 File Offset: 0x00324DB4
		public static void AddFixProcessor(FlatBufferBuilder builder, Offset<IFixProcessor> fixProcessorOffset)
		{
			builder.AddOffset(3, fixProcessorOffset.Value, 0);
		}

		// Token: 0x06015D8B RID: 89483 RVA: 0x00326BC4 File Offset: 0x00324DC4
		public static void Add_FoldedForTree(FlatBufferBuilder builder, bool _FoldedForTree)
		{
			builder.AddBool(4, _FoldedForTree, false);
		}

		// Token: 0x06015D8C RID: 89484 RVA: 0x00326BCF File Offset: 0x00324DCF
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(5, disabled, false);
		}

		// Token: 0x06015D8D RID: 89485 RVA: 0x00326BDA File Offset: 0x00324DDA
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(6, rewardId, 0);
		}

		// Token: 0x06015D8E RID: 89486 RVA: 0x00326BE5 File Offset: 0x00324DE5
		public static void AddRewardGetUiType(FlatBufferBuilder builder, EItemGetUiType rewardGetUiType)
		{
			builder.AddByte(7, (byte)rewardGetUiType, 0);
		}

		// Token: 0x06015D8F RID: 89487 RVA: 0x00326BF0 File Offset: 0x00324DF0
		public static void AddRewardGetUiConfig(FlatBufferBuilder builder, Offset<IItemGetUiConfigSpecialQuest> rewardGetUiConfigOffset)
		{
			builder.AddOffset(8, rewardGetUiConfigOffset.Value, 0);
		}

		// Token: 0x06015D90 RID: 89488 RVA: 0x00326C00 File Offset: 0x00324E00
		public static void AddHideTip(FlatBufferBuilder builder, bool hideTip)
		{
			builder.AddBool(9, hideTip, false);
		}

		// Token: 0x06015D91 RID: 89489 RVA: 0x00326C0C File Offset: 0x00324E0C
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(10, tidTipOffset.Value, 0);
		}

		// Token: 0x06015D92 RID: 89490 RVA: 0x00326C1D File Offset: 0x00324E1D
		public static void AddShowTipBeforeEnterActions(FlatBufferBuilder builder, bool showTipBeforeEnterActions)
		{
			builder.AddBool(11, showTipBeforeEnterActions, false);
		}

		// Token: 0x06015D93 RID: 89491 RVA: 0x00326C29 File Offset: 0x00324E29
		public static void AddShowNavigation(FlatBufferBuilder builder, bool showNavigation)
		{
			builder.AddBool(12, showNavigation, false);
		}

		// Token: 0x06015D94 RID: 89492 RVA: 0x00326C35 File Offset: 0x00324E35
		public static void AddNavigationStyle(FlatBufferBuilder builder, ENavigationStyle navigationStyle)
		{
			builder.AddByte(13, (byte)navigationStyle, 0);
		}

		// Token: 0x06015D95 RID: 89493 RVA: 0x00326C41 File Offset: 0x00324E41
		public static void AddAlwaysShowNavigation(FlatBufferBuilder builder, bool alwaysShowNavigation)
		{
			builder.AddBool(14, alwaysShowNavigation, false);
		}

		// Token: 0x06015D96 RID: 89494 RVA: 0x00326C4D File Offset: 0x00324E4D
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(15, enterActionsOffset.Value, 0);
		}

		// Token: 0x06015D97 RID: 89495 RVA: 0x00326C60 File Offset: 0x00324E60
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015D98 RID: 89496 RVA: 0x00326CA0 File Offset: 0x00324EA0
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D99 RID: 89497 RVA: 0x00326CBA File Offset: 0x00324EBA
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D9A RID: 89498 RVA: 0x00326CD8 File Offset: 0x00324ED8
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015D9B RID: 89499 RVA: 0x00326CF1 File Offset: 0x00324EF1
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015D9C RID: 89500 RVA: 0x00326CFC File Offset: 0x00324EFC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(16, finishActionsOffset.Value, 0);
		}

		// Token: 0x06015D9D RID: 89501 RVA: 0x00326D10 File Offset: 0x00324F10
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015D9E RID: 89502 RVA: 0x00326D50 File Offset: 0x00324F50
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015D9F RID: 89503 RVA: 0x00326D6A File Offset: 0x00324F6A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015DA0 RID: 89504 RVA: 0x00326D88 File Offset: 0x00324F88
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015DA1 RID: 89505 RVA: 0x00326DA1 File Offset: 0x00324FA1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015DA2 RID: 89506 RVA: 0x00326DAC File Offset: 0x00324FAC
		public static void AddTrackTarget(FlatBufferBuilder builder, Offset<ITrackTarget> trackTargetOffset)
		{
			builder.AddOffset(17, trackTargetOffset.Value, 0);
		}

		// Token: 0x06015DA3 RID: 89507 RVA: 0x00326DBD File Offset: 0x00324FBD
		public static void AddConditionType(FlatBufferBuilder builder, TChildQuestCondition conditionType)
		{
			builder.AddByte(18, (byte)conditionType, 0);
		}

		// Token: 0x06015DA4 RID: 89508 RVA: 0x00326DC9 File Offset: 0x00324FC9
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(19, conditionOffset, 0);
		}

		// Token: 0x06015DA5 RID: 89509 RVA: 0x00326DD5 File Offset: 0x00324FD5
		public static void AddHideUi(FlatBufferBuilder builder, bool hideUi)
		{
			builder.AddBool(20, hideUi, false);
		}

		// Token: 0x06015DA6 RID: 89510 RVA: 0x00326DE1 File Offset: 0x00324FE1
		public static void AddHideUiExceptTaskList(FlatBufferBuilder builder, bool hideUiExceptTaskList)
		{
			builder.AddBool(21, hideUiExceptTaskList, false);
		}

		// Token: 0x06015DA7 RID: 89511 RVA: 0x00326DED File Offset: 0x00324FED
		public static void AddSaveConfigType(FlatBufferBuilder builder, TSaveConfig saveConfigType)
		{
			builder.AddByte(22, (byte)saveConfigType, 0);
		}

		// Token: 0x06015DA8 RID: 89512 RVA: 0x00326DF9 File Offset: 0x00324FF9
		public static void AddSaveConfig(FlatBufferBuilder builder, int saveConfigOffset)
		{
			builder.AddOffset(23, saveConfigOffset, 0);
		}

		// Token: 0x06015DA9 RID: 89513 RVA: 0x00326E05 File Offset: 0x00325005
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(24, customIcon, 0);
		}

		// Token: 0x06015DAA RID: 89514 RVA: 0x00326E11 File Offset: 0x00325011
		public static void AddCustomTrackUiPrefabId(FlatBufferBuilder builder, int customTrackUiPrefabId)
		{
			builder.AddInt(25, customTrackUiPrefabId, 0);
		}

		// Token: 0x06015DAB RID: 89515 RVA: 0x00326E1D File Offset: 0x0032501D
		public static void AddStuckCheck(FlatBufferBuilder builder, VectorOffset stuckCheckOffset)
		{
			builder.AddOffset(26, stuckCheckOffset.Value, 0);
		}

		// Token: 0x06015DAC RID: 89516 RVA: 0x00326E30 File Offset: 0x00325030
		public static VectorOffset CreateStuckCheckVector(FlatBufferBuilder builder, Offset<IStuckCheckCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015DAD RID: 89517 RVA: 0x00326E70 File Offset: 0x00325070
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, Offset<IStuckCheckCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStuckCheckCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015DAE RID: 89518 RVA: 0x00326E8A File Offset: 0x0032508A
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStuckCheckCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStuckCheckCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015DAF RID: 89519 RVA: 0x00326EA8 File Offset: 0x003250A8
		public static VectorOffset CreateStuckCheckVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStuckCheckCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015DB0 RID: 89520 RVA: 0x00326EC1 File Offset: 0x003250C1
		public static void StartStuckCheckVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015DB1 RID: 89521 RVA: 0x00326ECC File Offset: 0x003250CC
		public static void AddModifyTrackAreaText(FlatBufferBuilder builder, Offset<ITrackAreaText> modifyTrackAreaTextOffset)
		{
			builder.AddOffset(27, modifyTrackAreaTextOffset.Value, 0);
		}

		// Token: 0x06015DB2 RID: 89522 RVA: 0x00326EDD File Offset: 0x003250DD
		public static void AddTrackCustomBoard(FlatBufferBuilder builder, Offset<ITrackCustomBoard> trackCustomBoardOffset)
		{
			builder.AddOffset(28, trackCustomBoardOffset.Value, 0);
		}

		// Token: 0x06015DB3 RID: 89523 RVA: 0x00326EEE File Offset: 0x003250EE
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(29, nullMask, 0);
		}

		// Token: 0x06015DB4 RID: 89524 RVA: 0x00326EFA File Offset: 0x003250FA
		public static Offset<IChildQuestBtNode> EndIChildQuestBtNode(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestBtNode>(builder.EndTable());
		}

		// Token: 0x06015DB5 RID: 89525 RVA: 0x00326F08 File Offset: 0x00325108
		public IChildQuestBtNodeT UnPack()
		{
			IChildQuestBtNodeT childQuestBtNodeT = new IChildQuestBtNodeT();
			this.UnPackTo(childQuestBtNodeT);
			return childQuestBtNodeT;
		}

		// Token: 0x06015DB6 RID: 89526 RVA: 0x00326F24 File Offset: 0x00325124
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

		// Token: 0x06015DB7 RID: 89527 RVA: 0x00328318 File Offset: 0x00326518
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

		// Token: 0x0400B675 RID: 46709
		private Table __p;
	}
}
