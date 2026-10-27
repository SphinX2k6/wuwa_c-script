using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064FF RID: 25855
	public class ICustomScreenLoadingT
	{
		// Token: 0x1700C04D RID: 49229
		// (get) Token: 0x0602CDAB RID: 183723 RVA: 0x00629703 File Offset: 0x00627903
		// (set) Token: 0x0602CDAC RID: 183724 RVA: 0x0062970B File Offset: 0x0062790B
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C04E RID: 49230
		// (get) Token: 0x0602CDAD RID: 183725 RVA: 0x00629714 File Offset: 0x00627914
		// (set) Token: 0x0602CDAE RID: 183726 RVA: 0x0062971C File Offset: 0x0062791C
		public ICustomScreenLoadingCyberpunkT LoadingType { get; set; }

		// Token: 0x0602CDAF RID: 183727 RVA: 0x00629725 File Offset: 0x00627925
		public ICustomScreenLoadingT()
		{
			this.Type = ECustomScreenType.Spine;
			this.LoadingType = null;
		}
	}
}
