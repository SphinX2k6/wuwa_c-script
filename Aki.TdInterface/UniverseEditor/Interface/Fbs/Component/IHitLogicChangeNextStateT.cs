using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005922 RID: 22818
	public class IHitLogicChangeNextStateT
	{
		// Token: 0x1700A57D RID: 42365
		// (get) Token: 0x06025194 RID: 151956 RVA: 0x005175EA File Offset: 0x005157EA
		// (set) Token: 0x06025195 RID: 151957 RVA: 0x005175F2 File Offset: 0x005157F2
		public EHitLogicType Type { get; set; }

		// Token: 0x06025196 RID: 151958 RVA: 0x005175FB File Offset: 0x005157FB
		public IHitLogicChangeNextStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}
