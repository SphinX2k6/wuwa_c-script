using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D59 RID: 15705
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeRandomEventOpenParam : IRoguelikeRandomEventOpenParam
	{
		// Token: 0x1700523C RID: 21052
		// (get) Token: 0x0602835F RID: 164703 RVA: 0x00B43650 File Offset: 0x00B41850
		// (set) Token: 0x06028360 RID: 164704 RVA: 0x00B43658 File Offset: 0x00B41858
		public int BindId { get; set; }

		// Token: 0x1700523D RID: 21053
		// (get) Token: 0x06028361 RID: 164705 RVA: 0x00B43661 File Offset: 0x00B41861
		// (set) Token: 0x06028362 RID: 164706 RVA: 0x00B43669 File Offset: 0x00B41869
		public Action<int> SelectCallback { get; set; }
	}
}
