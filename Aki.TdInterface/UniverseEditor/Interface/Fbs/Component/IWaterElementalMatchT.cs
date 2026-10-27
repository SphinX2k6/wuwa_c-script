using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B51 RID: 23377
	public class IWaterElementalMatchT
	{
		// Token: 0x1700B08E RID: 45198
		// (get) Token: 0x06027FC1 RID: 163777 RVA: 0x0057F765 File Offset: 0x0057D965
		// (set) Token: 0x06027FC2 RID: 163778 RVA: 0x0057F76D File Offset: 0x0057D96D
		public EElementalType Type { get; set; }

		// Token: 0x1700B08F RID: 45199
		// (get) Token: 0x06027FC3 RID: 163779 RVA: 0x0057F776 File Offset: 0x0057D976
		// (set) Token: 0x06027FC4 RID: 163780 RVA: 0x0057F77E File Offset: 0x0057D97E
		public bool CanStagnate { get; set; }

		// Token: 0x1700B090 RID: 45200
		// (get) Token: 0x06027FC5 RID: 163781 RVA: 0x0057F787 File Offset: 0x0057D987
		// (set) Token: 0x06027FC6 RID: 163782 RVA: 0x0057F78F File Offset: 0x0057D98F
		public IWaterStagnationActorConfigT StagnationActorConfig { get; set; }

		// Token: 0x1700B091 RID: 45201
		// (get) Token: 0x06027FC7 RID: 163783 RVA: 0x0057F798 File Offset: 0x0057D998
		// (set) Token: 0x06027FC8 RID: 163784 RVA: 0x0057F7A0 File Offset: 0x0057D9A0
		public float StagnationImmuneDurationAfterHit { get; set; }

		// Token: 0x1700B092 RID: 45202
		// (get) Token: 0x06027FC9 RID: 163785 RVA: 0x0057F7A9 File Offset: 0x0057D9A9
		// (set) Token: 0x06027FCA RID: 163786 RVA: 0x0057F7B1 File Offset: 0x0057D9B1
		public byte NullMask { get; set; }

		// Token: 0x06027FCB RID: 163787 RVA: 0x0057F7BA File Offset: 0x0057D9BA
		public IWaterElementalMatchT()
		{
			this.Type = EElementalType.Fire;
			this.CanStagnate = false;
			this.StagnationActorConfig = null;
			this.StagnationImmuneDurationAfterHit = 0f;
			this.NullMask = 0;
		}
	}
}
