using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFF RID: 20223
	public class IBattleVehicleFeatureT
	{
		// Token: 0x17009184 RID: 37252
		// (get) Token: 0x0601FF2E RID: 130862 RVA: 0x004724A2 File Offset: 0x004706A2
		// (set) Token: 0x0601FF2F RID: 130863 RVA: 0x004724AA File Offset: 0x004706AA
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x0601FF30 RID: 130864 RVA: 0x004724B3 File Offset: 0x004706B3
		public IBattleVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
		}
	}
}
