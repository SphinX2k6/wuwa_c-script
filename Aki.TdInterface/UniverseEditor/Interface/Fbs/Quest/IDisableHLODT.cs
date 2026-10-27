using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD4 RID: 15828
	public class IDisableHLODT
	{
		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x060161A7 RID: 90535 RVA: 0x00331EE0 File Offset: 0x003300E0
		// (set) Token: 0x060161A8 RID: 90536 RVA: 0x00331EE8 File Offset: 0x003300E8
		public EOperation Type { get; set; }

		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x060161A9 RID: 90537 RVA: 0x00331EF1 File Offset: 0x003300F1
		// (set) Token: 0x060161AA RID: 90538 RVA: 0x00331EF9 File Offset: 0x003300F9
		public bool IsDisable { get; set; }

		// Token: 0x060161AB RID: 90539 RVA: 0x00331F02 File Offset: 0x00330102
		public IDisableHLODT()
		{
			this.Type = EOperation.DisableHLOD;
			this.IsDisable = false;
		}
	}
}
