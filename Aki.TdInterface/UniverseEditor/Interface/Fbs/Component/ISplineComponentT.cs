using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005981 RID: 22913
	public class ISplineComponentT
	{
		// Token: 0x1700ABF0 RID: 44016
		// (get) Token: 0x06026CB6 RID: 158902 RVA: 0x005572D1 File Offset: 0x005554D1
		// (set) Token: 0x06026CB7 RID: 158903 RVA: 0x005572D9 File Offset: 0x005554D9
		public bool Disabled { get; set; }

		// Token: 0x1700ABF1 RID: 44017
		// (get) Token: 0x06026CB8 RID: 158904 RVA: 0x005572E2 File Offset: 0x005554E2
		// (set) Token: 0x06026CB9 RID: 158905 RVA: 0x005572EA File Offset: 0x005554EA
		public TSplineOptionUnion Option { get; set; }

		// Token: 0x1700ABF2 RID: 44018
		// (get) Token: 0x06026CBA RID: 158906 RVA: 0x005572F3 File Offset: 0x005554F3
		// (set) Token: 0x06026CBB RID: 158907 RVA: 0x005572FB File Offset: 0x005554FB
		public byte NullMask { get; set; }

		// Token: 0x06026CBC RID: 158908 RVA: 0x00557304 File Offset: 0x00555504
		public ISplineComponentT()
		{
			this.Disabled = false;
			this.Option = null;
			this.NullMask = 0;
		}
	}
}
