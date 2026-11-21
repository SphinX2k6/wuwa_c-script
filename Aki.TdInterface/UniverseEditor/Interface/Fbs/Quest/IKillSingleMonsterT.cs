using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430B RID: 17163
	public class IKillSingleMonsterT
	{
		// Token: 0x17007591 RID: 30097
		// (get) Token: 0x0601822E RID: 98862 RVA: 0x003719FC File Offset: 0x0036FBFC
		// (set) Token: 0x0601822F RID: 98863 RVA: 0x00371A04 File Offset: 0x0036FC04
		public int EntityId { get; set; }

		// Token: 0x17007592 RID: 30098
		// (get) Token: 0x06018230 RID: 98864 RVA: 0x00371A0D File Offset: 0x0036FC0D
		// (set) Token: 0x06018231 RID: 98865 RVA: 0x00371A15 File Offset: 0x0036FC15
		public int AddTime { get; set; }

		// Token: 0x06018232 RID: 98866 RVA: 0x00371A1E File Offset: 0x0036FC1E
		public IKillSingleMonsterT()
		{
			this.EntityId = 0;
			this.AddTime = 0;
		}
	}
}
