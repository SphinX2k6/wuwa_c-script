using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E87 RID: 16007
	public class IFishDestroyStateT
	{
		// Token: 0x17006C25 RID: 27685
		// (get) Token: 0x0601598E RID: 88462 RVA: 0x0031CBFC File Offset: 0x0031ADFC
		// (set) Token: 0x0601598F RID: 88463 RVA: 0x0031CC04 File Offset: 0x0031AE04
		public EFishState Type { get; set; }

		// Token: 0x17006C26 RID: 27686
		// (get) Token: 0x06015990 RID: 88464 RVA: 0x0031CC0D File Offset: 0x0031AE0D
		// (set) Token: 0x06015991 RID: 88465 RVA: 0x0031CC15 File Offset: 0x0031AE15
		public float DissolveDuration { get; set; }

		// Token: 0x06015992 RID: 88466 RVA: 0x0031CC1E File Offset: 0x0031AE1E
		public IFishDestroyStateT()
		{
			this.Type = EFishState.Idle;
			this.DissolveDuration = 0f;
		}
	}
}
