using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046E9 RID: 18153
	public interface IKurotatoSaveData
	{
		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x0602D99F RID: 186783
		// (set) Token: 0x0602D9A0 RID: 186784
		long SaveTimestamp { get; set; }

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x0602D9A1 RID: 186785
		// (set) Token: 0x0602D9A2 RID: 186786
		int RoleLevel { get; set; }

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x0602D9A3 RID: 186787
		// (set) Token: 0x0602D9A4 RID: 186788
		int WaveNum { get; set; }
	}
}
