using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CEC RID: 19692
	public class ITargetEntityT
	{
		// Token: 0x17008EE7 RID: 36583
		// (get) Token: 0x0601F410 RID: 128016 RVA: 0x0045C8A8 File Offset: 0x0045AAA8
		// (set) Token: 0x0601F411 RID: 128017 RVA: 0x0045C8B0 File Offset: 0x0045AAB0
		public ETargetEntityType Type { get; set; }

		// Token: 0x17008EE8 RID: 36584
		// (get) Token: 0x0601F412 RID: 128018 RVA: 0x0045C8B9 File Offset: 0x0045AAB9
		// (set) Token: 0x0601F413 RID: 128019 RVA: 0x0045C8C1 File Offset: 0x0045AAC1
		public int EntityId { get; set; }

		// Token: 0x0601F414 RID: 128020 RVA: 0x0045C8CA File Offset: 0x0045AACA
		public ITargetEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.EntityId = 0;
		}
	}
}
