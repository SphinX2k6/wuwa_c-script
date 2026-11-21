using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006989 RID: 27017
	public class IChangePhantomFormationT
	{
		// Token: 0x1700C6EA RID: 50922
		// (get) Token: 0x0602E574 RID: 189812 RVA: 0x006538F9 File Offset: 0x00651AF9
		// (set) Token: 0x0602E575 RID: 189813 RVA: 0x00653901 File Offset: 0x00651B01
		public int FormationId { get; set; }

		// Token: 0x1700C6EB RID: 50923
		// (get) Token: 0x0602E576 RID: 189814 RVA: 0x0065390A File Offset: 0x00651B0A
		// (set) Token: 0x0602E577 RID: 189815 RVA: 0x00653912 File Offset: 0x00651B12
		public bool RetainRole { get; set; }

		// Token: 0x1700C6EC RID: 50924
		// (get) Token: 0x0602E578 RID: 189816 RVA: 0x0065391B File Offset: 0x00651B1B
		// (set) Token: 0x0602E579 RID: 189817 RVA: 0x00653923 File Offset: 0x00651B23
		public int TeleportEntityId { get; set; }

		// Token: 0x1700C6ED RID: 50925
		// (get) Token: 0x0602E57A RID: 189818 RVA: 0x0065392C File Offset: 0x00651B2C
		// (set) Token: 0x0602E57B RID: 189819 RVA: 0x00653934 File Offset: 0x00651B34
		public List<long> AppendBuffIds { get; set; }

		// Token: 0x1700C6EE RID: 50926
		// (get) Token: 0x0602E57C RID: 189820 RVA: 0x0065393D File Offset: 0x00651B3D
		// (set) Token: 0x0602E57D RID: 189821 RVA: 0x00653945 File Offset: 0x00651B45
		public byte NullMask { get; set; }

		// Token: 0x0602E57E RID: 189822 RVA: 0x0065394E File Offset: 0x00651B4E
		public IChangePhantomFormationT()
		{
			this.FormationId = 0;
			this.RetainRole = false;
			this.TeleportEntityId = 0;
			this.AppendBuffIds = null;
			this.NullMask = 0;
		}
	}
}
