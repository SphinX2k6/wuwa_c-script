using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005543 RID: 21827
	public class IMechHookConfigTypeT
	{
		// Token: 0x1700A12A RID: 41258
		// (get) Token: 0x06024131 RID: 147761 RVA: 0x004FBE06 File Offset: 0x004FA006
		// (set) Token: 0x06024132 RID: 147762 RVA: 0x004FBE0E File Offset: 0x004FA00E
		public EMechHookConfigType Type { get; set; }

		// Token: 0x06024133 RID: 147763 RVA: 0x004FBE17 File Offset: 0x004FA017
		public IMechHookConfigTypeT()
		{
			this.Type = EMechHookConfigType.BurrowHook;
		}
	}
}
