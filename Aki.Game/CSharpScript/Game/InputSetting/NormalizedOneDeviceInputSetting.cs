using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006175 RID: 24949
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedOneDeviceInputSetting
	{
		// Token: 0x0401F8B3 RID: 129203
		public InputSettingDevice Device;

		// Token: 0x0401F8B4 RID: 129204
		public CSharpScript.Game.Module.Menu.EInputControllerType InputControllerType;

		// Token: 0x0401F8B5 RID: 129205
		public List<NormalizedActionOverride> ActionOverrides = new List<NormalizedActionOverride>();

		// Token: 0x0401F8B6 RID: 129206
		public List<NormalizedAxisOverride> AxisOverrides = new List<NormalizedAxisOverride>();

		// Token: 0x0401F8B7 RID: 129207
		public List<NormalizedCombinationActionOverride> CombinationActionOverrides = new List<NormalizedCombinationActionOverride>();

		// Token: 0x0401F8B8 RID: 129208
		public List<NormalizedCombinationAxisOverride> CombinationAxisOverrides = new List<NormalizedCombinationAxisOverride>();
	}
}
