using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007002 RID: 28674
	public class ISetHorizontalVerticalSpeedImmediatelyT
	{
		// Token: 0x1700D4FD RID: 54525
		// (get) Token: 0x06032B95 RID: 207765 RVA: 0x006D82D5 File Offset: 0x006D64D5
		// (set) Token: 0x06032B96 RID: 207766 RVA: 0x006D82DD File Offset: 0x006D64DD
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x1700D4FE RID: 54526
		// (get) Token: 0x06032B97 RID: 207767 RVA: 0x006D82E6 File Offset: 0x006D64E6
		// (set) Token: 0x06032B98 RID: 207768 RVA: 0x006D82EE File Offset: 0x006D64EE
		public TProcessedValueUnion HorizontalSpeed { get; set; }

		// Token: 0x1700D4FF RID: 54527
		// (get) Token: 0x06032B99 RID: 207769 RVA: 0x006D82F7 File Offset: 0x006D64F7
		// (set) Token: 0x06032B9A RID: 207770 RVA: 0x006D82FF File Offset: 0x006D64FF
		public TProcessedValueUnion VerticalSpeed { get; set; }

		// Token: 0x06032B9B RID: 207771 RVA: 0x006D8308 File Offset: 0x006D6508
		public ISetHorizontalVerticalSpeedImmediatelyT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
			this.HorizontalSpeed = null;
			this.VerticalSpeed = null;
		}
	}
}
