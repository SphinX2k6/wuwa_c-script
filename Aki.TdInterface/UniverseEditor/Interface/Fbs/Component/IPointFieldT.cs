using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005758 RID: 22360
	public class IPointFieldT
	{
		// Token: 0x1700A6CE RID: 42702
		// (get) Token: 0x06025785 RID: 153477 RVA: 0x0052B6CA File Offset: 0x005298CA
		// (set) Token: 0x06025786 RID: 153478 RVA: 0x0052B6D2 File Offset: 0x005298D2
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x06025787 RID: 153479 RVA: 0x0052B6DB File Offset: 0x005298DB
		public IPointFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
		}
	}
}
