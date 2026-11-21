using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F60 RID: 20320
	public class ICheckIsInRideFlyingCarGameplayT
	{
		// Token: 0x1700913A RID: 37178
		// (get) Token: 0x0601F9F5 RID: 129525 RVA: 0x00465D8C File Offset: 0x00463F8C
		// (set) Token: 0x0601F9F6 RID: 129526 RVA: 0x00465D94 File Offset: 0x00463F94
		public ECondition Type { get; set; }

		// Token: 0x1700913B RID: 37179
		// (get) Token: 0x0601F9F7 RID: 129527 RVA: 0x00465D9D File Offset: 0x00463F9D
		// (set) Token: 0x0601F9F8 RID: 129528 RVA: 0x00465DA5 File Offset: 0x00463FA5
		public bool IsIn { get; set; }

		// Token: 0x0601F9F9 RID: 129529 RVA: 0x00465DAE File Offset: 0x00463FAE
		public ICheckIsInRideFlyingCarGameplayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
		}
	}
}
