using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E0 RID: 22240
	public class IEntityGroupComponentT
	{
		// Token: 0x1700A055 RID: 41045
		// (get) Token: 0x06023AF7 RID: 146167 RVA: 0x004E8343 File Offset: 0x004E6543
		// (set) Token: 0x06023AF8 RID: 146168 RVA: 0x004E834B File Offset: 0x004E654B
		public bool Disabled { get; set; }

		// Token: 0x1700A056 RID: 41046
		// (get) Token: 0x06023AF9 RID: 146169 RVA: 0x004E8354 File Offset: 0x004E6554
		// (set) Token: 0x06023AFA RID: 146170 RVA: 0x004E835C File Offset: 0x004E655C
		public List<int> EntityIds { get; set; }

		// Token: 0x1700A057 RID: 41047
		// (get) Token: 0x06023AFB RID: 146171 RVA: 0x004E8365 File Offset: 0x004E6565
		// (set) Token: 0x06023AFC RID: 146172 RVA: 0x004E836D File Offset: 0x004E656D
		public List<IEntityStateTriggerT> StateTriggers { get; set; }

		// Token: 0x1700A058 RID: 41048
		// (get) Token: 0x06023AFD RID: 146173 RVA: 0x004E8376 File Offset: 0x004E6576
		// (set) Token: 0x06023AFE RID: 146174 RVA: 0x004E837E File Offset: 0x004E657E
		public IFinishStateTriggerT FinishState { get; set; }

		// Token: 0x1700A059 RID: 41049
		// (get) Token: 0x06023AFF RID: 146175 RVA: 0x004E8387 File Offset: 0x004E6587
		// (set) Token: 0x06023B00 RID: 146176 RVA: 0x004E838F File Offset: 0x004E658F
		public IFailureStateTriggerT FailureState { get; set; }

		// Token: 0x1700A05A RID: 41050
		// (get) Token: 0x06023B01 RID: 146177 RVA: 0x004E8398 File Offset: 0x004E6598
		// (set) Token: 0x06023B02 RID: 146178 RVA: 0x004E83A0 File Offset: 0x004E65A0
		public byte NullMask { get; set; }

		// Token: 0x06023B03 RID: 146179 RVA: 0x004E83A9 File Offset: 0x004E65A9
		public IEntityGroupComponentT()
		{
			this.Disabled = false;
			this.EntityIds = null;
			this.StateTriggers = null;
			this.FinishState = null;
			this.FailureState = null;
			this.NullMask = 0;
		}
	}
}
