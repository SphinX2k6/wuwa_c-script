using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079BD RID: 31165
	public class IStopNewMoveWithSplineAtTargetPointT
	{
		// Token: 0x1700E48A RID: 58506
		// (get) Token: 0x06036E96 RID: 224918 RVA: 0x00757E5C File Offset: 0x0075605C
		// (set) Token: 0x06036E97 RID: 224919 RVA: 0x00757E64 File Offset: 0x00756064
		public EStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x1700E48B RID: 58507
		// (get) Token: 0x06036E98 RID: 224920 RVA: 0x00757E6D File Offset: 0x0075606D
		// (set) Token: 0x06036E99 RID: 224921 RVA: 0x00757E75 File Offset: 0x00756075
		public int PointId { get; set; }

		// Token: 0x06036E9A RID: 224922 RVA: 0x00757E7E File Offset: 0x0075607E
		public IStopNewMoveWithSplineAtTargetPointT()
		{
			this.Type = EStopNewMoveWithSplineType.StopAtCurrentPos;
			this.PointId = 0;
		}
	}
}
