using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004652 RID: 18002
	public class IFinishCurTrackDungeonNodeT
	{
		// Token: 0x17007FC7 RID: 32711
		// (get) Token: 0x0601B47F RID: 111743 RVA: 0x003E19EA File Offset: 0x003DFBEA
		// (set) Token: 0x0601B480 RID: 111744 RVA: 0x003E19F2 File Offset: 0x003DFBF2
		public EGmCommand Type { get; set; }

		// Token: 0x17007FC8 RID: 32712
		// (get) Token: 0x0601B481 RID: 111745 RVA: 0x003E19FB File Offset: 0x003DFBFB
		// (set) Token: 0x0601B482 RID: 111746 RVA: 0x003E1A03 File Offset: 0x003DFC03
		public int NodeId { get; set; }

		// Token: 0x17007FC9 RID: 32713
		// (get) Token: 0x0601B483 RID: 111747 RVA: 0x003E1A0C File Offset: 0x003DFC0C
		// (set) Token: 0x0601B484 RID: 111748 RVA: 0x003E1A14 File Offset: 0x003DFC14
		public int NodeIndex { get; set; }

		// Token: 0x17007FCA RID: 32714
		// (get) Token: 0x0601B485 RID: 111749 RVA: 0x003E1A1D File Offset: 0x003DFC1D
		// (set) Token: 0x0601B486 RID: 111750 RVA: 0x003E1A25 File Offset: 0x003DFC25
		public bool IsComplete { get; set; }

		// Token: 0x17007FCB RID: 32715
		// (get) Token: 0x0601B487 RID: 111751 RVA: 0x003E1A2E File Offset: 0x003DFC2E
		// (set) Token: 0x0601B488 RID: 111752 RVA: 0x003E1A36 File Offset: 0x003DFC36
		public byte NullMask { get; set; }

		// Token: 0x0601B489 RID: 111753 RVA: 0x003E1A3F File Offset: 0x003DFC3F
		public IFinishCurTrackDungeonNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.IsComplete = false;
			this.NullMask = 0;
		}
	}
}
