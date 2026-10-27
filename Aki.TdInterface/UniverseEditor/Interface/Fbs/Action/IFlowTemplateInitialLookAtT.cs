using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006826 RID: 26662
	public class IFlowTemplateInitialLookAtT
	{
		// Token: 0x1700C610 RID: 50704
		// (get) Token: 0x0602E7B9 RID: 190393 RVA: 0x006580BB File Offset: 0x006562BB
		// (set) Token: 0x0602E7BA RID: 190394 RVA: 0x006580C3 File Offset: 0x006562C3
		public int ActorIndex { get; set; }

		// Token: 0x1700C611 RID: 50705
		// (get) Token: 0x0602E7BB RID: 190395 RVA: 0x006580CC File Offset: 0x006562CC
		// (set) Token: 0x0602E7BC RID: 190396 RVA: 0x006580D4 File Offset: 0x006562D4
		public TActorLookAtDataUnion Target { get; set; }

		// Token: 0x0602E7BD RID: 190397 RVA: 0x006580DD File Offset: 0x006562DD
		public IFlowTemplateInitialLookAtT()
		{
			this.ActorIndex = 0;
			this.Target = null;
		}
	}
}
