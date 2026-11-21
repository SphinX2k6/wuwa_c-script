using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD4 RID: 19668
	public class IEditorStartConfigT
	{
		// Token: 0x17008C3C RID: 35900
		// (get) Token: 0x0601E56B RID: 124267 RVA: 0x004407CB File Offset: 0x0043E9CB
		// (set) Token: 0x0601E56C RID: 124268 RVA: 0x004407D3 File Offset: 0x0043E9D3
		public string Account { get; set; }

		// Token: 0x17008C3D RID: 35901
		// (get) Token: 0x0601E56D RID: 124269 RVA: 0x004407DC File Offset: 0x0043E9DC
		// (set) Token: 0x0601E56E RID: 124270 RVA: 0x004407E4 File Offset: 0x0043E9E4
		public EEditorLoginAccountType LoginAccountType { get; set; }

		// Token: 0x17008C3E RID: 35902
		// (get) Token: 0x0601E56F RID: 124271 RVA: 0x004407ED File Offset: 0x0043E9ED
		// (set) Token: 0x0601E570 RID: 124272 RVA: 0x004407F5 File Offset: 0x0043E9F5
		public string CustomAccount { get; set; }

		// Token: 0x17008C3F RID: 35903
		// (get) Token: 0x0601E571 RID: 124273 RVA: 0x004407FE File Offset: 0x0043E9FE
		// (set) Token: 0x0601E572 RID: 124274 RVA: 0x00440806 File Offset: 0x0043EA06
		public string ArchiveAccount { get; set; }

		// Token: 0x17008C40 RID: 35904
		// (get) Token: 0x0601E573 RID: 124275 RVA: 0x0044080F File Offset: 0x0043EA0F
		// (set) Token: 0x0601E574 RID: 124276 RVA: 0x00440817 File Offset: 0x0043EA17
		public bool IsNetMode { get; set; }

		// Token: 0x17008C41 RID: 35905
		// (get) Token: 0x0601E575 RID: 124277 RVA: 0x00440820 File Offset: 0x0043EA20
		// (set) Token: 0x0601E576 RID: 124278 RVA: 0x00440828 File Offset: 0x0043EA28
		public bool IsMale { get; set; }

		// Token: 0x17008C42 RID: 35906
		// (get) Token: 0x0601E577 RID: 124279 RVA: 0x00440831 File Offset: 0x0043EA31
		// (set) Token: 0x0601E578 RID: 124280 RVA: 0x00440839 File Offset: 0x0043EA39
		public bool UseTemp { get; set; }

		// Token: 0x17008C43 RID: 35907
		// (get) Token: 0x0601E579 RID: 124281 RVA: 0x00440842 File Offset: 0x0043EA42
		// (set) Token: 0x0601E57A RID: 124282 RVA: 0x0044084A File Offset: 0x0043EA4A
		public string ServerIp { get; set; }

		// Token: 0x17008C44 RID: 35908
		// (get) Token: 0x0601E57B RID: 124283 RVA: 0x00440853 File Offset: 0x0043EA53
		// (set) Token: 0x0601E57C RID: 124284 RVA: 0x0044085B File Offset: 0x0043EA5B
		public bool IsRelaxMode { get; set; }

		// Token: 0x17008C45 RID: 35909
		// (get) Token: 0x0601E57D RID: 124285 RVA: 0x00440864 File Offset: 0x0043EA64
		// (set) Token: 0x0601E57E RID: 124286 RVA: 0x0044086C File Offset: 0x0043EA6C
		public int DungeonId { get; set; }

		// Token: 0x17008C46 RID: 35910
		// (get) Token: 0x0601E57F RID: 124287 RVA: 0x00440875 File Offset: 0x0043EA75
		// (set) Token: 0x0601E580 RID: 124288 RVA: 0x0044087D File Offset: 0x0043EA7D
		public bool IsOpenDebugService { get; set; }

		// Token: 0x17008C47 RID: 35911
		// (get) Token: 0x0601E581 RID: 124289 RVA: 0x00440886 File Offset: 0x0043EA86
		// (set) Token: 0x0601E582 RID: 124290 RVA: 0x0044088E File Offset: 0x0043EA8E
		public bool DisableAutoStartServer { get; set; }

		// Token: 0x17008C48 RID: 35912
		// (get) Token: 0x0601E583 RID: 124291 RVA: 0x00440897 File Offset: 0x0043EA97
		// (set) Token: 0x0601E584 RID: 124292 RVA: 0x0044089F File Offset: 0x0043EA9F
		public bool ReloadEditorConfig { get; set; }

		// Token: 0x17008C49 RID: 35913
		// (get) Token: 0x0601E585 RID: 124293 RVA: 0x004408A8 File Offset: 0x0043EAA8
		// (set) Token: 0x0601E586 RID: 124294 RVA: 0x004408B0 File Offset: 0x0043EAB0
		public bool ReloadConfigTable { get; set; }

		// Token: 0x17008C4A RID: 35914
		// (get) Token: 0x0601E587 RID: 124295 RVA: 0x004408B9 File Offset: 0x0043EAB9
		// (set) Token: 0x0601E588 RID: 124296 RVA: 0x004408C1 File Offset: 0x0043EAC1
		public bool IsLoginByNewUserName { get; set; }

		// Token: 0x17008C4B RID: 35915
		// (get) Token: 0x0601E589 RID: 124297 RVA: 0x004408CA File Offset: 0x0043EACA
		// (set) Token: 0x0601E58A RID: 124298 RVA: 0x004408D2 File Offset: 0x0043EAD2
		public EAccountType AccountType { get; set; }

		// Token: 0x17008C4C RID: 35916
		// (get) Token: 0x0601E58B RID: 124299 RVA: 0x004408DB File Offset: 0x0043EADB
		// (set) Token: 0x0601E58C RID: 124300 RVA: 0x004408E3 File Offset: 0x0043EAE3
		public string GmPathOnLogin { get; set; }

		// Token: 0x17008C4D RID: 35917
		// (get) Token: 0x0601E58D RID: 124301 RVA: 0x004408EC File Offset: 0x0043EAEC
		// (set) Token: 0x0601E58E RID: 124302 RVA: 0x004408F4 File Offset: 0x0043EAF4
		public int EditorPort { get; set; }

		// Token: 0x17008C4E RID: 35918
		// (get) Token: 0x0601E58F RID: 124303 RVA: 0x004408FD File Offset: 0x0043EAFD
		// (set) Token: 0x0601E590 RID: 124304 RVA: 0x00440905 File Offset: 0x0043EB05
		public int GameClientGmPort { get; set; }

		// Token: 0x17008C4F RID: 35919
		// (get) Token: 0x0601E591 RID: 124305 RVA: 0x0044090E File Offset: 0x0043EB0E
		// (set) Token: 0x0601E592 RID: 124306 RVA: 0x00440916 File Offset: 0x0043EB16
		public bool IsReLoadArchive { get; set; }

		// Token: 0x17008C50 RID: 35920
		// (get) Token: 0x0601E593 RID: 124307 RVA: 0x0044091F File Offset: 0x0043EB1F
		// (set) Token: 0x0601E594 RID: 124308 RVA: 0x00440927 File Offset: 0x0043EB27
		public int PackageVersion { get; set; }

		// Token: 0x17008C51 RID: 35921
		// (get) Token: 0x0601E595 RID: 124309 RVA: 0x00440930 File Offset: 0x0043EB30
		// (set) Token: 0x0601E596 RID: 124310 RVA: 0x00440938 File Offset: 0x0043EB38
		public bool IsCustomAttachServerIp { get; set; }

		// Token: 0x17008C52 RID: 35922
		// (get) Token: 0x0601E597 RID: 124311 RVA: 0x00440941 File Offset: 0x0043EB41
		// (set) Token: 0x0601E598 RID: 124312 RVA: 0x00440949 File Offset: 0x0043EB49
		public string AttachServerIp { get; set; }

		// Token: 0x17008C53 RID: 35923
		// (get) Token: 0x0601E599 RID: 124313 RVA: 0x00440952 File Offset: 0x0043EB52
		// (set) Token: 0x0601E59A RID: 124314 RVA: 0x0044095A File Offset: 0x0043EB5A
		public int AttachPlayerId { get; set; }

		// Token: 0x17008C54 RID: 35924
		// (get) Token: 0x0601E59B RID: 124315 RVA: 0x00440963 File Offset: 0x0043EB63
		// (set) Token: 0x0601E59C RID: 124316 RVA: 0x0044096B File Offset: 0x0043EB6B
		public bool IsUseMobileStreamingParamsInPie { get; set; }

		// Token: 0x17008C55 RID: 35925
		// (get) Token: 0x0601E59D RID: 124317 RVA: 0x00440974 File Offset: 0x0043EB74
		// (set) Token: 0x0601E59E RID: 124318 RVA: 0x0044097C File Offset: 0x0043EB7C
		public bool IsUseHighAoi { get; set; }

		// Token: 0x17008C56 RID: 35926
		// (get) Token: 0x0601E59F RID: 124319 RVA: 0x00440985 File Offset: 0x0043EB85
		// (set) Token: 0x0601E5A0 RID: 124320 RVA: 0x0044098D File Offset: 0x0043EB8D
		public bool IsStayInSubWp { get; set; }

		// Token: 0x17008C57 RID: 35927
		// (get) Token: 0x0601E5A1 RID: 124321 RVA: 0x00440996 File Offset: 0x0043EB96
		// (set) Token: 0x0601E5A2 RID: 124322 RVA: 0x0044099E File Offset: 0x0043EB9E
		public string CustomPlayerName { get; set; }

		// Token: 0x17008C58 RID: 35928
		// (get) Token: 0x0601E5A3 RID: 124323 RVA: 0x004409A7 File Offset: 0x0043EBA7
		// (set) Token: 0x0601E5A4 RID: 124324 RVA: 0x004409AF File Offset: 0x0043EBAF
		public List<string> SubLevels { get; set; }

		// Token: 0x17008C59 RID: 35929
		// (get) Token: 0x0601E5A5 RID: 124325 RVA: 0x004409B8 File Offset: 0x0043EBB8
		// (set) Token: 0x0601E5A6 RID: 124326 RVA: 0x004409C0 File Offset: 0x0043EBC0
		public List<Record_Int_StringsT> SubLevelsMap { get; set; }

		// Token: 0x17008C5A RID: 35930
		// (get) Token: 0x0601E5A7 RID: 124327 RVA: 0x004409C9 File Offset: 0x0043EBC9
		// (set) Token: 0x0601E5A8 RID: 124328 RVA: 0x004409D1 File Offset: 0x0043EBD1
		public List<Record_Int_IntsT> DataLayers { get; set; }

		// Token: 0x17008C5B RID: 35931
		// (get) Token: 0x0601E5A9 RID: 124329 RVA: 0x004409DA File Offset: 0x0043EBDA
		// (set) Token: 0x0601E5AA RID: 124330 RVA: 0x004409E2 File Offset: 0x0043EBE2
		public List<Record_Int_IDisableEntitiesT> DisableEntities { get; set; }

		// Token: 0x17008C5C RID: 35932
		// (get) Token: 0x0601E5AB RID: 124331 RVA: 0x004409EB File Offset: 0x0043EBEB
		// (set) Token: 0x0601E5AC RID: 124332 RVA: 0x004409F3 File Offset: 0x0043EBF3
		public List<Record_Int_IntT> DungeonIdMap { get; set; }

		// Token: 0x17008C5D RID: 35933
		// (get) Token: 0x0601E5AD RID: 124333 RVA: 0x004409FC File Offset: 0x0043EBFC
		// (set) Token: 0x0601E5AE RID: 124334 RVA: 0x00440A04 File Offset: 0x0043EC04
		public List<int> SkipQuests { get; set; }

		// Token: 0x17008C5E RID: 35934
		// (get) Token: 0x0601E5AF RID: 124335 RVA: 0x00440A0D File Offset: 0x0043EC0D
		// (set) Token: 0x0601E5B0 RID: 124336 RVA: 0x00440A15 File Offset: 0x0043EC15
		public bool IsBornAtCamera { get; set; }

		// Token: 0x17008C5F RID: 35935
		// (get) Token: 0x0601E5B1 RID: 124337 RVA: 0x00440A1E File Offset: 0x0043EC1E
		// (set) Token: 0x0601E5B2 RID: 124338 RVA: 0x00440A26 File Offset: 0x0043EC26
		public bool EnableDeltaReload { get; set; }

		// Token: 0x17008C60 RID: 35936
		// (get) Token: 0x0601E5B3 RID: 124339 RVA: 0x00440A2F File Offset: 0x0043EC2F
		// (set) Token: 0x0601E5B4 RID: 124340 RVA: 0x00440A37 File Offset: 0x0043EC37
		public bool IsSkipQuests { get; set; }

		// Token: 0x17008C61 RID: 35937
		// (get) Token: 0x0601E5B5 RID: 124341 RVA: 0x00440A40 File Offset: 0x0043EC40
		// (set) Token: 0x0601E5B6 RID: 124342 RVA: 0x00440A48 File Offset: 0x0043EC48
		public bool IsUnlockExplore { get; set; }

		// Token: 0x17008C62 RID: 35938
		// (get) Token: 0x0601E5B7 RID: 124343 RVA: 0x00440A51 File Offset: 0x0043EC51
		// (set) Token: 0x0601E5B8 RID: 124344 RVA: 0x00440A59 File Offset: 0x0043EC59
		public bool IsUnlockSpecial { get; set; }

		// Token: 0x17008C63 RID: 35939
		// (get) Token: 0x0601E5B9 RID: 124345 RVA: 0x00440A62 File Offset: 0x0043EC62
		// (set) Token: 0x0601E5BA RID: 124346 RVA: 0x00440A6A File Offset: 0x0043EC6A
		public IPosAT Location { get; set; }

		// Token: 0x17008C64 RID: 35940
		// (get) Token: 0x0601E5BB RID: 124347 RVA: 0x00440A73 File Offset: 0x0043EC73
		// (set) Token: 0x0601E5BC RID: 124348 RVA: 0x00440A7B File Offset: 0x0043EC7B
		public bool EnableAllSystemWithoutPopWin { get; set; }

		// Token: 0x17008C65 RID: 35941
		// (get) Token: 0x0601E5BD RID: 124349 RVA: 0x00440A84 File Offset: 0x0043EC84
		// (set) Token: 0x0601E5BE RID: 124350 RVA: 0x00440A8C File Offset: 0x0043EC8C
		public bool EnableAllTeleportPoints { get; set; }

		// Token: 0x17008C66 RID: 35942
		// (get) Token: 0x0601E5BF RID: 124351 RVA: 0x00440A95 File Offset: 0x0043EC95
		// (set) Token: 0x0601E5C0 RID: 124352 RVA: 0x00440A9D File Offset: 0x0043EC9D
		public bool IsUnlockAllFog { get; set; }

		// Token: 0x17008C67 RID: 35943
		// (get) Token: 0x0601E5C1 RID: 124353 RVA: 0x00440AA6 File Offset: 0x0043ECA6
		// (set) Token: 0x0601E5C2 RID: 124354 RVA: 0x00440AAE File Offset: 0x0043ECAE
		public bool IsDisableTeleportDungeon { get; set; }

		// Token: 0x0601E5C3 RID: 124355 RVA: 0x00440AB8 File Offset: 0x0043ECB8
		public IEditorStartConfigT()
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
			this.SubLevels = null;
			this.SubLevelsMap = null;
			this.DataLayers = null;
			this.DisableEntities = null;
			this.DungeonIdMap = null;
			this.SkipQuests = null;
			this.IsBornAtCamera = false;
			this.EnableDeltaReload = false;
			this.IsSkipQuests = false;
			this.IsUnlockExplore = false;
			this.IsUnlockSpecial = false;
			this.Location = null;
			this.EnableAllSystemWithoutPopWin = false;
			this.EnableAllTeleportPoints = false;
			this.IsUnlockAllFog = false;
			this.IsDisableTeleportDungeon = false;
		}
	}
}
