using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062DC RID: 25308
	public class IChangeElementalBoxStateTargetBoxIdT
	{
		// Token: 0x1700BCE6 RID: 48358
		// (get) Token: 0x0602BBF3 RID: 179187 RVA: 0x00604DD0 File Offset: 0x00602FD0
		// (set) Token: 0x0602BBF4 RID: 179188 RVA: 0x00604DD8 File Offset: 0x00602FD8
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x1700BCE7 RID: 48359
		// (get) Token: 0x0602BBF5 RID: 179189 RVA: 0x00604DE1 File Offset: 0x00602FE1
		// (set) Token: 0x0602BBF6 RID: 179190 RVA: 0x00604DE9 File Offset: 0x00602FE9
		public int TargetBoxId { get; set; }

		// Token: 0x0602BBF7 RID: 179191 RVA: 0x00604DF2 File Offset: 0x00602FF2
		public IChangeElementalBoxStateTargetBoxIdT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
			this.TargetBoxId = 0;
		}
	}
}
