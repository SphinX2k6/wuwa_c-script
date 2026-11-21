using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739E RID: 29598
	public class IOpenSystemBoardT
	{
		// Token: 0x1700D957 RID: 55639
		// (get) Token: 0x06033BDF RID: 211935 RVA: 0x006FAF8B File Offset: 0x006F918B
		// (set) Token: 0x06033BE0 RID: 211936 RVA: 0x006FAF93 File Offset: 0x006F9193
		public ESystemType SystemType { get; set; }

		// Token: 0x1700D958 RID: 55640
		// (get) Token: 0x06033BE1 RID: 211937 RVA: 0x006FAF9C File Offset: 0x006F919C
		// (set) Token: 0x06033BE2 RID: 211938 RVA: 0x006FAFA4 File Offset: 0x006F91A4
		public int BoardId { get; set; }

		// Token: 0x1700D959 RID: 55641
		// (get) Token: 0x06033BE3 RID: 211939 RVA: 0x006FAFAD File Offset: 0x006F91AD
		// (set) Token: 0x06033BE4 RID: 211940 RVA: 0x006FAFB5 File Offset: 0x006F91B5
		public string ActionMontage { get; set; }

		// Token: 0x1700D95A RID: 55642
		// (get) Token: 0x06033BE5 RID: 211941 RVA: 0x006FAFBE File Offset: 0x006F91BE
		// (set) Token: 0x06033BE6 RID: 211942 RVA: 0x006FAFC6 File Offset: 0x006F91C6
		public List<TVarRefUnion> InputVars { get; set; }

		// Token: 0x1700D95B RID: 55643
		// (get) Token: 0x06033BE7 RID: 211943 RVA: 0x006FAFCF File Offset: 0x006F91CF
		// (set) Token: 0x06033BE8 RID: 211944 RVA: 0x006FAFD7 File Offset: 0x006F91D7
		public string UiCameraName { get; set; }

		// Token: 0x1700D95C RID: 55644
		// (get) Token: 0x06033BE9 RID: 211945 RVA: 0x006FAFE0 File Offset: 0x006F91E0
		// (set) Token: 0x06033BEA RID: 211946 RVA: 0x006FAFE8 File Offset: 0x006F91E8
		public IPhotographConfigT PhotographConfig { get; set; }

		// Token: 0x1700D95D RID: 55645
		// (get) Token: 0x06033BEB RID: 211947 RVA: 0x006FAFF1 File Offset: 0x006F91F1
		// (set) Token: 0x06033BEC RID: 211948 RVA: 0x006FAFF9 File Offset: 0x006F91F9
		public IInformationViewConfigT InformationViewConfig { get; set; }

		// Token: 0x1700D95E RID: 55646
		// (get) Token: 0x06033BED RID: 211949 RVA: 0x006FB002 File Offset: 0x006F9202
		// (set) Token: 0x06033BEE RID: 211950 RVA: 0x006FB00A File Offset: 0x006F920A
		public int GramophoneId { get; set; }

		// Token: 0x1700D95F RID: 55647
		// (get) Token: 0x06033BEF RID: 211951 RVA: 0x006FB013 File Offset: 0x006F9213
		// (set) Token: 0x06033BF0 RID: 211952 RVA: 0x006FB01B File Offset: 0x006F921B
		public bool SetMapMusic { get; set; }

		// Token: 0x1700D960 RID: 55648
		// (get) Token: 0x06033BF1 RID: 211953 RVA: 0x006FB024 File Offset: 0x006F9224
		// (set) Token: 0x06033BF2 RID: 211954 RVA: 0x006FB02C File Offset: 0x006F922C
		public bool FadeInScreenWhenClose { get; set; }

		// Token: 0x1700D961 RID: 55649
		// (get) Token: 0x06033BF3 RID: 211955 RVA: 0x006FB035 File Offset: 0x006F9235
		// (set) Token: 0x06033BF4 RID: 211956 RVA: 0x006FB03D File Offset: 0x006F923D
		public ESyncOpenSystemBoardFinishTiming SyncOpenSystemBoardFinishTiming { get; set; }

		// Token: 0x1700D962 RID: 55650
		// (get) Token: 0x06033BF5 RID: 211957 RVA: 0x006FB046 File Offset: 0x006F9246
		// (set) Token: 0x06033BF6 RID: 211958 RVA: 0x006FB04E File Offset: 0x006F924E
		public List<int> Seats { get; set; }

		// Token: 0x1700D963 RID: 55651
		// (get) Token: 0x06033BF7 RID: 211959 RVA: 0x006FB057 File Offset: 0x006F9257
		// (set) Token: 0x06033BF8 RID: 211960 RVA: 0x006FB05F File Offset: 0x006F925F
		public int PlotReviewJumpTipsNodeId { get; set; }

		// Token: 0x1700D964 RID: 55652
		// (get) Token: 0x06033BF9 RID: 211961 RVA: 0x006FB068 File Offset: 0x006F9268
		// (set) Token: 0x06033BFA RID: 211962 RVA: 0x006FB070 File Offset: 0x006F9270
		public bool WaitLoading { get; set; }

		// Token: 0x1700D965 RID: 55653
		// (get) Token: 0x06033BFB RID: 211963 RVA: 0x006FB079 File Offset: 0x006F9279
		// (set) Token: 0x06033BFC RID: 211964 RVA: 0x006FB081 File Offset: 0x006F9281
		public ITransitionPopupConfigT TransitionPopupConfig { get; set; }

		// Token: 0x1700D966 RID: 55654
		// (get) Token: 0x06033BFD RID: 211965 RVA: 0x006FB08A File Offset: 0x006F928A
		// (set) Token: 0x06033BFE RID: 211966 RVA: 0x006FB092 File Offset: 0x006F9292
		public int FightPreparationEntityId { get; set; }

		// Token: 0x1700D967 RID: 55655
		// (get) Token: 0x06033BFF RID: 211967 RVA: 0x006FB09B File Offset: 0x006F929B
		// (set) Token: 0x06033C00 RID: 211968 RVA: 0x006FB0A3 File Offset: 0x006F92A3
		public string FightPreparationUiCamera { get; set; }

		// Token: 0x1700D968 RID: 55656
		// (get) Token: 0x06033C01 RID: 211969 RVA: 0x006FB0AC File Offset: 0x006F92AC
		// (set) Token: 0x06033C02 RID: 211970 RVA: 0x006FB0B4 File Offset: 0x006F92B4
		public TInfrActivityBuildStageTypeUnion InfrActivityBuildStage { get; set; }

		// Token: 0x1700D969 RID: 55657
		// (get) Token: 0x06033C03 RID: 211971 RVA: 0x006FB0BD File Offset: 0x006F92BD
		// (set) Token: 0x06033C04 RID: 211972 RVA: 0x006FB0C5 File Offset: 0x006F92C5
		public IMapConfigT MapConfig { get; set; }

		// Token: 0x1700D96A RID: 55658
		// (get) Token: 0x06033C05 RID: 211973 RVA: 0x006FB0CE File Offset: 0x006F92CE
		// (set) Token: 0x06033C06 RID: 211974 RVA: 0x006FB0D6 File Offset: 0x006F92D6
		public int TargetPhantomExhibitEntity { get; set; }

		// Token: 0x1700D96B RID: 55659
		// (get) Token: 0x06033C07 RID: 211975 RVA: 0x006FB0DF File Offset: 0x006F92DF
		// (set) Token: 0x06033C08 RID: 211976 RVA: 0x006FB0E7 File Offset: 0x006F92E7
		public List<int> TargetWeaponExhibitEntities { get; set; }

		// Token: 0x1700D96C RID: 55660
		// (get) Token: 0x06033C09 RID: 211977 RVA: 0x006FB0F0 File Offset: 0x006F92F0
		// (set) Token: 0x06033C0A RID: 211978 RVA: 0x006FB0F8 File Offset: 0x006F92F8
		public bool BlockAutoOpenUiAfterDungeon { get; set; }

		// Token: 0x1700D96D RID: 55661
		// (get) Token: 0x06033C0B RID: 211979 RVA: 0x006FB101 File Offset: 0x006F9301
		// (set) Token: 0x06033C0C RID: 211980 RVA: 0x006FB109 File Offset: 0x006F9309
		public int GuessJokerLevel { get; set; }

		// Token: 0x1700D96E RID: 55662
		// (get) Token: 0x06033C0D RID: 211981 RVA: 0x006FB112 File Offset: 0x006F9312
		// (set) Token: 0x06033C0E RID: 211982 RVA: 0x006FB11A File Offset: 0x006F931A
		public IPictureCaptionConfigT PictureCaptionConfig { get; set; }

		// Token: 0x1700D96F RID: 55663
		// (get) Token: 0x06033C0F RID: 211983 RVA: 0x006FB123 File Offset: 0x006F9323
		// (set) Token: 0x06033C10 RID: 211984 RVA: 0x006FB12B File Offset: 0x006F932B
		public int TetrisBoardGameEntity { get; set; }

		// Token: 0x1700D970 RID: 55664
		// (get) Token: 0x06033C11 RID: 211985 RVA: 0x006FB134 File Offset: 0x006F9334
		// (set) Token: 0x06033C12 RID: 211986 RVA: 0x006FB13C File Offset: 0x006F933C
		public TVillageInfrBuildTypeUnion VillageInfrBuildStage { get; set; }

		// Token: 0x1700D971 RID: 55665
		// (get) Token: 0x06033C13 RID: 211987 RVA: 0x006FB145 File Offset: 0x006F9345
		// (set) Token: 0x06033C14 RID: 211988 RVA: 0x006FB14D File Offset: 0x006F934D
		public string VillageInfrDeliveryUiCamera { get; set; }

		// Token: 0x1700D972 RID: 55666
		// (get) Token: 0x06033C15 RID: 211989 RVA: 0x006FB156 File Offset: 0x006F9356
		// (set) Token: 0x06033C16 RID: 211990 RVA: 0x006FB15E File Offset: 0x006F935E
		public IQuestBranchConfigT QuestBranchConfig { get; set; }

		// Token: 0x1700D973 RID: 55667
		// (get) Token: 0x06033C17 RID: 211991 RVA: 0x006FB167 File Offset: 0x006F9367
		// (set) Token: 0x06033C18 RID: 211992 RVA: 0x006FB16F File Offset: 0x006F936F
		public IWriteLetterConfigT WriteLetterConfig { get; set; }

		// Token: 0x1700D974 RID: 55668
		// (get) Token: 0x06033C19 RID: 211993 RVA: 0x006FB178 File Offset: 0x006F9378
		// (set) Token: 0x06033C1A RID: 211994 RVA: 0x006FB180 File Offset: 0x006F9380
		public int DollGrabShowcaseEntityId { get; set; }

		// Token: 0x1700D975 RID: 55669
		// (get) Token: 0x06033C1B RID: 211995 RVA: 0x006FB189 File Offset: 0x006F9389
		// (set) Token: 0x06033C1C RID: 211996 RVA: 0x006FB191 File Offset: 0x006F9391
		public List<string> MechascoutMindSpaceTextKeys { get; set; }

		// Token: 0x1700D976 RID: 55670
		// (get) Token: 0x06033C1D RID: 211997 RVA: 0x006FB19A File Offset: 0x006F939A
		// (set) Token: 0x06033C1E RID: 211998 RVA: 0x006FB1A2 File Offset: 0x006F93A2
		public IDeliverItemProbeCollectiblesConfigT DeliverItemProbeCollectiblesConfig { get; set; }

		// Token: 0x1700D977 RID: 55671
		// (get) Token: 0x06033C1F RID: 211999 RVA: 0x006FB1AB File Offset: 0x006F93AB
		// (set) Token: 0x06033C20 RID: 212000 RVA: 0x006FB1B3 File Offset: 0x006F93B3
		public ushort NullMask { get; set; }

		// Token: 0x06033C21 RID: 212001 RVA: 0x006FB1BC File Offset: 0x006F93BC
		public IOpenSystemBoardT()
		{
			this.SystemType = ESystemType.Shop;
			this.BoardId = 0;
			this.ActionMontage = null;
			this.InputVars = null;
			this.UiCameraName = null;
			this.PhotographConfig = null;
			this.InformationViewConfig = null;
			this.GramophoneId = 0;
			this.SetMapMusic = false;
			this.FadeInScreenWhenClose = false;
			this.SyncOpenSystemBoardFinishTiming = ESyncOpenSystemBoardFinishTiming.OpenFinished;
			this.Seats = null;
			this.PlotReviewJumpTipsNodeId = 0;
			this.WaitLoading = false;
			this.TransitionPopupConfig = null;
			this.FightPreparationEntityId = 0;
			this.FightPreparationUiCamera = null;
			this.InfrActivityBuildStage = null;
			this.MapConfig = new IMapConfigT();
			this.TargetPhantomExhibitEntity = 0;
			this.TargetWeaponExhibitEntities = null;
			this.BlockAutoOpenUiAfterDungeon = false;
			this.GuessJokerLevel = 0;
			this.PictureCaptionConfig = null;
			this.TetrisBoardGameEntity = 0;
			this.VillageInfrBuildStage = null;
			this.VillageInfrDeliveryUiCamera = null;
			this.QuestBranchConfig = null;
			this.WriteLetterConfig = null;
			this.DollGrabShowcaseEntityId = 0;
			this.MechascoutMindSpaceTextKeys = null;
			this.DeliverItemProbeCollectiblesConfig = null;
			this.NullMask = 0;
		}
	}
}
