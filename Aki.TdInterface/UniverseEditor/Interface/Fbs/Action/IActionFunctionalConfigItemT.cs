using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DD RID: 26333
	public class IActionFunctionalConfigItemT
	{
		// Token: 0x1700BF71 RID: 49009
		// (get) Token: 0x0602C404 RID: 181252 RVA: 0x0060672A File Offset: 0x0060492A
		// (set) Token: 0x0602C405 RID: 181253 RVA: 0x00606732 File Offset: 0x00604932
		public EOnlineParticipateRule OnlineParticipateRule { get; set; }

		// Token: 0x1700BF72 RID: 49010
		// (get) Token: 0x0602C406 RID: 181254 RVA: 0x0060673B File Offset: 0x0060493B
		// (set) Token: 0x0602C407 RID: 181255 RVA: 0x00606743 File Offset: 0x00604943
		public bool IsDetectScreenOccupation { get; set; }

		// Token: 0x1700BF73 RID: 49011
		// (get) Token: 0x0602C408 RID: 181256 RVA: 0x0060674C File Offset: 0x0060494C
		// (set) Token: 0x0602C409 RID: 181257 RVA: 0x00606754 File Offset: 0x00604954
		public bool IsWithResultOnly { get; set; }

		// Token: 0x1700BF74 RID: 49012
		// (get) Token: 0x0602C40A RID: 181258 RVA: 0x0060675D File Offset: 0x0060495D
		// (set) Token: 0x0602C40B RID: 181259 RVA: 0x00606765 File Offset: 0x00604965
		public bool IsOperatePlayer { get; set; }

		// Token: 0x1700BF75 RID: 49013
		// (get) Token: 0x0602C40C RID: 181260 RVA: 0x0060676E File Offset: 0x0060496E
		// (set) Token: 0x0602C40D RID: 181261 RVA: 0x00606776 File Offset: 0x00604976
		public byte NullMask { get; set; }

		// Token: 0x0602C40E RID: 181262 RVA: 0x0060677F File Offset: 0x0060497F
		public IActionFunctionalConfigItemT()
		{
			this.OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer;
			this.IsDetectScreenOccupation = false;
			this.IsWithResultOnly = false;
			this.IsOperatePlayer = false;
			this.NullMask = 0;
		}
	}
}
