using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B26 RID: 23334
	public class IMonsterNpcInteractionEnableConfigT
	{
		// Token: 0x1700AA56 RID: 43606
		// (get) Token: 0x06026614 RID: 157204 RVA: 0x00541FB5 File Offset: 0x005401B5
		// (set) Token: 0x06026615 RID: 157205 RVA: 0x00541FBD File Offset: 0x005401BD
		public List<TMonsterNpcInteractionConfigUnion> Interactions { get; set; }

		// Token: 0x06026616 RID: 157206 RVA: 0x00541FC6 File Offset: 0x005401C6
		public IMonsterNpcInteractionEnableConfigT()
		{
			this.Interactions = null;
		}
	}
}
