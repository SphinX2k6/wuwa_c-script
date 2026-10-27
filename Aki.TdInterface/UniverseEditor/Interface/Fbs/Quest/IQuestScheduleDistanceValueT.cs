using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004020 RID: 16416
	public class IQuestScheduleDistanceValueT
	{
		// Token: 0x17007375 RID: 29557
		// (get) Token: 0x06017B91 RID: 97169 RVA: 0x0036C0A9 File Offset: 0x0036A2A9
		// (set) Token: 0x06017B92 RID: 97170 RVA: 0x0036C0B1 File Offset: 0x0036A2B1
		public EQuestScheduleType Type { get; set; }

		// Token: 0x17007376 RID: 29558
		// (get) Token: 0x06017B93 RID: 97171 RVA: 0x0036C0BA File Offset: 0x0036A2BA
		// (set) Token: 0x06017B94 RID: 97172 RVA: 0x0036C0C2 File Offset: 0x0036A2C2
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosAT Pos { get; set; }

		// Token: 0x17007377 RID: 29559
		// (get) Token: 0x06017B95 RID: 97173 RVA: 0x0036C0CB File Offset: 0x0036A2CB
		// (set) Token: 0x06017B96 RID: 97174 RVA: 0x0036C0D3 File Offset: 0x0036A2D3
		public EDistanceMeasureMode DistanceMeasureMode { get; set; }

		// Token: 0x06017B97 RID: 97175 RVA: 0x0036C0DC File Offset: 0x0036A2DC
		public IQuestScheduleDistanceValueT()
		{
			this.Type = EQuestScheduleType.None;
			this.Pos = null;
			this.DistanceMeasureMode = EDistanceMeasureMode.Horizontal;
		}
	}
}
