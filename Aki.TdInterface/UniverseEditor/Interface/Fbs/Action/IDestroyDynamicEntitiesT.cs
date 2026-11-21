using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEB RID: 27627
	public class IDestroyDynamicEntitiesT
	{
		// Token: 0x1700CA98 RID: 51864
		// (get) Token: 0x0602F8C9 RID: 194761 RVA: 0x0067B53D File Offset: 0x0067973D
		// (set) Token: 0x0602F8CA RID: 194762 RVA: 0x0067B545 File Offset: 0x00679745
		public IDestroyVisionDisplayT DestroyEntitiesConfig { get; set; }

		// Token: 0x0602F8CB RID: 194763 RVA: 0x0067B54E File Offset: 0x0067974E
		public IDestroyDynamicEntitiesT()
		{
			this.DestroyEntitiesConfig = null;
		}
	}
}
