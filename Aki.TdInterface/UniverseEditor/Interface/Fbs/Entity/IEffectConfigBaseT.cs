using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BED RID: 19437
	public class IEffectConfigBaseT
	{
		// Token: 0x17008995 RID: 35221
		// (get) Token: 0x0601DAF4 RID: 121588 RVA: 0x0042A4BA File Offset: 0x004286BA
		// (set) Token: 0x0601DAF5 RID: 121589 RVA: 0x0042A4C2 File Offset: 0x004286C2
		public EEffectConfigType Type { get; set; }

		// Token: 0x0601DAF6 RID: 121590 RVA: 0x0042A4CB File Offset: 0x004286CB
		public IEffectConfigBaseT()
		{
			this.Type = EEffectConfigType.Death;
		}
	}
}
