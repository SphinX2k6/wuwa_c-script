using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF2 RID: 23538
	public class INpcSpecialMarkIgnoreCameraHideNpcT
	{
		// Token: 0x1700AC38 RID: 44088
		// (get) Token: 0x06026DF4 RID: 159220 RVA: 0x005524F6 File Offset: 0x005506F6
		// (set) Token: 0x06026DF5 RID: 159221 RVA: 0x005524FE File Offset: 0x005506FE
		public ESpecialNpcMarkType Type { get; set; }

		// Token: 0x06026DF6 RID: 159222 RVA: 0x00552507 File Offset: 0x00550707
		public INpcSpecialMarkIgnoreCameraHideNpcT()
		{
			this.Type = ESpecialNpcMarkType.TrafficLight;
		}
	}
}
