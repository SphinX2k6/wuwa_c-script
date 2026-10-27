using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CAA RID: 19626
	[NullableContext(1)]
	public interface IRoleDevelopConfigData
	{
		// Token: 0x17007D13 RID: 32019
		// (get) Token: 0x06032B5F RID: 207711
		// (set) Token: 0x06032B60 RID: 207712
		List<IRoleDevPropsConfig> DevPropsList { get; set; }
	}
}
