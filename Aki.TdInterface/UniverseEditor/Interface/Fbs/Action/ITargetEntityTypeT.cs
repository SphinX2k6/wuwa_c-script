using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B3A RID: 31546
	public class ITargetEntityTypeT
	{
		// Token: 0x1700EC4D RID: 60493
		// (get) Token: 0x06038D07 RID: 232711 RVA: 0x007AEE82 File Offset: 0x007AD082
		// (set) Token: 0x06038D08 RID: 232712 RVA: 0x007AEE8A File Offset: 0x007AD08A
		public ETargetEntityType Type { get; set; }

		// Token: 0x06038D09 RID: 232713 RVA: 0x007AEE93 File Offset: 0x007AD093
		public ITargetEntityTypeT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
