using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732F RID: 29487
	public class INpcLookAtEntityT
	{
		// Token: 0x1700D822 RID: 55330
		// (get) Token: 0x060336CE RID: 210638 RVA: 0x006EEDF4 File Offset: 0x006ECFF4
		// (set) Token: 0x060336CF RID: 210639 RVA: 0x006EEDFC File Offset: 0x006ECFFC
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700D823 RID: 55331
		// (get) Token: 0x060336D0 RID: 210640 RVA: 0x006EEE05 File Offset: 0x006ED005
		// (set) Token: 0x060336D1 RID: 210641 RVA: 0x006EEE0D File Offset: 0x006ED00D
		public int EntityId { get; set; }

		// Token: 0x060336D2 RID: 210642 RVA: 0x006EEE16 File Offset: 0x006ED016
		public INpcLookAtEntityT()
		{
			this.Type = ECommonTargetType.Player;
			this.EntityId = 0;
		}
	}
}
