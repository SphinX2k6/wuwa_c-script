using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C10 RID: 27664
	public class IOpenMotorRaceChallengeResultWithReturnT
	{
		// Token: 0x1700CDC2 RID: 52674
		// (get) Token: 0x06030A6D RID: 199277 RVA: 0x0069AF5B File Offset: 0x0069915B
		// (set) Token: 0x06030A6E RID: 199278 RVA: 0x0069AF63 File Offset: 0x00699163
		public ESystemType Type { get; set; }

		// Token: 0x1700CDC3 RID: 52675
		// (get) Token: 0x06030A6F RID: 199279 RVA: 0x0069AF6C File Offset: 0x0069916C
		// (set) Token: 0x06030A70 RID: 199280 RVA: 0x0069AF74 File Offset: 0x00699174
		public TVarRefUnion Score { get; set; }

		// Token: 0x1700CDC4 RID: 52676
		// (get) Token: 0x06030A71 RID: 199281 RVA: 0x0069AF7D File Offset: 0x0069917D
		// (set) Token: 0x06030A72 RID: 199282 RVA: 0x0069AF85 File Offset: 0x00699185
		public int RankS { get; set; }

		// Token: 0x1700CDC5 RID: 52677
		// (get) Token: 0x06030A73 RID: 199283 RVA: 0x0069AF8E File Offset: 0x0069918E
		// (set) Token: 0x06030A74 RID: 199284 RVA: 0x0069AF96 File Offset: 0x00699196
		public int RankA { get; set; }

		// Token: 0x1700CDC6 RID: 52678
		// (get) Token: 0x06030A75 RID: 199285 RVA: 0x0069AF9F File Offset: 0x0069919F
		// (set) Token: 0x06030A76 RID: 199286 RVA: 0x0069AFA7 File Offset: 0x006991A7
		public int RankB { get; set; }

		// Token: 0x1700CDC7 RID: 52679
		// (get) Token: 0x06030A77 RID: 199287 RVA: 0x0069AFB0 File Offset: 0x006991B0
		// (set) Token: 0x06030A78 RID: 199288 RVA: 0x0069AFB8 File Offset: 0x006991B8
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030A79 RID: 199289 RVA: 0x0069AFC1 File Offset: 0x006991C1
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
