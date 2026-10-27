using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005749 RID: 22345
	public class IPlayerAttachTargetT
	{
		// Token: 0x1700A6B6 RID: 42678
		// (get) Token: 0x06025715 RID: 153365 RVA: 0x0052AB72 File Offset: 0x00528D72
		// (set) Token: 0x06025716 RID: 153366 RVA: 0x0052AB7A File Offset: 0x00528D7A
		public EAttachType Type { get; set; }

		// Token: 0x06025717 RID: 153367 RVA: 0x0052AB83 File Offset: 0x00528D83
		public IPlayerAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}
