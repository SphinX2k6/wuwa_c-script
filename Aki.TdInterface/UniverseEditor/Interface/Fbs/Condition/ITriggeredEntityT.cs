using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005203 RID: 20995
	public class ITriggeredEntityT
	{
		// Token: 0x17009646 RID: 38470
		// (get) Token: 0x06021113 RID: 135443 RVA: 0x00491A82 File Offset: 0x0048FC82
		// (set) Token: 0x06021114 RID: 135444 RVA: 0x00491A8A File Offset: 0x0048FC8A
		public ETargetEntityType Type { get; set; }

		// Token: 0x06021115 RID: 135445 RVA: 0x00491A93 File Offset: 0x0048FC93
		public ITriggeredEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
