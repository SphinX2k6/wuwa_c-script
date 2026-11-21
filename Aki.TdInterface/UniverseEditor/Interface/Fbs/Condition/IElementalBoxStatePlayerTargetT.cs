using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F2 RID: 20722
	public class IElementalBoxStatePlayerTargetT
	{
		// Token: 0x17009483 RID: 38019
		// (get) Token: 0x06020907 RID: 133383 RVA: 0x00484567 File Offset: 0x00482767
		// (set) Token: 0x06020908 RID: 133384 RVA: 0x0048456F File Offset: 0x0048276F
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17009484 RID: 38020
		// (get) Token: 0x06020909 RID: 133385 RVA: 0x00484578 File Offset: 0x00482778
		// (set) Token: 0x0602090A RID: 133386 RVA: 0x00484580 File Offset: 0x00482780
		public string State { get; set; }

		// Token: 0x0602090B RID: 133387 RVA: 0x00484589 File Offset: 0x00482789
		public IElementalBoxStatePlayerTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.State = null;
		}
	}
}
