using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007377 RID: 29559
	public class IOpenMotorRaceChallengeResultWithReturnT
	{
		// Token: 0x1700D8DD RID: 55517
		// (get) Token: 0x060339C1 RID: 211393 RVA: 0x006F5257 File Offset: 0x006F3457
		// (set) Token: 0x060339C2 RID: 211394 RVA: 0x006F525F File Offset: 0x006F345F
		public ESystemType Type { get; set; }

		// Token: 0x1700D8DE RID: 55518
		// (get) Token: 0x060339C3 RID: 211395 RVA: 0x006F5268 File Offset: 0x006F3468
		// (set) Token: 0x060339C4 RID: 211396 RVA: 0x006F5270 File Offset: 0x006F3470
		public TVarRefUnion Score { get; set; }

		// Token: 0x1700D8DF RID: 55519
		// (get) Token: 0x060339C5 RID: 211397 RVA: 0x006F5279 File Offset: 0x006F3479
		// (set) Token: 0x060339C6 RID: 211398 RVA: 0x006F5281 File Offset: 0x006F3481
		public int RankS { get; set; }

		// Token: 0x1700D8E0 RID: 55520
		// (get) Token: 0x060339C7 RID: 211399 RVA: 0x006F528A File Offset: 0x006F348A
		// (set) Token: 0x060339C8 RID: 211400 RVA: 0x006F5292 File Offset: 0x006F3492
		public int RankA { get; set; }

		// Token: 0x1700D8E1 RID: 55521
		// (get) Token: 0x060339C9 RID: 211401 RVA: 0x006F529B File Offset: 0x006F349B
		// (set) Token: 0x060339CA RID: 211402 RVA: 0x006F52A3 File Offset: 0x006F34A3
		public int RankB { get; set; }

		// Token: 0x1700D8E2 RID: 55522
		// (get) Token: 0x060339CB RID: 211403 RVA: 0x006F52AC File Offset: 0x006F34AC
		// (set) Token: 0x060339CC RID: 211404 RVA: 0x006F52B4 File Offset: 0x006F34B4
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x060339CD RID: 211405 RVA: 0x006F52BD File Offset: 0x006F34BD
		public IOpenMotorRaceChallengeResultWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Score = null;
			this.RankS = 0;
			this.RankA = 0;
			this.RankB = 0;
			this.ReturnVar = null;
		}
	}
}
