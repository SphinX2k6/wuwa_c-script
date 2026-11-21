using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FCC RID: 20428
	public class ICheckPlayerIsInMotorcycleCruiseT
	{
		// Token: 0x1700921E RID: 37406
		// (get) Token: 0x0601FDA5 RID: 130469 RVA: 0x0046C7F0 File Offset: 0x0046A9F0
		// (set) Token: 0x0601FDA6 RID: 130470 RVA: 0x0046C7F8 File Offset: 0x0046A9F8
		public ECondition Type { get; set; }

		// Token: 0x1700921F RID: 37407
		// (get) Token: 0x0601FDA7 RID: 130471 RVA: 0x0046C801 File Offset: 0x0046AA01
		// (set) Token: 0x0601FDA8 RID: 130472 RVA: 0x0046C809 File Offset: 0x0046AA09
		public bool IsInMotorcycleCruise { get; set; }

		// Token: 0x0601FDA9 RID: 130473 RVA: 0x0046C812 File Offset: 0x0046AA12
		public ICheckPlayerIsInMotorcycleCruiseT()
		{
			this.Type = ECondition.CompareVar;
			this.IsInMotorcycleCruise = false;
		}
	}
}
