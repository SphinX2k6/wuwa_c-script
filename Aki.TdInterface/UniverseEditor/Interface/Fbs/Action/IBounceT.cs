using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688D RID: 26765
	public class IBounceT
	{
		// Token: 0x1700C4B2 RID: 50354
		// (get) Token: 0x0602DC15 RID: 187413 RVA: 0x00641543 File Offset: 0x0063F743
		// (set) Token: 0x0602DC16 RID: 187414 RVA: 0x0064154B File Offset: 0x0063F74B
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C4B3 RID: 50355
		// (get) Token: 0x0602DC17 RID: 187415 RVA: 0x00641554 File Offset: 0x0063F754
		// (set) Token: 0x0602DC18 RID: 187416 RVA: 0x0064155C File Offset: 0x0063F75C
		public TCommonTargetUnion Target { get; set; }

		// Token: 0x1700C4B4 RID: 50356
		// (get) Token: 0x0602DC19 RID: 187417 RVA: 0x00641565 File Offset: 0x0063F765
		// (set) Token: 0x0602DC1A RID: 187418 RVA: 0x0064156D File Offset: 0x0063F76D
		public int Height { get; set; }

		// Token: 0x1700C4B5 RID: 50357
		// (get) Token: 0x0602DC1B RID: 187419 RVA: 0x00641576 File Offset: 0x0063F776
		// (set) Token: 0x0602DC1C RID: 187420 RVA: 0x0064157E File Offset: 0x0063F77E
		public float Time { get; set; }

		// Token: 0x1700C4B6 RID: 50358
		// (get) Token: 0x0602DC1D RID: 187421 RVA: 0x00641587 File Offset: 0x0063F787
		// (set) Token: 0x0602DC1E RID: 187422 RVA: 0x0064158F File Offset: 0x0063F78F
		public string MotionCurve { get; set; }

		// Token: 0x1700C4B7 RID: 50359
		// (get) Token: 0x0602DC1F RID: 187423 RVA: 0x00641598 File Offset: 0x0063F798
		// (set) Token: 0x0602DC20 RID: 187424 RVA: 0x006415A0 File Offset: 0x0063F7A0
		public byte NullMask { get; set; }

		// Token: 0x0602DC21 RID: 187425 RVA: 0x006415A9 File Offset: 0x0063F7A9
		public IBounceT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Target = null;
			this.Height = 0;
			this.Time = 0f;
			this.MotionCurve = null;
			this.NullMask = 0;
		}
	}
}
