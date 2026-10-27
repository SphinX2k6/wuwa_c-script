using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004869 RID: 18537
	public class IEditorSaveConfigT
	{
		// Token: 0x1700859D RID: 34205
		// (get) Token: 0x0601CC80 RID: 117888 RVA: 0x00411905 File Offset: 0x0040FB05
		// (set) Token: 0x0601CC81 RID: 117889 RVA: 0x0041190D File Offset: 0x0040FB0D
		public string Account { get; set; }

		// Token: 0x1700859E RID: 34206
		// (get) Token: 0x0601CC82 RID: 117890 RVA: 0x00411916 File Offset: 0x0040FB16
		// (set) Token: 0x0601CC83 RID: 117891 RVA: 0x0041191E File Offset: 0x0040FB1E
		public EEditorLoginAccountType LoginAccountType { get; set; }

		// Token: 0x1700859F RID: 34207
		// (get) Token: 0x0601CC84 RID: 117892 RVA: 0x00411927 File Offset: 0x0040FB27
		// (set) Token: 0x0601CC85 RID: 117893 RVA: 0x0041192F File Offset: 0x0040FB2F
		public string CustomAccount { get; set; }

		// Token: 0x170085A0 RID: 34208
		// (get) Token: 0x0601CC86 RID: 117894 RVA: 0x00411938 File Offset: 0x0040FB38
		// (set) Token: 0x0601CC87 RID: 117895 RVA: 0x00411940 File Offset: 0x0040FB40
		public string ArchiveAccount { get; set; }

		// Token: 0x170085A1 RID: 34209
		// (get) Token: 0x0601CC88 RID: 117896 RVA: 0x00411949 File Offset: 0x0040FB49
		// (set) Token: 0x0601CC89 RID: 117897 RVA: 0x00411951 File Offset: 0x0040FB51
		public bool IsNetMode { get; set; }

		// Token: 0x170085A2 RID: 34210
		// (get) Token: 0x0601CC8A RID: 117898 RVA: 0x0041195A File Offset: 0x0040FB5A
		// (set) Token: 0x0601CC8B RID: 117899 RVA: 0x00411962 File Offset: 0x0040FB62
		public bool IsMale { get; set; }

		// Token: 0x170085A3 RID: 34211
		// (get) Token: 0x0601CC8C RID: 117900 RVA: 0x0041196B File Offset: 0x0040FB6B
		// (set) Token: 0x0601CC8D RID: 117901 RVA: 0x00411973 File Offset: 0x0040FB73
		public bool UseTemp { get; set; }

		// Token: 0x170085A4 RID: 34212
		// (get) Token: 0x0601CC8E RID: 117902 RVA: 0x0041197C File Offset: 0x0040FB7C
		// (set) Token: 0x0601CC8F RID: 117903 RVA: 0x00411984 File Offset: 0x0040FB84
		public string ServerIp { get; set; }

		// Token: 0x170085A5 RID: 34213
		// (get) Token: 0x0601CC90 RID: 117904 RVA: 0x0041198D File Offset: 0x0040FB8D
		// (set) Token: 0x0601CC91 RID: 117905 RVA: 0x00411995 File Offset: 0x0040FB95
		public bool IsRelaxMode { get; set; }

		// Token: 0x170085A6 RID: 34214
		// (get) Token: 0x0601CC92 RID: 117906 RVA: 0x0041199E File Offset: 0x0040FB9E
		// (set) Token: 0x0601CC93 RID: 117907 RVA: 0x004119A6 File Offset: 0x0040FBA6
		public int DungeonId { get; set; }

		// Token: 0x170085A7 RID: 34215
		// (get) Token: 0x0601CC94 RID: 117908 RVA: 0x004119AF File Offset: 0x0040FBAF
		// (set) Token: 0x0601CC95 RID: 117909 RVA: 0x004119B7 File Offset: 0x0040FBB7
		public bool IsBornAtCamera { get; set; }

		// Token: 0x170085A8 RID: 34216
		// (get) Token: 0x0601CC96 RID: 117910 RVA: 0x004119C0 File Offset: 0x0040FBC0
		// (set) Token: 0x0601CC97 RID: 117911 RVA: 0x004119C8 File Offset: 0x0040FBC8
		public bool IsOpenDebugService { get; set; }

		// Token: 0x170085A9 RID: 34217
		// (get) Token: 0x0601CC98 RID: 117912 RVA: 0x004119D1 File Offset: 0x0040FBD1
		// (set) Token: 0x0601CC99 RID: 117913 RVA: 0x004119D9 File Offset: 0x0040FBD9
		public bool DisableAutoStartServer { get; set; }

		// Token: 0x170085AA RID: 34218
		// (get) Token: 0x0601CC9A RID: 117914 RVA: 0x004119E2 File Offset: 0x0040FBE2
		// (set) Token: 0x0601CC9B RID: 117915 RVA: 0x004119EA File Offset: 0x0040FBEA
		public bool ReloadEditorConfig { get; set; }

		// Token: 0x170085AB RID: 34219
		// (get) Token: 0x0601CC9C RID: 117916 RVA: 0x004119F3 File Offset: 0x0040FBF3
		// (set) Token: 0x0601CC9D RID: 117917 RVA: 0x004119FB File Offset: 0x0040FBFB
		public bool ReloadConfigTable { get; set; }

		// Token: 0x170085AC RID: 34220
		// (get) Token: 0x0601CC9E RID: 117918 RVA: 0x00411A04 File Offset: 0x0040FC04
		// (set) Token: 0x0601CC9F RID: 117919 RVA: 0x00411A0C File Offset: 0x0040FC0C
		public bool IsLoginByNewUserName { get; set; }

		// Token: 0x170085AD RID: 34221
		// (get) Token: 0x0601CCA0 RID: 117920 RVA: 0x00411A15 File Offset: 0x0040FC15
		// (set) Token: 0x0601CCA1 RID: 117921 RVA: 0x00411A1D File Offset: 0x0040FC1D
		public EAccountType AccountType { get; set; }

		// Token: 0x170085AE RID: 34222
		// (get) Token: 0x0601CCA2 RID: 117922 RVA: 0x00411A26 File Offset: 0x0040FC26
		// (set) Token: 0x0601CCA3 RID: 117923 RVA: 0x00411A2E File Offset: 0x0040FC2E
		public string GmPathOnLogin { get; set; }

		// Token: 0x170085AF RID: 34223
		// (get) Token: 0x0601CCA4 RID: 117924 RVA: 0x00411A37 File Offset: 0x0040FC37
		// (set) Token: 0x0601CCA5 RID: 117925 RVA: 0x00411A3F File Offset: 0x0040FC3F
		public int EditorPort { get; set; }

		// Token: 0x170085B0 RID: 34224
		// (get) Token: 0x0601CCA6 RID: 117926 RVA: 0x00411A48 File Offset: 0x0040FC48
		// (set) Token: 0x0601CCA7 RID: 117927 RVA: 0x00411A50 File Offset: 0x0040FC50
		public int GameClientGmPort { get; set; }

		// Token: 0x170085B1 RID: 34225
		// (get) Token: 0x0601CCA8 RID: 117928 RVA: 0x00411A59 File Offset: 0x0040FC59
		// (set) Token: 0x0601CCA9 RID: 117929 RVA: 0x00411A61 File Offset: 0x0040FC61
		public bool IsReLoadArchive { get; set; }

		// Token: 0x170085B2 RID: 34226
		// (get) Token: 0x0601CCAA RID: 117930 RVA: 0x00411A6A File Offset: 0x0040FC6A
		// (set) Token: 0x0601CCAB RID: 117931 RVA: 0x00411A72 File Offset: 0x0040FC72
		public int PackageVersion { get; set; }

		// Token: 0x170085B3 RID: 34227
		// (get) Token: 0x0601CCAC RID: 117932 RVA: 0x00411A7B File Offset: 0x0040FC7B
		// (set) Token: 0x0601CCAD RID: 117933 RVA: 0x00411A83 File Offset: 0x0040FC83
		public bool IsCustomAttachServerIp { get; set; }

		// Token: 0x170085B4 RID: 34228
		// (get) Token: 0x0601CCAE RID: 117934 RVA: 0x00411A8C File Offset: 0x0040FC8C
		// (set) Token: 0x0601CCAF RID: 117935 RVA: 0x00411A94 File Offset: 0x0040FC94
		public string AttachServerIp { get; set; }

		// Token: 0x170085B5 RID: 34229
		// (get) Token: 0x0601CCB0 RID: 117936 RVA: 0x00411A9D File Offset: 0x0040FC9D
		// (set) Token: 0x0601CCB1 RID: 117937 RVA: 0x00411AA5 File Offset: 0x0040FCA5
		public int AttachPlayerId { get; set; }

		// Token: 0x170085B6 RID: 34230
		// (get) Token: 0x0601CCB2 RID: 117938 RVA: 0x00411AAE File Offset: 0x0040FCAE
		// (set) Token: 0x0601CCB3 RID: 117939 RVA: 0x00411AB6 File Offset: 0x0040FCB6
		public bool IsUseMobileStreamingParamsInPie { get; set; }

		// Token: 0x170085B7 RID: 34231
		// (get) Token: 0x0601CCB4 RID: 117940 RVA: 0x00411ABF File Offset: 0x0040FCBF
		// (set) Token: 0x0601CCB5 RID: 117941 RVA: 0x00411AC7 File Offset: 0x0040FCC7
		public bool IsUseHighAoi { get; set; }

		// Token: 0x170085B8 RID: 34232
		// (get) Token: 0x0601CCB6 RID: 117942 RVA: 0x00411AD0 File Offset: 0x0040FCD0
		// (set) Token: 0x0601CCB7 RID: 117943 RVA: 0x00411AD8 File Offset: 0x0040FCD8
		public bool IsStayInSubWp { get; set; }

		// Token: 0x170085B9 RID: 34233
		// (get) Token: 0x0601CCB8 RID: 117944 RVA: 0x00411AE1 File Offset: 0x0040FCE1
		// (set) Token: 0x0601CCB9 RID: 117945 RVA: 0x00411AE9 File Offset: 0x0040FCE9
		public string CustomPlayerName { get; set; }

		// Token: 0x0601CCBA RID: 117946 RVA: 0x00411AF4 File Offset: 0x0040FCF4
		public IEditorSaveConfigT()
		{
			this.Account = null;
			this.LoginAccountType = EEditorLoginAccountType.Custom;
			this.CustomAccount = null;
			this.ArchiveAccount = null;
			this.IsNetMode = false;
			this.IsMale = false;
			this.UseTemp = false;
			this.ServerIp = null;
			this.IsRelaxMode = false;
			this.DungeonId = 0;
			this.IsBornAtCamera = false;
			this.IsOpenDebugService = false;
			this.DisableAutoStartServer = false;
			this.ReloadEditorConfig = false;
			this.ReloadConfigTable = false;
			this.IsLoginByNewUserName = false;
			this.AccountType = EAccountType.Custom;
			this.GmPathOnLogin = null;
			this.EditorPort = 0;
			this.GameClientGmPort = 0;
			this.IsReLoadArchive = false;
			this.PackageVersion = 0;
			this.IsCustomAttachServerIp = false;
			this.AttachServerIp = null;
			this.AttachPlayerId = 0;
			this.IsUseMobileStreamingParamsInPie = false;
			this.IsUseHighAoi = false;
			this.IsStayInSubWp = false;
			this.CustomPlayerName = null;
		}
	}
}
