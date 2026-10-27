using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005091 RID: 20625
	public class IDollComboCameraT
	{
		// Token: 0x170095CC RID: 38348
		// (get) Token: 0x060211B5 RID: 135605 RVA: 0x00499AF7 File Offset: 0x00497CF7
		// (set) Token: 0x060211B6 RID: 135606 RVA: 0x00499AFF File Offset: 0x00497CFF
		public float Fov { get; set; }

		// Token: 0x170095CD RID: 38349
		// (get) Token: 0x060211B7 RID: 135607 RVA: 0x00499B08 File Offset: 0x00497D08
		// (set) Token: 0x060211B8 RID: 135608 RVA: 0x00499B10 File Offset: 0x00497D10
		public List<IDollComboCameraConfigT> ComboCameras { get; set; }

		// Token: 0x060211B9 RID: 135609 RVA: 0x00499B19 File Offset: 0x00497D19
		public IDollComboCameraT()
		{
			this.Fov = 0f;
			this.ComboCameras = null;
		}
	}
}
