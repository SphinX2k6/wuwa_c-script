using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005325 RID: 21285
	public class IGravityFlipConfigT
	{
		// Token: 0x17009C4E RID: 40014
		// (get) Token: 0x06022C88 RID: 142472 RVA: 0x004D1978 File Offset: 0x004CFB78
		// (set) Token: 0x06022C89 RID: 142473 RVA: 0x004D1980 File Offset: 0x004CFB80
		public EGravityFlipType Type { get; set; }

		// Token: 0x17009C4F RID: 40015
		// (get) Token: 0x06022C8A RID: 142474 RVA: 0x004D1989 File Offset: 0x004CFB89
		// (set) Token: 0x06022C8B RID: 142475 RVA: 0x004D1991 File Offset: 0x004CFB91
		public int LocationEntityId { get; set; }

		// Token: 0x06022C8C RID: 142476 RVA: 0x004D199A File Offset: 0x004CFB9A
		public IGravityFlipConfigT()
		{
			this.Type = EGravityFlipType.None;
			this.LocationEntityId = 0;
		}
	}
}
