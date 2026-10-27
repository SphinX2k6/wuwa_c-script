using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC2 RID: 27586
	public class INpcLeisureInteractTypeT
	{
		// Token: 0x1700CD03 RID: 52483
		// (get) Token: 0x06030761 RID: 198497 RVA: 0x00694B46 File Offset: 0x00692D46
		// (set) Token: 0x06030762 RID: 198498 RVA: 0x00694B4E File Offset: 0x00692D4E
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700CD04 RID: 52484
		// (get) Token: 0x06030763 RID: 198499 RVA: 0x00694B57 File Offset: 0x00692D57
		// (set) Token: 0x06030764 RID: 198500 RVA: 0x00694B5F File Offset: 0x00692D5F
		public bool KeepState { get; set; }

		// Token: 0x1700CD05 RID: 52485
		// (get) Token: 0x06030765 RID: 198501 RVA: 0x00694B68 File Offset: 0x00692D68
		// (set) Token: 0x06030766 RID: 198502 RVA: 0x00694B70 File Offset: 0x00692D70
		public byte NullMask { get; set; }

		// Token: 0x06030767 RID: 198503 RVA: 0x00694B79 File Offset: 0x00692D79
		public INpcLeisureInteractTypeT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.NullMask = 0;
		}
	}
}
