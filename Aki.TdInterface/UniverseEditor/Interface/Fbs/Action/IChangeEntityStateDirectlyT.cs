using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006962 RID: 26978
	public class IChangeEntityStateDirectlyT
	{
		// Token: 0x1700C696 RID: 50838
		// (get) Token: 0x0602E404 RID: 189444 RVA: 0x00650ED9 File Offset: 0x0064F0D9
		// (set) Token: 0x0602E405 RID: 189445 RVA: 0x00650EE1 File Offset: 0x0064F0E1
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700C697 RID: 50839
		// (get) Token: 0x0602E406 RID: 189446 RVA: 0x00650EEA File Offset: 0x0064F0EA
		// (set) Token: 0x0602E407 RID: 189447 RVA: 0x00650EF2 File Offset: 0x0064F0F2
		public int EntityId { get; set; }

		// Token: 0x1700C698 RID: 50840
		// (get) Token: 0x0602E408 RID: 189448 RVA: 0x00650EFB File Offset: 0x0064F0FB
		// (set) Token: 0x0602E409 RID: 189449 RVA: 0x00650F03 File Offset: 0x0064F103
		public string State { get; set; }

		// Token: 0x1700C699 RID: 50841
		// (get) Token: 0x0602E40A RID: 189450 RVA: 0x00650F0C File Offset: 0x0064F10C
		// (set) Token: 0x0602E40B RID: 189451 RVA: 0x00650F14 File Offset: 0x0064F114
		public bool DelayChange { get; set; }

		// Token: 0x1700C69A RID: 50842
		// (get) Token: 0x0602E40C RID: 189452 RVA: 0x00650F1D File Offset: 0x0064F11D
		// (set) Token: 0x0602E40D RID: 189453 RVA: 0x00650F25 File Offset: 0x0064F125
		public byte NullMask { get; set; }

		// Token: 0x0602E40E RID: 189454 RVA: 0x00650F2E File Offset: 0x0064F12E
		public IChangeEntityStateDirectlyT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
			this.State = null;
			this.DelayChange = false;
			this.NullMask = 0;
		}
	}
}
