using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD1 RID: 27345
	public class IModifySelfSceneItemAttributeTagT
	{
		// Token: 0x1700CADB RID: 51931
		// (get) Token: 0x0602FEC8 RID: 196296 RVA: 0x006849E1 File Offset: 0x00682BE1
		// (set) Token: 0x0602FEC9 RID: 196297 RVA: 0x006849E9 File Offset: 0x00682BE9
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700CADC RID: 51932
		// (get) Token: 0x0602FECA RID: 196298 RVA: 0x006849F2 File Offset: 0x00682BF2
		// (set) Token: 0x0602FECB RID: 196299 RVA: 0x006849FA File Offset: 0x00682BFA
		public bool IsAddTag { get; set; }

		// Token: 0x1700CADD RID: 51933
		// (get) Token: 0x0602FECC RID: 196300 RVA: 0x00684A03 File Offset: 0x00682C03
		// (set) Token: 0x0602FECD RID: 196301 RVA: 0x00684A0B File Offset: 0x00682C0B
		public List<int> PerformanceTag { get; set; }

		// Token: 0x0602FECE RID: 196302 RVA: 0x00684A14 File Offset: 0x00682C14
		public IModifySelfSceneItemAttributeTagT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.IsAddTag = false;
			this.PerformanceTag = null;
		}
	}
}
