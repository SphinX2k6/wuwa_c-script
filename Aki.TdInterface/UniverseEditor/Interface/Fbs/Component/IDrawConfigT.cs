using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005623 RID: 22051
	public class IDrawConfigT
	{
		// Token: 0x17009E57 RID: 40535
		// (get) Token: 0x06023341 RID: 144193 RVA: 0x004D8725 File Offset: 0x004D6925
		// (set) Token: 0x06023342 RID: 144194 RVA: 0x004D872D File Offset: 0x004D692D
		public int DrawDelay { get; set; }

		// Token: 0x17009E58 RID: 40536
		// (get) Token: 0x06023343 RID: 144195 RVA: 0x004D8736 File Offset: 0x004D6936
		// (set) Token: 0x06023344 RID: 144196 RVA: 0x004D873E File Offset: 0x004D693E
		public int DrawTime { get; set; }

		// Token: 0x17009E59 RID: 40537
		// (get) Token: 0x06023345 RID: 144197 RVA: 0x004D8747 File Offset: 0x004D6947
		// (set) Token: 0x06023346 RID: 144198 RVA: 0x004D874F File Offset: 0x004D694F
		public int DrawAlignTime { get; set; }

		// Token: 0x17009E5A RID: 40538
		// (get) Token: 0x06023347 RID: 144199 RVA: 0x004D8758 File Offset: 0x004D6958
		// (set) Token: 0x06023348 RID: 144200 RVA: 0x004D8760 File Offset: 0x004D6960
		public int DrawAlignHeight { get; set; }

		// Token: 0x17009E5B RID: 40539
		// (get) Token: 0x06023349 RID: 144201 RVA: 0x004D8769 File Offset: 0x004D6969
		// (set) Token: 0x0602334A RID: 144202 RVA: 0x004D8771 File Offset: 0x004D6971
		public string DrawCameraShake { get; set; }

		// Token: 0x0602334B RID: 144203 RVA: 0x004D877A File Offset: 0x004D697A
		public IDrawConfigT()
		{
			this.DrawDelay = 0;
			this.DrawTime = 0;
			this.DrawAlignTime = 0;
			this.DrawAlignHeight = 0;
			this.DrawCameraShake = null;
		}
	}
}
