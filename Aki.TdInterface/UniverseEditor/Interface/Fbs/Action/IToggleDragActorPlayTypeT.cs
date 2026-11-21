using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BEB RID: 31723
	public class IToggleDragActorPlayTypeT
	{
		// Token: 0x1700EDAA RID: 60842
		// (get) Token: 0x060392FC RID: 234236 RVA: 0x007BA00A File Offset: 0x007B820A
		// (set) Token: 0x060392FD RID: 234237 RVA: 0x007BA012 File Offset: 0x007B8212
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x060392FE RID: 234238 RVA: 0x007BA01B File Offset: 0x007B821B
		public IToggleDragActorPlayTypeT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
		}
	}
}
