using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D58 RID: 15704
	[NullableContext(2)]
	public interface IRoguelikeRandomEventOpenParam
	{
		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x0602835B RID: 164699
		// (set) Token: 0x0602835C RID: 164700
		int BindId { get; set; }

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x0602835D RID: 164701
		// (set) Token: 0x0602835E RID: 164702
		Action<int> SelectCallback { get; set; }
	}
}
