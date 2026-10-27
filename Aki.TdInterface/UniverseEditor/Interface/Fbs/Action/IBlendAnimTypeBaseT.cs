using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200620D RID: 25101
	public class IBlendAnimTypeBaseT
	{
		// Token: 0x1700BB17 RID: 47895
		// (get) Token: 0x0602B451 RID: 177233 RVA: 0x005F5DDA File Offset: 0x005F3FDA
		// (set) Token: 0x0602B452 RID: 177234 RVA: 0x005F5DE2 File Offset: 0x005F3FE2
		public EBlendAnimType Type { get; set; }

		// Token: 0x0602B453 RID: 177235 RVA: 0x005F5DEB File Offset: 0x005F3FEB
		public IBlendAnimTypeBaseT()
		{
			this.Type = EBlendAnimType.StateMachine;
		}
	}
}
