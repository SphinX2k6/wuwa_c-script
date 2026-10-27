using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006892 RID: 26770
	public class IGiantTriggerResponseT
	{
		// Token: 0x1700C6C3 RID: 50883
		// (get) Token: 0x0602EB08 RID: 191240 RVA: 0x0065DB29 File Offset: 0x0065BD29
		// (set) Token: 0x0602EB09 RID: 191241 RVA: 0x0065DB31 File Offset: 0x0065BD31
		public List<TGiantResponseFunctionUnion> ResponseFunctions { get; set; }

		// Token: 0x0602EB0A RID: 191242 RVA: 0x0065DB3A File Offset: 0x0065BD3A
		public IGiantTriggerResponseT()
		{
			this.ResponseFunctions = null;
		}
	}
}
