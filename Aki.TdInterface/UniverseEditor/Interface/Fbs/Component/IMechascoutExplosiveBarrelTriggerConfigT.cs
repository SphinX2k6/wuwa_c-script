using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005537 RID: 21815
	public class IMechascoutExplosiveBarrelTriggerConfigT
	{
		// Token: 0x1700A110 RID: 41232
		// (get) Token: 0x060240B7 RID: 147639 RVA: 0x004FACB2 File Offset: 0x004F8EB2
		// (set) Token: 0x060240B8 RID: 147640 RVA: 0x004FACBA File Offset: 0x004F8EBA
		public ETeleCtrlTriggerType Type { get; set; }

		// Token: 0x060240B9 RID: 147641 RVA: 0x004FACC3 File Offset: 0x004F8EC3
		public IMechascoutExplosiveBarrelTriggerConfigT()
		{
			this.Type = ETeleCtrlTriggerType.MechascoutJavelin;
		}
	}
}
