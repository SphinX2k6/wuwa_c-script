using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A0 RID: 16800
	public class IChildQuestBtNodeT
	{
		// Token: 0x170071F1 RID: 29169
		// (get) Token: 0x060172F0 RID: 94960 RVA: 0x0034F93A File Offset: 0x0034DB3A
		// (set) Token: 0x060172F1 RID: 94961 RVA: 0x0034F942 File Offset: 0x0034DB42
		public EBtNode Type { get; set; }

		// Token: 0x170071F2 RID: 29170
		// (get) Token: 0x060172F2 RID: 94962 RVA: 0x0034F94B File Offset: 0x0034DB4B
		// (set) Token: 0x060172F3 RID: 94963 RVA: 0x0034F953 File Offset: 0x0034DB53
		public int Id { get; set; }

		// Token: 0x170071F3 RID: 29171
		// (get) Token: 0x060172F4 RID: 94964 RVA: 0x0034F95C File Offset: 0x0034DB5C
		// (set) Token: 0x060172F5 RID: 94965 RVA: 0x0034F964 File Offset: 0x0034DB64
		public string Desc { get; set; }

		// Token: 0x170071F4 RID: 29172
		// (get) Token: 0x060172F6 RID: 94966 RVA: 0x0034F96D File Offset: 0x0034DB6D
		// (set) Token: 0x060172F7 RID: 94967 RVA: 0x0034F975 File Offset: 0x0034DB75
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170071F5 RID: 29173
		// (get) Token: 0x060172F8 RID: 94968 RVA: 0x0034F97E File Offset: 0x0034DB7E
		// (set) Token: 0x060172F9 RID: 94969 RVA: 0x0034F986 File Offset: 0x0034DB86
		public bool _FoldedForTree { get; set; }

		// Token: 0x170071F6 RID: 29174
		// (get) Token: 0x060172FA RID: 94970 RVA: 0x0034F98F File Offset: 0x0034DB8F
		// (set) Token: 0x060172FB RID: 94971 RVA: 0x0034F997 File Offset: 0x0034DB97
		public bool Disabled { get; set; }

		// Token: 0x170071F7 RID: 29175
		// (get) Token: 0x060172FC RID: 94972 RVA: 0x0034F9A0 File Offset: 0x0034DBA0
		// (set) Token: 0x060172FD RID: 94973 RVA: 0x0034F9A8 File Offset: 0x0034DBA8
		public int RewardId { get; set; }

		// Token: 0x170071F8 RID: 29176
		// (get) Token: 0x060172FE RID: 94974 RVA: 0x0034F9B1 File Offset: 0x0034DBB1
		// (set) Token: 0x060172FF RID: 94975 RVA: 0x0034F9B9 File Offset: 0x0034DBB9
		public EItemGetUiType RewardGetUiType { get; set; }

		// Token: 0x170071F9 RID: 29177
		// (get) Token: 0x06017300 RID: 94976 RVA: 0x0034F9C2 File Offset: 0x0034DBC2
		// (set) Token: 0x06017301 RID: 94977 RVA: 0x0034F9CA File Offset: 0x0034DBCA
		public IItemGetUiConfigSpecialQuestT RewardGetUiConfig { get; set; }

		// Token: 0x170071FA RID: 29178
		// (get) Token: 0x06017302 RID: 94978 RVA: 0x0034F9D3 File Offset: 0x0034DBD3
		// (set) Token: 0x06017303 RID: 94979 RVA: 0x0034F9DB File Offset: 0x0034DBDB
		public bool HideTip { get; set; }

		// Token: 0x170071FB RID: 29179
		// (get) Token: 0x06017304 RID: 94980 RVA: 0x0034F9E4 File Offset: 0x0034DBE4
		// (set) Token: 0x06017305 RID: 94981 RVA: 0x0034F9EC File Offset: 0x0034DBEC
		public string TidTip { get; set; }

		// Token: 0x170071FC RID: 29180
		// (get) Token: 0x06017306 RID: 94982 RVA: 0x0034F9F5 File Offset: 0x0034DBF5
		// (set) Token: 0x06017307 RID: 94983 RVA: 0x0034F9FD File Offset: 0x0034DBFD
		public bool ShowTipBeforeEnterActions { get; set; }

		// Token: 0x170071FD RID: 29181
		// (get) Token: 0x06017308 RID: 94984 RVA: 0x0034FA06 File Offset: 0x0034DC06
		// (set) Token: 0x06017309 RID: 94985 RVA: 0x0034FA0E File Offset: 0x0034DC0E
		public bool ShowNavigation { get; set; }

		// Token: 0x170071FE RID: 29182
		// (get) Token: 0x0601730A RID: 94986 RVA: 0x0034FA17 File Offset: 0x0034DC17
		// (set) Token: 0x0601730B RID: 94987 RVA: 0x0034FA1F File Offset: 0x0034DC1F
		public ENavigationStyle NavigationStyle { get; set; }

		// Token: 0x170071FF RID: 29183
		// (get) Token: 0x0601730C RID: 94988 RVA: 0x0034FA28 File Offset: 0x0034DC28
		// (set) Token: 0x0601730D RID: 94989 RVA: 0x0034FA30 File Offset: 0x0034DC30
		public bool AlwaysShowNavigation { get; set; }

		// Token: 0x17007200 RID: 29184
		// (get) Token: 0x0601730E RID: 94990 RVA: 0x0034FA39 File Offset: 0x0034DC39
		// (set) Token: 0x0601730F RID: 94991 RVA: 0x0034FA41 File Offset: 0x0034DC41
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x17007201 RID: 29185
		// (get) Token: 0x06017310 RID: 94992 RVA: 0x0034FA4A File Offset: 0x0034DC4A
		// (set) Token: 0x06017311 RID: 94993 RVA: 0x0034FA52 File Offset: 0x0034DC52
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007202 RID: 29186
		// (get) Token: 0x06017312 RID: 94994 RVA: 0x0034FA5B File Offset: 0x0034DC5B
		// (set) Token: 0x06017313 RID: 94995 RVA: 0x0034FA63 File Offset: 0x0034DC63
		public ITrackTargetT TrackTarget { get; set; }

		// Token: 0x17007203 RID: 29187
		// (get) Token: 0x06017314 RID: 94996 RVA: 0x0034FA6C File Offset: 0x0034DC6C
		// (set) Token: 0x06017315 RID: 94997 RVA: 0x0034FA74 File Offset: 0x0034DC74
		public TChildQuestConditionUnion Condition { get; set; }

		// Token: 0x17007204 RID: 29188
		// (get) Token: 0x06017316 RID: 94998 RVA: 0x0034FA7D File Offset: 0x0034DC7D
		// (set) Token: 0x06017317 RID: 94999 RVA: 0x0034FA85 File Offset: 0x0034DC85
		public bool HideUi { get; set; }

		// Token: 0x17007205 RID: 29189
		// (get) Token: 0x06017318 RID: 95000 RVA: 0x0034FA8E File Offset: 0x0034DC8E
		// (set) Token: 0x06017319 RID: 95001 RVA: 0x0034FA96 File Offset: 0x0034DC96
		public bool HideUiExceptTaskList { get; set; }

		// Token: 0x17007206 RID: 29190
		// (get) Token: 0x0601731A RID: 95002 RVA: 0x0034FA9F File Offset: 0x0034DC9F
		// (set) Token: 0x0601731B RID: 95003 RVA: 0x0034FAA7 File Offset: 0x0034DCA7
		public TSaveConfigUnion SaveConfig { get; set; }

		// Token: 0x17007207 RID: 29191
		// (get) Token: 0x0601731C RID: 95004 RVA: 0x0034FAB0 File Offset: 0x0034DCB0
		// (set) Token: 0x0601731D RID: 95005 RVA: 0x0034FAB8 File Offset: 0x0034DCB8
		public int CustomIcon { get; set; }

		// Token: 0x17007208 RID: 29192
		// (get) Token: 0x0601731E RID: 95006 RVA: 0x0034FAC1 File Offset: 0x0034DCC1
		// (set) Token: 0x0601731F RID: 95007 RVA: 0x0034FAC9 File Offset: 0x0034DCC9
		public int CustomTrackUiPrefabId { get; set; }

		// Token: 0x17007209 RID: 29193
		// (get) Token: 0x06017320 RID: 95008 RVA: 0x0034FAD2 File Offset: 0x0034DCD2
		// (set) Token: 0x06017321 RID: 95009 RVA: 0x0034FADA File Offset: 0x0034DCDA
		public List<IStuckCheckConditionT> StuckCheck { get; set; }

		// Token: 0x1700720A RID: 29194
		// (get) Token: 0x06017322 RID: 95010 RVA: 0x0034FAE3 File Offset: 0x0034DCE3
		// (set) Token: 0x06017323 RID: 95011 RVA: 0x0034FAEB File Offset: 0x0034DCEB
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x1700720B RID: 29195
		// (get) Token: 0x06017324 RID: 95012 RVA: 0x0034FAF4 File Offset: 0x0034DCF4
		// (set) Token: 0x06017325 RID: 95013 RVA: 0x0034FAFC File Offset: 0x0034DCFC
		public ITrackCustomBoardT TrackCustomBoard { get; set; }

		// Token: 0x1700720C RID: 29196
		// (get) Token: 0x06017326 RID: 95014 RVA: 0x0034FB05 File Offset: 0x0034DD05
		// (set) Token: 0x06017327 RID: 95015 RVA: 0x0034FB0D File Offset: 0x0034DD0D
		public ushort NullMask { get; set; }

		// Token: 0x06017328 RID: 95016 RVA: 0x0034FB18 File Offset: 0x0034DD18
		public IChildQuestBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.RewardId = 0;
			this.RewardGetUiType = EItemGetUiType.None;
			this.RewardGetUiConfig = null;
			this.HideTip = false;
			this.TidTip = null;
			this.ShowTipBeforeEnterActions = false;
			this.ShowNavigation = false;
			this.NavigationStyle = ENavigationStyle.Default;
			this.AlwaysShowNavigation = false;
			this.EnterActions = null;
			this.FinishActions = null;
			this.TrackTarget = null;
			this.Condition = null;
			this.HideUi = false;
			this.HideUiExceptTaskList = false;
			this.SaveConfig = null;
			this.CustomIcon = 0;
			this.CustomTrackUiPrefabId = 0;
			this.StuckCheck = null;
			this.ModifyTrackAreaText = null;
			this.TrackCustomBoard = null;
			this.NullMask = 0;
		}
	}
}
