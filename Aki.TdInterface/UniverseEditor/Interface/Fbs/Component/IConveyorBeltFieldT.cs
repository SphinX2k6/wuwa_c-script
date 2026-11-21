using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558D RID: 21901
	public class IConveyorBeltFieldT
	{
		// Token: 0x17009CDE RID: 40158
		// (get) Token: 0x06022D5B RID: 142683 RVA: 0x004CC7DE File Offset: 0x004CA9DE
		// (set) Token: 0x06022D5C RID: 142684 RVA: 0x004CC7E6 File Offset: 0x004CA9E6
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x06022D5D RID: 142685 RVA: 0x004CC7EF File Offset: 0x004CA9EF
		public IConveyorBeltFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
		}
	}
}
