using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DC RID: 27100
	public class ILandSlideEndInteractT
	{
		// Token: 0x1700C917 RID: 51479
		// (get) Token: 0x0602F601 RID: 194049 RVA: 0x00673762 File Offset: 0x00671962
		// (set) Token: 0x0602F602 RID: 194050 RVA: 0x0067376A File Offset: 0x0067196A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602F603 RID: 194051 RVA: 0x00673773 File Offset: 0x00671973
		public ILandSlideEndInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
