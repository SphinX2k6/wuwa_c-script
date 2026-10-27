using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C5 RID: 21189
	public class IFoxJumpInteractPointRelationTypeT
	{
		// Token: 0x17009B69 RID: 39785
		// (get) Token: 0x06022903 RID: 141571 RVA: 0x004CA7AC File Offset: 0x004C89AC
		// (set) Token: 0x06022904 RID: 141572 RVA: 0x004CA7B4 File Offset: 0x004C89B4
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x17009B6A RID: 39786
		// (get) Token: 0x06022905 RID: 141573 RVA: 0x004CA7BD File Offset: 0x004C89BD
		// (set) Token: 0x06022906 RID: 141574 RVA: 0x004CA7C5 File Offset: 0x004C89C5
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17009B6B RID: 39787
		// (get) Token: 0x06022907 RID: 141575 RVA: 0x004CA7CE File Offset: 0x004C89CE
		// (set) Token: 0x06022908 RID: 141576 RVA: 0x004CA7D6 File Offset: 0x004C89D6
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x06022909 RID: 141577 RVA: 0x004CA7DF File Offset: 0x004C89DF
		public IFoxJumpInteractPointRelationTypeT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
		}
	}
}
