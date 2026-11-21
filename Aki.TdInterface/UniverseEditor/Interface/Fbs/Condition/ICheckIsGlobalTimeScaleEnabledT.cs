using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F51 RID: 20305
	public class ICheckIsGlobalTimeScaleEnabledT
	{
		// Token: 0x1700911D RID: 37149
		// (get) Token: 0x0601F97F RID: 129407 RVA: 0x004651E0 File Offset: 0x004633E0
		// (set) Token: 0x0601F980 RID: 129408 RVA: 0x004651E8 File Offset: 0x004633E8
		public ECondition Type { get; set; }

		// Token: 0x1700911E RID: 37150
		// (get) Token: 0x0601F981 RID: 129409 RVA: 0x004651F1 File Offset: 0x004633F1
		// (set) Token: 0x0601F982 RID: 129410 RVA: 0x004651F9 File Offset: 0x004633F9
		public bool Enabled { get; set; }

		// Token: 0x0601F983 RID: 129411 RVA: 0x00465202 File Offset: 0x00463402
		public ICheckIsGlobalTimeScaleEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.Enabled = false;
		}
	}
}
