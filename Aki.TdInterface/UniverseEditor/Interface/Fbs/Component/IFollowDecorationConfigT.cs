using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005292 RID: 21138
	public class IFollowDecorationConfigT
	{
		// Token: 0x17009AFF RID: 39679
		// (get) Token: 0x0602272E RID: 141102 RVA: 0x004C6A46 File Offset: 0x004C4C46
		// (set) Token: 0x0602272F RID: 141103 RVA: 0x004C6A4E File Offset: 0x004C4C4E
		public EFollowDecorationType Type { get; set; }

		// Token: 0x06022730 RID: 141104 RVA: 0x004C6A57 File Offset: 0x004C4C57
		public IFollowDecorationConfigT()
		{
			this.Type = EFollowDecorationType.Chair;
		}
	}
}
