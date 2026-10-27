using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693A RID: 26938
	public class IHookLockInteractT
	{
		// Token: 0x1700C7DE RID: 51166
		// (get) Token: 0x0602F09A RID: 192666 RVA: 0x006698D4 File Offset: 0x00667AD4
		// (set) Token: 0x0602F09B RID: 192667 RVA: 0x006698DC File Offset: 0x00667ADC
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C7DF RID: 51167
		// (get) Token: 0x0602F09C RID: 192668 RVA: 0x006698E5 File Offset: 0x00667AE5
		// (set) Token: 0x0602F09D RID: 192669 RVA: 0x006698ED File Offset: 0x00667AED
		public int EntityId { get; set; }

		// Token: 0x0602F09E RID: 192670 RVA: 0x006698F6 File Offset: 0x00667AF6
		public IHookLockInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
		}
	}
}
