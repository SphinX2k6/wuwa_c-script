using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006880 RID: 26752
	public class IGameplayPose3InteractT
	{
		// Token: 0x1700C6AC RID: 50860
		// (get) Token: 0x0602EA7F RID: 191103 RVA: 0x0065CB56 File Offset: 0x0065AD56
		// (set) Token: 0x0602EA80 RID: 191104 RVA: 0x0065CB5E File Offset: 0x0065AD5E
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602EA81 RID: 191105 RVA: 0x0065CB67 File Offset: 0x0065AD67
		public IGameplayPose3InteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
