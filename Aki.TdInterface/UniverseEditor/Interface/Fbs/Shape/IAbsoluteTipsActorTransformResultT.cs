using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE1 RID: 15329
	public class IAbsoluteTipsActorTransformResultT
	{
		// Token: 0x17006928 RID: 26920
		// (get) Token: 0x0601512B RID: 86315 RVA: 0x0030DF22 File Offset: 0x0030C122
		// (set) Token: 0x0601512C RID: 86316 RVA: 0x0030DF2A File Offset: 0x0030C12A
		public bool IsSuccess { get; set; }

		// Token: 0x17006929 RID: 26921
		// (get) Token: 0x0601512D RID: 86317 RVA: 0x0030DF33 File Offset: 0x0030C133
		// (set) Token: 0x0601512E RID: 86318 RVA: 0x0030DF3B File Offset: 0x0030C13B
		public string Reason { get; set; }

		// Token: 0x1700692A RID: 26922
		// (get) Token: 0x0601512F RID: 86319 RVA: 0x0030DF44 File Offset: 0x0030C144
		// (set) Token: 0x06015130 RID: 86320 RVA: 0x0030DF4C File Offset: 0x0030C14C
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x1700692B RID: 26923
		// (get) Token: 0x06015131 RID: 86321 RVA: 0x0030DF55 File Offset: 0x0030C155
		// (set) Token: 0x06015132 RID: 86322 RVA: 0x0030DF5D File Offset: 0x0030C15D
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x1700692C RID: 26924
		// (get) Token: 0x06015133 RID: 86323 RVA: 0x0030DF66 File Offset: 0x0030C166
		// (set) Token: 0x06015134 RID: 86324 RVA: 0x0030DF6E File Offset: 0x0030C16E
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x06015135 RID: 86325 RVA: 0x0030DF77 File Offset: 0x0030C177
		public IAbsoluteTipsActorTransformResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
			this.Type = ETipsActorTransformType.Absolute;
			this.TransformWorld = null;
			this.HollowTipsActorComponent = null;
		}
	}
}
