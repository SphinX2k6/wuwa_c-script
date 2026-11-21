using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F5A RID: 20314
	public class ICheckIsInDollGrabGamePlayT
	{
		// Token: 0x1700912F RID: 37167
		// (get) Token: 0x0601F9C7 RID: 129479 RVA: 0x0046595A File Offset: 0x00463B5A
		// (set) Token: 0x0601F9C8 RID: 129480 RVA: 0x00465962 File Offset: 0x00463B62
		public ECondition Type { get; set; }

		// Token: 0x17009130 RID: 37168
		// (get) Token: 0x0601F9C9 RID: 129481 RVA: 0x0046596B File Offset: 0x00463B6B
		// (set) Token: 0x0601F9CA RID: 129482 RVA: 0x00465973 File Offset: 0x00463B73
		public bool IsIn { get; set; }

		// Token: 0x17009131 RID: 37169
		// (get) Token: 0x0601F9CB RID: 129483 RVA: 0x0046597C File Offset: 0x00463B7C
		// (set) Token: 0x0601F9CC RID: 129484 RVA: 0x00465984 File Offset: 0x00463B84
		public int DollGrabEntityId { get; set; }

		// Token: 0x0601F9CD RID: 129485 RVA: 0x0046598D File Offset: 0x00463B8D
		public ICheckIsInDollGrabGamePlayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
			this.DollGrabEntityId = 0;
		}
	}
}
