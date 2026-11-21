using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CCE RID: 19662
	public class IEditorSaveConfigT
	{
		// Token: 0x17008BE7 RID: 35815
		// (get) Token: 0x0601E471 RID: 124017 RVA: 0x0043E1AD File Offset: 0x0043C3AD
		// (set) Token: 0x0601E472 RID: 124018 RVA: 0x0043E1B5 File Offset: 0x0043C3B5
		public string Account { get; set; }

		// Token: 0x17008BE8 RID: 35816
		// (get) Token: 0x0601E473 RID: 124019 RVA: 0x0043E1BE File Offset: 0x0043C3BE
		// (set) Token: 0x0601E474 RID: 124020 RVA: 0x0043E1C6 File Offset: 0x0043C3C6
		public EEditorLoginAccountType LoginAccountType { get; set; }

		// Token: 0x17008BE9 RID: 35817
		// (get) Token: 0x0601E475 RID: 124021 RVA: 0x0043E1CF File Offset: 0x0043C3CF
		// (set) Token: 0x0601E476 RID: 124022 RVA: 0x0043E1D7 File Offset: 0x0043C3D7
		public string CustomAccount { get; set; }

		// Token: 0x17008BEA RID: 35818
		// (get) Token: 0x0601E477 RID: 124023 RVA: 0x0043E1E0 File Offset: 0x0043C3E0
		// (set) Token: 0x0601E478 RID: 124024 RVA: 0x0043E1E8 File Offset: 0x0043C3E8
		public string ArchiveAccount { get; set; }

		// Token: 0x17008BEB RID: 35819
		// (get) Token: 0x0601E479 RID: 124025 RVA: 0x0043E1F1 File Offset: 0x0043C3F1
		// (set) Token: 0x0601E47A RID: 124026 RVA: 0x0043E1F9 File Offset: 0x0043C3F9
		public bool IsNetMode { get; set; }

		// Token: 0x17008BEC RID: 35820
		// (get) Token: 0x0601E47B RID: 124027 RVA: 0x0043E202 File Offset: 0x0043C402
		// (set) Token: 0x0601E47C RID: 124028 RVA: 0x0043E20A File Offset: 0x0043C40A
		public bool IsMale { get; set; }

		// Token: 0x17008BED RID: 35821
		// (get) Token: 0x0601E47D RID: 124029 RVA: 0x0043E213 File Offset: 0x0043C413
		// (set) Token: 0x0601E47E RID: 124030 RVA: 0x0043E21B File Offset: 0x0043C41B
		public bool UseTemp { get; set; }

		// Token: 0x17008BEE RID: 35822
		// (get) Token: 0x0601E47F RID: 124031 RVA: 0x0043E224 File Offset: 0x0043C424
		// (set) Token: 0x0601E480 RID: 124032 RVA: 0x0043E22C File Offset: 0x0043C42C
		public string ServerIp { get; set; }

		// Token: 0x17008BEF RID: 35823
		// (get) Token: 0x0601E481 RID: 124033 RVA: 0x0043E235 File Offset: 0x0043C435
		// (set) Token: 0x0601E482 RID: 124034 RVA: 0x0043E23D File Offset: 0x0043C43D
		public bool IsRelaxMode { get; set; }

		// Token: 0x17008BF0 RID: 35824
		// (get) Token: 0x0601E483 RID: 124035 RVA: 0x0043E246 File Offset: 0x0043C446
		// (set) Token: 0x0601E484 RID: 124036 RVA: 0x0043E24E File Offset: 0x0043C44E
		public int DungeonId { get; set; }

		// Token: 0x17008BF1 RID: 35825
		// (get) Token: 0x0601E485 RID: 124037 RVA: 0x0043E257 File Offset: 0x0043C457
		// (set) Token: 0x0601E486 RID: 124038 RVA: 0x0043E25F File Offset: 0x0043C45F
		public bool IsBornAtCamera { get; set; }

		// Token: 0x17008BF2 RID: 35826
		// (get) Token: 0x0601E487 RID: 124039 RVA: 0x0043E268 File Offset: 0x0043C468
		// (set) Token: 0x0601E488 RID: 124040 RVA: 0x0043E270 File Offset: 0x0043C470
		public bool IsOpenDebugService { get; set; }

		// Token: 0x17008BF3 RID: 35827
		// (get) Token: 0x0601E489 RID: 124041 RVA: 0x0043E279 File Offset: 0x0043C479
		// (set) Token: 0x0601E48A RID: 124042 RVA: 0x0043E281 File Offset: 0x0043C481
		public bool DisableAutoStartServer { get; set; }

		// Token: 0x17008BF4 RID: 35828
		// (get) Token: 0x0601E48B RID: 124043 RVA: 0x0043E28A File Offset: 0x0043C48A
		// (set) Token: 0x0601E48C RID: 124044 RVA: 0x0043E292 File Offset: 0x0043C492
		public bool ReloadEditorConfig { get; set; }

		// Token: 0x17008BF5 RID: 35829
		// (get) Token: 0x0601E48D RID: 124045 RVA: 0x0043E29B File Offset: 0x0043C49B
		// (set) Token: 0x0601E48E RID: 124046 RVA: 0x0043E2A3 File Offset: 0x0043C4A3
		public bool ReloadConfigTable { get; set; }

		// Token: 0x17008BF6 RID: 35830
		// (get) Token: 0x0601E48F RID: 124047 RVA: 0x0043E2AC File Offset: 0x0043C4AC
		// (set) Token: 0x0601E490 RID: 124048 RVA: 0x0043E2B4 File Offset: 0x0043C4B4
		public bool IsLoginByNewUserName { get; set; }

		// Token: 0x17008BF7 RID: 35831
		// (get) Token: 0x0601E491 RID: 124049 RVA: 0x0043E2BD File Offset: 0x0043C4BD
		// (set) Token: 0x0601E492 RID: 124050 RVA: 0x0043E2C5 File Offset: 0x0043C4C5
		public EAccountType AccountType { get; set; }

		// Token: 0x17008BF8 RID: 35832
		// (get) Token: 0x0601E493 RID: 124051 RVA: 0x0043E2CE File Offset: 0x0043C4CE
		// (set) Token: 0x0601E494 RID: 124052 RVA: 0x0043E2D6 File Offset: 0x0043C4D6
		public string GmPathOnLogin { get; set; }

		// Token: 0x17008BF9 RID: 35833
		// (get) Token: 0x0601E495 RID: 124053 RVA: 0x0043E2DF File Offset: 0x0043C4DF
		// (set) Token: 0x0601E496 RID: 124054 RVA: 0x0043E2E7 File Offset: 0x0043C4E7
		public int EditorPort { get; set; }

		// Token: 0x17008BFA RID: 35834
		// (get) Token: 0x0601E497 RID: 124055 RVA: 0x0043E2F0 File Offset: 0x0043C4F0
		// (set) Token: 0x0601E498 RID: 124056 RVA: 0x0043E2F8 File Offset: 0x0043C4F8
		public int GameClientGmPort { get; set; }

		// Token: 0x17008BFB RID: 35835
		// (get) Token: 0x0601E499 RID: 124057 RVA: 0x0043E301 File Offset: 0x0043C501
		// (set) Token: 0x0601E49A RID: 124058 RVA: 0x0043E309 File Offset: 0x0043C509
		public bool IsReLoadArchive { get; set; }

		// Token: 0x17008BFC RID: 35836
		// (get) Token: 0x0601E49B RID: 124059 RVA: 0x0043E312 File Offset: 0x0043C512
		// (set) Token: 0x0601E49C RID: 124060 RVA: 0x0043E31A File Offset: 0x0043C51A
		public int PackageVersion { get; set; }

		// Token: 0x17008BFD RID: 35837
		// (get) Token: 0x0601E49D RID: 124061 RVA: 0x0043E323 File Offset: 0x0043C523
		// (set) Token: 0x0601E49E RID: 124062 RVA: 0x0043E32B File Offset: 0x0043C52B
		public bool IsCustomAttachServerIp { get; set; }

		// Token: 0x17008BFE RID: 35838
		// (get) Token: 0x0601E49F RID: 124063 RVA: 0x0043E334 File Offset: 0x0043C534
		// (set) Token: 0x0601E4A0 RID: 124064 RVA: 0x0043E33C File Offset: 0x0043C53C
		public string AttachServerIp { get; set; }

		// Token: 0x17008BFF RID: 35839
		// (get) Token: 0x0601E4A1 RID: 124065 RVA: 0x0043E345 File Offset: 0x0043C545
		// (set) Token: 0x0601E4A2 RID: 124066 RVA: 0x0043E34D File Offset: 0x0043C54D
		public int AttachPlayerId { get; set; }

		// Token: 0x17008C00 RID: 35840
		// (get) Token: 0x0601E4A3 RID: 124067 RVA: 0x0043E356 File Offset: 0x0043C556
		// (set) Token: 0x0601E4A4 RID: 124068 RVA: 0x0043E35E File Offset: 0x0043C55E
		public bool IsUseMobileStreamingParamsInPie { get; set; }

		// Token: 0x17008C01 RID: 35841
		// (get) Token: 0x0601E4A5 RID: 124069 RVA: 0x0043E367 File Offset: 0x0043C567
		// (set) Token: 0x0601E4A6 RID: 124070 RVA: 0x0043E36F File Offset: 0x0043C56F
		public bool IsUseHighAoi { get; set; }

		// Token: 0x17008C02 RID: 35842
		// (get) Token: 0x0601E4A7 RID: 124071 RVA: 0x0043E378 File Offset: 0x0043C578
		// (set) Token: 0x0601E4A8 RID: 124072 RVA: 0x0043E380 File Offset: 0x0043C580
		public bool IsStayInSubWp { get; set; }

		// Token: 0x17008C03 RID: 35843
		// (get) Token: 0x0601E4A9 RID: 124073 RVA: 0x0043E389 File Offset: 0x0043C589
		// (set) Token: 0x0601E4AA RID: 124074 RVA: 0x0043E391 File Offset: 0x0043C591
		public string CustomPlayerName { get; set; }

		// Token: 0x0601E4AB RID: 124075 RVA: 0x0043E39C File Offset: 0x0043C59C
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
