using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A86 RID: 27270
	public class IMechStuntT
	{
		// Token: 0x1700CA79 RID: 51833
		// (get) Token: 0x0602FCAE RID: 195758 RVA: 0x00681049 File Offset: 0x0067F249
		// (set) Token: 0x0602FCAF RID: 195759 RVA: 0x00681051 File Offset: 0x0067F251
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CA7A RID: 51834
		// (get) Token: 0x0602FCB0 RID: 195760 RVA: 0x0068105A File Offset: 0x0067F25A
		// (set) Token: 0x0602FCB1 RID: 195761 RVA: 0x00681062 File Offset: 0x0067F262
		public TMechStuntConfigUnion StuntConfig { get; set; }

		// Token: 0x1700CA7B RID: 51835
		// (get) Token: 0x0602FCB2 RID: 195762 RVA: 0x0068106B File Offset: 0x0067F26B
		// (set) Token: 0x0602FCB3 RID: 195763 RVA: 0x00681073 File Offset: 0x0067F273
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700CA7C RID: 51836
		// (get) Token: 0x0602FCB4 RID: 195764 RVA: 0x0068107C File Offset: 0x0067F27C
		// (set) Token: 0x0602FCB5 RID: 195765 RVA: 0x00681084 File Offset: 0x0067F284
		public bool CanInterrupt { get; set; }

		// Token: 0x1700CA7D RID: 51837
		// (get) Token: 0x0602FCB6 RID: 195766 RVA: 0x0068108D File Offset: 0x0067F28D
		// (set) Token: 0x0602FCB7 RID: 195767 RVA: 0x00681095 File Offset: 0x0067F295
		public byte NullMask { get; set; }

		// Token: 0x0602FCB8 RID: 195768 RVA: 0x0068109E File Offset: 0x0067F29E
		public IMechStuntT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.StuntConfig = null;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
