using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F33 RID: 28467
	public class IGiantTriggerResponseT
	{
		// Token: 0x1700D0A9 RID: 53417
		// (get) Token: 0x06031442 RID: 201794 RVA: 0x006ACBA9 File Offset: 0x006AADA9
		// (set) Token: 0x06031443 RID: 201795 RVA: 0x006ACBB1 File Offset: 0x006AADB1
		public List<TGiantResponseFunctionUnion> ResponseFunctions { get; set; }

		// Token: 0x06031444 RID: 201796 RVA: 0x006ACBBA File Offset: 0x006AADBA
		public IGiantTriggerResponseT()
		{
			this.ResponseFunctions = null;
		}
	}
}
