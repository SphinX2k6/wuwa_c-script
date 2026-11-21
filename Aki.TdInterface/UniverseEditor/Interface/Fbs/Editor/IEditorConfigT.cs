using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC2 RID: 19650
	public class IEditorConfigT
	{
		// Token: 0x17008B85 RID: 35717
		// (get) Token: 0x0601E369 RID: 123753 RVA: 0x0043C0D7 File Offset: 0x0043A2D7
		// (set) Token: 0x0601E36A RID: 123754 RVA: 0x0043C0DF File Offset: 0x0043A2DF
		public string Version { get; set; }

		// Token: 0x17008B86 RID: 35718
		// (get) Token: 0x0601E36B RID: 123755 RVA: 0x0043C0E8 File Offset: 0x0043A2E8
		// (set) Token: 0x0601E36C RID: 123756 RVA: 0x0043C0F0 File Offset: 0x0043A2F0
		public bool ShowId { get; set; }

		// Token: 0x17008B87 RID: 35719
		// (get) Token: 0x0601E36D RID: 123757 RVA: 0x0043C0F9 File Offset: 0x0043A2F9
		// (set) Token: 0x0601E36E RID: 123758 RVA: 0x0043C101 File Offset: 0x0043A301
		public bool ShowFlowEditorError { get; set; }

		// Token: 0x17008B88 RID: 35720
		// (get) Token: 0x0601E36F RID: 123759 RVA: 0x0043C10A File Offset: 0x0043A30A
		// (set) Token: 0x0601E370 RID: 123760 RVA: 0x0043C112 File Offset: 0x0043A312
		public IFlowStateIndexT LastPlayFlow { get; set; }

		// Token: 0x17008B89 RID: 35721
		// (get) Token: 0x0601E371 RID: 123761 RVA: 0x0043C11B File Offset: 0x0043A31B
		// (set) Token: 0x0601E372 RID: 123762 RVA: 0x0043C123 File Offset: 0x0043A323
		public string CsvName { get; set; }

		// Token: 0x17008B8A RID: 35722
		// (get) Token: 0x0601E373 RID: 123763 RVA: 0x0043C12C File Offset: 0x0043A32C
		// (set) Token: 0x0601E374 RID: 123764 RVA: 0x0043C134 File Offset: 0x0043A334
		public List<int> RecentLevels { get; set; }

		// Token: 0x17008B8B RID: 35723
		// (get) Token: 0x0601E375 RID: 123765 RVA: 0x0043C13D File Offset: 0x0043A33D
		// (set) Token: 0x0601E376 RID: 123766 RVA: 0x0043C145 File Offset: 0x0043A345
		public List<int> RecentSubWpMaps { get; set; }

		// Token: 0x17008B8C RID: 35724
		// (get) Token: 0x0601E377 RID: 123767 RVA: 0x0043C14E File Offset: 0x0043A34E
		// (set) Token: 0x0601E378 RID: 123768 RVA: 0x0043C156 File Offset: 0x0043A356
		public bool EnableRecentSelectRecord { get; set; }

		// Token: 0x17008B8D RID: 35725
		// (get) Token: 0x0601E379 RID: 123769 RVA: 0x0043C15F File Offset: 0x0043A35F
		// (set) Token: 0x0601E37A RID: 123770 RVA: 0x0043C167 File Offset: 0x0043A367
		public EMaximumDisplayCountInSelector MaximumDisplayCountInSelector { get; set; }

		// Token: 0x17008B8E RID: 35726
		// (get) Token: 0x0601E37B RID: 123771 RVA: 0x0043C170 File Offset: 0x0043A370
		// (set) Token: 0x0601E37C RID: 123772 RVA: 0x0043C178 File Offset: 0x0043A378
		public ERecentSelectRecordMode RecentSelectRecordMode { get; set; }

		// Token: 0x17008B8F RID: 35727
		// (get) Token: 0x0601E37D RID: 123773 RVA: 0x0043C181 File Offset: 0x0043A381
		// (set) Token: 0x0601E37E RID: 123774 RVA: 0x0043C189 File Offset: 0x0043A389
		public bool EnableAutoUpdateFile { get; set; }

		// Token: 0x17008B90 RID: 35728
		// (get) Token: 0x0601E37F RID: 123775 RVA: 0x0043C192 File Offset: 0x0043A392
		// (set) Token: 0x0601E380 RID: 123776 RVA: 0x0043C19A File Offset: 0x0043A39A
		public bool IsTransientEntityModeDisable { get; set; }

		// Token: 0x17008B91 RID: 35729
		// (get) Token: 0x0601E381 RID: 123777 RVA: 0x0043C1A3 File Offset: 0x0043A3A3
		// (set) Token: 0x0601E382 RID: 123778 RVA: 0x0043C1AB File Offset: 0x0043A3AB
		public bool IsAllowSubmitNotOriginFile { get; set; }

		// Token: 0x17008B92 RID: 35730
		// (get) Token: 0x0601E383 RID: 123779 RVA: 0x0043C1B4 File Offset: 0x0043A3B4
		// (set) Token: 0x0601E384 RID: 123780 RVA: 0x0043C1BC File Offset: 0x0043A3BC
		public bool IsAllowSubmitAllWpActor { get; set; }

		// Token: 0x17008B93 RID: 35731
		// (get) Token: 0x0601E385 RID: 123781 RVA: 0x0043C1C5 File Offset: 0x0043A3C5
		// (set) Token: 0x0601E386 RID: 123782 RVA: 0x0043C1CD File Offset: 0x0043A3CD
		public ILaunchSettingShowInMainEditorT SettingShowInMainEditor { get; set; }

		// Token: 0x17008B94 RID: 35732
		// (get) Token: 0x0601E387 RID: 123783 RVA: 0x0043C1D6 File Offset: 0x0043A3D6
		// (set) Token: 0x0601E388 RID: 123784 RVA: 0x0043C1DE File Offset: 0x0043A3DE
		public IEditorStartConfigT EditorStartConfig { get; set; }

		// Token: 0x17008B95 RID: 35733
		// (get) Token: 0x0601E389 RID: 123785 RVA: 0x0043C1E7 File Offset: 0x0043A3E7
		// (set) Token: 0x0601E38A RID: 123786 RVA: 0x0043C1EF File Offset: 0x0043A3EF
		public IEditorIndentationDisplaySettingT IndentationDisplaySetting { get; set; }

		// Token: 0x17008B96 RID: 35734
		// (get) Token: 0x0601E38B RID: 123787 RVA: 0x0043C1F8 File Offset: 0x0043A3F8
		// (set) Token: 0x0601E38C RID: 123788 RVA: 0x0043C200 File Offset: 0x0043A400
		public bool IsEnableBottomAoiCheck { get; set; }

		// Token: 0x17008B97 RID: 35735
		// (get) Token: 0x0601E38D RID: 123789 RVA: 0x0043C209 File Offset: 0x0043A409
		// (set) Token: 0x0601E38E RID: 123790 RVA: 0x0043C211 File Offset: 0x0043A411
		public bool IsLimitFloatBoxWidth { get; set; }

		// Token: 0x17008B98 RID: 35736
		// (get) Token: 0x0601E38F RID: 123791 RVA: 0x0043C21A File Offset: 0x0043A41A
		// (set) Token: 0x0601E390 RID: 123792 RVA: 0x0043C222 File Offset: 0x0043A422
		public bool IsEnableAutoSaveRes { get; set; }

		// Token: 0x17008B99 RID: 35737
		// (get) Token: 0x0601E391 RID: 123793 RVA: 0x0043C22B File Offset: 0x0043A42B
		// (set) Token: 0x0601E392 RID: 123794 RVA: 0x0043C233 File Offset: 0x0043A433
		public bool IsAskWhenAutoSaveError { get; set; }

		// Token: 0x17008B9A RID: 35738
		// (get) Token: 0x0601E393 RID: 123795 RVA: 0x0043C23C File Offset: 0x0043A43C
		// (set) Token: 0x0601E394 RID: 123796 RVA: 0x0043C244 File Offset: 0x0043A444
		public bool IsLoadActorWhenJumpEntity { get; set; }

		// Token: 0x17008B9B RID: 35739
		// (get) Token: 0x0601E395 RID: 123797 RVA: 0x0043C24D File Offset: 0x0043A44D
		// (set) Token: 0x0601E396 RID: 123798 RVA: 0x0043C255 File Offset: 0x0043A455
		public bool IsStayInMainWpWhenNavigateSubWpEntity { get; set; }

		// Token: 0x17008B9C RID: 35740
		// (get) Token: 0x0601E397 RID: 123799 RVA: 0x0043C25E File Offset: 0x0043A45E
		// (set) Token: 0x0601E398 RID: 123800 RVA: 0x0043C266 File Offset: 0x0043A466
		public EEntityActorLoadMode EntityActorLoadMode { get; set; }

		// Token: 0x17008B9D RID: 35741
		// (get) Token: 0x0601E399 RID: 123801 RVA: 0x0043C26F File Offset: 0x0043A46F
		// (set) Token: 0x0601E39A RID: 123802 RVA: 0x0043C277 File Offset: 0x0043A477
		public bool IsAskWhenLoadActor { get; set; }

		// Token: 0x17008B9E RID: 35742
		// (get) Token: 0x0601E39B RID: 123803 RVA: 0x0043C280 File Offset: 0x0043A480
		// (set) Token: 0x0601E39C RID: 123804 RVA: 0x0043C288 File Offset: 0x0043A488
		public int ActorLoadCellSize { get; set; }

		// Token: 0x17008B9F RID: 35743
		// (get) Token: 0x0601E39D RID: 123805 RVA: 0x0043C291 File Offset: 0x0043A491
		// (set) Token: 0x0601E39E RID: 123806 RVA: 0x0043C299 File Offset: 0x0043A499
		public int ParentChildAndActorDepth { get; set; }

		// Token: 0x17008BA0 RID: 35744
		// (get) Token: 0x0601E39F RID: 123807 RVA: 0x0043C2A2 File Offset: 0x0043A4A2
		// (set) Token: 0x0601E3A0 RID: 123808 RVA: 0x0043C2AA File Offset: 0x0043A4AA
		public int ParentChildAndActorLoadedActorTypes { get; set; }

		// Token: 0x17008BA1 RID: 35745
		// (get) Token: 0x0601E3A1 RID: 123809 RVA: 0x0043C2B3 File Offset: 0x0043A4B3
		// (set) Token: 0x0601E3A2 RID: 123810 RVA: 0x0043C2BB File Offset: 0x0043A4BB
		public int ParentChildAndActorExcludeFolders { get; set; }

		// Token: 0x17008BA2 RID: 35746
		// (get) Token: 0x0601E3A3 RID: 123811 RVA: 0x0043C2C4 File Offset: 0x0043A4C4
		// (set) Token: 0x0601E3A4 RID: 123812 RVA: 0x0043C2CC File Offset: 0x0043A4CC
		public EActorDeleteMode ActorDeleteMode { get; set; }

		// Token: 0x17008BA3 RID: 35747
		// (get) Token: 0x0601E3A5 RID: 123813 RVA: 0x0043C2D5 File Offset: 0x0043A4D5
		// (set) Token: 0x0601E3A6 RID: 123814 RVA: 0x0043C2DD File Offset: 0x0043A4DD
		public bool IsAskWhenOpenExcel { get; set; }

		// Token: 0x17008BA4 RID: 35748
		// (get) Token: 0x0601E3A7 RID: 123815 RVA: 0x0043C2E6 File Offset: 0x0043A4E6
		// (set) Token: 0x0601E3A8 RID: 123816 RVA: 0x0043C2EE File Offset: 0x0043A4EE
		public List<Record_String_BooleanT> SilentRunTestConfig { get; set; }

		// Token: 0x17008BA5 RID: 35749
		// (get) Token: 0x0601E3A9 RID: 123817 RVA: 0x0043C2F7 File Offset: 0x0043A4F7
		// (set) Token: 0x0601E3AA RID: 123818 RVA: 0x0043C2FF File Offset: 0x0043A4FF
		public List<Record_String_BooleanT> AutoRunTestConfig { get; set; }

		// Token: 0x17008BA6 RID: 35750
		// (get) Token: 0x0601E3AB RID: 123819 RVA: 0x0043C308 File Offset: 0x0043A508
		// (set) Token: 0x0601E3AC RID: 123820 RVA: 0x0043C310 File Offset: 0x0043A510
		public bool IsDebugTest { get; set; }

		// Token: 0x17008BA7 RID: 35751
		// (get) Token: 0x0601E3AD RID: 123821 RVA: 0x0043C319 File Offset: 0x0043A519
		// (set) Token: 0x0601E3AE RID: 123822 RVA: 0x0043C321 File Offset: 0x0043A521
		public EActionDisabledType ActionDisabledType { get; set; }

		// Token: 0x17008BA8 RID: 35752
		// (get) Token: 0x0601E3AF RID: 123823 RVA: 0x0043C32A File Offset: 0x0043A52A
		// (set) Token: 0x0601E3B0 RID: 123824 RVA: 0x0043C332 File Offset: 0x0043A532
		public ETreeNodeDisabledType TreeNodeDisabledType { get; set; }

		// Token: 0x17008BA9 RID: 35753
		// (get) Token: 0x0601E3B1 RID: 123825 RVA: 0x0043C33B File Offset: 0x0043A53B
		// (set) Token: 0x0601E3B2 RID: 123826 RVA: 0x0043C343 File Offset: 0x0043A543
		public bool ShowClipboardTipsInStatusBar { get; set; }

		// Token: 0x17008BAA RID: 35754
		// (get) Token: 0x0601E3B3 RID: 123827 RVA: 0x0043C34C File Offset: 0x0043A54C
		// (set) Token: 0x0601E3B4 RID: 123828 RVA: 0x0043C354 File Offset: 0x0043A554
		public bool IsAllowDragDropArray { get; set; }

		// Token: 0x17008BAB RID: 35755
		// (get) Token: 0x0601E3B5 RID: 123829 RVA: 0x0043C35D File Offset: 0x0043A55D
		// (set) Token: 0x0601E3B6 RID: 123830 RVA: 0x0043C365 File Offset: 0x0043A565
		public EActionHelpClickMode ActionHelpClickMode { get; set; }

		// Token: 0x17008BAC RID: 35756
		// (get) Token: 0x0601E3B7 RID: 123831 RVA: 0x0043C36E File Offset: 0x0043A56E
		// (set) Token: 0x0601E3B8 RID: 123832 RVA: 0x0043C376 File Offset: 0x0043A576
		public string AkiBasePath { get; set; }

		// Token: 0x17008BAD RID: 35757
		// (get) Token: 0x0601E3B9 RID: 123833 RVA: 0x0043C37F File Offset: 0x0043A57F
		// (set) Token: 0x0601E3BA RID: 123834 RVA: 0x0043C387 File Offset: 0x0043A587
		public string ExternalJsonEditor { get; set; }

		// Token: 0x0601E3BB RID: 123835 RVA: 0x0043C390 File Offset: 0x0043A590
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
			this.IsStayInMainWpWhenNavigateSubWpEntity = false;
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
			this.ActionDisabledType = EActionDisabledType.SmartDisabled;
			this.TreeNodeDisabledType = ETreeNodeDisabledType.LocalDisabled;
			this.ShowClipboardTipsInStatusBar = false;
			this.IsAllowDragDropArray = false;
			this.ActionHelpClickMode = EActionHelpClickMode.OpenDetailByClick;
			this.AkiBasePath = null;
			this.ExternalJsonEditor = null;
		}
	}
}
