using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C37 RID: 27703
	public class IOpenSystemBoardT
	{
		// Token: 0x1700CE3C RID: 52796
		// (get) Token: 0x06030C87 RID: 199815 RVA: 0x006A0B23 File Offset: 0x0069ED23
		// (set) Token: 0x06030C88 RID: 199816 RVA: 0x006A0B2B File Offset: 0x0069ED2B
		public ESystemType SystemType { get; set; }

		// Token: 0x1700CE3D RID: 52797
		// (get) Token: 0x06030C89 RID: 199817 RVA: 0x006A0B34 File Offset: 0x0069ED34
		// (set) Token: 0x06030C8A RID: 199818 RVA: 0x006A0B3C File Offset: 0x0069ED3C
		public int BoardId { get; set; }

		// Token: 0x1700CE3E RID: 52798
		// (get) Token: 0x06030C8B RID: 199819 RVA: 0x006A0B45 File Offset: 0x0069ED45
		// (set) Token: 0x06030C8C RID: 199820 RVA: 0x006A0B4D File Offset: 0x0069ED4D
		public string ActionMontage { get; set; }

		// Token: 0x1700CE3F RID: 52799
		// (get) Token: 0x06030C8D RID: 199821 RVA: 0x006A0B56 File Offset: 0x0069ED56
		// (set) Token: 0x06030C8E RID: 199822 RVA: 0x006A0B5E File Offset: 0x0069ED5E
		public List<TVarRefUnion> InputVars { get; set; }

		// Token: 0x1700CE40 RID: 52800
		// (get) Token: 0x06030C8F RID: 199823 RVA: 0x006A0B67 File Offset: 0x0069ED67
		// (set) Token: 0x06030C90 RID: 199824 RVA: 0x006A0B6F File Offset: 0x0069ED6F
		public string UiCameraName { get; set; }

		// Token: 0x1700CE41 RID: 52801
		// (get) Token: 0x06030C91 RID: 199825 RVA: 0x006A0B78 File Offset: 0x0069ED78
		// (set) Token: 0x06030C92 RID: 199826 RVA: 0x006A0B80 File Offset: 0x0069ED80
		public IPhotographConfigT PhotographConfig { get; set; }

		// Token: 0x1700CE42 RID: 52802
		// (get) Token: 0x06030C93 RID: 199827 RVA: 0x006A0B89 File Offset: 0x0069ED89
		// (set) Token: 0x06030C94 RID: 199828 RVA: 0x006A0B91 File Offset: 0x0069ED91
		public IInformationViewConfigT InformationViewConfig { get; set; }

		// Token: 0x1700CE43 RID: 52803
		// (get) Token: 0x06030C95 RID: 199829 RVA: 0x006A0B9A File Offset: 0x0069ED9A
		// (set) Token: 0x06030C96 RID: 199830 RVA: 0x006A0BA2 File Offset: 0x0069EDA2
		public int GramophoneId { get; set; }

		// Token: 0x1700CE44 RID: 52804
		// (get) Token: 0x06030C97 RID: 199831 RVA: 0x006A0BAB File Offset: 0x0069EDAB
		// (set) Token: 0x06030C98 RID: 199832 RVA: 0x006A0BB3 File Offset: 0x0069EDB3
		public bool SetMapMusic { get; set; }

		// Token: 0x1700CE45 RID: 52805
		// (get) Token: 0x06030C99 RID: 199833 RVA: 0x006A0BBC File Offset: 0x0069EDBC
		// (set) Token: 0x06030C9A RID: 199834 RVA: 0x006A0BC4 File Offset: 0x0069EDC4
		public bool FadeInScreenWhenClose { get; set; }

		// Token: 0x1700CE46 RID: 52806
		// (get) Token: 0x06030C9B RID: 199835 RVA: 0x006A0BCD File Offset: 0x0069EDCD
		// (set) Token: 0x06030C9C RID: 199836 RVA: 0x006A0BD5 File Offset: 0x0069EDD5
		public ESyncOpenSystemBoardFinishTiming SyncOpenSystemBoardFinishTiming { get; set; }

		// Token: 0x1700CE47 RID: 52807
		// (get) Token: 0x06030C9D RID: 199837 RVA: 0x006A0BDE File Offset: 0x0069EDDE
		// (set) Token: 0x06030C9E RID: 199838 RVA: 0x006A0BE6 File Offset: 0x0069EDE6
		public List<int> Seats { get; set; }

		// Token: 0x1700CE48 RID: 52808
		// (get) Token: 0x06030C9F RID: 199839 RVA: 0x006A0BEF File Offset: 0x0069EDEF
		// (set) Token: 0x06030CA0 RID: 199840 RVA: 0x006A0BF7 File Offset: 0x0069EDF7
		public int PlotReviewJumpTipsNodeId { get; set; }

		// Token: 0x1700CE49 RID: 52809
		// (get) Token: 0x06030CA1 RID: 199841 RVA: 0x006A0C00 File Offset: 0x0069EE00
		// (set) Token: 0x06030CA2 RID: 199842 RVA: 0x006A0C08 File Offset: 0x0069EE08
		public bool WaitLoading { get; set; }

		// Token: 0x1700CE4A RID: 52810
		// (get) Token: 0x06030CA3 RID: 199843 RVA: 0x006A0C11 File Offset: 0x0069EE11
		// (set) Token: 0x06030CA4 RID: 199844 RVA: 0x006A0C19 File Offset: 0x0069EE19
		public ITransitionPopupConfigT TransitionPopupConfig { get; set; }

		// Token: 0x1700CE4B RID: 52811
		// (get) Token: 0x06030CA5 RID: 199845 RVA: 0x006A0C22 File Offset: 0x0069EE22
		// (set) Token: 0x06030CA6 RID: 199846 RVA: 0x006A0C2A File Offset: 0x0069EE2A
		public int FightPreparationEntityId { get; set; }

		// Token: 0x1700CE4C RID: 52812
		// (get) Token: 0x06030CA7 RID: 199847 RVA: 0x006A0C33 File Offset: 0x0069EE33
		// (set) Token: 0x06030CA8 RID: 199848 RVA: 0x006A0C3B File Offset: 0x0069EE3B
		public string FightPreparationUiCamera { get; set; }

		// Token: 0x1700CE4D RID: 52813
		// (get) Token: 0x06030CA9 RID: 199849 RVA: 0x006A0C44 File Offset: 0x0069EE44
		// (set) Token: 0x06030CAA RID: 199850 RVA: 0x006A0C4C File Offset: 0x0069EE4C
		public TInfrActivityBuildStageTypeUnion InfrActivityBuildStage { get; set; }

		// Token: 0x1700CE4E RID: 52814
		// (get) Token: 0x06030CAB RID: 199851 RVA: 0x006A0C55 File Offset: 0x0069EE55
		// (set) Token: 0x06030CAC RID: 199852 RVA: 0x006A0C5D File Offset: 0x0069EE5D
		public IMapConfigT MapConfig { get; set; }

		// Token: 0x1700CE4F RID: 52815
		// (get) Token: 0x06030CAD RID: 199853 RVA: 0x006A0C66 File Offset: 0x0069EE66
		// (set) Token: 0x06030CAE RID: 199854 RVA: 0x006A0C6E File Offset: 0x0069EE6E
		public int TargetPhantomExhibitEntity { get; set; }

		// Token: 0x1700CE50 RID: 52816
		// (get) Token: 0x06030CAF RID: 199855 RVA: 0x006A0C77 File Offset: 0x0069EE77
		// (set) Token: 0x06030CB0 RID: 199856 RVA: 0x006A0C7F File Offset: 0x0069EE7F
		public List<int> TargetWeaponExhibitEntities { get; set; }

		// Token: 0x1700CE51 RID: 52817
		// (get) Token: 0x06030CB1 RID: 199857 RVA: 0x006A0C88 File Offset: 0x0069EE88
		// (set) Token: 0x06030CB2 RID: 199858 RVA: 0x006A0C90 File Offset: 0x0069EE90
		public bool BlockAutoOpenUiAfterDungeon { get; set; }

		// Token: 0x1700CE52 RID: 52818
		// (get) Token: 0x06030CB3 RID: 199859 RVA: 0x006A0C99 File Offset: 0x0069EE99
		// (set) Token: 0x06030CB4 RID: 199860 RVA: 0x006A0CA1 File Offset: 0x0069EEA1
		public int GuessJokerLevel { get; set; }

		// Token: 0x1700CE53 RID: 52819
		// (get) Token: 0x06030CB5 RID: 199861 RVA: 0x006A0CAA File Offset: 0x0069EEAA
		// (set) Token: 0x06030CB6 RID: 199862 RVA: 0x006A0CB2 File Offset: 0x0069EEB2
		public IPictureCaptionConfigT PictureCaptionConfig { get; set; }

		// Token: 0x1700CE54 RID: 52820
		// (get) Token: 0x06030CB7 RID: 199863 RVA: 0x006A0CBB File Offset: 0x0069EEBB
		// (set) Token: 0x06030CB8 RID: 199864 RVA: 0x006A0CC3 File Offset: 0x0069EEC3
		public int TetrisBoardGameEntity { get; set; }

		// Token: 0x1700CE55 RID: 52821
		// (get) Token: 0x06030CB9 RID: 199865 RVA: 0x006A0CCC File Offset: 0x0069EECC
		// (set) Token: 0x06030CBA RID: 199866 RVA: 0x006A0CD4 File Offset: 0x0069EED4
		public TVillageInfrBuildTypeUnion VillageInfrBuildStage { get; set; }

		// Token: 0x1700CE56 RID: 52822
		// (get) Token: 0x06030CBB RID: 199867 RVA: 0x006A0CDD File Offset: 0x0069EEDD
		// (set) Token: 0x06030CBC RID: 199868 RVA: 0x006A0CE5 File Offset: 0x0069EEE5
		public string VillageInfrDeliveryUiCamera { get; set; }

		// Token: 0x1700CE57 RID: 52823
		// (get) Token: 0x06030CBD RID: 199869 RVA: 0x006A0CEE File Offset: 0x0069EEEE
		// (set) Token: 0x06030CBE RID: 199870 RVA: 0x006A0CF6 File Offset: 0x0069EEF6
		public IQuestBranchConfigT QuestBranchConfig { get; set; }

		// Token: 0x1700CE58 RID: 52824
		// (get) Token: 0x06030CBF RID: 199871 RVA: 0x006A0CFF File Offset: 0x0069EEFF
		// (set) Token: 0x06030CC0 RID: 199872 RVA: 0x006A0D07 File Offset: 0x0069EF07
		public IWriteLetterConfigT WriteLetterConfig { get; set; }

		// Token: 0x1700CE59 RID: 52825
		// (get) Token: 0x06030CC1 RID: 199873 RVA: 0x006A0D10 File Offset: 0x0069EF10
		// (set) Token: 0x06030CC2 RID: 199874 RVA: 0x006A0D18 File Offset: 0x0069EF18
		public int DollGrabShowcaseEntityId { get; set; }

		// Token: 0x1700CE5A RID: 52826
		// (get) Token: 0x06030CC3 RID: 199875 RVA: 0x006A0D21 File Offset: 0x0069EF21
		// (set) Token: 0x06030CC4 RID: 199876 RVA: 0x006A0D29 File Offset: 0x0069EF29
		public List<string> MechascoutMindSpaceTextKeys { get; set; }

		// Token: 0x1700CE5B RID: 52827
		// (get) Token: 0x06030CC5 RID: 199877 RVA: 0x006A0D32 File Offset: 0x0069EF32
		// (set) Token: 0x06030CC6 RID: 199878 RVA: 0x006A0D3A File Offset: 0x0069EF3A
		public IDeliverItemProbeCollectiblesConfigT DeliverItemProbeCollectiblesConfig { get; set; }

		// Token: 0x1700CE5C RID: 52828
		// (get) Token: 0x06030CC7 RID: 199879 RVA: 0x006A0D43 File Offset: 0x0069EF43
		// (set) Token: 0x06030CC8 RID: 199880 RVA: 0x006A0D4B File Offset: 0x0069EF4B
		public ushort NullMask { get; set; }

		// Token: 0x06030CC9 RID: 199881 RVA: 0x006A0D54 File Offset: 0x0069EF54
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
