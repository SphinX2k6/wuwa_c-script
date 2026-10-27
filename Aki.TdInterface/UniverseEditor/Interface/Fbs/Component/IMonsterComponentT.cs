using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005573 RID: 21875
	public class IMonsterComponentT
	{
		// Token: 0x1700A19F RID: 41375
		// (get) Token: 0x0602431F RID: 148255 RVA: 0x004FFCF9 File Offset: 0x004FDEF9
		// (set) Token: 0x06024320 RID: 148256 RVA: 0x004FFD01 File Offset: 0x004FDF01
		public bool Disabled { get; set; }

		// Token: 0x1700A1A0 RID: 41376
		// (get) Token: 0x06024321 RID: 148257 RVA: 0x004FFD0A File Offset: 0x004FDF0A
		// (set) Token: 0x06024322 RID: 148258 RVA: 0x004FFD12 File Offset: 0x004FDF12
		public int FightConfigId { get; set; }

		// Token: 0x1700A1A1 RID: 41377
		// (get) Token: 0x06024323 RID: 148259 RVA: 0x004FFD1B File Offset: 0x004FDF1B
		// (set) Token: 0x06024324 RID: 148260 RVA: 0x004FFD23 File Offset: 0x004FDF23
		public IBossStateViewConfigT BossViewConfig { get; set; }

		// Token: 0x1700A1A2 RID: 41378
		// (get) Token: 0x06024325 RID: 148261 RVA: 0x004FFD2C File Offset: 0x004FDF2C
		// (set) Token: 0x06024326 RID: 148262 RVA: 0x004FFD34 File Offset: 0x004FDF34
		public List<string> InitGasTag { get; set; }

		// Token: 0x1700A1A3 RID: 41379
		// (get) Token: 0x06024327 RID: 148263 RVA: 0x004FFD3D File Offset: 0x004FDF3D
		// (set) Token: 0x06024328 RID: 148264 RVA: 0x004FFD45 File Offset: 0x004FDF45
		public int SpecialHateAndSenseConfig { get; set; }

		// Token: 0x1700A1A4 RID: 41380
		// (get) Token: 0x06024329 RID: 148265 RVA: 0x004FFD4E File Offset: 0x004FDF4E
		// (set) Token: 0x0602432A RID: 148266 RVA: 0x004FFD56 File Offset: 0x004FDF56
		public IMonsterPerformConfigT PerformConfig { get; set; }

		// Token: 0x1700A1A5 RID: 41381
		// (get) Token: 0x0602432B RID: 148267 RVA: 0x004FFD5F File Offset: 0x004FDF5F
		// (set) Token: 0x0602432C RID: 148268 RVA: 0x004FFD67 File Offset: 0x004FDF67
		public List<int> ShareLifeSubMonsterIds { get; set; }

		// Token: 0x1700A1A6 RID: 41382
		// (get) Token: 0x0602432D RID: 148269 RVA: 0x004FFD70 File Offset: 0x004FDF70
		// (set) Token: 0x0602432E RID: 148270 RVA: 0x004FFD78 File Offset: 0x004FDF78
		public int LifeMaxCustomizationId { get; set; }

		// Token: 0x1700A1A7 RID: 41383
		// (get) Token: 0x0602432F RID: 148271 RVA: 0x004FFD81 File Offset: 0x004FDF81
		// (set) Token: 0x06024330 RID: 148272 RVA: 0x004FFD89 File Offset: 0x004FDF89
		public IMonsterNpcInteractionEnableConfigT EnableMonsterNpcInteraction { get; set; }

		// Token: 0x1700A1A8 RID: 41384
		// (get) Token: 0x06024331 RID: 148273 RVA: 0x004FFD92 File Offset: 0x004FDF92
		// (set) Token: 0x06024332 RID: 148274 RVA: 0x004FFD9A File Offset: 0x004FDF9A
		public IMonsterCommunicationGroupConfigT MonsterCommunicationGroup { get; set; }

		// Token: 0x1700A1A9 RID: 41385
		// (get) Token: 0x06024333 RID: 148275 RVA: 0x004FFDA3 File Offset: 0x004FDFA3
		// (set) Token: 0x06024334 RID: 148276 RVA: 0x004FFDAB File Offset: 0x004FDFAB
		public byte NullMask { get; set; }

		// Token: 0x06024335 RID: 148277 RVA: 0x004FFDB4 File Offset: 0x004FDFB4
		public IMonsterComponentT()
		{
			this.Disabled = false;
			this.FightConfigId = 0;
			this.BossViewConfig = null;
			this.InitGasTag = null;
			this.SpecialHateAndSenseConfig = 0;
			this.PerformConfig = null;
			this.ShareLifeSubMonsterIds = null;
			this.LifeMaxCustomizationId = 0;
			this.EnableMonsterNpcInteraction = null;
			this.MonsterCommunicationGroup = null;
			this.NullMask = 0;
		}
	}
}
