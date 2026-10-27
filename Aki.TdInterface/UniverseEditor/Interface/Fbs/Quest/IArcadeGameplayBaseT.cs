using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D02 RID: 15618
	public class IArcadeGameplayBaseT
	{
		// Token: 0x17006B2B RID: 27435
		// (get) Token: 0x060158B1 RID: 88241 RVA: 0x0031CEEE File Offset: 0x0031B0EE
		// (set) Token: 0x060158B2 RID: 88242 RVA: 0x0031CEF6 File Offset: 0x0031B0F6
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x060158B3 RID: 88243 RVA: 0x0031CEFF File Offset: 0x0031B0FF
		public IArcadeGameplayBaseT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
		}
	}
}
