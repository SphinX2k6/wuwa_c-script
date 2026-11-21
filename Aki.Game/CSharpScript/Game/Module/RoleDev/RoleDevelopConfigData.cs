using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C5C RID: 15452
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopConfigData : IRoleDevelopConfigData
	{
		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x06027915 RID: 162069 RVA: 0x00B19D71 File Offset: 0x00B17F71
		// (set) Token: 0x06027916 RID: 162070 RVA: 0x00B19D79 File Offset: 0x00B17F79
		public List<IRoleDevPropsConfig> DevPropsList { get; set; }
	}
}
