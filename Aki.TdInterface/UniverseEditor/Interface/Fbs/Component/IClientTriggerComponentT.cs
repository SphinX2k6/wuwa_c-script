using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FAD RID: 20397
	public class IClientTriggerComponentT
	{
		// Token: 0x170093B9 RID: 37817
		// (get) Token: 0x0602076B RID: 132971 RVA: 0x0048455E File Offset: 0x0048275E
		// (set) Token: 0x0602076C RID: 132972 RVA: 0x00484566 File Offset: 0x00482766
		public bool Disabled { get; set; }

		// Token: 0x170093BA RID: 37818
		// (get) Token: 0x0602076D RID: 132973 RVA: 0x0048456F File Offset: 0x0048276F
		// (set) Token: 0x0602076E RID: 132974 RVA: 0x00484577 File Offset: 0x00482777
		public ITriggerMatchConfigT TriggerMatch { get; set; }

		// Token: 0x170093BB RID: 37819
		// (get) Token: 0x0602076F RID: 132975 RVA: 0x00484580 File Offset: 0x00482780
		// (set) Token: 0x06020770 RID: 132976 RVA: 0x00484588 File Offset: 0x00482788
		public ITriggeredConfigT OnTriggerEnter { get; set; }

		// Token: 0x170093BC RID: 37820
		// (get) Token: 0x06020771 RID: 132977 RVA: 0x00484591 File Offset: 0x00482791
		// (set) Token: 0x06020772 RID: 132978 RVA: 0x00484599 File Offset: 0x00482799
		public ITriggeredConfigT OnTriggerExit { get; set; }

		// Token: 0x170093BD RID: 37821
		// (get) Token: 0x06020773 RID: 132979 RVA: 0x004845A2 File Offset: 0x004827A2
		// (set) Token: 0x06020774 RID: 132980 RVA: 0x004845AA File Offset: 0x004827AA
		public byte NullMask { get; set; }

		// Token: 0x06020775 RID: 132981 RVA: 0x004845B3 File Offset: 0x004827B3
		public IClientTriggerComponentT()
		{
			this.Disabled = false;
			this.TriggerMatch = null;
			this.OnTriggerEnter = null;
			this.OnTriggerExit = null;
			this.NullMask = 0;
		}
	}
}
