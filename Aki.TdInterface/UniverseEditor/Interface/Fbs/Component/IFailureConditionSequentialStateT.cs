using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005226 RID: 21030
	public class IFailureConditionSequentialStateT
	{
		// Token: 0x17009A06 RID: 39430
		// (get) Token: 0x060222F7 RID: 140023 RVA: 0x004BE073 File Offset: 0x004BC273
		// (set) Token: 0x060222F8 RID: 140024 RVA: 0x004BE07B File Offset: 0x004BC27B
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x17009A07 RID: 39431
		// (get) Token: 0x060222F9 RID: 140025 RVA: 0x004BE084 File Offset: 0x004BC284
		// (set) Token: 0x060222FA RID: 140026 RVA: 0x004BE08C File Offset: 0x004BC28C
		public List<int> Order { get; set; }

		// Token: 0x060222FB RID: 140027 RVA: 0x004BE095 File Offset: 0x004BC295
		public IFailureConditionSequentialStateT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.Order = null;
		}
	}
}
