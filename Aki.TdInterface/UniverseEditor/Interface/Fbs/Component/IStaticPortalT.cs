using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD6 RID: 24534
	public class IStaticPortalT
	{
		// Token: 0x1700B5DA RID: 46554
		// (get) Token: 0x0602951E RID: 169246 RVA: 0x005A41A7 File Offset: 0x005A23A7
		// (set) Token: 0x0602951F RID: 169247 RVA: 0x005A41AF File Offset: 0x005A23AF
		public EPortalType Type { get; set; }

		// Token: 0x1700B5DB RID: 46555
		// (get) Token: 0x06029520 RID: 169248 RVA: 0x005A41B8 File Offset: 0x005A23B8
		// (set) Token: 0x06029521 RID: 169249 RVA: 0x005A41C0 File Offset: 0x005A23C0
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700B5DC RID: 46556
		// (get) Token: 0x06029522 RID: 169250 RVA: 0x005A41C9 File Offset: 0x005A23C9
		// (set) Token: 0x06029523 RID: 169251 RVA: 0x005A41D1 File Offset: 0x005A23D1
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x1700B5DD RID: 46557
		// (get) Token: 0x06029524 RID: 169252 RVA: 0x005A41DA File Offset: 0x005A23DA
		// (set) Token: 0x06029525 RID: 169253 RVA: 0x005A41E2 File Offset: 0x005A23E2
		public int LinkPortalEntityId { get; set; }

		// Token: 0x1700B5DE RID: 46558
		// (get) Token: 0x06029526 RID: 169254 RVA: 0x005A41EB File Offset: 0x005A23EB
		// (set) Token: 0x06029527 RID: 169255 RVA: 0x005A41F3 File Offset: 0x005A23F3
		public bool IsStreamSource { get; set; }

		// Token: 0x1700B5DF RID: 46559
		// (get) Token: 0x06029528 RID: 169256 RVA: 0x005A41FC File Offset: 0x005A23FC
		// (set) Token: 0x06029529 RID: 169257 RVA: 0x005A4204 File Offset: 0x005A2404
		public byte NullMask { get; set; }

		// Token: 0x0602952A RID: 169258 RVA: 0x005A420D File Offset: 0x005A240D
		public IStaticPortalT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
			this.LinkPortalEntityId = 0;
			this.IsStreamSource = false;
			this.NullMask = 0;
		}
	}
}
