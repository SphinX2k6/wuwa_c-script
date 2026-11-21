using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739D RID: 29597
	public struct IOpenSystemBoard : IFlatbufferObject
	{
		// Token: 0x1700D934 RID: 55604
		// (get) Token: 0x06033B5B RID: 211803 RVA: 0x006F92BB File Offset: 0x006F74BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B5C RID: 211804 RVA: 0x006F92C8 File Offset: 0x006F74C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B5D RID: 211805 RVA: 0x006F92D0 File Offset: 0x006F74D0
		public static IOpenSystemBoard GetRootAsIOpenSystemBoard(ByteBuffer _bb)
		{
			return IOpenSystemBoard.GetRootAsIOpenSystemBoard(_bb, default(IOpenSystemBoard));
		}

		// Token: 0x06033B5E RID: 211806 RVA: 0x006F92EC File Offset: 0x006F74EC
		public static IOpenSystemBoard GetRootAsIOpenSystemBoard(ByteBuffer _bb, IOpenSystemBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B5F RID: 211807 RVA: 0x006F9309 File Offset: 0x006F7509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B60 RID: 211808 RVA: 0x006F9318 File Offset: 0x006F7518
		public IOpenSystemBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D935 RID: 55605
		// (get) Token: 0x06033B61 RID: 211809 RVA: 0x006F9328 File Offset: 0x006F7528
		public ESystemType SystemType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D936 RID: 55606
		// (get) Token: 0x06033B62 RID: 211810 RVA: 0x006F9364 File Offset: 0x006F7564
		public int BoardId
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

		// Token: 0x1700D937 RID: 55607
		// (get) Token: 0x06033B63 RID: 211811 RVA: 0x006F93A0 File Offset: 0x006F75A0
		public string ActionMontage
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

		// Token: 0x06033B64 RID: 211812 RVA: 0x006F93D7 File Offset: 0x006F75D7
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06033B65 RID: 211813 RVA: 0x006F93E6 File Offset: 0x006F75E6
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06033B66 RID: 211814 RVA: 0x006F93F4 File Offset: 0x006F75F4
		public TVarRef InputVarsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D938 RID: 55608
		// (get) Token: 0x06033B67 RID: 211815 RVA: 0x006F9434 File Offset: 0x006F7634
		public int InputVarsTypeLength
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

		// Token: 0x06033B68 RID: 211816 RVA: 0x006F9460 File Offset: 0x006F7660
		public Span<TVarRef> GetInputVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(10, 1);
		}

		// Token: 0x06033B69 RID: 211817 RVA: 0x006F9470 File Offset: 0x006F7670
		public TVarRef[] GetInputVarsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVarRef[] array = new TVarRef[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVarRef)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06033B6A RID: 211818 RVA: 0x006F94DC File Offset: 0x006F76DC
		public TTable? InputVars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D939 RID: 55609
		// (get) Token: 0x06033B6B RID: 211819 RVA: 0x006F9524 File Offset: 0x006F7724
		public int InputVarsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D93A RID: 55610
		// (get) Token: 0x06033B6C RID: 211820 RVA: 0x006F9550 File Offset: 0x006F7750
		public string UiCameraName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B6D RID: 211821 RVA: 0x006F9588 File Offset: 0x006F7788
		public Span<byte> GetUiCameraNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06033B6E RID: 211822 RVA: 0x006F9598 File Offset: 0x006F7798
		public byte[] GetUiCameraNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700D93B RID: 55611
		// (get) Token: 0x06033B6F RID: 211823 RVA: 0x006F95A8 File Offset: 0x006F77A8
		public IPhotographConfig? PhotographConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPhotographConfig?(default(IPhotographConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D93C RID: 55612
		// (get) Token: 0x06033B70 RID: 211824 RVA: 0x006F9608 File Offset: 0x006F7808
		public IInformationViewConfig? InformationViewConfig
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

		// Token: 0x1700D93D RID: 55613
		// (get) Token: 0x06033B71 RID: 211825 RVA: 0x006F9668 File Offset: 0x006F7868
		public int GramophoneId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D93E RID: 55614
		// (get) Token: 0x06033B72 RID: 211826 RVA: 0x006F96A8 File Offset: 0x006F78A8
		public bool SetMapMusic
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D93F RID: 55615
		// (get) Token: 0x06033B73 RID: 211827 RVA: 0x006F96E8 File Offset: 0x006F78E8
		public bool FadeInScreenWhenClose
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D940 RID: 55616
		// (get) Token: 0x06033B74 RID: 211828 RVA: 0x006F9728 File Offset: 0x006F7928
		public ESyncOpenSystemBoardFinishTiming SyncOpenSystemBoardFinishTiming
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return ESyncOpenSystemBoardFinishTiming.OpenFinished;
				}
				return (ESyncOpenSystemBoardFinishTiming)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B75 RID: 211829 RVA: 0x006F9768 File Offset: 0x006F7968
		public int Seats(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D941 RID: 55617
		// (get) Token: 0x06033B76 RID: 211830 RVA: 0x006F97A8 File Offset: 0x006F79A8
		public int SeatsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033B77 RID: 211831 RVA: 0x006F97D4 File Offset: 0x006F79D4
		public Span<int> GetSeatsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06033B78 RID: 211832 RVA: 0x006F97E4 File Offset: 0x006F79E4
		public int[] GetSeatsArray()
		{
			return this.__p.__vector_as_array<int>(28);
		}

		// Token: 0x1700D942 RID: 55618
		// (get) Token: 0x06033B79 RID: 211833 RVA: 0x006F97F4 File Offset: 0x006F79F4
		public int PlotReviewJumpTipsNodeId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D943 RID: 55619
		// (get) Token: 0x06033B7A RID: 211834 RVA: 0x006F9834 File Offset: 0x006F7A34
		public bool WaitLoading
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D944 RID: 55620
		// (get) Token: 0x06033B7B RID: 211835 RVA: 0x006F9874 File Offset: 0x006F7A74
		public ITransitionPopupConfig? TransitionPopupConfig
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ITransitionPopupConfig?(default(ITransitionPopupConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D945 RID: 55621
		// (get) Token: 0x06033B7C RID: 211836 RVA: 0x006F98D4 File Offset: 0x006F7AD4
		public int FightPreparationEntityId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D946 RID: 55622
		// (get) Token: 0x06033B7D RID: 211837 RVA: 0x006F9914 File Offset: 0x006F7B14
		public string FightPreparationUiCamera
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B7E RID: 211838 RVA: 0x006F994C File Offset: 0x006F7B4C
		public Span<byte> GetFightPreparationUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06033B7F RID: 211839 RVA: 0x006F995C File Offset: 0x006F7B5C
		public byte[] GetFightPreparationUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x1700D947 RID: 55623
		// (get) Token: 0x06033B80 RID: 211840 RVA: 0x006F996C File Offset: 0x006F7B6C
		public TInfrActivityBuildStageType InfrActivityBuildStageType
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return TInfrActivityBuildStageType.NONE;
				}
				return (TInfrActivityBuildStageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B81 RID: 211841 RVA: 0x006F99AC File Offset: 0x006F7BAC
		public TTable? InfrActivityBuildStage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B82 RID: 211842 RVA: 0x006F99F4 File Offset: 0x006F7BF4
		public IInfrActivityInfrastructureStage InfrActivityBuildStageAsIInfrActivityInfrastructureStage()
		{
			return this.InfrActivityBuildStage<IInfrActivityInfrastructureStage>().Value;
		}

		// Token: 0x06033B83 RID: 211843 RVA: 0x006F9A10 File Offset: 0x006F7C10
		public IInfrActivityRoadProcess InfrActivityBuildStageAsIInfrActivityRoadProcess()
		{
			return this.InfrActivityBuildStage<IInfrActivityRoadProcess>().Value;
		}

		// Token: 0x1700D948 RID: 55624
		// (get) Token: 0x06033B84 RID: 211844 RVA: 0x006F9A2C File Offset: 0x006F7C2C
		public IMapConfig? MapConfig
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new IMapConfig?(default(IMapConfig).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700D949 RID: 55625
		// (get) Token: 0x06033B85 RID: 211845 RVA: 0x006F9A80 File Offset: 0x006F7C80
		public int TargetPhantomExhibitEntity
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B86 RID: 211846 RVA: 0x006F9AC0 File Offset: 0x006F7CC0
		public int TargetWeaponExhibitEntities(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D94A RID: 55626
		// (get) Token: 0x06033B87 RID: 211847 RVA: 0x006F9B00 File Offset: 0x006F7D00
		public int TargetWeaponExhibitEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033B88 RID: 211848 RVA: 0x006F9B2C File Offset: 0x006F7D2C
		public Span<int> GetTargetWeaponExhibitEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06033B89 RID: 211849 RVA: 0x006F9B3C File Offset: 0x006F7D3C
		public int[] GetTargetWeaponExhibitEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(48);
		}

		// Token: 0x1700D94B RID: 55627
		// (get) Token: 0x06033B8A RID: 211850 RVA: 0x006F9B4C File Offset: 0x006F7D4C
		public bool BlockAutoOpenUiAfterDungeon
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D94C RID: 55628
		// (get) Token: 0x06033B8B RID: 211851 RVA: 0x006F9B8C File Offset: 0x006F7D8C
		public int GuessJokerLevel
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

		// Token: 0x1700D94D RID: 55629
		// (get) Token: 0x06033B8C RID: 211852 RVA: 0x006F9BCC File Offset: 0x006F7DCC
		public IPictureCaptionConfig? PictureCaptionConfig
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IPictureCaptionConfig?(default(IPictureCaptionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D94E RID: 55630
		// (get) Token: 0x06033B8D RID: 211853 RVA: 0x006F9C2C File Offset: 0x006F7E2C
		public int TetrisBoardGameEntity
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D94F RID: 55631
		// (get) Token: 0x06033B8E RID: 211854 RVA: 0x006F9C6C File Offset: 0x006F7E6C
		public TVillageInfrBuildType VillageInfrBuildStageType
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return TVillageInfrBuildType.NONE;
				}
				return (TVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B8F RID: 211855 RVA: 0x006F9CAC File Offset: 0x006F7EAC
		public TTable? VillageInfrBuildStage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B90 RID: 211856 RVA: 0x006F9CF4 File Offset: 0x006F7EF4
		public IVillageInfrTreeProcess VillageInfrBuildStageAsIVillageInfrTreeProcess()
		{
			return this.VillageInfrBuildStage<IVillageInfrTreeProcess>().Value;
		}

		// Token: 0x06033B91 RID: 211857 RVA: 0x006F9D10 File Offset: 0x006F7F10
		public IVillageInfrVillageLevel VillageInfrBuildStageAsIVillageInfrVillageLevel()
		{
			return this.VillageInfrBuildStage<IVillageInfrVillageLevel>().Value;
		}

		// Token: 0x1700D950 RID: 55632
		// (get) Token: 0x06033B92 RID: 211858 RVA: 0x006F9D2C File Offset: 0x006F7F2C
		public string VillageInfrDeliveryUiCamera
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B93 RID: 211859 RVA: 0x006F9D64 File Offset: 0x006F7F64
		public Span<byte> GetVillageInfrDeliveryUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06033B94 RID: 211860 RVA: 0x006F9D74 File Offset: 0x006F7F74
		public byte[] GetVillageInfrDeliveryUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(62);
		}

		// Token: 0x1700D951 RID: 55633
		// (get) Token: 0x06033B95 RID: 211861 RVA: 0x006F9D84 File Offset: 0x006F7F84
		public IQuestBranchConfig? QuestBranchConfig
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new IQuestBranchConfig?(default(IQuestBranchConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D952 RID: 55634
		// (get) Token: 0x06033B96 RID: 211862 RVA: 0x006F9DE4 File Offset: 0x006F7FE4
		public IWriteLetterConfig? WriteLetterConfig
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new IWriteLetterConfig?(default(IWriteLetterConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D953 RID: 55635
		// (get) Token: 0x06033B97 RID: 211863 RVA: 0x006F9E44 File Offset: 0x006F8044
		public int DollGrabShowcaseEntityId
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B98 RID: 211864 RVA: 0x006F9E84 File Offset: 0x006F8084
		public string MechascoutMindSpaceTextKeys(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D954 RID: 55636
		// (get) Token: 0x06033B99 RID: 211865 RVA: 0x006F9EC0 File Offset: 0x006F80C0
		public int MechascoutMindSpaceTextKeysLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D955 RID: 55637
		// (get) Token: 0x06033B9A RID: 211866 RVA: 0x006F9EEC File Offset: 0x006F80EC
		public IDeliverItemProbeCollectiblesConfig? DeliverItemProbeCollectiblesConfig
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return new IDeliverItemProbeCollectiblesConfig?(default(IDeliverItemProbeCollectiblesConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D956 RID: 55638
		// (get) Token: 0x06033B9B RID: 211867 RVA: 0x006F9F4C File Offset: 0x006F814C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B9C RID: 211868 RVA: 0x006F9F8C File Offset: 0x006F818C
		public static Offset<IOpenSystemBoard> CreateIOpenSystemBoard(FlatBufferBuilder builder, ESystemType SystemType = ESystemType.Shop, int BoardId = 0, StringOffset ActionMontageOffset = default(StringOffset), VectorOffset InputVars_typeOffset = default(VectorOffset), VectorOffset InputVarsOffset = default(VectorOffset), StringOffset UiCameraNameOffset = default(StringOffset), Offset<IPhotographConfig> PhotographConfigOffset = default(Offset<IPhotographConfig>), Offset<IInformationViewConfig> InformationViewConfigOffset = default(Offset<IInformationViewConfig>), int GramophoneId = 0, bool SetMapMusic = false, bool FadeInScreenWhenClose = false, ESyncOpenSystemBoardFinishTiming SyncOpenSystemBoardFinishTiming = ESyncOpenSystemBoardFinishTiming.OpenFinished, VectorOffset SeatsOffset = default(VectorOffset), int PlotReviewJumpTipsNodeId = 0, bool WaitLoading = false, Offset<ITransitionPopupConfig> TransitionPopupConfigOffset = default(Offset<ITransitionPopupConfig>), int FightPreparationEntityId = 0, StringOffset FightPreparationUiCameraOffset = default(StringOffset), TInfrActivityBuildStageType InfrActivityBuildStage_type = TInfrActivityBuildStageType.NONE, int InfrActivityBuildStageOffset = 0, IMapConfigT MapConfig = null, int TargetPhantomExhibitEntity = 0, VectorOffset TargetWeaponExhibitEntitiesOffset = default(VectorOffset), bool BlockAutoOpenUiAfterDungeon = false, int GuessJokerLevel = 0, Offset<IPictureCaptionConfig> PictureCaptionConfigOffset = default(Offset<IPictureCaptionConfig>), int TetrisBoardGameEntity = 0, TVillageInfrBuildType VillageInfrBuildStage_type = TVillageInfrBuildType.NONE, int VillageInfrBuildStageOffset = 0, StringOffset VillageInfrDeliveryUiCameraOffset = default(StringOffset), Offset<IQuestBranchConfig> QuestBranchConfigOffset = default(Offset<IQuestBranchConfig>), Offset<IWriteLetterConfig> WriteLetterConfigOffset = default(Offset<IWriteLetterConfig>), int DollGrabShowcaseEntityId = 0, VectorOffset MechascoutMindSpaceTextKeysOffset = default(VectorOffset), Offset<IDeliverItemProbeCollectiblesConfig> DeliverItemProbeCollectiblesConfigOffset = default(Offset<IDeliverItemProbeCollectiblesConfig>), ushort NullMask = 0)
		{
			builder.StartTable(36);
			IOpenSystemBoard.AddDeliverItemProbeCollectiblesConfig(builder, DeliverItemProbeCollectiblesConfigOffset);
			IOpenSystemBoard.AddMechascoutMindSpaceTextKeys(builder, MechascoutMindSpaceTextKeysOffset);
			IOpenSystemBoard.AddDollGrabShowcaseEntityId(builder, DollGrabShowcaseEntityId);
			IOpenSystemBoard.AddWriteLetterConfig(builder, WriteLetterConfigOffset);
			IOpenSystemBoard.AddQuestBranchConfig(builder, QuestBranchConfigOffset);
			IOpenSystemBoard.AddVillageInfrDeliveryUiCamera(builder, VillageInfrDeliveryUiCameraOffset);
			IOpenSystemBoard.AddVillageInfrBuildStage(builder, VillageInfrBuildStageOffset);
			IOpenSystemBoard.AddTetrisBoardGameEntity(builder, TetrisBoardGameEntity);
			IOpenSystemBoard.AddPictureCaptionConfig(builder, PictureCaptionConfigOffset);
			IOpenSystemBoard.AddGuessJokerLevel(builder, GuessJokerLevel);
			IOpenSystemBoard.AddTargetWeaponExhibitEntities(builder, TargetWeaponExhibitEntitiesOffset);
			IOpenSystemBoard.AddTargetPhantomExhibitEntity(builder, TargetPhantomExhibitEntity);
			IOpenSystemBoard.AddMapConfig(builder, IMapConfig.Pack(builder, MapConfig));
			IOpenSystemBoard.AddInfrActivityBuildStage(builder, InfrActivityBuildStageOffset);
			IOpenSystemBoard.AddFightPreparationUiCamera(builder, FightPreparationUiCameraOffset);
			IOpenSystemBoard.AddFightPreparationEntityId(builder, FightPreparationEntityId);
			IOpenSystemBoard.AddTransitionPopupConfig(builder, TransitionPopupConfigOffset);
			IOpenSystemBoard.AddPlotReviewJumpTipsNodeId(builder, PlotReviewJumpTipsNodeId);
			IOpenSystemBoard.AddSeats(builder, SeatsOffset);
			IOpenSystemBoard.AddGramophoneId(builder, GramophoneId);
			IOpenSystemBoard.AddInformationViewConfig(builder, InformationViewConfigOffset);
			IOpenSystemBoard.AddPhotographConfig(builder, PhotographConfigOffset);
			IOpenSystemBoard.AddUiCameraName(builder, UiCameraNameOffset);
			IOpenSystemBoard.AddInputVars(builder, InputVarsOffset);
			IOpenSystemBoard.AddInputVarsType(builder, InputVars_typeOffset);
			IOpenSystemBoard.AddActionMontage(builder, ActionMontageOffset);
			IOpenSystemBoard.AddBoardId(builder, BoardId);
			IOpenSystemBoard.AddNullMask(builder, NullMask);
			IOpenSystemBoard.AddVillageInfrBuildStageType(builder, VillageInfrBuildStage_type);
			IOpenSystemBoard.AddBlockAutoOpenUiAfterDungeon(builder, BlockAutoOpenUiAfterDungeon);
			IOpenSystemBoard.AddInfrActivityBuildStageType(builder, InfrActivityBuildStage_type);
			IOpenSystemBoard.AddWaitLoading(builder, WaitLoading);
			IOpenSystemBoard.AddSyncOpenSystemBoardFinishTiming(builder, SyncOpenSystemBoardFinishTiming);
			IOpenSystemBoard.AddFadeInScreenWhenClose(builder, FadeInScreenWhenClose);
			IOpenSystemBoard.AddSetMapMusic(builder, SetMapMusic);
			IOpenSystemBoard.AddSystemType(builder, SystemType);
			return IOpenSystemBoard.EndIOpenSystemBoard(builder);
		}

		// Token: 0x06033B9D RID: 211869 RVA: 0x006FA0CA File Offset: 0x006F82CA
		public static void StartIOpenSystemBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(36);
		}

		// Token: 0x06033B9E RID: 211870 RVA: 0x006FA0D4 File Offset: 0x006F82D4
		public static void AddSystemType(FlatBufferBuilder builder, ESystemType systemType)
		{
			builder.AddByte(0, (byte)systemType, 0);
		}

		// Token: 0x06033B9F RID: 211871 RVA: 0x006FA0DF File Offset: 0x006F82DF
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x06033BA0 RID: 211872 RVA: 0x006FA0EA File Offset: 0x006F82EA
		public static void AddActionMontage(FlatBufferBuilder builder, StringOffset actionMontageOffset)
		{
			builder.AddOffset(2, actionMontageOffset.Value, 0);
		}

		// Token: 0x06033BA1 RID: 211873 RVA: 0x006FA0FA File Offset: 0x006F82FA
		public static void AddInputVarsType(FlatBufferBuilder builder, VectorOffset inputVarsTypeOffset)
		{
			builder.AddOffset(3, inputVarsTypeOffset.Value, 0);
		}

		// Token: 0x06033BA2 RID: 211874 RVA: 0x006FA10C File Offset: 0x006F830C
		public static VectorOffset CreateInputVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BA3 RID: 211875 RVA: 0x006FA143 File Offset: 0x006F8343
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BA4 RID: 211876 RVA: 0x006FA15D File Offset: 0x006F835D
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BA5 RID: 211877 RVA: 0x006FA17B File Offset: 0x006F837B
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BA6 RID: 211878 RVA: 0x006FA194 File Offset: 0x006F8394
		public static void StartInputVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06033BA7 RID: 211879 RVA: 0x006FA19F File Offset: 0x006F839F
		public static void AddInputVars(FlatBufferBuilder builder, VectorOffset inputVarsOffset)
		{
			builder.AddOffset(4, inputVarsOffset.Value, 0);
		}

		// Token: 0x06033BA8 RID: 211880 RVA: 0x006FA1B0 File Offset: 0x006F83B0
		public static VectorOffset CreateInputVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BA9 RID: 211881 RVA: 0x006FA1E7 File Offset: 0x006F83E7
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BAA RID: 211882 RVA: 0x006FA201 File Offset: 0x006F8401
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BAB RID: 211883 RVA: 0x006FA21F File Offset: 0x006F841F
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BAC RID: 211884 RVA: 0x006FA238 File Offset: 0x006F8438
		public static void StartInputVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033BAD RID: 211885 RVA: 0x006FA243 File Offset: 0x006F8443
		public static void AddUiCameraName(FlatBufferBuilder builder, StringOffset uiCameraNameOffset)
		{
			builder.AddOffset(5, uiCameraNameOffset.Value, 0);
		}

		// Token: 0x06033BAE RID: 211886 RVA: 0x006FA253 File Offset: 0x006F8453
		public static void AddPhotographConfig(FlatBufferBuilder builder, Offset<IPhotographConfig> photographConfigOffset)
		{
			builder.AddOffset(6, photographConfigOffset.Value, 0);
		}

		// Token: 0x06033BAF RID: 211887 RVA: 0x006FA263 File Offset: 0x006F8463
		public static void AddInformationViewConfig(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewConfigOffset)
		{
			builder.AddOffset(7, informationViewConfigOffset.Value, 0);
		}

		// Token: 0x06033BB0 RID: 211888 RVA: 0x006FA273 File Offset: 0x006F8473
		public static void AddGramophoneId(FlatBufferBuilder builder, int gramophoneId)
		{
			builder.AddInt(8, gramophoneId, 0);
		}

		// Token: 0x06033BB1 RID: 211889 RVA: 0x006FA27E File Offset: 0x006F847E
		public static void AddSetMapMusic(FlatBufferBuilder builder, bool setMapMusic)
		{
			builder.AddBool(9, setMapMusic, false);
		}

		// Token: 0x06033BB2 RID: 211890 RVA: 0x006FA28A File Offset: 0x006F848A
		public static void AddFadeInScreenWhenClose(FlatBufferBuilder builder, bool fadeInScreenWhenClose)
		{
			builder.AddBool(10, fadeInScreenWhenClose, false);
		}

		// Token: 0x06033BB3 RID: 211891 RVA: 0x006FA296 File Offset: 0x006F8496
		public static void AddSyncOpenSystemBoardFinishTiming(FlatBufferBuilder builder, ESyncOpenSystemBoardFinishTiming syncOpenSystemBoardFinishTiming)
		{
			builder.AddByte(11, (byte)syncOpenSystemBoardFinishTiming, 0);
		}

		// Token: 0x06033BB4 RID: 211892 RVA: 0x006FA2A2 File Offset: 0x006F84A2
		public static void AddSeats(FlatBufferBuilder builder, VectorOffset seatsOffset)
		{
			builder.AddOffset(12, seatsOffset.Value, 0);
		}

		// Token: 0x06033BB5 RID: 211893 RVA: 0x006FA2B4 File Offset: 0x006F84B4
		public static VectorOffset CreateSeatsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BB6 RID: 211894 RVA: 0x006FA2EB File Offset: 0x006F84EB
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BB7 RID: 211895 RVA: 0x006FA305 File Offset: 0x006F8505
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BB8 RID: 211896 RVA: 0x006FA323 File Offset: 0x006F8523
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BB9 RID: 211897 RVA: 0x006FA33C File Offset: 0x006F853C
		public static void StartSeatsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033BBA RID: 211898 RVA: 0x006FA347 File Offset: 0x006F8547
		public static void AddPlotReviewJumpTipsNodeId(FlatBufferBuilder builder, int plotReviewJumpTipsNodeId)
		{
			builder.AddInt(13, plotReviewJumpTipsNodeId, 0);
		}

		// Token: 0x06033BBB RID: 211899 RVA: 0x006FA353 File Offset: 0x006F8553
		public static void AddWaitLoading(FlatBufferBuilder builder, bool waitLoading)
		{
			builder.AddBool(14, waitLoading, false);
		}

		// Token: 0x06033BBC RID: 211900 RVA: 0x006FA35F File Offset: 0x006F855F
		public static void AddTransitionPopupConfig(FlatBufferBuilder builder, Offset<ITransitionPopupConfig> transitionPopupConfigOffset)
		{
			builder.AddOffset(15, transitionPopupConfigOffset.Value, 0);
		}

		// Token: 0x06033BBD RID: 211901 RVA: 0x006FA370 File Offset: 0x006F8570
		public static void AddFightPreparationEntityId(FlatBufferBuilder builder, int fightPreparationEntityId)
		{
			builder.AddInt(16, fightPreparationEntityId, 0);
		}

		// Token: 0x06033BBE RID: 211902 RVA: 0x006FA37C File Offset: 0x006F857C
		public static void AddFightPreparationUiCamera(FlatBufferBuilder builder, StringOffset fightPreparationUiCameraOffset)
		{
			builder.AddOffset(17, fightPreparationUiCameraOffset.Value, 0);
		}

		// Token: 0x06033BBF RID: 211903 RVA: 0x006FA38D File Offset: 0x006F858D
		public static void AddInfrActivityBuildStageType(FlatBufferBuilder builder, TInfrActivityBuildStageType infrActivityBuildStageType)
		{
			builder.AddByte(18, (byte)infrActivityBuildStageType, 0);
		}

		// Token: 0x06033BC0 RID: 211904 RVA: 0x006FA399 File Offset: 0x006F8599
		public static void AddInfrActivityBuildStage(FlatBufferBuilder builder, int infrActivityBuildStageOffset)
		{
			builder.AddOffset(19, infrActivityBuildStageOffset, 0);
		}

		// Token: 0x06033BC1 RID: 211905 RVA: 0x006FA3A5 File Offset: 0x006F85A5
		public static void AddMapConfig(FlatBufferBuilder builder, Offset<IMapConfig> mapConfigOffset)
		{
			builder.AddStruct(20, mapConfigOffset.Value, 0);
		}

		// Token: 0x06033BC2 RID: 211906 RVA: 0x006FA3B6 File Offset: 0x006F85B6
		public static void AddTargetPhantomExhibitEntity(FlatBufferBuilder builder, int targetPhantomExhibitEntity)
		{
			builder.AddInt(21, targetPhantomExhibitEntity, 0);
		}

		// Token: 0x06033BC3 RID: 211907 RVA: 0x006FA3C2 File Offset: 0x006F85C2
		public static void AddTargetWeaponExhibitEntities(FlatBufferBuilder builder, VectorOffset targetWeaponExhibitEntitiesOffset)
		{
			builder.AddOffset(22, targetWeaponExhibitEntitiesOffset.Value, 0);
		}

		// Token: 0x06033BC4 RID: 211908 RVA: 0x006FA3D4 File Offset: 0x006F85D4
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BC5 RID: 211909 RVA: 0x006FA40B File Offset: 0x006F860B
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BC6 RID: 211910 RVA: 0x006FA425 File Offset: 0x006F8625
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BC7 RID: 211911 RVA: 0x006FA443 File Offset: 0x006F8643
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BC8 RID: 211912 RVA: 0x006FA45C File Offset: 0x006F865C
		public static void StartTargetWeaponExhibitEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033BC9 RID: 211913 RVA: 0x006FA467 File Offset: 0x006F8667
		public static void AddBlockAutoOpenUiAfterDungeon(FlatBufferBuilder builder, bool blockAutoOpenUiAfterDungeon)
		{
			builder.AddBool(23, blockAutoOpenUiAfterDungeon, false);
		}

		// Token: 0x06033BCA RID: 211914 RVA: 0x006FA473 File Offset: 0x006F8673
		public static void AddGuessJokerLevel(FlatBufferBuilder builder, int guessJokerLevel)
		{
			builder.AddInt(24, guessJokerLevel, 0);
		}

		// Token: 0x06033BCB RID: 211915 RVA: 0x006FA47F File Offset: 0x006F867F
		public static void AddPictureCaptionConfig(FlatBufferBuilder builder, Offset<IPictureCaptionConfig> pictureCaptionConfigOffset)
		{
			builder.AddOffset(25, pictureCaptionConfigOffset.Value, 0);
		}

		// Token: 0x06033BCC RID: 211916 RVA: 0x006FA490 File Offset: 0x006F8690
		public static void AddTetrisBoardGameEntity(FlatBufferBuilder builder, int tetrisBoardGameEntity)
		{
			builder.AddInt(26, tetrisBoardGameEntity, 0);
		}

		// Token: 0x06033BCD RID: 211917 RVA: 0x006FA49C File Offset: 0x006F869C
		public static void AddVillageInfrBuildStageType(FlatBufferBuilder builder, TVillageInfrBuildType villageInfrBuildStageType)
		{
			builder.AddByte(27, (byte)villageInfrBuildStageType, 0);
		}

		// Token: 0x06033BCE RID: 211918 RVA: 0x006FA4A8 File Offset: 0x006F86A8
		public static void AddVillageInfrBuildStage(FlatBufferBuilder builder, int villageInfrBuildStageOffset)
		{
			builder.AddOffset(28, villageInfrBuildStageOffset, 0);
		}

		// Token: 0x06033BCF RID: 211919 RVA: 0x006FA4B4 File Offset: 0x006F86B4
		public static void AddVillageInfrDeliveryUiCamera(FlatBufferBuilder builder, StringOffset villageInfrDeliveryUiCameraOffset)
		{
			builder.AddOffset(29, villageInfrDeliveryUiCameraOffset.Value, 0);
		}

		// Token: 0x06033BD0 RID: 211920 RVA: 0x006FA4C5 File Offset: 0x006F86C5
		public static void AddQuestBranchConfig(FlatBufferBuilder builder, Offset<IQuestBranchConfig> questBranchConfigOffset)
		{
			builder.AddOffset(30, questBranchConfigOffset.Value, 0);
		}

		// Token: 0x06033BD1 RID: 211921 RVA: 0x006FA4D6 File Offset: 0x006F86D6
		public static void AddWriteLetterConfig(FlatBufferBuilder builder, Offset<IWriteLetterConfig> writeLetterConfigOffset)
		{
			builder.AddOffset(31, writeLetterConfigOffset.Value, 0);
		}

		// Token: 0x06033BD2 RID: 211922 RVA: 0x006FA4E7 File Offset: 0x006F86E7
		public static void AddDollGrabShowcaseEntityId(FlatBufferBuilder builder, int dollGrabShowcaseEntityId)
		{
			builder.AddInt(32, dollGrabShowcaseEntityId, 0);
		}

		// Token: 0x06033BD3 RID: 211923 RVA: 0x006FA4F3 File Offset: 0x006F86F3
		public static void AddMechascoutMindSpaceTextKeys(FlatBufferBuilder builder, VectorOffset mechascoutMindSpaceTextKeysOffset)
		{
			builder.AddOffset(33, mechascoutMindSpaceTextKeysOffset.Value, 0);
		}

		// Token: 0x06033BD4 RID: 211924 RVA: 0x006FA504 File Offset: 0x006F8704
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033BD5 RID: 211925 RVA: 0x006FA544 File Offset: 0x006F8744
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BD6 RID: 211926 RVA: 0x006FA55E File Offset: 0x006F875E
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06033BD7 RID: 211927 RVA: 0x006FA57C File Offset: 0x006F877C
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033BD8 RID: 211928 RVA: 0x006FA595 File Offset: 0x006F8795
		public static void StartMechascoutMindSpaceTextKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033BD9 RID: 211929 RVA: 0x006FA5A0 File Offset: 0x006F87A0
		public static void AddDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder, Offset<IDeliverItemProbeCollectiblesConfig> deliverItemProbeCollectiblesConfigOffset)
		{
			builder.AddOffset(34, deliverItemProbeCollectiblesConfigOffset.Value, 0);
		}

		// Token: 0x06033BDA RID: 211930 RVA: 0x006FA5B1 File Offset: 0x006F87B1
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(35, nullMask, 0);
		}

		// Token: 0x06033BDB RID: 211931 RVA: 0x006FA5BD File Offset: 0x006F87BD
		public static Offset<IOpenSystemBoard> EndIOpenSystemBoard(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoard>(builder.EndTable());
		}

		// Token: 0x06033BDC RID: 211932 RVA: 0x006FA5CC File Offset: 0x006F87CC
		public IOpenSystemBoardT UnPack()
		{
			IOpenSystemBoardT openSystemBoardT = new IOpenSystemBoardT();
			this.UnPackTo(openSystemBoardT);
			return openSystemBoardT;
		}

		// Token: 0x06033BDD RID: 211933 RVA: 0x006FA5E8 File Offset: 0x006F87E8
		public void UnPackTo(IOpenSystemBoardT _o)
		{
			_o.SystemType = this.SystemType;
			_o.BoardId = this.BoardId;
			_o.ActionMontage = this.ActionMontage;
			_o.InputVars = new List<TVarRefUnion>();
			for (int i = 0; i < this.InputVarsLength; i++)
			{
				TVarRefUnion tvarRefUnion = new TVarRefUnion();
				tvarRefUnion.Type = this.InputVarsType(i);
				switch (this.InputVarsType(i))
				{
				case TVarRef.IConstVarRef:
					tvarRefUnion.Value = ((this.InputVars<IConstVarRef>(i) != null) ? this.InputVars<IConstVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IGlobalVarRef:
					tvarRefUnion.Value = ((this.InputVars<IGlobalVarRef>(i) != null) ? this.InputVars<IGlobalVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.IOtherVarRef:
					tvarRefUnion.Value = ((this.InputVars<IOtherVarRef>(i) != null) ? this.InputVars<IOtherVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISelfVarRef:
					tvarRefUnion.Value = ((this.InputVars<ISelfVarRef>(i) != null) ? this.InputVars<ISelfVarRef>(i).Value.UnPack() : null);
					break;
				case TVarRef.ISystemVarRef:
					tvarRefUnion.Value = ((this.InputVars<ISystemVarRef>(i) != null) ? this.InputVars<ISystemVarRef>(i).Value.UnPack() : null);
					break;
				}
				_o.InputVars.Add(tvarRefUnion);
			}
			_o.UiCameraName = this.UiCameraName;
			_o.PhotographConfig = ((this.PhotographConfig != null) ? this.PhotographConfig.Value.UnPack() : null);
			_o.InformationViewConfig = ((this.InformationViewConfig != null) ? this.InformationViewConfig.Value.UnPack() : null);
			_o.GramophoneId = this.GramophoneId;
			_o.SetMapMusic = this.SetMapMusic;
			_o.FadeInScreenWhenClose = this.FadeInScreenWhenClose;
			_o.SyncOpenSystemBoardFinishTiming = this.SyncOpenSystemBoardFinishTiming;
			_o.Seats = new List<int>();
			for (int j = 0; j < this.SeatsLength; j++)
			{
				_o.Seats.Add(this.Seats(j));
			}
			_o.PlotReviewJumpTipsNodeId = this.PlotReviewJumpTipsNodeId;
			_o.WaitLoading = this.WaitLoading;
			_o.TransitionPopupConfig = ((this.TransitionPopupConfig != null) ? this.TransitionPopupConfig.Value.UnPack() : null);
			_o.FightPreparationEntityId = this.FightPreparationEntityId;
			_o.FightPreparationUiCamera = this.FightPreparationUiCamera;
			_o.InfrActivityBuildStage = new TInfrActivityBuildStageTypeUnion();
			_o.InfrActivityBuildStage.Type = this.InfrActivityBuildStageType;
			TInfrActivityBuildStageType infrActivityBuildStageType = this.InfrActivityBuildStageType;
			if (infrActivityBuildStageType != TInfrActivityBuildStageType.IInfrActivityInfrastructureStage)
			{
				if (infrActivityBuildStageType == TInfrActivityBuildStageType.IInfrActivityRoadProcess)
				{
					_o.InfrActivityBuildStage.Value = ((this.InfrActivityBuildStage<IInfrActivityRoadProcess>() != null) ? this.InfrActivityBuildStage<IInfrActivityRoadProcess>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.InfrActivityBuildStage.Value = ((this.InfrActivityBuildStage<IInfrActivityInfrastructureStage>() != null) ? this.InfrActivityBuildStage<IInfrActivityInfrastructureStage>().Value.UnPack() : null);
			}
			_o.MapConfig = ((this.MapConfig != null) ? this.MapConfig.Value.UnPack() : null);
			_o.TargetPhantomExhibitEntity = this.TargetPhantomExhibitEntity;
			_o.TargetWeaponExhibitEntities = new List<int>();
			for (int k = 0; k < this.TargetWeaponExhibitEntitiesLength; k++)
			{
				_o.TargetWeaponExhibitEntities.Add(this.TargetWeaponExhibitEntities(k));
			}
			_o.BlockAutoOpenUiAfterDungeon = this.BlockAutoOpenUiAfterDungeon;
			_o.GuessJokerLevel = this.GuessJokerLevel;
			_o.PictureCaptionConfig = ((this.PictureCaptionConfig != null) ? this.PictureCaptionConfig.Value.UnPack() : null);
			_o.TetrisBoardGameEntity = this.TetrisBoardGameEntity;
			_o.VillageInfrBuildStage = new TVillageInfrBuildTypeUnion();
			_o.VillageInfrBuildStage.Type = this.VillageInfrBuildStageType;
			TVillageInfrBuildType villageInfrBuildStageType = this.VillageInfrBuildStageType;
			if (villageInfrBuildStageType != TVillageInfrBuildType.IVillageInfrTreeProcess)
			{
				if (villageInfrBuildStageType == TVillageInfrBuildType.IVillageInfrVillageLevel)
				{
					_o.VillageInfrBuildStage.Value = ((this.VillageInfrBuildStage<IVillageInfrVillageLevel>() != null) ? this.VillageInfrBuildStage<IVillageInfrVillageLevel>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.VillageInfrBuildStage.Value = ((this.VillageInfrBuildStage<IVillageInfrTreeProcess>() != null) ? this.VillageInfrBuildStage<IVillageInfrTreeProcess>().Value.UnPack() : null);
			}
			_o.VillageInfrDeliveryUiCamera = this.VillageInfrDeliveryUiCamera;
			_o.QuestBranchConfig = ((this.QuestBranchConfig != null) ? this.QuestBranchConfig.Value.UnPack() : null);
			_o.WriteLetterConfig = ((this.WriteLetterConfig != null) ? this.WriteLetterConfig.Value.UnPack() : null);
			_o.DollGrabShowcaseEntityId = this.DollGrabShowcaseEntityId;
			_o.MechascoutMindSpaceTextKeys = new List<string>();
			for (int l = 0; l < this.MechascoutMindSpaceTextKeysLength; l++)
			{
				_o.MechascoutMindSpaceTextKeys.Add(this.MechascoutMindSpaceTextKeys(l));
			}
			_o.DeliverItemProbeCollectiblesConfig = ((this.DeliverItemProbeCollectiblesConfig != null) ? this.DeliverItemProbeCollectiblesConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033BDE RID: 211934 RVA: 0x006FABBC File Offset: 0x006F8DBC
		public static Offset<IOpenSystemBoard> Pack(FlatBufferBuilder builder, IOpenSystemBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemBoard>);
			}
			StringOffset actionMontageOffset = (_o.ActionMontage == null) ? default(StringOffset) : builder.CreateString(_o.ActionMontage);
			VectorOffset inputVars_typeOffset = default(VectorOffset);
			if (_o.InputVars != null)
			{
				TVarRef[] array = new TVarRef[_o.InputVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.InputVars[i].Type;
				}
				inputVars_typeOffset = IOpenSystemBoard.CreateInputVarsTypeVector(builder, array);
			}
			VectorOffset inputVarsOffset = default(VectorOffset);
			if (_o.InputVars != null)
			{
				int[] array2 = new int[_o.InputVars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVarRefUnion.Pack(builder, _o.InputVars[j]);
				}
				inputVarsOffset = IOpenSystemBoard.CreateInputVarsVector(builder, array2);
			}
			StringOffset uiCameraNameOffset = (_o.UiCameraName == null) ? default(StringOffset) : builder.CreateString(_o.UiCameraName);
			Offset<IPhotographConfig> photographConfigOffset = (_o.PhotographConfig == null) ? default(Offset<IPhotographConfig>) : IPhotographConfig.Pack(builder, _o.PhotographConfig);
			Offset<IInformationViewConfig> informationViewConfigOffset = (_o.InformationViewConfig == null) ? default(Offset<IInformationViewConfig>) : IInformationViewConfig.Pack(builder, _o.InformationViewConfig);
			VectorOffset seatsOffset = default(VectorOffset);
			if (_o.Seats != null)
			{
				int[] data = _o.Seats.ToArray();
				seatsOffset = IOpenSystemBoard.CreateSeatsVector(builder, data);
			}
			Offset<ITransitionPopupConfig> transitionPopupConfigOffset = (_o.TransitionPopupConfig == null) ? default(Offset<ITransitionPopupConfig>) : ITransitionPopupConfig.Pack(builder, _o.TransitionPopupConfig);
			StringOffset fightPreparationUiCameraOffset = (_o.FightPreparationUiCamera == null) ? default(StringOffset) : builder.CreateString(_o.FightPreparationUiCamera);
			TInfrActivityBuildStageType infrActivityBuildStage_type = (_o.InfrActivityBuildStage == null) ? TInfrActivityBuildStageType.NONE : _o.InfrActivityBuildStage.Type;
			int infrActivityBuildStageOffset = (_o.InfrActivityBuildStage == null) ? 0 : TInfrActivityBuildStageTypeUnion.Pack(builder, _o.InfrActivityBuildStage);
			VectorOffset targetWeaponExhibitEntitiesOffset = default(VectorOffset);
			if (_o.TargetWeaponExhibitEntities != null)
			{
				int[] data2 = _o.TargetWeaponExhibitEntities.ToArray();
				targetWeaponExhibitEntitiesOffset = IOpenSystemBoard.CreateTargetWeaponExhibitEntitiesVector(builder, data2);
			}
			Offset<IPictureCaptionConfig> pictureCaptionConfigOffset = (_o.PictureCaptionConfig == null) ? default(Offset<IPictureCaptionConfig>) : IPictureCaptionConfig.Pack(builder, _o.PictureCaptionConfig);
			TVillageInfrBuildType villageInfrBuildStage_type = (_o.VillageInfrBuildStage == null) ? TVillageInfrBuildType.NONE : _o.VillageInfrBuildStage.Type;
			int villageInfrBuildStageOffset = (_o.VillageInfrBuildStage == null) ? 0 : TVillageInfrBuildTypeUnion.Pack(builder, _o.VillageInfrBuildStage);
			StringOffset villageInfrDeliveryUiCameraOffset = (_o.VillageInfrDeliveryUiCamera == null) ? default(StringOffset) : builder.CreateString(_o.VillageInfrDeliveryUiCamera);
			Offset<IQuestBranchConfig> questBranchConfigOffset = (_o.QuestBranchConfig == null) ? default(Offset<IQuestBranchConfig>) : IQuestBranchConfig.Pack(builder, _o.QuestBranchConfig);
			Offset<IWriteLetterConfig> writeLetterConfigOffset = (_o.WriteLetterConfig == null) ? default(Offset<IWriteLetterConfig>) : IWriteLetterConfig.Pack(builder, _o.WriteLetterConfig);
			VectorOffset mechascoutMindSpaceTextKeysOffset = default(VectorOffset);
			if (_o.MechascoutMindSpaceTextKeys != null)
			{
				StringOffset[] array3 = new StringOffset[_o.MechascoutMindSpaceTextKeys.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.MechascoutMindSpaceTextKeys[k]);
				}
				mechascoutMindSpaceTextKeysOffset = IOpenSystemBoard.CreateMechascoutMindSpaceTextKeysVector(builder, array3);
			}
			Offset<IDeliverItemProbeCollectiblesConfig> deliverItemProbeCollectiblesConfigOffset = (_o.DeliverItemProbeCollectiblesConfig == null) ? default(Offset<IDeliverItemProbeCollectiblesConfig>) : IDeliverItemProbeCollectiblesConfig.Pack(builder, _o.DeliverItemProbeCollectiblesConfig);
			return IOpenSystemBoard.CreateIOpenSystemBoard(builder, _o.SystemType, _o.BoardId, actionMontageOffset, inputVars_typeOffset, inputVarsOffset, uiCameraNameOffset, photographConfigOffset, informationViewConfigOffset, _o.GramophoneId, _o.SetMapMusic, _o.FadeInScreenWhenClose, _o.SyncOpenSystemBoardFinishTiming, seatsOffset, _o.PlotReviewJumpTipsNodeId, _o.WaitLoading, transitionPopupConfigOffset, _o.FightPreparationEntityId, fightPreparationUiCameraOffset, infrActivityBuildStage_type, infrActivityBuildStageOffset, _o.MapConfig, _o.TargetPhantomExhibitEntity, targetWeaponExhibitEntitiesOffset, _o.BlockAutoOpenUiAfterDungeon, _o.GuessJokerLevel, pictureCaptionConfigOffset, _o.TetrisBoardGameEntity, villageInfrBuildStage_type, villageInfrBuildStageOffset, villageInfrDeliveryUiCameraOffset, questBranchConfigOffset, writeLetterConfigOffset, _o.DollGrabShowcaseEntityId, mechascoutMindSpaceTextKeysOffset, deliverItemProbeCollectiblesConfigOffset, _o.NullMask);
		}

		// Token: 0x040124A2 RID: 74914
		private Table __p;
	}
}
