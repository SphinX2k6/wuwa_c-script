using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E2 RID: 21730
	public class ICircuitConnectLevelDataT
	{
		// Token: 0x17009B3D RID: 39741
		// (get) Token: 0x060224F1 RID: 140529 RVA: 0x004BAD5C File Offset: 0x004B8F5C
		// (set) Token: 0x060224F2 RID: 140530 RVA: 0x004BAD64 File Offset: 0x004B8F64
		public TCircuitConnectModeUnion Mode { get; set; }

		// Token: 0x17009B3E RID: 39742
		// (get) Token: 0x060224F3 RID: 140531 RVA: 0x004BAD6D File Offset: 0x004B8F6D
		// (set) Token: 0x060224F4 RID: 140532 RVA: 0x004BAD75 File Offset: 0x004B8F75
		public float RotationSpeed { get; set; }

		// Token: 0x17009B3F RID: 39743
		// (get) Token: 0x060224F5 RID: 140533 RVA: 0x004BAD7E File Offset: 0x004B8F7E
		// (set) Token: 0x060224F6 RID: 140534 RVA: 0x004BAD86 File Offset: 0x004B8F86
		public float ConnectTolerance { get; set; }

		// Token: 0x17009B40 RID: 39744
		// (get) Token: 0x060224F7 RID: 140535 RVA: 0x004BAD8F File Offset: 0x004B8F8F
		// (set) Token: 0x060224F8 RID: 140536 RVA: 0x004BAD97 File Offset: 0x004B8F97
		public List<ICircuitConnectLinkageGroupT> LinkageGroups { get; set; }

		// Token: 0x17009B41 RID: 39745
		// (get) Token: 0x060224F9 RID: 140537 RVA: 0x004BADA0 File Offset: 0x004B8FA0
		// (set) Token: 0x060224FA RID: 140538 RVA: 0x004BADA8 File Offset: 0x004B8FA8
		public List<ICircuitConnectLayoutT> Layout { get; set; }

		// Token: 0x060224FB RID: 140539 RVA: 0x004BADB1 File Offset: 0x004B8FB1
		public ICircuitConnectLevelDataT()
		{
			this.Mode = null;
			this.RotationSpeed = 0f;
			this.ConnectTolerance = 0f;
			this.LinkageGroups = null;
			this.Layout = null;
		}
	}
}
