using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050BE RID: 20670
	public class IDrawConfigT
	{
		// Token: 0x1700966A RID: 38506
		// (get) Token: 0x060213ED RID: 136173 RVA: 0x0049E799 File Offset: 0x0049C999
		// (set) Token: 0x060213EE RID: 136174 RVA: 0x0049E7A1 File Offset: 0x0049C9A1
		public int DrawDelay { get; set; }

		// Token: 0x1700966B RID: 38507
		// (get) Token: 0x060213EF RID: 136175 RVA: 0x0049E7AA File Offset: 0x0049C9AA
		// (set) Token: 0x060213F0 RID: 136176 RVA: 0x0049E7B2 File Offset: 0x0049C9B2
		public int DrawTime { get; set; }

		// Token: 0x1700966C RID: 38508
		// (get) Token: 0x060213F1 RID: 136177 RVA: 0x0049E7BB File Offset: 0x0049C9BB
		// (set) Token: 0x060213F2 RID: 136178 RVA: 0x0049E7C3 File Offset: 0x0049C9C3
		public int DrawAlignTime { get; set; }

		// Token: 0x1700966D RID: 38509
		// (get) Token: 0x060213F3 RID: 136179 RVA: 0x0049E7CC File Offset: 0x0049C9CC
		// (set) Token: 0x060213F4 RID: 136180 RVA: 0x0049E7D4 File Offset: 0x0049C9D4
		public int DrawAlignHeight { get; set; }

		// Token: 0x1700966E RID: 38510
		// (get) Token: 0x060213F5 RID: 136181 RVA: 0x0049E7DD File Offset: 0x0049C9DD
		// (set) Token: 0x060213F6 RID: 136182 RVA: 0x0049E7E5 File Offset: 0x0049C9E5
		public string DrawCameraShake { get; set; }

		// Token: 0x060213F7 RID: 136183 RVA: 0x0049E7EE File Offset: 0x0049C9EE
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
