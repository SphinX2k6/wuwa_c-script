using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC9 RID: 20425
	public class ICheckPlayerIsInDeadEyeProcessT
	{
		// Token: 0x17009219 RID: 37401
		// (get) Token: 0x0601FD8F RID: 130447 RVA: 0x0046C5F0 File Offset: 0x0046A7F0
		// (set) Token: 0x0601FD90 RID: 130448 RVA: 0x0046C5F8 File Offset: 0x0046A7F8
		public ECondition Type { get; set; }

		// Token: 0x1700921A RID: 37402
		// (get) Token: 0x0601FD91 RID: 130449 RVA: 0x0046C601 File Offset: 0x0046A801
		// (set) Token: 0x0601FD92 RID: 130450 RVA: 0x0046C609 File Offset: 0x0046A809
		public bool IsInDeadEyeProcess { get; set; }

		// Token: 0x0601FD93 RID: 130451 RVA: 0x0046C612 File Offset: 0x0046A812
		public ICheckPlayerIsInDeadEyeProcessT()
		{
			this.Type = ECondition.CompareVar;
			this.IsInDeadEyeProcess = false;
		}
	}
}
