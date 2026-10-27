using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF2 RID: 19698
	public class ITargetEntityTypeT
	{
		// Token: 0x17008EF2 RID: 36594
		// (get) Token: 0x0601F43E RID: 128062 RVA: 0x0045CCD6 File Offset: 0x0045AED6
		// (set) Token: 0x0601F43F RID: 128063 RVA: 0x0045CCDE File Offset: 0x0045AEDE
		public ETargetEntityType Type { get; set; }

		// Token: 0x0601F440 RID: 128064 RVA: 0x0045CCE7 File Offset: 0x0045AEE7
		public ITargetEntityTypeT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
