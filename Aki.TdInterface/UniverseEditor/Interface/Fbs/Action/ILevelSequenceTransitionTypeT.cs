using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F1 RID: 27121
	public class ILevelSequenceTransitionTypeT
	{
		// Token: 0x1700C937 RID: 51511
		// (get) Token: 0x0602F735 RID: 194357 RVA: 0x00676742 File Offset: 0x00674942
		// (set) Token: 0x0602F736 RID: 194358 RVA: 0x0067674A File Offset: 0x0067494A
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700C938 RID: 51512
		// (get) Token: 0x0602F737 RID: 194359 RVA: 0x00676753 File Offset: 0x00674953
		// (set) Token: 0x0602F738 RID: 194360 RVA: 0x0067675B File Offset: 0x0067495B
		public float Duration { get; set; }

		// Token: 0x1700C939 RID: 51513
		// (get) Token: 0x0602F739 RID: 194361 RVA: 0x00676764 File Offset: 0x00674964
		// (set) Token: 0x0602F73A RID: 194362 RVA: 0x0067676C File Offset: 0x0067496C
		public byte NullMask { get; set; }

		// Token: 0x0602F73B RID: 194363 RVA: 0x00676775 File Offset: 0x00674975
		public ILevelSequenceTransitionTypeT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
