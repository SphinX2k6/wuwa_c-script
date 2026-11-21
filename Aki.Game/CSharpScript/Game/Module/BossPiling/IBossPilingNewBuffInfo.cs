using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE9 RID: 19433
	public interface IBossPilingNewBuffInfo
	{
		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x060307F0 RID: 198640
		// (set) Token: 0x060307F1 RID: 198641
		int BuffId { get; set; }

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x060307F2 RID: 198642
		// (set) Token: 0x060307F3 RID: 198643
		int OldValue { get; set; }

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x060307F4 RID: 198644
		// (set) Token: 0x060307F5 RID: 198645
		int NewValue { get; set; }

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x060307F6 RID: 198646
		// (set) Token: 0x060307F7 RID: 198647
		bool NeedAccelerate { get; set; }
	}
}
