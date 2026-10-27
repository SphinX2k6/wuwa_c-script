using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F9C RID: 16284
	public class IPhotoTargetT
	{
		// Token: 0x170071AE RID: 29102
		// (get) Token: 0x06017438 RID: 95288 RVA: 0x0035AE0D File Offset: 0x0035900D
		// (set) Token: 0x06017439 RID: 95289 RVA: 0x0035AE15 File Offset: 0x00359015
		public int EntityId { get; set; }

		// Token: 0x170071AF RID: 29103
		// (get) Token: 0x0601743A RID: 95290 RVA: 0x0035AE1E File Offset: 0x0035901E
		// (set) Token: 0x0601743B RID: 95291 RVA: 0x0035AE26 File Offset: 0x00359026
		public string TidDescription { get; set; }

		// Token: 0x170071B0 RID: 29104
		// (get) Token: 0x0601743C RID: 95292 RVA: 0x0035AE2F File Offset: 0x0035902F
		// (set) Token: 0x0601743D RID: 95293 RVA: 0x0035AE37 File Offset: 0x00359037
		public bool IsOptionalTarget { get; set; }

		// Token: 0x170071B1 RID: 29105
		// (get) Token: 0x0601743E RID: 95294 RVA: 0x0035AE40 File Offset: 0x00359040
		// (set) Token: 0x0601743F RID: 95295 RVA: 0x0035AE48 File Offset: 0x00359048
		public ISetVarT SetVar { get; set; }

		// Token: 0x170071B2 RID: 29106
		// (get) Token: 0x06017440 RID: 95296 RVA: 0x0035AE51 File Offset: 0x00359051
		// (set) Token: 0x06017441 RID: 95297 RVA: 0x0035AE59 File Offset: 0x00359059
		public byte NullMask { get; set; }

		// Token: 0x06017442 RID: 95298 RVA: 0x0035AE62 File Offset: 0x00359062
		public IPhotoTargetT()
		{
			this.EntityId = 0;
			this.TidDescription = null;
			this.IsOptionalTarget = false;
			this.SetVar = null;
			this.NullMask = 0;
		}
	}
}
