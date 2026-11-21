using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9C RID: 23196
	public class ILookAtTargetEntityT
	{
		// Token: 0x1700A909 RID: 43273
		// (get) Token: 0x0602605F RID: 155743 RVA: 0x005360B0 File Offset: 0x005342B0
		// (set) Token: 0x06026060 RID: 155744 RVA: 0x005360B8 File Offset: 0x005342B8
		public ELookAtTargetType Type { get; set; }

		// Token: 0x1700A90A RID: 43274
		// (get) Token: 0x06026061 RID: 155745 RVA: 0x005360C1 File Offset: 0x005342C1
		// (set) Token: 0x06026062 RID: 155746 RVA: 0x005360C9 File Offset: 0x005342C9
		public int EntityId { get; set; }

		// Token: 0x06026063 RID: 155747 RVA: 0x005360D2 File Offset: 0x005342D2
		public ILookAtTargetEntityT()
		{
			this.Type = ELookAtTargetType.Entity;
			this.EntityId = 0;
		}
	}
}
