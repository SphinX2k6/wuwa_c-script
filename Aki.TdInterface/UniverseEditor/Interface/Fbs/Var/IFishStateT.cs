using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E96 RID: 16022
	public class IFishStateT
	{
		// Token: 0x17006C5D RID: 27741
		// (get) Token: 0x06015A44 RID: 88644 RVA: 0x0031E386 File Offset: 0x0031C586
		// (set) Token: 0x06015A45 RID: 88645 RVA: 0x0031E38E File Offset: 0x0031C58E
		public EFishState Type { get; set; }

		// Token: 0x06015A46 RID: 88646 RVA: 0x0031E397 File Offset: 0x0031C597
		public IFishStateT()
		{
			this.Type = EFishState.Idle;
		}
	}
}
