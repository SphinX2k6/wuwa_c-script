using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E3 RID: 25827
	public class ICommonBtActionInfoT
	{
		// Token: 0x1700BE72 RID: 48754
		// (get) Token: 0x0602BEA8 RID: 179880 RVA: 0x005F8B4F File Offset: 0x005F6D4F
		// (set) Token: 0x0602BEA9 RID: 179881 RVA: 0x005F8B57 File Offset: 0x005F6D57
		public int TaskId { get; set; }

		// Token: 0x1700BE73 RID: 48755
		// (get) Token: 0x0602BEAA RID: 179882 RVA: 0x005F8B60 File Offset: 0x005F6D60
		// (set) Token: 0x0602BEAB RID: 179883 RVA: 0x005F8B68 File Offset: 0x005F6D68
		public IActionInfoT Action { get; set; }

		// Token: 0x0602BEAC RID: 179884 RVA: 0x005F8B71 File Offset: 0x005F6D71
		public ICommonBtActionInfoT()
		{
			this.TaskId = 0;
			this.Action = null;
		}
	}
}
