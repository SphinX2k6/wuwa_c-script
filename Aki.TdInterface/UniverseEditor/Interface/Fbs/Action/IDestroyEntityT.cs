using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF4 RID: 27636
	public class IDestroyEntityT
	{
		// Token: 0x1700CAA2 RID: 51874
		// (get) Token: 0x0602F905 RID: 194821 RVA: 0x0067BB35 File Offset: 0x00679D35
		// (set) Token: 0x0602F906 RID: 194822 RVA: 0x0067BB3D File Offset: 0x00679D3D
		public List<int> EntityIds { get; set; }

		// Token: 0x1700CAA3 RID: 51875
		// (get) Token: 0x0602F907 RID: 194823 RVA: 0x0067BB46 File Offset: 0x00679D46
		// (set) Token: 0x0602F908 RID: 194824 RVA: 0x0067BB4E File Offset: 0x00679D4E
		public bool DelayDestroy { get; set; }

		// Token: 0x1700CAA4 RID: 51876
		// (get) Token: 0x0602F909 RID: 194825 RVA: 0x0067BB57 File Offset: 0x00679D57
		// (set) Token: 0x0602F90A RID: 194826 RVA: 0x0067BB5F File Offset: 0x00679D5F
		public byte NullMask { get; set; }

		// Token: 0x0602F90B RID: 194827 RVA: 0x0067BB68 File Offset: 0x00679D68
		public IDestroyEntityT()
		{
			this.EntityIds = null;
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
