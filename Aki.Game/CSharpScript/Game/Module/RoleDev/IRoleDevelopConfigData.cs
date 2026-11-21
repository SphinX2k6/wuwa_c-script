using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C5B RID: 15451
	[NullableContext(1)]
	public interface IRoleDevelopConfigData
	{
		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x06027913 RID: 162067
		// (set) Token: 0x06027914 RID: 162068
		List<IRoleDevPropsConfig> DevPropsList { get; set; }
	}
}
