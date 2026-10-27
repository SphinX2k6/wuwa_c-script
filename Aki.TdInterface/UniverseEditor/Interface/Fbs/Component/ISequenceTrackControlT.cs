using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FE RID: 22782
	public class ISequenceTrackControlT
	{
		// Token: 0x1700AAC4 RID: 43716
		// (get) Token: 0x06026802 RID: 157698 RVA: 0x0054E136 File Offset: 0x0054C336
		// (set) Token: 0x06026803 RID: 157699 RVA: 0x0054E13E File Offset: 0x0054C33E
		public ETrackControlMode Type { get; set; }

		// Token: 0x1700AAC5 RID: 43717
		// (get) Token: 0x06026804 RID: 157700 RVA: 0x0054E147 File Offset: 0x0054C347
		// (set) Token: 0x06026805 RID: 157701 RVA: 0x0054E14F File Offset: 0x0054C34F
		public string Sequence { get; set; }

		// Token: 0x1700AAC6 RID: 43718
		// (get) Token: 0x06026806 RID: 157702 RVA: 0x0054E158 File Offset: 0x0054C358
		// (set) Token: 0x06026807 RID: 157703 RVA: 0x0054E160 File Offset: 0x0054C360
		public List<ISequenceTrackControlPointT> ControlPoints { get; set; }

		// Token: 0x06026808 RID: 157704 RVA: 0x0054E169 File Offset: 0x0054C369
		public ISequenceTrackControlT()
		{
			this.Type = ETrackControlMode.Sequence;
			this.Sequence = null;
			this.ControlPoints = null;
		}
	}
}
