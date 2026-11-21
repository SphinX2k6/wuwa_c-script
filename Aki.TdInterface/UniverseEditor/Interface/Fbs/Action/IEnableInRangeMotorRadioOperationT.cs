using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDE RID: 27870
	public class IEnableInRangeMotorRadioOperationT
	{
		// Token: 0x1700CC68 RID: 52328
		// (get) Token: 0x060300AC RID: 196780 RVA: 0x006895AF File Offset: 0x006877AF
		// (set) Token: 0x060300AD RID: 196781 RVA: 0x006895B7 File Offset: 0x006877B7
		public EMotorRadioOperationType Type { get; set; }

		// Token: 0x1700CC69 RID: 52329
		// (get) Token: 0x060300AE RID: 196782 RVA: 0x006895C0 File Offset: 0x006877C0
		// (set) Token: 0x060300AF RID: 196783 RVA: 0x006895C8 File Offset: 0x006877C8
		public string RangeKey { get; set; }

		// Token: 0x060300B0 RID: 196784 RVA: 0x006895D1 File Offset: 0x006877D1
		public IEnableInRangeMotorRadioOperationT()
		{
			this.Type = EMotorRadioOperationType.EnableAll;
			this.RangeKey = null;
		}
	}
}
