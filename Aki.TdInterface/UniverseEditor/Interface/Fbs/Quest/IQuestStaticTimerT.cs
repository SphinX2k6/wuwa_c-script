using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448B RID: 17547
	public class IQuestStaticTimerT
	{
		// Token: 0x170079D8 RID: 31192
		// (get) Token: 0x060193FE RID: 103422 RVA: 0x0039A2FD File Offset: 0x003984FD
		// (set) Token: 0x060193FF RID: 103423 RVA: 0x0039A305 File Offset: 0x00398505
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170079D9 RID: 31193
		// (get) Token: 0x06019400 RID: 103424 RVA: 0x0039A30E File Offset: 0x0039850E
		// (set) Token: 0x06019401 RID: 103425 RVA: 0x0039A316 File Offset: 0x00398516
		public TVarRefUnion Var { get; set; }

		// Token: 0x170079DA RID: 31194
		// (get) Token: 0x06019402 RID: 103426 RVA: 0x0039A31F File Offset: 0x0039851F
		// (set) Token: 0x06019403 RID: 103427 RVA: 0x0039A327 File Offset: 0x00398527
		public ETimerType TimerType { get; set; }

		// Token: 0x06019404 RID: 103428 RVA: 0x0039A330 File Offset: 0x00398530
		public IQuestStaticTimerT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.TimerType = ETimerType.CountDownChallenge;
		}
	}
}
