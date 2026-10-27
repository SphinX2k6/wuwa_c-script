using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A3 RID: 29091
	public class ISpringArmFixConfigT
	{
		// Token: 0x1700D80B RID: 55307
		// (get) Token: 0x06033942 RID: 211266 RVA: 0x006F2364 File Offset: 0x006F0564
		// (set) Token: 0x06033943 RID: 211267 RVA: 0x006F236C File Offset: 0x006F056C
		public bool LeftRightFix { get; set; }

		// Token: 0x1700D80C RID: 55308
		// (get) Token: 0x06033944 RID: 211268 RVA: 0x006F2375 File Offset: 0x006F0575
		// (set) Token: 0x06033945 RID: 211269 RVA: 0x006F237D File Offset: 0x006F057D
		public bool ForwardBackFix { get; set; }

		// Token: 0x1700D80D RID: 55309
		// (get) Token: 0x06033946 RID: 211270 RVA: 0x006F2386 File Offset: 0x006F0586
		// (set) Token: 0x06033947 RID: 211271 RVA: 0x006F238E File Offset: 0x006F058E
		public bool UpDownFix { get; set; }

		// Token: 0x1700D80E RID: 55310
		// (get) Token: 0x06033948 RID: 211272 RVA: 0x006F2397 File Offset: 0x006F0597
		// (set) Token: 0x06033949 RID: 211273 RVA: 0x006F239F File Offset: 0x006F059F
		public byte NullMask { get; set; }

		// Token: 0x0603394A RID: 211274 RVA: 0x006F23A8 File Offset: 0x006F05A8
		public ISpringArmFixConfigT()
		{
			this.LeftRightFix = false;
			this.ForwardBackFix = false;
			this.UpDownFix = false;
			this.NullMask = 0;
		}
	}
}
