using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553D RID: 21821
	public class IMechFixedPointHookT
	{
		// Token: 0x1700A117 RID: 41239
		// (get) Token: 0x060240DD RID: 147677 RVA: 0x004FB06F File Offset: 0x004F926F
		// (set) Token: 0x060240DE RID: 147678 RVA: 0x004FB077 File Offset: 0x004F9277
		public EMechHookConfigType Type { get; set; }

		// Token: 0x1700A118 RID: 41240
		// (get) Token: 0x060240DF RID: 147679 RVA: 0x004FB080 File Offset: 0x004F9280
		// (set) Token: 0x060240E0 RID: 147680 RVA: 0x004FB088 File Offset: 0x004F9288
		public IMechBehaviorConfigT MechBehaviorConfig { get; set; }

		// Token: 0x060240E1 RID: 147681 RVA: 0x004FB091 File Offset: 0x004F9291
		public IMechFixedPointHookT()
		{
			this.Type = EMechHookConfigType.BurrowHook;
			this.MechBehaviorConfig = null;
		}
	}
}
