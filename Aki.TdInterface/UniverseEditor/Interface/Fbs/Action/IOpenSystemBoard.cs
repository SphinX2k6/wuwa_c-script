using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C36 RID: 27702
	public struct IOpenSystemBoard : IFlatbufferObject
	{
		// Token: 0x1700CE19 RID: 52761
		// (get) Token: 0x06030C03 RID: 199683 RVA: 0x0069EE53 File Offset: 0x0069D053
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C04 RID: 199684 RVA: 0x0069EE60 File Offset: 0x0069D060
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C05 RID: 199685 RVA: 0x0069EE68 File Offset: 0x0069D068
		public static IOpenSystemBoard GetRootAsIOpenSystemBoard(ByteBuffer _bb)
		{
			return IOpenSystemBoard.GetRootAsIOpenSystemBoard(_bb, default(IOpenSystemBoard));
		}

		// Token: 0x06030C06 RID: 199686 RVA: 0x0069EE84 File Offset: 0x0069D084
		public static IOpenSystemBoard GetRootAsIOpenSystemBoard(ByteBuffer _bb, IOpenSystemBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C07 RID: 199687 RVA: 0x0069EEA1 File Offset: 0x0069D0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C08 RID: 199688 RVA: 0x0069EEB0 File Offset: 0x0069D0B0
		public IOpenSystemBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE1A RID: 52762
		// (get) Token: 0x06030C09 RID: 199689 RVA: 0x0069EEC0 File Offset: 0x0069D0C0
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

		// Token: 0x1700CE1B RID: 52763
		// (get) Token: 0x06030C0A RID: 199690 RVA: 0x0069EEFC File Offset: 0x0069D0FC
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

		// Token: 0x1700CE1C RID: 52764
		// (get) Token: 0x06030C0B RID: 199691 RVA: 0x0069EF38 File Offset: 0x0069D138
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

		// Token: 0x06030C0C RID: 199692 RVA: 0x0069EF6F File Offset: 0x0069D16F
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030C0D RID: 199693 RVA: 0x0069EF7E File Offset: 0x0069D17E
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06030C0E RID: 199694 RVA: 0x0069EF8C File Offset: 0x0069D18C
		public TVarRef InputVarsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TVarRef.NONE;
			}
			return (TVarRef)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700CE1D RID: 52765
		// (get) Token: 0x06030C0F RID: 199695 RVA: 0x0069EFCC File Offset: 0x0069D1CC
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

		// Token: 0x06030C10 RID: 199696 RVA: 0x0069EFF8 File Offset: 0x0069D1F8
		public Span<TVarRef> GetInputVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TVarRef>(10, 1);
		}

		// Token: 0x06030C11 RID: 199697 RVA: 0x0069F008 File Offset: 0x0069D208
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

		// Token: 0x06030C12 RID: 199698 RVA: 0x0069F074 File Offset: 0x0069D274
		public TTable? InputVars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700CE1E RID: 52766
		// (get) Token: 0x06030C13 RID: 199699 RVA: 0x0069F0BC File Offset: 0x0069D2BC
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

		// Token: 0x1700CE1F RID: 52767
		// (get) Token: 0x06030C14 RID: 199700 RVA: 0x0069F0E8 File Offset: 0x0069D2E8
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

		// Token: 0x06030C15 RID: 199701 RVA: 0x0069F120 File Offset: 0x0069D320
		public Span<byte> GetUiCameraNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06030C16 RID: 199702 RVA: 0x0069F130 File Offset: 0x0069D330
		public byte[] GetUiCameraNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700CE20 RID: 52768
		// (get) Token: 0x06030C17 RID: 199703 RVA: 0x0069F140 File Offset: 0x0069D340
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

		// Token: 0x1700CE21 RID: 52769
		// (get) Token: 0x06030C18 RID: 199704 RVA: 0x0069F1A0 File Offset: 0x0069D3A0
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

		// Token: 0x1700CE22 RID: 52770
		// (get) Token: 0x06030C19 RID: 199705 RVA: 0x0069F200 File Offset: 0x0069D400
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

		// Token: 0x1700CE23 RID: 52771
		// (get) Token: 0x06030C1A RID: 199706 RVA: 0x0069F240 File Offset: 0x0069D440
		public bool SetMapMusic
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE24 RID: 52772
		// (get) Token: 0x06030C1B RID: 199707 RVA: 0x0069F280 File Offset: 0x0069D480
		public bool FadeInScreenWhenClose
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE25 RID: 52773
		// (get) Token: 0x06030C1C RID: 199708 RVA: 0x0069F2C0 File Offset: 0x0069D4C0
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

		// Token: 0x06030C1D RID: 199709 RVA: 0x0069F300 File Offset: 0x0069D500
		public int Seats(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CE26 RID: 52774
		// (get) Token: 0x06030C1E RID: 199710 RVA: 0x0069F340 File Offset: 0x0069D540
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

		// Token: 0x06030C1F RID: 199711 RVA: 0x0069F36C File Offset: 0x0069D56C
		public Span<int> GetSeatsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06030C20 RID: 199712 RVA: 0x0069F37C File Offset: 0x0069D57C
		public int[] GetSeatsArray()
		{
			return this.__p.__vector_as_array<int>(28);
		}

		// Token: 0x1700CE27 RID: 52775
		// (get) Token: 0x06030C21 RID: 199713 RVA: 0x0069F38C File Offset: 0x0069D58C
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

		// Token: 0x1700CE28 RID: 52776
		// (get) Token: 0x06030C22 RID: 199714 RVA: 0x0069F3CC File Offset: 0x0069D5CC
		public bool WaitLoading
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE29 RID: 52777
		// (get) Token: 0x06030C23 RID: 199715 RVA: 0x0069F40C File Offset: 0x0069D60C
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

		// Token: 0x1700CE2A RID: 52778
		// (get) Token: 0x06030C24 RID: 199716 RVA: 0x0069F46C File Offset: 0x0069D66C
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

		// Token: 0x1700CE2B RID: 52779
		// (get) Token: 0x06030C25 RID: 199717 RVA: 0x0069F4AC File Offset: 0x0069D6AC
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

		// Token: 0x06030C26 RID: 199718 RVA: 0x0069F4E4 File Offset: 0x0069D6E4
		public Span<byte> GetFightPreparationUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06030C27 RID: 199719 RVA: 0x0069F4F4 File Offset: 0x0069D6F4
		public byte[] GetFightPreparationUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x1700CE2C RID: 52780
		// (get) Token: 0x06030C28 RID: 199720 RVA: 0x0069F504 File Offset: 0x0069D704
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

		// Token: 0x06030C29 RID: 199721 RVA: 0x0069F544 File Offset: 0x0069D744
		public TTable? InfrActivityBuildStage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030C2A RID: 199722 RVA: 0x0069F58C File Offset: 0x0069D78C
		public IInfrActivityInfrastructureStage InfrActivityBuildStageAsIInfrActivityInfrastructureStage()
		{
			return this.InfrActivityBuildStage<IInfrActivityInfrastructureStage>().Value;
		}

		// Token: 0x06030C2B RID: 199723 RVA: 0x0069F5A8 File Offset: 0x0069D7A8
		public IInfrActivityRoadProcess InfrActivityBuildStageAsIInfrActivityRoadProcess()
		{
			return this.InfrActivityBuildStage<IInfrActivityRoadProcess>().Value;
		}

		// Token: 0x1700CE2D RID: 52781
		// (get) Token: 0x06030C2C RID: 199724 RVA: 0x0069F5C4 File Offset: 0x0069D7C4
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

		// Token: 0x1700CE2E RID: 52782
		// (get) Token: 0x06030C2D RID: 199725 RVA: 0x0069F618 File Offset: 0x0069D818
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

		// Token: 0x06030C2E RID: 199726 RVA: 0x0069F658 File Offset: 0x0069D858
		public int TargetWeaponExhibitEntities(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CE2F RID: 52783
		// (get) Token: 0x06030C2F RID: 199727 RVA: 0x0069F698 File Offset: 0x0069D898
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

		// Token: 0x06030C30 RID: 199728 RVA: 0x0069F6C4 File Offset: 0x0069D8C4
		public Span<int> GetTargetWeaponExhibitEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x06030C31 RID: 199729 RVA: 0x0069F6D4 File Offset: 0x0069D8D4
		public int[] GetTargetWeaponExhibitEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(48);
		}

		// Token: 0x1700CE30 RID: 52784
		// (get) Token: 0x06030C32 RID: 199730 RVA: 0x0069F6E4 File Offset: 0x0069D8E4
		public bool BlockAutoOpenUiAfterDungeon
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE31 RID: 52785
		// (get) Token: 0x06030C33 RID: 199731 RVA: 0x0069F724 File Offset: 0x0069D924
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

		// Token: 0x1700CE32 RID: 52786
		// (get) Token: 0x06030C34 RID: 199732 RVA: 0x0069F764 File Offset: 0x0069D964
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

		// Token: 0x1700CE33 RID: 52787
		// (get) Token: 0x06030C35 RID: 199733 RVA: 0x0069F7C4 File Offset: 0x0069D9C4
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

		// Token: 0x1700CE34 RID: 52788
		// (get) Token: 0x06030C36 RID: 199734 RVA: 0x0069F804 File Offset: 0x0069DA04
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

		// Token: 0x06030C37 RID: 199735 RVA: 0x0069F844 File Offset: 0x0069DA44
		public TTable? VillageInfrBuildStage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030C38 RID: 199736 RVA: 0x0069F88C File Offset: 0x0069DA8C
		public IVillageInfrTreeProcess VillageInfrBuildStageAsIVillageInfrTreeProcess()
		{
			return this.VillageInfrBuildStage<IVillageInfrTreeProcess>().Value;
		}

		// Token: 0x06030C39 RID: 199737 RVA: 0x0069F8A8 File Offset: 0x0069DAA8
		public IVillageInfrVillageLevel VillageInfrBuildStageAsIVillageInfrVillageLevel()
		{
			return this.VillageInfrBuildStage<IVillageInfrVillageLevel>().Value;
		}

		// Token: 0x1700CE35 RID: 52789
		// (get) Token: 0x06030C3A RID: 199738 RVA: 0x0069F8C4 File Offset: 0x0069DAC4
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

		// Token: 0x06030C3B RID: 199739 RVA: 0x0069F8FC File Offset: 0x0069DAFC
		public Span<byte> GetVillageInfrDeliveryUiCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06030C3C RID: 199740 RVA: 0x0069F90C File Offset: 0x0069DB0C
		public byte[] GetVillageInfrDeliveryUiCameraArray()
		{
			return this.__p.__vector_as_array<byte>(62);
		}

		// Token: 0x1700CE36 RID: 52790
		// (get) Token: 0x06030C3D RID: 199741 RVA: 0x0069F91C File Offset: 0x0069DB1C
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

		// Token: 0x1700CE37 RID: 52791
		// (get) Token: 0x06030C3E RID: 199742 RVA: 0x0069F97C File Offset: 0x0069DB7C
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

		// Token: 0x1700CE38 RID: 52792
		// (get) Token: 0x06030C3F RID: 199743 RVA: 0x0069F9DC File Offset: 0x0069DBDC
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

		// Token: 0x06030C40 RID: 199744 RVA: 0x0069FA1C File Offset: 0x0069DC1C
		public string MechascoutMindSpaceTextKeys(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CE39 RID: 52793
		// (get) Token: 0x06030C41 RID: 199745 RVA: 0x0069FA58 File Offset: 0x0069DC58
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

		// Token: 0x1700CE3A RID: 52794
		// (get) Token: 0x06030C42 RID: 199746 RVA: 0x0069FA84 File Offset: 0x0069DC84
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

		// Token: 0x1700CE3B RID: 52795
		// (get) Token: 0x06030C43 RID: 199747 RVA: 0x0069FAE4 File Offset: 0x0069DCE4
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

		// Token: 0x06030C44 RID: 199748 RVA: 0x0069FB24 File Offset: 0x0069DD24
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

		// Token: 0x06030C45 RID: 199749 RVA: 0x0069FC62 File Offset: 0x0069DE62
		public static void StartIOpenSystemBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(36);
		}

		// Token: 0x06030C46 RID: 199750 RVA: 0x0069FC6C File Offset: 0x0069DE6C
		public static void AddSystemType(FlatBufferBuilder builder, ESystemType systemType)
		{
			builder.AddByte(0, (byte)systemType, 0);
		}

		// Token: 0x06030C47 RID: 199751 RVA: 0x0069FC77 File Offset: 0x0069DE77
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x06030C48 RID: 199752 RVA: 0x0069FC82 File Offset: 0x0069DE82
		public static void AddActionMontage(FlatBufferBuilder builder, StringOffset actionMontageOffset)
		{
			builder.AddOffset(2, actionMontageOffset.Value, 0);
		}

		// Token: 0x06030C49 RID: 199753 RVA: 0x0069FC92 File Offset: 0x0069DE92
		public static void AddInputVarsType(FlatBufferBuilder builder, VectorOffset inputVarsTypeOffset)
		{
			builder.AddOffset(3, inputVarsTypeOffset.Value, 0);
		}

		// Token: 0x06030C4A RID: 199754 RVA: 0x0069FCA4 File Offset: 0x0069DEA4
		public static VectorOffset CreateInputVarsTypeVector(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030C4B RID: 199755 RVA: 0x0069FCDB File Offset: 0x0069DEDB
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, TVarRef[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C4C RID: 199756 RVA: 0x0069FCF5 File Offset: 0x0069DEF5
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVarRef> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVarRef>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C4D RID: 199757 RVA: 0x0069FD13 File Offset: 0x0069DF13
		public static VectorOffset CreateInputVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVarRef>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030C4E RID: 199758 RVA: 0x0069FD2C File Offset: 0x0069DF2C
		public static void StartInputVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06030C4F RID: 199759 RVA: 0x0069FD37 File Offset: 0x0069DF37
		public static void AddInputVars(FlatBufferBuilder builder, VectorOffset inputVarsOffset)
		{
			builder.AddOffset(4, inputVarsOffset.Value, 0);
		}

		// Token: 0x06030C50 RID: 199760 RVA: 0x0069FD48 File Offset: 0x0069DF48
		public static VectorOffset CreateInputVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030C51 RID: 199761 RVA: 0x0069FD7F File Offset: 0x0069DF7F
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C52 RID: 199762 RVA: 0x0069FD99 File Offset: 0x0069DF99
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C53 RID: 199763 RVA: 0x0069FDB7 File Offset: 0x0069DFB7
		public static VectorOffset CreateInputVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030C54 RID: 199764 RVA: 0x0069FDD0 File Offset: 0x0069DFD0
		public static void StartInputVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030C55 RID: 199765 RVA: 0x0069FDDB File Offset: 0x0069DFDB
		public static void AddUiCameraName(FlatBufferBuilder builder, StringOffset uiCameraNameOffset)
		{
			builder.AddOffset(5, uiCameraNameOffset.Value, 0);
		}

		// Token: 0x06030C56 RID: 199766 RVA: 0x0069FDEB File Offset: 0x0069DFEB
		public static void AddPhotographConfig(FlatBufferBuilder builder, Offset<IPhotographConfig> photographConfigOffset)
		{
			builder.AddOffset(6, photographConfigOffset.Value, 0);
		}

		// Token: 0x06030C57 RID: 199767 RVA: 0x0069FDFB File Offset: 0x0069DFFB
		public static void AddInformationViewConfig(FlatBufferBuilder builder, Offset<IInformationViewConfig> informationViewConfigOffset)
		{
			builder.AddOffset(7, informationViewConfigOffset.Value, 0);
		}

		// Token: 0x06030C58 RID: 199768 RVA: 0x0069FE0B File Offset: 0x0069E00B
		public static void AddGramophoneId(FlatBufferBuilder builder, int gramophoneId)
		{
			builder.AddInt(8, gramophoneId, 0);
		}

		// Token: 0x06030C59 RID: 199769 RVA: 0x0069FE16 File Offset: 0x0069E016
		public static void AddSetMapMusic(FlatBufferBuilder builder, bool setMapMusic)
		{
			builder.AddBool(9, setMapMusic, false);
		}

		// Token: 0x06030C5A RID: 199770 RVA: 0x0069FE22 File Offset: 0x0069E022
		public static void AddFadeInScreenWhenClose(FlatBufferBuilder builder, bool fadeInScreenWhenClose)
		{
			builder.AddBool(10, fadeInScreenWhenClose, false);
		}

		// Token: 0x06030C5B RID: 199771 RVA: 0x0069FE2E File Offset: 0x0069E02E
		public static void AddSyncOpenSystemBoardFinishTiming(FlatBufferBuilder builder, ESyncOpenSystemBoardFinishTiming syncOpenSystemBoardFinishTiming)
		{
			builder.AddByte(11, (byte)syncOpenSystemBoardFinishTiming, 0);
		}

		// Token: 0x06030C5C RID: 199772 RVA: 0x0069FE3A File Offset: 0x0069E03A
		public static void AddSeats(FlatBufferBuilder builder, VectorOffset seatsOffset)
		{
			builder.AddOffset(12, seatsOffset.Value, 0);
		}

		// Token: 0x06030C5D RID: 199773 RVA: 0x0069FE4C File Offset: 0x0069E04C
		public static VectorOffset CreateSeatsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030C5E RID: 199774 RVA: 0x0069FE83 File Offset: 0x0069E083
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C5F RID: 199775 RVA: 0x0069FE9D File Offset: 0x0069E09D
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C60 RID: 199776 RVA: 0x0069FEBB File Offset: 0x0069E0BB
		public static VectorOffset CreateSeatsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030C61 RID: 199777 RVA: 0x0069FED4 File Offset: 0x0069E0D4
		public static void StartSeatsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030C62 RID: 199778 RVA: 0x0069FEDF File Offset: 0x0069E0DF
		public static void AddPlotReviewJumpTipsNodeId(FlatBufferBuilder builder, int plotReviewJumpTipsNodeId)
		{
			builder.AddInt(13, plotReviewJumpTipsNodeId, 0);
		}

		// Token: 0x06030C63 RID: 199779 RVA: 0x0069FEEB File Offset: 0x0069E0EB
		public static void AddWaitLoading(FlatBufferBuilder builder, bool waitLoading)
		{
			builder.AddBool(14, waitLoading, false);
		}

		// Token: 0x06030C64 RID: 199780 RVA: 0x0069FEF7 File Offset: 0x0069E0F7
		public static void AddTransitionPopupConfig(FlatBufferBuilder builder, Offset<ITransitionPopupConfig> transitionPopupConfigOffset)
		{
			builder.AddOffset(15, transitionPopupConfigOffset.Value, 0);
		}

		// Token: 0x06030C65 RID: 199781 RVA: 0x0069FF08 File Offset: 0x0069E108
		public static void AddFightPreparationEntityId(FlatBufferBuilder builder, int fightPreparationEntityId)
		{
			builder.AddInt(16, fightPreparationEntityId, 0);
		}

		// Token: 0x06030C66 RID: 199782 RVA: 0x0069FF14 File Offset: 0x0069E114
		public static void AddFightPreparationUiCamera(FlatBufferBuilder builder, StringOffset fightPreparationUiCameraOffset)
		{
			builder.AddOffset(17, fightPreparationUiCameraOffset.Value, 0);
		}

		// Token: 0x06030C67 RID: 199783 RVA: 0x0069FF25 File Offset: 0x0069E125
		public static void AddInfrActivityBuildStageType(FlatBufferBuilder builder, TInfrActivityBuildStageType infrActivityBuildStageType)
		{
			builder.AddByte(18, (byte)infrActivityBuildStageType, 0);
		}

		// Token: 0x06030C68 RID: 199784 RVA: 0x0069FF31 File Offset: 0x0069E131
		public static void AddInfrActivityBuildStage(FlatBufferBuilder builder, int infrActivityBuildStageOffset)
		{
			builder.AddOffset(19, infrActivityBuildStageOffset, 0);
		}

		// Token: 0x06030C69 RID: 199785 RVA: 0x0069FF3D File Offset: 0x0069E13D
		public static void AddMapConfig(FlatBufferBuilder builder, Offset<IMapConfig> mapConfigOffset)
		{
			builder.AddStruct(20, mapConfigOffset.Value, 0);
		}

		// Token: 0x06030C6A RID: 199786 RVA: 0x0069FF4E File Offset: 0x0069E14E
		public static void AddTargetPhantomExhibitEntity(FlatBufferBuilder builder, int targetPhantomExhibitEntity)
		{
			builder.AddInt(21, targetPhantomExhibitEntity, 0);
		}

		// Token: 0x06030C6B RID: 199787 RVA: 0x0069FF5A File Offset: 0x0069E15A
		public static void AddTargetWeaponExhibitEntities(FlatBufferBuilder builder, VectorOffset targetWeaponExhibitEntitiesOffset)
		{
			builder.AddOffset(22, targetWeaponExhibitEntitiesOffset.Value, 0);
		}

		// Token: 0x06030C6C RID: 199788 RVA: 0x0069FF6C File Offset: 0x0069E16C
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030C6D RID: 199789 RVA: 0x0069FFA3 File Offset: 0x0069E1A3
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C6E RID: 199790 RVA: 0x0069FFBD File Offset: 0x0069E1BD
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C6F RID: 199791 RVA: 0x0069FFDB File Offset: 0x0069E1DB
		public static VectorOffset CreateTargetWeaponExhibitEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030C70 RID: 199792 RVA: 0x0069FFF4 File Offset: 0x0069E1F4
		public static void StartTargetWeaponExhibitEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030C71 RID: 199793 RVA: 0x0069FFFF File Offset: 0x0069E1FF
		public static void AddBlockAutoOpenUiAfterDungeon(FlatBufferBuilder builder, bool blockAutoOpenUiAfterDungeon)
		{
			builder.AddBool(23, blockAutoOpenUiAfterDungeon, false);
		}

		// Token: 0x06030C72 RID: 199794 RVA: 0x006A000B File Offset: 0x0069E20B
		public static void AddGuessJokerLevel(FlatBufferBuilder builder, int guessJokerLevel)
		{
			builder.AddInt(24, guessJokerLevel, 0);
		}

		// Token: 0x06030C73 RID: 199795 RVA: 0x006A0017 File Offset: 0x0069E217
		public static void AddPictureCaptionConfig(FlatBufferBuilder builder, Offset<IPictureCaptionConfig> pictureCaptionConfigOffset)
		{
			builder.AddOffset(25, pictureCaptionConfigOffset.Value, 0);
		}

		// Token: 0x06030C74 RID: 199796 RVA: 0x006A0028 File Offset: 0x0069E228
		public static void AddTetrisBoardGameEntity(FlatBufferBuilder builder, int tetrisBoardGameEntity)
		{
			builder.AddInt(26, tetrisBoardGameEntity, 0);
		}

		// Token: 0x06030C75 RID: 199797 RVA: 0x006A0034 File Offset: 0x0069E234
		public static void AddVillageInfrBuildStageType(FlatBufferBuilder builder, TVillageInfrBuildType villageInfrBuildStageType)
		{
			builder.AddByte(27, (byte)villageInfrBuildStageType, 0);
		}

		// Token: 0x06030C76 RID: 199798 RVA: 0x006A0040 File Offset: 0x0069E240
		public static void AddVillageInfrBuildStage(FlatBufferBuilder builder, int villageInfrBuildStageOffset)
		{
			builder.AddOffset(28, villageInfrBuildStageOffset, 0);
		}

		// Token: 0x06030C77 RID: 199799 RVA: 0x006A004C File Offset: 0x0069E24C
		public static void AddVillageInfrDeliveryUiCamera(FlatBufferBuilder builder, StringOffset villageInfrDeliveryUiCameraOffset)
		{
			builder.AddOffset(29, villageInfrDeliveryUiCameraOffset.Value, 0);
		}

		// Token: 0x06030C78 RID: 199800 RVA: 0x006A005D File Offset: 0x0069E25D
		public static void AddQuestBranchConfig(FlatBufferBuilder builder, Offset<IQuestBranchConfig> questBranchConfigOffset)
		{
			builder.AddOffset(30, questBranchConfigOffset.Value, 0);
		}

		// Token: 0x06030C79 RID: 199801 RVA: 0x006A006E File Offset: 0x0069E26E
		public static void AddWriteLetterConfig(FlatBufferBuilder builder, Offset<IWriteLetterConfig> writeLetterConfigOffset)
		{
			builder.AddOffset(31, writeLetterConfigOffset.Value, 0);
		}

		// Token: 0x06030C7A RID: 199802 RVA: 0x006A007F File Offset: 0x0069E27F
		public static void AddDollGrabShowcaseEntityId(FlatBufferBuilder builder, int dollGrabShowcaseEntityId)
		{
			builder.AddInt(32, dollGrabShowcaseEntityId, 0);
		}

		// Token: 0x06030C7B RID: 199803 RVA: 0x006A008B File Offset: 0x0069E28B
		public static void AddMechascoutMindSpaceTextKeys(FlatBufferBuilder builder, VectorOffset mechascoutMindSpaceTextKeysOffset)
		{
			builder.AddOffset(33, mechascoutMindSpaceTextKeysOffset.Value, 0);
		}

		// Token: 0x06030C7C RID: 199804 RVA: 0x006A009C File Offset: 0x0069E29C
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030C7D RID: 199805 RVA: 0x006A00DC File Offset: 0x0069E2DC
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C7E RID: 199806 RVA: 0x006A00F6 File Offset: 0x0069E2F6
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030C7F RID: 199807 RVA: 0x006A0114 File Offset: 0x0069E314
		public static VectorOffset CreateMechascoutMindSpaceTextKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030C80 RID: 199808 RVA: 0x006A012D File Offset: 0x0069E32D
		public static void StartMechascoutMindSpaceTextKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030C81 RID: 199809 RVA: 0x006A0138 File Offset: 0x0069E338
		public static void AddDeliverItemProbeCollectiblesConfig(FlatBufferBuilder builder, Offset<IDeliverItemProbeCollectiblesConfig> deliverItemProbeCollectiblesConfigOffset)
		{
			builder.AddOffset(34, deliverItemProbeCollectiblesConfigOffset.Value, 0);
		}

		// Token: 0x06030C82 RID: 199810 RVA: 0x006A0149 File Offset: 0x0069E349
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(35, nullMask, 0);
		}

		// Token: 0x06030C83 RID: 199811 RVA: 0x006A0155 File Offset: 0x0069E355
		public static Offset<IOpenSystemBoard> EndIOpenSystemBoard(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoard>(builder.EndTable());
		}

		// Token: 0x06030C84 RID: 199812 RVA: 0x006A0164 File Offset: 0x0069E364
		public IOpenSystemBoardT UnPack()
		{
			IOpenSystemBoardT openSystemBoardT = new IOpenSystemBoardT();
			this.UnPackTo(openSystemBoardT);
			return openSystemBoardT;
		}

		// Token: 0x06030C85 RID: 199813 RVA: 0x006A0180 File Offset: 0x0069E380
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

		// Token: 0x06030C86 RID: 199814 RVA: 0x006A0754 File Offset: 0x0069E954
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

		// Token: 0x0401154B RID: 70987
		private Table __p;
	}
}
