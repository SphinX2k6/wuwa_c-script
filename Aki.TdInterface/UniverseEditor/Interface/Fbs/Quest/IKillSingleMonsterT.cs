using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ECD RID: 16077
	public class IKillSingleMonsterT
	{
		// Token: 0x17006FA2 RID: 28578
		// (get) Token: 0x06016BD7 RID: 93143 RVA: 0x00348830 File Offset: 0x00346A30
		// (set) Token: 0x06016BD8 RID: 93144 RVA: 0x00348838 File Offset: 0x00346A38
		public int EntityId { get; set; }

		// Token: 0x17006FA3 RID: 28579
		// (get) Token: 0x06016BD9 RID: 93145 RVA: 0x00348841 File Offset: 0x00346A41
		// (set) Token: 0x06016BDA RID: 93146 RVA: 0x00348849 File Offset: 0x00346A49
		public int AddTime { get; set; }

		// Token: 0x06016BDB RID: 93147 RVA: 0x00348852 File Offset: 0x00346A52
		public IKillSingleMonsterT()
		{
			this.EntityId = 0;
			this.AddTime = 0;
		}
	}
}
