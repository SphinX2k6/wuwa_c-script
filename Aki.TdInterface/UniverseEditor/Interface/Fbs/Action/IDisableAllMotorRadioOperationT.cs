using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C39 RID: 27705
	public class IDisableAllMotorRadioOperationT
	{
		// Token: 0x1700CAFD RID: 51965
		// (get) Token: 0x0602FACA RID: 195274 RVA: 0x0067E636 File Offset: 0x0067C836
		// (set) Token: 0x0602FACB RID: 195275 RVA: 0x0067E63E File Offset: 0x0067C83E
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x0602FACC RID: 195276 RVA: 0x0067E647 File Offset: 0x0067C847
		public IDisableAllMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
		}
	}
}
