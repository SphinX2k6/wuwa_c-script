using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B6 RID: 25526
	public class IClientEventUiFlyingFlowerT
	{
		// Token: 0x1700BE3D RID: 48701
		// (get) Token: 0x0602C281 RID: 180865 RVA: 0x0061036F File Offset: 0x0060E56F
		// (set) Token: 0x0602C282 RID: 180866 RVA: 0x00610377 File Offset: 0x0060E577
		public EClientEventUiType Type { get; set; }

		// Token: 0x1700BE3E RID: 48702
		// (get) Token: 0x0602C283 RID: 180867 RVA: 0x00610380 File Offset: 0x0060E580
		// (set) Token: 0x0602C284 RID: 180868 RVA: 0x00610388 File Offset: 0x0060E588
		public IClientEventFlyingFlowerUpdateSubtitleT EventType { get; set; }

		// Token: 0x0602C285 RID: 180869 RVA: 0x00610391 File Offset: 0x0060E591
		public IClientEventUiFlyingFlowerT()
		{
			this.Type = EClientEventUiType.PlayPiano;
			this.EventType = null;
		}
	}
}
