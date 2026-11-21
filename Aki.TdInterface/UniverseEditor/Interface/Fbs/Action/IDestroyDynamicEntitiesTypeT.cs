using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEE RID: 27630
	public class IDestroyDynamicEntitiesTypeT
	{
		// Token: 0x1700CA9B RID: 51867
		// (get) Token: 0x0602F8DB RID: 194779 RVA: 0x0067B6CA File Offset: 0x006798CA
		// (set) Token: 0x0602F8DC RID: 194780 RVA: 0x0067B6D2 File Offset: 0x006798D2
		public EDynamicEntityType Type { get; set; }

		// Token: 0x0602F8DD RID: 194781 RVA: 0x0067B6DB File Offset: 0x006798DB
		public IDestroyDynamicEntitiesTypeT()
		{
			this.Type = EDynamicEntityType.VisionDisplay;
		}
	}
}
