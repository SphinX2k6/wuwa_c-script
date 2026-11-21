using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006131 RID: 24881
	public class IVehicleGenerationConfigT
	{
		// Token: 0x1700B954 RID: 47444
		// (get) Token: 0x0602A382 RID: 172930 RVA: 0x005C3273 File Offset: 0x005C1473
		// (set) Token: 0x0602A383 RID: 172931 RVA: 0x005C327B File Offset: 0x005C147B
		public float Range { get; set; }

		// Token: 0x1700B955 RID: 47445
		// (get) Token: 0x0602A384 RID: 172932 RVA: 0x005C3284 File Offset: 0x005C1484
		// (set) Token: 0x0602A385 RID: 172933 RVA: 0x005C328C File Offset: 0x005C148C
		public List<ISplineWayPointT> Destinations { get; set; }

		// Token: 0x1700B956 RID: 47446
		// (get) Token: 0x0602A386 RID: 172934 RVA: 0x005C3295 File Offset: 0x005C1495
		// (set) Token: 0x0602A387 RID: 172935 RVA: 0x005C329D File Offset: 0x005C149D
		public List<TVehicleGenerationTypeUnion> VehicleConfig { get; set; }

		// Token: 0x1700B957 RID: 47447
		// (get) Token: 0x0602A388 RID: 172936 RVA: 0x005C32A6 File Offset: 0x005C14A6
		// (set) Token: 0x0602A389 RID: 172937 RVA: 0x005C32AE File Offset: 0x005C14AE
		public float Cd { get; set; }

		// Token: 0x1700B958 RID: 47448
		// (get) Token: 0x0602A38A RID: 172938 RVA: 0x005C32B7 File Offset: 0x005C14B7
		// (set) Token: 0x0602A38B RID: 172939 RVA: 0x005C32BF File Offset: 0x005C14BF
		public IVectorInfoT Offset { get; set; }

		// Token: 0x0602A38C RID: 172940 RVA: 0x005C32C8 File Offset: 0x005C14C8
		public IVehicleGenerationConfigT()
		{
			this.Range = 0f;
			this.Destinations = null;
			this.VehicleConfig = null;
			this.Cd = 0f;
			this.Offset = null;
		}
	}
}
