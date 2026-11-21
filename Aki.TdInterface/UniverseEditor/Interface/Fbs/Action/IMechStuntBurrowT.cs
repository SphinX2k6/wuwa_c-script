using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AE RID: 29102
	public class IMechStuntBurrowT
	{
		// Token: 0x1700D530 RID: 54576
		// (get) Token: 0x06032A04 RID: 207364 RVA: 0x006D7572 File Offset: 0x006D5772
		// (set) Token: 0x06032A05 RID: 207365 RVA: 0x006D757A File Offset: 0x006D577A
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A06 RID: 207366 RVA: 0x006D7583 File Offset: 0x006D5783
		public IMechStuntBurrowT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
