using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D87 RID: 28039
	public class IPrefabConfigT
	{
		// Token: 0x1700D132 RID: 53554
		// (get) Token: 0x06031880 RID: 202880 RVA: 0x006B6C08 File Offset: 0x006B4E08
		// (set) Token: 0x06031881 RID: 202881 RVA: 0x006B6C10 File Offset: 0x006B4E10
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700D133 RID: 53555
		// (get) Token: 0x06031882 RID: 202882 RVA: 0x006B6C19 File Offset: 0x006B4E19
		// (set) Token: 0x06031883 RID: 202883 RVA: 0x006B6C21 File Offset: 0x006B4E21
		public int PrefabId { get; set; }

		// Token: 0x06031884 RID: 202884 RVA: 0x006B6C2A File Offset: 0x006B4E2A
		public IPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.PrefabId = 0;
		}
	}
}
