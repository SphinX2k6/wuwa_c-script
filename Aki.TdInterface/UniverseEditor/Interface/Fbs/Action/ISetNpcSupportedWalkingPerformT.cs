using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780D RID: 30733
	public class ISetNpcSupportedWalkingPerformT
	{
		// Token: 0x1700E14B RID: 57675
		// (get) Token: 0x0603601B RID: 221211 RVA: 0x0073BF85 File Offset: 0x0073A185
		// (set) Token: 0x0603601C RID: 221212 RVA: 0x0073BF8D File Offset: 0x0073A18D
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700E14C RID: 57676
		// (get) Token: 0x0603601D RID: 221213 RVA: 0x0073BF96 File Offset: 0x0073A196
		// (set) Token: 0x0603601E RID: 221214 RVA: 0x0073BF9E File Offset: 0x0073A19E
		public IPlayerInitiatorT Initiator { get; set; }

		// Token: 0x1700E14D RID: 57677
		// (get) Token: 0x0603601F RID: 221215 RVA: 0x0073BFA7 File Offset: 0x0073A1A7
		// (set) Token: 0x06036020 RID: 221216 RVA: 0x0073BFAF File Offset: 0x0073A1AF
		public int Target { get; set; }

		// Token: 0x06036021 RID: 221217 RVA: 0x0073BFB8 File Offset: 0x0073A1B8
		public ISetNpcSupportedWalkingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Initiator = null;
			this.Target = 0;
		}
	}
}
