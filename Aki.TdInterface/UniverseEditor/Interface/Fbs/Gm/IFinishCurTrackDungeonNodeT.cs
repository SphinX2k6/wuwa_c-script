using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ABA RID: 19130
	public class IFinishCurTrackDungeonNodeT
	{
		// Token: 0x17008608 RID: 34312
		// (get) Token: 0x0601CC54 RID: 117844 RVA: 0x0040DC86 File Offset: 0x0040BE86
		// (set) Token: 0x0601CC55 RID: 117845 RVA: 0x0040DC8E File Offset: 0x0040BE8E
		public EGmCommand Type { get; set; }

		// Token: 0x17008609 RID: 34313
		// (get) Token: 0x0601CC56 RID: 117846 RVA: 0x0040DC97 File Offset: 0x0040BE97
		// (set) Token: 0x0601CC57 RID: 117847 RVA: 0x0040DC9F File Offset: 0x0040BE9F
		public int NodeId { get; set; }

		// Token: 0x1700860A RID: 34314
		// (get) Token: 0x0601CC58 RID: 117848 RVA: 0x0040DCA8 File Offset: 0x0040BEA8
		// (set) Token: 0x0601CC59 RID: 117849 RVA: 0x0040DCB0 File Offset: 0x0040BEB0
		public int NodeIndex { get; set; }

		// Token: 0x1700860B RID: 34315
		// (get) Token: 0x0601CC5A RID: 117850 RVA: 0x0040DCB9 File Offset: 0x0040BEB9
		// (set) Token: 0x0601CC5B RID: 117851 RVA: 0x0040DCC1 File Offset: 0x0040BEC1
		public bool IsComplete { get; set; }

		// Token: 0x1700860C RID: 34316
		// (get) Token: 0x0601CC5C RID: 117852 RVA: 0x0040DCCA File Offset: 0x0040BECA
		// (set) Token: 0x0601CC5D RID: 117853 RVA: 0x0040DCD2 File Offset: 0x0040BED2
		public byte NullMask { get; set; }

		// Token: 0x0601CC5E RID: 117854 RVA: 0x0040DCDB File Offset: 0x0040BEDB
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
