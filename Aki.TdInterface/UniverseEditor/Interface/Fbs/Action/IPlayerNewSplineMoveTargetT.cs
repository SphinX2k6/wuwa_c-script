using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007481 RID: 29825
	public class IPlayerNewSplineMoveTargetT
	{
		// Token: 0x1700DB1F RID: 56095
		// (get) Token: 0x06034374 RID: 213876 RVA: 0x00708912 File Offset: 0x00706B12
		// (set) Token: 0x06034375 RID: 213877 RVA: 0x0070891A File Offset: 0x00706B1A
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x06034376 RID: 213878 RVA: 0x00708923 File Offset: 0x00706B23
		public IPlayerNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}
