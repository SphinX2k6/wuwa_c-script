using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005283 RID: 21123
	public class IFlowerPollutionPointLightConfigT
	{
		// Token: 0x17009ADB RID: 39643
		// (get) Token: 0x06022681 RID: 140929 RVA: 0x004C5114 File Offset: 0x004C3314
		// (set) Token: 0x06022682 RID: 140930 RVA: 0x004C511C File Offset: 0x004C331C
		public List<int> PointLightEntityIds { get; set; }

		// Token: 0x17009ADC RID: 39644
		// (get) Token: 0x06022683 RID: 140931 RVA: 0x004C5125 File Offset: 0x004C3325
		// (set) Token: 0x06022684 RID: 140932 RVA: 0x004C512D File Offset: 0x004C332D
		public List<IPointLightOperationsT> PointLightConfig { get; set; }

		// Token: 0x06022685 RID: 140933 RVA: 0x004C5136 File Offset: 0x004C3336
		public IFlowerPollutionPointLightConfigT()
		{
			this.PointLightEntityIds = null;
			this.PointLightConfig = null;
		}
	}
}
