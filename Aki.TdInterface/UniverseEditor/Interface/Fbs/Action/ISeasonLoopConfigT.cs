using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F52 RID: 28498
	public class ISeasonLoopConfigT
	{
		// Token: 0x1700D3C3 RID: 54211
		// (get) Token: 0x06032593 RID: 206227 RVA: 0x006CC604 File Offset: 0x006CA804
		// (set) Token: 0x06032594 RID: 206228 RVA: 0x006CC60C File Offset: 0x006CA80C
		public float HoldTime { get; set; }

		// Token: 0x1700D3C4 RID: 54212
		// (get) Token: 0x06032595 RID: 206229 RVA: 0x006CC615 File Offset: 0x006CA815
		// (set) Token: 0x06032596 RID: 206230 RVA: 0x006CC61D File Offset: 0x006CA81D
		public float SwitchTime { get; set; }

		// Token: 0x06032597 RID: 206231 RVA: 0x006CC626 File Offset: 0x006CA826
		public ISeasonLoopConfigT()
		{
			this.HoldTime = 0f;
			this.SwitchTime = 0f;
		}
	}
}
