using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004555 RID: 17749
	public class IRollBlockBlockTemplateT
	{
		// Token: 0x17007DE7 RID: 32231
		// (get) Token: 0x0601AB6F RID: 109423 RVA: 0x003CF3A4 File Offset: 0x003CD5A4
		// (set) Token: 0x0601AB70 RID: 109424 RVA: 0x003CF3AC File Offset: 0x003CD5AC
		public ERollBlockBlockType BlockType { get; set; }

		// Token: 0x17007DE8 RID: 32232
		// (get) Token: 0x0601AB71 RID: 109425 RVA: 0x003CF3B5 File Offset: 0x003CD5B5
		// (set) Token: 0x0601AB72 RID: 109426 RVA: 0x003CF3BD File Offset: 0x003CD5BD
		public string TemplateId { get; set; }

		// Token: 0x17007DE9 RID: 32233
		// (get) Token: 0x0601AB73 RID: 109427 RVA: 0x003CF3C6 File Offset: 0x003CD5C6
		// (set) Token: 0x0601AB74 RID: 109428 RVA: 0x003CF3CE File Offset: 0x003CD5CE
		public string PhantomTemplateId { get; set; }

		// Token: 0x17007DEA RID: 32234
		// (get) Token: 0x0601AB75 RID: 109429 RVA: 0x003CF3D7 File Offset: 0x003CD5D7
		// (set) Token: 0x0601AB76 RID: 109430 RVA: 0x003CF3DF File Offset: 0x003CD5DF
		public IVectorInfoT Size { get; set; }

		// Token: 0x0601AB77 RID: 109431 RVA: 0x003CF3E8 File Offset: 0x003CD5E8
		public IRollBlockBlockTemplateT()
		{
			this.BlockType = ERollBlockBlockType.Block1;
			this.TemplateId = null;
			this.PhantomTemplateId = null;
			this.Size = null;
		}
	}
}
