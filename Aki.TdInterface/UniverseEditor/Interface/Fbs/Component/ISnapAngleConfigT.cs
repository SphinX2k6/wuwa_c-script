using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F4C RID: 24396
	public class ISnapAngleConfigT
	{
		// Token: 0x1700B4B5 RID: 46261
		// (get) Token: 0x06029008 RID: 167944 RVA: 0x00599F50 File Offset: 0x00598150
		// (set) Token: 0x06029009 RID: 167945 RVA: 0x00599F58 File Offset: 0x00598158
		public float Angle { get; set; }

		// Token: 0x1700B4B6 RID: 46262
		// (get) Token: 0x0602900A RID: 167946 RVA: 0x00599F61 File Offset: 0x00598161
		// (set) Token: 0x0602900B RID: 167947 RVA: 0x00599F69 File Offset: 0x00598169
		public float Range { get; set; }

		// Token: 0x0602900C RID: 167948 RVA: 0x00599F72 File Offset: 0x00598172
		public ISnapAngleConfigT()
		{
			this.Angle = 0f;
			this.Range = 0f;
		}
	}
}
