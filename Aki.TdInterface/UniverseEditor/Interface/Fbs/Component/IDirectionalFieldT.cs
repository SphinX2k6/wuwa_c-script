using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F0 RID: 22000
	public class IDirectionalFieldT
	{
		// Token: 0x17009DA9 RID: 40361
		// (get) Token: 0x060230CB RID: 143563 RVA: 0x004D3317 File Offset: 0x004D1517
		// (set) Token: 0x060230CC RID: 143564 RVA: 0x004D331F File Offset: 0x004D151F
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x17009DAA RID: 40362
		// (get) Token: 0x060230CD RID: 143565 RVA: 0x004D3328 File Offset: 0x004D1528
		// (set) Token: 0x060230CE RID: 143566 RVA: 0x004D3330 File Offset: 0x004D1530
		public IVectorInfoT Direction { get; set; }

		// Token: 0x060230CF RID: 143567 RVA: 0x004D3339 File Offset: 0x004D1539
		public IDirectionalFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
			this.Direction = null;
		}
	}
}
