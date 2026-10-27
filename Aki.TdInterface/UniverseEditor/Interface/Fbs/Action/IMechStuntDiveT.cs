using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A95 RID: 27285
	public class IMechStuntDiveT
	{
		// Token: 0x1700CA8B RID: 51851
		// (get) Token: 0x0602FD14 RID: 195860 RVA: 0x00681966 File Offset: 0x0067FB66
		// (set) Token: 0x0602FD15 RID: 195861 RVA: 0x0068196E File Offset: 0x0067FB6E
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FD16 RID: 195862 RVA: 0x00681977 File Offset: 0x0067FB77
		public IMechStuntDiveT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
