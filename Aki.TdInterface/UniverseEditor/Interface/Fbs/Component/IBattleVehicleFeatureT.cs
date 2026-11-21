using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005431 RID: 21553
	public class IBattleVehicleFeatureT
	{
		// Token: 0x17009906 RID: 39174
		// (get) Token: 0x06021C9E RID: 138398 RVA: 0x004A8836 File Offset: 0x004A6A36
		// (set) Token: 0x06021C9F RID: 138399 RVA: 0x004A883E File Offset: 0x004A6A3E
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x06021CA0 RID: 138400 RVA: 0x004A8847 File Offset: 0x004A6A47
		public IBattleVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
		}
	}
}
