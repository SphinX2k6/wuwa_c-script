using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C00 RID: 31744
	public class IToggleRideFlyingCarUiGameplayT
	{
		// Token: 0x1700EDC2 RID: 60866
		// (get) Token: 0x06039382 RID: 234370 RVA: 0x007BAD39 File Offset: 0x007B8F39
		// (set) Token: 0x06039383 RID: 234371 RVA: 0x007BAD41 File Offset: 0x007B8F41
		public TToggleRideFlyingCarUiGameplayUnion Config { get; set; }

		// Token: 0x06039384 RID: 234372 RVA: 0x007BAD4A File Offset: 0x007B8F4A
		public IToggleRideFlyingCarUiGameplayT()
		{
			this.Config = null;
		}
	}
}
