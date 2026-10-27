using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685F RID: 26719
	public class IFoxPushBoxT
	{
		// Token: 0x1700C678 RID: 50808
		// (get) Token: 0x0602E97B RID: 190843 RVA: 0x0065B051 File Offset: 0x00659251
		// (set) Token: 0x0602E97C RID: 190844 RVA: 0x0065B059 File Offset: 0x00659259
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C679 RID: 50809
		// (get) Token: 0x0602E97D RID: 190845 RVA: 0x0065B062 File Offset: 0x00659262
		// (set) Token: 0x0602E97E RID: 190846 RVA: 0x0065B06A File Offset: 0x0065926A
		public int EntityId { get; set; }

		// Token: 0x1700C67A RID: 50810
		// (get) Token: 0x0602E97F RID: 190847 RVA: 0x0065B073 File Offset: 0x00659273
		// (set) Token: 0x0602E980 RID: 190848 RVA: 0x0065B07B File Offset: 0x0065927B
		public int CollisionRadius { get; set; }

		// Token: 0x1700C67B RID: 50811
		// (get) Token: 0x0602E981 RID: 190849 RVA: 0x0065B084 File Offset: 0x00659284
		// (set) Token: 0x0602E982 RID: 190850 RVA: 0x0065B08C File Offset: 0x0065928C
		public int SplineEntityId { get; set; }

		// Token: 0x1700C67C RID: 50812
		// (get) Token: 0x0602E983 RID: 190851 RVA: 0x0065B095 File Offset: 0x00659295
		// (set) Token: 0x0602E984 RID: 190852 RVA: 0x0065B09D File Offset: 0x0065929D
		public string SendEntityEventOnSplineFinish { get; set; }

		// Token: 0x0602E985 RID: 190853 RVA: 0x0065B0A6 File Offset: 0x006592A6
		public IFoxPushBoxT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
			this.CollisionRadius = 0;
			this.SplineEntityId = 0;
			this.SendEntityEventOnSplineFinish = null;
		}
	}
}
