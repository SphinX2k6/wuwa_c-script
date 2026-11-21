using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006776 RID: 26486
	public class IActorVisibilityEffectDefaultT
	{
		// Token: 0x1700C095 RID: 49301
		// (get) Token: 0x0602CE54 RID: 183892 RVA: 0x0062364A File Offset: 0x0062184A
		// (set) Token: 0x0602CE55 RID: 183893 RVA: 0x00623652 File Offset: 0x00621852
		public EActorVisibilityEffectType Type { get; set; }

		// Token: 0x0602CE56 RID: 183894 RVA: 0x0062365B File Offset: 0x0062185B
		public IActorVisibilityEffectDefaultT()
		{
			this.Type = EActorVisibilityEffectType.Default;
		}
	}
}
