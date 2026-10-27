using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005797 RID: 22423
	public class IProceduralVisualComponentT
	{
		// Token: 0x1700A73A RID: 42810
		// (get) Token: 0x0602598B RID: 153995 RVA: 0x0052F851 File Offset: 0x0052DA51
		// (set) Token: 0x0602598C RID: 153996 RVA: 0x0052F859 File Offset: 0x0052DA59
		public bool Disabled { get; set; }

		// Token: 0x1700A73B RID: 42811
		// (get) Token: 0x0602598D RID: 153997 RVA: 0x0052F862 File Offset: 0x0052DA62
		// (set) Token: 0x0602598E RID: 153998 RVA: 0x0052F86A File Offset: 0x0052DA6A
		public List<TProceduralVisualUnion> Configs { get; set; }

		// Token: 0x1700A73C RID: 42812
		// (get) Token: 0x0602598F RID: 153999 RVA: 0x0052F873 File Offset: 0x0052DA73
		// (set) Token: 0x06025990 RID: 154000 RVA: 0x0052F87B File Offset: 0x0052DA7B
		public byte NullMask { get; set; }

		// Token: 0x06025991 RID: 154001 RVA: 0x0052F884 File Offset: 0x0052DA84
		public IProceduralVisualComponentT()
		{
			this.Disabled = false;
			this.Configs = null;
			this.NullMask = 0;
		}
	}
}
