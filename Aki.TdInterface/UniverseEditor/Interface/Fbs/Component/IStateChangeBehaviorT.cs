using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599F RID: 22943
	public class IStateChangeBehaviorT
	{
		// Token: 0x1700AC2F RID: 44079
		// (get) Token: 0x06026DD2 RID: 159186 RVA: 0x00559493 File Offset: 0x00557693
		// (set) Token: 0x06026DD3 RID: 159187 RVA: 0x0055949B File Offset: 0x0055769B
		public string State { get; set; }

		// Token: 0x1700AC30 RID: 44080
		// (get) Token: 0x06026DD4 RID: 159188 RVA: 0x005594A4 File Offset: 0x005576A4
		// (set) Token: 0x06026DD5 RID: 159189 RVA: 0x005594AC File Offset: 0x005576AC
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x1700AC31 RID: 44081
		// (get) Token: 0x06026DD6 RID: 159190 RVA: 0x005594B5 File Offset: 0x005576B5
		// (set) Token: 0x06026DD7 RID: 159191 RVA: 0x005594BD File Offset: 0x005576BD
		public IDelayChangeStateT DelayChangeState { get; set; }

		// Token: 0x1700AC32 RID: 44082
		// (get) Token: 0x06026DD8 RID: 159192 RVA: 0x005594C6 File Offset: 0x005576C6
		// (set) Token: 0x06026DD9 RID: 159193 RVA: 0x005594CE File Offset: 0x005576CE
		public bool PendingConditionAvailable { get; set; }

		// Token: 0x1700AC33 RID: 44083
		// (get) Token: 0x06026DDA RID: 159194 RVA: 0x005594D7 File Offset: 0x005576D7
		// (set) Token: 0x06026DDB RID: 159195 RVA: 0x005594DF File Offset: 0x005576DF
		public List<IConditionActionT> ConditionAction { get; set; }

		// Token: 0x1700AC34 RID: 44084
		// (get) Token: 0x06026DDC RID: 159196 RVA: 0x005594E8 File Offset: 0x005576E8
		// (set) Token: 0x06026DDD RID: 159197 RVA: 0x005594F0 File Offset: 0x005576F0
		public byte NullMask { get; set; }

		// Token: 0x06026DDE RID: 159198 RVA: 0x005594F9 File Offset: 0x005576F9
		public IStateChangeBehaviorT()
		{
			this.State = null;
			this.Action = null;
			this.DelayChangeState = null;
			this.PendingConditionAvailable = false;
			this.ConditionAction = null;
			this.NullMask = 0;
		}
	}
}
