using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748D RID: 29837
	public class IPlayerSplineMoveTargetT
	{
		// Token: 0x1700DB2E RID: 56110
		// (get) Token: 0x060343C2 RID: 213954 RVA: 0x007090D3 File Offset: 0x007072D3
		// (set) Token: 0x060343C3 RID: 213955 RVA: 0x007090DB File Offset: 0x007072DB
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x1700DB2F RID: 56111
		// (get) Token: 0x060343C4 RID: 213956 RVA: 0x007090E4 File Offset: 0x007072E4
		// (set) Token: 0x060343C5 RID: 213957 RVA: 0x007090EC File Offset: 0x007072EC
		public IThreeStageSplineMoveMontageT CustomMoveMontage { get; set; }

		// Token: 0x060343C6 RID: 213958 RVA: 0x007090F5 File Offset: 0x007072F5
		public IPlayerSplineMoveTargetT()
		{
			this.Type = ESplineMoveTargetType.Entity;
			this.CustomMoveMontage = null;
		}
	}
}
