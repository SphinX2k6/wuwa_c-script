using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7E RID: 15998
	public class IEnergyFishStateConfigT
	{
		// Token: 0x17006C19 RID: 27673
		// (get) Token: 0x06015954 RID: 88404 RVA: 0x0031C667 File Offset: 0x0031A867
		// (set) Token: 0x06015955 RID: 88405 RVA: 0x0031C66F File Offset: 0x0031A86F
		public string State { get; set; }

		// Token: 0x17006C1A RID: 27674
		// (get) Token: 0x06015956 RID: 88406 RVA: 0x0031C678 File Offset: 0x0031A878
		// (set) Token: 0x06015957 RID: 88407 RVA: 0x0031C680 File Offset: 0x0031A880
		public TEnergyFishStateUnion Params { get; set; }

		// Token: 0x06015958 RID: 88408 RVA: 0x0031C689 File Offset: 0x0031A889
		public IEnergyFishStateConfigT()
		{
			this.State = null;
			this.Params = null;
		}
	}
}
