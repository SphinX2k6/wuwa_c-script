using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043EF RID: 17391
	public class IPositionRollbackConfigT
	{
		// Token: 0x170077D4 RID: 30676
		// (get) Token: 0x06018B69 RID: 101225 RVA: 0x00385DD5 File Offset: 0x00383FD5
		// (set) Token: 0x06018B6A RID: 101226 RVA: 0x00385DDD File Offset: 0x00383FDD
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x170077D5 RID: 30677
		// (get) Token: 0x06018B6B RID: 101227 RVA: 0x00385DE6 File Offset: 0x00383FE6
		// (set) Token: 0x06018B6C RID: 101228 RVA: 0x00385DEE File Offset: 0x00383FEE
		public int CheckRange { get; set; }

		// Token: 0x170077D6 RID: 30678
		// (get) Token: 0x06018B6D RID: 101229 RVA: 0x00385DF7 File Offset: 0x00383FF7
		// (set) Token: 0x06018B6E RID: 101230 RVA: 0x00385DFF File Offset: 0x00383FFF
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT Position { get; set; }

		// Token: 0x06018B6F RID: 101231 RVA: 0x00385E08 File Offset: 0x00384008
		public IPositionRollbackConfigT()
		{
			this.CheckPoint = null;
			this.CheckRange = 0;
			this.Position = null;
		}
	}
}
