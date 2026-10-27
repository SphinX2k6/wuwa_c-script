using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200486F RID: 18543
	public class IEditorStartConfigT
	{
		// Token: 0x170085F2 RID: 34290
		// (get) Token: 0x0601CD7A RID: 118138 RVA: 0x00413F23 File Offset: 0x00412123
		// (set) Token: 0x0601CD7B RID: 118139 RVA: 0x00413F2B File Offset: 0x0041212B
		public string Account { get; set; }

		// Token: 0x170085F3 RID: 34291
		// (get) Token: 0x0601CD7C RID: 118140 RVA: 0x00413F34 File Offset: 0x00412134
		// (set) Token: 0x0601CD7D RID: 118141 RVA: 0x00413F3C File Offset: 0x0041213C
		public EEditorLoginAccountType LoginAccountType { get; set; }

		// Token: 0x170085F4 RID: 34292
		// (get) Token: 0x0601CD7E RID: 118142 RVA: 0x00413F45 File Offset: 0x00412145
		// (set) Token: 0x0601CD7F RID: 118143 RVA: 0x00413F4D File Offset: 0x0041214D
		public string CustomAccount { get; set; }

		// Token: 0x170085F5 RID: 34293
		// (get) Token: 0x0601CD80 RID: 118144 RVA: 0x00413F56 File Offset: 0x00412156
		// (set) Token: 0x0601CD81 RID: 118145 RVA: 0x00413F5E File Offset: 0x0041215E
		public string ArchiveAccount { get; set; }

		// Token: 0x170085F6 RID: 34294
		// (get) Token: 0x0601CD82 RID: 118146 RVA: 0x00413F67 File Offset: 0x00412167
		// (set) Token: 0x0601CD83 RID: 118147 RVA: 0x00413F6F File Offset: 0x0041216F
		public bool IsNetMode { get; set; }

		// Token: 0x170085F7 RID: 34295
		// (get) Token: 0x0601CD84 RID: 118148 RVA: 0x00413F78 File Offset: 0x00412178
		// (set) Token: 0x0601CD85 RID: 118149 RVA: 0x00413F80 File Offset: 0x00412180
		public bool IsMale { get; set; }

		// Token: 0x170085F8 RID: 34296
		// (get) Token: 0x0601CD86 RID: 118150 RVA: 0x00413F89 File Offset: 0x00412189
		// (set) Token: 0x0601CD87 RID: 118151 RVA: 0x00413F91 File Offset: 0x00412191
		public bool UseTemp { get; set; }

		// Token: 0x170085F9 RID: 34297
		// (get) Token: 0x0601CD88 RID: 118152 RVA: 0x00413F9A File Offset: 0x0041219A
		// (set) Token: 0x0601CD89 RID: 118153 RVA: 0x00413FA2 File Offset: 0x004121A2
		public string ServerIp { get; set; }

		// Token: 0x170085FA RID: 34298
		// (get) Token: 0x0601CD8A RID: 118154 RVA: 0x00413FAB File Offset: 0x004121AB
		// (set) Token: 0x0601CD8B RID: 118155 RVA: 0x00413FB3 File Offset: 0x004121B3
		public bool IsRelaxMode { get; set; }

		// Token: 0x170085FB RID: 34299
		// (get) Token: 0x0601CD8C RID: 118156 RVA: 0x00413FBC File Offset: 0x004121BC
		// (set) Token: 0x0601CD8D RID: 118157 RVA: 0x00413FC4 File Offset: 0x004121C4
		public int DungeonId { get; set; }

		// Token: 0x170085FC RID: 34300
		// (get) Token: 0x0601CD8E RID: 118158 RVA: 0x00413FCD File Offset: 0x004121CD
		// (set) Token: 0x0601CD8F RID: 118159 RVA: 0x00413FD5 File Offset: 0x004121D5
		public bool IsOpenDebugService { get; set; }

		// Token: 0x170085FD RID: 34301
		// (get) Token: 0x0601CD90 RID: 118160 RVA: 0x00413FDE File Offset: 0x004121DE
		// (set) Token: 0x0601CD91 RID: 118161 RVA: 0x00413FE6 File Offset: 0x004121E6
		public bool DisableAutoStartServer { get; set; }

		// Token: 0x170085FE RID: 34302
		// (get) Token: 0x0601CD92 RID: 118162 RVA: 0x00413FEF File Offset: 0x004121EF
		// (set) Token: 0x0601CD93 RID: 118163 RVA: 0x00413FF7 File Offset: 0x004121F7
		public bool ReloadEditorConfig { get; set; }

		// Token: 0x170085FF RID: 34303
		// (get) Token: 0x0601CD94 RID: 118164 RVA: 0x00414000 File Offset: 0x00412200
		// (set) Token: 0x0601CD95 RID: 118165 RVA: 0x00414008 File Offset: 0x00412208
		public bool ReloadConfigTable { get; set; }

		// Token: 0x17008600 RID: 34304
		// (get) Token: 0x0601CD96 RID: 118166 RVA: 0x00414011 File Offset: 0x00412211
		// (set) Token: 0x0601CD97 RID: 118167 RVA: 0x00414019 File Offset: 0x00412219
		public bool IsLoginByNewUserName { get; set; }

		// Token: 0x17008601 RID: 34305
		// (get) Token: 0x0601CD98 RID: 118168 RVA: 0x00414022 File Offset: 0x00412222
		// (set) Token: 0x0601CD99 RID: 118169 RVA: 0x0041402A File Offset: 0x0041222A
		public EAccountType AccountType { get; set; }

		// Token: 0x17008602 RID: 34306
		// (get) Token: 0x0601CD9A RID: 118170 RVA: 0x00414033 File Offset: 0x00412233
		// (set) Token: 0x0601CD9B RID: 118171 RVA: 0x0041403B File Offset: 0x0041223B
		public string GmPathOnLogin { get; set; }

		// Token: 0x17008603 RID: 34307
		// (get) Token: 0x0601CD9C RID: 118172 RVA: 0x00414044 File Offset: 0x00412244
		// (set) Token: 0x0601CD9D RID: 118173 RVA: 0x0041404C File Offset: 0x0041224C
		public int EditorPort { get; set; }

		// Token: 0x17008604 RID: 34308
		// (get) Token: 0x0601CD9E RID: 118174 RVA: 0x00414055 File Offset: 0x00412255
		// (set) Token: 0x0601CD9F RID: 118175 RVA: 0x0041405D File Offset: 0x0041225D
		public int GameClientGmPort { get; set; }

		// Token: 0x17008605 RID: 34309
		// (get) Token: 0x0601CDA0 RID: 118176 RVA: 0x00414066 File Offset: 0x00412266
		// (set) Token: 0x0601CDA1 RID: 118177 RVA: 0x0041406E File Offset: 0x0041226E
		public bool IsReLoadArchive { get; set; }

		// Token: 0x17008606 RID: 34310
		// (get) Token: 0x0601CDA2 RID: 118178 RVA: 0x00414077 File Offset: 0x00412277
		// (set) Token: 0x0601CDA3 RID: 118179 RVA: 0x0041407F File Offset: 0x0041227F
		public int PackageVersion { get; set; }

		// Token: 0x17008607 RID: 34311
		// (get) Token: 0x0601CDA4 RID: 118180 RVA: 0x00414088 File Offset: 0x00412288
		// (set) Token: 0x0601CDA5 RID: 118181 RVA: 0x00414090 File Offset: 0x00412290
		public bool IsCustomAttachServerIp { get; set; }

		// Token: 0x17008608 RID: 34312
		// (get) Token: 0x0601CDA6 RID: 118182 RVA: 0x00414099 File Offset: 0x00412299
		// (set) Token: 0x0601CDA7 RID: 118183 RVA: 0x004140A1 File Offset: 0x004122A1
		public string AttachServerIp { get; set; }

		// Token: 0x17008609 RID: 34313
		// (get) Token: 0x0601CDA8 RID: 118184 RVA: 0x004140AA File Offset: 0x004122AA
		// (set) Token: 0x0601CDA9 RID: 118185 RVA: 0x004140B2 File Offset: 0x004122B2
		public int AttachPlayerId { get; set; }

		// Token: 0x1700860A RID: 34314
		// (get) Token: 0x0601CDAA RID: 118186 RVA: 0x004140BB File Offset: 0x004122BB
		// (set) Token: 0x0601CDAB RID: 118187 RVA: 0x004140C3 File Offset: 0x004122C3
		public bool IsUseMobileStreamingParamsInPie { get; set; }

		// Token: 0x1700860B RID: 34315
		// (get) Token: 0x0601CDAC RID: 118188 RVA: 0x004140CC File Offset: 0x004122CC
		// (set) Token: 0x0601CDAD RID: 118189 RVA: 0x004140D4 File Offset: 0x004122D4
		public bool IsUseHighAoi { get; set; }

		// Token: 0x1700860C RID: 34316
		// (get) Token: 0x0601CDAE RID: 118190 RVA: 0x004140DD File Offset: 0x004122DD
		// (set) Token: 0x0601CDAF RID: 118191 RVA: 0x004140E5 File Offset: 0x004122E5
		public bool IsStayInSubWp { get; set; }

		// Token: 0x1700860D RID: 34317
		// (get) Token: 0x0601CDB0 RID: 118192 RVA: 0x004140EE File Offset: 0x004122EE
		// (set) Token: 0x0601CDB1 RID: 118193 RVA: 0x004140F6 File Offset: 0x004122F6
		public string CustomPlayerName { get; set; }

		// Token: 0x1700860E RID: 34318
		// (get) Token: 0x0601CDB2 RID: 118194 RVA: 0x004140FF File Offset: 0x004122FF
		// (set) Token: 0x0601CDB3 RID: 118195 RVA: 0x00414107 File Offset: 0x00412307
		public List<string> SubLevels { get; set; }

		// Token: 0x1700860F RID: 34319
		// (get) Token: 0x0601CDB4 RID: 118196 RVA: 0x00414110 File Offset: 0x00412310
		// (set) Token: 0x0601CDB5 RID: 118197 RVA: 0x00414118 File Offset: 0x00412318
		public List<Record_Int_StringsT> SubLevelsMap { get; set; }

		// Token: 0x17008610 RID: 34320
		// (get) Token: 0x0601CDB6 RID: 118198 RVA: 0x00414121 File Offset: 0x00412321
		// (set) Token: 0x0601CDB7 RID: 118199 RVA: 0x00414129 File Offset: 0x00412329
		public List<Record_Int_IntsT> DataLayers { get; set; }

		// Token: 0x17008611 RID: 34321
		// (get) Token: 0x0601CDB8 RID: 118200 RVA: 0x00414132 File Offset: 0x00412332
		// (set) Token: 0x0601CDB9 RID: 118201 RVA: 0x0041413A File Offset: 0x0041233A
		public List<Record_Int_IDisableEntitiesT> DisableEntities { get; set; }

		// Token: 0x17008612 RID: 34322
		// (get) Token: 0x0601CDBA RID: 118202 RVA: 0x00414143 File Offset: 0x00412343
		// (set) Token: 0x0601CDBB RID: 118203 RVA: 0x0041414B File Offset: 0x0041234B
		public List<Record_Int_IntT> DungeonIdMap { get; set; }

		// Token: 0x17008613 RID: 34323
		// (get) Token: 0x0601CDBC RID: 118204 RVA: 0x00414154 File Offset: 0x00412354
		// (set) Token: 0x0601CDBD RID: 118205 RVA: 0x0041415C File Offset: 0x0041235C
		public List<int> SkipQuests { get; set; }

		// Token: 0x17008614 RID: 34324
		// (get) Token: 0x0601CDBE RID: 118206 RVA: 0x00414165 File Offset: 0x00412365
		// (set) Token: 0x0601CDBF RID: 118207 RVA: 0x0041416D File Offset: 0x0041236D
		public bool IsBornAtCamera { get; set; }

		// Token: 0x17008615 RID: 34325
		// (get) Token: 0x0601CDC0 RID: 118208 RVA: 0x00414176 File Offset: 0x00412376
		// (set) Token: 0x0601CDC1 RID: 118209 RVA: 0x0041417E File Offset: 0x0041237E
		public bool EnableDeltaReload { get; set; }

		// Token: 0x17008616 RID: 34326
		// (get) Token: 0x0601CDC2 RID: 118210 RVA: 0x00414187 File Offset: 0x00412387
		// (set) Token: 0x0601CDC3 RID: 118211 RVA: 0x0041418F File Offset: 0x0041238F
		public bool IsSkipQuests { get; set; }

		// Token: 0x17008617 RID: 34327
		// (get) Token: 0x0601CDC4 RID: 118212 RVA: 0x00414198 File Offset: 0x00412398
		// (set) Token: 0x0601CDC5 RID: 118213 RVA: 0x004141A0 File Offset: 0x004123A0
		public bool IsUnlockExplore { get; set; }

		// Token: 0x17008618 RID: 34328
		// (get) Token: 0x0601CDC6 RID: 118214 RVA: 0x004141A9 File Offset: 0x004123A9
		// (set) Token: 0x0601CDC7 RID: 118215 RVA: 0x004141B1 File Offset: 0x004123B1
		public bool IsUnlockSpecial { get; set; }

		// Token: 0x17008619 RID: 34329
		// (get) Token: 0x0601CDC8 RID: 118216 RVA: 0x004141BA File Offset: 0x004123BA
		// (set) Token: 0x0601CDC9 RID: 118217 RVA: 0x004141C2 File Offset: 0x004123C2
		public IPosAT Location { get; set; }

		// Token: 0x1700861A RID: 34330
		// (get) Token: 0x0601CDCA RID: 118218 RVA: 0x004141CB File Offset: 0x004123CB
		// (set) Token: 0x0601CDCB RID: 118219 RVA: 0x004141D3 File Offset: 0x004123D3
		public bool EnableAllSystemWithoutPopWin { get; set; }

		// Token: 0x1700861B RID: 34331
		// (get) Token: 0x0601CDCC RID: 118220 RVA: 0x004141DC File Offset: 0x004123DC
		// (set) Token: 0x0601CDCD RID: 118221 RVA: 0x004141E4 File Offset: 0x004123E4
		public bool EnableAllTeleportPoints { get; set; }

		// Token: 0x1700861C RID: 34332
		// (get) Token: 0x0601CDCE RID: 118222 RVA: 0x004141ED File Offset: 0x004123ED
		// (set) Token: 0x0601CDCF RID: 118223 RVA: 0x004141F5 File Offset: 0x004123F5
		public bool IsUnlockAllFog { get; set; }

		// Token: 0x1700861D RID: 34333
		// (get) Token: 0x0601CDD0 RID: 118224 RVA: 0x004141FE File Offset: 0x004123FE
		// (set) Token: 0x0601CDD1 RID: 118225 RVA: 0x00414206 File Offset: 0x00412406
		public bool IsDisableTeleportDungeon { get; set; }

		// Token: 0x0601CDD2 RID: 118226 RVA: 0x00414210 File Offset: 0x00412410
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
