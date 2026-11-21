using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C3 RID: 29379
	public class IMp4FrameEventT
	{
		// Token: 0x1700D76E RID: 55150
		// (get) Token: 0x06033385 RID: 209797 RVA: 0x006E92EB File Offset: 0x006E74EB
		// (set) Token: 0x06033386 RID: 209798 RVA: 0x006E92F3 File Offset: 0x006E74F3
		public float Second { get; set; }

		// Token: 0x1700D76F RID: 55151
		// (get) Token: 0x06033387 RID: 209799 RVA: 0x006E92FC File Offset: 0x006E74FC
		// (set) Token: 0x06033388 RID: 209800 RVA: 0x006E9304 File Offset: 0x006E7504
		public List<IActionInfoT> EventActions { get; set; }

		// Token: 0x06033389 RID: 209801 RVA: 0x006E930D File Offset: 0x006E750D
		public IMp4FrameEventT()
		{
			this.Second = 0f;
			this.EventActions = null;
		}
	}
}
