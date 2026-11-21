using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D5F RID: 23903
	public class IPointFieldT
	{
		// Token: 0x1700AFF2 RID: 45042
		// (get) Token: 0x06027CA5 RID: 162981 RVA: 0x00571856 File Offset: 0x0056FA56
		// (set) Token: 0x06027CA6 RID: 162982 RVA: 0x0057185E File Offset: 0x0056FA5E
		public EConveyorBeltFieldType Type { get; set; }

		// Token: 0x06027CA7 RID: 162983 RVA: 0x00571867 File Offset: 0x0056FA67
		public IPointFieldT()
		{
			this.Type = EConveyorBeltFieldType.DirectionalField;
		}
	}
}
