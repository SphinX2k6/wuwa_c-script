using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007119 RID: 28953
	public class ISitDownT
	{
		// Token: 0x1700D73F RID: 55103
		// (get) Token: 0x0603355B RID: 210267 RVA: 0x006EB812 File Offset: 0x006E9A12
		// (set) Token: 0x0603355C RID: 210268 RVA: 0x006EB81A File Offset: 0x006E9A1A
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D740 RID: 55104
		// (get) Token: 0x0603355D RID: 210269 RVA: 0x006EB823 File Offset: 0x006E9A23
		// (set) Token: 0x0603355E RID: 210270 RVA: 0x006EB82B File Offset: 0x006E9A2B
		public bool OnlyAllowForwardStandUp { get; set; }

		// Token: 0x1700D741 RID: 55105
		// (get) Token: 0x0603355F RID: 210271 RVA: 0x006EB834 File Offset: 0x006E9A34
		// (set) Token: 0x06033560 RID: 210272 RVA: 0x006EB83C File Offset: 0x006E9A3C
		public byte NullMask { get; set; }

		// Token: 0x06033561 RID: 210273 RVA: 0x006EB845 File Offset: 0x006E9A45
		public ISitDownT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.OnlyAllowForwardStandUp = false;
			this.NullMask = 0;
		}
	}
}
