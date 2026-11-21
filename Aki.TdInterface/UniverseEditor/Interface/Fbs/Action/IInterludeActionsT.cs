using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007062 RID: 28770
	public class IInterludeActionsT
	{
		// Token: 0x1700D2B5 RID: 53941
		// (get) Token: 0x06031E39 RID: 204345 RVA: 0x006C0CCC File Offset: 0x006BEECC
		// (set) Token: 0x06031E3A RID: 204346 RVA: 0x006C0CD4 File Offset: 0x006BEED4
		public List<IActionInfoT> InterludeActionList { get; set; }

		// Token: 0x1700D2B6 RID: 53942
		// (get) Token: 0x06031E3B RID: 204347 RVA: 0x006C0CDD File Offset: 0x006BEEDD
		// (set) Token: 0x06031E3C RID: 204348 RVA: 0x006C0CE5 File Offset: 0x006BEEE5
		public List<int> DestroyEntityIds { get; set; }

		// Token: 0x1700D2B7 RID: 53943
		// (get) Token: 0x06031E3D RID: 204349 RVA: 0x006C0CEE File Offset: 0x006BEEEE
		// (set) Token: 0x06031E3E RID: 204350 RVA: 0x006C0CF6 File Offset: 0x006BEEF6
		public bool IsFadeIn { get; set; }

		// Token: 0x1700D2B8 RID: 53944
		// (get) Token: 0x06031E3F RID: 204351 RVA: 0x006C0CFF File Offset: 0x006BEEFF
		// (set) Token: 0x06031E40 RID: 204352 RVA: 0x006C0D07 File Offset: 0x006BEF07
		public bool IsFadeOut { get; set; }

		// Token: 0x1700D2B9 RID: 53945
		// (get) Token: 0x06031E41 RID: 204353 RVA: 0x006C0D10 File Offset: 0x006BEF10
		// (set) Token: 0x06031E42 RID: 204354 RVA: 0x006C0D18 File Offset: 0x006BEF18
		public byte NullMask { get; set; }

		// Token: 0x06031E43 RID: 204355 RVA: 0x006C0D21 File Offset: 0x006BEF21
		public IInterludeActionsT()
		{
			this.InterludeActionList = null;
			this.DestroyEntityIds = null;
			this.IsFadeIn = false;
			this.IsFadeOut = false;
			this.NullMask = 0;
		}
	}
}
