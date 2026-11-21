using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A95 RID: 31381
	public class ITalkItemAutoPlayConfigT
	{
		// Token: 0x1700E61D RID: 58909
		// (get) Token: 0x060375F6 RID: 226806 RVA: 0x00765D25 File Offset: 0x00763F25
		// (set) Token: 0x060375F7 RID: 226807 RVA: 0x00765D2D File Offset: 0x00763F2D
		public ITalkItemDisableAutoSelectOptionGroupT DisableAutoSelectOptionGroup { get; set; }

		// Token: 0x060375F8 RID: 226808 RVA: 0x00765D36 File Offset: 0x00763F36
		public ITalkItemAutoPlayConfigT()
		{
			this.DisableAutoSelectOptionGroup = null;
		}
	}
}
