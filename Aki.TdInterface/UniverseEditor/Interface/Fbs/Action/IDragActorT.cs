using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C78 RID: 27768
	public class IDragActorT
	{
		// Token: 0x1700CBAD RID: 52141
		// (get) Token: 0x0602FD6C RID: 195948 RVA: 0x00683CE4 File Offset: 0x00681EE4
		// (set) Token: 0x0602FD6D RID: 195949 RVA: 0x00683CEC File Offset: 0x00681EEC
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CBAE RID: 52142
		// (get) Token: 0x0602FD6E RID: 195950 RVA: 0x00683CF5 File Offset: 0x00681EF5
		// (set) Token: 0x0602FD6F RID: 195951 RVA: 0x00683CFD File Offset: 0x00681EFD
		public int TargetEntityId { get; set; }

		// Token: 0x0602FD70 RID: 195952 RVA: 0x00683D06 File Offset: 0x00681F06
		public IDragActorT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.TargetEntityId = 0;
		}
	}
}
