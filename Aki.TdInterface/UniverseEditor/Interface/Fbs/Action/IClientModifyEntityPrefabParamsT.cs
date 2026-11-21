using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4E RID: 27214
	public class IClientModifyEntityPrefabParamsT
	{
		// Token: 0x1700C7F5 RID: 51189
		// (get) Token: 0x0602EAFD RID: 191229 RVA: 0x0065D457 File Offset: 0x0065B657
		// (set) Token: 0x0602EAFE RID: 191230 RVA: 0x0065D45F File Offset: 0x0065B65F
		public EClientExecEntityPrefabOption Type { get; set; }

		// Token: 0x1700C7F6 RID: 51190
		// (get) Token: 0x0602EAFF RID: 191231 RVA: 0x0065D468 File Offset: 0x0065B668
		// (set) Token: 0x0602EB00 RID: 191232 RVA: 0x0065D470 File Offset: 0x0065B670
		public int EntityId { get; set; }

		// Token: 0x1700C7F7 RID: 51191
		// (get) Token: 0x0602EB01 RID: 191233 RVA: 0x0065D479 File Offset: 0x0065B679
		// (set) Token: 0x0602EB02 RID: 191234 RVA: 0x0065D481 File Offset: 0x0065B681
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700C7F8 RID: 51192
		// (get) Token: 0x0602EB03 RID: 191235 RVA: 0x0065D48A File Offset: 0x0065B68A
		// (set) Token: 0x0602EB04 RID: 191236 RVA: 0x0065D492 File Offset: 0x0065B692
		public TParamsPresetUnion Params { get; set; }

		// Token: 0x0602EB05 RID: 191237 RVA: 0x0065D49B File Offset: 0x0065B69B
		public IClientModifyEntityPrefabParamsT()
		{
			this.Type = EClientExecEntityPrefabOption.ModifyPrefabParams;
			this.EntityId = 0;
			this.ReferenceActorKey = null;
			this.Params = null;
		}
	}
}
