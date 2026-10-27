using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E44 RID: 28228
	public class IRemoveEffectT
	{
		// Token: 0x1700D254 RID: 53844
		// (get) Token: 0x06031E24 RID: 204324 RVA: 0x006C020D File Offset: 0x006BE40D
		// (set) Token: 0x06031E25 RID: 204325 RVA: 0x006C0215 File Offset: 0x006BE415
		public IRemoveScreenEffectT RemoveEffectConfig { get; set; }

		// Token: 0x06031E26 RID: 204326 RVA: 0x006C021E File Offset: 0x006BE41E
		public IRemoveEffectT()
		{
			this.RemoveEffectConfig = null;
		}
	}
}
