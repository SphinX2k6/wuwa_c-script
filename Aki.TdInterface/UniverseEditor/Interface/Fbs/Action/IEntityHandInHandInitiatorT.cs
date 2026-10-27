using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DC RID: 26332
	public class IEntityHandInHandInitiatorT
	{
		// Token: 0x1700C39F RID: 50079
		// (get) Token: 0x0602DC71 RID: 187505 RVA: 0x00642C38 File Offset: 0x00640E38
		// (set) Token: 0x0602DC72 RID: 187506 RVA: 0x00642C40 File Offset: 0x00640E40
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x1700C3A0 RID: 50080
		// (get) Token: 0x0602DC73 RID: 187507 RVA: 0x00642C49 File Offset: 0x00640E49
		// (set) Token: 0x0602DC74 RID: 187508 RVA: 0x00642C51 File Offset: 0x00640E51
		public int EntityId { get; set; }

		// Token: 0x0602DC75 RID: 187509 RVA: 0x00642C5A File Offset: 0x00640E5A
		public IEntityHandInHandInitiatorT()
		{
			this.Type = EHandInHandInitiatorType.Player;
			this.EntityId = 0;
		}
	}
}
