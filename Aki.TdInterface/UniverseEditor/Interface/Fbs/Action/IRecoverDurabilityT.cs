using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007592 RID: 30098
	public class IRecoverDurabilityT
	{
		// Token: 0x1700DD59 RID: 56665
		// (get) Token: 0x06034CB8 RID: 216248 RVA: 0x00719426 File Offset: 0x00717626
		// (set) Token: 0x06034CB9 RID: 216249 RVA: 0x0071942E File Offset: 0x0071762E
		public int EntityId { get; set; }

		// Token: 0x06034CBA RID: 216250 RVA: 0x00719437 File Offset: 0x00717637
		public IRecoverDurabilityT()
		{
			this.EntityId = 0;
		}
	}
}
