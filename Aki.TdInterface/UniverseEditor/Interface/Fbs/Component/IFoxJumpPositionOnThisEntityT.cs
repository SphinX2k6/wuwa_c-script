using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005839 RID: 22585
	public class IFoxJumpPositionOnThisEntityT
	{
		// Token: 0x1700A38E RID: 41870
		// (get) Token: 0x06024921 RID: 149793 RVA: 0x00506634 File Offset: 0x00504834
		// (set) Token: 0x06024922 RID: 149794 RVA: 0x0050663C File Offset: 0x0050483C
		public EFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x1700A38F RID: 41871
		// (get) Token: 0x06024923 RID: 149795 RVA: 0x00506645 File Offset: 0x00504845
		// (set) Token: 0x06024924 RID: 149796 RVA: 0x0050664D File Offset: 0x0050484D
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700A390 RID: 41872
		// (get) Token: 0x06024925 RID: 149797 RVA: 0x00506656 File Offset: 0x00504856
		// (set) Token: 0x06024926 RID: 149798 RVA: 0x0050665E File Offset: 0x0050485E
		public IVectorInfoT RaycastDestOffset { get; set; }

		// Token: 0x1700A391 RID: 41873
		// (get) Token: 0x06024927 RID: 149799 RVA: 0x00506667 File Offset: 0x00504867
		// (set) Token: 0x06024928 RID: 149800 RVA: 0x0050666F File Offset: 0x0050486F
		public int SplineEntityId { get; set; }

		// Token: 0x1700A392 RID: 41874
		// (get) Token: 0x06024929 RID: 149801 RVA: 0x00506678 File Offset: 0x00504878
		// (set) Token: 0x0602492A RID: 149802 RVA: 0x00506680 File Offset: 0x00504880
		public byte NullMask { get; set; }

		// Token: 0x0602492B RID: 149803 RVA: 0x00506689 File Offset: 0x00504889
		public IFoxJumpPositionOnThisEntityT()
		{
			this.Type = EFoxJumpInteractPointRelationType.ThisEntity;
			this.Offset = null;
			this.RaycastDestOffset = null;
			this.SplineEntityId = 0;
			this.NullMask = 0;
		}
	}
}
