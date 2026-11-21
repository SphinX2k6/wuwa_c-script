using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AFC RID: 19196
	public class ISetUnopenedAreaPullbackT
	{
		// Token: 0x17008686 RID: 34438
		// (get) Token: 0x0601CECA RID: 118474 RVA: 0x00411CCC File Offset: 0x0040FECC
		// (set) Token: 0x0601CECB RID: 118475 RVA: 0x00411CD4 File Offset: 0x0040FED4
		public EGmCommand Type { get; set; }

		// Token: 0x17008687 RID: 34439
		// (get) Token: 0x0601CECC RID: 118476 RVA: 0x00411CDD File Offset: 0x0040FEDD
		// (set) Token: 0x0601CECD RID: 118477 RVA: 0x00411CE5 File Offset: 0x0040FEE5
		public bool IsOpen { get; set; }

		// Token: 0x0601CECE RID: 118478 RVA: 0x00411CEE File Offset: 0x0040FEEE
		public ISetUnopenedAreaPullbackT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsOpen = false;
		}
	}
}
