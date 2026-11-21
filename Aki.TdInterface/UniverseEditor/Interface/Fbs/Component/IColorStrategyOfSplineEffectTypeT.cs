using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551B RID: 21787
	public class IColorStrategyOfSplineEffectTypeT
	{
		// Token: 0x17009BB7 RID: 39863
		// (get) Token: 0x06022701 RID: 141057 RVA: 0x004BEB5E File Offset: 0x004BCD5E
		// (set) Token: 0x06022702 RID: 141058 RVA: 0x004BEB66 File Offset: 0x004BCD66
		public EColorChangeStrategyOfSplineEffect Type { get; set; }

		// Token: 0x06022703 RID: 141059 RVA: 0x004BEB6F File Offset: 0x004BCD6F
		public IColorStrategyOfSplineEffectTypeT()
		{
			this.Type = EColorChangeStrategyOfSplineEffect.RGB;
		}
	}
}
