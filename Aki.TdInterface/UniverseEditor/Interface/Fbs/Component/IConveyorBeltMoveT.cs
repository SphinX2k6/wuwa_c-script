using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005593 RID: 21907
	public class IConveyorBeltMoveT
	{
		// Token: 0x17009CE3 RID: 40163
		// (get) Token: 0x06022D7B RID: 142715 RVA: 0x004CCA9E File Offset: 0x004CAC9E
		// (set) Token: 0x06022D7C RID: 142716 RVA: 0x004CCAA6 File Offset: 0x004CACA6
		public EConveyorBeltMoveType Type { get; set; }

		// Token: 0x06022D7D RID: 142717 RVA: 0x004CCAAF File Offset: 0x004CACAF
		public IConveyorBeltMoveT()
		{
			this.Type = EConveyorBeltMoveType.FixSpeed;
		}
	}
}
