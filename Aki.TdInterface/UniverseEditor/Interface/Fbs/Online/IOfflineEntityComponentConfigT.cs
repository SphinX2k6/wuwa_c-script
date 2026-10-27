using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x02004388 RID: 17288
	public class IOfflineEntityComponentConfigT
	{
		// Token: 0x17007A35 RID: 31285
		// (get) Token: 0x06019B89 RID: 105353 RVA: 0x003AF07D File Offset: 0x003AD27D
		// (set) Token: 0x06019B8A RID: 105354 RVA: 0x003AF085 File Offset: 0x003AD285
		public List<EComponent> Components { get; set; }

		// Token: 0x06019B8B RID: 105355 RVA: 0x003AF08E File Offset: 0x003AD28E
		public IOfflineEntityComponentConfigT()
		{
			this.Components = null;
		}
	}
}
