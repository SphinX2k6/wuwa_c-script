using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E8 RID: 20968
	public class ITargetEntityT
	{
		// Token: 0x17009620 RID: 38432
		// (get) Token: 0x06021055 RID: 135253 RVA: 0x004907F8 File Offset: 0x0048E9F8
		// (set) Token: 0x06021056 RID: 135254 RVA: 0x00490800 File Offset: 0x0048EA00
		public ETargetEntityType Type { get; set; }

		// Token: 0x17009621 RID: 38433
		// (get) Token: 0x06021057 RID: 135255 RVA: 0x00490809 File Offset: 0x0048EA09
		// (set) Token: 0x06021058 RID: 135256 RVA: 0x00490811 File Offset: 0x0048EA11
		public int EntityId { get; set; }

		// Token: 0x06021059 RID: 135257 RVA: 0x0049081A File Offset: 0x0048EA1A
		public ITargetEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.EntityId = 0;
		}
	}
}
