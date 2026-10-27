using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006114 RID: 24852
	public class IActorVisibilityEffectDefaultT
	{
		// Token: 0x1700B72A RID: 46890
		// (get) Token: 0x0602A773 RID: 173939 RVA: 0x005D96A2 File Offset: 0x005D78A2
		// (set) Token: 0x0602A774 RID: 173940 RVA: 0x005D96AA File Offset: 0x005D78AA
		public EActorVisibilityEffectType Type { get; set; }

		// Token: 0x0602A775 RID: 173941 RVA: 0x005D96B3 File Offset: 0x005D78B3
		public IActorVisibilityEffectDefaultT()
		{
			this.Type = EActorVisibilityEffectType.Default;
		}
	}
}
