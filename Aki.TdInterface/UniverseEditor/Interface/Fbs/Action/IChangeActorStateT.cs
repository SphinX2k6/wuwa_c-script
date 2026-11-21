using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006938 RID: 26936
	public class IChangeActorStateT
	{
		// Token: 0x1700C64E RID: 50766
		// (get) Token: 0x0602E2B2 RID: 189106 RVA: 0x0064ECAD File Offset: 0x0064CEAD
		// (set) Token: 0x0602E2B3 RID: 189107 RVA: 0x0064ECB5 File Offset: 0x0064CEB5
		public string State { get; set; }

		// Token: 0x0602E2B4 RID: 189108 RVA: 0x0064ECBE File Offset: 0x0064CEBE
		public IChangeActorStateT()
		{
			this.State = null;
		}
	}
}
