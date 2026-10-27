using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006117 RID: 24855
	public class IActorVisibilityEffectTypeT
	{
		// Token: 0x1700B72D RID: 46893
		// (get) Token: 0x0602A785 RID: 173957 RVA: 0x005D981A File Offset: 0x005D7A1A
		// (set) Token: 0x0602A786 RID: 173958 RVA: 0x005D9822 File Offset: 0x005D7A22
		public EActorVisibilityEffectType Type { get; set; }

		// Token: 0x0602A787 RID: 173959 RVA: 0x005D982B File Offset: 0x005D7A2B
		public IActorVisibilityEffectTypeT()
		{
			this.Type = EActorVisibilityEffectType.Default;
		}
	}
}
