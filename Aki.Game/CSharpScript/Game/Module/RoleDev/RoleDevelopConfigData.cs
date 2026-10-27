using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CAB RID: 19627
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopConfigData : IRoleDevelopConfigData
	{
		// Token: 0x17007D14 RID: 32020
		// (get) Token: 0x06032B61 RID: 207713 RVA: 0x00BD4FD9 File Offset: 0x00BD31D9
		// (set) Token: 0x06032B62 RID: 207714 RVA: 0x00BD4FE1 File Offset: 0x00BD31E1
		public List<IRoleDevPropsConfig> DevPropsList { get; set; }
	}
}
