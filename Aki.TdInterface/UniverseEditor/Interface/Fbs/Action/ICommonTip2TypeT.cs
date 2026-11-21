using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF2 RID: 27378
	public class ICommonTip2TypeT
	{
		// Token: 0x1700C917 RID: 51479
		// (get) Token: 0x0602F11A RID: 192794 RVA: 0x0066BD26 File Offset: 0x00669F26
		// (set) Token: 0x0602F11B RID: 192795 RVA: 0x0066BD2E File Offset: 0x00669F2E
		public ECommonTip2Type Type { get; set; }

		// Token: 0x0602F11C RID: 192796 RVA: 0x0066BD37 File Offset: 0x00669F37
		public ICommonTip2TypeT()
		{
			this.Type = ECommonTip2Type.PrepareCountdown;
		}
	}
}
