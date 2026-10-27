using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006285 RID: 25221
	public class ICameraLockTargetBaseT
	{
		// Token: 0x1700BC1A RID: 48154
		// (get) Token: 0x0602B8DD RID: 178397 RVA: 0x005FF16E File Offset: 0x005FD36E
		// (set) Token: 0x0602B8DE RID: 178398 RVA: 0x005FF176 File Offset: 0x005FD376
		public ECameraLockTargetType Type { get; set; }

		// Token: 0x0602B8DF RID: 178399 RVA: 0x005FF17F File Offset: 0x005FD37F
		public ICameraLockTargetBaseT()
		{
			this.Type = ECameraLockTargetType.TargetPosition;
		}
	}
}
