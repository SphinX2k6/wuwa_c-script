using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485A RID: 18522
	public class IEditorConfigT
	{
		// Token: 0x17008537 RID: 34103
		// (get) Token: 0x0601CB64 RID: 117604 RVA: 0x0040F651 File Offset: 0x0040D851
		// (set) Token: 0x0601CB65 RID: 117605 RVA: 0x0040F659 File Offset: 0x0040D859
		public string Version { get; set; }

		// Token: 0x17008538 RID: 34104
		// (get) Token: 0x0601CB66 RID: 117606 RVA: 0x0040F662 File Offset: 0x0040D862
		// (set) Token: 0x0601CB67 RID: 117607 RVA: 0x0040F66A File Offset: 0x0040D86A
		public bool ShowId { get; set; }

		// Token: 0x17008539 RID: 34105
		// (get) Token: 0x0601CB68 RID: 117608 RVA: 0x0040F673 File Offset: 0x0040D873
		// (set) Token: 0x0601CB69 RID: 117609 RVA: 0x0040F67B File Offset: 0x0040D87B
		public bool ShowFlowEditorError { get; set; }

		// Token: 0x1700853A RID: 34106
		// (get) Token: 0x0601CB6A RID: 117610 RVA: 0x0040F684 File Offset: 0x0040D884
		// (set) Token: 0x0601CB6B RID: 117611 RVA: 0x0040F68C File Offset: 0x0040D88C
		public IFlowStateIndexT LastPlayFlow { get; set; }

		// Token: 0x1700853B RID: 34107
		// (get) Token: 0x0601CB6C RID: 117612 RVA: 0x0040F695 File Offset: 0x0040D895
		// (set) Token: 0x0601CB6D RID: 117613 RVA: 0x0040F69D File Offset: 0x0040D89D
		public string CsvName { get; set; }

		// Token: 0x1700853C RID: 34108
		// (get) Token: 0x0601CB6E RID: 117614 RVA: 0x0040F6A6 File Offset: 0x0040D8A6
		// (set) Token: 0x0601CB6F RID: 117615 RVA: 0x0040F6AE File Offset: 0x0040D8AE
		public List<int> RecentLevels { get; set; }

		// Token: 0x1700853D RID: 34109
		// (get) Token: 0x0601CB70 RID: 117616 RVA: 0x0040F6B7 File Offset: 0x0040D8B7
		// (set) Token: 0x0601CB71 RID: 117617 RVA: 0x0040F6BF File Offset: 0x0040D8BF
		public List<int> RecentSubWpMaps { get; set; }

		// Token: 0x1700853E RID: 34110
		// (get) Token: 0x0601CB72 RID: 117618 RVA: 0x0040F6C8 File Offset: 0x0040D8C8
		// (set) Token: 0x0601CB73 RID: 117619 RVA: 0x0040F6D0 File Offset: 0x0040D8D0
		public bool EnableRecentSelectRecord { get; set; }

		// Token: 0x1700853F RID: 34111
		// (get) Token: 0x0601CB74 RID: 117620 RVA: 0x0040F6D9 File Offset: 0x0040D8D9
		// (set) Token: 0x0601CB75 RID: 117621 RVA: 0x0040F6E1 File Offset: 0x0040D8E1
		public EMaximumDisplayCountInSelector MaximumDisplayCountInSelector { get; set; }

		// Token: 0x17008540 RID: 34112
		// (get) Token: 0x0601CB76 RID: 117622 RVA: 0x0040F6EA File Offset: 0x0040D8EA
		// (set) Token: 0x0601CB77 RID: 117623 RVA: 0x0040F6F2 File Offset: 0x0040D8F2
		public ERecentSelectRecordMode RecentSelectRecordMode { get; set; }

		// Token: 0x17008541 RID: 34113
		// (get) Token: 0x0601CB78 RID: 117624 RVA: 0x0040F6FB File Offset: 0x0040D8FB
		// (set) Token: 0x0601CB79 RID: 117625 RVA: 0x0040F703 File Offset: 0x0040D903
		public bool EnableAutoUpdateFile { get; set; }

		// Token: 0x17008542 RID: 34114
		// (get) Token: 0x0601CB7A RID: 117626 RVA: 0x0040F70C File Offset: 0x0040D90C
		// (set) Token: 0x0601CB7B RID: 117627 RVA: 0x0040F714 File Offset: 0x0040D914
		public bool IsTransientEntityModeDisable { get; set; }

		// Token: 0x17008543 RID: 34115
		// (get) Token: 0x0601CB7C RID: 117628 RVA: 0x0040F71D File Offset: 0x0040D91D
		// (set) Token: 0x0601CB7D RID: 117629 RVA: 0x0040F725 File Offset: 0x0040D925
		public bool IsAllowSubmitNotOriginFile { get; set; }

		// Token: 0x17008544 RID: 34116
		// (get) Token: 0x0601CB7E RID: 117630 RVA: 0x0040F72E File Offset: 0x0040D92E
		// (set) Token: 0x0601CB7F RID: 117631 RVA: 0x0040F736 File Offset: 0x0040D936
		public bool IsAllowSubmitAllWpActor { get; set; }

		// Token: 0x17008545 RID: 34117
		// (get) Token: 0x0601CB80 RID: 117632 RVA: 0x0040F73F File Offset: 0x0040D93F
		// (set) Token: 0x0601CB81 RID: 117633 RVA: 0x0040F747 File Offset: 0x0040D947
		public ILaunchSettingShowInMainEditorT SettingShowInMainEditor { get; set; }

		// Token: 0x17008546 RID: 34118
		// (get) Token: 0x0601CB82 RID: 117634 RVA: 0x0040F750 File Offset: 0x0040D950
		// (set) Token: 0x0601CB83 RID: 117635 RVA: 0x0040F758 File Offset: 0x0040D958
		public IEditorStartConfigT EditorStartConfig { get; set; }

		// Token: 0x17008547 RID: 34119
		// (get) Token: 0x0601CB84 RID: 117636 RVA: 0x0040F761 File Offset: 0x0040D961
		// (set) Token: 0x0601CB85 RID: 117637 RVA: 0x0040F769 File Offset: 0x0040D969
		public IEditorIndentationDisplaySettingT IndentationDisplaySetting { get; set; }

		// Token: 0x17008548 RID: 34120
		// (get) Token: 0x0601CB86 RID: 117638 RVA: 0x0040F772 File Offset: 0x0040D972
		// (set) Token: 0x0601CB87 RID: 117639 RVA: 0x0040F77A File Offset: 0x0040D97A
		public bool IsEnableBottomAoiCheck { get; set; }

		// Token: 0x17008549 RID: 34121
		// (get) Token: 0x0601CB88 RID: 117640 RVA: 0x0040F783 File Offset: 0x0040D983
		// (set) Token: 0x0601CB89 RID: 117641 RVA: 0x0040F78B File Offset: 0x0040D98B
		public bool IsLimitFloatBoxWidth { get; set; }

		// Token: 0x1700854A RID: 34122
		// (get) Token: 0x0601CB8A RID: 117642 RVA: 0x0040F794 File Offset: 0x0040D994
		// (set) Token: 0x0601CB8B RID: 117643 RVA: 0x0040F79C File Offset: 0x0040D99C
		public bool IsEnableAutoSaveRes { get; set; }

		// Token: 0x1700854B RID: 34123
		// (get) Token: 0x0601CB8C RID: 117644 RVA: 0x0040F7A5 File Offset: 0x0040D9A5
		// (set) Token: 0x0601CB8D RID: 117645 RVA: 0x0040F7AD File Offset: 0x0040D9AD
		public bool IsAskWhenAutoSaveError { get; set; }

		// Token: 0x1700854C RID: 34124
		// (get) Token: 0x0601CB8E RID: 117646 RVA: 0x0040F7B6 File Offset: 0x0040D9B6
		// (set) Token: 0x0601CB8F RID: 117647 RVA: 0x0040F7BE File Offset: 0x0040D9BE
		public bool IsLoadActorWhenJumpEntity { get; set; }

		// Token: 0x1700854D RID: 34125
		// (get) Token: 0x0601CB90 RID: 117648 RVA: 0x0040F7C7 File Offset: 0x0040D9C7
		// (set) Token: 0x0601CB91 RID: 117649 RVA: 0x0040F7CF File Offset: 0x0040D9CF
		public EEntityActorLoadMode EntityActorLoadMode { get; set; }

		// Token: 0x1700854E RID: 34126
		// (get) Token: 0x0601CB92 RID: 117650 RVA: 0x0040F7D8 File Offset: 0x0040D9D8
		// (set) Token: 0x0601CB93 RID: 117651 RVA: 0x0040F7E0 File Offset: 0x0040D9E0
		public bool IsAskWhenLoadActor { get; set; }

		// Token: 0x1700854F RID: 34127
		// (get) Token: 0x0601CB94 RID: 117652 RVA: 0x0040F7E9 File Offset: 0x0040D9E9
		// (set) Token: 0x0601CB95 RID: 117653 RVA: 0x0040F7F1 File Offset: 0x0040D9F1
		public int ActorLoadCellSize { get; set; }

		// Token: 0x17008550 RID: 34128
		// (get) Token: 0x0601CB96 RID: 117654 RVA: 0x0040F7FA File Offset: 0x0040D9FA
		// (set) Token: 0x0601CB97 RID: 117655 RVA: 0x0040F802 File Offset: 0x0040DA02
		public int ParentChildAndActorDepth { get; set; }

		// Token: 0x17008551 RID: 34129
		// (get) Token: 0x0601CB98 RID: 117656 RVA: 0x0040F80B File Offset: 0x0040DA0B
		// (set) Token: 0x0601CB99 RID: 117657 RVA: 0x0040F813 File Offset: 0x0040DA13
		public int ParentChildAndActorLoadedActorTypes { get; set; }

		// Token: 0x17008552 RID: 34130
		// (get) Token: 0x0601CB9A RID: 117658 RVA: 0x0040F81C File Offset: 0x0040DA1C
		// (set) Token: 0x0601CB9B RID: 117659 RVA: 0x0040F824 File Offset: 0x0040DA24
		public int ParentChildAndActorExcludeFolders { get; set; }

		// Token: 0x17008553 RID: 34131
		// (get) Token: 0x0601CB9C RID: 117660 RVA: 0x0040F82D File Offset: 0x0040DA2D
		// (set) Token: 0x0601CB9D RID: 117661 RVA: 0x0040F835 File Offset: 0x0040DA35
		public EActorDeleteMode ActorDeleteMode { get; set; }

		// Token: 0x17008554 RID: 34132
		// (get) Token: 0x0601CB9E RID: 117662 RVA: 0x0040F83E File Offset: 0x0040DA3E
		// (set) Token: 0x0601CB9F RID: 117663 RVA: 0x0040F846 File Offset: 0x0040DA46
		public bool IsAskWhenOpenExcel { get; set; }

		// Token: 0x17008555 RID: 34133
		// (get) Token: 0x0601CBA0 RID: 117664 RVA: 0x0040F84F File Offset: 0x0040DA4F
		// (set) Token: 0x0601CBA1 RID: 117665 RVA: 0x0040F857 File Offset: 0x0040DA57
		public List<Record_String_BooleanT> SilentRunTestConfig { get; set; }

		// Token: 0x17008556 RID: 34134
		// (get) Token: 0x0601CBA2 RID: 117666 RVA: 0x0040F860 File Offset: 0x0040DA60
		// (set) Token: 0x0601CBA3 RID: 117667 RVA: 0x0040F868 File Offset: 0x0040DA68
		public List<Record_String_BooleanT> AutoRunTestConfig { get; set; }

		// Token: 0x17008557 RID: 34135
		// (get) Token: 0x0601CBA4 RID: 117668 RVA: 0x0040F871 File Offset: 0x0040DA71
		// (set) Token: 0x0601CBA5 RID: 117669 RVA: 0x0040F879 File Offset: 0x0040DA79
		public bool IsDebugTest { get; set; }

		// Token: 0x17008558 RID: 34136
		// (get) Token: 0x0601CBA6 RID: 117670 RVA: 0x0040F882 File Offset: 0x0040DA82
		// (set) Token: 0x0601CBA7 RID: 117671 RVA: 0x0040F88A File Offset: 0x0040DA8A
		public EActionDisabledType ActionDisabledType { get; set; }

		// Token: 0x17008559 RID: 34137
		// (get) Token: 0x0601CBA8 RID: 117672 RVA: 0x0040F893 File Offset: 0x0040DA93
		// (set) Token: 0x0601CBA9 RID: 117673 RVA: 0x0040F89B File Offset: 0x0040DA9B
		public ETreeNodeDisabledType TreeNodeDisabledType { get; set; }

		// Token: 0x1700855A RID: 34138
		// (get) Token: 0x0601CBAA RID: 117674 RVA: 0x0040F8A4 File Offset: 0x0040DAA4
		// (set) Token: 0x0601CBAB RID: 117675 RVA: 0x0040F8AC File Offset: 0x0040DAAC
		public bool ShowClipboardTipsInStatusBar { get; set; }

		// Token: 0x1700855B RID: 34139
		// (get) Token: 0x0601CBAC RID: 117676 RVA: 0x0040F8B5 File Offset: 0x0040DAB5
		// (set) Token: 0x0601CBAD RID: 117677 RVA: 0x0040F8BD File Offset: 0x0040DABD
		public bool IsAllowDragDropArray { get; set; }

		// Token: 0x1700855C RID: 34140
		// (get) Token: 0x0601CBAE RID: 117678 RVA: 0x0040F8C6 File Offset: 0x0040DAC6
		// (set) Token: 0x0601CBAF RID: 117679 RVA: 0x0040F8CE File Offset: 0x0040DACE
		public EActionHelpClickMode ActionHelpClickMode { get; set; }

		// Token: 0x1700855D RID: 34141
		// (get) Token: 0x0601CBB0 RID: 117680 RVA: 0x0040F8D7 File Offset: 0x0040DAD7
		// (set) Token: 0x0601CBB1 RID: 117681 RVA: 0x0040F8DF File Offset: 0x0040DADF
		public string AkiBasePath { get; set; }

		// Token: 0x1700855E RID: 34142
		// (get) Token: 0x0601CBB2 RID: 117682 RVA: 0x0040F8E8 File Offset: 0x0040DAE8
		// (set) Token: 0x0601CBB3 RID: 117683 RVA: 0x0040F8F0 File Offset: 0x0040DAF0
		public string ExternalJsonEditor { get; set; }

		// Token: 0x0601CBB4 RID: 117684 RVA: 0x0040F8FC File Offset: 0x0040DAFC
		public IEditorConfigT()
		{
			this.Version = null;
			this.ShowId = false;
			this.ShowFlowEditorError = false;
			this.LastPlayFlow = null;
			this.CsvName = null;
			this.RecentLevels = null;
			this.RecentSubWpMaps = null;
			this.EnableRecentSelectRecord = false;
			this.MaximumDisplayCountInSelector = EMaximumDisplayCountInSelector.None;
			this.RecentSelectRecordMode = ERecentSelectRecordMode.SortByCount;
			this.EnableAutoUpdateFile = false;
			this.IsTransientEntityModeDisable = false;
			this.IsAllowSubmitNotOriginFile = false;
			this.IsAllowSubmitAllWpActor = false;
			this.SettingShowInMainEditor = null;
			this.EditorStartConfig = null;
			this.IndentationDisplaySetting = null;
			this.IsEnableBottomAoiCheck = false;
			this.IsLimitFloatBoxWidth = false;
			this.IsEnableAutoSaveRes = false;
			this.IsAskWhenAutoSaveError = false;
			this.IsLoadActorWhenJumpEntity = false;
			this.EntityActorLoadMode = EEntityActorLoadMode.Self;
			this.IsAskWhenLoadActor = false;
			this.ActorLoadCellSize = 0;
			this.ParentChildAndActorDepth = 0;
			this.ParentChildAndActorLoadedActorTypes = 0;
			this.ParentChildAndActorExcludeFolders = 0;
			this.ActorDeleteMode = EActorDeleteMode.AskUser;
			this.IsAskWhenOpenExcel = false;
			this.SilentRunTestConfig = null;
			this.AutoRunTestConfig = null;
			this.IsDebugTest = false;
			this.ActionDisabledType = EActionDisabledType.LocalDisabled;
			this.TreeNodeDisabledType = ETreeNodeDisabledType.LocalDisabled;
			this.ShowClipboardTipsInStatusBar = false;
			this.IsAllowDragDropArray = false;
			this.ActionHelpClickMode = EActionHelpClickMode.OpenDetailByClick;
			this.AkiBasePath = null;
			this.ExternalJsonEditor = null;
		}
	}
}
