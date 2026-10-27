using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D9 RID: 27097
	public class IKiteHookInteractT
	{
		// Token: 0x1700C913 RID: 51475
		// (get) Token: 0x0602F5ED RID: 194029 RVA: 0x006735C4 File Offset: 0x006717C4
		// (set) Token: 0x0602F5EE RID: 194030 RVA: 0x006735CC File Offset: 0x006717CC
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C914 RID: 51476
		// (get) Token: 0x0602F5EF RID: 194031 RVA: 0x006735D5 File Offset: 0x006717D5
		// (set) Token: 0x0602F5F0 RID: 194032 RVA: 0x006735DD File Offset: 0x006717DD
		public int EntityId { get; set; }

		// Token: 0x0602F5F1 RID: 194033 RVA: 0x006735E6 File Offset: 0x006717E6
		public IKiteHookInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
		}
	}
}
