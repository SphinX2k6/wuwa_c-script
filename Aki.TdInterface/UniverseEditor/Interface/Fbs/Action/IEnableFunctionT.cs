using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD5 RID: 27861
	public class IEnableFunctionT
	{
		// Token: 0x1700CC5D RID: 52317
		// (get) Token: 0x06030068 RID: 196712 RVA: 0x00688EE2 File Offset: 0x006870E2
		// (set) Token: 0x06030069 RID: 196713 RVA: 0x00688EEA File Offset: 0x006870EA
		public EEnableFunctionType Type { get; set; }

		// Token: 0x0603006A RID: 196714 RVA: 0x00688EF3 File Offset: 0x006870F3
		public IEnableFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
		}
	}
}
