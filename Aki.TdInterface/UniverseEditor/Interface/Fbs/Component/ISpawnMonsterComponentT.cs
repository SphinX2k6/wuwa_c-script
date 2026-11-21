using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5B RID: 24411
	public class ISpawnMonsterComponentT
	{
		// Token: 0x1700B4C8 RID: 46280
		// (get) Token: 0x06029070 RID: 168048 RVA: 0x0059ABC1 File Offset: 0x00598DC1
		// (set) Token: 0x06029071 RID: 168049 RVA: 0x0059ABC9 File Offset: 0x00598DC9
		public bool Disabled { get; set; }

		// Token: 0x1700B4C9 RID: 46281
		// (get) Token: 0x06029072 RID: 168050 RVA: 0x0059ABD2 File Offset: 0x00598DD2
		// (set) Token: 0x06029073 RID: 168051 RVA: 0x0059ABDA File Offset: 0x00598DDA
		public TSpawnMonsterStartConditionUnion ActiveType { get; set; }

		// Token: 0x1700B4CA RID: 46282
		// (get) Token: 0x06029074 RID: 168052 RVA: 0x0059ABE3 File Offset: 0x00598DE3
		// (set) Token: 0x06029075 RID: 168053 RVA: 0x0059ABEB File Offset: 0x00598DEB
		public List<ISpawnMonsterConfigT> SpawnMonsterConfigs { get; set; }

		// Token: 0x1700B4CB RID: 46283
		// (get) Token: 0x06029076 RID: 168054 RVA: 0x0059ABF4 File Offset: 0x00598DF4
		// (set) Token: 0x06029077 RID: 168055 RVA: 0x0059ABFC File Offset: 0x00598DFC
		public bool IssharedHatred { get; set; }

		// Token: 0x1700B4CC RID: 46284
		// (get) Token: 0x06029078 RID: 168056 RVA: 0x0059AC05 File Offset: 0x00598E05
		// (set) Token: 0x06029079 RID: 168057 RVA: 0x0059AC0D File Offset: 0x00598E0D
		public ISpawnMonsterConstraintAnnularSectorT SpawnMonsterConstraintType { get; set; }

		// Token: 0x1700B4CD RID: 46285
		// (get) Token: 0x0602907A RID: 168058 RVA: 0x0059AC16 File Offset: 0x00598E16
		// (set) Token: 0x0602907B RID: 168059 RVA: 0x0059AC1E File Offset: 0x00598E1E
		public byte NullMask { get; set; }

		// Token: 0x0602907C RID: 168060 RVA: 0x0059AC27 File Offset: 0x00598E27
		public ISpawnMonsterComponentT()
		{
			this.Disabled = false;
			this.ActiveType = null;
			this.SpawnMonsterConfigs = null;
			this.IssharedHatred = false;
			this.SpawnMonsterConstraintType = null;
			this.NullMask = 0;
		}
	}
}
