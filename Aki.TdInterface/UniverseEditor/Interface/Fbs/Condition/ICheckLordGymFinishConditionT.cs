using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F96 RID: 20374
	public class ICheckLordGymFinishConditionT
	{
		// Token: 0x170091B7 RID: 37303
		// (get) Token: 0x0601FBD9 RID: 130009 RVA: 0x004692F0 File Offset: 0x004674F0
		// (set) Token: 0x0601FBDA RID: 130010 RVA: 0x004692F8 File Offset: 0x004674F8
		public ECondition Type { get; set; }

		// Token: 0x170091B8 RID: 37304
		// (get) Token: 0x0601FBDB RID: 130011 RVA: 0x00469301 File Offset: 0x00467501
		// (set) Token: 0x0601FBDC RID: 130012 RVA: 0x00469309 File Offset: 0x00467509
		public int LordGymId { get; set; }

		// Token: 0x0601FBDD RID: 130013 RVA: 0x00469312 File Offset: 0x00467512
		public ICheckLordGymFinishConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.LordGymId = 0;
		}
	}
}
