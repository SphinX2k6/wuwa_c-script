using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711F RID: 28959
	public class ILiveScOperationT
	{
		// Token: 0x1700D415 RID: 54293
		// (get) Token: 0x060324ED RID: 206061 RVA: 0x006CD55E File Offset: 0x006CB75E
		// (set) Token: 0x060324EE RID: 206062 RVA: 0x006CD566 File Offset: 0x006CB766
		public ELiveScOperationType Type { get; set; }

		// Token: 0x060324EF RID: 206063 RVA: 0x006CD56F File Offset: 0x006CB76F
		public ILiveScOperationT()
		{
			this.Type = ELiveScOperationType.Send;
		}
	}
}
