using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D35 RID: 23861
	public class IPhotoTargetComponentT
	{
		// Token: 0x1700AF76 RID: 44918
		// (get) Token: 0x06027AD6 RID: 162518 RVA: 0x0056DBA8 File Offset: 0x0056BDA8
		// (set) Token: 0x06027AD7 RID: 162519 RVA: 0x0056DBB0 File Offset: 0x0056BDB0
		public bool Disabled { get; set; }

		// Token: 0x1700AF77 RID: 44919
		// (get) Token: 0x06027AD8 RID: 162520 RVA: 0x0056DBB9 File Offset: 0x0056BDB9
		// (set) Token: 0x06027AD9 RID: 162521 RVA: 0x0056DBC1 File Offset: 0x0056BDC1
		public List<IVectorInfoT> RequiredPoints { get; set; }

		// Token: 0x1700AF78 RID: 44920
		// (get) Token: 0x06027ADA RID: 162522 RVA: 0x0056DBCA File Offset: 0x0056BDCA
		// (set) Token: 0x06027ADB RID: 162523 RVA: 0x0056DBD2 File Offset: 0x0056BDD2
		public TPhotoTargetCaptureUiUnion TargetCapturePromptUi { get; set; }

		// Token: 0x1700AF79 RID: 44921
		// (get) Token: 0x06027ADC RID: 162524 RVA: 0x0056DBDB File Offset: 0x0056BDDB
		// (set) Token: 0x06027ADD RID: 162525 RVA: 0x0056DBE3 File Offset: 0x0056BDE3
		public List<int> RayCastIgnoreEntities { get; set; }

		// Token: 0x1700AF7A RID: 44922
		// (get) Token: 0x06027ADE RID: 162526 RVA: 0x0056DBEC File Offset: 0x0056BDEC
		// (set) Token: 0x06027ADF RID: 162527 RVA: 0x0056DBF4 File Offset: 0x0056BDF4
		public byte NullMask { get; set; }

		// Token: 0x06027AE0 RID: 162528 RVA: 0x0056DBFD File Offset: 0x0056BDFD
		public IPhotoTargetComponentT()
		{
			this.Disabled = false;
			this.RequiredPoints = null;
			this.TargetCapturePromptUi = null;
			this.RayCastIgnoreEntities = null;
			this.NullMask = 0;
		}
	}
}
