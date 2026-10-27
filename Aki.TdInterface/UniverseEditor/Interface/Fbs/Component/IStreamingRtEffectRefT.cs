using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D2 RID: 22994
	public class IStreamingRtEffectRefT
	{
		// Token: 0x1700ACC6 RID: 44230
		// (get) Token: 0x06027028 RID: 159784 RVA: 0x0055E491 File Offset: 0x0055C691
		// (set) Token: 0x06027029 RID: 159785 RVA: 0x0055E499 File Offset: 0x0055C699
		public string ActorRefKey { get; set; }

		// Token: 0x0602702A RID: 159786 RVA: 0x0055E4A2 File Offset: 0x0055C6A2
		public IStreamingRtEffectRefT()
		{
			this.ActorRefKey = null;
		}
	}
}
