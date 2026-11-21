using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F06 RID: 28422
	public class IFrontAxleTrackingSplineMoveT
	{
		// Token: 0x1700D06F RID: 53359
		// (get) Token: 0x060312F1 RID: 201457 RVA: 0x006AA6B0 File Offset: 0x006A88B0
		// (set) Token: 0x060312F2 RID: 201458 RVA: 0x006AA6B8 File Offset: 0x006A88B8
		public ENewSplineMoveType Type { get; set; }

		// Token: 0x1700D070 RID: 53360
		// (get) Token: 0x060312F3 RID: 201459 RVA: 0x006AA6C1 File Offset: 0x006A88C1
		// (set) Token: 0x060312F4 RID: 201460 RVA: 0x006AA6C9 File Offset: 0x006A88C9
		public float EntityAxisLength { get; set; }

		// Token: 0x060312F5 RID: 201461 RVA: 0x006AA6D2 File Offset: 0x006A88D2
		public IFrontAxleTrackingSplineMoveT()
		{
			this.Type = ENewSplineMoveType.FrontAxleTracking;
			this.EntityAxisLength = 0f;
		}
	}
}
