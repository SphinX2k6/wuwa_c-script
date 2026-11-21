using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745A RID: 29786
	public class IPlayEffectT
	{
		// Token: 0x1700DAE7 RID: 56039
		// (get) Token: 0x0603425D RID: 213597 RVA: 0x00706C7F File Offset: 0x00704E7F
		// (set) Token: 0x0603425E RID: 213598 RVA: 0x00706C87 File Offset: 0x00704E87
		public string Path { get; set; }

		// Token: 0x1700DAE8 RID: 56040
		// (get) Token: 0x0603425F RID: 213599 RVA: 0x00706C90 File Offset: 0x00704E90
		// (set) Token: 0x06034260 RID: 213600 RVA: 0x00706C98 File Offset: 0x00704E98
		public TPos2Union Pos2 { get; set; }

		// Token: 0x06034261 RID: 213601 RVA: 0x00706CA1 File Offset: 0x00704EA1
		public IPlayEffectT()
		{
			this.Path = null;
			this.Pos2 = null;
		}
	}
}
