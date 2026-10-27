using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E4 RID: 23012
	public class ISuccessConditionCountDownStateT
	{
		// Token: 0x1700ACE3 RID: 44259
		// (get) Token: 0x060270AC RID: 159916 RVA: 0x0055F212 File Offset: 0x0055D412
		// (set) Token: 0x060270AD RID: 159917 RVA: 0x0055F21A File Offset: 0x0055D41A
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x060270AE RID: 159918 RVA: 0x0055F223 File Offset: 0x0055D423
		public ISuccessConditionCountDownStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}
