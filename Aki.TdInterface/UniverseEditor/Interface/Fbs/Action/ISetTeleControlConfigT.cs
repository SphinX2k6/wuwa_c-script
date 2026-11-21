using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007858 RID: 30808
	public class ISetTeleControlConfigT
	{
		// Token: 0x1700E1FE RID: 57854
		// (get) Token: 0x060362F3 RID: 221939 RVA: 0x00742308 File Offset: 0x00740508
		// (set) Token: 0x060362F4 RID: 221940 RVA: 0x00742310 File Offset: 0x00740510
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700E1FF RID: 57855
		// (get) Token: 0x060362F5 RID: 221941 RVA: 0x00742319 File Offset: 0x00740519
		// (set) Token: 0x060362F6 RID: 221942 RVA: 0x00742321 File Offset: 0x00740521
		public int EntityId { get; set; }

		// Token: 0x060362F7 RID: 221943 RVA: 0x0074232A File Offset: 0x0074052A
		public ISetTeleControlConfigT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
		}
	}
}
