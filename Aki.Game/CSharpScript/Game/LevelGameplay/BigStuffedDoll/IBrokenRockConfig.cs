using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F46 RID: 28486
	[NullableContext(1)]
	public interface IBrokenRockConfig
	{
		// Token: 0x17009B2B RID: 39723
		// (get) Token: 0x060454A7 RID: 283815
		int Id { get; }

		// Token: 0x17009B2C RID: 39724
		// (get) Token: 0x060454A8 RID: 283816
		int[] Rings { get; }

		// Token: 0x17009B2D RID: 39725
		// (get) Token: 0x060454A9 RID: 283817
		int ScoreMax { get; }

		// Token: 0x17009B2E RID: 39726
		// (get) Token: 0x060454AA RID: 283818
		int ScoreUp { get; }

		// Token: 0x17009B2F RID: 39727
		// (get) Token: 0x060454AB RID: 283819
		int ScoreDown { get; }

		// Token: 0x17009B30 RID: 39728
		// (get) Token: 0x060454AC RID: 283820
		int GlobalTime { get; }

		// Token: 0x17009B31 RID: 39729
		// (get) Token: 0x060454AD RID: 283821
		int NormalSkill { get; }

		// Token: 0x17009B32 RID: 39730
		// (get) Token: 0x060454AE RID: 283822
		int FinishSkill { get; }

		// Token: 0x17009B33 RID: 39731
		// (get) Token: 0x060454AF RID: 283823
		string EntityUid { get; }
	}
}
