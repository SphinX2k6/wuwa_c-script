using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C7 RID: 22983
	public class IInteractComponentT
	{
		// Token: 0x1700A6F6 RID: 42742
		// (get) Token: 0x0602581B RID: 153627 RVA: 0x0052579D File Offset: 0x0052399D
		// (set) Token: 0x0602581C RID: 153628 RVA: 0x005257A5 File Offset: 0x005239A5
		public bool Disabled { get; set; }

		// Token: 0x1700A6F7 RID: 42743
		// (get) Token: 0x0602581D RID: 153629 RVA: 0x005257AE File Offset: 0x005239AE
		// (set) Token: 0x0602581E RID: 153630 RVA: 0x005257B6 File Offset: 0x005239B6
		public List<int> QuestIds { get; set; }

		// Token: 0x1700A6F8 RID: 42744
		// (get) Token: 0x0602581F RID: 153631 RVA: 0x005257BF File Offset: 0x005239BF
		// (set) Token: 0x06025820 RID: 153632 RVA: 0x005257C7 File Offset: 0x005239C7
		public float Range { get; set; }

		// Token: 0x1700A6F9 RID: 42745
		// (get) Token: 0x06025821 RID: 153633 RVA: 0x005257D0 File Offset: 0x005239D0
		// (set) Token: 0x06025822 RID: 153634 RVA: 0x005257D8 File Offset: 0x005239D8
		public float ExitRange { get; set; }

		// Token: 0x1700A6FA RID: 42746
		// (get) Token: 0x06025823 RID: 153635 RVA: 0x005257E1 File Offset: 0x005239E1
		// (set) Token: 0x06025824 RID: 153636 RVA: 0x005257E9 File Offset: 0x005239E9
		public float ForbiddenRange { get; set; }

		// Token: 0x1700A6FB RID: 42747
		// (get) Token: 0x06025825 RID: 153637 RVA: 0x005257F2 File Offset: 0x005239F2
		// (set) Token: 0x06025826 RID: 153638 RVA: 0x005257FA File Offset: 0x005239FA
		public IInteractScreenDetectShapeCircleT ScreenDetectLimit { get; set; }

		// Token: 0x1700A6FC RID: 42748
		// (get) Token: 0x06025827 RID: 153639 RVA: 0x00525803 File Offset: 0x00523A03
		// (set) Token: 0x06025828 RID: 153640 RVA: 0x0052580B File Offset: 0x00523A0B
		public List<IRangeByTagT> RangesByTags { get; set; }

		// Token: 0x1700A6FD RID: 42749
		// (get) Token: 0x06025829 RID: 153641 RVA: 0x00525814 File Offset: 0x00523A14
		// (set) Token: 0x0602582A RID: 153642 RVA: 0x0052581C File Offset: 0x00523A1C
		public EDoInteract DoIntactType { get; set; }

		// Token: 0x1700A6FE RID: 42750
		// (get) Token: 0x0602582B RID: 153643 RVA: 0x00525825 File Offset: 0x00523A25
		// (set) Token: 0x0602582C RID: 153644 RVA: 0x0052582D File Offset: 0x00523A2D
		public IInteractSectorRangeT SectorRange { get; set; }

		// Token: 0x1700A6FF RID: 42751
		// (get) Token: 0x0602582D RID: 153645 RVA: 0x00525836 File Offset: 0x00523A36
		// (set) Token: 0x0602582E RID: 153646 RVA: 0x0052583E File Offset: 0x00523A3E
		public TInteractPlayerDiractionOptionUnion SectorRangeFromPlayerToEntity { get; set; }

		// Token: 0x1700A700 RID: 42752
		// (get) Token: 0x0602582F RID: 153647 RVA: 0x00525847 File Offset: 0x00523A47
		// (set) Token: 0x06025830 RID: 153648 RVA: 0x0052584F File Offset: 0x00523A4F
		public List<IInteractOptionT> Options { get; set; }

		// Token: 0x1700A701 RID: 42753
		// (get) Token: 0x06025831 RID: 153649 RVA: 0x00525858 File Offset: 0x00523A58
		// (set) Token: 0x06025832 RID: 153650 RVA: 0x00525860 File Offset: 0x00523A60
		public IRandomInteractT RandomInteract { get; set; }

		// Token: 0x1700A702 RID: 42754
		// (get) Token: 0x06025833 RID: 153651 RVA: 0x00525869 File Offset: 0x00523A69
		// (set) Token: 0x06025834 RID: 153652 RVA: 0x00525871 File Offset: 0x00523A71
		public EInteractDefaultIcon InteractDefaultIcon { get; set; }

		// Token: 0x1700A703 RID: 42755
		// (get) Token: 0x06025835 RID: 153653 RVA: 0x0052587A File Offset: 0x00523A7A
		// (set) Token: 0x06025836 RID: 153654 RVA: 0x00525882 File Offset: 0x00523A82
		public EInteractIcon InteractIcon { get; set; }

		// Token: 0x1700A704 RID: 42756
		// (get) Token: 0x06025837 RID: 153655 RVA: 0x0052588B File Offset: 0x00523A8B
		// (set) Token: 0x06025838 RID: 153656 RVA: 0x00525893 File Offset: 0x00523A93
		public EInteractTurnAround TurnAroundType { get; set; }

		// Token: 0x1700A705 RID: 42757
		// (get) Token: 0x06025839 RID: 153657 RVA: 0x0052589C File Offset: 0x00523A9C
		// (set) Token: 0x0602583A RID: 153658 RVA: 0x005258A4 File Offset: 0x00523AA4
		public bool IsWaitForTurnAroundComplete { get; set; }

		// Token: 0x1700A706 RID: 42758
		// (get) Token: 0x0602583B RID: 153659 RVA: 0x005258AD File Offset: 0x00523AAD
		// (set) Token: 0x0602583C RID: 153660 RVA: 0x005258B5 File Offset: 0x00523AB5
		public bool IsWaitForInteractComplete { get; set; }

		// Token: 0x1700A707 RID: 42759
		// (get) Token: 0x0602583D RID: 153661 RVA: 0x005258BE File Offset: 0x00523ABE
		// (set) Token: 0x0602583E RID: 153662 RVA: 0x005258C6 File Offset: 0x00523AC6
		public IPlayFlowT PreFlow { get; set; }

		// Token: 0x1700A708 RID: 42760
		// (get) Token: 0x0602583F RID: 153663 RVA: 0x005258CF File Offset: 0x00523ACF
		// (set) Token: 0x06025840 RID: 153664 RVA: 0x005258D7 File Offset: 0x00523AD7
		public string TidContent { get; set; }

		// Token: 0x1700A709 RID: 42761
		// (get) Token: 0x06025841 RID: 153665 RVA: 0x005258E0 File Offset: 0x00523AE0
		// (set) Token: 0x06025842 RID: 153666 RVA: 0x005258E8 File Offset: 0x00523AE8
		public IVectorInfoT InteractPointOffset { get; set; }

		// Token: 0x1700A70A RID: 42762
		// (get) Token: 0x06025843 RID: 153667 RVA: 0x005258F1 File Offset: 0x00523AF1
		// (set) Token: 0x06025844 RID: 153668 RVA: 0x005258F9 File Offset: 0x00523AF9
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700A70B RID: 42763
		// (get) Token: 0x06025845 RID: 153669 RVA: 0x00525902 File Offset: 0x00523B02
		// (set) Token: 0x06025846 RID: 153670 RVA: 0x0052590A File Offset: 0x00523B0A
		public IFishingPointAdditionalInfoT InteractAdditionalInfo { get; set; }

		// Token: 0x1700A70C RID: 42764
		// (get) Token: 0x06025847 RID: 153671 RVA: 0x00525913 File Offset: 0x00523B13
		// (set) Token: 0x06025848 RID: 153672 RVA: 0x0052591B File Offset: 0x00523B1B
		public IInteractPointIconConfigT PointIconConfig { get; set; }

		// Token: 0x1700A70D RID: 42765
		// (get) Token: 0x06025849 RID: 153673 RVA: 0x00525924 File Offset: 0x00523B24
		// (set) Token: 0x0602584A RID: 153674 RVA: 0x0052592C File Offset: 0x00523B2C
		public IInteractCameraOffsetConfigT InteractCameraOffsetConfig { get; set; }

		// Token: 0x1700A70E RID: 42766
		// (get) Token: 0x0602584B RID: 153675 RVA: 0x00525935 File Offset: 0x00523B35
		// (set) Token: 0x0602584C RID: 153676 RVA: 0x0052593D File Offset: 0x00523B3D
		public TInteractStyleUnion InteractStyleType { get; set; }

		// Token: 0x1700A70F RID: 42767
		// (get) Token: 0x0602584D RID: 153677 RVA: 0x00525946 File Offset: 0x00523B46
		// (set) Token: 0x0602584E RID: 153678 RVA: 0x0052594E File Offset: 0x00523B4E
		public EInterruptMontageType InterruptMontageType { get; set; }

		// Token: 0x1700A710 RID: 42768
		// (get) Token: 0x0602584F RID: 153679 RVA: 0x00525957 File Offset: 0x00523B57
		// (set) Token: 0x06025850 RID: 153680 RVA: 0x0052595F File Offset: 0x00523B5F
		public bool NotInterruptPlotModeLevelD { get; set; }

		// Token: 0x1700A711 RID: 42769
		// (get) Token: 0x06025851 RID: 153681 RVA: 0x00525968 File Offset: 0x00523B68
		// (set) Token: 0x06025852 RID: 153682 RVA: 0x00525970 File Offset: 0x00523B70
		public ushort NullMask { get; set; }

		// Token: 0x06025853 RID: 153683 RVA: 0x0052597C File Offset: 0x00523B7C
		public IInteractComponentT()
		{
			this.Disabled = false;
			this.QuestIds = null;
			this.Range = 0f;
			this.ExitRange = 0f;
			this.ForbiddenRange = 0f;
			this.ScreenDetectLimit = null;
			this.RangesByTags = null;
			this.DoIntactType = EDoInteract.Direct;
			this.SectorRange = null;
			this.SectorRangeFromPlayerToEntity = null;
			this.Options = null;
			this.RandomInteract = null;
			this.InteractDefaultIcon = EInteractDefaultIcon.Collect;
			this.InteractIcon = EInteractIcon.Dialog;
			this.TurnAroundType = EInteractTurnAround.FaceEachOther;
			this.IsWaitForTurnAroundComplete = false;
			this.IsWaitForInteractComplete = false;
			this.PreFlow = null;
			this.TidContent = null;
			this.InteractPointOffset = null;
			this.MatchRoleOption = null;
			this.InteractAdditionalInfo = null;
			this.PointIconConfig = null;
			this.InteractCameraOffsetConfig = null;
			this.InteractStyleType = null;
			this.InterruptMontageType = EInterruptMontageType.InterruptAtEnd;
			this.NotInterruptPlotModeLevelD = false;
			this.NullMask = 0;
		}
	}
}
