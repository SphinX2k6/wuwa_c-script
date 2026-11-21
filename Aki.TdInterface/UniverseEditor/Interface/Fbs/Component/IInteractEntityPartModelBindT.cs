using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D0 RID: 22992
	public class IInteractEntityPartModelBindT
	{
		// Token: 0x1700A71A RID: 42778
		// (get) Token: 0x0602588B RID: 153739 RVA: 0x00526397 File Offset: 0x00524597
		// (set) Token: 0x0602588C RID: 153740 RVA: 0x0052639F File Offset: 0x0052459F
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x1700A71B RID: 42779
		// (get) Token: 0x0602588D RID: 153741 RVA: 0x005263A8 File Offset: 0x005245A8
		// (set) Token: 0x0602588E RID: 153742 RVA: 0x005263B0 File Offset: 0x005245B0
		public List<IInteractEntityPartModelOptionPointT> OptionPoints { get; set; }

		// Token: 0x0602588F RID: 153743 RVA: 0x005263B9 File Offset: 0x005245B9
		public IInteractEntityPartModelBindT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
			this.OptionPoints = null;
		}
	}
}
