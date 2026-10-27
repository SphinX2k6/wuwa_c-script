using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E3 RID: 28899
	public class IShowMapMarkT
	{
		// Token: 0x1700D6C2 RID: 54978
		// (get) Token: 0x0603333D RID: 209725 RVA: 0x006E7088 File Offset: 0x006E5288
		// (set) Token: 0x0603333E RID: 209726 RVA: 0x006E7090 File Offset: 0x006E5290
		public EMapMarkState Type { get; set; }

		// Token: 0x1700D6C3 RID: 54979
		// (get) Token: 0x0603333F RID: 209727 RVA: 0x006E7099 File Offset: 0x006E5299
		// (set) Token: 0x06033340 RID: 209728 RVA: 0x006E70A1 File Offset: 0x006E52A1
		public int MarkId { get; set; }

		// Token: 0x1700D6C4 RID: 54980
		// (get) Token: 0x06033341 RID: 209729 RVA: 0x006E70AA File Offset: 0x006E52AA
		// (set) Token: 0x06033342 RID: 209730 RVA: 0x006E70B2 File Offset: 0x006E52B2
		public bool IsFocusOnFirstShow { get; set; }

		// Token: 0x1700D6C5 RID: 54981
		// (get) Token: 0x06033343 RID: 209731 RVA: 0x006E70BB File Offset: 0x006E52BB
		// (set) Token: 0x06033344 RID: 209732 RVA: 0x006E70C3 File Offset: 0x006E52C3
		public byte NullMask { get; set; }

		// Token: 0x06033345 RID: 209733 RVA: 0x006E70CC File Offset: 0x006E52CC
		public IShowMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
			this.IsFocusOnFirstShow = false;
			this.NullMask = 0;
		}
	}
}
