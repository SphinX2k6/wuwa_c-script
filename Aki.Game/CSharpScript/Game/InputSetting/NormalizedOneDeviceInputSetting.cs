using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FF4 RID: 28660
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalizedOneDeviceInputSetting
	{
		// Token: 0x040245FD RID: 148989
		public InputSettingDevice Device;

		// Token: 0x040245FE RID: 148990
		public CSharpScript.Game.Module.Menu.EInputControllerType InputControllerType;

		// Token: 0x040245FF RID: 148991
		public List<NormalizedActionOverride> ActionOverrides = new List<NormalizedActionOverride>();

		// Token: 0x04024600 RID: 148992
		public List<NormalizedAxisOverride> AxisOverrides = new List<NormalizedAxisOverride>();

		// Token: 0x04024601 RID: 148993
		public List<NormalizedCombinationActionOverride> CombinationActionOverrides = new List<NormalizedCombinationActionOverride>();

		// Token: 0x04024602 RID: 148994
		public List<NormalizedCombinationAxisOverride> CombinationAxisOverrides = new List<NormalizedCombinationAxisOverride>();
	}
}
