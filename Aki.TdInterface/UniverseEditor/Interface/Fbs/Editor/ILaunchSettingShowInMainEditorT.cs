using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE6 RID: 19686
	public class ILaunchSettingShowInMainEditorT
	{
		// Token: 0x17008CC6 RID: 36038
		// (get) Token: 0x0601E6E9 RID: 124649 RVA: 0x0044387E File Offset: 0x00441A7E
		// (set) Token: 0x0601E6EA RID: 124650 RVA: 0x00443886 File Offset: 0x00441A86
		public bool DisableAutoStartServer { get; set; }

		// Token: 0x17008CC7 RID: 36039
		// (get) Token: 0x0601E6EB RID: 124651 RVA: 0x0044388F File Offset: 0x00441A8F
		// (set) Token: 0x0601E6EC RID: 124652 RVA: 0x00443897 File Offset: 0x00441A97
		public bool IsNetMode { get; set; }

		// Token: 0x17008CC8 RID: 36040
		// (get) Token: 0x0601E6ED RID: 124653 RVA: 0x004438A0 File Offset: 0x00441AA0
		// (set) Token: 0x0601E6EE RID: 124654 RVA: 0x004438A8 File Offset: 0x00441AA8
		public bool UseTemp { get; set; }

		// Token: 0x17008CC9 RID: 36041
		// (get) Token: 0x0601E6EF RID: 124655 RVA: 0x004438B1 File Offset: 0x00441AB1
		// (set) Token: 0x0601E6F0 RID: 124656 RVA: 0x004438B9 File Offset: 0x00441AB9
		public bool EnableDeltaReload { get; set; }

		// Token: 0x17008CCA RID: 36042
		// (get) Token: 0x0601E6F1 RID: 124657 RVA: 0x004438C2 File Offset: 0x00441AC2
		// (set) Token: 0x0601E6F2 RID: 124658 RVA: 0x004438CA File Offset: 0x00441ACA
		public bool ReloadEditorConfig { get; set; }

		// Token: 0x17008CCB RID: 36043
		// (get) Token: 0x0601E6F3 RID: 124659 RVA: 0x004438D3 File Offset: 0x00441AD3
		// (set) Token: 0x0601E6F4 RID: 124660 RVA: 0x004438DB File Offset: 0x00441ADB
		public bool ReloadConfigTable { get; set; }

		// Token: 0x17008CCC RID: 36044
		// (get) Token: 0x0601E6F5 RID: 124661 RVA: 0x004438E4 File Offset: 0x00441AE4
		// (set) Token: 0x0601E6F6 RID: 124662 RVA: 0x004438EC File Offset: 0x00441AEC
		public bool Account { get; set; }

		// Token: 0x17008CCD RID: 36045
		// (get) Token: 0x0601E6F7 RID: 124663 RVA: 0x004438F5 File Offset: 0x00441AF5
		// (set) Token: 0x0601E6F8 RID: 124664 RVA: 0x004438FD File Offset: 0x00441AFD
		public bool IsBornAtCamera { get; set; }

		// Token: 0x17008CCE RID: 36046
		// (get) Token: 0x0601E6F9 RID: 124665 RVA: 0x00443906 File Offset: 0x00441B06
		// (set) Token: 0x0601E6FA RID: 124666 RVA: 0x0044390E File Offset: 0x00441B0E
		public bool IsOpenDebugService { get; set; }

		// Token: 0x17008CCF RID: 36047
		// (get) Token: 0x0601E6FB RID: 124667 RVA: 0x00443917 File Offset: 0x00441B17
		// (set) Token: 0x0601E6FC RID: 124668 RVA: 0x0044391F File Offset: 0x00441B1F
		public bool IsMale { get; set; }

		// Token: 0x17008CD0 RID: 36048
		// (get) Token: 0x0601E6FD RID: 124669 RVA: 0x00443928 File Offset: 0x00441B28
		// (set) Token: 0x0601E6FE RID: 124670 RVA: 0x00443930 File Offset: 0x00441B30
		public bool WaitDebug { get; set; }

		// Token: 0x17008CD1 RID: 36049
		// (get) Token: 0x0601E6FF RID: 124671 RVA: 0x00443939 File Offset: 0x00441B39
		// (set) Token: 0x0601E700 RID: 124672 RVA: 0x00443941 File Offset: 0x00441B41
		public bool EnableAllSystemWithoutPopWin { get; set; }

		// Token: 0x17008CD2 RID: 36050
		// (get) Token: 0x0601E701 RID: 124673 RVA: 0x0044394A File Offset: 0x00441B4A
		// (set) Token: 0x0601E702 RID: 124674 RVA: 0x00443952 File Offset: 0x00441B52
		public bool IsUnlockExplore { get; set; }

		// Token: 0x17008CD3 RID: 36051
		// (get) Token: 0x0601E703 RID: 124675 RVA: 0x0044395B File Offset: 0x00441B5B
		// (set) Token: 0x0601E704 RID: 124676 RVA: 0x00443963 File Offset: 0x00441B63
		public bool IsUnlockSpecial { get; set; }

		// Token: 0x17008CD4 RID: 36052
		// (get) Token: 0x0601E705 RID: 124677 RVA: 0x0044396C File Offset: 0x00441B6C
		// (set) Token: 0x0601E706 RID: 124678 RVA: 0x00443974 File Offset: 0x00441B74
		public bool EnableAllTeleportPoints { get; set; }

		// Token: 0x17008CD5 RID: 36053
		// (get) Token: 0x0601E707 RID: 124679 RVA: 0x0044397D File Offset: 0x00441B7D
		// (set) Token: 0x0601E708 RID: 124680 RVA: 0x00443985 File Offset: 0x00441B85
		public bool IsUnlockAllFog { get; set; }

		// Token: 0x17008CD6 RID: 36054
		// (get) Token: 0x0601E709 RID: 124681 RVA: 0x0044398E File Offset: 0x00441B8E
		// (set) Token: 0x0601E70A RID: 124682 RVA: 0x00443996 File Offset: 0x00441B96
		public bool IsDisableTeleportDungeon { get; set; }

		// Token: 0x17008CD7 RID: 36055
		// (get) Token: 0x0601E70B RID: 124683 RVA: 0x0044399F File Offset: 0x00441B9F
		// (set) Token: 0x0601E70C RID: 124684 RVA: 0x004439A7 File Offset: 0x00441BA7
		public bool IsSkipQuests { get; set; }

		// Token: 0x17008CD8 RID: 36056
		// (get) Token: 0x0601E70D RID: 124685 RVA: 0x004439B0 File Offset: 0x00441BB0
		// (set) Token: 0x0601E70E RID: 124686 RVA: 0x004439B8 File Offset: 0x00441BB8
		public bool LevelSetting { get; set; }

		// Token: 0x17008CD9 RID: 36057
		// (get) Token: 0x0601E70F RID: 124687 RVA: 0x004439C1 File Offset: 0x00441BC1
		// (set) Token: 0x0601E710 RID: 124688 RVA: 0x004439C9 File Offset: 0x00441BC9
		public bool NewLevelSetting { get; set; }

		// Token: 0x17008CDA RID: 36058
		// (get) Token: 0x0601E711 RID: 124689 RVA: 0x004439D2 File Offset: 0x00441BD2
		// (set) Token: 0x0601E712 RID: 124690 RVA: 0x004439DA File Offset: 0x00441BDA
		public bool DataLayerSetting { get; set; }

		// Token: 0x17008CDB RID: 36059
		// (get) Token: 0x0601E713 RID: 124691 RVA: 0x004439E3 File Offset: 0x00441BE3
		// (set) Token: 0x0601E714 RID: 124692 RVA: 0x004439EB File Offset: 0x00441BEB
		public bool DisableEntitySetting { get; set; }

		// Token: 0x17008CDC RID: 36060
		// (get) Token: 0x0601E715 RID: 124693 RVA: 0x004439F4 File Offset: 0x00441BF4
		// (set) Token: 0x0601E716 RID: 124694 RVA: 0x004439FC File Offset: 0x00441BFC
		public bool GmPathOnLogin { get; set; }

		// Token: 0x17008CDD RID: 36061
		// (get) Token: 0x0601E717 RID: 124695 RVA: 0x00443A05 File Offset: 0x00441C05
		// (set) Token: 0x0601E718 RID: 124696 RVA: 0x00443A0D File Offset: 0x00441C0D
		public bool IsUseMobileStreamingParamsInPie { get; set; }

		// Token: 0x17008CDE RID: 36062
		// (get) Token: 0x0601E719 RID: 124697 RVA: 0x00443A16 File Offset: 0x00441C16
		// (set) Token: 0x0601E71A RID: 124698 RVA: 0x00443A1E File Offset: 0x00441C1E
		public bool IsUseHighAoi { get; set; }

		// Token: 0x17008CDF RID: 36063
		// (get) Token: 0x0601E71B RID: 124699 RVA: 0x00443A27 File Offset: 0x00441C27
		// (set) Token: 0x0601E71C RID: 124700 RVA: 0x00443A2F File Offset: 0x00441C2F
		public bool IsOpenUseWorldPartitionLoadedZone { get; set; }

		// Token: 0x17008CE0 RID: 36064
		// (get) Token: 0x0601E71D RID: 124701 RVA: 0x00443A38 File Offset: 0x00441C38
		// (set) Token: 0x0601E71E RID: 124702 RVA: 0x00443A40 File Offset: 0x00441C40
		public bool IsCloseSkinnedMeshAlwaysTick { get; set; }

		// Token: 0x17008CE1 RID: 36065
		// (get) Token: 0x0601E71F RID: 124703 RVA: 0x00443A49 File Offset: 0x00441C49
		// (set) Token: 0x0601E720 RID: 124704 RVA: 0x00443A51 File Offset: 0x00441C51
		public bool IsOpenReloadSpeed { get; set; }

		// Token: 0x17008CE2 RID: 36066
		// (get) Token: 0x0601E721 RID: 124705 RVA: 0x00443A5A File Offset: 0x00441C5A
		// (set) Token: 0x0601E722 RID: 124706 RVA: 0x00443A62 File Offset: 0x00441C62
		public bool IsStayInSubWp { get; set; }

		// Token: 0x17008CE3 RID: 36067
		// (get) Token: 0x0601E723 RID: 124707 RVA: 0x00443A6B File Offset: 0x00441C6B
		// (set) Token: 0x0601E724 RID: 124708 RVA: 0x00443A73 File Offset: 0x00441C73
		public bool CustomPlayerName { get; set; }

		// Token: 0x17008CE4 RID: 36068
		// (get) Token: 0x0601E725 RID: 124709 RVA: 0x00443A7C File Offset: 0x00441C7C
		// (set) Token: 0x0601E726 RID: 124710 RVA: 0x00443A84 File Offset: 0x00441C84
		public uint NullMask { get; set; }

		// Token: 0x0601E727 RID: 124711 RVA: 0x00443A90 File Offset: 0x00441C90
		public ILaunchSettingShowInMainEditorT()
		{
			this.DisableAutoStartServer = false;
			this.IsNetMode = false;
			this.UseTemp = false;
			this.EnableDeltaReload = false;
			this.ReloadEditorConfig = false;
			this.ReloadConfigTable = false;
			this.Account = false;
			this.IsBornAtCamera = false;
			this.IsOpenDebugService = false;
			this.IsMale = false;
			this.WaitDebug = false;
			this.EnableAllSystemWithoutPopWin = false;
			this.IsUnlockExplore = false;
			this.IsUnlockSpecial = false;
			this.EnableAllTeleportPoints = false;
			this.IsUnlockAllFog = false;
			this.IsDisableTeleportDungeon = false;
			this.IsSkipQuests = false;
			this.LevelSetting = false;
			this.NewLevelSetting = false;
			this.DataLayerSetting = false;
			this.DisableEntitySetting = false;
			this.GmPathOnLogin = false;
			this.IsUseMobileStreamingParamsInPie = false;
			this.IsUseHighAoi = false;
			this.IsOpenUseWorldPartitionLoadedZone = false;
			this.IsCloseSkinnedMeshAlwaysTick = false;
			this.IsOpenReloadSpeed = false;
			this.IsStayInSubWp = false;
			this.CustomPlayerName = false;
			this.NullMask = 0U;
		}
	}
}
