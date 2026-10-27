using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502E RID: 20526
	public class IConveyorBeltFieldT
	{
		// Token: 0x170094FD RID: 38141
		// (get) Token: 0x06020E3B RID: 134715 RVA: 0x00492D8E File Offset: 0x00490F8E
		// (set) Token: 0x06020E3C RID: 134716 RVA: 0x00492D96 File Offset: 0x00490F96
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x06020E3D RID: 134717 RVA: 0x00492D9F File Offset: 0x00490F9F
		public IConveyorBeltFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
		}
	}
}
