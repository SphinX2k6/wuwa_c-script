using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA4 RID: 27300
	public class IMinAlertValueT
	{
		// Token: 0x1700CA9C RID: 51868
		// (get) Token: 0x0602FD72 RID: 195954 RVA: 0x006821D2 File Offset: 0x006803D2
		// (set) Token: 0x0602FD73 RID: 195955 RVA: 0x006821DA File Offset: 0x006803DA
		public EValueChangeType Type { get; set; }

		// Token: 0x0602FD74 RID: 195956 RVA: 0x006821E3 File Offset: 0x006803E3
		public IMinAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
		}
	}
}
