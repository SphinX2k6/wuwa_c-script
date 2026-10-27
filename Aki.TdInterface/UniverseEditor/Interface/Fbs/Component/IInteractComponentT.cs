using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005441 RID: 21569
	public class IInteractComponentT
	{
		// Token: 0x17009EBC RID: 40636
		// (get) Token: 0x06023763 RID: 145251 RVA: 0x004E8729 File Offset: 0x004E6929
		// (set) Token: 0x06023764 RID: 145252 RVA: 0x004E8731 File Offset: 0x004E6931
		public bool Disabled { get; set; }

		// Token: 0x17009EBD RID: 40637
		// (get) Token: 0x06023765 RID: 145253 RVA: 0x004E873A File Offset: 0x004E693A
		// (set) Token: 0x06023766 RID: 145254 RVA: 0x004E8742 File Offset: 0x004E6942
		public List<int> QuestIds { get; set; }

		// Token: 0x17009EBE RID: 40638
		// (get) Token: 0x06023767 RID: 145255 RVA: 0x004E874B File Offset: 0x004E694B
		// (set) Token: 0x06023768 RID: 145256 RVA: 0x004E8753 File Offset: 0x004E6953
		public float Range { get; set; }

		// Token: 0x17009EBF RID: 40639
		// (get) Token: 0x06023769 RID: 145257 RVA: 0x004E875C File Offset: 0x004E695C
		// (set) Token: 0x0602376A RID: 145258 RVA: 0x004E8764 File Offset: 0x004E6964
		public float ExitRange { get; set; }

		// Token: 0x17009EC0 RID: 40640
		// (get) Token: 0x0602376B RID: 145259 RVA: 0x004E876D File Offset: 0x004E696D
		// (set) Token: 0x0602376C RID: 145260 RVA: 0x004E8775 File Offset: 0x004E6975
		public float ForbiddenRange { get; set; }

		// Token: 0x17009EC1 RID: 40641
		// (get) Token: 0x0602376D RID: 145261 RVA: 0x004E877E File Offset: 0x004E697E
		// (set) Token: 0x0602376E RID: 145262 RVA: 0x004E8786 File Offset: 0x004E6986
		public IInteractScreenDetectShapeCircleT ScreenDetectLimit { get; set; }

		// Token: 0x17009EC2 RID: 40642
		// (get) Token: 0x0602376F RID: 145263 RVA: 0x004E878F File Offset: 0x004E698F
		// (set) Token: 0x06023770 RID: 145264 RVA: 0x004E8797 File Offset: 0x004E6997
		public List<IRangeByTagT> RangesByTags { get; set; }

		// Token: 0x17009EC3 RID: 40643
		// (get) Token: 0x06023771 RID: 145265 RVA: 0x004E87A0 File Offset: 0x004E69A0
		// (set) Token: 0x06023772 RID: 145266 RVA: 0x004E87A8 File Offset: 0x004E69A8
		public EDoInteract DoIntactType { get; set; }

		// Token: 0x17009EC4 RID: 40644
		// (get) Token: 0x06023773 RID: 145267 RVA: 0x004E87B1 File Offset: 0x004E69B1
		// (set) Token: 0x06023774 RID: 145268 RVA: 0x004E87B9 File Offset: 0x004E69B9
		public IInteractSectorRangeT SectorRange { get; set; }

		// Token: 0x17009EC5 RID: 40645
		// (get) Token: 0x06023775 RID: 145269 RVA: 0x004E87C2 File Offset: 0x004E69C2
		// (set) Token: 0x06023776 RID: 145270 RVA: 0x004E87CA File Offset: 0x004E69CA
		public TInteractPlayerDiractionOptionUnion SectorRangeFromPlayerToEntity { get; set; }

		// Token: 0x17009EC6 RID: 40646
		// (get) Token: 0x06023777 RID: 145271 RVA: 0x004E87D3 File Offset: 0x004E69D3
		// (set) Token: 0x06023778 RID: 145272 RVA: 0x004E87DB File Offset: 0x004E69DB
		public List<IInteractOptionT> Options { get; set; }

		// Token: 0x17009EC7 RID: 40647
		// (get) Token: 0x06023779 RID: 145273 RVA: 0x004E87E4 File Offset: 0x004E69E4
		// (set) Token: 0x0602377A RID: 145274 RVA: 0x004E87EC File Offset: 0x004E69EC
		public IRandomInteractT RandomInteract { get; set; }

		// Token: 0x17009EC8 RID: 40648
		// (get) Token: 0x0602377B RID: 145275 RVA: 0x004E87F5 File Offset: 0x004E69F5
		// (set) Token: 0x0602377C RID: 145276 RVA: 0x004E87FD File Offset: 0x004E69FD
		public EInteractDefaultIcon InteractDefaultIcon { get; set; }

		// Token: 0x17009EC9 RID: 40649
		// (get) Token: 0x0602377D RID: 145277 RVA: 0x004E8806 File Offset: 0x004E6A06
		// (set) Token: 0x0602377E RID: 145278 RVA: 0x004E880E File Offset: 0x004E6A0E
		public EInteractIcon InteractIcon { get; set; }

		// Token: 0x17009ECA RID: 40650
		// (get) Token: 0x0602377F RID: 145279 RVA: 0x004E8817 File Offset: 0x004E6A17
		// (set) Token: 0x06023780 RID: 145280 RVA: 0x004E881F File Offset: 0x004E6A1F
		public EInteractTurnAround TurnAroundType { get; set; }

		// Token: 0x17009ECB RID: 40651
		// (get) Token: 0x06023781 RID: 145281 RVA: 0x004E8828 File Offset: 0x004E6A28
		// (set) Token: 0x06023782 RID: 145282 RVA: 0x004E8830 File Offset: 0x004E6A30
		public bool IsWaitForTurnAroundComplete { get; set; }

		// Token: 0x17009ECC RID: 40652
		// (get) Token: 0x06023783 RID: 145283 RVA: 0x004E8839 File Offset: 0x004E6A39
		// (set) Token: 0x06023784 RID: 145284 RVA: 0x004E8841 File Offset: 0x004E6A41
		public bool IsWaitForInteractComplete { get; set; }

		// Token: 0x17009ECD RID: 40653
		// (get) Token: 0x06023785 RID: 145285 RVA: 0x004E884A File Offset: 0x004E6A4A
		// (set) Token: 0x06023786 RID: 145286 RVA: 0x004E8852 File Offset: 0x004E6A52
		public IPlayFlowT PreFlow { get; set; }

		// Token: 0x17009ECE RID: 40654
		// (get) Token: 0x06023787 RID: 145287 RVA: 0x004E885B File Offset: 0x004E6A5B
		// (set) Token: 0x06023788 RID: 145288 RVA: 0x004E8863 File Offset: 0x004E6A63
		public string TidContent { get; set; }

		// Token: 0x17009ECF RID: 40655
		// (get) Token: 0x06023789 RID: 145289 RVA: 0x004E886C File Offset: 0x004E6A6C
		// (set) Token: 0x0602378A RID: 145290 RVA: 0x004E8874 File Offset: 0x004E6A74
		public IVectorInfoT InteractPointOffset { get; set; }

		// Token: 0x17009ED0 RID: 40656
		// (get) Token: 0x0602378B RID: 145291 RVA: 0x004E887D File Offset: 0x004E6A7D
		// (set) Token: 0x0602378C RID: 145292 RVA: 0x004E8885 File Offset: 0x004E6A85
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17009ED1 RID: 40657
		// (get) Token: 0x0602378D RID: 145293 RVA: 0x004E888E File Offset: 0x004E6A8E
		// (set) Token: 0x0602378E RID: 145294 RVA: 0x004E8896 File Offset: 0x004E6A96
		public IFishingPointAdditionalInfoT InteractAdditionalInfo { get; set; }

		// Token: 0x17009ED2 RID: 40658
		// (get) Token: 0x0602378F RID: 145295 RVA: 0x004E889F File Offset: 0x004E6A9F
		// (set) Token: 0x06023790 RID: 145296 RVA: 0x004E88A7 File Offset: 0x004E6AA7
		public IInteractPointIconConfigT PointIconConfig { get; set; }

		// Token: 0x17009ED3 RID: 40659
		// (get) Token: 0x06023791 RID: 145297 RVA: 0x004E88B0 File Offset: 0x004E6AB0
		// (set) Token: 0x06023792 RID: 145298 RVA: 0x004E88B8 File Offset: 0x004E6AB8
		public IInteractCameraOffsetConfigT InteractCameraOffsetConfig { get; set; }

		// Token: 0x17009ED4 RID: 40660
		// (get) Token: 0x06023793 RID: 145299 RVA: 0x004E88C1 File Offset: 0x004E6AC1
		// (set) Token: 0x06023794 RID: 145300 RVA: 0x004E88C9 File Offset: 0x004E6AC9
		public TInteractStyleUnion InteractStyleType { get; set; }

		// Token: 0x17009ED5 RID: 40661
		// (get) Token: 0x06023795 RID: 145301 RVA: 0x004E88D2 File Offset: 0x004E6AD2
		// (set) Token: 0x06023796 RID: 145302 RVA: 0x004E88DA File Offset: 0x004E6ADA
		public EInterruptMontageType InterruptMontageType { get; set; }

		// Token: 0x17009ED6 RID: 40662
		// (get) Token: 0x06023797 RID: 145303 RVA: 0x004E88E3 File Offset: 0x004E6AE3
		// (set) Token: 0x06023798 RID: 145304 RVA: 0x004E88EB File Offset: 0x004E6AEB
		public bool NotInterruptPlotModeLevelD { get; set; }

		// Token: 0x17009ED7 RID: 40663
		// (get) Token: 0x06023799 RID: 145305 RVA: 0x004E88F4 File Offset: 0x004E6AF4
		// (set) Token: 0x0602379A RID: 145306 RVA: 0x004E88FC File Offset: 0x004E6AFC
		public ushort NullMask { get; set; }

		// Token: 0x0602379B RID: 145307 RVA: 0x004E8908 File Offset: 0x004E6B08
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
