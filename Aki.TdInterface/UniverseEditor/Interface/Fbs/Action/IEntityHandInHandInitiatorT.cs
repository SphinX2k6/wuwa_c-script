using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5C RID: 27996
	public class IEntityHandInHandInitiatorT
	{
		// Token: 0x1700CD55 RID: 52565
		// (get) Token: 0x060304AE RID: 197806 RVA: 0x006901AC File Offset: 0x0068E3AC
		// (set) Token: 0x060304AF RID: 197807 RVA: 0x006901B4 File Offset: 0x0068E3B4
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x1700CD56 RID: 52566
		// (get) Token: 0x060304B0 RID: 197808 RVA: 0x006901BD File Offset: 0x0068E3BD
		// (set) Token: 0x060304B1 RID: 197809 RVA: 0x006901C5 File Offset: 0x0068E3C5
		public int EntityId { get; set; }

		// Token: 0x060304B2 RID: 197810 RVA: 0x006901CE File Offset: 0x0068E3CE
		public IEntityHandInHandInitiatorT()
		{
			this.Type = EHandInHandInitiatorType.Player;
			this.EntityId = 0;
		}
	}
}
