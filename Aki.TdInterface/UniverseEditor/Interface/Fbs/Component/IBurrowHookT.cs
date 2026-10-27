using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F44 RID: 20292
	public class IBurrowHookT
	{
		// Token: 0x17009242 RID: 37442
		// (get) Token: 0x06020219 RID: 131609 RVA: 0x0047873F File Offset: 0x0047693F
		// (set) Token: 0x0602021A RID: 131610 RVA: 0x00478747 File Offset: 0x00476947
		public EMechHookConfigType Type { get; set; }

		// Token: 0x17009243 RID: 37443
		// (get) Token: 0x0602021B RID: 131611 RVA: 0x00478750 File Offset: 0x00476950
		// (set) Token: 0x0602021C RID: 131612 RVA: 0x00478758 File Offset: 0x00476958
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x17009244 RID: 37444
		// (get) Token: 0x0602021D RID: 131613 RVA: 0x00478761 File Offset: 0x00476961
		// (set) Token: 0x0602021E RID: 131614 RVA: 0x00478769 File Offset: 0x00476969
		public bool CanInterrupt { get; set; }

		// Token: 0x17009245 RID: 37445
		// (get) Token: 0x0602021F RID: 131615 RVA: 0x00478772 File Offset: 0x00476972
		// (set) Token: 0x06020220 RID: 131616 RVA: 0x0047877A File Offset: 0x0047697A
		public byte NullMask { get; set; }

		// Token: 0x06020221 RID: 131617 RVA: 0x00478783 File Offset: 0x00476983
		public IBurrowHookT()
		{
			this.Type = EMechHookConfigType.BurrowHook;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
